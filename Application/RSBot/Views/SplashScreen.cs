using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Objects;
using RSBot.Views.Dialog;
using SDUI;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;

namespace RSBot.Views;

public partial class SplashScreen : Form
{
    private readonly Main _mainForm;

    /// <summary>
    ///     Initializes a new instance of the <see cref="SplashScreen" /> class.
    /// </summary>
    public SplashScreen()
    {
        InitializeComponent();
        TitleBar.Visible = false;

        _mainForm = new Main();

        labelVersion.Text = Program.AssemblyVersion;
        referenceDataLoader.RunWorkerCompleted += ReferenceDataLoaderCompleted;
    }

    /// <summary>
    ///     Handles the Load event of the SplashScreen control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected override async void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        
        if (!await LoadProfileConfig())
        {
            Environment.Exit(0);
            return;
        }

        Kernel.Language = GlobalConfig.Get("RSBot.Language", "en_US");

        LanguageManager.Translate(_mainForm, Kernel.Language);

        if (!GlobalConfig.Exists("RSBot.SilkroadDirectory") ||
            !File.Exists(GlobalConfig.Get<string>("RSBot.SilkroadDirectory") + "\\media.pk2"))
        {
            var dialog = new OpenFileDialog
            {
                Title = LanguageManager.GetLang("OpenFileDialogTitle"),
                FileName = "sro_client.exe"
            };
            dialog.AddFilter("Silkroad Sro_Client", "exe");

            var result = await dialog.ShowDialog(this);

            var silkroadDirectory = Path.GetDirectoryName(dialog.FileName);

            if (result == DialogResult.OK && File.Exists(Path.Combine(silkroadDirectory, "media.pk2")))
            {
                GlobalConfig.Set("RSBot.SilkroadDirectory", silkroadDirectory);
                GlobalConfig.Set("RSBot.SilkroadExecutable", Path.GetFileName(dialog.FileName));

                var title = LanguageManager.GetLang("ClientTypeInputDialogTitle");
                var content = LanguageManager.GetLang("ClientTypeInputDialogContent");

                var clientTypeDialog = new InputDialog(title, title, content, InputDialog.InputType.Combobox);
                clientTypeDialog.StartPosition = FormStartPosition.CenterScreen;
                clientTypeDialog.Selector.Items.AddRange(Enum.GetNames(typeof(GameClientType)));
                clientTypeDialog.Selector.SelectedIndex = 2;
                clientTypeDialog.StartPosition = FormStartPosition.CenterScreen;

                if (await clientTypeDialog.ShowDialog(this) == DialogResult.OK)
                {
                    if (Enum.TryParse<GameClientType>(clientTypeDialog.Value.ToString(), out var clientType))
                        GlobalConfig.Set("RSBot.Game.ClientType", clientType);
                }
                else
                {
                    await MessageBox.Show(this, LanguageManager.GetLang("ClientTypeNotSelected"));
                    GlobalConfig.Set("RSBot.Game.ClientType", GameClientType.Vietnam);
                }
            }
            else
            {
                await MessageBox.Show(this,LanguageManager.GetLang("SelectSroDirWarn"));
                Environment.Exit(0);
            }
        }

        InitializeBot();

        referenceDataLoader.RunWorkerAsync();
    }

    /// <summary>
    ///     Handles the RunWorkerCompleted event of the Initializer control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">
    ///     The <see cref="System.ComponentModel.RunWorkerCompletedEventArgs" /> instance containing the event
    ///     data.
    /// </param>
    private void ReferenceDataLoaderCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        var detectDarkLight = GlobalConfig.Get("RSBot.Theme.Auto", true);
        if (detectDarkLight)
        {
            //if (WindowsHelper.IsDark())
            //    ColorScheme.BackColor = Main.DarkThemeColor;
            //else
            //    ColorScheme.BackColor = Main.LightThemeColor;
        }
        else
        {
            //ColorScheme.BackColor = Color.FromArgb(GlobalConfig.Get("SDUI.Color", Color.White.ToArgb()));
        }

        _mainForm.Show();
        _mainForm.RefreshTheme();

        Hide();
    }

    /// <summary>
    ///     Loads the profile configuration.
    /// </summary>
    private async Task<bool> LoadProfileConfig()
    {
        if (!ProfileManager.IsProfileLoadedByArgs)
        {
            if (ProfileManager.ShowProfileDialog)
            {
                var dialog = new ProfileSelectionDialog();
                dialog.TitleBar.Visible = false;
                dialog.Cursor = Cursor.Default;

                if (await dialog.ShowDialog(this) != DialogResult.Cancel)
                    ProfileManager.SetSelectedProfile(dialog.SelectedProfile);
                else
                    return false;
            }
            else //Load selected profile without dialog
            {
                var selectedProfile = ProfileManager.SelectedProfile;
                var profilePath = ProfileManager.GetProfileFile(selectedProfile);

                //Configured profile could not be found. Fallback to default profile
                if (!string.IsNullOrEmpty(selectedProfile) && !File.Exists(profilePath))
                    selectedProfile = "Default";

                ProfileManager.SetSelectedProfile(selectedProfile);
            }
        }

        GlobalConfig.Load();
        Log.Notify($"Loaded profile {ProfileManager.SelectedProfile}");

        return true;
    }

    /// <summary>
    ///     Initializes the bot.
    /// </summary>
    private async void InitializeBot()
    {
        //---- Boot kernel -----
        Kernel.Initialize();
        Game.Initialize();

        //---- Load Plugins ----
        if (!Kernel.PluginManager.LoadAssemblies())
        {
            await MessageBox.Show(this, @"Failed to load plugins. Process canceled!", @"Initialize Application - Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        //---- Load Botbases ----
        if (!Kernel.BotbaseManager.LoadAssemblies())
            await MessageBox.Show(this, @"Failed to load botbases. Process canceled!", @"Initialize Application - Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        CommandManager.Initialize();
    }

    /// <summary>
    ///     Handles the DoWork event of the referenceDataLoader control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs" /> instance containing the event data.</param>
    private async void referenceDataLoader_DoWork(object sender, DoWorkEventArgs e)
    {
        if (!Game.InitializeArchiveFiles())
        {
            await MessageBox.Show(@"Failed to load game data. Boot process canceled!", @"Initialize Application - Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Game.ReferenceManager.Load(GlobalConfig.Get("RSBot.TranslationIndex", 9), referenceDataLoader);
    }

    private void referenceDataLoader_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
        lblLoading.Text = $"Loading: {e.UserState}";
        progressLoading.Value = e.ProgressPercentage;
    }
}