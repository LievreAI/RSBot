﻿using System;
using System.Drawing;
using System.Linq;

using RSBot.Core;
using RSBot.Core.Client.ReferenceObjects;
using RSBot.Core.Extensions;
using RSBot.Core.Objects.Quests;
using SDUI;

namespace RSBot.Quest.Views.Sidebar;

public partial class QuestItem : Panel
{
    public QuestItem(uint questId)
    {
        
        QuestId = questId;

        InitializeComponent();
        RefreshQuest();
    }

    public uint QuestId { get; }

    private void RefreshQuest()
    {
        if (!Game.Player.QuestLog.ActiveQuests.TryGetValue(QuestId, out var playerQuest))
            return;

        lblQuestName.Text = playerQuest.Quest.GetTranslatedName();

        if (playerQuest.Objectives == null || playerQuest.Objectives.Length == 0)
        {
            lblObjective.Text = "All objectives completed";

            return;
        }

        var objectiveText = "";
        var objective = playerQuest.Objectives.First();

        objectiveText += GetObjectiveText(objective);

        if (objective.InProgress)
            objectiveText += " (in progress)\n";
        else
            objectiveText += " (done)\n";

        lblObjective.Text = objectiveText;

        var rewardText = GetRewardText(playerQuest.Quest);
    }

    private string GetRewardText(RefQuest quest)
    {
        var rewardText = "";

        if (quest.Reward != null)
        {
            rewardText += "Basic rewards:";
            if (quest.Reward.Exp > 0)
                rewardText += $"\n  Exp: {quest.Reward.Exp}";

            if (quest.Reward.Gold > 0)
                rewardText += $"\n  Gold: {quest.Reward.Gold}";

            if (quest.Reward.SP > 0)
                rewardText += $"\n  Skill points: {quest.Reward.SP}";

            if (quest.Reward.SP > 0)
                rewardText += $"\n  Skill exp: {quest.Reward.SPExp}";

            if (quest.Reward.InventorySlots > 0)
                rewardText += $"\n  Inv. slots: {quest.Reward.InventorySlots}";

            if (quest.Reward.Hwan > 0)
                rewardText += $"\n  Hwan: {quest.Reward.InventorySlots}";
        }

        if (quest.RewardItems != null && quest.RewardItems.Any())
        {
            rewardText += "\nItems:";

            foreach (var item in quest.RewardItems)
            {
                if (item.Item != null)
                    rewardText += $"\n  {item.Item.GetRealName(true)}";

                if (item.OptionalItem != null)
                    rewardText += $"\n  {item.OptionalItem.GetRealName(true)}";
            }
        }

        return rewardText;
    }

    private string GetObjectiveText(QuestObjective objective)
    {
        if (objective.Tasks == null || objective.Tasks.Length == 0)
            return Game.ReferenceManager.GetTranslation(objective.NameStrId);

        return Game.ReferenceManager.GetTranslation(objective.NameStrId).JoymaxFormat(objective.Tasks[0]);
    }

    protected override void OnInvalidated(EventArgs<Rectangle> e)
    {
        base.OnInvalidated(e);

        RefreshQuest();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        View.SidebarElement.RemoveQuest(QuestId);
        View.SidebarElement.Invalidate();
    }
}