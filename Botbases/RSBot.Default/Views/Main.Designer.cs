﻿namespace RSBot.Default.Views
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Avoid", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Prefer", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Berzerk", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("No custom behavior", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("General");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Champion");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Giant");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("General (party)");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Champion (party)");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Giant (party)");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Unique");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Strong");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Elite");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Event");
            groupBox2 = new System.Windows.Forms.GroupBox();
            lvAvoidance = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            ctxAvoidance = new System.Windows.Forms.ContextMenuStrip();
            btnAvoid = new System.Windows.Forms.ToolStripMenuItem();
            btnPrefer = new System.Windows.Forms.ToolStripMenuItem();
            btnBerserk = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            btnNoCustomBehavior = new System.Windows.Forms.ToolStripMenuItem();
            groupBoxWalkback = new System.Windows.Forms.GroupBox();
            linkRecord = new System.Windows.Forms.LinkLabel();
            checkBoxUseReverse = new System.Windows.Forms.CheckBox();
            checkUseSpeedDrug = new System.Windows.Forms.CheckBox();
            checkCastBuffs = new System.Windows.Forms.CheckBox();
            checkUseMount = new System.Windows.Forms.CheckBox();
            btnBrowse = new System.Windows.Forms.Button();
            txtWalkscript = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            checkBerzerkWhenFull = new System.Windows.Forms.CheckBox();
            checkBerserkOnMonsterRarity = new System.Windows.Forms.CheckBox();
            groupBoxBerserk = new System.Windows.Forms.GroupBox();
            label7 = new System.Windows.Forms.Label();
            numBerzerkMonsterAmount = new System.Windows.Forms.NumericUpDown();
            checkBerzerkAvoidance = new System.Windows.Forms.CheckBox();
            checkBerzerkMonsterAmount = new System.Windows.Forms.CheckBox();
            groupBoxArea = new System.Windows.Forms.GroupBox();
            buttonSelectTrainingArea = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            radioWalkAround = new System.Windows.Forms.RadioButton();
            radioCenter = new System.Windows.Forms.RadioButton();
            btnGetCurrent = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtRadius = new System.Windows.Forms.TextBox();
            txtYCoord = new System.Windows.Forms.TextBox();
            txtXCoord = new System.Windows.Forms.TextBox();
            groupBoxAdvanced = new System.Windows.Forms.GroupBox();
            linkAttackWeakerMobsHelp = new System.Windows.Forms.LinkLabel();
            checkAttackWeakerFirst = new System.Windows.Forms.CheckBox();
            checkBoxDimensionPillar = new System.Windows.Forms.CheckBox();
            groupBox2.SuspendLayout();
            ctxAvoidance.SuspendLayout();
            groupBoxWalkback.SuspendLayout();
            groupBoxBerserk.SuspendLayout();
            groupBoxArea.SuspendLayout();
            groupBoxAdvanced.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            
            groupBox2.Controls.Add(lvAvoidance);
            groupBox2.Location = new System.Drawing.Point(23, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2, 7, 2, 3);
            
            
            groupBox2.Size = new System.Drawing.Size(221, 214);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Avoidance";
            // 
            // lvAvoidance
            // 
            lvAvoidance.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            
            lvAvoidance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvAvoidance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1 });
            lvAvoidance.ContextMenuStrip = ctxAvoidance;
            lvAvoidance.Dock = System.Windows.Forms.DockStyle.Fill;
            
            lvAvoidance.FullRowSelect = true;
            listViewGroup1.Header = "Avoid";
            listViewGroup1.Name = "grpAvoid";
            listViewGroup2.Header = "Prefer";
            listViewGroup2.Name = "grpPrefer";
            listViewGroup3.Header = "No custom behavior";
            listViewGroup3.Name = "grpNone";
            listViewGroup4.Header = "Berserk";
            listViewGroup4.Name = "grpBerserk";
            lvAvoidance.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup4, listViewGroup3 });
            lvAvoidance.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.Group = listViewGroup3;
            listViewItem2.Group = listViewGroup3;
            listViewItem3.Group = listViewGroup3;
            listViewItem4.Group = listViewGroup3;
            listViewItem5.Group = listViewGroup3;
            listViewItem6.Group = listViewGroup3;
            listViewItem7.Group = listViewGroup3;
            listViewItem8.Group = listViewGroup3;
            listViewItem9.Group = listViewGroup3;
            listViewItem10.Group = listViewGroup3;
            listViewItem10.ToolTipText = "Event Mobs";
            lvAvoidance.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10 });
            lvAvoidance.Location = new System.Drawing.Point(2, 23);
            lvAvoidance.Name = "lvAvoidance";
            lvAvoidance.Size = new System.Drawing.Size(217, 188);
            lvAvoidance.TabIndex = 5;
            lvAvoidance.TileSize = new System.Drawing.Size(168, 16);
            lvAvoidance.UseCompatibleStateImageBehavior = false;
            lvAvoidance.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 190;
            // 
            // ctxAvoidance
            // 
            ctxAvoidance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAvoid, btnPrefer, btnBerserk, toolStripSeparator1, btnNoCustomBehavior });
            ctxAvoidance.Name = "ctxAvoidance";
            ctxAvoidance.Size = new System.Drawing.Size(183, 76);
            // 
            // btnAvoid
            // 
            btnAvoid.Name = "btnAvoid";
            btnAvoid.Size = new System.Drawing.Size(182, 22);
            btnAvoid.Text = "Avoid";
            btnAvoid.Click += btnAvoid_Click;
            // 
            // btnPrefer
            // 
            btnPrefer.Name = "btnPrefer";
            btnPrefer.Size = new System.Drawing.Size(182, 22);
            btnPrefer.Text = "Prefer";
            btnPrefer.Click += btnPrefer_Click;
            // 
            // btnBerserk
            // 
            btnBerserk.Name = "btnBerserk";
            btnBerserk.Size = new System.Drawing.Size(182, 22);
            btnBerserk.Text = "Berserk";
            btnBerserk.Click += btnBerserk_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // btnNoCustomBehavior
            // 
            btnNoCustomBehavior.Name = "btnNoCustomBehavior";
            btnNoCustomBehavior.Size = new System.Drawing.Size(182, 22);
            btnNoCustomBehavior.Text = "No custom behavior";
            btnNoCustomBehavior.Click += btnNoCustomBehavior_Click;
            // 
            // groupBoxWalkback
            // 
            
            groupBoxWalkback.Controls.Add(linkRecord);
            groupBoxWalkback.Controls.Add(checkBoxUseReverse);
            groupBoxWalkback.Controls.Add(checkUseSpeedDrug);
            groupBoxWalkback.Controls.Add(checkCastBuffs);
            groupBoxWalkback.Controls.Add(checkUseMount);
            groupBoxWalkback.Controls.Add(btnBrowse);
            groupBoxWalkback.Controls.Add(txtWalkscript);
            groupBoxWalkback.Controls.Add(label4);
            groupBoxWalkback.Location = new System.Drawing.Point(262, 16);
            groupBoxWalkback.Name = "groupBoxWalkback";
            groupBoxWalkback.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            
            
            groupBoxWalkback.Size = new System.Drawing.Size(478, 117);
            groupBoxWalkback.TabIndex = 2;
            groupBoxWalkback.TabStop = false;
            groupBoxWalkback.Text = "Back to training";
            // 
            // linkRecord
            // 
            linkRecord.AutoSize = true;
            linkRecord.Location = new System.Drawing.Point(348, 33);
            linkRecord.Name = "linkRecord";
            linkRecord.Size = new System.Drawing.Size(52, 15);
            linkRecord.TabIndex = 7;
            linkRecord.TabStop = true;
            linkRecord.Text = "[Record]";
            linkRecord.LinkClicked += linkRecord_LinkClicked;
            // 
            // checkBoxUseReverse
            // 
            checkBoxUseReverse.AutoSize = true;
            
            
            checkBoxUseReverse.Location = new System.Drawing.Point(373, 80);
            checkBoxUseReverse.Margin = new System.Windows.Forms.Padding(0);
            
            checkBoxUseReverse.Name = "checkBoxUseReverse";
            
            checkBoxUseReverse.Size = new System.Drawing.Size(95, 30);
            checkBoxUseReverse.TabIndex = 7;
            checkBoxUseReverse.Text = "Use Reverse";
            checkBoxUseReverse.UseVisualStyleBackColor = false;
            checkBoxUseReverse.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseSpeedDrug
            // 
            checkUseSpeedDrug.AutoSize = true;
            
            
            checkUseSpeedDrug.Location = new System.Drawing.Point(258, 80);
            checkUseSpeedDrug.Margin = new System.Windows.Forms.Padding(0);
            
            checkUseSpeedDrug.Name = "checkUseSpeedDrug";
            
            checkUseSpeedDrug.Size = new System.Drawing.Size(115, 30);
            checkUseSpeedDrug.TabIndex = 7;
            checkUseSpeedDrug.Text = "Use speed drug";
            checkUseSpeedDrug.UseVisualStyleBackColor = false;
            checkUseSpeedDrug.CheckedChanged += settings_CheckedChanged;
            // 
            // checkCastBuffs
            // 
            checkCastBuffs.AutoSize = true;
            
            
            checkCastBuffs.Location = new System.Drawing.Point(169, 80);
            checkCastBuffs.Margin = new System.Windows.Forms.Padding(0);
            
            checkCastBuffs.Name = "checkCastBuffs";
            
            checkCastBuffs.Size = new System.Drawing.Size(83, 30);
            checkCastBuffs.TabIndex = 6;
            checkCastBuffs.Text = "Cast buffs";
            checkCastBuffs.UseVisualStyleBackColor = false;
            checkCastBuffs.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseMount
            // 
            checkUseMount.AutoSize = true;
            
            
            checkUseMount.Location = new System.Drawing.Point(18, 80);
            checkUseMount.Margin = new System.Windows.Forms.Padding(0);
            
            checkUseMount.Name = "checkUseMount";
            
            checkUseMount.Size = new System.Drawing.Size(150, 30);
            checkUseMount.TabIndex = 3;
            checkUseMount.Text = "Use mount if available";
            checkUseMount.UseVisualStyleBackColor = false;
            checkUseMount.CheckedChanged += settings_CheckedChanged;
            // 
            // btnBrowse
            // 
            
            btnBrowse.Location = new System.Drawing.Point(406, 51);
            btnBrowse.Name = "btnBrowse";
            
            
            btnBrowse.Size = new System.Drawing.Size(57, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtWalkscript
            // 
            
            txtWalkscript.Location = new System.Drawing.Point(21, 52);
            txtWalkscript.MaxLength = 32767;
            txtWalkscript.Multiline = false;
            txtWalkscript.Name = "txtWalkscript";
            
            
            txtWalkscript.Size = new System.Drawing.Size(379, 21);
            txtWalkscript.TabIndex = 4;
            
            txtWalkscript.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            
            label4.AutoSize = true;
            
            
            
            label4.Location = new System.Drawing.Point(18, 33);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Walkscript:";
            // 
            // checkBerzerkWhenFull
            // 
            checkBerzerkWhenFull.AutoSize = true;
            
            
            checkBerzerkWhenFull.Location = new System.Drawing.Point(21, 34);
            checkBerzerkWhenFull.Margin = new System.Windows.Forms.Padding(0);
            
            checkBerzerkWhenFull.Name = "checkBerzerkWhenFull";
            
            checkBerzerkWhenFull.Size = new System.Drawing.Size(190, 30);
            checkBerzerkWhenFull.TabIndex = 4;
            checkBerzerkWhenFull.Text = "Enter berzerk mode when full";
            checkBerzerkWhenFull.UseVisualStyleBackColor = false;
            checkBerzerkWhenFull.CheckedChanged += settings_CheckedChanged;
            // 
            // checkBerserkOnMonsterRarity
            // 
            checkBerserkOnMonsterRarity.AutoSize = true;
            
            
            checkBerserkOnMonsterRarity.Location = new System.Drawing.Point(21, 112);
            checkBerserkOnMonsterRarity.Margin = new System.Windows.Forms.Padding(0);
            
            checkBerserkOnMonsterRarity.Name = "checkBerserkOnMonsterRarity";
            
            checkBerserkOnMonsterRarity.Size = new System.Drawing.Size(190, 30);
            checkBerserkOnMonsterRarity.TabIndex = 4;
            checkBerserkOnMonsterRarity.Text = "Enter berserk mode when attack specific monster type";
            checkBerserkOnMonsterRarity.UseVisualStyleBackColor = false;
            checkBerserkOnMonsterRarity.CheckedChanged += settings_CheckedChanged;
            // 
            // groupBoxBerserk
            // 
            
            groupBoxBerserk.Controls.Add(label7);
            groupBoxBerserk.Controls.Add(numBerzerkMonsterAmount);
            groupBoxBerserk.Controls.Add(checkBerzerkAvoidance);
            groupBoxBerserk.Controls.Add(checkBerzerkMonsterAmount);
            groupBoxBerserk.Controls.Add(checkBerzerkWhenFull);
            groupBoxBerserk.Controls.Add(checkBerserkOnMonsterRarity);
            groupBoxBerserk.Location = new System.Drawing.Point(262, 144);
            groupBoxBerserk.Name = "groupBoxBerserk";
            groupBoxBerserk.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            
            
            groupBoxBerserk.Size = new System.Drawing.Size(478, 150);
            groupBoxBerserk.TabIndex = 5;
            groupBoxBerserk.TabStop = false;
            groupBoxBerserk.Text = "Berserk";
            // 
            // label7
            // 
            
            label7.AutoSize = true;
            
            
            
            label7.Location = new System.Drawing.Point(300, 67);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(56, 15);
            label7.TabIndex = 7;
            label7.Text = "monsters";
            // 
            // numBerzerkMonsterAmount
            // 
            
            numBerzerkMonsterAmount.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            
            numBerzerkMonsterAmount.Location = new System.Drawing.Point(214, 62);
            numBerzerkMonsterAmount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numBerzerkMonsterAmount.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numBerzerkMonsterAmount.MinimumSize = new System.Drawing.Size(80, 25);
            numBerzerkMonsterAmount.Name = "numBerzerkMonsterAmount";
            numBerzerkMonsterAmount.Size = new System.Drawing.Size(80, 25);
            numBerzerkMonsterAmount.TabIndex = 6;
            numBerzerkMonsterAmount.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numBerzerkMonsterAmount.ValueChanged += numSettings_ValueChanged;
            // 
            // checkBerzerkAvoidance
            // 
            checkBerzerkAvoidance.AutoSize = true;
            
            
            checkBerzerkAvoidance.Location = new System.Drawing.Point(21, 86);
            checkBerzerkAvoidance.Margin = new System.Windows.Forms.Padding(0);
            
            checkBerzerkAvoidance.Name = "checkBerzerkAvoidance";
            
            checkBerzerkAvoidance.Size = new System.Drawing.Size(352, 30);
            checkBerzerkAvoidance.TabIndex = 5;
            checkBerzerkAvoidance.Text = "If being attacked by a monster type that should be avoided";
            checkBerzerkAvoidance.UseVisualStyleBackColor = false;
            checkBerzerkAvoidance.CheckedChanged += settings_CheckedChanged;
            // 
            // checkBerzerkMonsterAmount
            // 
            checkBerzerkMonsterAmount.AutoSize = true;
            
            
            checkBerzerkMonsterAmount.Location = new System.Drawing.Point(21, 60);
            checkBerzerkMonsterAmount.Margin = new System.Windows.Forms.Padding(0);
            
            checkBerzerkMonsterAmount.Name = "checkBerzerkMonsterAmount";
            
            checkBerzerkMonsterAmount.Size = new System.Drawing.Size(187, 30);
            checkBerzerkMonsterAmount.TabIndex = 4;
            checkBerzerkMonsterAmount.Text = "Being attacked by more than";
            checkBerzerkMonsterAmount.UseVisualStyleBackColor = false;
            checkBerzerkMonsterAmount.CheckedChanged += settings_CheckedChanged;
            // 
            // groupBoxArea
            // 
            
            groupBoxArea.Controls.Add(buttonSelectTrainingArea);
            groupBoxArea.Controls.Add(label6);
            groupBoxArea.Controls.Add(label5);
            groupBoxArea.Controls.Add(radioWalkAround);
            groupBoxArea.Controls.Add(radioCenter);
            groupBoxArea.Controls.Add(btnGetCurrent);
            groupBoxArea.Controls.Add(label3);
            groupBoxArea.Controls.Add(label2);
            groupBoxArea.Controls.Add(label1);
            groupBoxArea.Controls.Add(txtRadius);
            groupBoxArea.Controls.Add(txtYCoord);
            groupBoxArea.Controls.Add(txtXCoord);
            groupBoxArea.Location = new System.Drawing.Point(23, 16);
            groupBoxArea.Name = "groupBoxArea";
            groupBoxArea.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            
            
            groupBoxArea.Size = new System.Drawing.Size(221, 228);
            groupBoxArea.TabIndex = 0;
            groupBoxArea.TabStop = false;
            groupBoxArea.Text = "Area";
            // 
            // buttonSelectTrainingArea
            // 
            
            buttonSelectTrainingArea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonSelectTrainingArea.Location = new System.Drawing.Point(179, 107);
            buttonSelectTrainingArea.Name = "buttonSelectTrainingArea";
            
            
            buttonSelectTrainingArea.Size = new System.Drawing.Size(24, 24);
            buttonSelectTrainingArea.TabIndex = 7;
            buttonSelectTrainingArea.Text = "...";
            buttonSelectTrainingArea.UseVisualStyleBackColor = true;
            buttonSelectTrainingArea.Click += buttonSelectTrainingArea_Click;
            // 
            // label6
            // 
            
            label6.AutoSize = true;
            
            
            
            label6.Location = new System.Drawing.Point(14, 145);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(159, 15);
            label6.TabIndex = 7;
            label6.Text = "If there is no enemy nearby...";
            // 
            // label5
            // 
            
            
            
            
            label5.Location = new System.Drawing.Point(11, 142);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(200, 2);
            label5.TabIndex = 6;
            // 
            // radioWalkAround
            // 
            radioWalkAround.AutoSize = true;
            radioWalkAround.Checked = true;
            radioWalkAround.Location = new System.Drawing.Point(35, 192);
            radioWalkAround.Margin = new System.Windows.Forms.Padding(0);
            radioWalkAround.Name = "radioWalkAround";
            
            radioWalkAround.Size = new System.Drawing.Size(100, 30);
            radioWalkAround.TabIndex = 5;
            radioWalkAround.TabStop = true;
            radioWalkAround.Text = "Walk around";
            radioWalkAround.CheckedChanged += settings_CheckedChanged;
            // 
            // radioCenter
            // 
            radioCenter.AutoSize = true;
            radioCenter.Location = new System.Drawing.Point(35, 166);
            radioCenter.Margin = new System.Windows.Forms.Padding(0);
            radioCenter.Name = "radioCenter";
            
            radioCenter.Size = new System.Drawing.Size(127, 30);
            radioCenter.TabIndex = 4;
            radioCenter.Text = "Go back to center";
            radioCenter.CheckedChanged += settings_CheckedChanged;
            // 
            // btnGetCurrent
            // 
            
            btnGetCurrent.Location = new System.Drawing.Point(76, 107);
            btnGetCurrent.Name = "btnGetCurrent";
            
            
            btnGetCurrent.Size = new System.Drawing.Size(97, 23);
            btnGetCurrent.TabIndex = 3;
            btnGetCurrent.Text = "Current";
            btnGetCurrent.UseVisualStyleBackColor = true;
            btnGetCurrent.Click += btnGetCurrent_Click;
            // 
            // label3
            // 
            
            label3.AutoSize = true;
            
            
            
            label3.Location = new System.Drawing.Point(27, 84);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 1;
            label3.Text = "Radius:";
            // 
            // label2
            // 
            
            label2.AutoSize = true;
            
            
            
            label2.Location = new System.Drawing.Point(53, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "Y:";
            // 
            // label1
            // 
            
            label1.AutoSize = true;
            
            
            
            label1.Location = new System.Drawing.Point(53, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "X:";
            // 
            // txtRadius
            // 
            txtRadius.Location = new System.Drawing.Point(76, 81);
            txtRadius.MaxLength = 32767;
            txtRadius.Multiline = false;
            txtRadius.Name = "txtRadius";
            
            
            txtRadius.Size = new System.Drawing.Size(97, 21);
            txtRadius.TabIndex = 0;
            
            txtRadius.UseSystemPasswordChar = false;
            txtRadius.TextChanged += txtRadius_TextChanged;
            // 
            // txtYCoord
            // 
            txtYCoord.Location = new System.Drawing.Point(76, 55);
            txtYCoord.MaxLength = 32767;
            txtYCoord.Multiline = false;
            txtYCoord.Name = "txtYCoord";
            
            
            txtYCoord.Size = new System.Drawing.Size(97, 21);
            txtYCoord.TabIndex = 0;
            
            txtYCoord.UseSystemPasswordChar = false;
            txtYCoord.TextChanged += txtYCoord_TextChanged;
            // 
            // txtXCoord
            // 
            txtXCoord.Location = new System.Drawing.Point(76, 29);
            txtXCoord.MaxLength = 32767;
            txtXCoord.Multiline = false;
            txtXCoord.Name = "txtXCoord";
            
            
            txtXCoord.Size = new System.Drawing.Size(97, 21);
            txtXCoord.TabIndex = 0;
            
            txtXCoord.UseSystemPasswordChar = false;
            txtXCoord.TextChanged += txtXCoord_TextChanged;
            // 
            // groupBoxAdvanced
            // 
            
            groupBoxAdvanced.Controls.Add(linkAttackWeakerMobsHelp);
            groupBoxAdvanced.Controls.Add(checkAttackWeakerFirst);
            groupBoxAdvanced.Controls.Add(checkBoxDimensionPillar);
            groupBoxAdvanced.Location = new System.Drawing.Point(262, 300);
            groupBoxAdvanced.Name = "groupBoxAdvanced";
            groupBoxAdvanced.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            
            
            groupBoxAdvanced.Size = new System.Drawing.Size(478, 100);
            groupBoxAdvanced.TabIndex = 6;
            groupBoxAdvanced.TabStop = false;
            groupBoxAdvanced.Text = "Advanced";
            // 
            // linkAttackWeakerMobsHelp
            // 
            linkAttackWeakerMobsHelp.AutoSize = true;
            linkAttackWeakerMobsHelp.Location = new System.Drawing.Point(286, 64);
            linkAttackWeakerMobsHelp.Name = "linkAttackWeakerMobsHelp";
            linkAttackWeakerMobsHelp.Size = new System.Drawing.Size(12, 15);
            linkAttackWeakerMobsHelp.TabIndex = 7;
            linkAttackWeakerMobsHelp.TabStop = true;
            linkAttackWeakerMobsHelp.Text = "?";
            linkAttackWeakerMobsHelp.LinkClicked += linkAttackWeakerMobsHelp_LinkClicked;
            // 
            // checkAttackWeakerFirst
            // 
            checkAttackWeakerFirst.AutoSize = true;
            
            
            checkAttackWeakerFirst.Location = new System.Drawing.Point(21, 57);
            checkAttackWeakerFirst.Margin = new System.Windows.Forms.Padding(0);
            
            checkAttackWeakerFirst.Name = "checkAttackWeakerFirst";
            
            checkAttackWeakerFirst.Size = new System.Drawing.Size(267, 30);
            checkAttackWeakerFirst.TabIndex = 1;
            checkAttackWeakerFirst.Text = "If avoided: counter attack weaker mobs first";
            checkAttackWeakerFirst.UseVisualStyleBackColor = false;
            checkAttackWeakerFirst.CheckedChanged += settings_CheckedChanged;
            // 
            // checkBoxDimensionPillar
            // 
            checkBoxDimensionPillar.AutoSize = true;
            
            
            checkBoxDimensionPillar.Location = new System.Drawing.Point(21, 27);
            checkBoxDimensionPillar.Margin = new System.Windows.Forms.Padding(0);
            
            checkBoxDimensionPillar.Name = "checkBoxDimensionPillar";
            
            checkBoxDimensionPillar.Size = new System.Drawing.Size(157, 30);
            checkBoxDimensionPillar.TabIndex = 0;
            checkBoxDimensionPillar.Text = "Ignore Dimension Pillar";
            checkBoxDimensionPillar.UseVisualStyleBackColor = false;
            checkBoxDimensionPillar.CheckedChanged += settings_CheckedChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(groupBoxAdvanced);
            Controls.Add(groupBoxWalkback);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxArea);
            Controls.Add(groupBoxBerserk);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "Main";
            Size = new System.Drawing.Size(772, 491);
            Load += Main_Load;
            groupBox2.ResumeLayout(false);
            ctxAvoidance.ResumeLayout(false);
            groupBoxWalkback.ResumeLayout(false);
            groupBoxWalkback.PerformLayout();
            groupBoxBerserk.ResumeLayout(false);
            groupBoxBerserk.PerformLayout();
            groupBoxArea.ResumeLayout(false);
            groupBoxArea.PerformLayout();
            groupBoxAdvanced.ResumeLayout(false);
            groupBoxAdvanced.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxWalkback;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtWalkscript;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkUseMount;
        private System.Windows.Forms.CheckBox checkUseSpeedDrug;
        private System.Windows.Forms.CheckBox checkCastBuffs;
        private System.Windows.Forms.CheckBox checkBerzerkWhenFull;
        private System.Windows.Forms.CheckBox checkBerserkOnMonsterRarity;
        private System.Windows.Forms.ListView lvAvoidance;
        private System.Windows.Forms.ContextMenuStrip ctxAvoidance;
        private System.Windows.Forms.ToolStripMenuItem btnAvoid;
        private System.Windows.Forms.ToolStripMenuItem btnPrefer;
        private System.Windows.Forms.ToolStripMenuItem btnBerserk;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnNoCustomBehavior;
        private System.Windows.Forms.GroupBox groupBoxBerserk;
        private System.Windows.Forms.NumericUpDown numBerzerkMonsterAmount;
        private System.Windows.Forms.CheckBox checkBerzerkAvoidance;
        private System.Windows.Forms.CheckBox checkBerzerkMonsterAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBoxArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioWalkAround;
        private System.Windows.Forms.RadioButton radioCenter;
        private System.Windows.Forms.Button btnGetCurrent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtYCoord;
        private System.Windows.Forms.TextBox txtXCoord;
        private System.Windows.Forms.CheckBox checkBoxUseReverse;
        private System.Windows.Forms.Button buttonSelectTrainingArea;
        private System.Windows.Forms.RadioButton radioStand;
        private System.Windows.Forms.GroupBox groupBoxAdvanced;
        private System.Windows.Forms.CheckBox checkBoxDimensionPillar;
        private System.Windows.Forms.CheckBox checkAttackWeakerFirst;
        private System.Windows.Forms.LinkLabel linkAttackWeakerMobsHelp;
        private System.Windows.Forms.LinkLabel linkRecord;
    }
}
