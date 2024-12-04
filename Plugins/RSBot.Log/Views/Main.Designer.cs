using SDUI;
using SkiaSharp;

namespace RSBot.Log.Views
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
            checkEnabled = new SDUI.CheckBox();
            btnReset = new SDUI.Button();
            panel1 = new SDUI.Panel();
            checkNormal = new SDUI.CheckBox();
            checkError = new SDUI.CheckBox();
            checkWarning = new SDUI.CheckBox();
            checkDebug = new SDUI.CheckBox();
            txtLog = new SDUI.RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkEnabled
            // 
            checkEnabled.AutoSize = true;
            checkEnabled.Checked = true;
            checkEnabled.CheckState = CheckState.Checked;
            checkEnabled.Location = new System.Drawing.Point(14, 8);
            checkEnabled.Name = "checkEnabled";
            checkEnabled.Ripple = true;
            checkEnabled.Size = new System.Drawing.Size(73, 30);
            checkEnabled.TabIndex = 1;
            checkEnabled.Text = "Enabled";
            checkEnabled.UseVisualStyleBackColor = true;
            checkEnabled.CheckedChanged += checkEnabled_CheckedChanged;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.Color = SKColors.Transparent;
            btnReset.Location = new System.Drawing.Point(624, 13);
            btnReset.Name = "btnReset";
            btnReset.ShadowDepth = 4F;
            btnReset.Size = new System.Drawing.Size(75, 23);
            btnReset.TabIndex = 0;
            btnReset.Text = "Clear";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panel1
            // 
            panel1.Border = new Padding(0, 0, 0, 1);
            panel1.BorderColor = SKColors.Transparent;
            panel1.Controls.Add(checkNormal);
            panel1.Controls.Add(checkError);
            panel1.Controls.Add(checkWarning);
            panel1.Controls.Add(checkDebug);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(checkEnabled);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.ShadowDepth = 0F;
            panel1.Size = new System.Drawing.Size(719, 46);
            panel1.TabIndex = 2;
            // 
            // checkNormal
            // 
            checkNormal.AutoSize = true;
            checkNormal.Checked = true;
            checkNormal.CheckState = CheckState.Checked;
            checkNormal.Location = new System.Drawing.Point(100, 8);
            checkNormal.Margin = new Padding(0);
            checkNormal.Name = "checkNormal";
            checkNormal.Ripple = true;
            checkNormal.Size = new System.Drawing.Size(70, 30);
            checkNormal.TabIndex = 6;
            checkNormal.Text = "Normal";
            checkNormal.UseVisualStyleBackColor = false;
            // 
            // checkError
            // 
            checkError.AutoSize = true;
            checkError.Checked = true;
            checkError.CheckState = CheckState.Checked;
            checkError.Location = new System.Drawing.Point(332, 8);
            checkError.Margin = new Padding(0);
            checkError.Name = "checkError";
            checkError.Ripple = true;
            checkError.Size = new System.Drawing.Size(56, 30);
            checkError.TabIndex = 3;
            checkError.Text = "Error";
            checkError.UseVisualStyleBackColor = false;
            // 
            // checkWarning
            // 
            checkWarning.AutoSize = true;
            checkWarning.Checked = true;
            checkWarning.CheckState = CheckState.Checked;
            checkWarning.Location = new System.Drawing.Point(249, 8);
            checkWarning.Margin = new Padding(0);
            checkWarning.Name = "checkWarning";
            checkWarning.Ripple = true;
            checkWarning.Size = new System.Drawing.Size(76, 30);
            checkWarning.TabIndex = 4;
            checkWarning.Text = "Warning";
            checkWarning.UseVisualStyleBackColor = false;
            // 
            // checkDebug
            // 
            checkDebug.AutoSize = true;
            checkDebug.Checked = true;
            checkDebug.CheckState = CheckState.Checked;
            checkDebug.Location = new System.Drawing.Point(175, 8);
            checkDebug.Margin = new Padding(0);
            checkDebug.Name = "checkDebug";
            checkDebug.Ripple = true;
            checkDebug.Size = new System.Drawing.Size(66, 30);
            checkDebug.TabIndex = 5;
            checkDebug.Text = "Debug";
            checkDebug.UseVisualStyleBackColor = false;
            // 
            // txtLog
            // 
            txtLog.Dock = DockStyle.Fill;
            txtLog.Location = new System.Drawing.Point(0, 46);
            txtLog.Name = "txtLog";
            txtLog.Size = new System.Drawing.Size(719, 413);
            txtLog.TabIndex = 3;
            txtLog.Text = "";
            // 
            // Main
            // 
            Controls.Add(txtLog);
            Controls.Add(panel1);
            Name = "Main";
            Size = new System.Drawing.Size(719, 459);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SDUI.Button btnReset;
        private SDUI.CheckBox checkEnabled;
        private SDUI.Panel panel1;
        private SDUI.CheckBox checkError;
        private SDUI.CheckBox checkWarning;
        private SDUI.CheckBox checkDebug;
        private SDUI.CheckBox checkNormal;
        private SDUI.RichTextBox txtLog;
    }
}
