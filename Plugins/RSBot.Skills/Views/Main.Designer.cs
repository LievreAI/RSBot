using SDUI;
using SkiaSharp;

namespace RSBot.Skills.Views
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
            groupBoxAttackingSkills = new SDUI.GroupBox();
            checkUseSkillsInOrder = new SDUI.CheckBox();
            checkBoxNoAttack = new SDUI.CheckBox();
            listAttackingSkills = new SDUI.ListView();
            columnName = new ColumnHeader();
            columnLevel = new ColumnHeader();
            label2 = new SDUI.Label();
            comboMonsterType = new SDUI.ComboBox();
            btnMoveAttackSkillDown = new SDUI.Button();
            btnMoveAttackSkillUp = new SDUI.Button();
            btnRemoveAttackSkill = new SDUI.Button();
            groupBox2 = new SDUI.GroupBox();
            listBuffs = new SDUI.ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnMoveBuffSkillDown = new SDUI.Button();
            comboImbue = new SDUI.ComboBox();
            btnMoveBuffSkillUp = new SDUI.Button();
            label1 = new SDUI.Label();
            btnRemoveBuffSkill = new SDUI.Button();
            tabControl1 = new SDUI.TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupAdvancedSetup = new SDUI.GroupBox();
            comboTeleportSkill = new SDUI.ComboBox();
            checkUseTeleportSkill = new SDUI.CheckBox();
            checkUseDefaultAttack = new SDUI.CheckBox();
            checkWarlockMode = new SDUI.CheckBox();
            grpMasteryUpdate = new SDUI.GroupBox();
            checkLearnMasteryBotStopped = new SDUI.CheckBox();
            label4 = new SDUI.Label();
            numMasteryGap = new SDUI.NumUpDown();
            comboLearnMastery = new SDUI.ComboBox();
            checkLearnMastery = new SDUI.CheckBox();
            groupBoxAutomatedResurrection = new SDUI.GroupBox();
            comboResurrectionSkill = new SDUI.ComboBox();
            checkAcceptResurrection = new SDUI.CheckBox();
            label3 = new SDUI.Label();
            checkResurrectParty = new SDUI.CheckBox();
            groupBoxAdvancedBuff = new SDUI.GroupBox();
            checkCastBuffsDuringWalkBack = new SDUI.CheckBox();
            checkCastBuffsInTowns = new SDUI.CheckBox();
            tabControl2 = new SDUI.TabControl();
            tabPage3 = new TabPage();
            listSkills = new SDUI.ListView();
            colName = new ColumnHeader();
            colLevel = new ColumnHeader();
            skillContextMenu = new SDUI.ContextMenu();
            skillContextMenuAddAttackSkill = new MenuItem();
            MenuSplitterItem1 = new MenuSplitterItem();
            skillContextMenuAddBuffSkill = new MenuItem();
            MenuSplitterItem2 = new MenuSplitterItem();
            useMenuItem = new MenuItem();
            useToPartyMemberMenuItem = new MenuItem();
            panelPlayerSkills = new SDUI.Panel();
            panel2 = new SDUI.Panel();
            checkHideLowerLevelSkills = new SDUI.CheckBox();
            checkShowAttacks = new SDUI.CheckBox();
            checkShowBuffs = new SDUI.CheckBox();
            tabPage4 = new TabPage();
            listActiveBuffs = new SDUI.ListView();
            colActiveName = new ColumnHeader();
            colActiveLevel = new ColumnHeader();
            groupBoxAttackingSkills.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupAdvancedSetup.SuspendLayout();
            grpMasteryUpdate.SuspendLayout();
            groupBoxAutomatedResurrection.SuspendLayout();
            groupBoxAdvancedBuff.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            skillContextMenu.SuspendLayout();
            panelPlayerSkills.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAttackingSkills
            // 
            groupBoxAttackingSkills.BackColor = SKColors.Transparent;
            groupBoxAttackingSkills.Controls.Add(checkUseSkillsInOrder);
            groupBoxAttackingSkills.Controls.Add(checkBoxNoAttack);
            groupBoxAttackingSkills.Controls.Add(listAttackingSkills);
            groupBoxAttackingSkills.Controls.Add(label2);
            groupBoxAttackingSkills.Controls.Add(comboMonsterType);
            groupBoxAttackingSkills.Controls.Add(btnMoveAttackSkillDown);
            groupBoxAttackingSkills.Controls.Add(btnMoveAttackSkillUp);
            groupBoxAttackingSkills.Controls.Add(btnRemoveAttackSkill);
            groupBoxAttackingSkills.Location = new System.Drawing.Point(14, 5);
            groupBoxAttackingSkills.Name = "groupBoxAttackingSkills";
            groupBoxAttackingSkills.Padding = new Padding(3, 10, 3, 3);
            groupBoxAttackingSkills.ShadowDepth = 4;
            groupBoxAttackingSkills.Size = new System.Drawing.Size(357, 213);
            groupBoxAttackingSkills.TabIndex = 1;
            groupBoxAttackingSkills.TabStop = false;
            groupBoxAttackingSkills.Text = "Attacking skills";
            // 
            // checkUseSkillsInOrder
            // 
            checkUseSkillsInOrder.BackColor = SKColors.Transparent;
            checkUseSkillsInOrder.Location = new System.Drawing.Point(231, 194);
            checkUseSkillsInOrder.Margin = new Padding(0);
            checkUseSkillsInOrder.Name = "checkUseSkillsInOrder";
            checkUseSkillsInOrder.Ripple = true;
            checkUseSkillsInOrder.Size = new System.Drawing.Size(86, 15);
            checkUseSkillsInOrder.TabIndex = 10;
            checkUseSkillsInOrder.Text = "Use in order";
            checkUseSkillsInOrder.UseVisualStyleBackColor = false;
            checkUseSkillsInOrder.CheckedChanged += settings_CheckedChanged;
            // 
            // checkBoxNoAttack
            // 
            checkBoxNoAttack.BackColor = SKColors.Transparent;
            checkBoxNoAttack.Location = new System.Drawing.Point(231, 175);
            checkBoxNoAttack.Margin = new Padding(0);
            checkBoxNoAttack.Name = "checkBoxNoAttack";
            checkBoxNoAttack.Ripple = true;
            checkBoxNoAttack.Size = new System.Drawing.Size(76, 15);
            checkBoxNoAttack.TabIndex = 9;
            checkBoxNoAttack.Text = "No Attack";
            checkBoxNoAttack.UseVisualStyleBackColor = false;
            checkBoxNoAttack.CheckedChanged += settings_CheckedChanged;
            // 
            // listAttackingSkills
            // 
            listAttackingSkills.BackColor = SKColors.White;
            listAttackingSkills.Columns.AddRange(new ColumnHeader[] { columnName, columnLevel });
            listAttackingSkills.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            listAttackingSkills.FullRowSelect = true;
            listAttackingSkills.Location = new System.Drawing.Point(6, 25);
            listAttackingSkills.Name = "listAttackingSkills";
            listAttackingSkills.Size = new System.Drawing.Size(315, 146);
            listAttackingSkills.TabIndex = 8;
            listAttackingSkills.UseCompatibleStateImageBehavior = false;
            listAttackingSkills.ViewType = ViewTypes.Details;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.Width = 248;
            // 
            // columnLevel
            // 
            columnLevel.Text = "Level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label2.Location = new System.Drawing.Point(9, 183);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 15);
            label2.TabIndex = 7;
            label2.Text = "Type:";
            // 
            // comboMonsterType
            // 
            comboMonsterType.Items.AddRange(new object[] { "General (Default)", "Champion", "Giant", "General (Party)", "Champion (Party)", "Giant (Party)", "Elite", "Strong", "Unique", "Event" });
            comboMonsterType.Location = new System.Drawing.Point(54, 180);
            comboMonsterType.Name = "comboMonsterType";
            comboMonsterType.ShadowDepth = 4F;
            comboMonsterType.Size = new System.Drawing.Size(171, 23);
            comboMonsterType.TabIndex = 2;
            comboMonsterType.SelectedIndexChanged += comboMonsterType_SelectedIndexChanged;
            // 
            // btnMoveAttackSkillDown
            // 
            btnMoveAttackSkillDown.Color = SKColors.Transparent;
            btnMoveAttackSkillDown.Location = new System.Drawing.Point(327, 85);
            btnMoveAttackSkillDown.Name = "btnMoveAttackSkillDown";
            btnMoveAttackSkillDown.ShadowDepth = 4F;
            btnMoveAttackSkillDown.Size = new System.Drawing.Size(24, 24);
            btnMoveAttackSkillDown.TabIndex = 1;
            btnMoveAttackSkillDown.Text = "6";
            btnMoveAttackSkillDown.UseVisualStyleBackColor = true;
            btnMoveAttackSkillDown.Click += btnMoveAttackSkillDown_Click;
            // 
            // btnMoveAttackSkillUp
            // 
            btnMoveAttackSkillUp.Color = SKColors.Transparent;
            btnMoveAttackSkillUp.Location = new System.Drawing.Point(327, 55);
            btnMoveAttackSkillUp.Name = "btnMoveAttackSkillUp";
            btnMoveAttackSkillUp.ShadowDepth = 4F;
            btnMoveAttackSkillUp.Size = new System.Drawing.Size(24, 24);
            btnMoveAttackSkillUp.TabIndex = 1;
            btnMoveAttackSkillUp.Text = "5";
            btnMoveAttackSkillUp.UseVisualStyleBackColor = true;
            btnMoveAttackSkillUp.Click += btnMoveAttackSkillUp_Click;
            // 
            // btnRemoveAttackSkill
            // 
            btnRemoveAttackSkill.Color = SKColors.Transparent;
            btnRemoveAttackSkill.Location = new System.Drawing.Point(327, 25);
            btnRemoveAttackSkill.Name = "btnRemoveAttackSkill";
            btnRemoveAttackSkill.ShadowDepth = 4F;
            btnRemoveAttackSkill.Size = new System.Drawing.Size(24, 22);
            btnRemoveAttackSkill.TabIndex = 1;
            btnRemoveAttackSkill.Text = "r";
            btnRemoveAttackSkill.UseVisualStyleBackColor = true;
            btnRemoveAttackSkill.Click += btnRemoveAttackSkill_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SKColors.Transparent;
            groupBox2.Controls.Add(listBuffs);
            groupBox2.Controls.Add(btnMoveBuffSkillDown);
            groupBox2.Controls.Add(comboImbue);
            groupBox2.Controls.Add(btnMoveBuffSkillUp);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnRemoveBuffSkill);
            groupBox2.Location = new System.Drawing.Point(14, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 10, 3, 3);
            groupBox2.ShadowDepth = 4;
            groupBox2.Size = new System.Drawing.Size(357, 198);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buffing skills";
            // 
            // listBuffs
            // 
            listBuffs.BackColor = SKColors.White;
            listBuffs.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listBuffs.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            listBuffs.FullRowSelect = true;
            listBuffs.Location = new System.Drawing.Point(6, 27);
            listBuffs.Name = "listBuffs";
            listBuffs.Size = new System.Drawing.Size(315, 138);
            listBuffs.TabIndex = 8;
            listBuffs.UseCompatibleStateImageBehavior = false;
            listBuffs.ViewType = ViewTypes.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 248;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Level";
            // 
            // btnMoveBuffSkillDown
            // 
            btnMoveBuffSkillDown.Color = SKColors.Transparent;
            btnMoveBuffSkillDown.Location = new System.Drawing.Point(327, 87);
            btnMoveBuffSkillDown.Name = "btnMoveBuffSkillDown";
            btnMoveBuffSkillDown.ShadowDepth = 4F;
            btnMoveBuffSkillDown.Size = new System.Drawing.Size(24, 24);
            btnMoveBuffSkillDown.TabIndex = 8;
            btnMoveBuffSkillDown.Text = "6";
            btnMoveBuffSkillDown.UseVisualStyleBackColor = true;
            btnMoveBuffSkillDown.Click += btnMoveBuffSkillDown_Click;
            // 
            // comboImbue
            // 
            comboImbue.Location = new System.Drawing.Point(54, 171);
            comboImbue.Name = "comboImbue";
            comboImbue.ShadowDepth = 4F;
            comboImbue.Size = new System.Drawing.Size(267, 23);
            comboImbue.TabIndex = 7;
            comboImbue.SelectedIndexChanged += comboImbue_SelectedIndexChanged;
            // 
            // btnMoveBuffSkillUp
            // 
            btnMoveBuffSkillUp.Color = SKColors.Transparent;
            btnMoveBuffSkillUp.Location = new System.Drawing.Point(327, 57);
            btnMoveBuffSkillUp.Name = "btnMoveBuffSkillUp";
            btnMoveBuffSkillUp.ShadowDepth = 4F;
            btnMoveBuffSkillUp.Size = new System.Drawing.Size(24, 24);
            btnMoveBuffSkillUp.TabIndex = 9;
            btnMoveBuffSkillUp.Text = "5";
            btnMoveBuffSkillUp.UseVisualStyleBackColor = true;
            btnMoveBuffSkillUp.Click += btnMoveBuffSkillUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label1.Location = new System.Drawing.Point(9, 174);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Imbue:";
            // 
            // btnRemoveBuffSkill
            // 
            btnRemoveBuffSkill.Color = SKColors.Transparent;
            btnRemoveBuffSkill.Location = new System.Drawing.Point(327, 27);
            btnRemoveBuffSkill.Name = "btnRemoveBuffSkill";
            btnRemoveBuffSkill.ShadowDepth = 4F;
            btnRemoveBuffSkill.Size = new System.Drawing.Size(24, 24);
            btnRemoveBuffSkill.TabIndex = 5;
            btnRemoveBuffSkill.Text = "r";
            btnRemoveBuffSkill.UseVisualStyleBackColor = true;
            btnRemoveBuffSkill.Click += btnRemoveBuffSkill_Click;
            // 
            // tabControl1
            // 
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.Dock = DockStyle.Right;
            tabControl1.Location = new System.Drawing.Point(362, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Radius = new Padding(4);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(392, 467);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SKColors.White;
            tabPage1.Controls.Add(groupBoxAttackingSkills);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new System.Drawing.Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new System.Drawing.Size(384, 435);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General setup";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SKColors.White;
            tabPage2.Controls.Add(groupAdvancedSetup);
            tabPage2.Controls.Add(grpMasteryUpdate);
            tabPage2.Controls.Add(groupBoxAutomatedResurrection);
            tabPage2.Controls.Add(groupBoxAdvancedBuff);
            tabPage2.Location = new System.Drawing.Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new System.Drawing.Size(384, 435);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Advanced setup";
            // 
            // groupAdvancedSetup
            // 
            groupAdvancedSetup.BackColor = SKColors.Transparent;
            groupAdvancedSetup.Controls.Add(comboTeleportSkill);
            groupAdvancedSetup.Controls.Add(checkUseTeleportSkill);
            groupAdvancedSetup.Controls.Add(checkUseDefaultAttack);
            groupAdvancedSetup.Controls.Add(checkWarlockMode);
            groupAdvancedSetup.Location = new System.Drawing.Point(8, 313);
            groupAdvancedSetup.Name = "groupAdvancedSetup";
            groupAdvancedSetup.Padding = new Padding(3, 10, 3, 3);
            groupAdvancedSetup.ShadowDepth = 4;
            groupAdvancedSetup.Size = new System.Drawing.Size(367, 123);
            groupAdvancedSetup.TabIndex = 14;
            groupAdvancedSetup.TabStop = false;
            groupAdvancedSetup.Text = "Advanced setup";
            // 
            // comboTeleportSkill
            // 
            comboTeleportSkill.Location = new System.Drawing.Point(141, 88);
            comboTeleportSkill.Name = "comboTeleportSkill";
            comboTeleportSkill.ShadowDepth = 4F;
            comboTeleportSkill.Size = new System.Drawing.Size(208, 22);
            comboTeleportSkill.TabIndex = 9;
            comboTeleportSkill.SelectedIndexChanged += comboTeleportSkill_SelectedIndexChanged;
            // 
            // checkUseTeleportSkill
            // 
            checkUseTeleportSkill.AutoSize = true;
            checkUseTeleportSkill.BackColor = SKColors.Transparent;
            checkUseTeleportSkill.Location = new System.Drawing.Point(15, 84);
            checkUseTeleportSkill.Margin = new Padding(0);
            checkUseTeleportSkill.Name = "checkUseTeleportSkill";
            checkUseTeleportSkill.Ripple = true;
            checkUseTeleportSkill.Size = new System.Drawing.Size(123, 30);
            checkUseTeleportSkill.TabIndex = 2;
            checkUseTeleportSkill.Text = "Use teleport skill:";
            checkUseTeleportSkill.UseVisualStyleBackColor = false;
            checkUseTeleportSkill.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseDefaultAttack
            // 
            checkUseDefaultAttack.AutoSize = true;
            checkUseDefaultAttack.BackColor = SKColors.Transparent;
            checkUseDefaultAttack.Checked = true;
            checkUseDefaultAttack.CheckState = CheckState.Checked;
            checkUseDefaultAttack.Location = new System.Drawing.Point(15, 58);
            checkUseDefaultAttack.Margin = new Padding(0);
            checkUseDefaultAttack.Name = "checkUseDefaultAttack";
            checkUseDefaultAttack.Ripple = true;
            checkUseDefaultAttack.Size = new System.Drawing.Size(242, 30);
            checkUseDefaultAttack.TabIndex = 1;
            checkUseDefaultAttack.Text = "Use normal attack if no skill is available";
            checkUseDefaultAttack.UseVisualStyleBackColor = false;
            checkUseDefaultAttack.CheckedChanged += settings_CheckedChanged;
            // 
            // checkWarlockMode
            // 
            checkWarlockMode.AutoSize = true;
            checkWarlockMode.BackColor = SKColors.Transparent;
            checkWarlockMode.Location = new System.Drawing.Point(15, 31);
            checkWarlockMode.Margin = new Padding(0);
            checkWarlockMode.Name = "checkWarlockMode";
            checkWarlockMode.Ripple = true;
            checkWarlockMode.Size = new System.Drawing.Size(177, 30);
            checkWarlockMode.TabIndex = 0;
            checkWarlockMode.Text = "Change target after 2 DoTs";
            checkWarlockMode.UseVisualStyleBackColor = false;
            checkWarlockMode.CheckedChanged += settings_CheckedChanged;
            // 
            // grpMasteryUpdate
            // 
            grpMasteryUpdate.BackColor = SKColors.Transparent;
            grpMasteryUpdate.Controls.Add(checkLearnMasteryBotStopped);
            grpMasteryUpdate.Controls.Add(label4);
            grpMasteryUpdate.Controls.Add(numMasteryGap);
            grpMasteryUpdate.Controls.Add(comboLearnMastery);
            grpMasteryUpdate.Controls.Add(checkLearnMastery);
            grpMasteryUpdate.Location = new System.Drawing.Point(8, 218);
            grpMasteryUpdate.Name = "grpMasteryUpdate";
            grpMasteryUpdate.Padding = new Padding(3, 10, 3, 3);
            grpMasteryUpdate.ShadowDepth = 4;
            grpMasteryUpdate.Size = new System.Drawing.Size(367, 89);
            grpMasteryUpdate.TabIndex = 13;
            grpMasteryUpdate.TabStop = false;
            grpMasteryUpdate.Text = "Mastery update";
            // 
            // checkLearnMasteryBotStopped
            // 
            checkLearnMasteryBotStopped.AutoSize = true;
            checkLearnMasteryBotStopped.BackColor = SKColors.Transparent;
            checkLearnMasteryBotStopped.Location = new System.Drawing.Point(15, 56);
            checkLearnMasteryBotStopped.Margin = new Padding(0);
            checkLearnMasteryBotStopped.Name = "checkLearnMasteryBotStopped";
            checkLearnMasteryBotStopped.Ripple = true;
            checkLearnMasteryBotStopped.Size = new System.Drawing.Size(165, 30);
            checkLearnMasteryBotStopped.TabIndex = 25;
            checkLearnMasteryBotStopped.Text = "Enabled if bot is stopped";
            checkLearnMasteryBotStopped.UseVisualStyleBackColor = false;
            checkLearnMasteryBotStopped.CheckedChanged += settings_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label4.Location = new System.Drawing.Point(243, 36);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Gap";
            // 
            // numMasteryGap
            // 
            numMasteryGap.Location = new System.Drawing.Point(277, 32);
            numMasteryGap.Maximum = 9;
            numMasteryGap.Minimum = 0;
            numMasteryGap.MinimumSize = new System.Drawing.Size(80, 25);
            numMasteryGap.Name = "numMasteryGap";
            numMasteryGap.Size = new System.Drawing.Size(80, 25);
            numMasteryGap.TabIndex = 2;
            numMasteryGap.Value = 0;
            numMasteryGap.TextChanged += numSettings_ValueChanged;
            // 
            // comboLearnMastery
            // 
            comboLearnMastery.Location = new System.Drawing.Point(91, 33);
            comboLearnMastery.Name = "comboLearnMastery";
            comboLearnMastery.ShadowDepth = 4F;
            comboLearnMastery.Size = new System.Drawing.Size(141, 23);
            comboLearnMastery.TabIndex = 1;
            comboLearnMastery.SelectedIndexChanged += comboLearnMastery_SelectedIndexChanged;
            // 
            // checkLearnMastery
            // 
            checkLearnMastery.AutoSize = true;
            checkLearnMastery.BackColor = SKColors.Transparent;
            checkLearnMastery.Location = new System.Drawing.Point(15, 29);
            checkLearnMastery.Margin = new Padding(0);
            checkLearnMastery.Name = "checkLearnMastery";
            checkLearnMastery.Ripple = true;
            checkLearnMastery.Size = new System.Drawing.Size(73, 30);
            checkLearnMastery.TabIndex = 0;
            checkLearnMastery.Text = "Mastery";
            checkLearnMastery.UseVisualStyleBackColor = false;
            checkLearnMastery.CheckedChanged += settings_CheckedChanged;
            // 
            // groupBoxAutomatedResurrection
            // 
            groupBoxAutomatedResurrection.BackColor = SKColors.Transparent;
            groupBoxAutomatedResurrection.Controls.Add(comboResurrectionSkill);
            groupBoxAutomatedResurrection.Controls.Add(checkAcceptResurrection);
            groupBoxAutomatedResurrection.Controls.Add(label3);
            groupBoxAutomatedResurrection.Controls.Add(checkResurrectParty);
            groupBoxAutomatedResurrection.Location = new System.Drawing.Point(8, 6);
            groupBoxAutomatedResurrection.Name = "groupBoxAutomatedResurrection";
            groupBoxAutomatedResurrection.Padding = new Padding(3, 10, 3, 3);
            groupBoxAutomatedResurrection.ShadowDepth = 4;
            groupBoxAutomatedResurrection.Size = new System.Drawing.Size(367, 119);
            groupBoxAutomatedResurrection.TabIndex = 11;
            groupBoxAutomatedResurrection.TabStop = false;
            groupBoxAutomatedResurrection.Text = "Automated resurrection";
            // 
            // comboResurrectionSkill
            // 
            comboResurrectionSkill.Location = new System.Drawing.Point(86, 32);
            comboResurrectionSkill.Name = "comboResurrectionSkill";
            comboResurrectionSkill.ShadowDepth = 4F;
            comboResurrectionSkill.Size = new System.Drawing.Size(255, 23);
            comboResurrectionSkill.TabIndex = 8;
            comboResurrectionSkill.SelectedIndexChanged += comboResurrectionSkill_SelectedIndexChanged;
            // 
            // checkAcceptResurrection
            // 
            checkAcceptResurrection.AutoSize = true;
            checkAcceptResurrection.BackColor = SKColors.Transparent;
            checkAcceptResurrection.Checked = true;
            checkAcceptResurrection.CheckState = CheckState.Checked;
            checkAcceptResurrection.Location = new System.Drawing.Point(86, 84);
            checkAcceptResurrection.Margin = new Padding(0);
            checkAcceptResurrection.Name = "checkAcceptResurrection";
            checkAcceptResurrection.Ripple = true;
            checkAcceptResurrection.Size = new System.Drawing.Size(163, 30);
            checkAcceptResurrection.TabIndex = 9;
            checkAcceptResurrection.Text = "Auto accept resurrection";
            checkAcceptResurrection.UseVisualStyleBackColor = false;
            checkAcceptResurrection.CheckedChanged += settings_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label3.Location = new System.Drawing.Point(26, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Res. skill:";
            // 
            // checkResurrectParty
            // 
            checkResurrectParty.AutoSize = true;
            checkResurrectParty.BackColor = SKColors.Transparent;
            checkResurrectParty.Location = new System.Drawing.Point(86, 59);
            checkResurrectParty.Margin = new Padding(0);
            checkResurrectParty.Name = "checkResurrectParty";
            checkResurrectParty.Ripple = true;
            checkResurrectParty.Size = new System.Drawing.Size(193, 30);
            checkResurrectParty.TabIndex = 6;
            checkResurrectParty.Text = "Auto resurrect party members";
            checkResurrectParty.UseVisualStyleBackColor = false;
            checkResurrectParty.CheckedChanged += settings_CheckedChanged;
            // 
            // groupBoxAdvancedBuff
            // 
            groupBoxAdvancedBuff.BackColor = SKColors.Transparent;
            groupBoxAdvancedBuff.Controls.Add(checkCastBuffsDuringWalkBack);
            groupBoxAdvancedBuff.Controls.Add(checkCastBuffsInTowns);
            groupBoxAdvancedBuff.Location = new System.Drawing.Point(8, 131);
            groupBoxAdvancedBuff.Name = "groupBoxAdvancedBuff";
            groupBoxAdvancedBuff.Padding = new Padding(3, 10, 3, 3);
            groupBoxAdvancedBuff.ShadowDepth = 4;
            groupBoxAdvancedBuff.Size = new System.Drawing.Size(367, 81);
            groupBoxAdvancedBuff.TabIndex = 12;
            groupBoxAdvancedBuff.TabStop = false;
            groupBoxAdvancedBuff.Text = "Advanced buff configuration";
            // 
            // checkCastBuffsDuringWalkBack
            // 
            checkCastBuffsDuringWalkBack.AutoSize = true;
            checkCastBuffsDuringWalkBack.BackColor = SKColors.Transparent;
            checkCastBuffsDuringWalkBack.Checked = true;
            checkCastBuffsDuringWalkBack.CheckState = CheckState.Checked;
            checkCastBuffsDuringWalkBack.Location = new System.Drawing.Point(15, 48);
            checkCastBuffsDuringWalkBack.Margin = new Padding(0);
            checkCastBuffsDuringWalkBack.Name = "checkCastBuffsDuringWalkBack";
            checkCastBuffsDuringWalkBack.Ripple = true;
            checkCastBuffsDuringWalkBack.Size = new System.Drawing.Size(173, 30);
            checkCastBuffsDuringWalkBack.TabIndex = 10;
            checkCastBuffsDuringWalkBack.Text = "Cast buffs while walk-back";
            checkCastBuffsDuringWalkBack.UseVisualStyleBackColor = false;
            checkCastBuffsDuringWalkBack.CheckedChanged += settings_CheckedChanged;
            // 
            // checkCastBuffsInTowns
            // 
            checkCastBuffsInTowns.AutoSize = true;
            checkCastBuffsInTowns.BackColor = SKColors.Transparent;
            checkCastBuffsInTowns.Location = new System.Drawing.Point(15, 26);
            checkCastBuffsInTowns.Margin = new Padding(0);
            checkCastBuffsInTowns.Name = "checkCastBuffsInTowns";
            checkCastBuffsInTowns.Ripple = true;
            checkCastBuffsInTowns.Size = new System.Drawing.Size(133, 30);
            checkCastBuffsInTowns.TabIndex = 10;
            checkCastBuffsInTowns.Text = "Cast buffs in towns";
            checkCastBuffsInTowns.UseVisualStyleBackColor = false;
            checkCastBuffsInTowns.CheckedChanged += settings_CheckedChanged;
            // 
            // tabControl2
            // 
            tabControl2.TabPages.Add(tabPage3);
            tabControl2.TabPages.Add(tabPage4);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new System.Drawing.Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.Radius = new Padding(4);
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(362, 467);
            tabControl2.TabIndex = 6;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SKColors.White;
            tabPage3.Controls.Add(listSkills);
            tabPage3.Controls.Add(panelPlayerSkills);
            tabPage3.Location = new System.Drawing.Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new System.Drawing.Size(354, 435);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Player skills";
            // 
            // listSkills
            // 
            listSkills.BackColor = SKColors.White;
            listSkills.Columns.AddRange(new ColumnHeader[] { colName, colLevel });
            listSkills.ContextMenu = skillContextMenu;
            listSkills.Dock = DockStyle.Fill;
            listSkills.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            listSkills.FullRowSelect = true;
            listSkills.Location = new System.Drawing.Point(3, 3);
            listSkills.Name = "listSkills";
            listSkills.Size = new System.Drawing.Size(348, 392);
            listSkills.TabIndex = 5;
            listSkills.UseCompatibleStateImageBehavior = false;
            listSkills.ViewType = ViewTypes.Details;
            listSkills.DoubleClick += listSkills_MouseDoubleClick;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 226;
            // 
            // colLevel
            // 
            colLevel.Text = "";
            colLevel.Width = 69;
            // 
            // skillContextMenu
            // 
            skillContextMenu.Items.AddRange(new MenuItem[] { skillContextMenuAddAttackSkill, MenuSplitterItem1, skillContextMenuAddBuffSkill, MenuSplitterItem2, useMenuItem, useToPartyMemberMenuItem });
            skillContextMenu.Name = "skillContextMenu";
            skillContextMenu.Size = new System.Drawing.Size(186, 104);
            skillContextMenu.Opening += skillContextMenu_Opening;
            // 
            // skillContextMenuAddAttackSkill
            // 
            skillContextMenuAddAttackSkill.Name = "skillContextMenuAddAttackSkill";
            skillContextMenuAddAttackSkill.Text = "Add To Attacks";
            skillContextMenuAddAttackSkill.Click += menuAddAttack_Click;
            // 
            // MenuSplitterItem1
            // 
            MenuSplitterItem1.Name = "MenuSplitterItem1";
            // 
            // skillContextMenuAddBuffSkill
            // 
            skillContextMenuAddBuffSkill.Name = "skillContextMenuAddBuffSkill";
            skillContextMenuAddBuffSkill.Text = "Add To Buffs";
            skillContextMenuAddBuffSkill.Click += menuAddBuff_Click;
            // 
            // MenuSplitterItem2
            // 
            MenuSplitterItem2.Name = "MenuSplitterItem2";
            // 
            // useMenuItem
            // 
            useMenuItem.Name = "useMenuItem";
            useMenuItem.Text = "Use";
            useMenuItem.Click += useMenuItem_Click;
            // 
            // useToPartyMemberMenuItem
            // 
            useToPartyMemberMenuItem.Name = "useToPartyMemberMenuItem";
            useToPartyMemberMenuItem.Text = "Use to party member";
            // 
            // panelPlayerSkills
            // 
            panelPlayerSkills.BackColor = SKColors.Transparent;
            panelPlayerSkills.Border = new Padding(0, 1, 0, 0);
            panelPlayerSkills.BorderColor = SKColors.Transparent;
            panelPlayerSkills.Controls.Add(panel2);
            panelPlayerSkills.Controls.Add(checkHideLowerLevelSkills);
            panelPlayerSkills.Controls.Add(checkShowAttacks);
            panelPlayerSkills.Controls.Add(checkShowBuffs);
            panelPlayerSkills.Dock = DockStyle.Bottom;
            panelPlayerSkills.Location = new System.Drawing.Point(3, 395);
            panelPlayerSkills.Name = "panelPlayerSkills";
            panelPlayerSkills.ShadowDepth = 4F;
            panelPlayerSkills.Size = new System.Drawing.Size(348, 37);
            panelPlayerSkills.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = SKColors.Transparent;
            panel2.Border = new Padding(0, 0, 0, 0);
            panel2.BorderColor = SKColors.Transparent;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.ShadowDepth = 4F;
            panel2.Size = new System.Drawing.Size(348, 1);
            panel2.TabIndex = 9;
            // 
            // checkHideLowerLevelSkills
            // 
            checkHideLowerLevelSkills.AutoSize = true;
            checkHideLowerLevelSkills.BackColor = SKColors.Transparent;
            checkHideLowerLevelSkills.Location = new System.Drawing.Point(202, 6);
            checkHideLowerLevelSkills.Margin = new Padding(0);
            checkHideLowerLevelSkills.Name = "checkHideLowerLevelSkills";
            checkHideLowerLevelSkills.Ripple = true;
            checkHideLowerLevelSkills.Size = new System.Drawing.Size(146, 30);
            checkHideLowerLevelSkills.TabIndex = 6;
            checkHideLowerLevelSkills.Text = "Hide lower level skills";
            checkHideLowerLevelSkills.UseVisualStyleBackColor = false;
            checkHideLowerLevelSkills.CheckedChanged += Filter_CheckedChanged;
            // 
            // checkShowAttacks
            // 
            checkShowAttacks.AutoSize = true;
            checkShowAttacks.BackColor = SKColors.Transparent;
            checkShowAttacks.Checked = true;
            checkShowAttacks.CheckState = CheckState.Checked;
            checkShowAttacks.Location = new System.Drawing.Point(0, 6);
            checkShowAttacks.Margin = new Padding(0);
            checkShowAttacks.Name = "checkShowAttacks";
            checkShowAttacks.Ripple = true;
            checkShowAttacks.Size = new System.Drawing.Size(69, 30);
            checkShowAttacks.TabIndex = 7;
            checkShowAttacks.Text = "Attacks";
            checkShowAttacks.UseVisualStyleBackColor = false;
            checkShowAttacks.CheckedChanged += Filter_CheckedChanged;
            // 
            // checkShowBuffs
            // 
            checkShowBuffs.AutoSize = true;
            checkShowBuffs.BackColor = SKColors.Transparent;
            checkShowBuffs.Checked = true;
            checkShowBuffs.CheckState = CheckState.Checked;
            checkShowBuffs.Location = new System.Drawing.Point(83, 6);
            checkShowBuffs.Margin = new Padding(0);
            checkShowBuffs.Name = "checkShowBuffs";
            checkShowBuffs.Ripple = true;
            checkShowBuffs.Size = new System.Drawing.Size(57, 30);
            checkShowBuffs.TabIndex = 8;
            checkShowBuffs.Text = "Buffs";
            checkShowBuffs.UseVisualStyleBackColor = false;
            checkShowBuffs.CheckedChanged += Filter_CheckedChanged;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SKColors.White;
            tabPage4.Controls.Add(listActiveBuffs);
            tabPage4.Location = new System.Drawing.Point(4, 28);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new System.Drawing.Size(354, 435);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Active buffs";
            // 
            // listActiveBuffs
            // 
            listActiveBuffs.BackColor = SKColors.White;
            listActiveBuffs.Columns.AddRange(new ColumnHeader[] { colActiveName, colActiveLevel });
            listActiveBuffs.Dock = DockStyle.Fill;
            listActiveBuffs.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            listActiveBuffs.FullRowSelect = true;
            listActiveBuffs.Location = new System.Drawing.Point(3, 3);
            listActiveBuffs.Name = "listActiveBuffs";
            listActiveBuffs.Size = new System.Drawing.Size(348, 429);
            listActiveBuffs.TabIndex = 6;
            listActiveBuffs.UseCompatibleStateImageBehavior = false;
            listActiveBuffs.ViewType = ViewTypes.Details;
            listActiveBuffs.DoubleClick += listActiveBuffs_MouseDoubleClick;
            // 
            // colActiveName
            // 
            colActiveName.Text = "Name";
            colActiveName.Width = 226;
            // 
            // colActiveLevel
            // 
            colActiveLevel.Text = "";
            colActiveLevel.Width = 69;
            // 
            // Main
            // 
            
            
            Controls.Add(tabControl2);
            Controls.Add(tabControl1);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "Main";
            Size = new System.Drawing.Size(754, 467);
            ParentChanged += Main_Load;
            groupBoxAttackingSkills.ResumeLayout(false);
            groupBoxAttackingSkills.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupAdvancedSetup.ResumeLayout(false);
            groupAdvancedSetup.PerformLayout();
            grpMasteryUpdate.ResumeLayout(false);
            grpMasteryUpdate.PerformLayout();
            groupBoxAutomatedResurrection.ResumeLayout(false);
            groupBoxAutomatedResurrection.PerformLayout();
            groupBoxAdvancedBuff.ResumeLayout(false);
            groupBoxAdvancedBuff.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            skillContextMenu.ResumeLayout(false);
            panelPlayerSkills.ResumeLayout(false);
            panelPlayerSkills.PerformLayout();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SDUI.GroupBox groupBoxAttackingSkills;
        private SDUI.GroupBox groupBox2;
        private SDUI.Button btnRemoveAttackSkill;
        private SDUI.Button btnMoveAttackSkillDown;
        private SDUI.Button btnMoveAttackSkillUp;
        private SDUI.ComboBox comboImbue;
        private SDUI.Label label1;
        private SDUI.Button btnRemoveBuffSkill;
        private SDUI.Label label2;
        private SDUI.ComboBox comboMonsterType;
        private SDUI.TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private SDUI.ComboBox comboResurrectionSkill;
        private SDUI.Label label3;
        private SDUI.CheckBox checkResurrectParty;
        private SDUI.CheckBox checkAcceptResurrection;
        private SDUI.CheckBox checkCastBuffsInTowns;
        private SDUI.GroupBox groupBoxAutomatedResurrection;
        private SDUI.GroupBox groupBoxAdvancedBuff;
        private SDUI.CheckBox checkCastBuffsDuringWalkBack;
        private SDUI.TabControl tabControl2;
        private TabPage tabPage3;
        private SDUI.CheckBox checkShowAttacks;
        private SDUI.CheckBox checkShowBuffs;
        private SDUI.CheckBox checkHideLowerLevelSkills;
        private SDUI.ListView listSkills;
        private ColumnHeader colName;
        private ColumnHeader colLevel;
        private TabPage tabPage4;
        private SDUI.ListView listActiveBuffs;
        private ColumnHeader colActiveName;
        private ColumnHeader colActiveLevel;
        private SDUI.Button btnMoveBuffSkillDown;
        private SDUI.Button btnMoveBuffSkillUp;
        private SDUI.Panel panelPlayerSkills;
        private SDUI.Panel panel2;
        private SDUI.ListView listAttackingSkills;
        private ColumnHeader columnName;
        private ColumnHeader columnLevel;
        private SDUI.ListView listBuffs;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private SDUI.ContextMenu skillContextMenu;
        private SDUI.CheckBox checkBoxNoAttack;
        private MenuItem skillContextMenuAddBuffSkill;
        private MenuItem skillContextMenuAddAttackSkill;
        private MenuSplitterItem MenuSplitterItem1;
        private SDUI.GroupBox grpMasteryUpdate;
        private SDUI.Label label4;
        private SDUI.NumUpDown numMasteryGap;
        private SDUI.ComboBox comboLearnMastery;
        private SDUI.CheckBox checkLearnMastery;
        private SDUI.CheckBox checkLearnMasteryBotStopped;
        private SDUI.GroupBox groupAdvancedSetup;
        private SDUI.CheckBox checkWarlockMode;
        private MenuSplitterItem MenuSplitterItem2;
        private MenuItem useMenuItem;
        private MenuItem useToPartyMemberMenuItem;
        private SDUI.CheckBox checkUseDefaultAttack;
        private SDUI.CheckBox checkUseSkillsInOrder;
        private SDUI.ComboBox comboTeleportSkill;
        private SDUI.CheckBox checkUseTeleportSkill;
    }
}
