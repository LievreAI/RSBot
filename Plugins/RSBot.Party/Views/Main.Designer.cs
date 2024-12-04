namespace RSBot.Party.Views
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
            tabMain = new SDUI.TabControl();
            tabCurrentParty = new TabPage();
            listParty = new SDUI.ListView();
            colMemberName = new ColumnHeader();
            colLevel = new ColumnHeader();
            colGuild = new ColumnHeader();
            colMasteries = new ColumnHeader();
            colLocation = new ColumnHeader();
            contextParty = new SDUI.ContextMenu();
            contextPartyBuffs = new SDUI.ContextMenu();
            menuBanish = new MenuItem();
            menuLeave = new MenuItem();
            menuItemAddToBuffing = new MenuItem();
            menuItemRefreshBuffs = new MenuItem();
            Splitter3 = new SDUI.Splitter();
            panel1 = new SDUI.Panel();
            btnLeaveParty = new SDUI.Button();
            label1 = new SDUI.Label();
            lblLeader = new SDUI.Label();
            grpPartySettings = new SDUI.GroupBox();
            checkCurrentAllowInvitations = new SDUI.CheckBox();
            checkCurrentAutoShareItems = new SDUI.CheckBox();
            checkCurrentAutoShareEXP = new SDUI.CheckBox();
            tpAutoParty = new TabPage();
            groupBox2 = new SDUI.GroupBox();
            checkBoxFollowMaster = new SDUI.CheckBox();
            Splitter10 = new SDUI.Splitter();
            labelCommandsInfo = new SDUI.Label();
            Splitter2 = new SDUI.Splitter();
            Splitter1 = new SDUI.Splitter();
            textBoxLeaveIfMasterNotName = new SDUI.TextBox();
            checkBoxListenCommandsOnlyList = new SDUI.CheckBox();
            checkBoxListenMasterCommands = new SDUI.CheckBox();
            checkBoxLeaveIfMasterNot = new SDUI.CheckBox();
            checkAcceptIfBotStopped = new SDUI.CheckBox();
            checkAcceptAtTrainingPlace = new SDUI.CheckBox();
            label2 = new SDUI.Label();
            checkInviteFromList = new SDUI.CheckBox();
            checkInviteAll = new SDUI.CheckBox();
            checkAcceptFromList = new SDUI.CheckBox();
            checkAcceptAll = new SDUI.CheckBox();
            Splitter6 = new SDUI.Splitter();
            panel2 = new Panel();
            groupBox7 = new SDUI.GroupBox();
            listCommandPlayers = new SDUI.ListView();
            columnHeader3 = new ColumnHeader();
            panel4 = new SDUI.Panel();
            buttonCommandPlayerAdd = new SDUI.Button();
            buttonCommandPlayerRemove = new SDUI.Button();
            Splitter4 = new SDUI.Splitter();
            groupBox3 = new SDUI.GroupBox();
            listAutoParty = new SDUI.ListView();
            columnHeader2 = new ColumnHeader();
            panel3 = new SDUI.Panel();
            btnAddToAutoParty = new SDUI.Button();
            btnRemoveFromAutoParty = new SDUI.Button();
            Splitter5 = new SDUI.Splitter();
            grbAutoPartySettings = new SDUI.GroupBox();
            checkAutoAllowInvitations = new SDUI.CheckBox();
            checkAutoItemAutoShare = new SDUI.CheckBox();
            checkAutoExpAutoShare = new SDUI.CheckBox();
            tpPartyMatching = new TabPage();
            lvPartyMatching = new SDUI.ListView();
            chPartyMatchNo = new ColumnHeader();
            chPartyMatchRace = new ColumnHeader();
            chPartyMatchName = new ColumnHeader();
            chPartyMatchTitle = new ColumnHeader();
            chPartyMatchPurporse = new ColumnHeader();
            chPartyMatchMember = new ColumnHeader();
            chPartyMatchRange = new ColumnHeader();
            topPartyPanel = new SDUI.Panel();
            buttonConfirmJoinConfig = new SDUI.Button();
            textBoxJoinByTitle = new SDUI.TextBox();
            textBoxJoinByName = new SDUI.TextBox();
            checkBoxJoinByTitle = new SDUI.CheckBox();
            checkBoxJoinByName = new SDUI.CheckBox();
            Splitter11 = new SDUI.Splitter();
            buttonAutoJoinConfig = new SDUI.Button();
            btnPartyRefresh = new SDUI.Button();
            btnPartySearch = new SDUI.Button();
            nudPartySearchMax = new SDUI.NumUpDown();
            nudPartySearchMin = new SDUI.NumUpDown();
            cbPartySearchPurpose = new SDUI.ComboBox();
            tbPartySearchName = new SDUI.TextBox();
            label6 = new SDUI.Label();
            label5 = new SDUI.Label();
            label4 = new SDUI.Label();
            label3 = new SDUI.Label();
            bottomPartyPanel = new SDUI.Panel();
            btnPartyMatchDeleteEntry = new SDUI.Button();
            btnPartyMatchChangeEntry = new SDUI.Button();
            btnPartyMatchForm = new SDUI.Button();
            btnAutoMatchParty = new SDUI.Button();
            btnWhisperPartyMaster = new SDUI.Button();
            btnJoinFormedParty = new SDUI.Button();
            btnPrev = new SDUI.Button();
            btnNext = new SDUI.Button();
            lbl_partyPageRange = new SDUI.Label();
            tpPartyBuffing = new TabPage();
            groupBox4 = new SDUI.GroupBox();
            btnAddBuffToMember = new SDUI.Button();
            buttonRemoveCharFromBuffing = new SDUI.Button();
            btnRemoveBuffFromMember = new SDUI.Button();
            listViewPartyMembers = new SDUI.ListView();
            chPlayerName = new ColumnHeader();
            chPlayerLevel = new ColumnHeader();
            Splitter9 = new SDUI.Splitter();
            groupBox6 = new SDUI.GroupBox();
            buttonAddGroup = new SDUI.Button();
            buttonRemoveGroup = new SDUI.Button();
            listViewGroups = new SDUI.ListView();
            columnHeaderGroupName = new ColumnHeader();
            columnHeaderMembersCount = new ColumnHeader();
            Splitter8 = new SDUI.Splitter();
            groupBox5 = new SDUI.GroupBox();
            selectedMemberBuffs = new SDUI.ListView();
            columnHeader1 = new ColumnHeader();
            Splitter7 = new SDUI.Splitter();
            groupBox1 = new SDUI.GroupBox();
            listPartyBuffSkills = new SDUI.ListView();
            columnName = new ColumnHeader();
            columnLimit = new ColumnHeader();
            panel5 = new SDUI.Panel();
            checkHideLowerLevelSkills = new SDUI.CheckBox();
            tabMain.SuspendLayout();
            tabCurrentParty.SuspendLayout();
            contextParty.SuspendLayout();
            contextPartyBuffs.SuspendLayout();
            panel1.SuspendLayout();
            grpPartySettings.SuspendLayout();
            tpAutoParty.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox7.SuspendLayout();
            panel4.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            grbAutoPartySettings.SuspendLayout();
            tpPartyMatching.SuspendLayout();
            topPartyPanel.SuspendLayout();
            bottomPartyPanel.SuspendLayout();
            tpPartyBuffing.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabCurrentParty);
            tabMain.Controls.Add(tpAutoParty);
            tabMain.Controls.Add(tpPartyMatching);
            tabMain.Controls.Add(tpPartyBuffing);
            tabMain.Dock = DockStyle.Fill;
            tabMain.ItemSize = new System.Drawing.Size(80, 24);
            tabMain.Location = new System.Drawing.Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.Radius = new Padding(4);
            tabMain.SelectedIndex = 0;
            tabMain.Size = new System.Drawing.Size(754, 467);
            tabMain.TabIndex = 0;
            tabMain.SelectedIndexChanged += tabMain_SelectedIndexChanged;
            // 
            // tabCurrentParty
            // 
            tabCurrentParty.BackColor = SKColors.White;
            tabCurrentParty.Controls.Add(listParty);
            tabCurrentParty.Controls.Add(Splitter3);
            tabCurrentParty.Controls.Add(panel1);
            tabCurrentParty.Controls.Add(grpPartySettings);
            tabCurrentParty.Location = new System.Drawing.Point(4, 28);
            tabCurrentParty.Name = "tabCurrentParty";
            tabCurrentParty.Padding = new Padding(3);
            tabCurrentParty.Size = new System.Drawing.Size(746, 435);
            tabCurrentParty.TabIndex = 0;
            tabCurrentParty.Text = "Party";
            // 
            // listParty
            // 
            listParty.BackColor = SKColors.White;
            listParty.BorderStyle = BorderStyle.None;
            listParty.Columns.AddRange(new ColumnHeader[] { colMemberName, colLevel, colGuild, colMasteries, colLocation });
            listParty.ContextMenu = contextParty;
            listParty.Dock = DockStyle.Fill;
            listParty.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            listParty.FullRowSelect = true;
            listParty.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listParty.Location = new System.Drawing.Point(3, 93);
            listParty.MultiSelect = false;
            listParty.Name = "listParty";
            listParty.Size = new System.Drawing.Size(740, 307);
            listParty.TabIndex = 0;
            listParty.UseCompatibleStateImageBehavior = false;
            listParty.ViewType = ViewTypes.Details;
            // 
            // colMemberName
            // 
            colMemberName.Text = "Name";
            colMemberName.Width = 158;
            // 
            // colLevel
            // 
            colLevel.Text = "Level";
            colLevel.Width = 47;
            // 
            // colGuild
            // 
            colGuild.Text = "Guild";
            colGuild.Width = 145;
            // 
            // colMasteries
            // 
            colMasteries.Text = "Masteries";
            colMasteries.Width = 208;
            // 
            // colLocation
            // 
            colLocation.Text = "Location";
            // 
            // contextParty
            // 
            contextParty.Items.AddRange(new MenuItem[] { menuBanish, menuLeave, menuItemAddToBuffing });
            contextParty.Name = "contextParty";
            contextParty.Size = new System.Drawing.Size(153, 70);
            // 
            // menuBanish
            // 
            menuBanish.Enabled = false;
            menuBanish.Name = "menuBanish";
            menuBanish.Size = new System.Drawing.Size(152, 22);
            menuBanish.Text = "Banish";
            menuBanish.Click += menuBanish_Click;
            // 
            // menuLeave
            // 
            menuLeave.Enabled = false;
            menuLeave.Name = "menuLeave";
            menuLeave.Size = new System.Drawing.Size(152, 22);
            menuLeave.Text = "Leave";
            menuLeave.Click += btnLeaveParty_Click;
            // 
            // menuItemAddToBuffing
            // 
            menuItemAddToBuffing.Name = "menuItemAddToBuffing";
            menuItemAddToBuffing.Size = new System.Drawing.Size(152, 22);
            menuItemAddToBuffing.Text = "Add to buffing";
            menuItemAddToBuffing.Click += menuItemAddToBuffing_Click;
            // 
            // Splitter3
            // 
            Splitter3.Dock = DockStyle.Top;
            Splitter3.IsVertical = false;
            Splitter3.Location = new System.Drawing.Point(3, 83);
            Splitter3.Name = "Splitter3";
            Splitter3.Size = new System.Drawing.Size(740, 10);
            Splitter3.TabIndex = 9;
            Splitter3.Text = "Splitter3";
            // 
            // panel1
            // 
            panel1.BackColor = SKColors.Transparent;
            panel1.Border = new Padding(0, 1, 0, 0);
            panel1.BorderColor = SKColors.Transparent;
            panel1.Controls.Add(btnLeaveParty);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblLeader);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(3, 400);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6);
            panel1.Radius = 0;
            panel1.ShadowDepth = 4F;
            panel1.Size = new System.Drawing.Size(740, 32);
            panel1.TabIndex = 8;
            // 
            // btnLeaveParty
            // 
            btnLeaveParty.Color = SKColors.IndianRed;
            btnLeaveParty.Dock = DockStyle.Right;
            btnLeaveParty.Enabled = false;
            btnLeaveParty.ForeColor = SKColors.White;
            btnLeaveParty.Location = new System.Drawing.Point(637, 6);
            btnLeaveParty.Name = "btnLeaveParty";
            btnLeaveParty.Radius = 6;
            btnLeaveParty.ShadowDepth = 4F;
            btnLeaveParty.Size = new System.Drawing.Size(97, 20);
            btnLeaveParty.TabIndex = 2;
            btnLeaveParty.Text = "Leave party";
            btnLeaveParty.Click += btnLeaveParty_Click;
            // 
            // label1
            // 
            label1.ApplyGradient = false;
            label1.BackColor = SKColors.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label1.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label1.GradientAnimation = false;
            label1.Location = new System.Drawing.Point(3, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Leader:";
            // 
            // lblLeader
            // 
            lblLeader.ApplyGradient = false;
            lblLeader.BackColor = SKColors.Transparent;
            lblLeader.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblLeader.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            lblLeader.GradientAnimation = false;
            lblLeader.Location = new System.Drawing.Point(70, 9);
            lblLeader.Name = "lblLeader";
            lblLeader.Size = new System.Drawing.Size(143, 14);
            lblLeader.TabIndex = 1;
            lblLeader.Text = "<Not in a party>";
            // 
            // grpPartySettings
            // 
            grpPartySettings.BackColor = SKColors.Transparent;
            grpPartySettings.Controls.Add(checkCurrentAllowInvitations);
            grpPartySettings.Controls.Add(checkCurrentAutoShareItems);
            grpPartySettings.Controls.Add(checkCurrentAutoShareEXP);
            grpPartySettings.Dock = DockStyle.Top;
            grpPartySettings.Enabled = false;
            grpPartySettings.Location = new System.Drawing.Point(3, 3);
            grpPartySettings.Name = "grpPartySettings";
            grpPartySettings.Padding = new Padding(3, 10, 3, 3);
            grpPartySettings.Radius = 10;
            grpPartySettings.ShadowDepth = 4;
            grpPartySettings.Size = new System.Drawing.Size(740, 80);
            grpPartySettings.TabIndex = 7;
            grpPartySettings.TabStop = false;
            grpPartySettings.Text = "Party settings";
            // 
            // checkCurrentAllowInvitations
            // 
            checkCurrentAllowInvitations.BackColor = SKColors.Transparent;
            checkCurrentAllowInvitations.Depth = 0;
            checkCurrentAllowInvitations.Enabled = false;
            checkCurrentAllowInvitations.Location = new System.Drawing.Point(143, 31);
            checkCurrentAllowInvitations.Margin = new Padding(0);
            checkCurrentAllowInvitations.MouseLocation = new System.Drawing.Point(-1, -1);
            checkCurrentAllowInvitations.Name = "checkCurrentAllowInvitations";
            checkCurrentAllowInvitations.Ripple = true;
            checkCurrentAllowInvitations.Size = new System.Drawing.Size(111, 15);
            checkCurrentAllowInvitations.TabIndex = 6;
            checkCurrentAllowInvitations.Text = "Allow invitations";
            checkCurrentAllowInvitations.UseVisualStyleBackColor = false;
            // 
            // checkCurrentAutoShareItems
            // 
            checkCurrentAutoShareItems.BackColor = SKColors.Transparent;
            checkCurrentAutoShareItems.Depth = 0;
            checkCurrentAutoShareItems.Enabled = false;
            checkCurrentAutoShareItems.Location = new System.Drawing.Point(13, 54);
            checkCurrentAutoShareItems.Margin = new Padding(0);
            checkCurrentAutoShareItems.MouseLocation = new System.Drawing.Point(-1, -1);
            checkCurrentAutoShareItems.Name = "checkCurrentAutoShareItems";
            checkCurrentAutoShareItems.Ripple = true;
            checkCurrentAutoShareItems.Size = new System.Drawing.Size(105, 15);
            checkCurrentAutoShareItems.TabIndex = 5;
            checkCurrentAutoShareItems.Text = "Item auto share";
            checkCurrentAutoShareItems.UseVisualStyleBackColor = false;
            // 
            // checkCurrentAutoShareEXP
            // 
            checkCurrentAutoShareEXP.BackColor = SKColors.Transparent;
            checkCurrentAutoShareEXP.Depth = 0;
            checkCurrentAutoShareEXP.Enabled = false;
            checkCurrentAutoShareEXP.Location = new System.Drawing.Point(13, 31);
            checkCurrentAutoShareEXP.Margin = new Padding(0);
            checkCurrentAutoShareEXP.MouseLocation = new System.Drawing.Point(-1, -1);
            checkCurrentAutoShareEXP.Name = "checkCurrentAutoShareEXP";
            checkCurrentAutoShareEXP.Ripple = true;
            checkCurrentAutoShareEXP.Size = new System.Drawing.Size(103, 15);
            checkCurrentAutoShareEXP.TabIndex = 5;
            checkCurrentAutoShareEXP.Text = "EXP Auto share";
            checkCurrentAutoShareEXP.UseVisualStyleBackColor = false;
            // 
            // tpAutoParty
            // 
            tpAutoParty.BackColor = SKColors.White;
            tpAutoParty.Controls.Add(groupBox2);
            tpAutoParty.Controls.Add(Splitter6);
            tpAutoParty.Controls.Add(panel2);
            tpAutoParty.Controls.Add(Splitter5);
            tpAutoParty.Controls.Add(grbAutoPartySettings);
            tpAutoParty.Location = new System.Drawing.Point(4, 28);
            tpAutoParty.Name = "tpAutoParty";
            tpAutoParty.Padding = new Padding(3);
            tpAutoParty.Size = new System.Drawing.Size(746, 435);
            tpAutoParty.TabIndex = 1;
            tpAutoParty.Text = "Auto Party";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SKColors.Transparent;
            groupBox2.Controls.Add(checkBoxFollowMaster);
            groupBox2.Controls.Add(Splitter10);
            groupBox2.Controls.Add(labelCommandsInfo);
            groupBox2.Controls.Add(Splitter2);
            groupBox2.Controls.Add(Splitter1);
            groupBox2.Controls.Add(textBoxLeaveIfMasterNotName);
            groupBox2.Controls.Add(checkBoxListenCommandsOnlyList);
            groupBox2.Controls.Add(checkBoxListenMasterCommands);
            groupBox2.Controls.Add(checkBoxLeaveIfMasterNot);
            groupBox2.Controls.Add(checkAcceptIfBotStopped);
            groupBox2.Controls.Add(checkAcceptAtTrainingPlace);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(checkInviteFromList);
            groupBox2.Controls.Add(checkInviteAll);
            groupBox2.Controls.Add(checkAcceptFromList);
            groupBox2.Controls.Add(checkAcceptAll);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(234, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 10, 3, 3);
            groupBox2.Radius = 10;
            groupBox2.ShadowDepth = 4;
            groupBox2.Size = new System.Drawing.Size(509, 339);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Auto party settings";
            // 
            // checkBoxFollowMaster
            // 
            checkBoxFollowMaster.AutoSize = true;
            checkBoxFollowMaster.BackColor = SKColors.Transparent;
            checkBoxFollowMaster.Depth = 0;
            checkBoxFollowMaster.Location = new System.Drawing.Point(281, 31);
            checkBoxFollowMaster.Margin = new Padding(0);
            checkBoxFollowMaster.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxFollowMaster.Name = "checkBoxFollowMaster";
            checkBoxFollowMaster.Ripple = true;
            checkBoxFollowMaster.Size = new System.Drawing.Size(197, 30);
            checkBoxFollowMaster.TabIndex = 20;
            checkBoxFollowMaster.Text = "Always follow the party master";
            checkBoxFollowMaster.UseVisualStyleBackColor = false;
            checkBoxFollowMaster.CheckedChanged += checkBoxFollowMaster_CheckedChanged;
            // 
            // Splitter10
            // 
            Splitter10.IsVertical = true;
            Splitter10.Location = new System.Drawing.Point(265, 31);
            Splitter10.Name = "Splitter10";
            Splitter10.Size = new System.Drawing.Size(10, 130);
            Splitter10.TabIndex = 19;
            Splitter10.Text = "Splitter10";
            // 
            // labelCommandsInfo
            // 
            labelCommandsInfo.ApplyGradient = false;
            labelCommandsInfo.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCommandsInfo.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            labelCommandsInfo.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            labelCommandsInfo.GradientAnimation = false;
            labelCommandsInfo.Location = new System.Drawing.Point(212, 253);
            labelCommandsInfo.Name = "labelCommandsInfo";
            labelCommandsInfo.Size = new System.Drawing.Size(285, 77);
            labelCommandsInfo.TabIndex = 16;
            labelCommandsInfo.Text = "Commands only using in the game chat window! \r\n\r\ntraceme: Send follow me request to players \r\nsitdown: Send sitdown request to players";
            // 
            // Splitter2
            // 
            Splitter2.IsVertical = false;
            Splitter2.Location = new System.Drawing.Point(20, 214);
            Splitter2.Name = "Splitter2";
            Splitter2.Size = new System.Drawing.Size(464, 11);
            Splitter2.TabIndex = 15;
            Splitter2.Text = "Splitter1";
            // 
            // Splitter1
            // 
            Splitter1.IsVertical = false;
            Splitter1.Location = new System.Drawing.Point(20, 167);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new System.Drawing.Size(464, 11);
            Splitter1.TabIndex = 15;
            Splitter1.Text = "Splitter1";
            // 
            // textBoxLeaveIfMasterNotName
            // 
            textBoxLeaveIfMasterNotName.Location = new System.Drawing.Point(175, 193);
            textBoxLeaveIfMasterNotName.MaxLength = 32767;
            textBoxLeaveIfMasterNotName.MultiLine = false;
            textBoxLeaveIfMasterNotName.Name = "textBoxLeaveIfMasterNotName";
            textBoxLeaveIfMasterNotName.PassFocusShow = false;
            textBoxLeaveIfMasterNotName.Radius = 2;
            textBoxLeaveIfMasterNotName.Size = new System.Drawing.Size(85, 21);
            textBoxLeaveIfMasterNotName.TabIndex = 14;
            textBoxLeaveIfMasterNotName.TextAlignment = HorizontalAlignment.Left;
            textBoxLeaveIfMasterNotName.UseSystemPasswordChar = false;
            // 
            // checkBoxListenCommandsOnlyList
            // 
            checkBoxListenCommandsOnlyList.AutoSize = true;
            checkBoxListenCommandsOnlyList.BackColor = SKColors.Transparent;
            checkBoxListenCommandsOnlyList.Depth = 0;
            checkBoxListenCommandsOnlyList.Location = new System.Drawing.Point(20, 253);
            checkBoxListenCommandsOnlyList.Margin = new Padding(0);
            checkBoxListenCommandsOnlyList.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxListenCommandsOnlyList.Name = "checkBoxListenCommandsOnlyList";
            checkBoxListenCommandsOnlyList.Ripple = true;
            checkBoxListenCommandsOnlyList.Size = new System.Drawing.Size(157, 30);
            checkBoxListenCommandsOnlyList.TabIndex = 13;
            checkBoxListenCommandsOnlyList.Text = "Listen commands in list";
            checkBoxListenCommandsOnlyList.UseVisualStyleBackColor = false;
            checkBoxListenCommandsOnlyList.CheckedChanged += checkAutoPartySetting_CheckedChanged;
            // 
            // checkBoxListenMasterCommands
            // 
            checkBoxListenMasterCommands.AutoSize = true;
            checkBoxListenMasterCommands.BackColor = SKColors.Transparent;
            checkBoxListenMasterCommands.Depth = 0;
            checkBoxListenMasterCommands.Location = new System.Drawing.Point(20, 231);
            checkBoxListenMasterCommands.Margin = new Padding(0);
            checkBoxListenMasterCommands.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxListenMasterCommands.Name = "checkBoxListenMasterCommands";
            checkBoxListenMasterCommands.Ripple = true;
            checkBoxListenMasterCommands.Size = new System.Drawing.Size(197, 30);
            checkBoxListenMasterCommands.TabIndex = 13;
            checkBoxListenMasterCommands.Text = "Listen party master commands";
            checkBoxListenMasterCommands.UseVisualStyleBackColor = false;
            checkBoxListenMasterCommands.CheckedChanged += checkAutoPartySetting_CheckedChanged;
            // 
            // checkBoxLeaveIfMasterNot
            // 
            checkBoxLeaveIfMasterNot.AutoSize = true;
            checkBoxLeaveIfMasterNot.BackColor = SKColors.Transparent;
            checkBoxLeaveIfMasterNot.Depth = 0;
            checkBoxLeaveIfMasterNot.Location = new System.Drawing.Point(20, 190);
            checkBoxLeaveIfMasterNot.Margin = new Padding(0);
            checkBoxLeaveIfMasterNot.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxLeaveIfMasterNot.Name = "checkBoxLeaveIfMasterNot";
            checkBoxLeaveIfMasterNot.Ripple = true;
            checkBoxLeaveIfMasterNot.Size = new System.Drawing.Size(138, 30);
            checkBoxLeaveIfMasterNot.TabIndex = 13;
            checkBoxLeaveIfMasterNot.Text = "Leave, if master not:";
            checkBoxLeaveIfMasterNot.UseVisualStyleBackColor = false;
            checkBoxLeaveIfMasterNot.CheckedChanged += checkAutoPartySetting_CheckedChanged;
            // 
            // checkAcceptIfBotStopped
            // 
            checkAcceptIfBotStopped.AutoSize = true;
            checkAcceptIfBotStopped.BackColor = SKColors.Transparent;
            checkAcceptIfBotStopped.Depth = 0;
            checkAcceptIfBotStopped.Location = new System.Drawing.Point(20, 144);
            checkAcceptIfBotStopped.Margin = new Padding(0);
            checkAcceptIfBotStopped.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAcceptIfBotStopped.Name = "checkAcceptIfBotStopped";
            checkAcceptIfBotStopped.Ripple = true;
            checkAcceptIfBotStopped.Size = new System.Drawing.Size(180, 30);
            checkAcceptIfBotStopped.TabIndex = 12;
            checkAcceptIfBotStopped.Text = "Accept if the bot is stopped";
            checkAcceptIfBotStopped.UseVisualStyleBackColor = false;
            checkAcceptIfBotStopped.CheckedChanged += checkAutoPartySetting_CheckedChanged;
            // 
            // checkAcceptAtTrainingPlace
            // 
            checkAcceptAtTrainingPlace.AutoSize = true;
            checkAcceptAtTrainingPlace.BackColor = SKColors.Transparent;
            checkAcceptAtTrainingPlace.Depth = 0;
            checkAcceptAtTrainingPlace.Location = new System.Drawing.Point(20, 121);
            checkAcceptAtTrainingPlace.Margin = new Padding(0);
            checkAcceptAtTrainingPlace.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAcceptAtTrainingPlace.Name = "checkAcceptAtTrainingPlace";
            checkAcceptAtTrainingPlace.Ripple = true;
            checkAcceptAtTrainingPlace.Size = new System.Drawing.Size(219, 30);
            checkAcceptAtTrainingPlace.TabIndex = 10;
            checkAcceptAtTrainingPlace.Text = "Accept/Invite only at training place";
            checkAcceptAtTrainingPlace.UseVisualStyleBackColor = false;
            checkAcceptAtTrainingPlace.CheckedChanged += checkAutoPartySetting_CheckedChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.ApplyGradient = false;
            label2.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label2.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label2.GradientAnimation = false;
            label2.Location = new System.Drawing.Point(17, 308);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(189, 18);
            label2.TabIndex = 11;
            label2.Text = "* If party settings filter matches";
            // 
            // checkInviteFromList
            // 
            checkInviteFromList.AutoSize = true;
            checkInviteFromList.BackColor = SKColors.Transparent;
            checkInviteFromList.Depth = 0;
            checkInviteFromList.Location = new System.Drawing.Point(20, 98);
            checkInviteFromList.Margin = new Padding(0);
            checkInviteFromList.MouseLocation = new System.Drawing.Point(-1, -1);
            checkInviteFromList.Name = "checkInviteFromList";
            checkInviteFromList.Ripple = true;
            checkInviteFromList.Size = new System.Drawing.Size(231, 30);
            checkInviteFromList.TabIndex = 9;
            checkInviteFromList.Text = "Auto invite all players from player list";
            checkInviteFromList.UseVisualStyleBackColor = false;
            checkInviteFromList.CheckedChanged += checkAutoPartySetting_CheckedChanged;
            // 
            // checkInviteAll
            // 
            checkInviteAll.AutoSize = true;
            checkInviteAll.BackColor = SKColors.Transparent;
            checkInviteAll.Depth = 0;
            checkInviteAll.Location = new System.Drawing.Point(20, 75);
            checkInviteAll.Margin = new Padding(0);
            checkInviteAll.MouseLocation = new System.Drawing.Point(-1, -1);
            checkInviteAll.Name = "checkInviteAll";
            checkInviteAll.Ripple = true;
            checkInviteAll.Size = new System.Drawing.Size(146, 30);
            checkInviteAll.TabIndex = 8;
            checkInviteAll.Text = "Auto invite all players";
            checkInviteAll.UseVisualStyleBackColor = false;
            checkInviteAll.CheckedChanged += checkAutoPartySetting_CheckedChanged;
            // 
            // checkAcceptFromList
            // 
            checkAcceptFromList.AutoSize = true;
            checkAcceptFromList.BackColor = SKColors.Transparent;
            checkAcceptFromList.Depth = 0;
            checkAcceptFromList.Location = new System.Drawing.Point(20, 52);
            checkAcceptFromList.Margin = new Padding(0);
            checkAcceptFromList.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAcceptFromList.Name = "checkAcceptFromList";
            checkAcceptFromList.Ripple = true;
            checkAcceptFromList.Size = new System.Drawing.Size(211, 30);
            checkAcceptFromList.TabIndex = 7;
            checkAcceptFromList.Text = "Accept invitations from player list";
            checkAcceptFromList.UseVisualStyleBackColor = false;
            checkAcceptFromList.CheckedChanged += checkAutoPartySetting_CheckedChanged;
            // 
            // checkAcceptAll
            // 
            checkAcceptAll.AutoSize = true;
            checkAcceptAll.BackColor = SKColors.Transparent;
            checkAcceptAll.Depth = 0;
            checkAcceptAll.Location = new System.Drawing.Point(20, 29);
            checkAcceptAll.Margin = new Padding(0);
            checkAcceptAll.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAcceptAll.Name = "checkAcceptAll";
            checkAcceptAll.Ripple = true;
            checkAcceptAll.Size = new System.Drawing.Size(147, 30);
            checkAcceptAll.TabIndex = 6;
            checkAcceptAll.Text = "Accept all invitations*";
            checkAcceptAll.UseVisualStyleBackColor = false;
            checkAcceptAll.CheckedChanged += checkAutoPartySetting_CheckedChanged;
            // 
            // Splitter6
            // 
            Splitter6.Dock = DockStyle.Left;
            Splitter6.IsVertical = true;
            Splitter6.Location = new System.Drawing.Point(224, 93);
            Splitter6.Name = "Splitter6";
            Splitter6.Size = new System.Drawing.Size(10, 339);
            Splitter6.TabIndex = 16;
            Splitter6.Text = "Splitter6";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox7);
            panel2.Controls.Add(Splitter4);
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new System.Drawing.Point(3, 93);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(221, 339);
            panel2.TabIndex = 14;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = SKColors.Transparent;
            groupBox7.Controls.Add(listCommandPlayers);
            groupBox7.Controls.Add(panel4);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Location = new System.Drawing.Point(0, 189);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(1, 8, 1, 1);
            groupBox7.Radius = 10;
            groupBox7.ShadowDepth = 4;
            groupBox7.Size = new System.Drawing.Size(221, 150);
            groupBox7.TabIndex = 13;
            groupBox7.TabStop = false;
            groupBox7.Text = "Their commands will be listened to";
            // 
            // listCommandPlayers
            // 
            listCommandPlayers.BackColor = SKColors.White;
            listCommandPlayers.BorderStyle = BorderStyle.None;
            listCommandPlayers.Columns.AddRange(new ColumnHeader[] { columnHeader3 });
            listCommandPlayers.Dock = DockStyle.Fill;
            listCommandPlayers.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            listCommandPlayers.FullRowSelect = true;
            listCommandPlayers.HeaderStyle = ColumnHeaderStyle.None;
            listCommandPlayers.Location = new System.Drawing.Point(1, 24);
            listCommandPlayers.MultiSelect = false;
            listCommandPlayers.Name = "listCommandPlayers";
            listCommandPlayers.Size = new System.Drawing.Size(219, 92);
            listCommandPlayers.TabIndex = 18;
            listCommandPlayers.UseCompatibleStateImageBehavior = false;
            listCommandPlayers.ViewType = ViewTypes.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Width = 206;
            // 
            // panel4
            // 
            panel4.BackColor = SKColors.Transparent;
            panel4.Border = new Padding(0, 1, 0, 0);
            panel4.BorderColor = SKColors.Transparent;
            panel4.Controls.Add(buttonCommandPlayerAdd);
            panel4.Controls.Add(buttonCommandPlayerRemove);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new System.Drawing.Point(1, 116);
            panel4.Name = "panel4";
            panel4.Radius = 1;
            panel4.ShadowDepth = 4F;
            panel4.Size = new System.Drawing.Size(219, 33);
            panel4.TabIndex = 10;
            // 
            // buttonCommandPlayerAdd
            // 
            buttonCommandPlayerAdd.Color = SKColors.Transparent;
            buttonCommandPlayerAdd.Location = new System.Drawing.Point(5, 5);
            buttonCommandPlayerAdd.Name = "buttonCommandPlayerAdd";
            buttonCommandPlayerAdd.Radius = 6;
            buttonCommandPlayerAdd.ShadowDepth = 4F;
            buttonCommandPlayerAdd.Size = new System.Drawing.Size(82, 23);
            buttonCommandPlayerAdd.TabIndex = 10;
            buttonCommandPlayerAdd.Text = "Add";
            buttonCommandPlayerAdd.Click += buttonCommandPlayerAdd_Click;
            // 
            // buttonCommandPlayerRemove
            // 
            buttonCommandPlayerRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCommandPlayerRemove.Color = SKColors.Transparent;
            buttonCommandPlayerRemove.Location = new System.Drawing.Point(137, 5);
            buttonCommandPlayerRemove.Name = "buttonCommandPlayerRemove";
            buttonCommandPlayerRemove.Radius = 6;
            buttonCommandPlayerRemove.ShadowDepth = 4F;
            buttonCommandPlayerRemove.Size = new System.Drawing.Size(78, 23);
            buttonCommandPlayerRemove.TabIndex = 10;
            buttonCommandPlayerRemove.Text = "Remove";
            buttonCommandPlayerRemove.Click += buttonCommandPlayerRemove_Click;
            // 
            // Splitter4
            // 
            Splitter4.Dock = DockStyle.Top;
            Splitter4.IsVertical = false;
            Splitter4.Location = new System.Drawing.Point(0, 179);
            Splitter4.Name = "Splitter4";
            Splitter4.Size = new System.Drawing.Size(221, 10);
            Splitter4.TabIndex = 13;
            Splitter4.Text = "Splitter4";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SKColors.Transparent;
            groupBox3.Controls.Add(listAutoParty);
            groupBox3.Controls.Add(panel3);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new System.Drawing.Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(1, 8, 1, 1);
            groupBox3.Radius = 10;
            groupBox3.ShadowDepth = 4;
            groupBox3.Size = new System.Drawing.Size(221, 179);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Auto party players";
            // 
            // listAutoParty
            // 
            listAutoParty.BackColor = SKColors.White;
            listAutoParty.BorderStyle = BorderStyle.None;
            listAutoParty.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            listAutoParty.Dock = DockStyle.Fill;
            listAutoParty.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            listAutoParty.FullRowSelect = true;
            listAutoParty.HeaderStyle = ColumnHeaderStyle.None;
            listAutoParty.Location = new System.Drawing.Point(1, 24);
            listAutoParty.MultiSelect = false;
            listAutoParty.Name = "listAutoParty";
            listAutoParty.Size = new System.Drawing.Size(219, 121);
            listAutoParty.TabIndex = 17;
            listAutoParty.UseCompatibleStateImageBehavior = false;
            listAutoParty.ViewType = ViewTypes.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Width = 206;
            // 
            // panel3
            // 
            panel3.BackColor = SKColors.Transparent;
            panel3.Border = new Padding(0, 1, 0, 0);
            panel3.BorderColor = SKColors.Transparent;
            panel3.Controls.Add(btnAddToAutoParty);
            panel3.Controls.Add(btnRemoveFromAutoParty);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(1, 145);
            panel3.Name = "panel3";
            panel3.Radius = 0;
            panel3.ShadowDepth = 4F;
            panel3.Size = new System.Drawing.Size(219, 33);
            panel3.TabIndex = 17;
            // 
            // btnAddToAutoParty
            // 
            btnAddToAutoParty.Color = SKColors.Transparent;
            btnAddToAutoParty.Location = new System.Drawing.Point(5, 4);
            btnAddToAutoParty.Name = "btnAddToAutoParty";
            btnAddToAutoParty.Radius = 6;
            btnAddToAutoParty.ShadowDepth = 4F;
            btnAddToAutoParty.Size = new System.Drawing.Size(82, 23);
            btnAddToAutoParty.TabIndex = 10;
            btnAddToAutoParty.Text = "Add";
            btnAddToAutoParty.Click += btnAddToAutoParty_Click;
            // 
            // btnRemoveFromAutoParty
            // 
            btnRemoveFromAutoParty.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemoveFromAutoParty.Color = SKColors.Transparent;
            btnRemoveFromAutoParty.Location = new System.Drawing.Point(138, 4);
            btnRemoveFromAutoParty.Name = "btnRemoveFromAutoParty";
            btnRemoveFromAutoParty.Radius = 6;
            btnRemoveFromAutoParty.ShadowDepth = 4F;
            btnRemoveFromAutoParty.Size = new System.Drawing.Size(78, 23);
            btnRemoveFromAutoParty.TabIndex = 10;
            btnRemoveFromAutoParty.Text = "Remove";
            btnRemoveFromAutoParty.Click += btnRemoveFromAutoParty_Click;
            // 
            // Splitter5
            // 
            Splitter5.Dock = DockStyle.Top;
            Splitter5.IsVertical = false;
            Splitter5.Location = new System.Drawing.Point(3, 83);
            Splitter5.Name = "Splitter5";
            Splitter5.Size = new System.Drawing.Size(740, 10);
            Splitter5.TabIndex = 15;
            Splitter5.Text = "Splitter5";
            // 
            // grbAutoPartySettings
            // 
            grbAutoPartySettings.BackColor = SKColors.Transparent;
            grbAutoPartySettings.Controls.Add(checkAutoAllowInvitations);
            grbAutoPartySettings.Controls.Add(checkAutoItemAutoShare);
            grbAutoPartySettings.Controls.Add(checkAutoExpAutoShare);
            grbAutoPartySettings.Dock = DockStyle.Top;
            grbAutoPartySettings.Location = new System.Drawing.Point(3, 3);
            grbAutoPartySettings.Name = "grbAutoPartySettings";
            grbAutoPartySettings.Padding = new Padding(3, 10, 3, 3);
            grbAutoPartySettings.Radius = 10;
            grbAutoPartySettings.ShadowDepth = 4;
            grbAutoPartySettings.Size = new System.Drawing.Size(740, 80);
            grbAutoPartySettings.TabIndex = 8;
            grbAutoPartySettings.TabStop = false;
            grbAutoPartySettings.Text = "Party settings";
            // 
            // checkAutoAllowInvitations
            // 
            checkAutoAllowInvitations.AutoSize = true;
            checkAutoAllowInvitations.BackColor = SKColors.Transparent;
            checkAutoAllowInvitations.Checked = true;
            checkAutoAllowInvitations.CheckState = CheckState.Checked;
            checkAutoAllowInvitations.Depth = 0;
            checkAutoAllowInvitations.Location = new System.Drawing.Point(143, 25);
            checkAutoAllowInvitations.Margin = new Padding(0);
            checkAutoAllowInvitations.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAutoAllowInvitations.Name = "checkAutoAllowInvitations";
            checkAutoAllowInvitations.Ripple = true;
            checkAutoAllowInvitations.Size = new System.Drawing.Size(119, 30);
            checkAutoAllowInvitations.TabIndex = 6;
            checkAutoAllowInvitations.Text = "Allow invitations";
            checkAutoAllowInvitations.UseVisualStyleBackColor = false;
            checkAutoAllowInvitations.CheckedChanged += checkSettings_CheckedChanged;
            // 
            // checkAutoItemAutoShare
            // 
            checkAutoItemAutoShare.AutoSize = true;
            checkAutoItemAutoShare.BackColor = SKColors.Transparent;
            checkAutoItemAutoShare.Depth = 0;
            checkAutoItemAutoShare.Location = new System.Drawing.Point(13, 48);
            checkAutoItemAutoShare.Margin = new Padding(0);
            checkAutoItemAutoShare.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAutoItemAutoShare.Name = "checkAutoItemAutoShare";
            checkAutoItemAutoShare.Ripple = true;
            checkAutoItemAutoShare.Size = new System.Drawing.Size(115, 30);
            checkAutoItemAutoShare.TabIndex = 5;
            checkAutoItemAutoShare.Text = "Item auto share";
            checkAutoItemAutoShare.UseVisualStyleBackColor = false;
            checkAutoItemAutoShare.CheckedChanged += checkSettings_CheckedChanged;
            // 
            // checkAutoExpAutoShare
            // 
            checkAutoExpAutoShare.AutoSize = true;
            checkAutoExpAutoShare.BackColor = SKColors.Transparent;
            checkAutoExpAutoShare.Checked = true;
            checkAutoExpAutoShare.CheckState = CheckState.Checked;
            checkAutoExpAutoShare.Depth = 0;
            checkAutoExpAutoShare.Location = new System.Drawing.Point(13, 25);
            checkAutoExpAutoShare.Margin = new Padding(0);
            checkAutoExpAutoShare.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAutoExpAutoShare.Name = "checkAutoExpAutoShare";
            checkAutoExpAutoShare.Ripple = true;
            checkAutoExpAutoShare.Size = new System.Drawing.Size(112, 30);
            checkAutoExpAutoShare.TabIndex = 5;
            checkAutoExpAutoShare.Text = "EXP Auto share";
            checkAutoExpAutoShare.UseVisualStyleBackColor = false;
            checkAutoExpAutoShare.CheckedChanged += checkSettings_CheckedChanged;
            // 
            // tpPartyMatching
            // 
            tpPartyMatching.BackColor = SKColors.White;
            tpPartyMatching.Controls.Add(lvPartyMatching);
            tpPartyMatching.Controls.Add(topPartyPanel);
            tpPartyMatching.Controls.Add(bottomPartyPanel);
            tpPartyMatching.Location = new System.Drawing.Point(4, 28);
            tpPartyMatching.Name = "tpPartyMatching";
            tpPartyMatching.Padding = new Padding(3);
            tpPartyMatching.Size = new System.Drawing.Size(746, 435);
            tpPartyMatching.TabIndex = 2;
            tpPartyMatching.Text = "Party Matching";
            // 
            // lvPartyMatching
            // 
            lvPartyMatching.BackColor = SKColors.White;
            lvPartyMatching.BorderStyle = BorderStyle.None;
            lvPartyMatching.Columns.AddRange(new ColumnHeader[] { chPartyMatchNo, chPartyMatchRace, chPartyMatchName, chPartyMatchTitle, chPartyMatchPurporse, chPartyMatchMember, chPartyMatchRange });
            lvPartyMatching.Dock = DockStyle.Fill;
            lvPartyMatching.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lvPartyMatching.FullRowSelect = true;
            lvPartyMatching.Location = new System.Drawing.Point(3, 50);
            lvPartyMatching.MultiSelect = false;
            lvPartyMatching.Name = "lvPartyMatching";
            lvPartyMatching.ShowItemToolTips = true;
            lvPartyMatching.Size = new System.Drawing.Size(740, 331);
            lvPartyMatching.TabIndex = 15;
            lvPartyMatching.UseCompatibleStateImageBehavior = false;
            lvPartyMatching.ViewType = ViewTypes.Details;
            // 
            // chPartyMatchNo
            // 
            chPartyMatchNo.Text = "No";
            chPartyMatchNo.Width = 47;
            // 
            // chPartyMatchRace
            // 
            chPartyMatchRace.Text = "Race";
            chPartyMatchRace.TextAlign = HorizontalAlignment.Center;
            chPartyMatchRace.Width = 64;
            // 
            // chPartyMatchName
            // 
            chPartyMatchName.Text = "Name";
            chPartyMatchName.TextAlign = HorizontalAlignment.Center;
            chPartyMatchName.Width = 100;
            // 
            // chPartyMatchTitle
            // 
            chPartyMatchTitle.Text = "Title";
            chPartyMatchTitle.Width = 321;
            // 
            // chPartyMatchPurporse
            // 
            chPartyMatchPurporse.Text = "Purpose";
            // 
            // chPartyMatchMember
            // 
            chPartyMatchMember.Text = "Member";
            // 
            // chPartyMatchRange
            // 
            chPartyMatchRange.Text = "Range";
            chPartyMatchRange.Width = 56;
            // 
            // topPartyPanel
            // 
            topPartyPanel.BackColor = SKColors.Transparent;
            topPartyPanel.Border = new Padding(0, 0, 0, 1);
            topPartyPanel.BorderColor = SKColors.Transparent;
            topPartyPanel.Controls.Add(buttonConfirmJoinConfig);
            topPartyPanel.Controls.Add(textBoxJoinByTitle);
            topPartyPanel.Controls.Add(textBoxJoinByName);
            topPartyPanel.Controls.Add(checkBoxJoinByTitle);
            topPartyPanel.Controls.Add(checkBoxJoinByName);
            topPartyPanel.Controls.Add(Splitter11);
            topPartyPanel.Controls.Add(buttonAutoJoinConfig);
            topPartyPanel.Controls.Add(btnPartyRefresh);
            topPartyPanel.Controls.Add(btnPartySearch);
            topPartyPanel.Controls.Add(nudPartySearchMax);
            topPartyPanel.Controls.Add(nudPartySearchMin);
            topPartyPanel.Controls.Add(cbPartySearchPurpose);
            topPartyPanel.Controls.Add(tbPartySearchName);
            topPartyPanel.Controls.Add(label6);
            topPartyPanel.Controls.Add(label5);
            topPartyPanel.Controls.Add(label4);
            topPartyPanel.Controls.Add(label3);
            topPartyPanel.Dock = DockStyle.Top;
            topPartyPanel.Location = new System.Drawing.Point(3, 3);
            topPartyPanel.Name = "topPartyPanel";
            topPartyPanel.Radius = 0;
            topPartyPanel.ShadowDepth = 4F;
            topPartyPanel.Size = new System.Drawing.Size(740, 47);
            topPartyPanel.TabIndex = 16;
            // 
            // buttonConfirmJoinConfig
            // 
            buttonConfirmJoinConfig.Color = SKColors.Green;
            buttonConfirmJoinConfig.ForeColor = SKColors.White;
            buttonConfirmJoinConfig.Location = new System.Drawing.Point(276, 133);
            buttonConfirmJoinConfig.Name = "buttonConfirmJoinConfig";
            buttonConfirmJoinConfig.Radius = 6;
            buttonConfirmJoinConfig.ShadowDepth = 4F;
            buttonConfirmJoinConfig.Size = new System.Drawing.Size(61, 23);
            buttonConfirmJoinConfig.TabIndex = 23;
            buttonConfirmJoinConfig.Text = "Confirm";
            buttonConfirmJoinConfig.UseVisualStyleBackColor = true;
            buttonConfirmJoinConfig.Click += buttonConfirmJoinConfig_Click;
            // 
            // textBoxJoinByTitle
            // 
            textBoxJoinByTitle.Location = new System.Drawing.Point(276, 112);
            textBoxJoinByTitle.MaxLength = 32767;
            textBoxJoinByTitle.MultiLine = false;
            textBoxJoinByTitle.Name = "textBoxJoinByTitle";
            textBoxJoinByTitle.PassFocusShow = false;
            textBoxJoinByTitle.Radius = 2;
            textBoxJoinByTitle.Size = new System.Drawing.Size(202, 21);
            textBoxJoinByTitle.TabIndex = 21;
            textBoxJoinByTitle.TextAlignment = HorizontalAlignment.Left;
            textBoxJoinByTitle.UseSystemPasswordChar = false;
            // 
            // textBoxJoinByName
            // 
            textBoxJoinByName.Location = new System.Drawing.Point(276, 69);
            textBoxJoinByName.MaxLength = 32767;
            textBoxJoinByName.MultiLine = false;
            textBoxJoinByName.Name = "textBoxJoinByName";
            textBoxJoinByName.PassFocusShow = false;
            textBoxJoinByName.Radius = 2;
            textBoxJoinByName.Size = new System.Drawing.Size(107, 21);
            textBoxJoinByName.TabIndex = 22;
            textBoxJoinByName.TextAlignment = HorizontalAlignment.Left;
            textBoxJoinByName.UseSystemPasswordChar = false;
            // 
            // checkBoxJoinByTitle
            // 
            checkBoxJoinByTitle.AutoSize = true;
            checkBoxJoinByTitle.BackColor = SKColors.Transparent;
            checkBoxJoinByTitle.Depth = 0;
            checkBoxJoinByTitle.Location = new System.Drawing.Point(276, 96);
            checkBoxJoinByTitle.Margin = new Padding(0);
            checkBoxJoinByTitle.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxJoinByTitle.Name = "checkBoxJoinByTitle";
            checkBoxJoinByTitle.Ripple = true;
            checkBoxJoinByTitle.Size = new System.Drawing.Size(120, 30);
            checkBoxJoinByTitle.TabIndex = 19;
            checkBoxJoinByTitle.Text = "Auto join by title";
            checkBoxJoinByTitle.UseVisualStyleBackColor = false;
            // 
            // checkBoxJoinByName
            // 
            checkBoxJoinByName.AutoSize = true;
            checkBoxJoinByName.BackColor = SKColors.Transparent;
            checkBoxJoinByName.Depth = 0;
            checkBoxJoinByName.Location = new System.Drawing.Point(276, 53);
            checkBoxJoinByName.Margin = new Padding(0);
            checkBoxJoinByName.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxJoinByName.Name = "checkBoxJoinByName";
            checkBoxJoinByName.Ripple = true;
            checkBoxJoinByName.Size = new System.Drawing.Size(130, 30);
            checkBoxJoinByName.TabIndex = 20;
            checkBoxJoinByName.Text = "Auto join by name";
            checkBoxJoinByName.UseVisualStyleBackColor = false;
            // 
            // Splitter11
            // 
            Splitter11.IsVertical = false;
            Splitter11.Location = new System.Drawing.Point(15, 41);
            Splitter11.Name = "Splitter11";
            Splitter11.Size = new System.Drawing.Size(707, 10);
            Splitter11.TabIndex = 14;
            Splitter11.Text = "Splitter11";
            // 
            // buttonAutoJoinConfig
            // 
            buttonAutoJoinConfig.Color = SKColors.Transparent;
            buttonAutoJoinConfig.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAutoJoinConfig.Location = new System.Drawing.Point(705, 12);
            buttonAutoJoinConfig.Name = "buttonAutoJoinConfig";
            buttonAutoJoinConfig.Radius = 6;
            buttonAutoJoinConfig.ShadowDepth = 4F;
            buttonAutoJoinConfig.Size = new System.Drawing.Size(25, 23);
            buttonAutoJoinConfig.TabIndex = 13;
            buttonAutoJoinConfig.Text = "@";
            buttonAutoJoinConfig.UseVisualStyleBackColor = true;
            buttonAutoJoinConfig.Click += buttonAutoJoinConfig_Click;
            // 
            // btnPartyRefresh
            // 
            btnPartyRefresh.Color = SKColors.Transparent;
            btnPartyRefresh.Location = new System.Drawing.Point(617, 13);
            btnPartyRefresh.Name = "btnPartyRefresh";
            btnPartyRefresh.Radius = 6;
            btnPartyRefresh.ShadowDepth = 4F;
            btnPartyRefresh.Size = new System.Drawing.Size(85, 21);
            btnPartyRefresh.TabIndex = 4;
            btnPartyRefresh.Text = "Refresh";
            btnPartyRefresh.Click += btnPartyRefresh_Click;
            // 
            // btnPartySearch
            // 
            btnPartySearch.Color = SKColors.Transparent;
            btnPartySearch.Location = new System.Drawing.Point(528, 13);
            btnPartySearch.Name = "btnPartySearch";
            btnPartySearch.Radius = 6;
            btnPartySearch.ShadowDepth = 4F;
            btnPartySearch.Size = new System.Drawing.Size(87, 21);
            btnPartySearch.TabIndex = 4;
            btnPartySearch.Text = "Search";
            btnPartySearch.Click += btnPartySearch_Click;
            // 
            // nudPartySearchMax
            // 
            nudPartySearchMax.BackColor = SKColors.Transparent;
            nudPartySearchMax.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nudPartySearchMax.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            nudPartySearchMax.Location = new System.Drawing.Point(442, 11);
            nudPartySearchMax.Maximum = new decimal(new int[] { 140, 0, 0, 0 });
            nudPartySearchMax.Minimum = 1;
            nudPartySearchMax.MinimumSize = new System.Drawing.Size(80, 25);
            nudPartySearchMax.Name = "nudPartySearchMax";
            nudPartySearchMax.Size = new System.Drawing.Size(80, 25);
            nudPartySearchMax.TabIndex = 3;
            nudPartySearchMax.Value = new decimal(new int[] { 140, 0, 0, 0 });
            // 
            // nudPartySearchMin
            // 
            nudPartySearchMin.BackColor = SKColors.Transparent;
            nudPartySearchMin.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nudPartySearchMin.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            nudPartySearchMin.Location = new System.Drawing.Point(359, 11);
            nudPartySearchMin.Maximum = new decimal(new int[] { 140, 0, 0, 0 });
            nudPartySearchMin.Minimum = 1;
            nudPartySearchMin.MinimumSize = new System.Drawing.Size(80, 25);
            nudPartySearchMin.Name = "nudPartySearchMin";
            nudPartySearchMin.Size = new System.Drawing.Size(80, 25);
            nudPartySearchMin.TabIndex = 3;
            nudPartySearchMin.Value = 1;
            // 
            // cbPartySearchPurpose
            // 
            cbPartySearchPurpose.DrawMode = DrawMode.OwnerDrawFixed;
            cbPartySearchPurpose.DropDownHeight = 100;
            cbPartySearchPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPartySearchPurpose.FormattingEnabled = true;
            cbPartySearchPurpose.IntegralHeight = false;
            cbPartySearchPurpose.ItemHeight = 17;
            cbPartySearchPurpose.Items.AddRange(new object[] { "All", "Hunting", "Quest", "Thief Union", "Trade Union" });
            cbPartySearchPurpose.Location = new System.Drawing.Point(208, 12);
            cbPartySearchPurpose.Name = "cbPartySearchPurpose";
            cbPartySearchPurpose.Radius = 5;
            cbPartySearchPurpose.ShadowDepth = 4F;
            cbPartySearchPurpose.Size = new System.Drawing.Size(108, 23);
            cbPartySearchPurpose.TabIndex = 2;
            // 
            // tbPartySearchName
            // 
            tbPartySearchName.Location = new System.Drawing.Point(51, 12);
            tbPartySearchName.MaxLength = 32767;
            tbPartySearchName.MultiLine = false;
            tbPartySearchName.Name = "tbPartySearchName";
            tbPartySearchName.PassFocusShow = false;
            tbPartySearchName.Radius = 2;
            tbPartySearchName.Size = new System.Drawing.Size(100, 21);
            tbPartySearchName.TabIndex = 1;
            tbPartySearchName.TextAlignment = HorizontalAlignment.Left;
            tbPartySearchName.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            label6.ApplyGradient = false;
            label6.BackColor = SKColors.Transparent;
            label6.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label6.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label6.GradientAnimation = false;
            label6.Location = new System.Drawing.Point(419, 16);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(22, 18);
            label6.TabIndex = 0;
            label6.Text = "~";
            // 
            // label5
            // 
            label5.ApplyGradient = false;
            label5.BackColor = SKColors.Transparent;
            label5.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label5.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label5.GradientAnimation = false;
            label5.Location = new System.Drawing.Point(322, 15);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 18);
            label5.TabIndex = 0;
            label5.Text = "Level";
            // 
            // label4
            // 
            label4.ApplyGradient = false;
            label4.BackColor = SKColors.Transparent;
            label4.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label4.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label4.GradientAnimation = false;
            label4.Location = new System.Drawing.Point(156, 15);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 13);
            label4.TabIndex = 0;
            label4.Text = "Purpose";
            // 
            // label3
            // 
            label3.ApplyGradient = false;
            label3.BackColor = SKColors.Transparent;
            label3.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label3.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label3.GradientAnimation = false;
            label3.Location = new System.Drawing.Point(9, 14);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 13);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // bottomPartyPanel
            // 
            bottomPartyPanel.BackColor = SKColors.Transparent;
            bottomPartyPanel.Border = new Padding(0, 1, 0, 0);
            bottomPartyPanel.BorderColor = SKColors.Transparent;
            bottomPartyPanel.Controls.Add(btnPartyMatchDeleteEntry);
            bottomPartyPanel.Controls.Add(btnPartyMatchChangeEntry);
            bottomPartyPanel.Controls.Add(btnPartyMatchForm);
            bottomPartyPanel.Controls.Add(btnAutoMatchParty);
            bottomPartyPanel.Controls.Add(btnWhisperPartyMaster);
            bottomPartyPanel.Controls.Add(btnJoinFormedParty);
            bottomPartyPanel.Controls.Add(btnPrev);
            bottomPartyPanel.Controls.Add(btnNext);
            bottomPartyPanel.Controls.Add(lbl_partyPageRange);
            bottomPartyPanel.Dock = DockStyle.Bottom;
            bottomPartyPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bottomPartyPanel.Location = new System.Drawing.Point(3, 381);
            bottomPartyPanel.Name = "bottomPartyPanel";
            bottomPartyPanel.Radius = 0;
            bottomPartyPanel.ShadowDepth = 4F;
            bottomPartyPanel.Size = new System.Drawing.Size(740, 51);
            bottomPartyPanel.TabIndex = 14;
            // 
            // btnPartyMatchDeleteEntry
            // 
            btnPartyMatchDeleteEntry.Color = SKColors.Transparent;
            btnPartyMatchDeleteEntry.Enabled = false;
            btnPartyMatchDeleteEntry.Location = new System.Drawing.Point(635, 14);
            btnPartyMatchDeleteEntry.Name = "btnPartyMatchDeleteEntry";
            btnPartyMatchDeleteEntry.Radius = 6;
            btnPartyMatchDeleteEntry.ShadowDepth = 4F;
            btnPartyMatchDeleteEntry.Size = new System.Drawing.Size(87, 23);
            btnPartyMatchDeleteEntry.TabIndex = 16;
            btnPartyMatchDeleteEntry.Text = "Delete Entry";
            btnPartyMatchDeleteEntry.Click += btnPartyMatchDeleteEntry_Click;
            // 
            // btnPartyMatchChangeEntry
            // 
            btnPartyMatchChangeEntry.Color = SKColors.Transparent;
            btnPartyMatchChangeEntry.Enabled = false;
            btnPartyMatchChangeEntry.Location = new System.Drawing.Point(542, 14);
            btnPartyMatchChangeEntry.Name = "btnPartyMatchChangeEntry";
            btnPartyMatchChangeEntry.Radius = 6;
            btnPartyMatchChangeEntry.ShadowDepth = 4F;
            btnPartyMatchChangeEntry.Size = new System.Drawing.Size(87, 23);
            btnPartyMatchChangeEntry.TabIndex = 15;
            btnPartyMatchChangeEntry.Text = "Change Entry";
            btnPartyMatchChangeEntry.Click += btnPartyMatchForm_Click;
            // 
            // btnPartyMatchForm
            // 
            btnPartyMatchForm.Color = SKColors.Transparent;
            btnPartyMatchForm.Location = new System.Drawing.Point(445, 14);
            btnPartyMatchForm.Name = "btnPartyMatchForm";
            btnPartyMatchForm.Radius = 6;
            btnPartyMatchForm.ShadowDepth = 4F;
            btnPartyMatchForm.Size = new System.Drawing.Size(90, 23);
            btnPartyMatchForm.TabIndex = 14;
            btnPartyMatchForm.Text = "Form Party";
            btnPartyMatchForm.Click += btnPartyMatchForm_Click;
            // 
            // btnAutoMatchParty
            // 
            btnAutoMatchParty.Color = SKColors.Transparent;
            btnAutoMatchParty.Enabled = false;
            btnAutoMatchParty.Location = new System.Drawing.Point(180, 14);
            btnAutoMatchParty.Name = "btnAutoMatchParty";
            btnAutoMatchParty.Radius = 6;
            btnAutoMatchParty.ShadowDepth = 4F;
            btnAutoMatchParty.Size = new System.Drawing.Size(96, 23);
            btnAutoMatchParty.TabIndex = 10;
            btnAutoMatchParty.Text = "Auto Match";
            // 
            // btnWhisperPartyMaster
            // 
            btnWhisperPartyMaster.Color = SKColors.Transparent;
            btnWhisperPartyMaster.Enabled = false;
            btnWhisperPartyMaster.Location = new System.Drawing.Point(99, 14);
            btnWhisperPartyMaster.Name = "btnWhisperPartyMaster";
            btnWhisperPartyMaster.Radius = 6;
            btnWhisperPartyMaster.ShadowDepth = 4F;
            btnWhisperPartyMaster.Size = new System.Drawing.Size(75, 23);
            btnWhisperPartyMaster.TabIndex = 9;
            btnWhisperPartyMaster.Text = "Whisper";
            // 
            // btnJoinFormedParty
            // 
            btnJoinFormedParty.Color = SKColors.Transparent;
            btnJoinFormedParty.Location = new System.Drawing.Point(18, 14);
            btnJoinFormedParty.Name = "btnJoinFormedParty";
            btnJoinFormedParty.Radius = 6;
            btnJoinFormedParty.ShadowDepth = 4F;
            btnJoinFormedParty.Size = new System.Drawing.Size(75, 23);
            btnJoinFormedParty.TabIndex = 8;
            btnJoinFormedParty.Text = "Join Party";
            btnJoinFormedParty.Click += btnJoinFormedParty_Click;
            // 
            // btnPrev
            // 
            btnPrev.Color = SKColors.Transparent;
            btnPrev.Enabled = false;
            btnPrev.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPrev.ForeColor = new SkiaSharp.SKColor(64, 64, 64);
            btnPrev.Location = new System.Drawing.Point(315, 14);
            btnPrev.Name = "btnPrev";
            btnPrev.Radius = 6;
            btnPrev.ShadowDepth = 4F;
            btnPrev.Size = new System.Drawing.Size(23, 23);
            btnPrev.TabIndex = 11;
            btnPrev.Text = "◀";
            btnPrev.Click += PageNatigateBtn_Click;
            // 
            // btnNext
            // 
            btnNext.Color = SKColors.Transparent;
            btnNext.Enabled = false;
            btnNext.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNext.ForeColor = new SkiaSharp.SKColor(64, 64, 64);
            btnNext.Location = new System.Drawing.Point(387, 14);
            btnNext.Name = "btnNext";
            btnNext.Radius = 6;
            btnNext.ShadowDepth = 4F;
            btnNext.Size = new System.Drawing.Size(23, 23);
            btnNext.TabIndex = 12;
            btnNext.Text = "▶";
            btnNext.Click += PageNatigateBtn_Click;
            // 
            // lbl_partyPageRange
            // 
            lbl_partyPageRange.ApplyGradient = false;
            lbl_partyPageRange.BackColor = SKColors.Transparent;
            lbl_partyPageRange.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_partyPageRange.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lbl_partyPageRange.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            lbl_partyPageRange.GradientAnimation = false;
            lbl_partyPageRange.Location = new System.Drawing.Point(344, 15);
            lbl_partyPageRange.Name = "lbl_partyPageRange";
            lbl_partyPageRange.Size = new System.Drawing.Size(39, 19);
            lbl_partyPageRange.TabIndex = 13;
            lbl_partyPageRange.Text = "0 / 0";
            // 
            // tpPartyBuffing
            // 
            tpPartyBuffing.BackColor = SKColors.White;
            tpPartyBuffing.Controls.Add(groupBox4);
            tpPartyBuffing.Controls.Add(Splitter9);
            tpPartyBuffing.Controls.Add(groupBox6);
            tpPartyBuffing.Controls.Add(Splitter8);
            tpPartyBuffing.Controls.Add(groupBox5);
            tpPartyBuffing.Controls.Add(Splitter7);
            tpPartyBuffing.Controls.Add(groupBox1);
            tpPartyBuffing.Location = new System.Drawing.Point(4, 28);
            tpPartyBuffing.Name = "tpPartyBuffing";
            tpPartyBuffing.Padding = new Padding(6);
            tpPartyBuffing.Size = new System.Drawing.Size(746, 435);
            tpPartyBuffing.TabIndex = 3;
            tpPartyBuffing.Text = "Buffing";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SKColors.Transparent;
            groupBox4.Controls.Add(btnAddBuffToMember);
            groupBox4.Controls.Add(buttonRemoveCharFromBuffing);
            groupBox4.Controls.Add(btnRemoveBuffFromMember);
            groupBox4.Controls.Add(listViewPartyMembers);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new System.Drawing.Point(283, 191);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2, 8, 2, 2);
            groupBox4.Radius = 10;
            groupBox4.ShadowDepth = 4;
            groupBox4.Size = new System.Drawing.Size(214, 238);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Party Members";
            // 
            // btnAddBuffToMember
            // 
            btnAddBuffToMember.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddBuffToMember.Color = SKColors.Transparent;
            btnAddBuffToMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddBuffToMember.Location = new System.Drawing.Point(5, 209);
            btnAddBuffToMember.Name = "btnAddBuffToMember";
            btnAddBuffToMember.Radius = 6;
            btnAddBuffToMember.ShadowDepth = 4F;
            btnAddBuffToMember.Size = new System.Drawing.Size(75, 21);
            btnAddBuffToMember.TabIndex = 11;
            btnAddBuffToMember.Text = "Add Buff";
            btnAddBuffToMember.Click += btnAddBuffToMember_Click;
            // 
            // buttonRemoveCharFromBuffing
            // 
            buttonRemoveCharFromBuffing.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemoveCharFromBuffing.Color = SKColors.IndianRed;
            buttonRemoveCharFromBuffing.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRemoveCharFromBuffing.ForeColor = SKColors.White;
            buttonRemoveCharFromBuffing.Location = new System.Drawing.Point(183, 173);
            buttonRemoveCharFromBuffing.Name = "buttonRemoveCharFromBuffing";
            buttonRemoveCharFromBuffing.Radius = 6;
            buttonRemoveCharFromBuffing.ShadowDepth = 4F;
            buttonRemoveCharFromBuffing.Size = new System.Drawing.Size(23, 23);
            buttonRemoveCharFromBuffing.TabIndex = 12;
            buttonRemoveCharFromBuffing.Text = "r";
            buttonRemoveCharFromBuffing.Click += buttonRemoveCharFromBuffing_Click;
            // 
            // btnRemoveBuffFromMember
            // 
            btnRemoveBuffFromMember.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveBuffFromMember.Color = SKColors.Transparent;
            btnRemoveBuffFromMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRemoveBuffFromMember.Location = new System.Drawing.Point(120, 209);
            btnRemoveBuffFromMember.Name = "btnRemoveBuffFromMember";
            btnRemoveBuffFromMember.Radius = 6;
            btnRemoveBuffFromMember.ShadowDepth = 4F;
            btnRemoveBuffFromMember.Size = new System.Drawing.Size(86, 21);
            btnRemoveBuffFromMember.TabIndex = 12;
            btnRemoveBuffFromMember.Text = "Remove Buff";
            btnRemoveBuffFromMember.Click += btnRemoveBuffFromMember_Click;
            // 
            // listViewPartyMembers
            // 
            listViewPartyMembers.BackColor = SKColors.White;
            listViewPartyMembers.BorderStyle = BorderStyle.None;
            listViewPartyMembers.Columns.AddRange(new ColumnHeader[] { chPlayerName, chPlayerLevel });
            listViewPartyMembers.Dock = DockStyle.Top;
            listViewPartyMembers.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            listViewPartyMembers.FullRowSelect = true;
            listViewPartyMembers.HeaderStyle = ColumnHeaderStyle.None;
            listViewPartyMembers.Location = new System.Drawing.Point(2, 24);
            listViewPartyMembers.MultiSelect = false;
            listViewPartyMembers.Name = "listViewPartyMembers";
            listViewPartyMembers.Size = new System.Drawing.Size(210, 181);
            listViewPartyMembers.TabIndex = 10;
            listViewPartyMembers.UseCompatibleStateImageBehavior = false;
            listViewPartyMembers.ViewType = ViewTypes.Details;
            listViewPartyMembers.SelectedIndexChanged += listViewPartyMembers_SelectedIndexChanged;
            // 
            // chPlayerName
            // 
            chPlayerName.Text = "Name";
            chPlayerName.Width = 140;
            // 
            // chPlayerLevel
            // 
            chPlayerLevel.Text = "Level";
            chPlayerLevel.Width = 50;
            // 
            // Splitter9
            // 
            Splitter9.Dock = DockStyle.Top;
            Splitter9.IsVertical = false;
            Splitter9.Location = new System.Drawing.Point(283, 181);
            Splitter9.Name = "Splitter9";
            Splitter9.Size = new System.Drawing.Size(214, 10);
            Splitter9.TabIndex = 17;
            Splitter9.Text = "Splitter9";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SKColors.Transparent;
            groupBox6.Controls.Add(buttonAddGroup);
            groupBox6.Controls.Add(buttonRemoveGroup);
            groupBox6.Controls.Add(listViewGroups);
            groupBox6.Dock = DockStyle.Top;
            groupBox6.Location = new System.Drawing.Point(283, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2, 8, 2, 2);
            groupBox6.Radius = 10;
            groupBox6.ShadowDepth = 4;
            groupBox6.Size = new System.Drawing.Size(214, 175);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "Groups";
            // 
            // buttonAddGroup
            // 
            buttonAddGroup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddGroup.Color = SKColors.Transparent;
            buttonAddGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAddGroup.Location = new System.Drawing.Point(6, 146);
            buttonAddGroup.Name = "buttonAddGroup";
            buttonAddGroup.Radius = 6;
            buttonAddGroup.ShadowDepth = 4F;
            buttonAddGroup.Size = new System.Drawing.Size(63, 21);
            buttonAddGroup.TabIndex = 0;
            buttonAddGroup.Text = "Create";
            buttonAddGroup.Click += buttonAddGroup_Click;
            // 
            // buttonRemoveGroup
            // 
            buttonRemoveGroup.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRemoveGroup.Color = SKColors.Transparent;
            buttonRemoveGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRemoveGroup.Location = new System.Drawing.Point(136, 146);
            buttonRemoveGroup.Name = "buttonRemoveGroup";
            buttonRemoveGroup.Radius = 6;
            buttonRemoveGroup.ShadowDepth = 4F;
            buttonRemoveGroup.Size = new System.Drawing.Size(72, 21);
            buttonRemoveGroup.TabIndex = 0;
            buttonRemoveGroup.Text = "Remove";
            buttonRemoveGroup.Click += buttonRemoveGroup_Click;
            // 
            // listViewGroups
            // 
            listViewGroups.BackColor = SKColors.White;
            listViewGroups.BorderStyle = BorderStyle.None;
            listViewGroups.Columns.AddRange(new ColumnHeader[] { columnHeaderGroupName, columnHeaderMembersCount });
            listViewGroups.Dock = DockStyle.Top;
            listViewGroups.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            listViewGroups.FullRowSelect = true;
            listViewGroups.HeaderStyle = ColumnHeaderStyle.None;
            listViewGroups.Location = new System.Drawing.Point(2, 24);
            listViewGroups.MultiSelect = false;
            listViewGroups.Name = "listViewGroups";
            listViewGroups.Size = new System.Drawing.Size(210, 118);
            listViewGroups.TabIndex = 1;
            listViewGroups.UseCompatibleStateImageBehavior = false;
            listViewGroups.ViewType = ViewTypes.Details;
            listViewGroups.SelectedIndexChanged += listViewGroups_SelectedIndexChanged;
            // 
            // columnHeaderGroupName
            // 
            columnHeaderGroupName.Text = "Group Name";
            columnHeaderGroupName.Width = 135;
            // 
            // columnHeaderMembersCount
            // 
            columnHeaderMembersCount.Text = "Members";
            // 
            // Splitter8
            // 
            Splitter8.Dock = DockStyle.Right;
            Splitter8.IsVertical = true;
            Splitter8.Location = new System.Drawing.Point(497, 6);
            Splitter8.Name = "Splitter8";
            Splitter8.Size = new System.Drawing.Size(10, 423);
            Splitter8.TabIndex = 16;
            Splitter8.Text = "Splitter8";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SKColors.Transparent;
            groupBox5.Controls.Add(selectedMemberBuffs);
            groupBox5.Dock = DockStyle.Right;
            groupBox5.Location = new System.Drawing.Point(507, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2, 8, 2, 2);
            groupBox5.Radius = 10;
            groupBox5.ShadowDepth = 4;
            groupBox5.Size = new System.Drawing.Size(233, 423);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Member Buffs";
            // 
            // selectedMemberBuffs
            // 
            selectedMemberBuffs.BackColor = SKColors.White;
            selectedMemberBuffs.BorderStyle = BorderStyle.None;
            selectedMemberBuffs.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            selectedMemberBuffs.Dock = DockStyle.Fill;
            selectedMemberBuffs.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            selectedMemberBuffs.FullRowSelect = true;
            selectedMemberBuffs.HeaderStyle = ColumnHeaderStyle.None;
            selectedMemberBuffs.Location = new System.Drawing.Point(2, 24);
            selectedMemberBuffs.Name = "selectedMemberBuffs";
            selectedMemberBuffs.Size = new System.Drawing.Size(229, 397);
            selectedMemberBuffs.TabIndex = 9;
            selectedMemberBuffs.UseCompatibleStateImageBehavior = false;
            selectedMemberBuffs.ViewType = ViewTypes.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 220;
            // 
            // Splitter7
            // 
            Splitter7.Dock = DockStyle.Left;
            Splitter7.IsVertical = true;
            Splitter7.Location = new System.Drawing.Point(273, 6);
            Splitter7.Name = "Splitter7";
            Splitter7.Size = new System.Drawing.Size(10, 423);
            Splitter7.TabIndex = 15;
            Splitter7.Text = "Splitter7";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SKColors.Transparent;
            groupBox1.Controls.Add(listPartyBuffSkills);
            groupBox1.Controls.Add(panel5);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new System.Drawing.Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 8, 2, 2);
            groupBox1.Radius = 10;
            groupBox1.ShadowDepth = 4;
            groupBox1.Size = new System.Drawing.Size(267, 423);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buffs";
            // 
            // listPartyBuffSkills
            // 
            listPartyBuffSkills.BackColor = SKColors.White;
            listPartyBuffSkills.BorderStyle = BorderStyle.None;
            listPartyBuffSkills.Columns.AddRange(new ColumnHeader[] { columnName, columnLimit });
            listPartyBuffSkills.ContextMenu = contextPartyBuffs;
            listPartyBuffSkills.Dock = DockStyle.Fill;
            listPartyBuffSkills.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            listPartyBuffSkills.FullRowSelect = true;
            listPartyBuffSkills.HeaderStyle = ColumnHeaderStyle.None;
            listPartyBuffSkills.Location = new System.Drawing.Point(2, 24);
            listPartyBuffSkills.Name = "listPartyBuffSkills";
            listPartyBuffSkills.Size = new System.Drawing.Size(263, 371);
            listPartyBuffSkills.TabIndex = 9;
            listPartyBuffSkills.UseCompatibleStateImageBehavior = false;
            listPartyBuffSkills.ViewType = ViewTypes.Details;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.Width = 160;
            // 
            // columnLimit
            // 
            columnLimit.Text = "Limit";
            columnLimit.TextAlign = HorizontalAlignment.Center;
            columnLimit.Width = 80;
            // 
            // panel5
            // 
            panel5.BackColor = SKColors.Transparent;
            panel5.Border = new Padding(0, 1, 0, 0);
            panel5.BorderColor = SKColors.Transparent;
            panel5.Controls.Add(checkHideLowerLevelSkills);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new System.Drawing.Point(2, 395);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10, 0, 0, 0);
            panel5.Radius = 1;
            panel5.ShadowDepth = 4F;
            panel5.Size = new System.Drawing.Size(263, 26);
            panel5.TabIndex = 11;
            // 
            // checkHideLowerLevelSkills
            // 
            checkHideLowerLevelSkills.AutoSize = true;
            checkHideLowerLevelSkills.BackColor = SKColors.Transparent;
            checkHideLowerLevelSkills.Depth = 0;
            checkHideLowerLevelSkills.Dock = DockStyle.Fill;
            checkHideLowerLevelSkills.Location = new System.Drawing.Point(10, 0);
            checkHideLowerLevelSkills.Margin = new Padding(0);
            checkHideLowerLevelSkills.MouseLocation = new System.Drawing.Point(-1, -1);
            checkHideLowerLevelSkills.Name = "checkHideLowerLevelSkills";
            checkHideLowerLevelSkills.Ripple = true;
            checkHideLowerLevelSkills.Size = new System.Drawing.Size(253, 26);
            checkHideLowerLevelSkills.TabIndex = 10;
            checkHideLowerLevelSkills.Text = "Hide lower level skills";
            checkHideLowerLevelSkills.UseVisualStyleBackColor = false;
            checkHideLowerLevelSkills.Visible = false;
            checkHideLowerLevelSkills.CheckedChanged += checkHideLowerLevelSkills_CheckedChanged;
            // 
            // contextPartyBuffs
            // 
            contextPartyBuffs.Items.AddRange(new MenuItem[] { menuItemRefreshBuffs });
            contextPartyBuffs.Name = "contextPartyBuffs";
            contextPartyBuffs.Size = new System.Drawing.Size(153, 70);
            // 
            // menuItemRefreshBuffs
            // 
            menuItemRefreshBuffs.Enabled = true;
            menuItemRefreshBuffs.Name = "menuItemRefreshBuffs";
            menuItemRefreshBuffs.Size = new System.Drawing.Size(152, 22);
            menuItemRefreshBuffs.Text = "Refresh Buffs";
            menuItemRefreshBuffs.Click += menuItemRefreshBuffs_Click;
            // 
            // Main
            // 
            
            
            Controls.Add(tabMain);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "Main";
            Size = new System.Drawing.Size(754, 467);
            Load += Main_Load;
            tabMain.ResumeLayout(false);
            tabCurrentParty.ResumeLayout(false);
            contextParty.ResumeLayout(false);
            contextPartyBuffs.ResumeLayout(false);
            panel1.ResumeLayout(false);
            grpPartySettings.ResumeLayout(false);
            tpAutoParty.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            grbAutoPartySettings.ResumeLayout(false);
            grbAutoPartySettings.PerformLayout();
            tpPartyMatching.ResumeLayout(false);
            topPartyPanel.ResumeLayout(false);
            topPartyPanel.PerformLayout();
            bottomPartyPanel.ResumeLayout(false);
            tpPartyBuffing.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabCurrentParty;
        private SDUI.ListView listParty;
        private ColumnHeader colMemberName;
        private ColumnHeader colLevel;
        private ColumnHeader colGuild;
        private ColumnHeader colMasteries;
        private SDUI.Label lblLeader;
        private SDUI.Label label1;
        private SDUI.Button btnLeaveParty;
        private SDUI.CheckBox checkCurrentAutoShareItems;
        private SDUI.CheckBox checkCurrentAutoShareEXP;
        private SDUI.CheckBox checkCurrentAllowInvitations;
        private SDUI.GroupBox grpPartySettings;
        private SDUI.ContextMenu contextParty;
        private SDUI.ContextMenu contextPartyBuffs;
        private MenuItem menuBanish;
        private MenuItem menuLeave;
        private MenuItem menuItemRefreshBuffs;
        private TabPage tpAutoParty;
        private TabPage tpPartyMatching;
        private SDUI.GroupBox grbAutoPartySettings;
        private SDUI.CheckBox checkAutoAllowInvitations;
        private SDUI.CheckBox checkAutoItemAutoShare;
        private SDUI.CheckBox checkAutoExpAutoShare;
        private SDUI.Button btnAddToAutoParty;
        private SDUI.Button btnRemoveFromAutoParty;
        private SDUI.GroupBox groupBox2;
        private SDUI.CheckBox checkInviteFromList;
        private SDUI.CheckBox checkInviteAll;
        private SDUI.CheckBox checkAcceptFromList;
        private SDUI.CheckBox checkAcceptAll;
        private SDUI.CheckBox checkAcceptAtTrainingPlace;
        private SDUI.Label label2;
        private SDUI.GroupBox groupBox3;
        private SDUI.Panel bottomPartyPanel;
        private SDUI.Button btnPartyMatchDeleteEntry;
        private SDUI.Button btnPartyMatchChangeEntry;
        private SDUI.Button btnPartyMatchForm;
        private SDUI.Button btnAutoMatchParty;
        private SDUI.Button btnWhisperPartyMaster;
        private SDUI.Button btnJoinFormedParty;
        public SDUI.Button btnPrev;
        public SDUI.Button btnNext;
        public SDUI.ListView lvPartyMatching;
        private ColumnHeader chPartyMatchNo;
        private ColumnHeader chPartyMatchRace;
        private ColumnHeader chPartyMatchName;
        private ColumnHeader chPartyMatchTitle;
        private ColumnHeader chPartyMatchPurporse;
        private ColumnHeader chPartyMatchMember;
        private ColumnHeader chPartyMatchRange;
        private SDUI.Label lbl_partyPageRange;
        private SDUI.Panel topPartyPanel;
        private SDUI.ComboBox cbPartySearchPurpose;
        private SDUI.TextBox tbPartySearchName;
        private SDUI.Label label4;
        private SDUI.Label label3;
        private SDUI.Button btnPartyRefresh;
        private SDUI.Button btnPartySearch;
        private SDUI.NumUpDown nudPartySearchMax;
        private SDUI.NumUpDown nudPartySearchMin;
        private SDUI.Label label6;
        private SDUI.Label label5;
        private SDUI.CheckBox checkAcceptIfBotStopped;
        private SDUI.Panel panel1;
        private ColumnHeader colLocation;
        private TabPage tpPartyBuffing;
        private SDUI.GroupBox groupBox1;
        private SDUI.ListView listPartyBuffSkills;
        private ColumnHeader columnName;
        private SDUI.GroupBox groupBox4;
        private SDUI.GroupBox groupBox5;
        private SDUI.ListView selectedMemberBuffs;
        private ColumnHeader columnHeader1;
        private SDUI.CheckBox checkHideLowerLevelSkills;
        private ColumnHeader columnLimit;
        private SDUI.ListView listViewPartyMembers;
        private ColumnHeader chPlayerName;
        private ColumnHeader chPlayerLevel;
        private SDUI.GroupBox groupBox6;
        private SDUI.Button buttonAddGroup;
        private SDUI.Button buttonRemoveGroup;
        private SDUI.ListView listViewGroups;
        private ColumnHeader columnHeaderGroupName;
        private ColumnHeader columnHeaderMembersCount;
        private SDUI.Button btnAddBuffToMember;
        private SDUI.Button btnRemoveBuffFromMember;
        private MenuItem menuItemAddToBuffing;
        private SDUI.Button buttonRemoveCharFromBuffing;
        private SDUI.TextBox textBoxLeaveIfMasterNotName;
        private SDUI.CheckBox checkBoxLeaveIfMasterNot;
        private SDUI.Splitter Splitter1;
        private SDUI.CheckBox checkBoxListenCommandsOnlyList;
        private SDUI.CheckBox checkBoxListenMasterCommands;
        private SDUI.GroupBox groupBox7;
        private SDUI.Button buttonCommandPlayerRemove;
        private SDUI.Button buttonCommandPlayerAdd;
        private SDUI.Label labelCommandsInfo;
        private SDUI.Splitter Splitter2;
        private SDUI.Panel panel3;
        private SDUI.Panel panel4;
        private SDUI.TabControl tabMain;
        private SDUI.Splitter Splitter3;
        private SDUI.Splitter Splitter6;
        private Panel panel2;
        private SDUI.Splitter Splitter4;
        private SDUI.Splitter Splitter5;
        private SDUI.Panel panel5;
        private SDUI.Splitter Splitter9;
        private SDUI.Splitter Splitter8;
        private SDUI.Splitter Splitter7;
        private SDUI.ListView listCommandPlayers;
        private ColumnHeader columnHeader3;
        private SDUI.ListView listAutoParty;
        private ColumnHeader columnHeader2;
        private SDUI.Splitter Splitter10;
        private SDUI.Button buttonAutoJoinConfig;
        private SDUI.Splitter Splitter11;
        private SDUI.Button buttonConfirmJoinConfig;
        private SDUI.TextBox textBoxJoinByTitle;
        private SDUI.TextBox textBoxJoinByName;
        private SDUI.CheckBox checkBoxJoinByTitle;
        private SDUI.CheckBox checkBoxJoinByName;
        private SDUI.CheckBox checkBoxFollowMaster;
    }
}
