﻿using System;
using System.ComponentModel;

using RSBot.CommandCenter.Components;
using RSBot.Core;
using RSBot.Core.Components;
using SDUI;

namespace RSBot.CommandCenter.Views.Controls;

[ToolboxItem(false)]
internal partial class EmoticonActionElement : Panel
{
    public EmoticonActionElement(EmoticonItem item, string selectedActionName = null)
    {
        InitializeComponent();

        SelectedActionName = selectedActionName;
        Emoticon = item;
        picIcon.Image = item.GetIconImage();
        lblName.Text = item.Label;

        PopulateActions();
    }

    public EmoticonItem Emoticon { get; }

    public string SelectedActionName { get; private set; }

    private void PopulateActions()
    {
        comboAction.Items.Clear();

        foreach (var command in CommandManager.GetCommandDescriptions())
        {
            comboAction.Items.Add(new ActionComboBoxItem(command.Key, command.Value));
            var index = comboAction.Items.Count - 1;

            if (SelectedActionName == command.Key)
                comboAction.SelectedIndex = index;
        }
    }

    private void comboAction_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboAction.SelectedItem is not ActionComboBoxItem actionItem)
            return;

        SelectedActionName = actionItem.ActionName;

        PlayerConfig.Set($"RSBot.CommandCenter.MappedEmotes.{Emoticon.Name}", actionItem.ActionName);
    }

    private record ActionComboBoxItem(string ActionName, string ActionDescription)
    {
        public override string ToString()
        {
            return ActionDescription;
        }
    }
}