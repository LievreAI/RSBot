using Microsoft.Win32;
using RSBot.Core;
using RSBot.Core.Client;
using RSBot.Core.Components;
using RSBot.Core.Event;
using RSBot.Core.Plugins;
using RSBot.Views.Dialog;
using SDUI;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;


namespace RSBot.Views;

public partial class Main : Form
{
    public static readonly SKColor LightThemeColor = new SKColor(255, 255, 255);
    public static readonly SKColor DarkThemeColor = new SKColor(16, 16, 16);

    #region Members

    /// <summary>
    ///     Bot player name [_cached]
    /// </summary>
    private string _playerName;
    private readonly Dictionary<string, WindowBase> _pluginWindows = new(8);

    #endregion Members

    #region Constructor

    /// <summary>
    ///     Initializes a new instance of the <see cref="Main" /> class.
    /// </summary>
    public Main()
    {
        InitializeComponent();
        
        SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
        RegisterEvents();

        Text = "RSBot";

        menuStrip.Dock = DockStyle.Left;
        menuStrip.SendToBack();
        menuStrip.Dock = DockStyle.Fill;
        TitleBar.Controls.AddImplicitControl(menuStrip);
    }

    #endregion Constructor

    #region Events

    public static event UserPreferenceChangingEventHandler UserPreferenceChanging;

    #endregion

    #region Methods

    private void donateButton_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo { FileName = "https://buymeacoffee.com/sdclowen", UseShellExecute = true });
        Process.Start(
            new ProcessStartInfo { FileName = "https://github.com/sponsors/SDClowen", UseShellExecute = true });
        Process.Start(new ProcessStartInfo { FileName = "https://www.patreon.com/sdclowen", UseShellExecute = true });
    }

    /// <summary>
    ///     Called when user preference changing
    /// </summary>
    /// <param name="sender">The sender</param>
    /// <param name="e">The event args</param>
    private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
    {
        //if (BackColor.IsDark() == WindowsHelper.IsDark())
          //  return;

        var detectDarkLight = GlobalConfig.Get("RSBot.Theme.Auto", true);
        if (!detectDarkLight)
            return;

        //if (WindowsHelper.IsDark())
          //  SetThemeColor(DarkThemeColor);
        //else
          //  SetThemeColor(LightThemeColor);
    }

    /// <summary>
    ///     Set theme color
    /// </summary>
    /// <param name="color">The color</param>
    private void SetThemeColor(Color color)
    {
        GlobalConfig.Set("SDUI.Color", color.ToArgb());
        //ColorScheme.BackColor = color;
        RefreshTheme();
    }

    /// <summary>
    ///     Refreshes the theme.
    /// </summary>
    public void RefreshTheme(bool save = true)
    {
        //BackColor = ColorScheme.BackColor;
        //stripStatus.BackColor = BackColor.IsDark() ? ColorScheme.BorderColor : Color.FromArgb(33, 150, 243);
        //stripStatus.ForeColor = ColorScheme.ForeColor;

        if (save)
            GlobalConfig.Save();
    }

    /// <summary>
    ///     Registers the events.
    /// </summary>
    private void RegisterEvents()
    {
        EventManager.SubscribeEvent("OnChangeStatusText", new Action<string>(OnChangeStatusText));
        EventManager.SubscribeEvent("OnShowBotWindow", OnShowBotWindow);
        EventManager.SubscribeEvent("OnLoadPlugins", OnLoadPlugins);
        EventManager.SubscribeEvent("OnLoadDivisionInfo", new Action<DivisionInfo>(OnLoadDivisionInfo));
        EventManager.SubscribeEvent("OnLoadBotbases", OnLoadBotbases);
        EventManager.SubscribeEvent("OnLoadCharacter", OnLoadCharacter);
        EventManager.SubscribeEvent("OnStartBot", OnStartBot);
        EventManager.SubscribeEvent("OnStopBot", OnStopBot);
        EventManager.SubscribeEvent("OnAgentServerDisconnected", OnAgentServerDisconnected);
        EventManager.SubscribeEvent("OnShowScriptRecorder", new Action<int, bool>(OnShowScriptRecorder));
        EventManager.SubscribeEvent("OnAddSidebarElement", new Action<Control>(OnAddSidebarElement));
    }

    private void OnAddSidebarElement(Control obj)
    {
        pSidebarCustom.Controls.Add(obj);
    }

    private void OnShowScriptRecorder(int ownerId, bool startRecording)
    {
        var recorder = new ScriptRecorder(ownerId, startRecording);
        recorder.Show();
    }

    /// <summary>
    ///     Forces to show the bot window
    /// </summary>
    private void OnShowBotWindow()
    {
        if (WindowState == FormWindowState.Minimized)
            WindowState = FormWindowState.Normal;

        //TopMost = true;

        BringToFront();
        //Activate();

        //TopMost = false;
    }

    /// <summary>
    ///     Selects the botbase.
    /// </summary>
    /// <param name="index">The index.</param>
    private void SelectBotbase(string name)
    {
        if (Kernel.Bot.Running)
            return;

        var oldBotbaseName = Kernel.Bot?.Botbase?.Name;
        var newBotbase = Kernel.BotbaseManager.Bots.FirstOrDefault(bot => bot.Value.Name == name);
        if (newBotbase.Value == null)
        {
            Log.Error($"Botbase [{name}] could not be found!");

            return;
        }

        newBotbase.Value.Translate();

        var tabpage = new TabPage();
        tabpage.Text = LanguageManager.GetLangBySpecificKey(newBotbase.Value.Name, "TabText", newBotbase.Value.TabText);
        
        var control = newBotbase.Value.View;
        control.Name = newBotbase.Value.Name;
        control.Enabled = Game.Ready;
        control.Dock = DockStyle.Fill;
        tabpage.Controls.Add(control);

        windowPageControl.TabPages.Insert(1, tabpage);

        Kernel.Bot?.SetBotbase(newBotbase.Value);
        GlobalConfig.Set("RSBot.BotName", newBotbase.Value.Name);

        if (Game.Player != null)
            EventManager.FireEvent("OnLoadCharacter");

        foreach (MenuItem item in botsMenuItem.Items)
            item.Checked = newBotbase.Value.Name == item.Name;
        
        TabPage oldBotBase = null;

        if (!string.IsNullOrWhiteSpace(oldBotbaseName) && (oldBotBase = windowPageControl.TabPages.FirstOrDefault(p => p.Name == oldBotbaseName)) != null)
            windowPageControl.TabPages.Remove(oldBotBase);
    }

    /// <summary>
    ///     Loads the extensions.
    /// </summary>
    private async void LoadExtensions()
    {
        foreach (var plugin in Kernel.PluginManager.Extensions.Values)
            plugin.Initialize();

        var extensions =
            Kernel.PluginManager.Extensions.OrderBy(entry => entry.Value.Index)
                .ToDictionary(x => x.Key, x => x.Value);

        foreach (var extension in extensions.Where(extension => extension.Value.DisplayAsTab))
        {
            extension.Value.Translate();

            var tabpage = new TabPage();
            tabpage.Text = LanguageManager.GetLangBySpecificKey(extension.Value.InternalName, "DisplayName",
                extension.Value.DisplayName);
            
            var control = extension.Value.View;
            control.Name = extension.Value.InternalName;
            control.Enabled = !extension.Value.RequireIngame;
            control.Dock = DockStyle.Fill;
            tabpage.Controls.Add(control);

            try
            {
                windowPageControl.TabPages.Add(tabpage);
            }
            catch (Exception e)
            {
                await MessageBox.Show(this, "ERROR", e.ToString());
            }    
        }

        foreach (var extension in extensions.Where(extension => !extension.Value.DisplayAsTab))
        {
            var menuItemText = LanguageManager.GetLangBySpecificKey(extension.Value.InternalName, "DisplayName",
                extension.Value.DisplayName);
            var menuItem = new MenuItem(menuItemText)
            {
                Enabled = !extension.Value.RequireIngame
            };
            menuItem.Click += PluginMenuItem_Click;
            menuItem.Tag = extension.Value;

            menuPlugins.Items.Add(menuItem);
        }
    }

    /// <summary>
    ///     Configures the sidebar.
    /// </summary>
    private void ConfigureSidebar()
    {
        pSidebar.Visible = menuSidebar.Checked;
    }

    /// <summary>
    ///     Populates the server combobox.
    /// </summary>
    /// <param name="info">The information.</param>
    private void PopulateServerCombobox(DivisionInfo info)
    {
        comboServer.Items.Clear();
        foreach (var item in info.Divisions[comboDivision.SelectedIndex].GatewayServers)
            comboServer.Items.Add(item);

        var gatewayIndex = GlobalConfig.Get<int>("RSBot.GatewayIndex");

        if (comboServer.Items.Count > 0)
            comboServer.SelectedIndex = comboServer.Items.Count - 1 >= gatewayIndex ? gatewayIndex : 0;

        GlobalConfig.Set("RSBot.GatewayIndex", comboServer.SelectedIndex.ToString());
    }

    #endregion Methods

    #region Form events

    /// <summary>
    ///     Handles the Click event of the MenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    /// <exception cref="System.NotImplementedException"></exception>
    private void PluginMenuItem_Click(object sender, EventArgs e)
    {
        var menuItem = (MenuItem)sender;
        var plugin = (IPlugin)menuItem.Tag;

        if (!_pluginWindows.TryGetValue(plugin.InternalName, out var pluginWindow))
        {
            pluginWindow = new Form
            {
                Text = plugin.DisplayName,
                Name = plugin.InternalName,
                StartPosition = FormStartPosition.CenterParent,
            };

            var content = plugin.View;
            content.Dock = DockStyle.Fill;

            plugin.Translate();

            pluginWindow.Width = content.Size.Width + 16;
            pluginWindow.Height = content.Size.Height + 32;
            pluginWindow.Controls.Add(content);

            _pluginWindows[plugin.InternalName] = pluginWindow;
        }

        if (!pluginWindow.Visible)
            pluginWindow.Show();

    }

    /// <summary>
    ///     Handles the Click event of the menuScriptRecorder control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void menuScriptRecorder_Click(object sender, EventArgs e)
    {
        var scriptRecorder = new ScriptRecorder();
        scriptRecorder.Show();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        GlobalConfig.Save();
        PlayerConfig.Save();
    }

    /// <summary>
    ///     Handles the Click event of the menuSidebar control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void menuSidebar_Click(object sender, EventArgs e)
    {
        menuSidebar.Checked = !menuSidebar.Checked;
        GlobalConfig.Set("RSBot.ShowSidebar", menuSidebar.Checked.ToString());

        ConfigureSidebar();
    }

    /// <summary>
    ///     Handles the SelectedIndexChanged event of the comboDivision control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void comboDivision_SelectedIndexChanged(object sender, EventArgs e)
    {
        GlobalConfig.Set("RSBot.DivisionIndex", comboDivision.SelectedIndex.ToString());

        if (Game.ReferenceManager.DivisionInfo != null)
            PopulateServerCombobox(Game.ReferenceManager.DivisionInfo);
    }

    /// <summary>
    ///     Handles the SelectedIndexChanged event of the comboServer control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void comboServer_SelectedIndexChanged(object sender, EventArgs e)
    {
        GlobalConfig.Set("RSBot.GatewayIndex", comboServer.SelectedIndex.ToString());
    }

    /// <summary>
    ///     Handles the Load event of the Main window.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private async void Main_Load(object sender, EventArgs e)
    {
        menuSidebar.Checked = GlobalConfig.Get("RSBot.ShowSidebar", true);

        foreach (var item in await LanguageManager.GetLanguages())
        {
            var dropdown = new MenuItem(item.Value);
            dropdown.Click += LanguageDropdown_Click;
            dropdown.Tag = item.Key;
            languageMenuItem.Items.Add(dropdown);

            if (Kernel.Language == dropdown.Text)
                dropdown.Checked = true;
        }

        ConfigureSidebar();
        //BackColor = ColorScheme.BackColor;
        menuCurrentProfile.Text = "Profile: " + ProfileManager.SelectedProfile;

        EventManager.FireEvent("OnInitialized");
    }

    /// <summary>
    ///     Handles the Click event of the MenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    /// <exception cref="System.NotImplementedException"></exception>
    private void LanguageDropdown_Click(object sender, EventArgs e)
    {
        var dropdown = sender as MenuItem;
        if (dropdown.Checked)
            return;

        Kernel.Language = dropdown.Tag.ToString();

        foreach (MenuItem item in languageMenuItem.Items)
            item.Checked = false;

        foreach (var plugin in Kernel.PluginManager.Extensions)
        {
            plugin.Value.Translate();

            var tabpage = windowPageControl.TabPages.FirstOrDefault(p => p.Name == plugin.Key);
            if (tabpage == null)
                continue;

            tabpage.Text = LanguageManager.GetLangBySpecificKey(plugin.Key, "DisplayName", tabpage.Text);
        }

        foreach (var botbase in Kernel.BotbaseManager.Bots)
        {
            botbase.Value.Translate();

            var tabpage = windowPageControl.TabPages.FirstOrDefault(p => p.Name == botbase.Key);
            if (tabpage == null)
                continue;

            tabpage.Text = LanguageManager.GetLangBySpecificKey(botbase.Key, "DisplayName", tabpage.Text);
        }

        LanguageManager.Translate(this, Kernel.Language);

        dropdown.Checked = true;

        GlobalConfig.Set("RSBot.Language", Kernel.Language);
        GlobalConfig.Save();
    }

    /// <summary>
    ///     Handles the Click event of the btnStartStop control.
    /// </summary>
    private void btnStartStop_Click(object sender, EventArgs e)
    {
        if (Kernel.Proxy == null)
            return;

        if (!Kernel.Proxy.IsConnectedToAgentserver)
            return;

        if (Kernel.Bot == null)
        {
            Log.NotifyLang("NotifyPleaseSelectProperBotBase");
            return;
        }

        if (Game.Player == null)
        {
            Log.WarnLang("NotifyPlayerWasNull");
            return;
        }

        if (!Kernel.Bot.Running)
        {
            Kernel.Bot.Start();

            Log.StatusLang("Running");
        }
        else
        {
            Log.NotifyLang("StopingBot", Kernel.Bot.Botbase.DisplayName);

            Kernel.Bot.Stop();
            Log.StatusLang("Ready");
        }
    }

    /// <summary>
    ///     Handles the FormClosing event of the Main control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="SDUI.CancelEventArgs" /> instance containing the event data.</param>
    private async void Main_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (Kernel.Proxy == null || !Kernel.Proxy.ClientConnected || !GlobalConfig.Get("RSBot.showExitDialog", true))
        {
            GlobalConfig.Save();
            PlayerConfig.Save();

            Environment.Exit(0);
        }

        var exitDialog = new ExitDialog();
        if (await exitDialog.ShowDialog(this) != DialogResult.Yes)
        {
            e.Cancel = true;
            return;
        }

        GlobalConfig.Save();
        PlayerConfig.Save();
        ClientManager.Kill();

        Environment.Exit(0);
    }

    /// <summary>
    ///     Handles the Click event of the notifyIcon control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void notifyIcon_Click(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Normal)
            return;

        /*notifyIcon.Visible = true;
        notifyIcon.ShowBalloonTip(1000, "RSBot", "RSBot visible mode", ToolTipIcon.Info);*/

        Show();
        WindowState = FormWindowState.Normal;
    }

    /// <summary>
    ///     Handles the Click event of the menuItemExit control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private async void menuItemExit_Click(object sender, EventArgs e)
    {
        if (Kernel.Proxy == null || !Kernel.Proxy.ClientConnected || !GlobalConfig.Get("RSBot.showExitDialog", true))
        {
            GlobalConfig.Save();
            PlayerConfig.Save();

            Environment.Exit(0);
        }

        var exitDialog = new ExitDialog();
        if (await exitDialog.ShowDialog(this) != DialogResult.Yes)
            return;

        GlobalConfig.Save();
        PlayerConfig.Save();
        ClientManager.Kill();

        Environment.Exit(0);
    }

    /// <summary>
    ///     Handles the Resize event of the Main control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void Main_Resize(object sender, EventArgs e)
    {
        if (WindowState != FormWindowState.Minimized)
            return;

        if (!GlobalConfig.Get<bool>("RSBot.General.TrayWhenMinimize"))
            return;

        Hide();
    }

    /// <summary>
    ///     Handles the Click event of the menuItemThis control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private async void menuItemThis_Click(object sender, EventArgs e)
    {
        await new AboutDialog().ShowDialog(this);
    }

    /// <summary>
    ///     Handles the Click event of the networkConfigMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private async void networkConfigMenuItem_Click(object sender, EventArgs e)
    {
        using var configDialog = new ConfigDialog();
        await configDialog.ShowDialog(this);
    }

    /// <summary>
    ///     Handles the Click event of the darkMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void darkMenuItem_Click(object sender, EventArgs e)
    {
        GlobalConfig.Set("RSBot.Theme.Auto", false);
        //SetThemeColor(DarkThemeColor);
    }

    /// <summary>
    ///     Handles the Click event of the lightMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void lightMenuItem_Click(object sender, EventArgs e)
    {
        GlobalConfig.Set("RSBot.Theme.Auto", false);
        //SetThemeColor(LightThemeColor);
    }

    /// <summary>
    ///     Handles the Click event of the autoMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private async void autoMenuItem_Click(object sender, EventArgs e)
    {
        /*if (WindowsHelper.IsModern)
        {
            GlobalConfig.Set("RSBot.Theme.Auto", true);
            SystemEvents_UserPreferenceChanged(null,
                new UserPreferenceChangedEventArgs(UserPreferenceCategory.Color));

            return;
        }*/

        await MessageBox.Show(
            "Unfortunately, it does not support this mode because your operating system is outdated!",
            "Warning",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );
    }

    /// <summary>
    ///     Handles the Click event of the coloredMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void coloredMenuItem_Click(object sender, EventArgs e)
    {
        /*var colorDialog = new ColorDialog
        {
            CustomColors = GlobalConfig.GetArray<int>("SDUI.CustomColors")
        };

        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            GlobalConfig.SetArray("SDUI.CustomColors", colorDialog.CustomColors);
            SetThemeColor(colorDialog.Color);
        }*/
    }

    /// <summary>
    ///     Handles the Click event of the menuSelectProfile control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private async void menuSelectProfile_Click(object sender, EventArgs e)
    {
        var dialog = new ProfileSelectionDialog();
        dialog.StartPosition = FormStartPosition.CenterParent;
        if (await dialog.ShowDialog(this) != DialogResult.OK)
            return;

        if (dialog.SelectedProfile == ProfileManager.SelectedProfile)
            return;

        var oldSroPath = GlobalConfig.Get("RSBot.SilkroadDirectory", "");

        //We need this to check if the sro directories are different
        var tempNewConfig = new Config(ProfileManager.GetProfileFile(dialog.SelectedProfile));

        if (oldSroPath != tempNewConfig.Get("RSBot.SilkroadDirectory", ""))
            if (await MessageBox.Show("This profile references to a different client, do you want to restart the bot?",
                    "Restart bot?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Restart();

        ProfileManager.SetSelectedProfile(dialog.SelectedProfile);
        GlobalConfig.Load();

        EventManager.FireEvent("OnProfileChanged");
        menuCurrentProfile.Text = dialog.SelectedProfile;

        if (Game.Player == null)
            return;

        //Reload player config
        PlayerConfig.Load(Game.Player.Name);

        //A little hack to tell all plugins to reload their UI
        EventManager.FireEvent("OnLoadCharacter");
    }

    /// <summary>
    ///     Handles the Click event of the buttonConfig control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private async void buttonConfig_Click(object sender, EventArgs e)
    {
        const string title = "IP Bind";

        var currentBind = GlobalConfig.Get("RSBot.Network.BindIp", "0.0.0.0");

        const string message =
            "Use your custom interface ip for connect to game.\nEnter your interface Ip:\t(default: 0.0.0.0)";

        var dialog = new InputDialog(title, title, message, defaultValue: currentBind);
        if (await dialog.ShowDialog(this) != DialogResult.OK)
            return;

        if (!IPAddress.TryParse(dialog.Value.ToString(), out var ipAddress))
        {
            const string errorMessage = "The IP address is incorrect or cannot be verified.You can try like '0.0.0.0'.";
            await MessageBox.Show(this, "", errorMessage);

            return;
        }

        GlobalConfig.Set("RSBot.Network.BindIp", ipAddress.ToString());
    }

    #endregion Form events

    #region Core events

    /// <summary>
    ///     Called when [start bot].
    /// </summary>
    private void OnStartBot()
    {
        btnStartStop.Text = LanguageManager.GetLang("StopBot");
    }

    /// <summary>
    ///     Called when [stop bot].
    /// </summary>
    private void OnStopBot()
    {
        btnStartStop.Text = LanguageManager.GetLang("StartBot");
    }

    /// <summary>
    ///     Called when [load botbases].
    /// </summary>
    private async void OnLoadBotbases()
    {
        if (Kernel.BotbaseManager.Bots == null || Kernel.BotbaseManager.Bots.Count == 0)
        {
            var title = LanguageManager.GetLang("NoBotbaseDetected");
            var message = LanguageManager.GetLang("NoBotbaseDetectedDesc");
            var messageResult =
                await MessageBox.Show(this, message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (messageResult == DialogResult.Yes)
                Kernel.BotbaseManager.LoadAssemblies();
            else if (messageResult == DialogResult.No)
                Environment.Exit(-1);
        }

        foreach (var bot in Kernel.BotbaseManager.Bots)
        {
            var item = new MenuItem
            {
                Name = bot.Value.Name,
                Text = bot.Value.DisplayName
            };
            item.Click += Item_Click;
            botsMenuItem.Items.Add(item);
        }

        SelectBotbase(GlobalConfig.Get("RSBot.BotName", "RSBot.Default"));
    }

    /// <summary>
    ///     Handles the Click event of the MenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    /// <exception cref="System.NotImplementedException"></exception>
    private void Item_Click(object? sender, EventArgs e)
    {
        var item = sender as MenuItem;
        SelectBotbase(item.Name);
    }

    /// <summary>
    ///     Reset UI after character disconnect
    /// </summary>
    private void OnAgentServerDisconnected()
    {
        foreach (Control control in windowPageControl.TabPages)
        {
            if (!control.Controls.ContainsKey("overlay"))
                continue;

            control.Enabled = false;
            control.Controls["overlay"].Show();
        }

        var disconnectedText = LanguageManager.GetLang("Disconnected");
        if (!Text.EndsWith(disconnectedText))
        {
            Text = $@"RSBot - {_playerName} - {disconnectedText}";
        }
    }

    /// <summary>
    ///     Called when [change status text].
    /// </summary>
    /// <param name="text">The text.</param>
    private void OnChangeStatusText(string text)
    {
        lblIngameStatus.Text = text;
    }

    /// <summary>
    ///     Called when [load plugins].
    /// </summary>
    private void OnLoadPlugins()
    {
        LoadExtensions();
    }

    /// <summary>
    ///     Called when [load division information].
    /// </summary>
    /// <param name="info">The information.</param>
    private void OnLoadDivisionInfo(DivisionInfo info)
    {
        comboDivision.Items.Clear();
        foreach (var divInfo in info.Divisions)
            comboDivision.Items.Add(divInfo.Name);

        var divisionIndex = GlobalConfig.Get<int>("RSBot.DivisionIndex");

        if (comboDivision.Items.Count >= info.Divisions.Count)
            comboDivision.SelectedIndex = comboDivision.SelectedIndex =
                comboDivision.Items.Count - 1 >= divisionIndex ? divisionIndex : 0;

        PopulateServerCombobox(info);
    }

    /// <summary>
    ///     Called when [load character].
    /// </summary>
    private void OnLoadCharacter()
    {
        foreach (Control control in windowPageControl.TabPages)
        {
            control.Enabled = true;

            control.Controls["overlay"]?.Hide();
        }

        foreach (MenuItem item in menuPlugins.Items)
            item.Enabled = true;

        _playerName = Game.Player.Name;
        Text = $@"RSBot - {_playerName}";

        if (Game.Clientless)
            Text += " [Clientless]";

        if (Kernel.Debug)
            Text += $@" [JID = {Game.Player.JID}]";
    }

    #endregion Core events
}