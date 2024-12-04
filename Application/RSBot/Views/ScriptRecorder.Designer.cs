using SDUI;
using SkiaSharp;

namespace RSBot.Views
{
    partial class ScriptRecorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptRecorder));
            panel1 = new SDUI.Panel();
            btnStartStop = new SDUI.Button();
            btnSave = new SDUI.Button();
            labelStatus = new SDUI.Label();
            btnRun = new SDUI.Button();
            btnClear = new SDUI.Button();
            txtScript = new RichTextBox();
            panel2 = new SDUI.Panel();
            label1 = new SDUI.Label();
            btnAddCommand = new SDUI.Button();
            comboCommand = new SDUI.ComboBox();
            lblCommand = new SDUI.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SKColors.Transparent;
            panel1.Border = new Padding(0, 0, 0, 1);
            panel1.BorderColor = SKColors.Transparent;
            panel1.Controls.Add(btnStartStop);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(labelStatus);
            panel1.Controls.Add(btnRun);
            panel1.Controls.Add(btnClear);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(1, 32);
            panel1.Name = "panel1";
            panel1.ShadowDepth = 4F;
            panel1.Size = new System.Drawing.Size(491, 53);
            panel1.TabIndex = 0;
            // 
            // btnStartStop
            // 
            btnStartStop.BackColor = SKColors.Gold;
            btnStartStop.Color = SKColors.Navy;
            btnStartStop.ForeColor = SKColors.White;
            btnStartStop.Location = new System.Drawing.Point(13, 15);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.ShadowDepth = 4F;
            btnStartStop.Size = new System.Drawing.Size(74, 27);
            btnStartStop.TabIndex = 6;
            btnStartStop.TabStop = false;
            btnStartStop.Tag = "private";
            btnStartStop.Text = "RECORD";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStart_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Color = new SkiaSharp.SKColor(56, 155, 90);
            btnSave.ForeColor = SKColors.White;
            btnSave.Location = new System.Drawing.Point(384, 15);
            btnSave.Name = "btnSave";
            btnSave.ShadowDepth = 4F;
            btnSave.Size = new System.Drawing.Size(95, 27);
            btnSave.TabIndex = 5;
            btnSave.TabStop = false;
            btnSave.Tag = "private";
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            
            labelStatus.Location = new System.Drawing.Point(288, 19);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(47, 17);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "<Idle>";
            // 
            // btnRun
            // 
            btnRun.Color = SKColors.Transparent;
            btnRun.ForeColor = SKColors.Green;
            btnRun.Location = new System.Drawing.Point(174, 15);
            btnRun.Name = "btnRun";
            btnRun.ShadowDepth = 4F;
            btnRun.Size = new System.Drawing.Size(30, 27);
            btnRun.TabIndex = 3;
            btnRun.Text = "►";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRunNow_Click;
            // 
            // btnClear
            // 
            btnClear.Color = SKColors.RosyBrown;
            btnClear.ForeColor = SKColors.White;
            btnClear.Location = new System.Drawing.Point(93, 15);
            btnClear.Name = "btnClear";
            btnClear.ShadowDepth = 4F;
            btnClear.Size = new System.Drawing.Size(75, 27);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtScript
            // 
            txtScript.Dock = DockStyle.Fill;
            txtScript.Location = new System.Drawing.Point(1, 85);
            txtScript.Name = "txtScript";
            txtScript.Size = new System.Drawing.Size(491, 398);
            txtScript.TabIndex = 1;
            txtScript.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = SKColors.Transparent;
            panel2.Border = new Padding(0, 1, 0, 0);
            panel2.BorderColor = SKColors.Transparent;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAddCommand);
            panel2.Controls.Add(comboCommand);
            panel2.Controls.Add(lblCommand);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(1, 483);
            panel2.Name = "panel2";
            panel2.ShadowDepth = 4F;
            panel2.Size = new System.Drawing.Size(491, 77);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label1.Location = new System.Drawing.Point(20, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(351, 30);
            label1.TabIndex = 3;
            label1.Text = "&Hint: Make sure you add the \"dismount\" command to your script\r\nbefore teleportations to be able to enter it";
            // 
            // btnAddCommand
            // 
            btnAddCommand.Color = new SkiaSharp.SKColor(33, 150, 243);
            btnAddCommand.ForeColor = SKColors.White;
            btnAddCommand.Location = new System.Drawing.Point(255, 8);
            btnAddCommand.Name = "btnAddCommand";
            btnAddCommand.ShadowDepth = 4F;
            btnAddCommand.Size = new System.Drawing.Size(93, 27);
            btnAddCommand.TabIndex = 2;
            btnAddCommand.Text = "Add";
            btnAddCommand.UseVisualStyleBackColor = true;
            btnAddCommand.Click += btnAddCommand_Click;
            // 
            // comboCommand
            // 
            comboCommand.Location = new System.Drawing.Point(93, 9);
            comboCommand.Name = "comboCommand";
            comboCommand.ShadowDepth = 4F;
            comboCommand.Size = new System.Drawing.Size(156, 23);
            comboCommand.TabIndex = 1;
            // 
            // lblCommand
            // ;
            lblCommand.AutoSize = true;
            lblCommand.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblCommand.Location = new System.Drawing.Point(20, 12);
            lblCommand.Name = "lblCommand";
            lblCommand.Size = new System.Drawing.Size(67, 15);
            lblCommand.TabIndex = 0;
            lblCommand.Text = "Command:";
            // 
            // ScriptRecorder
            // 
            
            
            BackColor = new SkiaSharp.SKColor(251, 251, 251);
            Size = new System.Drawing.Size(493, 561);
            Controls.Add(txtScript);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Location = new System.Drawing.Point(0, 0);
            Name = "ScriptRecorder";
            Padding = new Padding(1, 32, 1, 1);
            Text = "RSBot - File recorder";
            Closed += ScriptRecorder_FormClosed;
            Load += ScriptRecorder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SDUI.Panel panel1;
        private RichTextBox txtScript;
        private SDUI.Button btnClear;
        private SDUI.Button btnRun;
        private SDUI.Label labelStatus;
        private SDUI.Panel panel2;
        private SDUI.Button btnAddCommand;
        private SDUI.ComboBox comboCommand;
        private SDUI.Label lblCommand;
        private SDUI.Button btnSave;
        private SDUI.Button btnStartStop;
        private SDUI.Label label1;
    }
}