using RSBot.Core.Components;
using SDUI;
using SDUI;
using System;
using System.IO;
using System.Threading.Tasks;


namespace RSBot.Views.Dialog;

public partial class ProfileSelectionDialog : Form
{
    public ProfileSelectionDialog()
    {
        InitializeComponent();

        LoadProfiles();
        checkSaveSelection.Checked = !ProfileManager.ShowProfileDialog;
    }

    /// <summary>
    ///     Gets the selected profile.
    /// </summary>
    /// <value>
    ///     The selected profile.
    /// </value>
    public string SelectedProfile { get; private set; }

    #region Methods

    private void LoadProfiles()
    {
        comboProfiles.Items.Clear();
        if (!ProfileManager.Any())
            ProfileManager.Add("Default");

        comboProfiles.Items.AddRange(ProfileManager.Profiles);
        comboProfiles.SelectedItem = ProfileManager.SelectedProfile;
    }

    private async Task<string> CreateNewProfile()
    {
        var inputDialog = new InputDialog("New profile", "New profile", "Please enter a profile name");
        if (await inputDialog.ShowDialog(this) != DialogResult.OK)
            return string.Empty;

        var profile = (string)inputDialog.Value;

        if (profile.LastIndexOfAny(Path.GetInvalidFileNameChars(), 0) != -1)
        {
            await MessageBox.Show(this, "The profile name contains invalid characters!", "Invalid name", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return string.Empty;
        }

        if (ProfileManager.ProfileExists(profile))
        {
            await MessageBox.Show($"The profile name '{profile}' already exists!", "Invalid name", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return string.Empty;
        }

        ProfileManager.Add(profile, true);

        return profile;
    }

    #endregion Methods

    #region Events

    private void comboProfiles_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboProfiles.SelectedItem == null)
            return;

        SelectedProfile = (string)comboProfiles.SelectedItem;
    }

    private void checkSaveSelection_CheckedChanged(object sender, EventArgs e)
    {
        ProfileManager.ShowProfileDialog = !checkSaveSelection.Checked;
    }

    private async void buttonDeleteProfile_Click(object sender, EventArgs e)
    {
        if (comboProfiles.SelectedIndex == 0) //Default
        {
            await MessageBox.Show("You can not delete the default profile!", "Default profile",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        if (ProfileManager.SelectedProfile == (string)comboProfiles.SelectedItem) //Active profile?
        {
            await MessageBox.Show("You can not delete the active profile!", "Profile active",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        if (await MessageBox.Show(
                $"Do you want to delete the profile {comboProfiles.SelectedItem} from the list?\nThis will not delete the user data.",
                "Delete profile?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;

        ProfileManager.Remove((string)comboProfiles.SelectedItem);

        LoadProfiles();
    }

    private async void buttonCreateProfile_Click(object sender, EventArgs e)
    {
        SelectedProfile = await CreateNewProfile();

        LoadProfiles();
    }

    #endregion Events
}