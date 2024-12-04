using RSBot.Core;
using RSBot.Core.Event;
using RSBot.Core.Objects.Quests;
using SDUI;
using System;
using System.ComponentModel;
using System.Linq;

namespace RSBot.Quest.Views;

[ToolboxItem(false)]
public partial class Main : Panel
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Main" /> class.
    /// </summary>
    public Main()
    {
        
        InitializeComponent();

        SubscribeEvents();
    }

    private void SubscribeEvents()
    {
        EventManager.SubscribeEvent("OnLoadCharacter", RefreshQuestList);
        EventManager.SubscribeEvent("OnUpdateQuests", RefreshQuestList);
    }

    private void RefreshQuestList()
    {
        try
        {
            if (!treeQuests.Created)
                return;

            //treeQuests.Invoke(() =>
            {
                treeQuests.Items.Clear();
                foreach (var activeQuest in Game.Player.QuestLog.ActiveQuests)
                {
                    var node = CreateNode(activeQuest.Value);
                    node.Tag = activeQuest.Key;

                    node.ContextMenu = contextQuest;

                    treeQuests.Items.Add(node);
                }

                if (!checkShowCompleted.Checked) return;

                var completedNode = new TreeViewItem("Completed");
                foreach (var questId in Game.Player.QuestLog.CompletedQuests)
                {
                    var quest = Game.ReferenceManager.GetRefQuest(questId);

                    var node = new TreeViewItem($"{quest.GetTranslatedName()} (lv. {quest.Level})");
                    completedNode.Items.Add(node);
                }

                treeQuests.Items.Add(completedNode);
            };
        }
        catch (Exception e)
        {
            // ignored
        }
    }

    private TreeViewItem CreateNode(ActiveQuest quest)
    {
        if (quest.Quest == null)
            return new TreeViewItem($"Unknown quest [{quest.Id}]");

        var name = Game.ReferenceManager.GetTranslation(quest.Quest.NameString);

        var node = new TreeViewItem(name);
        node.Items.Add($"Id: {quest.Id}");
        node.Items.Add($"Level: {quest.Quest.Level}");
        node.Items.Add($"Status: {GetStatusText(quest.Status)}");

        node.Tag = quest.Id;

        if (quest.Npcs?.Length > 0)
        {
            var npcNode = new TreeViewItem("NPCs");
            foreach (var npcId in quest.Npcs)
            {
                var npc = Game.ReferenceManager.GetRefObjChar(npcId);
                var npcName = Game.ReferenceManager.GetTranslation(npc.NameStrID);
                npcNode.Items.Add(npcName);
            }

            node.Items.Add(npcNode);
        }

        var rewardNode = new TreeViewItem("Rewards");

        if (quest.Quest.Reward != null)
        {
            if (quest.Quest.Reward.Exp > 0)
                rewardNode.Items.Add($"Exp: {quest.Quest.Reward.Exp}");

            if (quest.Quest.Reward.Gold > 0)
                rewardNode.Items.Add($"Gold: {quest.Quest.Reward.Gold}");

            if (quest.Quest.Reward.SP > 0)
                rewardNode.Items.Add($"Skill points: {quest.Quest.Reward.Gold}");

            if (quest.Quest.Reward.SP > 0)
                rewardNode.Items.Add($"Skill Exp: {quest.Quest.Reward.Gold}");

            if (quest.Quest.Reward.InventorySlots > 0)
                rewardNode.Items.Add($"Inv. slots: {quest.Quest.Reward.Gold}");

            if (quest.Quest.Reward.Hwan > 0)
                rewardNode.Items.Add($"Hwan: {quest.Quest.Reward.Gold}");
        }

        if (quest.Quest.RewardItems != null && quest.Quest.RewardItems.Any())
        {
            var itemsNode = new TreeViewItem("Items");

            foreach (var rewardItem in quest.Quest.RewardItems)
            {
                if (rewardItem.Item != null)
                    itemsNode.Items.Add($"{rewardItem.Item.GetRealName()}");

                if (rewardItem.OptionalItem != null)
                    itemsNode.Items.Add($"{rewardItem.OptionalItem.GetRealName()}");
            }

            rewardNode.Items.Add(itemsNode);
        }

        node.Items.Add(rewardNode);

        if (quest.Objectives?.Length > 0)
            foreach (var objective in quest.Objectives)
            {
                var objectiveName = Game.ReferenceManager.GetTranslation(objective.NameStrId);
                var objectiveSubNode = new TreeViewItem(objectiveName);
                if (objective.InProgress)
                    objectiveSubNode.Items.Add("Status: In progress");
                else
                    objectiveSubNode.Items.Add("Status: Complete");

                foreach (var task in objective.Tasks)
                {
                    var actualTitle = objectiveName.Replace("%d", task.ToString());

                    objectiveSubNode.Items.Add($"Progress: {task}");
                    objectiveSubNode.Text = actualTitle;
                }

                node.Items.Add(objectiveSubNode);
            }

        return node;
    }

    private string GetStatusText(QuestStatus status)
    {
        switch (status)
        {
            case QuestStatus.Cancelled:
                return "Cancelled";
            case QuestStatus.Completed:
            case QuestStatus.CompletedXTimes:
                return "Completed";
            case QuestStatus.CompletedButNotSupplied:
            case QuestStatus.CompletedByUserButNotSupplied:
                return "Ready for delivery";
            case QuestStatus.Initialized:
            case QuestStatus.StartedByUser:
                return "In progress";
            case QuestStatus.Unavailable:
                return "Unavailable";
            default:
                return status.ToString();
        }
    }

    private void checkShowCompleted_CheckedChanged(object sender, EventArgs e)
    {
        RefreshQuestList();
    }

    private void Main_Load(object sender, EventArgs e)
    {
        RefreshQuestList();
    }

    private void watchQuestMenuItem_Click(object sender, EventArgs e)
    {
        if (!uint.TryParse(treeQuests.SelectedItem?.Tag.ToString(), out var questId))
            return;

        if (View.SidebarElement.HasQuest(questId))
            View.SidebarElement.RemoveQuest(questId);
        else
            View.SidebarElement.AddQuest(questId);
    }

    private void treeQuests_NodeMouseClick(object sender, EventArgs e)
    {
        //treeQuests.SelectedNode = e.Node;
    }

    private async void abandonMenuItem_Click(object sender, EventArgs e)
    {
        if (!uint.TryParse(treeQuests.SelectedItem?.Tag.ToString(), out var questId))
            return;

        if (!Game.Player.QuestLog.ActiveQuests.TryGetValue(questId, out var activeQuest))
            return;

        if (await MessageBox.Show($"Do you really want to abandon the quest [{activeQuest.Quest.GetTranslatedName()}]?",
                "Abandon quest", MessageBoxButtons.YesNo) == DialogResult.Yes)
            Game.Player.QuestLog.AbandonQuest(questId);
    }
}