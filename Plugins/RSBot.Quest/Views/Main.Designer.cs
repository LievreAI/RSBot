﻿namespace RSBot.Quest.Views
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
            treeQuests = new System.Windows.Forms.TreeView();
            checkShowCompleted = new System.Windows.Forms.CheckBox();
            contextQuest = new System.Windows.Forms.ContextMenuStrip();
            watchQuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            abandonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contextQuest.SuspendLayout();
            SuspendLayout();
            // 
            // treeQuests
            // 
            treeQuests.FullRowSelect = true;
            treeQuests.HideSelection = false;
            treeQuests.Location = new System.Drawing.Point(17, 13);
            treeQuests.Name = "treeQuests";
            treeQuests.Size = new System.Drawing.Size(424, 431);
            treeQuests.TabIndex = 0;
            treeQuests.NodeMouseClick += treeQuests_NodeMouseClick;
            // 
            // checkShowCompleted
            // 
            checkShowCompleted.AutoSize = true;
            
            checkShowCompleted.Location = new System.Drawing.Point(17, 447);
            checkShowCompleted.Margin = new System.Windows.Forms.Padding(0);
            
            checkShowCompleted.Name = "checkShowCompleted";
            
            checkShowCompleted.Size = new System.Drawing.Size(121, 30);
            checkShowCompleted.TabIndex = 1;
            checkShowCompleted.Text = "Show completed";
            checkShowCompleted.UseVisualStyleBackColor = true;
            checkShowCompleted.CheckedChanged += checkShowCompleted_CheckedChanged;
            // 
            // contextQuest
            // 
            contextQuest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { watchQuestToolStripMenuItem, toolStripSeparator1, abandonToolStripMenuItem });
            contextQuest.Name = "contextMenuStrip1";
            contextQuest.Size = new System.Drawing.Size(181, 76);
            // 
            // watchQuestToolStripMenuItem
            // 
            
            watchQuestToolStripMenuItem.Name = "watchQuestToolStripMenuItem";
            watchQuestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            watchQuestToolStripMenuItem.Text = "Watch / unwatch";
            watchQuestToolStripMenuItem.Click += watchQuestToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // abandonToolStripMenuItem
            // 
            
            abandonToolStripMenuItem.Name = "abandonToolStripMenuItem";
            abandonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            abandonToolStripMenuItem.Text = "Abandon";
            abandonToolStripMenuItem.Click += abandonToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(checkShowCompleted);
            Controls.Add(treeQuests);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "Main";
            Size = new System.Drawing.Size(460, 490);
            Load += Main_Load;
            contextQuest.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView treeQuests;
        private System.Windows.Forms.CheckBox checkShowCompleted;
        private System.Windows.Forms.ContextMenuStrip contextQuest;
        private System.Windows.Forms.ToolStripMenuItem watchQuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abandonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
