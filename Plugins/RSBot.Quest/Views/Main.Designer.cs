using SDUI;

namespace RSBot.Quest.Views
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeQuests = new TreeView();
            checkShowCompleted = new SDUI.CheckBox();
            contextQuest = new SDUI.ContextMenu();
            watchQuestMenuItem = new MenuItem();
            MenuSplitterItem1 = new MenuSplitterItem();
            abandonMenuItem = new MenuItem();
            contextQuest.SuspendLayout();
            SuspendLayout();
            // 
            // treeQuests
            // 
            treeQuests.Location = new System.Drawing.Point(17, 13);
            treeQuests.Name = "treeQuests";
            treeQuests.Size = new System.Drawing.Size(424, 431);
            treeQuests.TabIndex = 0;
            treeQuests.ItemSelected += treeQuests_NodeMouseClick;
            // 
            // checkShowCompleted
            // 
            checkShowCompleted.AutoSize = true;
            checkShowCompleted.Location = new System.Drawing.Point(17, 447);
            checkShowCompleted.Margin = new Padding(0);
            checkShowCompleted.Name = "checkShowCompleted";
            checkShowCompleted.Ripple = true;
            checkShowCompleted.Size = new System.Drawing.Size(121, 30);
            checkShowCompleted.TabIndex = 1;
            checkShowCompleted.Text = "Show completed";
            checkShowCompleted.UseVisualStyleBackColor = true;
            checkShowCompleted.CheckedChanged += checkShowCompleted_CheckedChanged;
            // 
            // contextQuest
            // 
            contextQuest.Items.AddRange(new MenuItem[] { watchQuestMenuItem, MenuSplitterItem1, abandonMenuItem });
            contextQuest.Name = "ContextMenu1";
            contextQuest.Size = new System.Drawing.Size(181, 76);
            // 
            // watchQuestMenuItem
            // 
            watchQuestMenuItem.Name = "watchQuestMenuItem";
            watchQuestMenuItem.Text = "Watch / unwatch";
            watchQuestMenuItem.Click += watchQuestMenuItem_Click;
            // 
            // MenuSplitterItem1
            // 
            MenuSplitterItem1.Name = "MenuSplitterItem1";
            // 
            // abandonMenuItem
            // 
            abandonMenuItem.Name = "abandonMenuItem";
            abandonMenuItem.Text = "Abandon";
            abandonMenuItem.Click += abandonMenuItem_Click;
            // 
            // Main
            // 
            
            
            Controls.Add(checkShowCompleted);
            Controls.Add(treeQuests);
            Name = "Main";
            Size = new System.Drawing.Size(460, 490);
            ParentChanged += Main_Load;
            contextQuest.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeQuests;
        private SDUI.CheckBox checkShowCompleted;
        private SDUI.ContextMenu contextQuest;
        private MenuItem watchQuestMenuItem;
        private MenuItem abandonMenuItem;
        private MenuSplitterItem MenuSplitterItem1;
    }
}
