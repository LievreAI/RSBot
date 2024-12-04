using SDUI;
using SkiaSharp;

namespace RSBot.Trade.Views
{
    partial class Main
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            contextMenuRouteList = new SDUI.ContextMenu();
            addScriptMenuItem = new MenuItem();
            menuRecordScript = new MenuItem();
            menuChooseScript = new MenuItem();
            menuRemoveScript = new MenuItem();
            lblHint = new SDUI.Label();
            tabControl1 = new SDUI.TabControl();
            tabPageRoute = new TabPage();
            txtTracePlayerName = new SDUI.TextBox();
            radioUseRouteList = new SDUI.RadioButton();
            radioTracePlayer = new SDUI.RadioButton();
            buttonDeleteList = new SDUI.Button();
            buttonCreateList = new SDUI.Button();
            comboRouteList = new SDUI.ComboBox();
            linkRecord = new LinkLabel();
            lvRouteList = new SDUI.ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel1 = new SDUI.Panel();
            checkRunTownscript = new SDUI.CheckBox();
            tabPageSettings = new TabPage();
            checkAttackThiefPlayers = new SDUI.CheckBox();
            groupBox1 = new SDUI.GroupBox();
            checkSellGoods = new SDUI.CheckBox();
            lblNumGoodsDesc = new SDUI.Label();
            checkBuyGoods = new SDUI.CheckBox();
            numAmountGoods = new SDUI.NumUpDown();
            lblGoods = new SDUI.Label();
            checkProtectTransport = new SDUI.CheckBox();
            checkCounterAttack = new SDUI.CheckBox();
            checkAttackThiefNpc = new SDUI.CheckBox();
            groupBox2 = new SDUI.GroupBox();
            Splitter2 = new SDUI.Splitter();
            checkCastBuffs = new SDUI.CheckBox();
            checkWaitForHunter = new SDUI.CheckBox();
            label3 = new SDUI.Label();
            Splitter4 = new SDUI.Splitter();
            label1 = new SDUI.Label();
            numMaxDistance = new SDUI.NumUpDown();
            checkMountTransport = new SDUI.CheckBox();
            Splitter1 = new SDUI.Splitter();
            tabPage1 = new TabPage();
            lblJobExp = new SDUI.Label();
            lblJobLevel = new SDUI.Label();
            lblJobAlias = new SDUI.Label();
            label9 = new SDUI.Label();
            label8 = new SDUI.Label();
            label7 = new SDUI.Label();
            Splitter3 = new SDUI.Splitter();
            lblTradeScale = new SDUI.Label();
            label2 = new SDUI.Label();
            contextMenuRouteList.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageRoute.SuspendLayout();
            panel1.SuspendLayout();
            tabPageSettings.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuRouteList
            // 
            contextMenuRouteList.Items.AddRange(new MenuItem[] { addScriptMenuItem, menuRemoveScript });
            contextMenuRouteList.Name = "ContextMenu1";
            contextMenuRouteList.Size = new System.Drawing.Size(129, 48);
            // 
            // addScriptMenuItem
            // 
            addScriptMenuItem.Items.AddRange(new MenuItem[] { menuRecordScript, menuChooseScript });
            addScriptMenuItem.Name = "addScriptMenuItem";
            addScriptMenuItem.Text = "Add script";
            // 
            // menuRecordScript
            // 
            menuRecordScript.Name = "menuRecordScript";
            menuRecordScript.Text = "Record";
            menuRecordScript.Click += menuRecordScript_Click;
            // 
            // menuChooseScript
            // 
            menuChooseScript.Name = "menuChooseScript";
            menuChooseScript.Text = "Choose file...";
            menuChooseScript.Click += menuChooseScript_Click;
            // 
            // menuRemoveScript
            // 
            menuRemoveScript.Name = "menuRemoveScript";
            menuRemoveScript.Text = "Remove";
            menuRemoveScript.Click += menuRemoveScript_Click;
            // 
            // lblHint
            // 
            lblHint.ApplyGradient = false;
            lblHint.AutoSize = true;
            lblHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblHint.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblHint.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            lblHint.GradientAnimation = false;
            lblHint.Location = new System.Drawing.Point(7, 400);
            lblHint.Margin = new Padding(2, 0, 2, 0);
            lblHint.Name = "lblHint";
            lblHint.Size = new System.Drawing.Size(419, 15);
            lblHint.TabIndex = 7;
            lblHint.Text = "Hint: Automatic teleportation and town scripts are not supported in trace mode";
            // 
            // tabControl1
            // 
            tabControl1.TabPages.Add(tabPageRoute);
            tabControl1.TabPages.Add(tabPageSettings);
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.Location = new System.Drawing.Point(2, 2);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.Radius = new Padding(4);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(787, 388);
            tabControl1.TabIndex = 8;
            // 
            // tabPageRoute
            // 
            tabPageRoute.BackColor = SKColors.White;
            tabPageRoute.Controls.Add(txtTracePlayerName);
            tabPageRoute.Controls.Add(radioUseRouteList);
            tabPageRoute.Controls.Add(radioTracePlayer);
            tabPageRoute.Controls.Add(buttonDeleteList);
            tabPageRoute.Controls.Add(buttonCreateList);
            tabPageRoute.Controls.Add(comboRouteList);
            tabPageRoute.Controls.Add(linkRecord);
            tabPageRoute.Controls.Add(lvRouteList);
            tabPageRoute.Controls.Add(panel1);
            tabPageRoute.Location = new System.Drawing.Point(4, 28);
            tabPageRoute.Margin = new Padding(2);
            tabPageRoute.Name = "tabPageRoute";
            tabPageRoute.Padding = new Padding(2);
            tabPageRoute.Size = new System.Drawing.Size(779, 356);
            tabPageRoute.TabIndex = 0;
            tabPageRoute.Text = "Route";
            // 
            // txtTracePlayerName
            // 
            txtTracePlayerName.Location = new System.Drawing.Point(115, 16);
            txtTracePlayerName.Margin = new Padding(2);
            txtTracePlayerName.MaxLength = 32767;
            txtTracePlayerName.MultiLine = false;
            txtTracePlayerName.Name = "txtTracePlayerName";
            txtTracePlayerName.Size = new System.Drawing.Size(121, 21);
            txtTracePlayerName.TabIndex = 24;
            txtTracePlayerName.UseSystemPasswordChar = false;
            txtTracePlayerName.TextChanged += txtTracePlayerName_TextChanged;
            // 
            // radioUseRouteList
            // 
            radioUseRouteList.AutoSize = true;
            radioUseRouteList.Checked = true;
            radioUseRouteList.Location = new System.Drawing.Point(9, 46);
            radioUseRouteList.Margin = new Padding(0);
            radioUseRouteList.Name = "radioUseRouteList";
            radioUseRouteList.Ripple = true;
            radioUseRouteList.Size = new System.Drawing.Size(102, 30);
            radioUseRouteList.TabIndex = 23;
            radioUseRouteList.TabStop = true;
            radioUseRouteList.Text = "Use route list";
            radioUseRouteList.UseVisualStyleBackColor = true;
            radioUseRouteList.CheckedChanged += radioSetting_CheckedChanged;
            // 
            // radioTracePlayer
            // 
            radioTracePlayer.AutoSize = true;
            radioTracePlayer.Location = new System.Drawing.Point(9, 14);
            radioTracePlayer.Margin = new Padding(0);
            radioTracePlayer.Name = "radioTracePlayer";
            radioTracePlayer.Ripple = true;
            radioTracePlayer.Size = new System.Drawing.Size(96, 30);
            radioTracePlayer.TabIndex = 22;
            radioTracePlayer.Text = "Trace player";
            radioTracePlayer.UseVisualStyleBackColor = true;
            radioTracePlayer.CheckedChanged += radioSetting_CheckedChanged;
            // 
            // buttonDeleteList
            // 
            buttonDeleteList.Color = SKColors.IndianRed;
            buttonDeleteList.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonDeleteList.ForeColor = SKColors.White;
            buttonDeleteList.Location = new System.Drawing.Point(243, 45);
            buttonDeleteList.Margin = new Padding(2, 3, 2, 3);
            buttonDeleteList.Name = "buttonDeleteList";
            buttonDeleteList.Radius = 6;
            buttonDeleteList.ShadowDepth = 4F;
            buttonDeleteList.Size = new System.Drawing.Size(22, 26);
            buttonDeleteList.TabIndex = 20;
            buttonDeleteList.Text = "x";
            buttonDeleteList.UseVisualStyleBackColor = true;
            buttonDeleteList.Click += buttonDeleteList_Click;
            // 
            // buttonCreateList
            // 
            buttonCreateList.Color = new SkiaSharp.SKColor(0, 192, 0);
            buttonCreateList.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonCreateList.ForeColor = SKColors.White;
            buttonCreateList.Location = new System.Drawing.Point(269, 46);
            buttonCreateList.Margin = new Padding(2, 3, 2, 3);
            buttonCreateList.Name = "buttonCreateList";
            buttonCreateList.Radius = 6;
            buttonCreateList.ShadowDepth = 4F;
            buttonCreateList.Size = new System.Drawing.Size(22, 26);
            buttonCreateList.TabIndex = 21;
            buttonCreateList.Text = "+";
            buttonCreateList.UseVisualStyleBackColor = true;
            buttonCreateList.Click += buttonCreateList_Click;
            // 
            // comboRouteList
            // 
            comboRouteList.Items.AddRange(new object[] { "Default" });
            comboRouteList.Location = new System.Drawing.Point(115, 47);
            comboRouteList.Margin = new Padding(2);
            comboRouteList.Name = "comboRouteList";
            comboRouteList.Radius = 5;
            comboRouteList.ShadowDepth = 4F;
            comboRouteList.Size = new System.Drawing.Size(122, 24);
            comboRouteList.TabIndex = 19;
            comboRouteList.SelectedIndexChanged += comboRouteList_SelectedIndexChanged;
            // 
            // linkRecord
            // 
            linkRecord.AutoSize = true;
            linkRecord.Location = new System.Drawing.Point(718, 46);
            linkRecord.Margin = new Padding(2, 0, 2, 0);
            linkRecord.Name = "linkRecord";
            linkRecord.Size = new System.Drawing.Size(52, 15);
            linkRecord.TabIndex = 16;
            linkRecord.TabStop = true;
            linkRecord.Text = "[Record]";
            linkRecord.Click += linkRecord_LinkClicked;
            // 
            // lvRouteList
            // 
            lvRouteList.BackColor = SKColors.White;
            lvRouteList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader3 });
            lvRouteList.ContextMenu = contextMenuRouteList;
            lvRouteList.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lvRouteList.FullRowSelect = true;
            lvRouteList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvRouteList.Location = new System.Drawing.Point(9, 84);
            lvRouteList.Margin = new Padding(2);
            lvRouteList.Name = "lvRouteList";
            lvRouteList.Size = new System.Drawing.Size(762, 207);
            lvRouteList.TabIndex = 1;
            lvRouteList.UseCompatibleStateImageBehavior = false;
            lvRouteList.ViewType = ViewTypes.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Start region";
            columnHeader2.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "End region";
            columnHeader4.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Num. Steps";
            columnHeader3.Width = 150;
            // 
            // panel1
            // 
            panel1.BackColor = SKColors.Transparent;
            panel1.Border = new Padding(0, 0, 0, 0);
            panel1.BorderColor = SKColors.Transparent;
            panel1.Controls.Add(checkRunTownscript);
            panel1.Location = new System.Drawing.Point(7, 285);
            panel1.Name = "panel1";
            panel1.ShadowDepth = 4F;
            panel1.Size = new System.Drawing.Size(766, 42);
            panel1.TabIndex = 29;
            // 
            // checkRunTownscript
            // 
            checkRunTownscript.AutoSize = true;
            checkRunTownscript.BackColor = SKColors.Transparent;
            checkRunTownscript.Depth = 0;
            checkRunTownscript.Location = new System.Drawing.Point(2, 9);
            checkRunTownscript.Margin = new Padding(0);
            checkRunTownscript.MouseLocation = new System.Drawing.Point(-1, -1);
            checkRunTownscript.Name = "checkRunTownscript";
            checkRunTownscript.Ripple = true;
            checkRunTownscript.Size = new System.Drawing.Size(219, 30);
            checkRunTownscript.TabIndex = 27;
            checkRunTownscript.Text = "Run townscript after route finished";
            checkRunTownscript.UseVisualStyleBackColor = false;
            checkRunTownscript.CheckedChanged += checkBoxSetting_CheckedChanged;
            // 
            // tabPageSettings
            // 
            tabPageSettings.BackColor = SKColors.White;
            tabPageSettings.Controls.Add(checkAttackThiefPlayers);
            tabPageSettings.Controls.Add(groupBox1);
            tabPageSettings.Controls.Add(checkProtectTransport);
            tabPageSettings.Controls.Add(checkCounterAttack);
            tabPageSettings.Controls.Add(checkAttackThiefNpc);
            tabPageSettings.Controls.Add(groupBox2);
            tabPageSettings.Location = new System.Drawing.Point(4, 28);
            tabPageSettings.Margin = new Padding(2);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new Padding(2);
            tabPageSettings.Size = new System.Drawing.Size(779, 356);
            tabPageSettings.TabIndex = 1;
            tabPageSettings.Text = "Settings";
            // 
            // checkAttackThiefPlayers
            // 
            checkAttackThiefPlayers.AutoSize = true;
            checkAttackThiefPlayers.BackColor = SKColors.Transparent;
            checkAttackThiefPlayers.Depth = 0;
            checkAttackThiefPlayers.Location = new System.Drawing.Point(41, 45);
            checkAttackThiefPlayers.Margin = new Padding(0);
            checkAttackThiefPlayers.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAttackThiefPlayers.Name = "checkAttackThiefPlayers";
            checkAttackThiefPlayers.Ripple = true;
            checkAttackThiefPlayers.Size = new System.Drawing.Size(134, 30);
            checkAttackThiefPlayers.TabIndex = 0;
            checkAttackThiefPlayers.Text = "Attack thief players";
            checkAttackThiefPlayers.UseVisualStyleBackColor = false;
            checkAttackThiefPlayers.CheckedChanged += checkBoxSetting_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SKColors.Transparent;
            groupBox1.Controls.Add(checkSellGoods);
            groupBox1.Controls.Add(lblNumGoodsDesc);
            groupBox1.Controls.Add(checkBuyGoods);
            groupBox1.Controls.Add(numAmountGoods);
            groupBox1.Controls.Add(lblGoods);
            groupBox1.Location = new System.Drawing.Point(316, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 8, 3, 3);
            groupBox1.ShadowDepth = 4;
            groupBox1.Size = new System.Drawing.Size(311, 134);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buy / Sell";
            // 
            // checkSellGoods
            // 
            checkSellGoods.AutoSize = true;
            checkSellGoods.BackColor = SKColors.Transparent;
            checkSellGoods.Depth = 0;
            checkSellGoods.Location = new System.Drawing.Point(26, 35);
            checkSellGoods.Margin = new Padding(0);
            checkSellGoods.MouseLocation = new System.Drawing.Point(-1, -1);
            checkSellGoods.Name = "checkSellGoods";
            checkSellGoods.Ripple = true;
            checkSellGoods.Size = new System.Drawing.Size(86, 30);
            checkSellGoods.TabIndex = 5;
            checkSellGoods.Text = "Sell goods";
            checkSellGoods.UseVisualStyleBackColor = false;
            checkSellGoods.CheckedChanged += checkBoxSetting_CheckedChanged;
            // 
            // lblNumGoodsDesc
            // 
            lblNumGoodsDesc.AutoSize = true;
           lblNumGoodsDesc.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblNumGoodsDesc.Location = new System.Drawing.Point(84, 95);
            lblNumGoodsDesc.Name = "lblNumGoodsDesc";
            lblNumGoodsDesc.Size = new System.Drawing.Size(96, 13);
            lblNumGoodsDesc.TabIndex = 3;
            lblNumGoodsDesc.Text = "0 = max. possible";
            // 
            // checkBuyGoods
            // 
            checkBuyGoods.AutoSize = true;
            checkBuyGoods.Location = new System.Drawing.Point(26, 65);
            checkBuyGoods.Margin = new Padding(0);
            checkBuyGoods.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBuyGoods.Name = "checkBuyGoods";
            checkBuyGoods.Ripple = true;
            checkBuyGoods.Size = new System.Drawing.Size(50, 30);
            checkBuyGoods.TabIndex = 0;
            checkBuyGoods.Text = "Buy ";
            checkBuyGoods.UseVisualStyleBackColor = false;
            checkBuyGoods.CheckedChanged += checkBoxSetting_CheckedChanged;
            // 
            // numAmountGoods
            // 
            numAmountGoods.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numAmountGoods.Location = new System.Drawing.Point(85, 68);
            numAmountGoods.Maximum = 999999;
            numAmountGoods.Minimum = 0;
            numAmountGoods.MinimumSize = new System.Drawing.Size(80, 25);
            numAmountGoods.Name = "numAmountGoods";
            numAmountGoods.Size = new System.Drawing.Size(95, 25);
            numAmountGoods.TabIndex = 1;
            numAmountGoods.Value = 0;
            numAmountGoods.TextChanged += numSetting_ValueChanged;
            // 
            // lblGoods
            // 
            lblGoods.ApplyGradient = false;
            lblGoods.AutoSize = true;
            lblGoods.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblGoods.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            lblGoods.GradientAnimation = false;
            lblGoods.Location = new System.Drawing.Point(186, 70);
            lblGoods.Name = "lblGoods";
            lblGoods.Size = new System.Drawing.Size(90, 15);
            lblGoods.TabIndex = 2;
            lblGoods.Text = "x Special Goods";
            // 
            // checkProtectTransport
            // 
            checkProtectTransport.AutoSize = true;
            checkProtectTransport.BackColor = SKColors.Transparent;
            checkProtectTransport.Depth = 0;
            checkProtectTransport.Location = new System.Drawing.Point(41, 124);
            checkProtectTransport.Margin = new Padding(0);
            checkProtectTransport.MouseLocation = new System.Drawing.Point(-1, -1);
            checkProtectTransport.Name = "checkProtectTransport";
            checkProtectTransport.Ripple = true;
            checkProtectTransport.Size = new System.Drawing.Size(122, 30);
            checkProtectTransport.TabIndex = 6;
            checkProtectTransport.Text = "Protect transport";
            checkProtectTransport.UseVisualStyleBackColor = false;
            checkProtectTransport.CheckedChanged += checkBoxSetting_CheckedChanged;
            // 
            // checkCounterAttack
            // 
            checkCounterAttack.AutoSize = true;
            checkCounterAttack.BackColor = SKColors.Transparent;
            checkCounterAttack.Depth = 0;
            checkCounterAttack.Location = new System.Drawing.Point(41, 96);
            checkCounterAttack.Margin = new Padding(0);
            checkCounterAttack.MouseLocation = new System.Drawing.Point(-1, -1);
            checkCounterAttack.Name = "checkCounterAttack";
            checkCounterAttack.Ripple = true;
            checkCounterAttack.Size = new System.Drawing.Size(110, 30);
            checkCounterAttack.TabIndex = 2;
            checkCounterAttack.Text = "Counter attack";
            checkCounterAttack.UseVisualStyleBackColor = false;
            checkCounterAttack.CheckedChanged += checkBoxSetting_CheckedChanged;
            // 
            // checkAttackThiefNpc
            // 
            checkAttackThiefNpc.AutoSize = true;
            checkAttackThiefNpc.BackColor = SKColors.Transparent;
            checkAttackThiefNpc.Depth = 0;
            checkAttackThiefNpc.Location = new System.Drawing.Point(41, 71);
            checkAttackThiefNpc.Margin = new Padding(0);
            checkAttackThiefNpc.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAttackThiefNpc.Name = "checkAttackThiefNpc";
            checkAttackThiefNpc.Ripple = true;
            checkAttackThiefNpc.Size = new System.Drawing.Size(124, 30);
            checkAttackThiefNpc.TabIndex = 1;
            checkAttackThiefNpc.Text = "Attack thief NPCs";
            checkAttackThiefNpc.UseVisualStyleBackColor = false;
            checkAttackThiefNpc.CheckedChanged += checkBoxSetting_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SKColors.Transparent;
            groupBox2.Controls.Add(Splitter2);
            groupBox2.Controls.Add(checkCastBuffs);
            groupBox2.Controls.Add(checkWaitForHunter);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Splitter4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(numMaxDistance);
            groupBox2.Controls.Add(checkMountTransport);
            groupBox2.Controls.Add(Splitter1);
            groupBox2.Location = new System.Drawing.Point(13, 15);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 4, 2, 2);
            groupBox2.ShadowDepth = 4;
            groupBox2.Size = new System.Drawing.Size(287, 324);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Settings";
            // 
            // Splitter2
            // 
            Splitter2.Location = new System.Drawing.Point(2, 268);
            Splitter2.Margin = new Padding(2);
            Splitter2.Name = "Splitter2";
            Splitter2.Size = new System.Drawing.Size(282, 12);
            Splitter2.TabIndex = 31;
            Splitter2.Text = "Splitter2";
            // 
            // checkCastBuffs
            // 
            checkCastBuffs.AutoSize = true;
            checkCastBuffs.BackColor = SKColors.Transparent;
            checkCastBuffs.Depth = 0;
            checkCastBuffs.Location = new System.Drawing.Point(30, 148);
            checkCastBuffs.Margin = new Padding(0);
            checkCastBuffs.MouseLocation = new System.Drawing.Point(-1, -1);
            checkCastBuffs.Name = "checkCastBuffs";
            checkCastBuffs.Ripple = true;
            checkCastBuffs.Size = new System.Drawing.Size(83, 30);
            checkCastBuffs.TabIndex = 4;
            checkCastBuffs.Text = "Cast buffs";
            checkCastBuffs.UseVisualStyleBackColor = false;
            checkCastBuffs.CheckedChanged += checkBoxSetting_CheckedChanged;
            // 
            // checkWaitForHunter
            // 
            checkWaitForHunter.AutoSize = true;
            checkWaitForHunter.BackColor = SKColors.Transparent;
            checkWaitForHunter.Depth = 0;
            checkWaitForHunter.Location = new System.Drawing.Point(28, 281);
            checkWaitForHunter.Margin = new Padding(0);
            checkWaitForHunter.MouseLocation = new System.Drawing.Point(-1, -1);
            checkWaitForHunter.Name = "checkWaitForHunter";
            checkWaitForHunter.Ripple = true;
            checkWaitForHunter.Size = new System.Drawing.Size(163, 30);
            checkWaitForHunter.TabIndex = 30;
            checkWaitForHunter.Text = "Wait for a hunter nearby";
            checkWaitForHunter.UseVisualStyleBackColor = false;
            checkWaitForHunter.CheckedChanged += checkBoxSetting_CheckedChanged;
            // 
            // label3
            // 
            label3.ApplyGradient = false;
            label3.AutoSize = true;
            label3.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label3.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label3.GradientAnimation = false;
            label3.Location = new System.Drawing.Point(116, 235);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "meters";
            // 
            // Splitter4
            // 
            Splitter4.Location = new System.Drawing.Point(0, 176);
            Splitter4.Margin = new Padding(2);
            Splitter4.Name = "Splitter4";
            Splitter4.Size = new System.Drawing.Size(282, 12);
            Splitter4.TabIndex = 8;
            Splitter4.Text = "Splitter4";
            // 
            // label1
            // 
            label1.ApplyGradient = false;
            label1.AutoSize = true;
            label1.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label1.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label1.GradientAnimation = false;
            label1.Location = new System.Drawing.Point(28, 219);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 15);
            label1.TabIndex = 5;
            label1.Text = "Max. distance:";
            // 
            // numMaxDistance
            // 
            numMaxDistance.BackColor = SKColors.Transparent;
            numMaxDistance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numMaxDistance.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numMaxDistance.Location = new System.Drawing.Point(30, 237);
            numMaxDistance.Maximum = 100;
            numMaxDistance.Minimum = 1;
            numMaxDistance.MinimumSize = new System.Drawing.Size(80, 25);
            numMaxDistance.Name = "numMaxDistance";
            numMaxDistance.Size = new System.Drawing.Size(80, 25);
            numMaxDistance.TabIndex = 4;
            numMaxDistance.Value = 1;
            numMaxDistance.TextChanged += numSetting_ValueChanged;
            // 
            // checkMountTransport
            // 
            checkMountTransport.AutoSize = true;
            checkMountTransport.BackColor = SKColors.Transparent;
            checkMountTransport.Depth = 0;
            checkMountTransport.Location = new System.Drawing.Point(28, 186);
            checkMountTransport.Margin = new Padding(0);
            checkMountTransport.MouseLocation = new System.Drawing.Point(-1, -1);
            checkMountTransport.Name = "checkMountTransport";
            checkMountTransport.Ripple = true;
            checkMountTransport.Size = new System.Drawing.Size(119, 30);
            checkMountTransport.TabIndex = 7;
            checkMountTransport.Text = "Mount transport";
            checkMountTransport.UseVisualStyleBackColor = false;
            checkMountTransport.CheckedChanged += checkBoxSetting_CheckedChanged;
            // 
            // Splitter1
            //
            Splitter1.Location = new System.Drawing.Point(4, 137);
            Splitter1.Margin = new Padding(2);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new System.Drawing.Size(282, 12);
            Splitter1.TabIndex = 3;
            Splitter1.Text = "Splitter1";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SKColors.White;
            tabPage1.Controls.Add(lblJobExp);
            tabPage1.Controls.Add(lblJobLevel);
            tabPage1.Controls.Add(lblJobAlias);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(Splitter3);
            tabPage1.Controls.Add(lblTradeScale);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new System.Drawing.Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new System.Drawing.Size(779, 356);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Job overview";
            // 
            // lblJobExp
            // 
            lblJobExp.ApplyGradient = false;
            lblJobExp.AutoSize = true;
            lblJobExp.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblJobExp.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            lblJobExp.GradientAnimation = false;
            lblJobExp.Location = new System.Drawing.Point(129, 163);
            lblJobExp.Name = "lblJobExp";
            lblJobExp.Size = new System.Drawing.Size(13, 15);
            lblJobExp.TabIndex = 11;
            lblJobExp.Text = "0";
            // 
            // lblJobLevel
            // 
            lblJobLevel.ApplyGradient = false;
            lblJobLevel.AutoSize = true;
            lblJobLevel.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblJobLevel.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            lblJobLevel.GradientAnimation = false;
            lblJobLevel.Location = new System.Drawing.Point(129, 127);
            lblJobLevel.Name = "lblJobLevel";
            lblJobLevel.Size = new System.Drawing.Size(13, 15);
            lblJobLevel.TabIndex = 10;
            lblJobLevel.Text = "0";
            // 
            // lblJobAlias
            // 
            lblJobAlias.ApplyGradient = false;
            lblJobAlias.AutoSize = true;
            lblJobAlias.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblJobAlias.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            lblJobAlias.GradientAnimation = false;
            lblJobAlias.Location = new System.Drawing.Point(129, 90);
            lblJobAlias.Name = "lblJobAlias";
            lblJobAlias.Size = new System.Drawing.Size(50, 15);
            lblJobAlias.TabIndex = 9;
            lblJobAlias.Text = "<none>";
            // 
            // label9
            // 
            label9.ApplyGradient = false;
            label9.AutoSize = true;
            label9.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label9.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label9.GradientAnimation = false;
            label9.Location = new System.Drawing.Point(93, 163);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(30, 15);
            label9.TabIndex = 8;
            label9.Text = "EXP:";
            // 
            // label8
            // 
            label8.ApplyGradient = false;
            label8.AutoSize = true;
            label8.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label8.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label8.GradientAnimation = false;
            label8.Location = new System.Drawing.Point(69, 90);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(54, 15);
            label8.TabIndex = 7;
            label8.Text = "Job alias:";
            // 
            // label7
            // 
            label7.ApplyGradient = false;
            label7.AutoSize = true;
            label7.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label7.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label7.GradientAnimation = false;
            label7.Location = new System.Drawing.Point(86, 127);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(37, 15);
            label7.TabIndex = 7;
            label7.Text = "Level:";
            // 
            // Splitter3
            // 
            Splitter3.Location = new System.Drawing.Point(20, 67);
            Splitter3.Name = "Splitter3";
            Splitter3.Size = new System.Drawing.Size(365, 10);
            Splitter3.TabIndex = 6;
            Splitter3.Text = "Splitter3";
            // 
            // lblTradeScale
            // 
            lblTradeScale.ApplyGradient = false;
            lblTradeScale.AutoSize = true;
            lblTradeScale.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblTradeScale.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            lblTradeScale.GradientAnimation = false;
            lblTradeScale.Location = new System.Drawing.Point(144, 37);
            lblTradeScale.Name = "lblTradeScale";
            lblTradeScale.Size = new System.Drawing.Size(57, 15);
            lblTradeScale.TabIndex = 2;
            lblTradeScale.Text = "■■■■■";
            // 
            // label2
            // 
            label2.ApplyGradient = false;
            label2.AutoSize = true;
            label2.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label2.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label2.GradientAnimation = false;
            label2.Location = new System.Drawing.Point(50, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Trade difficulty:";
            // 
            // Main
            // 
            
            
            Controls.Add(tabControl1);
            Controls.Add(lblHint);
            Margin = new Padding(2);
            Name = "Main";
            Size = new System.Drawing.Size(790, 442);
            ParentChanged += Main_Load;
            contextMenuRouteList.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageRoute.ResumeLayout(false);
            tabPageRoute.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageSettings.ResumeLayout(false);
            tabPageSettings.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SDUI.ContextMenu contextMenuRouteList;
        private MenuItem addScriptMenuItem;
        private MenuItem menuRemoveScript;
        private SDUI.Label lblHint;
        private SDUI.TabControl tabControl1;
        private TabPage tabPageRoute;
        private LinkLabel linkRecord;
        private SDUI.ListView lvRouteList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TabPage tabPageSettings;
        private SDUI.ComboBox comboRouteList;
        private SDUI.Button buttonDeleteList;
        private SDUI.Button buttonCreateList;
        private SDUI.RadioButton radioUseRouteList;
        private SDUI.RadioButton radioTracePlayer;
        private SDUI.TextBox txtTracePlayerName;
        private SDUI.CheckBox checkCastBuffs;
        private SDUI.Splitter Splitter1;
        private SDUI.CheckBox checkCounterAttack;
        private SDUI.CheckBox checkAttackThiefNpc;
        private SDUI.CheckBox checkAttackThiefPlayers;
        private MenuItem menuRecordScript;
        private MenuItem menuChooseScript;
        private SDUI.CheckBox checkRunTownscript;
        private ColumnHeader columnHeader4;
        private SDUI.Panel panel1;
        private SDUI.CheckBox checkProtectTransport;
        private SDUI.GroupBox groupBox1;
        private SDUI.CheckBox checkBuyGoods;
        private SDUI.Label lblGoods;
        private SDUI.NumUpDown numAmountGoods;
        private SDUI.Label lblNumGoodsDesc;
        private SDUI.CheckBox checkSellGoods;
        private TabPage tabPage1;
        private SDUI.Label label4;
        private SDUI.Label lblTradeScale;
        private SDUI.Label label2;
        private SDUI.Splitter Splitter3;
        private SDUI.Label label9;
        private SDUI.Label label8;
        private SDUI.Label label7;
        private SDUI.Label lblJobExp;
        private SDUI.Label lblJobLevel;
        private SDUI.Label lblJobAlias;
        private SDUI.CheckBox checkMountTransport;
        private SDUI.GroupBox groupBox2;
        private SDUI.Label label3;
        private SDUI.Label label1;
        private SDUI.NumUpDown numMaxDistance;
        private SDUI.Splitter Splitter4;
        private SDUI.Splitter Splitter2;
        private SDUI.CheckBox checkWaitForHunter;
    }
}
