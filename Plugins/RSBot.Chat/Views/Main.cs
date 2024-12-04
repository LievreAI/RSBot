using System;
using System.ComponentModel;

using RSBot.Core;
using RSBot.Core.Event;
using RSBot.Core.Objects;
using SDUI;

namespace RSBot.Chat.Views;

[ToolboxItem(false)]
public partial class Main : Panel
{
    public Main()
    {
        InitializeComponent();

        SubscribeEvents();
    }

    /// <summary>
    ///     Subscribes the events.
    /// </summary>
    private void SubscribeEvents()
    {
        EventManager.SubscribeEvent("OnEnterGame", OnEnterGame);
    }

    /// <summary>
    ///     Sends the chat message.
    /// </summary>
    /// <param name="sender">The sender.</param>
    private void SendChatMessage(Control sender)
    {
        if (!Enum.TryParse<ChatType>(sender.Tag.ToString(), out var chatType))
            return;

        Bundle.Chat.SendChatPacket(chatType, sender.Text, txtRecievePrivate.Text);

        if (chatType == ChatType.Private)
            PlayerConfig.Set("RSBot.Chat.LastWhisper", txtRecievePrivate.Text);
    }

    /// <summary>
    ///     Appends the message.
    /// </summary>
    /// <param name="message">The message.</param>
    /// <param name="sender">The sender.</param>
    /// <param name="type">The type.</param>
    public void AppendMessage(string message, string sender, ChatType type)
    {
        message = $"({sender}): {message}";

        switch (type)
        {
            case ChatType.Academy:
                txtAcademy.Text += message + Environment.NewLine;
                break;

            case ChatType.All:
                txtAll.Text += message + Environment.NewLine;
                break;

            case ChatType.AllGM:
                txtAll.Text += message + Environment.NewLine;
                break;

            case ChatType.Global:
                txtGlobal.Text += message + Environment.NewLine;
                break;

            case ChatType.Guild:
                txtGuild.Text += message + Environment.NewLine;
                break;

            case ChatType.Notice:
                txtGlobal.Text += message + Environment.NewLine;
                break;

            case ChatType.Npc:
                txtAll.Text += message + Environment.NewLine;
                break;

            case ChatType.Party:
                txtParty.Text += message + Environment.NewLine;
                break;

            case ChatType.Private:
                txtPrivate.Text += message + Environment.NewLine;
                break;

            case ChatType.Union:
                txtUnion.Text += message + Environment.NewLine;
                break;

            case ChatType.Stall:
                txtStall.Text += message + Environment.NewLine;
                break;
        }
    }

    /// <summary>
    ///     The first event that will be fired after the player enters the game
    /// </summary>
    private void OnEnterGame()
    {
        txtRecievePrivate.Text = PlayerConfig.Get<string>("RSBot.Chat.LastWhisper");
    }

    /// <summary>
    ///     Messages the preview key down.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="PreviewKeyDownEventArgs" /> instance containing the event data.</param>
    private void MessagePreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;
        SendChatMessage((Control)sender);
        ((Control)sender).Text = string.Empty;
    }
}