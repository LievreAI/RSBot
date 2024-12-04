using SDUI;

namespace RSBot.Protection.Views
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
            label22 = new SDUI.Label();
            groupBackTown = new SDUI.GroupBox();
            checkStopBotOnReturnToTown = new SDUI.CheckBox();
            label21 = new SDUI.Label();
            numDeadTimeout = new SDUI.NumUpDown();
            checkLevelUp = new SDUI.CheckBox();
            checkFullPetInventory = new SDUI.CheckBox();
            checkNoMPPotions = new SDUI.CheckBox();
            checkNoHPPotions = new SDUI.CheckBox();
            checkDurability = new SDUI.CheckBox();
            checkDead = new SDUI.CheckBox();
            checkInventory = new SDUI.CheckBox();
            checkNoArrows = new SDUI.CheckBox();
            groupBadStatus = new SDUI.GroupBox();
            label18 = new SDUI.Label();
            comboSkillBadStatus = new SDUI.ComboBox();
            checkUseBadStatusSkill = new SDUI.CheckBox();
            checkUseUniversalPills = new SDUI.CheckBox();
            groupHPMP = new SDUI.GroupBox();
            label17 = new SDUI.Label();
            comboSkillPlayerMP = new SDUI.ComboBox();
            comboSkillPlayerHP = new SDUI.ComboBox();
            label11 = new SDUI.Label();
            numPlayerSkillMPMin = new SDUI.NumUpDown();
            label12 = new SDUI.Label();
            label9 = new SDUI.Label();
            numPlayerSkillHPMin = new SDUI.NumUpDown();
            label10 = new SDUI.Label();
            label7 = new SDUI.Label();
            numPlayerMPVigorPotionMin = new SDUI.NumUpDown();
            label8 = new SDUI.Label();
            label5 = new SDUI.Label();
            numPlayerHPVigorPotionMin = new SDUI.NumUpDown();
            label6 = new SDUI.Label();
            label3 = new SDUI.Label();
            numPlayerMPPotionMin = new SDUI.NumUpDown();
            label4 = new SDUI.Label();
            label2 = new SDUI.Label();
            numPlayerHPPotionMin = new SDUI.NumUpDown();
            label1 = new SDUI.Label();
            checkUseSkillHP = new SDUI.CheckBox();
            checkUseSkillMP = new SDUI.CheckBox();
            checkUseHPPotionsPlayer = new SDUI.CheckBox();
            checkUseVigorMP = new SDUI.CheckBox();
            checkUseMPPotionsPlayer = new SDUI.CheckBox();
            checkUseVigorHP = new SDUI.CheckBox();
            groupPet = new SDUI.GroupBox();
            checkAutoSummonAttackPet = new SDUI.CheckBox();
            checkUseAbnormalStatePotion = new SDUI.CheckBox();
            checkReviveAttackPet = new SDUI.CheckBox();
            label13 = new SDUI.Label();
            numPetMinHGP = new SDUI.NumUpDown();
            label14 = new SDUI.Label();
            label15 = new SDUI.Label();
            numPetMinHP = new SDUI.NumUpDown();
            label16 = new SDUI.Label();
            checkUsePetHP = new SDUI.CheckBox();
            checkUseHGP = new SDUI.CheckBox();
            groupStatPoints = new SDUI.GroupBox();
            buttonRun = new SDUI.Button();
            checkIncBotStopped = new SDUI.CheckBox();
            numIncStr = new SDUI.NumUpDown();
            numIncInt = new SDUI.NumUpDown();
            checkIncStr = new SDUI.CheckBox();
            checkIncInt = new SDUI.CheckBox();
            groupBackTown.SuspendLayout();
            groupBadStatus.SuspendLayout();
            groupHPMP.SuspendLayout();
            groupPet.SuspendLayout();
            groupStatPoints.SuspendLayout();
            SuspendLayout();
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label22.Location = new System.Drawing.Point(500, 449);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(254, 15);
            label22.TabIndex = 16;
            label22.Text = "* Will also be executed, if the bot is not started.";
            // 
            // groupBackTown
            // 
            groupBackTown.Controls.Add(checkStopBotOnReturnToTown);
            groupBackTown.Controls.Add(label21);
            groupBackTown.Controls.Add(numDeadTimeout);
            groupBackTown.Controls.Add(checkLevelUp);
            groupBackTown.Controls.Add(checkFullPetInventory);
            groupBackTown.Controls.Add(checkNoMPPotions);
            groupBackTown.Controls.Add(checkNoHPPotions);
            groupBackTown.Controls.Add(checkDurability);
            groupBackTown.Controls.Add(checkDead);
            groupBackTown.Controls.Add(checkInventory);
            groupBackTown.Controls.Add(checkNoArrows);
            groupBackTown.Location = new System.Drawing.Point(500, 7);
            groupBackTown.Name = "groupBackTown";
            groupBackTown.ShadowDepth = 4;
            groupBackTown.Size = new System.Drawing.Size(254, 266);
            groupBackTown.TabIndex = 17;
            groupBackTown.TabStop = false;
            groupBackTown.Text = "Back to town";
            // 
            // checkStopBotOnReturnToTown
            // 
            checkStopBotOnReturnToTown.AutoSize = true;
            checkStopBotOnReturnToTown.Location = new System.Drawing.Point(12, 63);
            checkStopBotOnReturnToTown.Name = "checkStopBotOnReturnToTown";
            checkStopBotOnReturnToTown.Ripple = true;
            checkStopBotOnReturnToTown.Size = new System.Drawing.Size(183, 30);
            checkStopBotOnReturnToTown.TabIndex = 11;
            checkStopBotOnReturnToTown.Text = "Stop bot when back in town";
            checkStopBotOnReturnToTown.UseVisualStyleBackColor = false;
            checkStopBotOnReturnToTown.CheckedChanged += settings_CheckedChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label21.Location = new System.Drawing.Point(235, 41);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(17, 15);
            label21.TabIndex = 10;
            label21.Text = "/s";
            // 
            // numDeadTimeout
            // 
            numDeadTimeout.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numDeadTimeout.Location = new System.Drawing.Point(153, 37);
            numDeadTimeout.Maximum = 100;
            numDeadTimeout.Minimum = 1;
            numDeadTimeout.MinimumSize = new System.Drawing.Size(80, 25);
            numDeadTimeout.Name = "numDeadTimeout";
            numDeadTimeout.Size = new System.Drawing.Size(80, 25);
            numDeadTimeout.TabIndex = 9;
            numDeadTimeout.Value = 30;
            numDeadTimeout.TextChanged += numSettings_ValueChanged;
            // 
            // checkLevelUp
            // 
            checkLevelUp.AutoSize = true;
            checkLevelUp.Location = new System.Drawing.Point(12, 231);
            checkLevelUp.Name = "checkLevelUp";
            checkLevelUp.Ripple = true;
            checkLevelUp.Size = new System.Drawing.Size(75, 30);
            checkLevelUp.TabIndex = 8;
            checkLevelUp.Text = "Level up";
            checkLevelUp.UseVisualStyleBackColor = false;
            checkLevelUp.CheckedChanged += settings_CheckedChanged;
            // 
            // checkFullPetInventory
            // 
            checkFullPetInventory.AutoSize = true;
            checkFullPetInventory.Location = new System.Drawing.Point(12, 135);
            checkFullPetInventory.Name = "checkFullPetInventory";
            checkFullPetInventory.Ripple = true;
            checkFullPetInventory.Size = new System.Drawing.Size(124, 30);
            checkFullPetInventory.TabIndex = 7;
            checkFullPetInventory.Text = "Full pet inventory";
            checkFullPetInventory.UseVisualStyleBackColor = false;
            checkFullPetInventory.CheckedChanged += settings_CheckedChanged;
            // 
            // checkNoMPPotions
            // 
            checkNoMPPotions.AutoSize = true;
            checkNoMPPotions.Location = new System.Drawing.Point(12, 183);
            checkNoMPPotions.Name = "checkNoMPPotions";
            checkNoMPPotions.Ripple = true;
            checkNoMPPotions.Size = new System.Drawing.Size(133, 30);
            checkNoMPPotions.TabIndex = 6;
            checkNoMPPotions.Text = "No MP Potions left";
            checkNoMPPotions.UseVisualStyleBackColor = false;
            checkNoMPPotions.CheckedChanged += settings_CheckedChanged;
            // 
            // checkNoHPPotions
            // 
            checkNoHPPotions.AutoSize = true;
            checkNoHPPotions.Location = new System.Drawing.Point(12, 159);
            checkNoHPPotions.Name = "checkNoHPPotions";
            checkNoHPPotions.Ripple = true;
            checkNoHPPotions.Size = new System.Drawing.Size(130, 30);
            checkNoHPPotions.TabIndex = 5;
            checkNoHPPotions.Text = "No HP Potions left";
            checkNoHPPotions.UseVisualStyleBackColor = false;
            checkNoHPPotions.CheckedChanged += settings_CheckedChanged;
            // 
            // checkDurability
            // 
            checkDurability.AutoSize = true;
            checkDurability.Location = new System.Drawing.Point(12, 207);
            checkDurability.Name = "checkDurability";
            checkDurability.Ripple = true;
            checkDurability.Size = new System.Drawing.Size(166, 30);
            checkDurability.TabIndex = 4;
            checkDurability.Text = "Equipment durability low";
            checkDurability.UseVisualStyleBackColor = false;
            checkDurability.CheckedChanged += settings_CheckedChanged;
            // 
            // checkDead
            // 
            checkDead.AutoSize = true;
            checkDead.Location = new System.Drawing.Point(12, 36);
            checkDead.Name = "checkDead";
            checkDead.Ripple = true;
            checkDead.Size = new System.Drawing.Size(132, 30);
            checkDead.TabIndex = 3;
            checkDead.Text = "Dead with delay of ";
            checkDead.UseVisualStyleBackColor = false;
            checkDead.CheckedChanged += settings_CheckedChanged;
            // 
            // checkInventory
            // 
            checkInventory.AutoSize = true;
            checkInventory.Location = new System.Drawing.Point(12, 111);
            checkInventory.Name = "checkInventory";
            checkInventory.Ripple = true;
            checkInventory.Size = new System.Drawing.Size(103, 30);
            checkInventory.TabIndex = 4;
            checkInventory.Text = "Full inventory";
            checkInventory.UseVisualStyleBackColor = false;
            checkInventory.CheckedChanged += settings_CheckedChanged;
            // 
            // checkNoArrows
            // 
            checkNoArrows.AutoSize = true;
            checkNoArrows.Location = new System.Drawing.Point(12, 87);
            checkNoArrows.Name = "checkNoArrows";
            checkNoArrows.Ripple = true;
            checkNoArrows.Size = new System.Drawing.Size(145, 30);
            checkNoArrows.TabIndex = 4;
            checkNoArrows.Text = "No arrows / bolts left";
            checkNoArrows.UseVisualStyleBackColor = false;
            checkNoArrows.CheckedChanged += settings_CheckedChanged;
            // 
            // groupBadStatus
            // 
            groupBadStatus.Controls.Add(label18);
            groupBadStatus.Controls.Add(comboSkillBadStatus);
            groupBadStatus.Controls.Add(checkUseBadStatusSkill);
            groupBadStatus.Controls.Add(checkUseUniversalPills);
            groupBadStatus.Location = new System.Drawing.Point(15, 226);
            groupBadStatus.Name = "groupBadStatus";
            groupBadStatus.ShadowDepth = 4;
            groupBadStatus.Size = new System.Drawing.Size(468, 93);
            groupBadStatus.TabIndex = 6;
            groupBadStatus.TabStop = false;
            groupBadStatus.Text = "Bad status";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label18.Location = new System.Drawing.Point(316, 42);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(31, 15);
            label18.TabIndex = 27;
            label18.Text = "Skill:";
            // 
            // comboSkillBadStatus
            // 
            comboSkillBadStatus.Location = new System.Drawing.Point(318, 59);
            comboSkillBadStatus.Name = "comboSkillBadStatus";
            comboSkillBadStatus.ShadowDepth = 4F;
            comboSkillBadStatus.Size = new System.Drawing.Size(121, 23);
            comboSkillBadStatus.TabIndex = 26;
            comboSkillBadStatus.SelectedIndexChanged += comboSkill_SelectedIndexChanged;
            // 
            // checkUseBadStatusSkill
            // 
            checkUseBadStatusSkill.AutoSize = true;
            checkUseBadStatusSkill.Location = new System.Drawing.Point(11, 56);
            checkUseBadStatusSkill.Name = "checkUseBadStatusSkill";
            checkUseBadStatusSkill.Ripple = true;
            checkUseBadStatusSkill.Size = new System.Drawing.Size(75, 30);
            checkUseBadStatusSkill.TabIndex = 5;
            checkUseBadStatusSkill.Text = "Use Skill";
            checkUseBadStatusSkill.UseVisualStyleBackColor = false;
            checkUseBadStatusSkill.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseUniversalPills
            // 
            checkUseUniversalPills.AutoSize = true;
            checkUseUniversalPills.Location = new System.Drawing.Point(11, 29);
            checkUseUniversalPills.Name = "checkUseUniversalPills";
            checkUseUniversalPills.Ripple = true;
            checkUseUniversalPills.Size = new System.Drawing.Size(136, 30);
            checkUseUniversalPills.TabIndex = 4;
            checkUseUniversalPills.Text = "Use Universal Pills *";
            checkUseUniversalPills.UseVisualStyleBackColor = false;
            checkUseUniversalPills.CheckedChanged += settings_CheckedChanged;
            // 
            // groupHPMP
            // 
            groupHPMP.Controls.Add(label17);
            groupHPMP.Controls.Add(comboSkillPlayerMP);
            groupHPMP.Controls.Add(comboSkillPlayerHP);
            groupHPMP.Controls.Add(label11);
            groupHPMP.Controls.Add(numPlayerSkillMPMin);
            groupHPMP.Controls.Add(label12);
            groupHPMP.Controls.Add(label9);
            groupHPMP.Controls.Add(numPlayerSkillHPMin);
            groupHPMP.Controls.Add(label10);
            groupHPMP.Controls.Add(label7);
            groupHPMP.Controls.Add(numPlayerMPVigorPotionMin);
            groupHPMP.Controls.Add(label8);
            groupHPMP.Controls.Add(label5);
            groupHPMP.Controls.Add(numPlayerHPVigorPotionMin);
            groupHPMP.Controls.Add(label6);
            groupHPMP.Controls.Add(label3);
            groupHPMP.Controls.Add(numPlayerMPPotionMin);
            groupHPMP.Controls.Add(label4);
            groupHPMP.Controls.Add(label2);
            groupHPMP.Controls.Add(numPlayerHPPotionMin);
            groupHPMP.Controls.Add(label1);
            groupHPMP.Controls.Add(checkUseSkillHP);
            groupHPMP.Controls.Add(checkUseSkillMP);
            groupHPMP.Controls.Add(checkUseHPPotionsPlayer);
            groupHPMP.Controls.Add(checkUseVigorMP);
            groupHPMP.Controls.Add(checkUseMPPotionsPlayer);
            groupHPMP.Controls.Add(checkUseVigorHP);
            groupHPMP.Location = new System.Drawing.Point(15, 7);
            groupHPMP.Name = "groupHPMP";
            groupHPMP.ShadowDepth = 4;
            groupHPMP.Size = new System.Drawing.Size(468, 213);
            groupHPMP.TabIndex = 5;
            groupHPMP.TabStop = false;
            groupHPMP.Text = "Health / Mana recovery";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label17.Location = new System.Drawing.Point(332, 134);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(31, 15);
            label17.TabIndex = 26;
            label17.Text = "Skill:";
            // 
            // comboSkillPlayerMP
            // 
            comboSkillPlayerMP.Location = new System.Drawing.Point(332, 179);
            comboSkillPlayerMP.Name = "comboSkillPlayerMP";
            comboSkillPlayerMP.ShadowDepth = 4F;
            comboSkillPlayerMP.Size = new System.Drawing.Size(121, 23);
            comboSkillPlayerMP.TabIndex = 25;
            comboSkillPlayerMP.SelectedIndexChanged += comboSkill_SelectedIndexChanged;
            // 
            // comboSkillPlayerHP
            // 
            comboSkillPlayerHP.Location = new System.Drawing.Point(332, 152);
            comboSkillPlayerHP.Name = "comboSkillPlayerHP";
            comboSkillPlayerHP.ShadowDepth = 4F;
            comboSkillPlayerHP.Size = new System.Drawing.Size(121, 23);
            comboSkillPlayerHP.TabIndex = 7;
            comboSkillPlayerHP.SelectedIndexChanged += comboSkill_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label11.Location = new System.Drawing.Point(301, 183);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(17, 15);
            label11.TabIndex = 24;
            label11.Text = "%";
            // 
            // numPlayerSkillMPMin
            // 
            numPlayerSkillMPMin.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numPlayerSkillMPMin.Location = new System.Drawing.Point(220, 179);
            numPlayerSkillMPMin.Maximum = 100;
            numPlayerSkillMPMin.Minimum = 1;
            numPlayerSkillMPMin.MinimumSize = new System.Drawing.Size(80, 25);
            numPlayerSkillMPMin.Name = "numPlayerSkillMPMin";
            numPlayerSkillMPMin.Size = new System.Drawing.Size(80, 25);
            numPlayerSkillMPMin.TabIndex = 23;
            numPlayerSkillMPMin.Value = 50;
            numPlayerSkillMPMin.TextChanged += numSettings_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label12.Location = new System.Drawing.Point(201, 182);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(15, 15);
            label12.TabIndex = 22;
            label12.Text = "<";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label9.Location = new System.Drawing.Point(302, 156);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(17, 15);
            label9.TabIndex = 21;
            label9.Text = "%";
            // 
            // numPlayerSkillHPMin
            // 
             numPlayerSkillHPMin.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numPlayerSkillHPMin.Location = new System.Drawing.Point(220, 152);
            numPlayerSkillHPMin.Maximum = 100;
            numPlayerSkillHPMin.Minimum = 1;
            numPlayerSkillHPMin.MinimumSize = new System.Drawing.Size(80, 25);
            numPlayerSkillHPMin.Name = "numPlayerSkillHPMin";
            numPlayerSkillHPMin.Size = new System.Drawing.Size(80, 25);
            numPlayerSkillHPMin.TabIndex = 20;
            numPlayerSkillHPMin.Value = 50;
            numPlayerSkillHPMin.TextChanged += numSettings_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label10.Location = new System.Drawing.Point(201, 155);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(15, 15);
            label10.TabIndex = 19;
            label10.Text = "<";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label7.Location = new System.Drawing.Point(302, 123);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(17, 15);
            label7.TabIndex = 18;
            label7.Text = "%";
            // 
            // numPlayerMPVigorPotionMin
            // 
            numPlayerMPVigorPotionMin.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numPlayerMPVigorPotionMin.Location = new System.Drawing.Point(220, 118);
            numPlayerMPVigorPotionMin.Maximum = 100;
            numPlayerMPVigorPotionMin.Minimum = 1;
            numPlayerMPVigorPotionMin.MinimumSize = new System.Drawing.Size(80, 25);
            numPlayerMPVigorPotionMin.Name = "numPlayerMPVigorPotionMin";
            numPlayerMPVigorPotionMin.Size = new System.Drawing.Size(80, 25);
            numPlayerMPVigorPotionMin.TabIndex = 17;
            numPlayerMPVigorPotionMin.Value = 50;
            numPlayerMPVigorPotionMin.TextChanged += numSettings_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label8.Location = new System.Drawing.Point(201, 122);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(15, 15);
            label8.TabIndex = 16;
            label8.Text = "<";
            // 
            // label5
            //
            label5.AutoSize = true;
            label5.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label5.Location = new System.Drawing.Point(302, 96);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(17, 15);
            label5.TabIndex = 15;
            label5.Text = "%";
            // 
            // numPlayerHPVigorPotionMin
            // 
            numPlayerHPVigorPotionMin.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numPlayerHPVigorPotionMin.Location = new System.Drawing.Point(220, 91);
            numPlayerHPVigorPotionMin.Maximum = 100;
            numPlayerHPVigorPotionMin.Minimum = 1;
            numPlayerHPVigorPotionMin.MinimumSize = new System.Drawing.Size(80, 25);
            numPlayerHPVigorPotionMin.Name = "numPlayerHPVigorPotionMin";
            numPlayerHPVigorPotionMin.Size = new System.Drawing.Size(80, 25);
            numPlayerHPVigorPotionMin.TabIndex = 14;
            numPlayerHPVigorPotionMin.Value = 50;
            numPlayerHPVigorPotionMin.TextChanged += numSettings_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label6.Location = new System.Drawing.Point(201, 95);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(15, 15);
            label6.TabIndex = 13;
            label6.Text = "<";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label3.Location = new System.Drawing.Point(306, 64);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(17, 15);
            label3.TabIndex = 12;
            label3.Text = "%";
            // 
            // numPlayerMPPotionMin
            // 
            numPlayerMPPotionMin.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numPlayerMPPotionMin.Location = new System.Drawing.Point(220, 60);
            numPlayerMPPotionMin.Maximum = 100;
            numPlayerMPPotionMin.Minimum = 1;
            numPlayerMPPotionMin.MinimumSize = new System.Drawing.Size(80, 25);
            numPlayerMPPotionMin.Name = "numPlayerMPPotionMin";
            numPlayerMPPotionMin.Size = new System.Drawing.Size(80, 25);
            numPlayerMPPotionMin.TabIndex = 11;
            numPlayerMPPotionMin.Value = 50;
            numPlayerMPPotionMin.TextChanged += numSettings_ValueChanged;
            // 
            // label4"
            // 
            label4.AutoSize = true;
            label4.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label4.Location = new System.Drawing.Point(201, 64);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(15, 15);
            label4.TabIndex = 10;
            label4.Text = "<";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label2.Location = new System.Drawing.Point(306, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 15);
            label2.TabIndex = 9;
            label2.Text = "%";
            // 
            // numPlayerHPPotionMin
            // 
            numPlayerHPPotionMin.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numPlayerHPPotionMin.Location = new System.Drawing.Point(220, 33);
            numPlayerHPPotionMin.Maximum = 100;
            numPlayerHPPotionMin.Minimum = 1;
            numPlayerHPPotionMin.MinimumSize = new System.Drawing.Size(80, 25);
            numPlayerHPPotionMin.Name = "numPlayerHPPotionMin";
            numPlayerHPPotionMin.Size = new System.Drawing.Size(80, 25);
            numPlayerHPPotionMin.TabIndex = 8;
            numPlayerHPPotionMin.Value = 50;
            numPlayerHPPotionMin.TextChanged += numSettings_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label1.Location = new System.Drawing.Point(201, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(15, 15);
            label1.TabIndex = 7;
            label1.Text = "<";
            // 
            // checkUseSkillHP
            // 
            checkUseSkillHP.AutoSize = true;
            checkUseSkillHP.Location = new System.Drawing.Point(11, 149);
            checkUseSkillHP.Name = "checkUseSkillHP";
            checkUseSkillHP.Ripple = true;
            checkUseSkillHP.Size = new System.Drawing.Size(103, 30);
            checkUseSkillHP.TabIndex = 4;
            checkUseSkillHP.Text = "Use skill if HP";
            checkUseSkillHP.UseVisualStyleBackColor = false;
            checkUseSkillHP.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseSkillMP
            // 
            checkUseSkillMP.AutoSize = true;
            checkUseSkillMP.Location = new System.Drawing.Point(9, 175);
            checkUseSkillMP.Name = "checkUseSkillMP";
            checkUseSkillMP.Ripple = true;
            checkUseSkillMP.Size = new System.Drawing.Size(105, 30);
            checkUseSkillMP.TabIndex = 5;
            checkUseSkillMP.Text = "Use skill if MP";
            checkUseSkillMP.UseVisualStyleBackColor = false;
            checkUseSkillMP.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseHPPotionsPlayer
            // 
            checkUseHPPotionsPlayer.AutoSize = true;
            checkUseHPPotionsPlayer.Location = new System.Drawing.Point(11, 29);
            checkUseHPPotionsPlayer.Name = "checkUseHPPotionsPlayer";
            checkUseHPPotionsPlayer.Ripple = true;
            checkUseHPPotionsPlayer.Size = new System.Drawing.Size(151, 30);
            checkUseHPPotionsPlayer.TabIndex = 0;
            checkUseHPPotionsPlayer.Text = "Use HP potions if HP *";
            checkUseHPPotionsPlayer.UseVisualStyleBackColor = false;
            checkUseHPPotionsPlayer.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseVigorMP
            // 
            checkUseVigorMP.AutoSize = true;
            checkUseVigorMP.Location = new System.Drawing.Point(11, 113);
            checkUseVigorMP.Name = "checkUseVigorMP";
            checkUseVigorMP.Ripple = true;
            checkUseVigorMP.Size = new System.Drawing.Size(158, 30);
            checkUseVigorMP.TabIndex = 3;
            checkUseVigorMP.Text = "Use Vigor Potions if MP";
            checkUseVigorMP.UseVisualStyleBackColor = false;
            checkUseVigorMP.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseMPPotionsPlayer
            // 
            checkUseMPPotionsPlayer.AutoSize = true;
            checkUseMPPotionsPlayer.Location = new System.Drawing.Point(11, 56);
            checkUseMPPotionsPlayer.Name = "checkUseMPPotionsPlayer";
            checkUseMPPotionsPlayer.Ripple = true;
            checkUseMPPotionsPlayer.Size = new System.Drawing.Size(156, 30);
            checkUseMPPotionsPlayer.TabIndex = 1;
            checkUseMPPotionsPlayer.Text = "Use MP potions if MP *";
            checkUseMPPotionsPlayer.UseVisualStyleBackColor = false;
            checkUseMPPotionsPlayer.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseVigorHP
            // 
            checkUseVigorHP.AutoSize = true;
            checkUseVigorHP.Location = new System.Drawing.Point(11, 87);
            checkUseVigorHP.Name = "checkUseVigorHP";
            checkUseVigorHP.Ripple = true;
            checkUseVigorHP.Size = new System.Drawing.Size(156, 30);
            checkUseVigorHP.TabIndex = 2;
            checkUseVigorHP.Text = "Use Vigor Potions if HP";
            checkUseVigorHP.UseVisualStyleBackColor = false;
            checkUseVigorHP.CheckedChanged += settings_CheckedChanged;
            // 
            // groupPet
            // 
            groupPet.Controls.Add(checkAutoSummonAttackPet);
            groupPet.Controls.Add(checkUseAbnormalStatePotion);
            groupPet.Controls.Add(checkReviveAttackPet);
            groupPet.Controls.Add(label13);
            groupPet.Controls.Add(numPetMinHGP);
            groupPet.Controls.Add(label14);
            groupPet.Controls.Add(label15);
            groupPet.Controls.Add(numPetMinHP);
            groupPet.Controls.Add(label16);
            groupPet.Controls.Add(checkUsePetHP);
            groupPet.Controls.Add(checkUseHGP);
            groupPet.Location = new System.Drawing.Point(15, 325);
            groupPet.Name = "groupPet";
            groupPet.Padding = new Padding(3, 10, 3, 3);
            groupPet.ShadowDepth = 4;
            groupPet.Size = new System.Drawing.Size(468, 160);
            groupPet.TabIndex = 1;
            groupPet.TabStop = false;
            groupPet.Text = "Recovery - Pet";
            // 
            // checkAutoSummonAttackPet
            // 
            checkAutoSummonAttackPet.AutoSize = true;
            checkAutoSummonAttackPet.Location = new System.Drawing.Point(11, 129);
            checkAutoSummonAttackPet.Margin = new Padding(0);
            checkAutoSummonAttackPet.Name = "checkAutoSummonAttackPet";
            checkAutoSummonAttackPet.Ripple = true;
            checkAutoSummonAttackPet.Size = new System.Drawing.Size(215, 30);
            checkAutoSummonAttackPet.TabIndex = 27;
            checkAutoSummonAttackPet.Text = "Auto summon growth / fellow pet";
            checkAutoSummonAttackPet.UseVisualStyleBackColor = false;
            checkAutoSummonAttackPet.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseAbnormalStatePotion
            // 
            checkUseAbnormalStatePotion.AutoSize = true;
            checkUseAbnormalStatePotion.Location = new System.Drawing.Point(11, 82);
            checkUseAbnormalStatePotion.Margin = new Padding(0);
            checkUseAbnormalStatePotion.Name = "checkUseAbnormalStatePotion";
            checkUseAbnormalStatePotion.Ripple = true;
            checkUseAbnormalStatePotion.Size = new System.Drawing.Size(238, 30);
            checkUseAbnormalStatePotion.TabIndex = 26;
            checkUseAbnormalStatePotion.Text = "Use abnormal state recovery potions *";
            checkUseAbnormalStatePotion.UseVisualStyleBackColor = false;
            checkUseAbnormalStatePotion.CheckedChanged += settings_CheckedChanged;
            // 
            // checkReviveAttackPet
            // 
            checkReviveAttackPet.AutoSize = true;
            checkReviveAttackPet.Location = new System.Drawing.Point(11, 105);
            checkReviveAttackPet.Margin = new Padding(0);
            checkReviveAttackPet.Name = "checkReviveAttackPet";
            checkReviveAttackPet.Ripple = true;
            checkReviveAttackPet.Size = new System.Drawing.Size(172, 30);
            checkReviveAttackPet.TabIndex = 25;
            checkReviveAttackPet.Text = "Revive growth / fellow pet";
            checkReviveAttackPet.UseVisualStyleBackColor = false;
            checkReviveAttackPet.CheckedChanged += settings_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label13.Location = new System.Drawing.Point(353, 64);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(17, 15);
            label13.TabIndex = 20;
            label13.Text = "%";
            // 
            // numPetMinHGP
            // 
            numPetMinHGP.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numPetMinHGP.Location = new System.Drawing.Point(267, 59);
            numPetMinHGP.Maximum = 100;
            numPetMinHGP.Minimum = 1;
            numPetMinHGP.MinimumSize = new System.Drawing.Size(80, 25);
            numPetMinHGP.Name = "numPetMinHGP";
            numPetMinHGP.Size = new System.Drawing.Size(80, 25);
            numPetMinHGP.TabIndex = 19;
            numPetMinHGP.Value = 50;
            numPetMinHGP.TextChanged += numSettings_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label14.Location = new System.Drawing.Point(246, 64);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(15, 15);
            label14.TabIndex = 18;
            label14.Text = "<";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label15.Location = new System.Drawing.Point(353, 36);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(17, 15);
            label15.TabIndex = 17;
            label15.Text = "%";
            // 
            // numPetMinHP
            // 
            numPetMinHP.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numPetMinHP.Location = new System.Drawing.Point(267, 31);
            numPetMinHP.Maximum = 100;
            numPetMinHP.Minimum = 1;
            numPetMinHP.MinimumSize = new System.Drawing.Size(80, 25);
            numPetMinHP.Name = "numPetMinHP";
            numPetMinHP.Size = new System.Drawing.Size(80, 25);
            numPetMinHP.TabIndex = 16;
            numPetMinHP.Value = 50;
            numPetMinHP.TextChanged += numSettings_ValueChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label16.Location = new System.Drawing.Point(246, 37);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(15, 15);
            label16.TabIndex = 15;
            label16.Text = "<";
            // 
            // checkUsePetHP
            // 
            checkUsePetHP.AutoSize = true;
            checkUsePetHP.Location = new System.Drawing.Point(11, 30);
            checkUsePetHP.Margin = new Padding(0);
            checkUsePetHP.Name = "checkUsePetHP";
            checkUsePetHP.Ripple = true;
            checkUsePetHP.Size = new System.Drawing.Size(151, 30);
            checkUsePetHP.TabIndex = 13;
            checkUsePetHP.Text = "Use HP potions if HP *";
            checkUsePetHP.UseVisualStyleBackColor = false;
            checkUsePetHP.CheckedChanged += settings_CheckedChanged;
            // 
            // checkUseHGP
            // 
            checkUseHGP.AutoSize = true;
            checkUseHGP.Location = new System.Drawing.Point(11, 57);
            checkUseHGP.Margin = new Padding(0);
            checkUseHGP.Name = "checkUseHGP";
            checkUseHGP.Ripple = true;
            checkUseHGP.Size = new System.Drawing.Size(227, 30);
            checkUseHGP.TabIndex = 14;
            checkUseHGP.Text = "Use HGP / Saiety potions if hunger *";
            checkUseHGP.UseVisualStyleBackColor = false;
            checkUseHGP.CheckedChanged += settings_CheckedChanged;
            // 
            // groupStatPoints
            // 
            groupStatPoints.Controls.Add(buttonRun);
            groupStatPoints.Controls.Add(checkIncBotStopped);
            groupStatPoints.Controls.Add(numIncStr);
            groupStatPoints.Controls.Add(numIncInt);
            groupStatPoints.Controls.Add(checkIncStr);
            groupStatPoints.Controls.Add(checkIncInt);
            groupStatPoints.Location = new System.Drawing.Point(500, 277);
            groupStatPoints.Name = "groupStatPoints";
            groupStatPoints.Padding = new Padding(3, 10, 3, 3);
            groupStatPoints.ShadowDepth = 4;
            groupStatPoints.Size = new System.Drawing.Size(254, 169);
            groupStatPoints.TabIndex = 18;
            groupStatPoints.TabStop = false;
            groupStatPoints.Text = "Stat points";
            // 
            // buttonRun
            // 
            buttonRun.Location = new System.Drawing.Point(63, 137);
            buttonRun.Name = "buttonRun";
            buttonRun.ShadowDepth = 4F;
            buttonRun.Size = new System.Drawing.Size(97, 23);
            buttonRun.TabIndex = 27;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // checkIncBotStopped
            // 
            checkIncBotStopped.AutoSize = true;
            checkIncBotStopped.Location = new System.Drawing.Point(18, 104);
            checkIncBotStopped.Margin = new Padding(0);
            checkIncBotStopped.Name = "checkIncBotStopped";
            checkIncBotStopped.Ripple = true;
            checkIncBotStopped.Size = new System.Drawing.Size(165, 30);
            checkIncBotStopped.TabIndex = 24;
            checkIncBotStopped.Text = "Enabled if bot is stopped";
            checkIncBotStopped.UseVisualStyleBackColor = false;
            checkIncBotStopped.CheckedChanged += settings_CheckedChanged;
            // 
            // numIncStr
            // 
            numIncStr.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numIncStr.Location = new System.Drawing.Point(133, 76);
            numIncStr.Maximum = 3;
            numIncStr.Minimum = 0;
            numIncStr.MinimumSize = new System.Drawing.Size(80, 25);
            numIncStr.Name = "numIncStr";
            numIncStr.Size = new System.Drawing.Size(80, 25);
            numIncStr.TabIndex = 22;
            numIncStr.Value = 0;
            numIncStr.TextChanged += numIncStr_ValueChanged;
            // 
            // numIncInt
            // 
            numIncInt.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numIncInt.Location = new System.Drawing.Point(133, 45);
            numIncInt.Maximum = 3;
            numIncInt.Minimum = 0;
            numIncInt.MinimumSize = new System.Drawing.Size(80, 25);
            numIncInt.Name = "numIncInt";
            numIncInt.Size = new System.Drawing.Size(80, 25);
            numIncInt.TabIndex = 21;
            numIncInt.Value = 0;
            numIncInt.TextChanged += numIncInt_ValueChanged;
            // 
            // checkIncStr
            // 
            checkIncStr.AutoSize = true;
            checkIncStr.Location = new System.Drawing.Point(18, 74);
            checkIncStr.Margin = new Padding(0);
            checkIncStr.Name = "checkIncStr";
            checkIncStr.Ripple = true;
            checkIncStr.Size = new System.Drawing.Size(98, 30);
            checkIncStr.TabIndex = 20;
            checkIncStr.Text = "Increase STR";
            checkIncStr.UseVisualStyleBackColor = false;
            checkIncStr.CheckedChanged += settings_CheckedChanged;
            // 
            // checkIncInt
            // 
            checkIncInt.AutoSize = true;
            checkIncInt.Location = new System.Drawing.Point(18, 43);
            checkIncInt.Margin = new Padding(0);
            checkIncInt.Name = "checkIncInt";
            checkIncInt.Ripple = true;
            checkIncInt.Size = new System.Drawing.Size(97, 30);
            checkIncInt.TabIndex = 19;
            checkIncInt.Text = "Increase INT";
            checkIncInt.UseVisualStyleBackColor = false;
            checkIncInt.CheckedChanged += settings_CheckedChanged;
            // 
            // Main
            // 
            
            
            Controls.Add(groupStatPoints);
            Controls.Add(groupBackTown);
            Controls.Add(label22);
            Controls.Add(groupBadStatus);
            Controls.Add(groupHPMP);
            Controls.Add(groupPet);
            Name = "Main";
            Size = new System.Drawing.Size(776, 497);
            ParentChanged += Main_Load;
            groupBackTown.ResumeLayout(false);
            groupBackTown.PerformLayout();
            groupBadStatus.ResumeLayout(false);
            groupBadStatus.PerformLayout();
            groupHPMP.ResumeLayout(false);
            groupHPMP.PerformLayout();
            groupPet.ResumeLayout(false);
            groupPet.PerformLayout();
            groupStatPoints.ResumeLayout(false);
            groupStatPoints.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SDUI.GroupBox groupPet;
        private SDUI.CheckBox checkUseUniversalPills;
        private SDUI.GroupBox groupHPMP;
        private SDUI.CheckBox checkUseHPPotionsPlayer;
        private SDUI.CheckBox checkUseVigorMP;
        private SDUI.CheckBox checkUseMPPotionsPlayer;
        private SDUI.CheckBox checkUseVigorHP;
        private SDUI.GroupBox groupBadStatus;
        private SDUI.CheckBox checkUseSkillHP;
        private SDUI.CheckBox checkUseSkillMP;
        private SDUI.Label label11;
        private SDUI.NumUpDown numPlayerSkillMPMin;
        private SDUI.Label label12;
        private SDUI.Label label9;
        private SDUI.NumUpDown numPlayerSkillHPMin;
        private SDUI.Label label10;
        private SDUI.Label label7;
        private SDUI.NumUpDown numPlayerMPVigorPotionMin;
        private SDUI.Label label8;
        private SDUI.Label label5;
        private SDUI.NumUpDown numPlayerHPVigorPotionMin;
        private SDUI.Label label6;
        private SDUI.Label label3;
        private SDUI.NumUpDown numPlayerMPPotionMin;
        private SDUI.Label label4;
        private SDUI.Label label2;
        private SDUI.NumUpDown numPlayerHPPotionMin;
        private SDUI.Label label1;
        private SDUI.CheckBox checkUseBadStatusSkill;
        private SDUI.ComboBox comboSkillPlayerMP;
        private SDUI.ComboBox comboSkillPlayerHP;
        private SDUI.ComboBox comboSkillBadStatus;
        private SDUI.Label label13;
        private SDUI.NumUpDown numPetMinHGP;
        private SDUI.Label label14;
        private SDUI.Label label15;
        private SDUI.NumUpDown numPetMinHP;
        private SDUI.Label label16;
        private SDUI.CheckBox checkUsePetHP;
        private SDUI.CheckBox checkUseHGP;
        private SDUI.Label label18;
        private SDUI.CheckBox checkUseAbnormalStatePotion;
        private SDUI.CheckBox checkReviveAttackPet;
        private SDUI.Label label19;
        private SDUI.NumUpDown numMountMinHP;
        private SDUI.Label label20;
        private SDUI.CheckBox checkUseMountHP;
        private SDUI.Label label22;
        private SDUI.CheckBox checkAutoSummonAttackPet;
        private SDUI.GroupBox groupBackTown;
        private SDUI.Label label21;
        private SDUI.NumUpDown numDeadTimeout;
        private SDUI.CheckBox checkLevelUp;
        private SDUI.CheckBox checkFullPetInventory;
        private SDUI.CheckBox checkNoMPPotions;
        private SDUI.CheckBox checkNoHPPotions;
        private SDUI.CheckBox checkDurability;
        private SDUI.CheckBox checkDead;
        private SDUI.CheckBox checkInventory;
        private SDUI.CheckBox checkNoArrows;
        private SDUI.GroupBox groupStatPoints;
        private SDUI.NumUpDown numIncStr;
        private SDUI.NumUpDown numIncInt;
        private SDUI.CheckBox checkIncStr;
        private SDUI.CheckBox checkIncInt;
        private SDUI.CheckBox checkIncBotStopped;
        private SDUI.Button buttonRun;
        private SDUI.CheckBox checkStopBotOnReturnToTown;
        private SDUI.Label label17;
    }
}
