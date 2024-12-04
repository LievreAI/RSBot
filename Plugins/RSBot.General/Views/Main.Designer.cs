using SDUI;
using SkiaSharp;

namespace RSBot.General.Views
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
            label1 = new SDUI.Label();
            lblVersion = new SDUI.Label();
            comboBoxClientType = new SDUI.ComboBox();
            groupBox4 = new SDUI.GroupBox();
            label8 = new SDUI.Label();
            checkBoxBotTrayMinimized = new SDUI.CheckBox();
            groupBox3 = new SDUI.GroupBox();
            label2 = new SDUI.Label();
            checkStayConnected = new SDUI.CheckBox();
            groupBox2 = new SDUI.GroupBox();
            btnClientHideShow = new SDUI.Button();
            btnStartClient = new SDUI.Button();
            btnStartClientless = new SDUI.Button();
            btnGoClientless = new SDUI.Button();
            groupBox1 = new SDUI.GroupBox();
            Splitter1 = new SDUI.Splitter();
            panel3 = new Panel();
            radioAutoSelectHigher = new SDUI.RadioButton();
            radioAutoSelectFirst = new SDUI.RadioButton();
            checkCharAutoSelect = new SDUI.CheckBox();
            checkHideClient = new SDUI.CheckBox();
            lblLoginDelaySeconds = new SDUI.Label();
            numLoginDelay = new SDUI.NumUpDown();
            checkEnableLoginDelay = new SDUI.CheckBox();
            checkStartBot = new SDUI.CheckBox();
            checkUseReturnScroll = new SDUI.CheckBox();
            captchaPanel = new Panel();
            Splitter2 = new SDUI.Splitter();
            label6 = new SDUI.Label();
            label5 = new SDUI.Label();
            txtStaticCaptcha = new SDUI.TextBox();
            checkEnableStaticCaptcha = new SDUI.CheckBox();
            autoLoginTopPanel = new Panel();
            comboAccounts = new SDUI.ComboBox();
            label7 = new SDUI.Label();
            label4 = new SDUI.Label();
            checkEnableAutoLogin = new SDUI.CheckBox();
            comboCharacter = new SDUI.ComboBox();
            btnAutoLoginSettings = new SDUI.Button();
            btnBrowseSilkroadPath = new SDUI.Button();
            txtSilkroadPath = new SDUI.TextBox();
            groupBox5 = new SDUI.GroupBox();
            checkEnableQueueLogs = new SDUI.CheckBox();
            label3 = new SDUI.Label();
            numQueueLeft = new SDUI.NumUpDown();
            checkAutoHidePendingWindow = new SDUI.CheckBox();
            checkEnableQueueNotification = new SDUI.CheckBox();
            btnShowPending = new SDUI.Button();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            captchaPanel.SuspendLayout();
            autoLoginTopPanel.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(16, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Silkroad executable path: ";
            // 
            // lblVersion
            // 
            lblVersion.Location = new System.Drawing.Point(707, 11);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(40, 15);
            lblVersion.TabIndex = 3;
            lblVersion.Text = "v1.000";
            // 
            // comboBoxClientType
            // 
            comboBoxClientType.Location = new System.Drawing.Point(595, 29);
            comboBoxClientType.Name = "comboBoxClientType";
            comboBoxClientType.ShadowDepth = 4F;
            comboBoxClientType.Size = new System.Drawing.Size(115, 24);
            comboBoxClientType.TabIndex = 18;
            comboBoxClientType.SelectedIndexChanged += comboBoxClientType_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SKColors.Transparent;
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(checkBoxBotTrayMinimized);
            groupBox4.Location = new System.Drawing.Point(389, 172);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 10, 3, 3);
            groupBox4.ShadowDepth = 4;
            groupBox4.Size = new System.Drawing.Size(359, 98);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Bot Settings";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new System.Drawing.Point(6, 60);
            label8.Name = "label8";
            label8.Padding = new Padding(3);
            label8.Size = new System.Drawing.Size(325, 32);
            label8.TabIndex = 22;
            label8.Text = "If activated, when the bot is minimized, the bot will \r\nautomatically switch to tray mode and continue to run there.";
            // 
            // checkBoxBotTrayMinimized
            // 
            checkBoxBotTrayMinimized.AutoSize = true;
            checkBoxBotTrayMinimized.BackColor = SKColors.Transparent;
            checkBoxBotTrayMinimized.Location = new System.Drawing.Point(19, 30);
            checkBoxBotTrayMinimized.Margin = new Padding(0);
            checkBoxBotTrayMinimized.Name = "checkBoxBotTrayMinimized";
            checkBoxBotTrayMinimized.Ripple = true;
            checkBoxBotTrayMinimized.Size = new System.Drawing.Size(252, 30);
            checkBoxBotTrayMinimized.TabIndex = 0;
            checkBoxBotTrayMinimized.Text = "Move bot to system tray when minimized";
            checkBoxBotTrayMinimized.UseVisualStyleBackColor = false;
            checkBoxBotTrayMinimized.CheckedChanged += checkBoxBotTrayMinimized_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SKColors.Transparent;
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(checkStayConnected);
            groupBox3.Location = new System.Drawing.Point(389, 60);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 10, 3, 3);
            groupBox3.ShadowDepth = 4;
            groupBox3.Size = new System.Drawing.Size(359, 105);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Client settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new System.Drawing.Point(6, 59);
            label2.Name = "label2";
            label2.Padding = new Padding(3);
            label2.Size = new System.Drawing.Size(345, 32);
            label2.TabIndex = 22;
            label2.Text = "If the client exits due to a crash, the bot will automatically switch\r\n to clientless mode and continue its tasks";
            // 
            // checkStayConnected
            // 
            checkStayConnected.AutoSize = true;
            checkStayConnected.BackColor = SKColors.Transparent;
            checkStayConnected.Location = new System.Drawing.Point(20, 27);
            checkStayConnected.Margin = new Padding(0);
            checkStayConnected.Name = "checkStayConnected";
            checkStayConnected.Ripple = true;
            checkStayConnected.Size = new System.Drawing.Size(257, 30);
            checkStayConnected.TabIndex = 17;
            checkStayConnected.Text = "Stay connected if client exits unexpectedly";
            checkStayConnected.UseVisualStyleBackColor = false;
            checkStayConnected.CheckedChanged += checkStayConnected_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SKColors.Transparent;
            groupBox2.Controls.Add(btnClientHideShow);
            groupBox2.Controls.Add(btnStartClient);
            groupBox2.Controls.Add(btnStartClientless);
            groupBox2.Controls.Add(btnGoClientless);
            groupBox2.Location = new System.Drawing.Point(19, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 10, 3, 3);
            groupBox2.ShadowDepth = 4;
            groupBox2.Size = new System.Drawing.Size(355, 105);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Start game";
            // 
            // btnClientHideShow
            // 
            btnClientHideShow.Color = SKColors.Transparent;
            btnClientHideShow.Enabled = false;
            btnClientHideShow.Location = new System.Drawing.Point(18, 68);
            btnClientHideShow.Name = "btnClientHideShow";
            btnClientHideShow.ShadowDepth = 4F;
            btnClientHideShow.Size = new System.Drawing.Size(125, 21);
            btnClientHideShow.TabIndex = 19;
            btnClientHideShow.Text = "Client Visibility";
            btnClientHideShow.UseVisualStyleBackColor = true;
            btnClientHideShow.Click += btnClientHideShow_Click;
            // 
            // btnStartClient
            // 
            btnStartClient.Color = SKColors.Transparent;
            btnStartClient.Location = new System.Drawing.Point(18, 36);
            btnStartClient.Name = "btnStartClient";
            btnStartClient.ShadowDepth = 4F;
            btnStartClient.Size = new System.Drawing.Size(125, 21);
            btnStartClient.TabIndex = 16;
            btnStartClient.Text = "Start Client";
            btnStartClient.UseVisualStyleBackColor = true;
            btnStartClient.Click += btnStartClient_Click;
            // 
            // btnStartClientless
            // 
            btnStartClientless.Color = SKColors.Transparent;
            btnStartClientless.Location = new System.Drawing.Point(212, 36);
            btnStartClientless.Name = "btnStartClientless";
            btnStartClientless.ShadowDepth = 4F;
            btnStartClientless.Size = new System.Drawing.Size(125, 21);
            btnStartClientless.TabIndex = 18;
            btnStartClientless.Text = "Start Clientless";
            btnStartClientless.UseVisualStyleBackColor = false;
            btnStartClientless.Click += btnStartClientless_Click;
            // 
            // btnGoClientless
            // 
            btnGoClientless.Color = SKColors.Transparent;
            btnGoClientless.Enabled = false;
            btnGoClientless.Location = new System.Drawing.Point(212, 68);
            btnGoClientless.Name = "btnGoClientless";
            btnGoClientless.ShadowDepth = 4F;
            btnGoClientless.Size = new System.Drawing.Size(125, 21);
            btnGoClientless.TabIndex = 17;
            btnGoClientless.Text = "Go Clientless";
            btnGoClientless.UseVisualStyleBackColor = true;
            btnGoClientless.Click += btnGoClientless_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackColor = SKColors.Transparent;
            groupBox1.Controls.Add(Splitter1);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(captchaPanel);
            groupBox1.Controls.Add(autoLoginTopPanel);
            groupBox1.Location = new System.Drawing.Point(19, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 10, 3, 3);
            groupBox1.ShadowDepth = 4;
            groupBox1.Size = new System.Drawing.Size(355, 324);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Automated login";
            // 
            // Splitter1
            // 
            Splitter1.Dock = DockStyle.Top;
            Splitter1.Location = new System.Drawing.Point(3, 203);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new System.Drawing.Size(349, 2);
            Splitter1.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Controls.Add(radioAutoSelectHigher);
            panel3.Controls.Add(radioAutoSelectFirst);
            panel3.Controls.Add(checkCharAutoSelect);
            panel3.Controls.Add(checkHideClient);
            panel3.Controls.Add(lblLoginDelaySeconds);
            panel3.Controls.Add(numLoginDelay);
            panel3.Controls.Add(checkEnableLoginDelay);
            panel3.Controls.Add(checkStartBot);
            panel3.Controls.Add(checkUseReturnScroll);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(3, 203);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(349, 118);
            panel3.TabIndex = 1;
            // 
            // radioAutoSelectHigher
            // 
            radioAutoSelectHigher.AutoSize = true;
            radioAutoSelectHigher.Enabled = false;
            radioAutoSelectHigher.Location = new System.Drawing.Point(198, 87);
            radioAutoSelectHigher.Margin = new Padding(0);
            radioAutoSelectHigher.Name = "radioAutoSelectHigher";
            radioAutoSelectHigher.Ripple = true;
            radioAutoSelectHigher.Size = new System.Drawing.Size(140, 30);
            radioAutoSelectHigher.TabIndex = 38;
            radioAutoSelectHigher.Text = "Auto Select (Higher)";
            radioAutoSelectHigher.UseVisualStyleBackColor = true;
            radioAutoSelectHigher.CheckedChanged += radioAutoSelectHigher_CheckedChanged;
            // 
            // radioAutoSelectFirst
            // 
            radioAutoSelectFirst.AutoSize = true;
            radioAutoSelectFirst.Checked = true;
            radioAutoSelectFirst.Enabled = false;
            radioAutoSelectFirst.Location = new System.Drawing.Point(66, 87);
            radioAutoSelectFirst.Margin = new Padding(0);
            radioAutoSelectFirst.Name = "radioAutoSelectFirst";
            radioAutoSelectFirst.Ripple = true;
            radioAutoSelectFirst.Size = new System.Drawing.Size(126, 30);
            radioAutoSelectFirst.TabIndex = 37;
            radioAutoSelectFirst.TabStop = true;
            radioAutoSelectFirst.Text = "Auto Select (First)";
            radioAutoSelectFirst.UseVisualStyleBackColor = true;
            radioAutoSelectFirst.CheckedChanged += radioAutoSelectFirst_CheckedChanged;
            // 
            // checkCharAutoSelect
            // 
            checkCharAutoSelect.AutoSize = true;
            checkCharAutoSelect.BackColor = SKColors.Transparent;
            checkCharAutoSelect.Enabled = false;
            checkCharAutoSelect.Location = new System.Drawing.Point(66, 64);
            checkCharAutoSelect.Name = "checkCharAutoSelect";
            checkCharAutoSelect.Ripple = true;
            checkCharAutoSelect.Size = new System.Drawing.Size(121, 30);
            checkCharAutoSelect.TabIndex = 36;
            checkCharAutoSelect.Text = "Auto Char Select";
            checkCharAutoSelect.UseVisualStyleBackColor = false;
            checkCharAutoSelect.CheckedChanged += checkCharAutoSelect_CheckedChanged;
            // 
            // checkHideClient
            // 
            checkHideClient.AutoSize = true;
            checkHideClient.BackColor = SKColors.Transparent;
            checkHideClient.Location = new System.Drawing.Point(198, 64);
            checkHideClient.Margin = new Padding(0);
            checkHideClient.Name = "checkHideClient";
            checkHideClient.Ripple = true;
            checkHideClient.Size = new System.Drawing.Size(121, 30);
            checkHideClient.TabIndex = 31;
            checkHideClient.Text = "Auto Hide Client";
            checkHideClient.UseVisualStyleBackColor = false;
            checkHideClient.CheckedChanged += checkHideClient_CheckedChanged;
            // 
            // lblLoginDelaySeconds
            // 
            lblLoginDelaySeconds.AutoSize = true;
            lblLoginDelaySeconds.Location = new System.Drawing.Point(284, 16);
            lblLoginDelaySeconds.Name = "lblLoginDelaySeconds";
            lblLoginDelaySeconds.Size = new System.Drawing.Size(49, 13);
            lblLoginDelaySeconds.TabIndex = 22;
            lblLoginDelaySeconds.Text = "seconds";
            // 
            // numLoginDelay
            // 
            numLoginDelay.BackColor = SKColors.Transparent;
            numLoginDelay.Location = new System.Drawing.Point(198, 11);
            numLoginDelay.MinimumSize = new System.Drawing.Size(80, 25);
            numLoginDelay.Name = "numLoginDelay";
            numLoginDelay.Size = new System.Drawing.Size(80, 25);
            numLoginDelay.TabIndex = 30;
            numLoginDelay.TextChanged += numLoginDelay_ValueChanged;
            // 
            // checkEnableLoginDelay
            // 
            checkEnableLoginDelay.AutoSize = true;
            checkEnableLoginDelay.BackColor = SKColors.Transparent;
            checkEnableLoginDelay.Location = new System.Drawing.Point(66, 10);
            checkEnableLoginDelay.Margin = new Padding(0);
            checkEnableLoginDelay.Name = "checkEnableLoginDelay";
            checkEnableLoginDelay.Ripple = true;
            checkEnableLoginDelay.Size = new System.Drawing.Size(129, 30);
            checkEnableLoginDelay.TabIndex = 25;
            checkEnableLoginDelay.Text = "Enable login delay";
            checkEnableLoginDelay.UseVisualStyleBackColor = false;
            checkEnableLoginDelay.CheckedChanged += checkEnableLoginDelay_CheckedChanged;
            // 
            // checkStartBot
            // 
            checkStartBot.AutoSize = true;
            checkStartBot.BackColor = SKColors.Transparent;
            checkStartBot.Location = new System.Drawing.Point(66, 40);
            checkStartBot.Margin = new Padding(0);
            checkStartBot.Name = "checkStartBot";
            checkStartBot.Ripple = true;
            checkStartBot.Size = new System.Drawing.Size(106, 30);
            checkStartBot.TabIndex = 24;
            checkStartBot.Text = "Auto start bot";
            checkStartBot.UseVisualStyleBackColor = false;
            checkStartBot.CheckedChanged += checkAutoStartBot_CheckedChanged;
            // 
            // checkUseReturnScroll
            // 
            checkUseReturnScroll.AutoSize = true;
            checkUseReturnScroll.BackColor = SKColors.Transparent;
            checkUseReturnScroll.Location = new System.Drawing.Point(198, 40);
            checkUseReturnScroll.Margin = new Padding(0);
            checkUseReturnScroll.Name = "checkUseReturnScroll";
            checkUseReturnScroll.Ripple = true;
            checkUseReturnScroll.Size = new System.Drawing.Size(118, 30);
            checkUseReturnScroll.TabIndex = 16;
            checkUseReturnScroll.Text = "Use return scroll";
            checkUseReturnScroll.UseVisualStyleBackColor = false;
            checkUseReturnScroll.CheckedChanged += checkUseReturnScroll_CheckedChanged;
            // 
            // captchaPanel
            // 
            captchaPanel.Controls.Add(Splitter2);
            captchaPanel.Controls.Add(label6);
            captchaPanel.Controls.Add(label5);
            captchaPanel.Controls.Add(txtStaticCaptcha);
            captchaPanel.Controls.Add(checkEnableStaticCaptcha);
            captchaPanel.Dock = DockStyle.Top;
            captchaPanel.Location = new System.Drawing.Point(3, 120);
            captchaPanel.Name = "captchaPanel";
            captchaPanel.Size = new System.Drawing.Size(349, 83);
            captchaPanel.TabIndex = 0;
            captchaPanel.Visible = false;
            // 
            // Splitter2
            // 
            Splitter2.Dock = DockStyle.Top;
            Splitter2.Location = new System.Drawing.Point(0, 0);
            Splitter2.Name = "Splitter2";
            Splitter2.Size = new System.Drawing.Size(349, 2);
            Splitter2.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new System.Drawing.Point(63, 61);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(260, 13);
            label6.TabIndex = 21;
            label6.Text = "Please use this only if the captcha never changes.";
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(9, 14);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 18);
            label5.TabIndex = 18;
            label5.Text = "Captcha:";
            // 
            // txtStaticCaptcha
            // 
            txtStaticCaptcha.Location = new System.Drawing.Point(66, 11);
            txtStaticCaptcha.MaxLength = 32767;
            txtStaticCaptcha.MultiLine = false;
            txtStaticCaptcha.Name = "txtStaticCaptcha";
            txtStaticCaptcha.Size = new System.Drawing.Size(268, 21);
            txtStaticCaptcha.TabIndex = 3;
            txtStaticCaptcha.UseSystemPasswordChar = false;
            txtStaticCaptcha.TextChanged += txtStaticCaptcha_TextChanged;
            // 
            // checkEnableStaticCaptcha
            // 
            checkEnableStaticCaptcha.AutoSize = true;
            checkEnableStaticCaptcha.BackColor = SKColors.Transparent;
            checkEnableStaticCaptcha.Location = new System.Drawing.Point(66, 35);
            checkEnableStaticCaptcha.Margin = new Padding(0);
            checkEnableStaticCaptcha.Name = "checkEnableStaticCaptcha";
            checkEnableStaticCaptcha.Ripple = true;
            checkEnableStaticCaptcha.Size = new System.Drawing.Size(174, 30);
            checkEnableStaticCaptcha.TabIndex = 4;
            checkEnableStaticCaptcha.Text = "Enable static captcha solve";
            checkEnableStaticCaptcha.UseVisualStyleBackColor = false;
            checkEnableStaticCaptcha.CheckedChanged += checkEnableStaticCaptcha_CheckedChanged;
            // 
            // autoLoginTopPanel
            // 
            autoLoginTopPanel.BackColor = SKColors.Transparent;
            autoLoginTopPanel.Controls.Add(comboAccounts);
            autoLoginTopPanel.Controls.Add(label7);
            autoLoginTopPanel.Controls.Add(label4);
            autoLoginTopPanel.Controls.Add(checkEnableAutoLogin);
            autoLoginTopPanel.Controls.Add(comboCharacter);
            autoLoginTopPanel.Controls.Add(btnAutoLoginSettings);
            autoLoginTopPanel.Dock = DockStyle.Top;
            autoLoginTopPanel.Location = new System.Drawing.Point(3, 26);
            autoLoginTopPanel.Name = "autoLoginTopPanel";
            autoLoginTopPanel.Size = new System.Drawing.Size(349, 94);
            autoLoginTopPanel.TabIndex = 28;
            // 
            // comboAccounts
            // 
            comboAccounts.Location = new System.Drawing.Point(66, 10);
            comboAccounts.Name = "comboAccounts";
            comboAccounts.ShadowDepth = 4F;
            comboAccounts.Size = new System.Drawing.Size(268, 24);
            comboAccounts.TabIndex = 0;
            comboAccounts.SelectedIndexChanged += comboAccounts_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(18, 37);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(42, 15);
            label7.TabIndex = 23;
            label7.Text = "Player:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(9, 14);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "Account:";
            // 
            // checkEnableAutoLogin
            // 
            checkEnableAutoLogin.AutoSize = true;
            checkEnableAutoLogin.BackColor = SKColors.Transparent;
            checkEnableAutoLogin.Location = new System.Drawing.Point(66, 60);
            checkEnableAutoLogin.Margin = new Padding(0);
            checkEnableAutoLogin.Name = "checkEnableAutoLogin";
            checkEnableAutoLogin.Ripple = true;
            checkEnableAutoLogin.Size = new System.Drawing.Size(159, 30);
            checkEnableAutoLogin.TabIndex = 1;
            checkEnableAutoLogin.Text = "Enable automated login";
            checkEnableAutoLogin.UseVisualStyleBackColor = false;
            checkEnableAutoLogin.CheckedChanged += checkEnableAutoLogin_CheckedChanged;
            // 
            // comboCharacter
            // 
            comboCharacter.Items.AddRange(new object[] { "No Selected" });
            comboCharacter.Location = new System.Drawing.Point(66, 36);
            comboCharacter.Name = "comboCharacter";
            comboCharacter.ShadowDepth = 4F;
            comboCharacter.Size = new System.Drawing.Size(268, 24);
            comboCharacter.TabIndex = 22;
            comboCharacter.SelectedIndexChanged += comboCharacter_SelectedIndexChanged;
            // 
            // btnAutoLoginSettings
            // 
            btnAutoLoginSettings.Color = SKColors.Transparent;
            btnAutoLoginSettings.Location = new System.Drawing.Point(259, 65);
            btnAutoLoginSettings.Name = "btnAutoLoginSettings";
            btnAutoLoginSettings.ShadowDepth = 4F;
            btnAutoLoginSettings.Size = new System.Drawing.Size(75, 23);
            btnAutoLoginSettings.TabIndex = 2;
            btnAutoLoginSettings.Text = "Setup";
            btnAutoLoginSettings.UseVisualStyleBackColor = true;
            btnAutoLoginSettings.Click += btnAutoLoginSettings_Click;
            // 
            // btnBrowseSilkroadPath
            // 
            btnBrowseSilkroadPath.Color = SKColors.Transparent;
            btnBrowseSilkroadPath.Location = new System.Drawing.Point(715, 30);
            btnBrowseSilkroadPath.Name = "btnBrowseSilkroadPath";
            btnBrowseSilkroadPath.ShadowDepth = 4F;
            btnBrowseSilkroadPath.Size = new System.Drawing.Size(32, 21);
            btnBrowseSilkroadPath.TabIndex = 2;
            btnBrowseSilkroadPath.Text = "...";
            btnBrowseSilkroadPath.UseVisualStyleBackColor = true;
            btnBrowseSilkroadPath.Click += btnBrowseSilkroadPath_Click;
            // 
            // txtSilkroadPath
            // 
            txtSilkroadPath.Location = new System.Drawing.Point(19, 30);
            txtSilkroadPath.MaxLength = 32767;
            txtSilkroadPath.MultiLine = false;
            txtSilkroadPath.Name = "txtSilkroadPath";
            txtSilkroadPath.Size = new System.Drawing.Size(570, 21);
            txtSilkroadPath.TabIndex = 1;
            txtSilkroadPath.UseSystemPasswordChar = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SKColors.Transparent;
            groupBox5.Controls.Add(checkEnableQueueLogs);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(numQueueLeft);
            groupBox5.Controls.Add(checkAutoHidePendingWindow);
            groupBox5.Controls.Add(checkEnableQueueNotification);
            groupBox5.Controls.Add(btnShowPending);
            groupBox5.Location = new System.Drawing.Point(389, 278);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 10, 3, 3);
            groupBox5.ShadowDepth = 4;
            groupBox5.Size = new System.Drawing.Size(359, 152);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "Server Pending";
            // 
            // checkEnableQueueLogs
            // 
            checkEnableQueueLogs.AutoSize = true;
            checkEnableQueueLogs.BackColor = SKColors.Transparent;
            checkEnableQueueLogs.Location = new System.Drawing.Point(20, 53);
            checkEnableQueueLogs.Margin = new Padding(0);
            checkEnableQueueLogs.Name = "checkEnableQueueLogs";
            checkEnableQueueLogs.Ripple = true;
            checkEnableQueueLogs.Size = new System.Drawing.Size(176, 30);
            checkEnableQueueLogs.TabIndex = 42;
            checkEnableQueueLogs.Text = "Enable pending queue logs";
            checkEnableQueueLogs.UseVisualStyleBackColor = false;
            checkEnableQueueLogs.CheckedChanged += checkEnableQueueLogs_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(292, 81);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 15);
            label3.TabIndex = 39;
            label3.Text = "people left";
            // 
            // numQueueLeft
            // 
            numQueueLeft.BackColor = SKColors.Transparent;
            numQueueLeft.Location = new System.Drawing.Point(206, 77);
            numQueueLeft.MinimumSize = new System.Drawing.Size(80, 25);
            numQueueLeft.Name = "numQueueLeft";
            numQueueLeft.Size = new System.Drawing.Size(80, 25);
            numQueueLeft.TabIndex = 39;
            numQueueLeft.TextChanged += numQueueLeft_ValueChanged;
            // 
            // checkAutoHidePendingWindow
            // 
            checkAutoHidePendingWindow.AutoSize = true;
            checkAutoHidePendingWindow.BackColor = SKColors.Transparent;
            checkAutoHidePendingWindow.Location = new System.Drawing.Point(20, 32);
            checkAutoHidePendingWindow.Margin = new Padding(0);
            checkAutoHidePendingWindow.Name = "checkAutoHidePendingWindow";
            checkAutoHidePendingWindow.Ripple = true;
            checkAutoHidePendingWindow.Size = new System.Drawing.Size(197, 30);
            checkAutoHidePendingWindow.TabIndex = 41;
            checkAutoHidePendingWindow.Text = "Auto hide the pending window";
            checkAutoHidePendingWindow.UseVisualStyleBackColor = false;
            checkAutoHidePendingWindow.CheckedChanged += checkDontShowPendingOnStartClient_CheckedChanged;
            // 
            // checkEnableQueueNotification
            // 
            checkEnableQueueNotification.AutoSize = true;
            checkEnableQueueNotification.BackColor = SKColors.Transparent;
            checkEnableQueueNotification.Location = new System.Drawing.Point(20, 75);
            checkEnableQueueNotification.Margin = new Padding(0);
            checkEnableQueueNotification.Name = "checkEnableQueueNotification";
            checkEnableQueueNotification.Ripple = true;
            checkEnableQueueNotification.Size = new System.Drawing.Size(188, 30);
            checkEnableQueueNotification.TabIndex = 40;
            checkEnableQueueNotification.Text = "Enable queue notification on ";
            checkEnableQueueNotification.UseVisualStyleBackColor = false;
            checkEnableQueueNotification.CheckedChanged += checkEnableQueueNotification_CheckedChanged;
            // 
            // btnShowPending
            // 
            btnShowPending.AutoSize = true;
            btnShowPending.Color = SKColors.Transparent;
            btnShowPending.Location = new System.Drawing.Point(29, 112);
            btnShowPending.Name = "btnShowPending";
            btnShowPending.ShadowDepth = 4F;
            btnShowPending.Size = new System.Drawing.Size(152, 23);
            btnShowPending.TabIndex = 24;
            btnShowPending.Text = "Toggle Pending Window";
            btnShowPending.UseVisualStyleBackColor = true;
            btnShowPending.Click += btnShowPending_Click;
            // 
            // Main
            // 
            Controls.Add(groupBox5);
            Controls.Add(comboBoxClientType);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblVersion);
            Controls.Add(btnBrowseSilkroadPath);
            Controls.Add(txtSilkroadPath);
            Controls.Add(label1);
            Name = "Main";
            Size = new System.Drawing.Size(765, 496);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            captchaPanel.ResumeLayout(false);
            captchaPanel.PerformLayout();
            autoLoginTopPanel.ResumeLayout(false);
            autoLoginTopPanel.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SDUI.Label label1;
        private SDUI.TextBox txtSilkroadPath;
        private SDUI.Button btnBrowseSilkroadPath;
        private SDUI.Label lblVersion;
        private SDUI.GroupBox groupBox1;
        private SDUI.Label label4;
        private SDUI.ComboBox comboAccounts;
        private SDUI.CheckBox checkEnableAutoLogin;
        private SDUI.Button btnAutoLoginSettings;
        private SDUI.TextBox txtStaticCaptcha;
        private SDUI.Label label5;
        private SDUI.CheckBox checkEnableStaticCaptcha;
        private SDUI.Label label6;
        private SDUI.Label label7;
        private SDUI.ComboBox comboCharacter;
        private SDUI.GroupBox groupBox2;
        private SDUI.Button btnGoClientless;
        private SDUI.Button btnStartClientless;
        private SDUI.Button btnStartClient;
        private SDUI.CheckBox checkUseReturnScroll;
        private SDUI.CheckBox checkStartBot;
        private SDUI.GroupBox groupBox3;
        private SDUI.CheckBox checkStayConnected;
        private SDUI.Label label2;
        private SDUI.Button btnClientHideShow;
        private SDUI.GroupBox groupBox4;
        private SDUI.Label label8;
        private SDUI.CheckBox checkBoxBotTrayMinimized;
        private SDUI.ComboBox comboBoxClientType;
        private Panel captchaPanel;
        private Panel panel3;
        private Panel autoLoginTopPanel;
        private SDUI.Splitter Splitter2;
        private SDUI.Splitter Splitter1;
        private SDUI.Label lblLoginDelaySeconds;
        private SDUI.NumUpDown numLoginDelay;
        private SDUI.CheckBox checkEnableLoginDelay;
        private SDUI.CheckBox checkHideClient;
        private SDUI.RadioButton radioAutoSelectHigher;
        private SDUI.RadioButton radioAutoSelectFirst;
        private SDUI.CheckBox checkCharAutoSelect;
        private SDUI.GroupBox groupBox5;
        private SDUI.Button btnShowPending;
        private SDUI.CheckBox checkEnableQueueNotification;
        private SDUI.NumUpDown numQueueLeft;
        private SDUI.CheckBox checkAutoHidePendingWindow;
        private SDUI.Label label3;
        private SDUI.CheckBox checkEnableQueueLogs;
    }
}
