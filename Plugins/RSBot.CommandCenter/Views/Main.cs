﻿using RSBot.CommandCenter.Components;
using RSBot.CommandCenter.Views.Controls;
using RSBot.Core;
using RSBot.Core.Components;
using SDUI;
using System;
using System.ComponentModel;

namespace RSBot.CommandCenter.Views;

[ToolboxItem(false)]
public partial class Main : Panel
{
    public Main()
    {
        InitializeComponent();
        RefreshView();
    }

    private void RefreshView()
    {
        checkEnable.Checked = PlayerConfig.Get("RSBot.CommandCenter.Enabled", true);

        panelActions.Hide();
        panelActions.Controls.Clear();

        PopulateEmoticonActions();
        PopulateChatCommandPage();

        panelActions.Show();
    }

    private void PopulateEmoticonActions()
    {
        foreach (var emoticon in Emoticons.Items)
        {
            var selectedName = PluginConfig.GetAssignedEmoteCommand(emoticon.Name);

            panelActions.Controls.Add(new EmoticonActionElement(emoticon, selectedName) { Dock = DockStyle.Top });
        }
    }

    private void PopulateChatCommandPage()
    {
        lblChatCommandDescriptions.Text = string.Empty;

        foreach (var commandDescription in CommandManager.GetCommandDescriptions())
        {
            if (commandDescription.Key == "none")
                continue;

            lblChatCommandDescriptions.Text +=
                $"\\{commandDescription.Key}\t{commandDescription.Value}{Environment.NewLine}";
        }
    }

    private async void btnResetToDefaults_Click(object sender, EventArgs e)
    {
        if (await MessageBox.Show(@"Do you really want to reset all settings to default?", @"Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
            return;

        foreach (var emoticon in Emoticons.Items)
            PlayerConfig.Set($"RSBot.CommandCenter.MappedEmotes.{emoticon.Name}",
                Emoticons.GetEmoticonDefaultCommand(emoticon.Name));

        RefreshView();
    }

    private void checkEnable_CheckedChanged(object sender, EventArgs e)
    {
        PlayerConfig.Set("RSBot.CommandCenter.Enabled", checkEnable.Checked);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        PlayerConfig.Save();
    }
}