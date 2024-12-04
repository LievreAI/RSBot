using SDUI;
using SkiaSharp;
using System.Timers;

namespace RSBot.Statistics.Views
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewGroup listViewGroup1 = new ListViewGroup("Player");
            ListViewGroup listViewGroup2 = new ListViewGroup("Loot");
            ListViewGroup listViewGroup3 = new ListViewGroup("Enemy");
            ListViewGroup listViewGroup4 = new ListViewGroup("Bot");
            splitContainer1 = new SplitContainer();
            panelStaticFilters = new SDUI.GroupBox();
            Splitter1 = new SDUI.Splitter();
            panelLiveFilters = new SDUI.GroupBox();
            lvStatistics = new SDUI.ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            ContextMenu = new SDUI.ContextMenu();
            resetMenuItem = new MenuItem();
            panel1 = new SDUI.Panel();
            btnReset = new SDUI.Button();
            timer = new Timer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ContextMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panelStaticFilters);
            splitContainer1.Panel1.Controls.Add(Splitter1);
            splitContainer1.Panel1.Controls.Add(panelLiveFilters);
            splitContainer1.Panel1.Padding = new Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lvStatistics);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Padding = new Padding(10);
            splitContainer1.Size = new System.Drawing.Size(762, 506);
            splitContainer1.TabIndex = 0;
            // 
            // panelStaticFilters
            // 
            panelStaticFilters.BackColor = SKColors.Transparent;
            panelStaticFilters.Dock = DockStyle.Top;
            panelStaticFilters.Location = new System.Drawing.Point(10, 212);
            panelStaticFilters.Name = "panelStaticFilters";
            panelStaticFilters.Padding = new Padding(8, 10, 3, 10);
            panelStaticFilters.ShadowDepth = 4;
            panelStaticFilters.Size = new System.Drawing.Size(235, 278);
            panelStaticFilters.TabIndex = 9;
            panelStaticFilters.TabStop = false;
            panelStaticFilters.Text = "Tracking";
            // 
            // Splitter1
            // 
            Splitter1.Dock = DockStyle.Top;
            Splitter1.Location = new System.Drawing.Point(10, 200);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new System.Drawing.Size(235, 12);
            Splitter1.TabIndex = 10;
            Splitter1.Text = "Splitter1";
            // 
            // panelLiveFilters
            // 
            panelLiveFilters.BackColor = SKColors.Transparent;
            panelLiveFilters.Dock = DockStyle.Top;
            panelLiveFilters.Location = new System.Drawing.Point(10, 10);
            panelLiveFilters.Name = "panelLiveFilters";
            panelLiveFilters.Padding = new Padding(8, 10, 3, 10);
            panelLiveFilters.ShadowDepth = 4;
            panelLiveFilters.Size = new System.Drawing.Size(235, 190);
            panelLiveFilters.TabIndex = 1;
            panelLiveFilters.TabStop = false;
            panelLiveFilters.Text = "Prognosis";
            // 
            // lvStatistics
            // 
            lvStatistics.BackColor = SKColors.White;
            lvStatistics.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvStatistics.ContextMenu = ContextMenu;
            lvStatistics.Dock = DockStyle.Fill;
            lvStatistics.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lvStatistics.FullRowSelect = true;
            listViewGroup1.Header = "Player";
            listViewGroup1.Name = "grpPlayer";
            listViewGroup2.Header = "Loot";
            listViewGroup2.Name = "grpLoot";
            listViewGroup3.Header = "Enemy";
            listViewGroup3.Name = "grpEnemy";
            listViewGroup4.Header = "Bot";
            listViewGroup4.Name = "grpBot";
            lvStatistics.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3, listViewGroup4 });
            lvStatistics.Location = new System.Drawing.Point(10, 10);
            lvStatistics.Name = "lvStatistics";
            lvStatistics.Size = new System.Drawing.Size(483, 451);
            lvStatistics.TabIndex = 0;
            lvStatistics.UseCompatibleStateImageBehavior = false;
            lvStatistics.ViewType = ViewTypes.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 245;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Value";
            columnHeader2.Width = 228;
            // 
            // ContextMenu
            // 
            ContextMenu.Items.AddRange(new MenuItem[] { resetMenuItem });
            ContextMenu.Name = "ContextMenu";
            ContextMenu.Size = new System.Drawing.Size(103, 26);
            // 
            // resetMenuItem
            // 
            resetMenuItem.Name = "resetMenuItem";
            resetMenuItem.Text = "Reset";
            resetMenuItem.Click += resetMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SKColors.Transparent;
            panel1.Border = new Padding(0, 1, 0, 0);
            panel1.BorderColor = SKColors.Transparent;
            panel1.Controls.Add(btnReset);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(10, 461);
            panel1.Name = "panel1";
            panel1.ShadowDepth = 4F;
            panel1.Size = new System.Drawing.Size(483, 35);
            panel1.TabIndex = 2;
            // 
            // btnReset
            // 
            btnReset.Color = SKColors.Transparent;
            btnReset.Location = new System.Drawing.Point(401, 6);
            btnReset.Name = "btnReset";
            btnReset.ShadowDepth = 4F;
            btnReset.Size = new System.Drawing.Size(75, 23);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset ";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Elapsed += RefreshTimer_Elapsed;
            // 
            // Main
            // 
            
            
            Controls.Add(splitContainer1);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "Main";
            Size = new System.Drawing.Size(762, 506);
            ParentChanged += Main_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ContextMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SDUI.ListView lvStatistics;
        private SDUI.Panel panel1;
        private SDUI.Button btnReset;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private SDUI.GroupBox panelLiveFilters;
        private SDUI.GroupBox panelStaticFilters;
        private SDUI.Splitter Splitter1;
        private Timer timer;
        private SDUI.ContextMenu ContextMenu;
        private MenuItem resetMenuItem;
    }
}
