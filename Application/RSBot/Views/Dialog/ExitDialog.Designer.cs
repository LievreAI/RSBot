using SDUI;

namespace RSBot.Views
{
    partial class ExitDialog
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
            labelInfo = new SDUI.Label();
            panel1 = new SDUI.Panel();
            btnNo = new SDUI.Button();
            btnYes = new SDUI.Button();
            checkDontAskAgain = new SDUI.CheckBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            labelInfo.Location = new System.Drawing.Point(160, 26);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new System.Drawing.Size(265, 45);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "Are you sure that you want to exit RSBot?\r\nThis will disconnect you from the Silkroad Server!\r\n\r\n";
            // 
            // panel1
            // 
            panel1.Border = new Padding(0, 1, 0, 0);
            panel1.Controls.Add(btnNo);
            panel1.Controls.Add(btnYes);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 129);
            panel1.Name = "panel1";
            panel1.ShadowDepth = 0F;
            panel1.Size = new System.Drawing.Size(441, 49);
            panel1.TabIndex = 1;
            // 
            // btnNo
            // 
            btnNo.DialogResult = DialogResult.No;
            btnNo.Location = new System.Drawing.Point(349, 14);
            btnNo.Name = "btnNo";
            btnNo.ShadowDepth = 4F;
            btnNo.Size = new System.Drawing.Size(75, 23);
            btnNo.TabIndex = 1;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            btnYes.DialogResult = DialogResult.Yes;
            btnYes.Location = new System.Drawing.Point(268, 14);
            btnYes.Name = "btnYes";
            btnYes.ShadowDepth = 4F;
            btnYes.Size = new System.Drawing.Size(75, 23);
            btnYes.TabIndex = 0;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            // 
            // checkDontAskAgain
            // 
            checkDontAskAgain.AutoSize = true;
            checkDontAskAgain.Location = new System.Drawing.Point(9, 139);
            checkDontAskAgain.Margin = new Padding(0);
            checkDontAskAgain.Name = "checkDontAskAgain";
            checkDontAskAgain.Ripple = true;
            checkDontAskAgain.Size = new System.Drawing.Size(114, 30);
            checkDontAskAgain.TabIndex = 2;
            checkDontAskAgain.Text = "Don't ask again";
            checkDontAskAgain.UseVisualStyleBackColor = false;
            checkDontAskAgain.CheckedChanged += checkDontAskAgain_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(15, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(111, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ExitDialog
            // 
            Size = new System.Drawing.Size(441, 178);
            Controls.Add(labelInfo);
            Controls.Add(checkDontAskAgain);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "ExitDialog";
            StartPosition = FormStartPosition.CenterParent;
            Load += ExitDialog_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SDUI.Label labelInfo;
        private SDUI.Panel panel1;
        private PictureBox pictureBox1;
        private SDUI.Button btnNo;
        private SDUI.Button btnYes;
        private SDUI.CheckBox checkDontAskAgain;
    }
}