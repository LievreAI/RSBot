using RSBot.Views.Controls;
using SDUI;
using SkiaSharp;


namespace RSBot.Views
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
            stripStatus = new ToolBar();
            lblIngameStatus = new MenuItem();
            menuCurrentProfile = new MenuItem();
            cosController = new Controls.Cos.CosController();
            bottomPanel = new SDUI.Panel();
            buttonConfig = new SDUI.Button();
            comboServer = new SDUI.ComboBox();
            comboDivision = new SDUI.ComboBox();
            btnSave = new SDUI.Button();
            btnStartStop = new SDUI.Button();
            pSidebar = new SDUI.Panel();
            pSidebarCustom = new Panel();
            entity1 = new Entity();
            botbase1MenuItem1 = new MenuItem();
            botbase1MenuItem = new MenuItem();
            fileMenuItem = new MenuItem();
            menuSelectProfile = new MenuItem();
            networkConfigMenuItem = new MenuItem();
            menuItemExit = new MenuItem();
            viewMenuItem = new MenuItem();
            menuSidebar = new MenuItem();
            toolsMenuItem = new MenuItem();
            menuScriptRecorder = new MenuItem();
            menuPlugins = new MenuItem();
            aboutMenuItem = new MenuItem();
            thisMenuItem = new MenuItem();
            menuStrip = new SDUI.ContextMenu();
            botsMenuItem = new MenuItem();
            languageMenuItem = new MenuItem();
            themeMenuItem = new MenuItem();
            darkMenuItem = new MenuItem();
            lightMenuItem = new MenuItem();
            autoMenuItem = new MenuItem();
            coloredMenuItem = new MenuItem();
            topCharacter = new Character();
            windowPageControl = new SDUI.TabControl();
            stripStatus.SuspendLayout();
            bottomPanel.SuspendLayout();
            pSidebar.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // stripStatus
            // 
            stripStatus.BackColor = new SkiaSharp.SKColor(33, 150, 243);
            stripStatus.Items.AddRange(new MenuItem[] { lblIngameStatus, menuCurrentProfile });
            stripStatus.Location = new System.Drawing.Point(0, 644);
            stripStatus.Dock = DockStyle.Bottom;
            stripStatus.Name = "stripStatus";
            stripStatus.Size = new System.Drawing.Size(1004, 22);
            stripStatus.TabIndex = 0;
            stripStatus.Tag = "private";
            // 
            // lblIngameStatus
            // 
            lblIngameStatus.Name = "lblIngameStatus";
            lblIngameStatus.Text = "Not in game";
            // 
            // menuCurrentProfile
            // 
            menuCurrentProfile.Name = "menuCurrentProfile";
            menuCurrentProfile.Text = "Profile: Default";
            menuCurrentProfile.Click += menuSelectProfile_Click;
            // 
            // cosController
            // 
            cosController.AutoSize = true;
            cosController.Dock = DockStyle.Top;
            cosController.Location = new System.Drawing.Point(0, 0);
            cosController.Margin = new Padding(4);
            cosController.Name = "cosController";
            cosController.Padding = new Padding(3);
            cosController.Size = new System.Drawing.Size(250, 70);
            cosController.TabIndex = 9;
            cosController.Visible = false;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = SKColors.Transparent;
            bottomPanel.Border = new Padding(0, 1, 0, 0);
            bottomPanel.BorderColor = SKColors.Transparent;
            bottomPanel.Controls.Add(buttonConfig);
            bottomPanel.Controls.Add(comboServer);
            bottomPanel.Controls.Add(comboDivision);
            bottomPanel.Controls.Add(btnSave);
            bottomPanel.Controls.Add(btnStartStop);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new System.Drawing.Point(0, 592);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.ShadowDepth = 8F;
            bottomPanel.Size = new System.Drawing.Size(1004, 52);
            bottomPanel.TabIndex = 2;
            // 
            // buttonConfig
            // 
            buttonConfig.AutoSize = true;
            buttonConfig.Color = SKColors.Transparent;
            buttonConfig.Location = new System.Drawing.Point(249, 15);
            buttonConfig.Name = "buttonConfig";
            buttonConfig.ShadowDepth = 4F;
            buttonConfig.Size = new System.Drawing.Size(60, 23);
            buttonConfig.TabIndex = 12;
            buttonConfig.Text = "IP Bind";
            buttonConfig.UseVisualStyleBackColor = true;
            buttonConfig.Click += buttonConfig_Click;
            // 
            // comboServer
            // 
            comboServer.Location = new System.Drawing.Point(111, 15);
            comboServer.Name = "comboServer";
            comboServer.ShadowDepth = 4F;
            comboServer.Size = new System.Drawing.Size(132, 23);
            comboServer.TabIndex = 11;
            comboServer.SelectedIndexChanged += comboServer_SelectedIndexChanged;
            // 
            // comboDivision
            // 
            comboDivision.Location = new System.Drawing.Point(14, 15);
            comboDivision.Name = "comboDivision";
            comboDivision.ShadowDepth = 4F;
            comboDivision.Size = new System.Drawing.Size(91, 23);
            comboDivision.TabIndex = 10;
            comboDivision.SelectedIndexChanged += comboDivision_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Color = new SkiaSharp.SKColor(56, 155, 90);
            btnSave.ForeColor = SKColors.White;
            btnSave.Location = new System.Drawing.Point(782, 12);
            btnSave.Name = "btnSave";
            btnSave.ShadowDepth = 4F;
            btnSave.Size = new System.Drawing.Size(100, 27);
            btnSave.TabIndex = 1;
            btnSave.TabStop = false;
            btnSave.Tag = "private";
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartStop.BackColor = SKColors.DodgerBlue;
            btnStartStop.Color = new SkiaSharp.SKColor(33, 150, 243);
             btnStartStop.ForeColor = SKColors.White;
            btnStartStop.Location = new System.Drawing.Point(888, 12);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.ShadowDepth = 4F;
            btnStartStop.Size = new System.Drawing.Size(100, 27);
            btnStartStop.TabIndex = 0;
            btnStartStop.TabStop = false;
            btnStartStop.Tag = "private";
            btnStartStop.Text = "START BOT";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // pSidebar
            // 
            pSidebar.BackColor = SKColors.Transparent;
            pSidebar.Border = new Padding(1, 0, 0, 0);
            pSidebar.BorderColor = SKColors.Transparent;
            pSidebar.Controls.Add(pSidebarCustom);
            pSidebar.Controls.Add(entity1);
            pSidebar.Controls.Add(cosController);
            pSidebar.Dock = DockStyle.Right;
            pSidebar.Location = new System.Drawing.Point(754, 32);
            pSidebar.Name = "pSidebar";
            pSidebar.ShadowDepth = 0F;
            pSidebar.Size = new System.Drawing.Size(250, 560);
            pSidebar.TabIndex = 6;
            // 
            // pSidebarCustom
            // 
            pSidebarCustom.Dock = DockStyle.Fill;
            pSidebarCustom.Location = new System.Drawing.Point(0, 153);
            pSidebarCustom.Margin = new Padding(3, 30, 3, 3);
            pSidebarCustom.Name = "pSidebarCustom";
            pSidebarCustom.Padding = new Padding(0, 16, 0, 0);
            pSidebarCustom.Size = new System.Drawing.Size(250, 407);
            pSidebarCustom.TabIndex = 14;
            // 
            // entity1
            // 
            entity1.Dock = DockStyle.Top;
            entity1.Location = new System.Drawing.Point(0, 70);
            entity1.Margin = new Padding(4);
            entity1.MinimumSize = new System.Drawing.Size(250, 76);
            entity1.Name = "entity1";
            entity1.Size = new System.Drawing.Size(250, 83);
            entity1.TabIndex = 10;
            // 
            // botbase1MenuItem1
            // 
            botbase1MenuItem1.Name = "botbase1MenuItem1";
            botbase1MenuItem1.Text = "Botbase #2";
            // 
            // botbase1MenuItem
            // 
            botbase1MenuItem.Name = "botbase1MenuItem";
            botbase1MenuItem.Text = "Botbase #1";
            // 
            // fileMenuItem
            // 
            fileMenuItem.Items.AddRange(new MenuItem[] { menuSelectProfile, networkConfigMenuItem, menuItemExit });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Text = "File";
            // 
            // menuSelectProfile
            // 
            menuSelectProfile.Name = "menuSelectProfile";
            menuSelectProfile.Text = "Select Profile...";
            menuSelectProfile.Click += menuSelectProfile_Click;
            // 
            // networkConfigMenuItem
            // 
            networkConfigMenuItem.Name = "networkConfigMenuItem";
            networkConfigMenuItem.Text = "Proxy Config";
            networkConfigMenuItem.Click += networkConfigMenuItem_Click;
            // 
            // menuItemExit
            // 
            menuItemExit.Name = "menuItemExit";
            menuItemExit.Text = "Exit";
            menuItemExit.Click += menuItemExit_Click;
            // 
            // viewMenuItem
            // 
            viewMenuItem.Items.AddRange(new MenuItem[] { menuSidebar });
            viewMenuItem.Name = "viewMenuItem";
            viewMenuItem.Text = "View";
            // 
            // menuSidebar
            // 
            menuSidebar.Name = "menuSidebar";
            menuSidebar.Text = "Sidebar";
            menuSidebar.Click += menuSidebar_Click;
            // 
            // toolsMenuItem
            // 
            toolsMenuItem.Items.AddRange(new MenuItem[] { menuScriptRecorder });
            toolsMenuItem.Name = "toolsMenuItem";
            toolsMenuItem.Text = "Tools";
            // 
            // menuScriptRecorder
            // 
            menuScriptRecorder.Name = "menuScriptRecorder";
            menuScriptRecorder.Text = "Script Recorder";
            menuScriptRecorder.Click += menuScriptRecorder_Click;
            // 
            // menuPlugins
            // 
            menuPlugins.Name = "menuPlugins";
            menuPlugins.Text = "Plugins";
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Items.AddRange(new MenuItem[] { thisMenuItem });
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Text = "About";
            // 
            // thisMenuItem
            // 
            thisMenuItem.Name = "thisMenuItem";
            thisMenuItem.Text = "This";
            thisMenuItem.Click += menuItemThis_Click;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = new SkiaSharp.SKColor(0, 0, 0, 0);
            menuStrip.Items.AddRange(new MenuItem[] { fileMenuItem, viewMenuItem, toolsMenuItem, menuPlugins, botsMenuItem, languageMenuItem, themeMenuItem, aboutMenuItem });
            menuStrip.Name = "menuStrip";
            menuStrip.Dock = DockStyle.Top;
            menuStrip.Size = new System.Drawing.Size(134, 180);
            menuStrip.BringToFront();
            // 
            // botsMenuItem
            // 
            botsMenuItem.Name = "botsMenuItem";
            botsMenuItem.Text = "Bots";
            // 
            // languageMenuItem
            // 
            languageMenuItem.Name = "languageMenuItem";
            languageMenuItem.Text = "Language";
            // 
            // themeMenuItem
            // 
            themeMenuItem.Items.AddRange(new MenuItem[] { darkMenuItem, lightMenuItem, autoMenuItem, coloredMenuItem });
            themeMenuItem.Name = "themeMenuItem";
            themeMenuItem.Text = "Theme";
            // 
            // darkMenuItem
            // 
            darkMenuItem.Name = "darkMenuItem";
            darkMenuItem.Text = "Dark";
            darkMenuItem.Click += darkMenuItem_Click;
            // 
            // lightMenuItem
            // 
            lightMenuItem.Name = "lightMenuItem";
            lightMenuItem.Text = "Light";
            lightMenuItem.Click += lightMenuItem_Click;
            // 
            // autoMenuItem
            // 
            autoMenuItem.Name = "autoMenuItem";
            autoMenuItem.Text = "Auto";
            autoMenuItem.Click += autoMenuItem_Click;
            // 
            // coloredMenuItem
            // 
            coloredMenuItem.Name = "coloredMenuItem";
            coloredMenuItem.Text = "Choose a color";
            coloredMenuItem.Click += coloredMenuItem_Click;
            // 
            // topCharacter
            // 
            topCharacter.BackColor = SKColors.Transparent;
            topCharacter.Dock = DockStyle.Top;
            topCharacter.Location = new System.Drawing.Point(0, 32);
            topCharacter.Margin = new Padding(4);
            topCharacter.Name = "topCharacter";
            topCharacter.Size = new System.Drawing.Size(754, 74);
            topCharacter.TabIndex = 7;
            // 
            // windowPageControl
            // 
            windowPageControl.Dock = DockStyle.Fill;
            windowPageControl.Location = new System.Drawing.Point(0, 106);
            windowPageControl.Name = "windowPageControl";
            windowPageControl.SelectedIndex = -1;
            windowPageControl.Size = new System.Drawing.Size(754, 486);
            windowPageControl.TabIndex = 13;
            // 
            // Main
            // 
            
            Controls.Add(windowPageControl);
            Controls.Add(topCharacter);
            Controls.Add(pSidebar);
            Controls.Add(bottomPanel);
            Controls.Add(stripStatus);
            Padding = new Padding(0, 41, 0, 0);
            Location = new System.Drawing.Point(0, 0);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Closing += Main_FormClosing;
            Load += Main_Load;
            Resize += Main_Resize;
            stripStatus.ResumeLayout(false);
            stripStatus.PerformLayout();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            pSidebar.ResumeLayout(false);
            pSidebar.PerformLayout();
            menuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolBar stripStatus;
        private SDUI.Panel bottomPanel;
        private SDUI.Panel pSidebar;
        private MenuItem lblIngameStatus;
        private SDUI.Button btnStartStop;
        private SDUI.Button btnSave;
        private Controls.Character topCharacter;
        private Controls.Cos.CosController cosController;
        private SDUI.ComboBox comboServer;
        private SDUI.ComboBox comboDivision;
        private MenuItem botbase1MenuItem1;
        private MenuItem botbase1MenuItem;
        private MenuItem fileMenuItem;
        private MenuItem menuItemExit;
        private MenuItem viewMenuItem;
        private MenuItem menuSidebar;
        private MenuItem toolsMenuItem;
        private MenuItem menuScriptRecorder;
        private MenuItem menuPlugins;
        private MenuItem aboutMenuItem;
        private MenuItem thisMenuItem;
        private SDUI.ContextMenu menuStrip;
        private MenuItem themeMenuItem;
        private MenuItem darkMenuItem;
        private MenuItem lightMenuItem;
        private MenuItem coloredMenuItem;
        private MenuItem languageMenuItem;
        private MenuItem menuSelectProfile;
        private MenuItem botsMenuItem;
        private MenuItem autoMenuItem;
        private SDUI.Button buttonConfig;
        private MenuItem networkConfigMenuItem;
        private MenuItem menuCurrentProfile;
        private SDUI.TabControl windowPageControl;
        private Entity entity1;
        private Panel pSidebarCustom;
    }
}

