﻿using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Event;
using RSBot.Core.Network;
using RSBot.Core.Network.Protocol;
using RSBot.General.Models;

namespace RSBot.General.Components;

/// <summary>
/// Handles automated login functionality including server selection, credentials, and game entry
/// </summary>
internal static class AutoLogin
{
    /// <summary>
    /// Gets or sets whether auto login is currently pending
    /// </summary>
    public static bool Pending;

    /// <summary>
    /// Gets or sets whether auto login is currently processing
    /// </summary>
    private static bool _busy;

    /// <summary>
    /// Handles the automated login process
    /// </summary>
    public static async void Handle()
    {
        if (Pending)
            return;

        if (_busy)
            return;

        Log.StatusLang("WaitingUser");

        _busy = true;

        if (!GlobalConfig.Get<bool>("RSBot.General.EnableAutomatedLogin"))
        {
            _busy = false;

            await Task.Delay(5000);
            ClientlessManager.RequestServerList();
            return;
        }

        var selectedAccount = Accounts.SavedAccounts?.Find(p =>
            p.Username == GlobalConfig.Get<string>("RSBot.General.AutoLoginAccountUsername"));
        if (selectedAccount == null)
        {
            _busy = false;
            Log.WarnLang("NoHaveAccountForAutoLogin");
            await Task.Delay(5000);
            ClientlessManager.RequestServerList();
            return;
        }

        var server = Serverlist.GetServerByName(selectedAccount.Servername);
        if (server == null && Serverlist.Servers != null)
        {
            Log.NotifyLang("ServerNotFound", selectedAccount.Servername);

            server = Serverlist.Servers.First();

            Log.NotifyLang("SelectedFirstServer", server.Name);
        }

        // Check if server is online
        if (!server.Status)
        {
            _busy = false;

            Log.NotifyLang("ServerCheck");

            await Task.Delay(5000);
            ClientlessManager.RequestServerList();

            return;
        }

        //Wait for the configured delay before sending the login request
        if (GlobalConfig.Get("RSBot.General.EnableLoginDelay", false))
        {
            var delay = GlobalConfig.Get("RSBot.General.LoginDelay", 10) * 1000;
            await Task.Delay(delay);
        }

        SendLoginRequest(selectedAccount, server);
    }

    /// <summary>
    /// Sends the secondary password if configured
    /// </summary>
    internal static void SendSecondaryPassword()
    {
        if (Accounts.Joined == null)
            return;

        if (!GlobalConfig.Get<bool>("RSBot.General.EnableAutomatedLogin"))
            return;

        var secondaryPassword = Accounts.Joined.SecondaryPassword;

        if (string.IsNullOrWhiteSpace(secondaryPassword))
            return;

        Blowfish blowfish = new();
        byte[] key = { 0x0F, 0x07, 0x3D, 0x20, 0x56, 0x62, 0xC9, 0xEB };

        if (Game.ClientType == GameClientType.Rigid)
            key = [.. key.Reverse()];

        blowfish.Initialize(key);

        var encodedBuffer = blowfish.Encode(Encoding.ASCII.GetBytes(secondaryPassword));

        var packet = new Packet(0x6117, true);
        packet.WriteByte(4);
        packet.WriteUShort(secondaryPassword.Length);
        packet.WriteBytes(encodedBuffer);
        PacketManager.SendPacket(packet, PacketDestination.Server);
    }

    /// <summary>
    /// Sends the login request with account credentials
    /// </summary>
    /// <param name="account">The account to log in with</param>
    /// <param name="server">The server to connect to</param>
    private static void SendLoginRequest(Account account, Models.Server server)
    {
        Log.NotifyLang("LoginCredentials", server.Name);

        ushort opcode = 0x6102;
        if (Game.ClientType >= GameClientType.Global)
            opcode = 0x610A;

        var loginPacket = new Packet(opcode, true);
        loginPacket.WriteByte(Game.ReferenceManager.DivisionInfo.Locale);
        loginPacket.WriteString(account.Username);
        loginPacket.WriteString(account.Password);

        if (Game.ClientType == GameClientType.Turkey ||
            Game.ClientType == GameClientType.VTC_Game)
            loginPacket.WriteBytes(new byte[6]); // mac

        loginPacket.WriteUShort(server.Id);

        if (opcode == 0x610A)
            loginPacket.WriteByte(account.Channel);

        PacketManager.SendPacket(loginPacket, PacketDestination.Server);

        Accounts.Joined = account;
        Serverlist.Joining = server;

        _busy = false;
    }

    /// <summary>
    /// Sends the static captcha response if enabled
    /// </summary>
    public static void SendStaticCaptcha()
    {
        if (!GlobalConfig.Get<bool>("RSBot.General.EnableStaticCaptcha") ||
            !GlobalConfig.Get<bool>("RSBot.General.EnableAutomatedLogin")) return;

        var captcha = GlobalConfig.Get<string>("RSBot.General.StaticCaptcha");
        captcha ??= string.Empty;

        Log.NotifyLang("EnteringCaptcha", captcha);

        var packet = new Packet(0x6323);
        packet.WriteString(captcha);

        PacketManager.SendPacket(packet, PacketDestination.Server);
    }

    /// <summary>
    /// Enters the game with the specified character
    /// </summary>
    /// <param name="character">The character name to enter with</param>
    public static void EnterGame(string character)
    {
        if (!GlobalConfig.Get<bool>("RSBot.General.EnableAutomatedLogin"))
            return;

        var packet = new Packet(0x7001);
        packet.WriteString(character);
        PacketManager.SendPacket(packet, PacketDestination.Server);

        PlayerConfig.Load(character);

        EventManager.FireEvent("OnEnterGame");
    }
}