using SDUI;
using SkiaSharp;

namespace RSBot.Default.Views
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
            ListViewGroup listViewGroup1 = new ListViewGroup("Avoid");
            ListViewGroup listViewGroup2 = new ListViewGroup("Prefer");
            ListViewGroup listViewGroup3 = new ListViewGroup("No custom behavior");
            ListViewItem listViewItem1 = new ListViewItem("General");
            ListViewItem listViewItem2 = new ListViewItem("Champion");
            ListViewItem listViewItem3 = new ListViewItem("Giant");
            ListViewItem listViewItem4 = new ListViewItem("General (party)");
            ListViewItem listViewItem5 = new ListViewItem("Champion (party)");
            ListViewItem listViewItem6 = new ListViewItem("Giant (party)");
            ListViewItem listViewItem7 = new ListViewItem("Unique");
            ListViewItem listViewItem8 = new ListViewItem("Strong");
            ListViewItem listViewItem9 = new ListViewItem("Elite");
            ListViewItem listViewItem10 = new ListViewItem("Event");
            groupBox2 = new SDUI.GroupBox();
            lvAvoidance = new SDUI.ListView();
            columnHeader1 = new ColumnHeader();
            ctxAvoidance = new SDUI.ContextMenu();
            btnAvoid = new MenuItem();
            btnPrefer = new MenuItem();
            MenuSplitterItem1 = new MenuSplitterItem();
            btnNoCustomBehavior = new MenuItem();
            groupBoxWalkback = new SDUI.GroupBox();
            linkRecord = new Label();
            checkBoxUseReverse = new SDUI.CheckBox();
            checkUseSpeedDrug = new SDUI.CheckBox();
            checkCastBuffs = new SDUI.CheckBox();
            checkUseMount = new SDUI.CheckBox();
            btnBrowse = new SDUI.Button();
            txtWalkscript = new SDUI.TextBox();
            label4 = new SDUI.Label();
            checkBerzerkWhenFull = new SDUI.CheckBox();
            groupBoxBerserk = new SDUI.GroupBox();
            label7 = new SDUI.Label();
            numBerzerkMonsterAmount = new SDUI.NumUpDown();
            checkBerzerkAvoidance = new SDUI.CheckBox();
            checkBerzerkMonsterAmount = new SDUI.CheckBox();
            groupBoxArea = new SDUI.GroupBox();
            buttonSelectTrainingArea = new SDUI.Button();
            label6 = new SDUI.Label();
            label5 = new SDUI.Label();
            radioWalkAround = new SDUI.RadioButton();
            radioCenter = new SDUI.RadioButton();
            btnGetCurrent = new SDUI.Button();
            label3 = new SDUI.Label();
            label2 = new SDUI.Label();
            label1 = new SDUI.Label();
            txtRadius = new SDUI.TextBox();
            txtYCoord = new SDUI.TextBox();
            txtXCoord = new SDUI.TextBox();
            groupBoxAdvanced = new SDUI.GroupBox();
            linkAttackWeakerMobsHelp = new Label();
            checkAttackWeakerFirst = new SDUI.CheckBox();
            checkBoxDimensionPillar = new SDUI.CheckBox();
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
            groupBox2.BackColor = SKColors.Transparent;
            groupBox2.Controls.Add(lvAvoidance);
            groupBox2.Location = new System.Drawing.Point(23, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 7, 2, 3);
            groupBox2.ShadowDepth = 4;
            groupBox2.Size = new System.Drawing.Size(221, 214);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Avoidance";
            // 
            // lvAvoidance
            // 
            lvAvoidance.BackColor = SKColors.White;
            lvAvoidance.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvAvoidance.ContextMenu = ctxAvoidance;
            lvAvoidance.Dock = DockStyle.Fill;
            lvAvoidance.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lvAvoidance.FullRowSelect = true;
            listViewGroup1.Header = "Avoid";
            listViewGroup1.Name = "grpAvoid";
            listViewGroup2.Header = "Prefer";
            listViewGroup2.Name = "grpPrefer";
            listViewGroup3.Header = "No custom behavior";
            listViewGroup3.Name = "grpNone";
            lvAvoidance.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3 });
            lvAvoidance.HeaderStyle = ColumnHeaderStyle.None;
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
            lvAvoidance.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10 });
            lvAvoidance.Location = new System.Drawing.Point(2, 23);
            lvAvoidance.Name = "lvAvoidance";
            lvAvoidance.Size = new System.Drawing.Size(217, 188);
            lvAvoidance.TabIndex = 5;
            lvAvoidance.UseCompatibleStateImageBehavior = false;
            lvAvoidance.ViewType = ViewTypes.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 190;
            // 
            // ctxAvoidance
            // 
            ctxAvoidance.Items.AddRange(new MenuItem[] { btnAvoid, btnPrefer, MenuSplitterItem1, btnNoCustomBehavior });
            ctxAvoidance.Name = "ctxAvoidance";
            ctxAvoidance.Size = new System.Drawing.Size(183, 76);
            // 
            // btnAvoid
            // 
            btnAvoid.Name = "btnAvoid";
            btnAvoid.Text = "Avoid";
            btnAvoid.Click += btnAvoid_Click;
            // 
            // btnPrefer
            // 
            btnPrefer.Name = "btnPrefer";
            btnPrefer.Text = "Prefer";
            btnPrefer.Click += btnPrefer_Click;
            // 
            // MenuSplitterItem1
            // 
            MenuSplitterItem1.Name = "MenuSplitterItem1";
            // 
            // btnNoCustomBehavior
            // 
            btnNoCustomBehavior.Name = "btnNoCustomBehavior";
            btnNoCustomBehavior.Text = "No custom behavior";
            btnNoCustomBehavior.Click += btnNoCustomBehavior_Click;
            // 
            // groupBoxWalkback
            // 
            groupBoxWalkback.BackColor = SKColors.Transparent;
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
            groupBoxWalkback.Padding = new Padding(3, 10, 3, 3);
            groupBoxWalkback.ShadowDepth = 4;
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
            linkRecord.Click += linkRecord_LinkClicked;
            // 
            // checkBoxUseReverse
            // 
            checkBoxUseReverse.AutoSize = true;
            checkBoxUseReverse.BackColor = SKColors.Transparent;
            checkBoxUseReverse.Depth = 0;
            checkBoxUseReverse.Location = new System.Drawing.Point(373, 80);
            checkBoxUseReverse.Margin = new Padding(0);
            checkBoxUseReverse.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxUseReverse.Name = "checkBoxUseReverse";
            checkBoxUseReverse.Ripple = true;
            checkBoxUseReverse.Size = new System.Drawing.Size(95, 30);
            checkBoxUseReverse.TabIndex = 7;
            checkBoxUseReverse.Text = "Use Reverse";
            checkBoxUseReverse.UseVisualStyleBackColor = false;
            checkBoxUseReverse.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseSpeedDrug
            // 
            checkUseSpeedDrug.AutoSize = true;
            checkUseSpeedDrug.BackColor = SKColors.Transparent;
            checkUseSpeedDrug.Depth = 0;
            checkUseSpeedDrug.Location = new System.Drawing.Point(258, 80);
            checkUseSpeedDrug.Margin = new Padding(0);
            checkUseSpeedDrug.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseSpeedDrug.Name = "checkUseSpeedDrug";
            checkUseSpeedDrug.Ripple = true;
            checkUseSpeedDrug.Size = new System.Drawing.Size(115, 30);
            checkUseSpeedDrug.TabIndex = 7;
            checkUseSpeedDrug.Text = "Use speed drug";
            checkUseSpeedDrug.UseVisualStyleBackColor = false;
            checkUseSpeedDrug.CheckedChanged += settings_CheckedChanged;
            // 
            // checkCastBuffs
            // 
            checkCastBuffs.AutoSize = true;
            checkCastBuffs.BackColor = SKColors.Transparent;
            checkCastBuffs.Depth = 0;
            checkCastBuffs.Location = new System.Drawing.Point(169, 80);
            checkCastBuffs.Margin = new Padding(0);
            checkCastBuffs.MouseLocation = new System.Drawing.Point(-1, -1);
            checkCastBuffs.Name = "checkCastBuffs";
            checkCastBuffs.Ripple = true;
            checkCastBuffs.Size = new System.Drawing.Size(83, 30);
            checkCastBuffs.TabIndex = 6;
            checkCastBuffs.Text = "Cast buffs";
            checkCastBuffs.UseVisualStyleBackColor = false;
            checkCastBuffs.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseMount
            // 
            checkUseMount.AutoSize = true;
            checkUseMount.BackColor = SKColors.Transparent;
            checkUseMount.Depth = 0;
            checkUseMount.Location = new System.Drawing.Point(18, 80);
            checkUseMount.Margin = new Padding(0);
            checkUseMount.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseMount.Name = "checkUseMount";
            checkUseMount.Ripple = true;
            checkUseMount.Size = new System.Drawing.Size(150, 30);
            checkUseMount.TabIndex = 3;
            checkUseMount.Text = "Use mount if available";
            checkUseMount.UseVisualStyleBackColor = false;
            checkUseMount.CheckedChanged += settings_CheckedChanged;
            // 
            // btnBrowse
            // 
            btnBrowse.Color = SKColors.Transparent;
            btnBrowse.Location = new System.Drawing.Point(406, 51);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Radius = 6;
            btnBrowse.ShadowDepth = 4F;
            btnBrowse.Size = new System.Drawing.Size(57, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtWalkscript
            // 
            txtWalkscript.BackColor = SKColors.White;
            txtWalkscript.Location = new System.Drawing.Point(21, 52);
            txtWalkscript.MaxLength = 32767;
            txtWalkscript.MultiLine = false;
            txtWalkscript.Name = "txtWalkscript";
            txtWalkscript.Size = new System.Drawing.Size(379, 21);
            txtWalkscript.TabIndex = 4;
            txtWalkscript.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.ApplyGradient = false;
            label4.AutoSize = true;
            label4.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label4.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label4.GradientAnimation = false;
            label4.Location = new System.Drawing.Point(18, 33);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Walkscript:";
            // 
            // checkBerzerkWhenFull
            // 
            checkBerzerkWhenFull.AutoSize = true;
            checkBerzerkWhenFull.BackColor = SKColors.Transparent;
            checkBerzerkWhenFull.Depth = 0;
            checkBerzerkWhenFull.Location = new System.Drawing.Point(21, 34);
            checkBerzerkWhenFull.Margin = new Padding(0);
            checkBerzerkWhenFull.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBerzerkWhenFull.Name = "checkBerzerkWhenFull";
            checkBerzerkWhenFull.Ripple = true;
            checkBerzerkWhenFull.Size = new System.Drawing.Size(190, 30);
            checkBerzerkWhenFull.TabIndex = 4;
            checkBerzerkWhenFull.Text = "Enter berzerk mode when full";
            checkBerzerkWhenFull.UseVisualStyleBackColor = false;
            checkBerzerkWhenFull.CheckedChanged += settings_CheckedChanged;
            // 
            // groupBoxBerserk
            // 
            groupBoxBerserk.BackColor = SKColors.Transparent;
            groupBoxBerserk.Controls.Add(label7);
            groupBoxBerserk.Controls.Add(numBerzerkMonsterAmount);
            groupBoxBerserk.Controls.Add(checkBerzerkAvoidance);
            groupBoxBerserk.Controls.Add(checkBerzerkMonsterAmount);
            groupBoxBerserk.Controls.Add(checkBerzerkWhenFull);
            groupBoxBerserk.Location = new System.Drawing.Point(262, 144);
            groupBoxBerserk.Name = "groupBoxBerserk";
            groupBoxBerserk.Padding = new Padding(3, 10, 3, 3);
            groupBoxBerserk.ShadowDepth = 4;
            groupBoxBerserk.Size = new System.Drawing.Size(478, 125);
            groupBoxBerserk.TabIndex = 5;
            groupBoxBerserk.TabStop = false;
            groupBoxBerserk.Text = "Berzerk";
            // 
            // label7
            // 
            label7.ApplyGradient = false;
            label7.AutoSize = true;
            label7.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label7.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label7.GradientAnimation = false;
            label7.Location = new System.Drawing.Point(300, 67);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(56, 15);
            label7.TabIndex = 7;
            label7.Text = "monsters";
            // 
            // numBerzerkMonsterAmount
            // 
            numBerzerkMonsterAmount.BackColor = SKColors.Transparent;
            numBerzerkMonsterAmount.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numBerzerkMonsterAmount.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numBerzerkMonsterAmount.Location = new System.Drawing.Point(214, 62);
            numBerzerkMonsterAmount.Maximum = 10;
            numBerzerkMonsterAmount.Minimum = 2;
            numBerzerkMonsterAmount.MinimumSize = new System.Drawing.Size(80, 25);
            numBerzerkMonsterAmount.Name = "numBerzerkMonsterAmount";
            numBerzerkMonsterAmount.Size = new System.Drawing.Size(80, 25);
            numBerzerkMonsterAmount.TabIndex = 6;
            numBerzerkMonsterAmount.Value = 5;
            numBerzerkMonsterAmount.TextChanged += numSettings_ValueChanged;
            // 
            // checkBerzerkAvoidance
            // 
            checkBerzerkAvoidance.AutoSize = true;
            checkBerzerkAvoidance.BackColor = SKColors.Transparent;
            checkBerzerkAvoidance.Depth = 0;
            checkBerzerkAvoidance.Location = new System.Drawing.Point(21, 86);
            checkBerzerkAvoidance.Margin = new Padding(0);
            checkBerzerkAvoidance.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBerzerkAvoidance.Name = "checkBerzerkAvoidance";
            checkBerzerkAvoidance.Ripple = true;
            checkBerzerkAvoidance.Size = new System.Drawing.Size(352, 30);
            checkBerzerkAvoidance.TabIndex = 5;
            checkBerzerkAvoidance.Text = "If being attacked by a monster type that should be avoided";
            checkBerzerkAvoidance.UseVisualStyleBackColor = false;
            checkBerzerkAvoidance.CheckedChanged += settings_CheckedChanged;
            // 
            // checkBerzerkMonsterAmount
            // 
            checkBerzerkMonsterAmount.AutoSize = true;
            checkBerzerkMonsterAmount.BackColor = SKColors.Transparent;
            checkBerzerkMonsterAmount.Depth = 0;
            checkBerzerkMonsterAmount.Location = new System.Drawing.Point(21, 60);
            checkBerzerkMonsterAmount.Margin = new Padding(0);
            checkBerzerkMonsterAmount.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBerzerkMonsterAmount.Name = "checkBerzerkMonsterAmount";
            checkBerzerkMonsterAmount.Ripple = true;
            checkBerzerkMonsterAmount.Size = new System.Drawing.Size(187, 30);
            checkBerzerkMonsterAmount.TabIndex = 4;
            checkBerzerkMonsterAmount.Text = "Being attacked by more than";
            checkBerzerkMonsterAmount.UseVisualStyleBackColor = false;
            checkBerzerkMonsterAmount.CheckedChanged += settings_CheckedChanged;
            // 
            // groupBoxArea
            // 
            groupBoxArea.BackColor = SKColors.Transparent;
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
            groupBoxArea.Padding = new Padding(3, 10, 3, 3);
            groupBoxArea.ShadowDepth = 4;
            groupBoxArea.Size = new System.Drawing.Size(221, 228);
            groupBoxArea.TabIndex = 0;
            groupBoxArea.TabStop = false;
            groupBoxArea.Text = "Area";
            // 
            // buttonSelectTrainingArea
            // 
            buttonSelectTrainingArea.Color = SKColors.Empty;
            buttonSelectTrainingArea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonSelectTrainingArea.Location = new System.Drawing.Point(179, 107);
            buttonSelectTrainingArea.Name = "buttonSelectTrainingArea";
            buttonSelectTrainingArea.Radius = 6;
            buttonSelectTrainingArea.ShadowDepth = 4F;
            buttonSelectTrainingArea.Size = new System.Drawing.Size(24, 24);
            buttonSelectTrainingArea.TabIndex = 7;
            buttonSelectTrainingArea.Text = "...";
            buttonSelectTrainingArea.UseVisualStyleBackColor = true;
            buttonSelectTrainingArea.Click += buttonSelectTrainingArea_Click;
            // 
            // label6
            // 
            label6.ApplyGradient = false;
            label6.AutoSize = true;
            label6.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label6.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label6.GradientAnimation = false;
            label6.Location = new System.Drawing.Point(14, 145);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(159, 15);
            label6.TabIndex = 7;
            label6.Text = "If there is no enemy nearby...";
            // 
            // label5
            // 
            label5.ApplyGradient = false;
            label5.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label5.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label5.GradientAnimation = false;
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
            radioWalkAround.Margin = new Padding(0);
            radioWalkAround.Name = "radioWalkAround";
            radioWalkAround.Ripple = true;
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
            radioCenter.Margin = new Padding(0);
            radioCenter.Name = "radioCenter";
            radioCenter.Ripple = true;
            radioCenter.Size = new System.Drawing.Size(127, 30);
            radioCenter.TabIndex = 4;
            radioCenter.Text = "Go back to center";
            radioCenter.CheckedChanged += settings_CheckedChanged;
            // 
            // btnGetCurrent
            // 
            btnGetCurrent.Color = SKColors.Transparent;
            btnGetCurrent.Location = new System.Drawing.Point(76, 107);
            btnGetCurrent.Name = "btnGetCurrent";
            btnGetCurrent.Radius = 6;
            btnGetCurrent.ShadowDepth = 4F;
            btnGetCurrent.Size = new System.Drawing.Size(97, 23);
            btnGetCurrent.TabIndex = 3;
            btnGetCurrent.Text = "Current";
            btnGetCurrent.UseVisualStyleBackColor = true;
            btnGetCurrent.Click += btnGetCurrent_Click;
            // 
            // label3
            // 
            label3.ApplyGradient = false;
            label3.AutoSize = true;
            label3.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label3.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label3.GradientAnimation = false;
            label3.Location = new System.Drawing.Point(27, 84);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 1;
            label3.Text = "Radius:";
            // 
            // label2
            // 
            label2.ApplyGradient = false;
            label2.AutoSize = true;
            label2.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label2.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label2.GradientAnimation = false;
            label2.Location = new System.Drawing.Point(53, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "Y:";
            // 
            // label1
            // 
            label1.ApplyGradient = false;
            label1.AutoSize = true;
            label1.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label1.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label1.GradientAnimation = false;
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
            txtRadius.MultiLine = false;
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
            txtYCoord.MultiLine = false;
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
            txtXCoord.MultiLine = false;
            txtXCoord.Name = "txtXCoord";
            txtXCoord.Size = new System.Drawing.Size(97, 21);
            txtXCoord.TabIndex = 0;
            txtXCoord.UseSystemPasswordChar = false;
            txtXCoord.TextChanged += txtXCoord_TextChanged;
            // 
            // groupBoxAdvanced
            // 
            groupBoxAdvanced.BackColor = SKColors.Transparent;
            groupBoxAdvanced.Controls.Add(linkAttackWeakerMobsHelp);
            groupBoxAdvanced.Controls.Add(checkAttackWeakerFirst);
            groupBoxAdvanced.Controls.Add(checkBoxDimensionPillar);
            groupBoxAdvanced.Location = new System.Drawing.Point(262, 275);
            groupBoxAdvanced.Name = "groupBoxAdvanced";
            groupBoxAdvanced.Padding = new Padding(3, 8, 3, 3);
            groupBoxAdvanced.ShadowDepth = 4;
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
            linkAttackWeakerMobsHelp.Click += linkAttackWeakerMobsHelp_LinkClicked;
            // 
            // checkAttackWeakerFirst
            // 
            checkAttackWeakerFirst.AutoSize = true;
            checkAttackWeakerFirst.BackColor = SKColors.Transparent;
            checkAttackWeakerFirst.Depth = 0;
            checkAttackWeakerFirst.Location = new System.Drawing.Point(21, 57);
            checkAttackWeakerFirst.Margin = new Padding(0);
            checkAttackWeakerFirst.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAttackWeakerFirst.Name = "checkAttackWeakerFirst";
            checkAttackWeakerFirst.Ripple = true;
            checkAttackWeakerFirst.Size = new System.Drawing.Size(267, 30);
            checkAttackWeakerFirst.TabIndex = 1;
            checkAttackWeakerFirst.Text = "If avoided: counter attack weaker mobs first";
            checkAttackWeakerFirst.UseVisualStyleBackColor = false;
            checkAttackWeakerFirst.CheckedChanged += settings_CheckedChanged;
            // 
            // checkBoxDimensionPillar
            // 
            checkBoxDimensionPillar.AutoSize = true;
            checkBoxDimensionPillar.BackColor = SKColors.Transparent;
            checkBoxDimensionPillar.Depth = 0;
            checkBoxDimensionPillar.Location = new System.Drawing.Point(21, 27);
            checkBoxDimensionPillar.Margin = new Padding(0);
            checkBoxDimensionPillar.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxDimensionPillar.Name = "checkBoxDimensionPillar";
            checkBoxDimensionPillar.Ripple = true;
            checkBoxDimensionPillar.Size = new System.Drawing.Size(157, 30);
            checkBoxDimensionPillar.TabIndex = 0;
            checkBoxDimensionPillar.Text = "Ignore Dimension Pillar";
            checkBoxDimensionPillar.UseVisualStyleBackColor = false;
            checkBoxDimensionPillar.CheckedChanged += settings_CheckedChanged;
            // 
            // Main
            // 
            
            
            Controls.Add(groupBoxAdvanced);
            Controls.Add(groupBoxWalkback);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxArea);
            Controls.Add(groupBoxBerserk);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "Main";
            Size = new System.Drawing.Size(772, 491);
            ParentChanged += Main_Load;
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
        private SDUI.GroupBox groupBox2;
        private SDUI.GroupBox groupBoxWalkback;
        private SDUI.Button btnBrowse;
        private SDUI.TextBox txtWalkscript;
        private SDUI.Label label4;
        private SDUI.CheckBox checkUseMount;
        private SDUI.CheckBox checkUseSpeedDrug;
        private SDUI.CheckBox checkCastBuffs;
        private SDUI.CheckBox checkBerzerkWhenFull;
        private SDUI.ListView lvAvoidance;
        private SDUI.ContextMenu ctxAvoidance;
        private MenuItem btnAvoid;
        private MenuItem btnPrefer;
        private MenuSplitterItem MenuSplitterItem1;
        private MenuItem btnNoCustomBehavior;
        private SDUI.GroupBox groupBoxBerserk;
        private SDUI.NumUpDown numBerzerkMonsterAmount;
        private SDUI.CheckBox checkBerzerkAvoidance;
        private SDUI.CheckBox checkBerzerkMonsterAmount;
        private SDUI.Label label7;
        private ColumnHeader columnHeader1;
        private SDUI.GroupBox groupBoxArea;
        private SDUI.Label label6;
        private SDUI.Label label5;
        private SDUI.RadioButton radioWalkAround;
        private SDUI.RadioButton radioCenter;
        private SDUI.Button btnGetCurrent;
        private SDUI.Label label3;
        private SDUI.Label label2;
        private SDUI.Label label1;
        private SDUI.TextBox txtRadius;
        private SDUI.TextBox txtYCoord;
        private SDUI.TextBox txtXCoord;
        private SDUI.CheckBox checkBoxUseReverse;
        private SDUI.Button buttonSelectTrainingArea;
        private SDUI.RadioButton radioStand;
        private SDUI.GroupBox groupBoxAdvanced;
        private SDUI.CheckBox checkBoxDimensionPillar;
        private SDUI.CheckBox checkAttackWeakerFirst;
        private Label linkAttackWeakerMobsHelp;
        private Label linkRecord;
    }
}
