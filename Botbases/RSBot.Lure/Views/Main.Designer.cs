using SDUI;
using SkiaSharp;

namespace RSBot.Lure.Views
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
            groupBox1 = new SDUI.GroupBox();
            label5 = new SDUI.Label();
            btnBrowseWalkscript = new SDUI.Button();
            txtWalkbackScript = new SDUI.TextBox();
            radioStayAtCenter = new SDUI.RadioButton();
            Splitter4 = new SDUI.Splitter();
            label7 = new SDUI.Label();
            numStayAtCenterSeconds = new SDUI.NumUpDown();
            checkStayAtCenter = new SDUI.CheckBox();
            btnBrowse = new SDUI.Button();
            radioUseScript = new SDUI.RadioButton();
            radioWalkRandomly = new SDUI.RadioButton();
            linkRecord = new Label();
            txtScriptPath = new SDUI.TextBox();
            panel1 = new SDUI.Panel();
            btnSetCenter = new SDUI.Button();
            lblX = new SDUI.Label();
            lblY = new SDUI.Label();
            numRadius = new SDUI.NumUpDown();
            label1 = new SDUI.Label();
            label3 = new SDUI.Label();
            label2 = new SDUI.Label();
            checkUseNormalAttack = new SDUI.CheckBox();
            checkUseHowlingShout = new SDUI.CheckBox();
            groupBox3 = new SDUI.GroupBox();
            label4 = new SDUI.Label();
            checkUseAttackingSkills = new SDUI.CheckBox();
            checkNoHowlingAtCenter = new SDUI.CheckBox();
            Splitter1 = new SDUI.Splitter();
            Splitter2 = new SDUI.Splitter();
            numPartyMember = new SDUI.NumUpDown();
            checkStopPartyMember = new SDUI.CheckBox();
            label6 = new SDUI.Label();
            comboMonsterType = new SDUI.ComboBox();
            numMonsterType = new SDUI.NumUpDown();
            checkStopMonsterType = new SDUI.CheckBox();
            numPartyMemberDead = new SDUI.NumUpDown();
            checkStopPartyMemberDead = new SDUI.CheckBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SKColors.Transparent;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnBrowseWalkscript);
            groupBox1.Controls.Add(txtWalkbackScript);
            groupBox1.Controls.Add(radioStayAtCenter);
            groupBox1.Controls.Add(Splitter4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numStayAtCenterSeconds);
            groupBox1.Controls.Add(checkStayAtCenter);
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(radioUseScript);
            groupBox1.Controls.Add(radioWalkRandomly);
            groupBox1.Controls.Add(linkRecord);
            groupBox1.Controls.Add(txtScriptPath);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new System.Drawing.Point(13, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 8, 3, 3);
            groupBox1.ShadowDepth = 4;
            groupBox1.Size = new System.Drawing.Size(332, 429);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Location";
            // 
            // label5
            // 
            label5.ApplyGradient = false;
            label5.AutoSize = true;
            label5.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label5.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label5.GradientAnimation = false;
            label5.Location = new System.Drawing.Point(18, 31);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 15);
            label5.TabIndex = 29;
            label5.Text = "Script to location:";
            // 
            // btnBrowseWalkscript
            // 
            btnBrowseWalkscript.Color = SKColors.Transparent;
            btnBrowseWalkscript.Location = new System.Drawing.Point(279, 52);
            btnBrowseWalkscript.Name = "btnBrowseWalkscript";
            btnBrowseWalkscript.Radius = 6;
            btnBrowseWalkscript.ShadowDepth = 4F;
            btnBrowseWalkscript.Size = new System.Drawing.Size(43, 23);
            btnBrowseWalkscript.TabIndex = 28;
            btnBrowseWalkscript.Text = "...";
            btnBrowseWalkscript.UseVisualStyleBackColor = true;
            btnBrowseWalkscript.Click += btnBrowseWalkscript_Click;
            // 
            // txtWalkbackScript
            // 
            txtWalkbackScript.Location = new System.Drawing.Point(18, 54);
            txtWalkbackScript.MaxLength = 32767;
            txtWalkbackScript.MultiLine = false;
            txtWalkbackScript.Name = "txtWalkbackScript";
            txtWalkbackScript.Size = new System.Drawing.Size(259, 21);
            txtWalkbackScript.TabIndex = 27;
            txtWalkbackScript.UseSystemPasswordChar = false;
            // 
            // radioStayAtCenter
            // 
            radioStayAtCenter.AutoSize = true;
            radioStayAtCenter.Location = new System.Drawing.Point(18, 254);
            radioStayAtCenter.Margin = new Padding(0);
            radioStayAtCenter.Name = "radioStayAtCenter";
            radioStayAtCenter.Ripple = true;
            radioStayAtCenter.Size = new System.Drawing.Size(105, 30);
            radioStayAtCenter.TabIndex = 25;
            radioStayAtCenter.Text = "Stay at center";
            radioStayAtCenter.UseVisualStyleBackColor = true;
            radioStayAtCenter.CheckedChanged += OnSettingsChanged;
            // 
            // Splitter4
            // 
            Splitter4.Location = new System.Drawing.Point(2, 348);
            Splitter4.Name = "Splitter4";
            Splitter4.Size = new System.Drawing.Size(328, 10);
            Splitter4.TabIndex = 15;
            Splitter4.Text = "Splitter4";
            // 
            // label7
            // 
            label7.ApplyGradient = false;
            label7.AutoSize = true;
            label7.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label7.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label7.GradientAnimation = false;
            label7.Location = new System.Drawing.Point(255, 374);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(58, 15);
            label7.TabIndex = 24;
            label7.Text = "second(s)";
            // 
            // numStayAtCenterSeconds
            // 
            numStayAtCenterSeconds.BackColor = SKColors.Transparent;
            numStayAtCenterSeconds.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numStayAtCenterSeconds.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numStayAtCenterSeconds.Location = new System.Drawing.Point(169, 368);
            numStayAtCenterSeconds.Maximum = 100;
            numStayAtCenterSeconds.Minimum = 1;
            numStayAtCenterSeconds.MinimumSize = new System.Drawing.Size(80, 25);
            numStayAtCenterSeconds.Name = "numStayAtCenterSeconds";
            numStayAtCenterSeconds.Size = new System.Drawing.Size(80, 25);
            numStayAtCenterSeconds.TabIndex = 23;
            numStayAtCenterSeconds.Value = 1;
            numStayAtCenterSeconds.TextChanged += OnSettingsChanged;
            // 
            // checkStayAtCenter
            // 
            checkStayAtCenter.AutoSize = true;
            checkStayAtCenter.BackColor = SKColors.Transparent;
            checkStayAtCenter.Depth = 0;
            checkStayAtCenter.Location = new System.Drawing.Point(18, 367);
            checkStayAtCenter.Margin = new Padding(0);
            checkStayAtCenter.MouseLocation = new System.Drawing.Point(-1, -1);
            checkStayAtCenter.Name = "checkStayAtCenter";
            checkStayAtCenter.Ripple = true;
            checkStayAtCenter.Size = new System.Drawing.Size(123, 30);
            checkStayAtCenter.TabIndex = 22;
            checkStayAtCenter.Text = "Stay at center for";
            checkStayAtCenter.UseVisualStyleBackColor = false;
            checkStayAtCenter.CheckedChanged += OnSettingsChanged;
            // 
            // btnBrowse
            // 
            btnBrowse.Color = SKColors.Transparent;
            btnBrowse.Location = new System.Drawing.Point(279, 315);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Radius = 6;
            btnBrowse.ShadowDepth = 4F;
            btnBrowse.Size = new System.Drawing.Size(43, 23);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // radioUseScript
            // 
            radioUseScript.AutoSize = true;
            radioUseScript.Location = new System.Drawing.Point(18, 282);
            radioUseScript.Margin = new Padding(0);
            radioUseScript.Name = "radioUseScript";
            radioUseScript.Ripple = true;
            radioUseScript.Size = new System.Drawing.Size(118, 30);
            radioUseScript.TabIndex = 2;
            radioUseScript.Text = "Use a lure script";
            radioUseScript.UseVisualStyleBackColor = true;
            radioUseScript.CheckedChanged += OnSettingsChanged;
            // 
            // radioWalkRandomly
            // 
            radioWalkRandomly.AutoSize = true;
            radioWalkRandomly.Checked = true;
            radioWalkRandomly.Location = new System.Drawing.Point(18, 226);
            radioWalkRandomly.Margin = new Padding(0);
            radioWalkRandomly.Name = "radioWalkRandomly";
            radioWalkRandomly.Ripple = true;
            radioWalkRandomly.Size = new System.Drawing.Size(113, 30);
            radioWalkRandomly.TabIndex = 1;
            radioWalkRandomly.TabStop = true;
            radioWalkRandomly.Text = "Walk randomly";
            radioWalkRandomly.UseVisualStyleBackColor = true;
            radioWalkRandomly.CheckedChanged += OnSettingsChanged;
            // 
            // linkRecord
            // 
            linkRecord.AutoSize = true;
            linkRecord.Location = new System.Drawing.Point(224, 298);
            linkRecord.Name = "linkRecord";
            linkRecord.Size = new System.Drawing.Size(52, 15);
            linkRecord.TabIndex = 5;
            linkRecord.TabStop = true;
            linkRecord.Text = "[Record]";
            linkRecord.Click += linkRecord_LinkClicked;
            // 
            // txtScriptPath
            // 
            txtScriptPath.Location = new System.Drawing.Point(18, 316);
            txtScriptPath.MaxLength = 32767;
            txtScriptPath.MultiLine = false;
            txtScriptPath.Name = "txtScriptPath";
            txtScriptPath.Size = new System.Drawing.Size(259, 21);
            txtScriptPath.TabIndex = 3;
            txtScriptPath.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.BackColor = SKColors.Transparent;
            panel1.Border = new Padding(0, 0, 0, 0);
            panel1.BorderColor = SKColors.Transparent;
            panel1.Controls.Add(btnSetCenter);
            panel1.Controls.Add(lblX);
            panel1.Controls.Add(lblY);
            panel1.Controls.Add(numRadius);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(-2, 91);
            panel1.Name = "panel1";
            panel1.ShadowDepth = 4F;
            panel1.Size = new System.Drawing.Size(336, 121);
            panel1.TabIndex = 30;
            // 
            // btnSetCenter
            // 
            btnSetCenter.Color = SKColors.Transparent;
            btnSetCenter.Location = new System.Drawing.Point(135, 84);
            btnSetCenter.Name = "btnSetCenter";
            btnSetCenter.Radius = 6;
            btnSetCenter.ShadowDepth = 4F;
            btnSetCenter.Size = new System.Drawing.Size(85, 23);
            btnSetCenter.TabIndex = 10;
            btnSetCenter.Text = "Set center";
            btnSetCenter.UseVisualStyleBackColor = true;
            btnSetCenter.Click += btnSetCenter_Click;
            // 
            // lblX
            // 
            lblX.ApplyGradient = false;
            lblX.AutoSize = true;
            lblX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblX.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblX.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            lblX.GradientAnimation = false;
            lblX.Location = new System.Drawing.Point(135, 15);
            lblX.Name = "lblX";
            lblX.Size = new System.Drawing.Size(14, 15);
            lblX.TabIndex = 12;
            lblX.Text = "0";
            // 
            // lblY
            // 
            lblY.ApplyGradient = false;
            lblY.AutoSize = true;
            lblY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblY.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblY.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            lblY.GradientAnimation = false;
            lblY.Location = new System.Drawing.Point(135, 34);
            lblY.Name = "lblY";
            lblY.Size = new System.Drawing.Size(14, 15);
            lblY.TabIndex = 11;
            lblY.Text = "0";
            // 
            // numRadius
            // 
            numRadius.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numRadius.Location = new System.Drawing.Point(135, 53);
            numRadius.Maximum = 100;
            numRadius.Minimum = 0;
            numRadius.MinimumSize = new System.Drawing.Size(80, 25);
            numRadius.Name = "numRadius";
            numRadius.Size = new System.Drawing.Size(85, 25);
            numRadius.TabIndex = 13;
            numRadius.Value = 0;
            numRadius.TextChanged += OnSettingsChanged;
            // 
            // label1
            // 
            label1.ApplyGradient = false;
            label1.AutoSize = true;
            label1.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label1.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label1.GradientAnimation = false;
            label1.Location = new System.Drawing.Point(112, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 15);
            label1.TabIndex = 9;
            label1.Text = "X:";
            // 
            // label3
            // 
            label3.ApplyGradient = false;
            label3.AutoSize = true;
            label3.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label3.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label3.GradientAnimation = false;
            label3.Location = new System.Drawing.Point(84, 59);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Radius:";
            // 
            // label2
            // 
            label2.ApplyGradient = false;
            label2.AutoSize = true;
            label2.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label2.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label2.GradientAnimation = false;
            label2.Location = new System.Drawing.Point(112, 34);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 15);
            label2.TabIndex = 8;
            label2.Text = "Y:";
            // 
            // checkUseNormalAttack
            // 
            checkUseNormalAttack.AutoSize = true;
            checkUseNormalAttack.BackColor = SKColors.Transparent;
            checkUseNormalAttack.Depth = 0;
            checkUseNormalAttack.Location = new System.Drawing.Point(26, 87);
            checkUseNormalAttack.Margin = new Padding(0);
            checkUseNormalAttack.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseNormalAttack.Name = "checkUseNormalAttack";
            checkUseNormalAttack.Ripple = true;
            checkUseNormalAttack.Size = new System.Drawing.Size(230, 30);
            checkUseNormalAttack.TabIndex = 1;
            checkUseNormalAttack.Text = "Use normal attack and switch target*";
            checkUseNormalAttack.UseVisualStyleBackColor = false;
            checkUseNormalAttack.CheckedChanged += OnSettingsChanged;
            // 
            // checkUseHowlingShout
            // 
            checkUseHowlingShout.AutoSize = true;
            checkUseHowlingShout.BackColor = SKColors.Transparent;
            checkUseHowlingShout.Depth = 0;
            checkUseHowlingShout.Location = new System.Drawing.Point(26, 36);
            checkUseHowlingShout.Margin = new Padding(0);
            checkUseHowlingShout.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseHowlingShout.Name = "checkUseHowlingShout";
            checkUseHowlingShout.Ripple = true;
            checkUseHowlingShout.Size = new System.Drawing.Size(186, 30);
            checkUseHowlingShout.TabIndex = 0;
            checkUseHowlingShout.Text = "Cast howling shout (only EU)";
            checkUseHowlingShout.UseVisualStyleBackColor = false;
            checkUseHowlingShout.CheckedChanged += OnSettingsChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SKColors.Transparent;
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(checkUseAttackingSkills);
            groupBox3.Controls.Add(checkNoHowlingAtCenter);
            groupBox3.Controls.Add(Splitter1);
            groupBox3.Controls.Add(checkUseNormalAttack);
            groupBox3.Controls.Add(checkUseHowlingShout);
            groupBox3.Controls.Add(Splitter2);
            groupBox3.Controls.Add(numPartyMember);
            groupBox3.Controls.Add(checkStopPartyMember);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(comboMonsterType);
            groupBox3.Controls.Add(numMonsterType);
            groupBox3.Controls.Add(checkStopMonsterType);
            groupBox3.Controls.Add(numPartyMemberDead);
            groupBox3.Controls.Add(checkStopPartyMemberDead);
            groupBox3.Location = new System.Drawing.Point(359, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 8, 3, 3);
            groupBox3.ShadowDepth = 4;
            groupBox3.Size = new System.Drawing.Size(391, 344);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Settings";
            // 
            // label4
            // 
            label4.ApplyGradient = false;
            label4.AutoSize = true;
            label4.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label4.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label4.GradientAnimation = false;
            label4.Location = new System.Drawing.Point(26, 315);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(304, 15);
            label4.TabIndex = 26;
            label4.Text = "* not available for scripts. Record skills in the script itself.";
            // 
            // checkUseAttackingSkills
            // 
            checkUseAttackingSkills.AutoSize = true;
            checkUseAttackingSkills.BackColor = SKColors.Transparent;
            checkUseAttackingSkills.Depth = 0;
            checkUseAttackingSkills.Location = new System.Drawing.Point(26, 113);
            checkUseAttackingSkills.Margin = new Padding(0);
            checkUseAttackingSkills.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseAttackingSkills.Name = "checkUseAttackingSkills";
            checkUseAttackingSkills.Ripple = true;
            checkUseAttackingSkills.Size = new System.Drawing.Size(230, 30);
            checkUseAttackingSkills.TabIndex = 27;
            checkUseAttackingSkills.Text = "Use attacking skill and switch target*";
            checkUseAttackingSkills.UseVisualStyleBackColor = false;
            checkUseAttackingSkills.CheckedChanged += OnSettingsChanged;
            // 
            // checkNoHowlingAtCenter
            // 
            checkNoHowlingAtCenter.AutoSize = true;
            checkNoHowlingAtCenter.BackColor = SKColors.Transparent;
            checkNoHowlingAtCenter.Depth = 0;
            checkNoHowlingAtCenter.Location = new System.Drawing.Point(45, 58);
            checkNoHowlingAtCenter.Margin = new Padding(0);
            checkNoHowlingAtCenter.MouseLocation = new System.Drawing.Point(-1, -1);
            checkNoHowlingAtCenter.Name = "checkNoHowlingAtCenter";
            checkNoHowlingAtCenter.Ripple = true;
            checkNoHowlingAtCenter.Size = new System.Drawing.Size(149, 30);
            checkNoHowlingAtCenter.TabIndex = 26;
            checkNoHowlingAtCenter.Text = "Don't cast near center";
            checkNoHowlingAtCenter.UseVisualStyleBackColor = false;
            checkNoHowlingAtCenter.CheckedChanged += OnSettingsChanged;
            // 
            // Splitter1
            // 
            Splitter1.Location = new System.Drawing.Point(0, 142);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new System.Drawing.Size(392, 10);
            Splitter1.TabIndex = 25;
            Splitter1.Text = "Splitter1";
            // 
            // Splitter2
            // 
            Splitter2.Location = new System.Drawing.Point(2, 277);
            Splitter2.Name = "Splitter2";
            Splitter2.Size = new System.Drawing.Size(392, 10);
            Splitter2.TabIndex = 21;
            Splitter2.Text = "Splitter2";
            // 
            // numPartyMember
            // 
            numPartyMember.BackColor = SKColors.Transparent;
            numPartyMember.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numPartyMember.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numPartyMember.Location = new System.Drawing.Point(225, 193);
            numPartyMember.Maximum = 8;
            numPartyMember.Minimum = 1;
            numPartyMember.MinimumSize = new System.Drawing.Size(80, 25);
            numPartyMember.Name = "numPartyMember";
            numPartyMember.Size = new System.Drawing.Size(80, 25);
            numPartyMember.TabIndex = 20;
            numPartyMember.Value = 1;
            numPartyMember.TextChanged += OnSettingsChanged;
            // 
            // checkStopPartyMember
            // 
            checkStopPartyMember.AutoSize = true;
            checkStopPartyMember.BackColor = SKColors.Transparent;
            checkStopPartyMember.Depth = 0;
            checkStopPartyMember.Location = new System.Drawing.Point(26, 191);
            checkStopPartyMember.Margin = new Padding(0);
            checkStopPartyMember.MouseLocation = new System.Drawing.Point(-1, -1);
            checkStopPartyMember.Name = "checkStopPartyMember";
            checkStopPartyMember.Ripple = true;
            checkStopPartyMember.Size = new System.Drawing.Size(189, 30);
            checkStopPartyMember.TabIndex = 19;
            checkStopPartyMember.Text = "Stop num party members <=";
            checkStopPartyMember.UseVisualStyleBackColor = false;
            checkStopPartyMember.CheckedChanged += OnSettingsChanged;
            // 
            // label6
            // 
            label6.ApplyGradient = false;
            label6.AutoSize = true;
            label6.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label6.Gradient = (new SKColor[] { SKColors.Gray, SKColors.Black });
            label6.GradientAnimation = false;
            label6.Location = new System.Drawing.Point(191, 253);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(23, 15);
            label6.TabIndex = 18;
            label6.Text = ">=";
            // 
            // comboMonsterType
            // 
            comboMonsterType.Items.AddRange(new object[] { "General (Default)", "Champion", "Giant", "General (Party)", "Champion (Party)", "Giant (Party)", "Elite", "Strong", "Unique", "Event" });
            comboMonsterType.Location = new System.Drawing.Point(45, 250);
            comboMonsterType.Name = "comboMonsterType";
            comboMonsterType.Radius = 5;
            comboMonsterType.ShadowDepth = 4F;
            comboMonsterType.Size = new System.Drawing.Size(140, 24);
            comboMonsterType.TabIndex = 17;
            comboMonsterType.SelectedIndexChanged += comboMonsterType_SelectedIndexChanged;
            // 
            // numMonsterType
            // 
            numMonsterType.BackColor = SKColors.Transparent;
            numMonsterType.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numMonsterType.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numMonsterType.Location = new System.Drawing.Point(225, 246);
            numMonsterType.Maximum = 100;
            numMonsterType.Minimum = 0;
            numMonsterType.MinimumSize = new System.Drawing.Size(80, 25);
            numMonsterType.Name = "numMonsterType";
            numMonsterType.Size = new System.Drawing.Size(80, 25);
            numMonsterType.TabIndex = 16;
            numMonsterType.Value = 0;
            numMonsterType.TextChanged += OnSettingsChanged;
            // 
            // checkStopMonsterType
            // 
            checkStopMonsterType.AutoSize = true;
            checkStopMonsterType.BackColor = SKColors.Transparent;
            checkStopMonsterType.Depth = 0;
            checkStopMonsterType.Location = new System.Drawing.Point(26, 221);
            checkStopMonsterType.Margin = new Padding(0);
            checkStopMonsterType.MouseLocation = new System.Drawing.Point(-1, -1);
            checkStopMonsterType.Name = "checkStopMonsterType";
            checkStopMonsterType.Ripple = true;
            checkStopMonsterType.Size = new System.Drawing.Size(183, 30);
            checkStopMonsterType.TabIndex = 15;
            checkStopMonsterType.Text = "Stop if num monster of type";
            checkStopMonsterType.UseVisualStyleBackColor = false;
            checkStopMonsterType.CheckedChanged += OnSettingsChanged;
            // 
            // numPartyMemberDead
            // 
            numPartyMemberDead.BackColor = SKColors.Transparent;
            numPartyMemberDead.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numPartyMemberDead.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            numPartyMemberDead.Location = new System.Drawing.Point(225, 161);
            numPartyMemberDead.Maximum = 8;
            numPartyMemberDead.Minimum = 1;
            numPartyMemberDead.MinimumSize = new System.Drawing.Size(80, 25);
            numPartyMemberDead.Name = "numPartyMemberDead";
            numPartyMemberDead.Size = new System.Drawing.Size(80, 25);
            numPartyMemberDead.TabIndex = 14;
            numPartyMemberDead.Value = 1;
            numPartyMemberDead.TextChanged += OnSettingsChanged;
            // 
            // checkStopPartyMemberDead
            // 
            checkStopPartyMemberDead.AutoSize = true;
            checkStopPartyMemberDead.BackColor = SKColors.Transparent;
            checkStopPartyMemberDead.Depth = 0;
            checkStopPartyMemberDead.Location = new System.Drawing.Point(26, 160);
            checkStopPartyMemberDead.Margin = new Padding(0);
            checkStopPartyMemberDead.MouseLocation = new System.Drawing.Point(-1, -1);
            checkStopPartyMemberDead.Name = "checkStopPartyMemberDead";
            checkStopPartyMemberDead.Ripple = true;
            checkStopPartyMemberDead.Size = new System.Drawing.Size(202, 30);
            checkStopPartyMemberDead.TabIndex = 6;
            checkStopPartyMemberDead.Text = "Stop if dead party members >=";
            checkStopPartyMemberDead.UseVisualStyleBackColor = false;
            checkStopPartyMemberDead.CheckedChanged += OnSettingsChanged;
            // 
            // Main
            // 
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Main";
            Size = new System.Drawing.Size(824, 515);
            ParentChanged += Main_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SDUI.GroupBox groupBox1;
        private SDUI.Button btnSetCenter;
        private SDUI.Label label3;
        private SDUI.Label label2;
        private SDUI.Label label1;
        private SDUI.Label lblY;
        private SDUI.Label lblX;
        private SDUI.NumUpDown numRadius;
        private SDUI.GroupBox groupBox3;
        private SDUI.Button btnBrowse;
        private SDUI.TextBox txtScriptPath;
        private SDUI.RadioButton radioUseScript;
        private SDUI.RadioButton radioWalkRandomly;
        private Label linkRecord;
        private SDUI.Label label6;
        private SDUI.ComboBox comboMonsterType;
        private SDUI.NumUpDown numMonsterType;
        private SDUI.CheckBox checkStopMonsterType;
        private SDUI.NumUpDown numPartyMemberDead;
        private SDUI.CheckBox checkStopPartyMemberDead;
        private SDUI.CheckBox checkUseNormalAttack;
        private SDUI.CheckBox checkUseHowlingShout;
        private SDUI.NumUpDown numPartyMember;
        private SDUI.CheckBox checkStopPartyMember;
        private SDUI.Label label7;
        private SDUI.NumUpDown numStayAtCenterSeconds;
        private SDUI.CheckBox checkStayAtCenter;
        private SDUI.Splitter Splitter2;
        private SDUI.Splitter Splitter1;
        private SDUI.Splitter Splitter4;
        private SDUI.RadioButton radioStayAtCenter;
        private SDUI.CheckBox checkNoHowlingAtCenter;
        private SDUI.CheckBox checkUseAttackingSkills;
        private SDUI.Label label4;
        private SDUI.Label label5;
        private SDUI.Button btnBrowseWalkscript;
        private SDUI.TextBox txtWalkbackScript;
        private SDUI.Panel panel1;
    }
}
