using SDUI;
using SkiaSharp;
using System;
using System.Timers;

namespace RSBot.Map.Views
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
            components = new System.ComponentModel.Container();
            label4 = new SDUI.Label();
            comboViewType = new SDUI.ComboBox();
            trmInterval = new Timer();
            lvMonster = new SDUI.ListView();
            colName = new ColumnHeader();
            colType = new ColumnHeader();
            colLevel = new ColumnHeader();
            colPosition = new ColumnHeader();
            checkBoxAutoSelectUniques = new SDUI.CheckBox();
            label3 = new SDUI.Label();
            timerUniqueChecker = new Timer();
            checkEnableCollisions = new SDUI.CheckBox();
            tabControl1 = new SDUI.TabControl();
            mapCanvas = new TabPage();
            tabNavMeshViewer = new TabPage();
            btnNvmResetToPlayer = new SDUI.Button();
            labelSectorInfo = new SDUI.Label();
            panelNavMeshRendererCanvas = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            tabControl1.SuspendLayout();
            tabNavMeshViewer.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.ApplyGradient = false;
            label4.AutoSize = true;
            label4.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label4.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label4.GradientAnimation = false;
            label4.Location = new System.Drawing.Point(23, 15);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 20);
            label4.TabIndex = 9;
            label4.Text = "Show:";
            // 
            // comboViewType
            // 
            comboViewType.Items.AddRange(new object[] { "Monsters", "Players", "Party", "NPCs", "COS", "Portals", "All" });
            comboViewType.Location = new System.Drawing.Point(81, 14);
            comboViewType.Name = "comboViewType";
            comboViewType.Radius = 5;
            comboViewType.ShadowDepth = 4F;
            comboViewType.Size = new System.Drawing.Size(197, 23);
            comboViewType.TabIndex = 10;
            // 
            // trmInterval
            // 
            trmInterval.Enabled = true;
            trmInterval.Interval = 50;
            trmInterval.Elapsed += trmInterval_Tick;
            // 
            // lvMonster
            // 
            lvMonster.BackColor = SKColors.White;
            lvMonster.Columns.AddRange(new ColumnHeader[] { colName, colType, colLevel, colPosition });
            lvMonster.Dock = DockStyle.Top;
            lvMonster.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lvMonster.FullRowSelect = true;
            lvMonster.Location = new System.Drawing.Point(0, 49);
            lvMonster.Name = "lvMonster";
            lvMonster.Size = new System.Drawing.Size(384, 291);
            lvMonster.TabIndex = 8;
            lvMonster.UseCompatibleStateImageBehavior = false;
            lvMonster.ViewType = ViewTypes.Details;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 130;
            // 
            // colType
            // 
            colType.Text = "Type";
            colType.Width = 64;
            // 
            // colLevel
            // 
            colLevel.Text = "Level";
            colLevel.Width = 50;
            // 
            // colPosition
            // 
            colPosition.Text = "Position";
            colPosition.Width = 125;
            // 
            // checkBoxAutoSelectUniques
            // 
            checkBoxAutoSelectUniques.AutoSize = true;
            checkBoxAutoSelectUniques.BackColor = SKColors.Transparent;
            checkBoxAutoSelectUniques.Depth = 0;
            checkBoxAutoSelectUniques.Location = new System.Drawing.Point(23, 383);
            checkBoxAutoSelectUniques.Margin = new Padding(0);
            checkBoxAutoSelectUniques.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxAutoSelectUniques.Name = "checkBoxAutoSelectUniques";
            checkBoxAutoSelectUniques.Ripple = true;
            checkBoxAutoSelectUniques.Size = new System.Drawing.Size(225, 30);
            checkBoxAutoSelectUniques.TabIndex = 17;
            checkBoxAutoSelectUniques.Text = "Automatically select uniques";
            checkBoxAutoSelectUniques.UseVisualStyleBackColor = false;
            checkBoxAutoSelectUniques.CheckedChanged += checkBoxAutoSelectUniques_CheckedChanged;
            // 
            // label3
            // 
            label3.ApplyGradient = false;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label3.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label3.GradientAnimation = false;
            label3.Location = new System.Drawing.Point(23, 416);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(325, 57);
            label3.TabIndex = 18;
            label3.Text = "This function does not work while the bot is active.\r\n If you want the bot to auto attack while active,\r\n set Avoidance.";
            // 
            // timerUniqueChecker
            // 
            timerUniqueChecker.Enabled = true;
            timerUniqueChecker.Interval = 2500;
            timerUniqueChecker.Elapsed += timerUniqueChecker_Tick;
            // 
            // checkEnableCollisions
            // 
            checkEnableCollisions.AutoSize = true;
            checkEnableCollisions.BackColor = SKColors.Transparent;
            checkEnableCollisions.Checked = true;
            checkEnableCollisions.CheckState = CheckState.Checked;
            checkEnableCollisions.Depth = 0;
            checkEnableCollisions.Location = new System.Drawing.Point(23, 355);
            checkEnableCollisions.Margin = new Padding(0);
            checkEnableCollisions.MouseLocation = new System.Drawing.Point(-1, -1);
            checkEnableCollisions.Name = "checkEnableCollisions";
            checkEnableCollisions.Ripple = true;
            checkEnableCollisions.Size = new System.Drawing.Size(204, 30);
            checkEnableCollisions.TabIndex = 19;
            checkEnableCollisions.Text = "Enable collision detection";
            checkEnableCollisions.UseVisualStyleBackColor = false;
            checkEnableCollisions.CheckedChanged += checkEnableCollisions_CheckedChanged;
            // 
            // tabControl1
            // 
            tabControl1.TabPages.Add(mapCanvas);
            tabControl1.TabPages.Add(tabNavMeshViewer);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Radius = new Padding(4);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(366, 501);
            tabControl1.TabIndex = 20;
            // 
            // mapCanvas
            // 
            mapCanvas.BackColor = SKColors.White;
            mapCanvas.Location = new System.Drawing.Point(4, 28);
            mapCanvas.Name = "mapCanvas";
            mapCanvas.Padding = new Padding(3);
            mapCanvas.Size = new System.Drawing.Size(358, 469);
            mapCanvas.TabIndex = 0;
            mapCanvas.Text = "Minimap";
            mapCanvas.Paint += tabMinimap_Paint;
            mapCanvas.Click += mapCanvas_MouseClick;
            // 
            // tabNavMeshViewer
            // 
            tabNavMeshViewer.BackColor = SKColors.White;
            tabNavMeshViewer.Controls.Add(panelNavMeshRendererCanvas);
            tabNavMeshViewer.Controls.Add(panel2);
            tabNavMeshViewer.Location = new System.Drawing.Point(4, 28);
            tabNavMeshViewer.Name = "tabNavMeshViewer";
            tabNavMeshViewer.Padding = new Padding(3);
            tabNavMeshViewer.Size = new System.Drawing.Size(358, 469);
            tabNavMeshViewer.TabIndex = 1;
            tabNavMeshViewer.Text = "NavMesh Viewer";
            // 
            // btnNvmResetToPlayer
            // 
            btnNvmResetToPlayer.Color = SKColors.Transparent;
            btnNvmResetToPlayer.Location = new System.Drawing.Point(14, 7);
            btnNvmResetToPlayer.Name = "btnNvmResetToPlayer";
            btnNvmResetToPlayer.Radius = 6;
            btnNvmResetToPlayer.ShadowDepth = 4F;
            btnNvmResetToPlayer.Size = new System.Drawing.Size(122, 23);
            btnNvmResetToPlayer.TabIndex = 16;
            btnNvmResetToPlayer.Text = "Reset to player";
            btnNvmResetToPlayer.UseVisualStyleBackColor = true;
            btnNvmResetToPlayer.Click += btnNvmResetToPlayer_Click;
            // 
            // labelSectorInfo
            // 
            labelSectorInfo.ApplyGradient = false;
            labelSectorInfo.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            labelSectorInfo.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            labelSectorInfo.GradientAnimation = false;
            labelSectorInfo.Location = new System.Drawing.Point(619, 10);
            labelSectorInfo.Name = "labelSectorInfo";
            labelSectorInfo.Size = new System.Drawing.Size(128, 17);
            labelSectorInfo.TabIndex = 15;
            labelSectorInfo.Text = "000x000";
            labelSectorInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelNavMeshRendererCanvas
            // 
            panelNavMeshRendererCanvas.BackColor = new SkiaSharp.SKColor(64, 64, 64);
            panelNavMeshRendererCanvas.Dock = DockStyle.Fill;
            panelNavMeshRendererCanvas.Location = new System.Drawing.Point(3, 3);
            panelNavMeshRendererCanvas.Name = "panelNavMeshRendererCanvas";
            panelNavMeshRendererCanvas.Size = new System.Drawing.Size(352, 427);
            panelNavMeshRendererCanvas.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lvMonster);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(checkEnableCollisions);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkBoxAutoSelectUniques);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new System.Drawing.Point(366, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(384, 501);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = SKColors.Transparent;
            panel2.Controls.Add(btnNvmResetToPlayer);
            panel2.Controls.Add(labelSectorInfo);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(3, 430);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(352, 36);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Controls.Add(comboViewType);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(384, 49);
            panel3.TabIndex = 20;
            // 
            // Main
            // 
            
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Main";
            Size = new System.Drawing.Size(750, 501);
            ParentChanged += Main_Load;
            tabControl1.ResumeLayout(false);
            tabNavMeshViewer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SDUI.ListView lvMonster;
        private ColumnHeader colName;
        private ColumnHeader colType;
        private ColumnHeader colLevel;
        private SDUI.Label label4;
        private SDUI.ComboBox comboViewType;
        private ColumnHeader colPosition;
        private Timer trmInterval;
        private SDUI.CheckBox checkBoxAutoSelectUniques;
        private SDUI.Label label3;
        private Timer timerUniqueChecker;
        private SDUI.CheckBox checkEnableCollisions;
        private SDUI.TabControl tabControl1;
        private TabPage mapCanvas;
        private TabPage tabNavMeshViewer;
        private Panel panelNavMeshRendererCanvas;
        private SDUI.Label labelSectorInfo;
        private SDUI.Button btnNvmResetToPlayer;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
