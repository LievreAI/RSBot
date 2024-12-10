using SDUI;

namespace RSBot.Views
{
    partial class AboutDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            pictureBox1 = new PictureBox();
            buttonOk = new SDUI.Button();
            richTextBox = new RichTextBox();
            labelName = new SDUI.Label();
            labelDescription = new SDUI.Label();
            labelVersion = new SDUI.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(129, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOk.Location = new System.Drawing.Point(12, 317);
            buttonOk.Name = "buttonOk";
            buttonOk.ShadowDepth = 4F;
            buttonOk.Size = new System.Drawing.Size(110, 32);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // richTextBox
            // 
            richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox.Location = new System.Drawing.Point(160, 57);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new System.Drawing.Size(401, 281);
            richTextBox.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.ForeColor = new SkiaSharp.SKColor(0, 0, 0);

            labelName.Location = new System.Drawing.Point(160, 8);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(61, 25);
            labelName.TabIndex = 4;
            labelName.Text = "RSBot";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            labelDescription.Location = new System.Drawing.Point(162, 33);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new System.Drawing.Size(211, 17);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "A Open source Silkroad Online bot";
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            labelVersion.Location = new System.Drawing.Point(227, 12);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new System.Drawing.Size(46, 19);
            labelVersion.TabIndex = 4;
            labelVersion.Text = "v1.0.0";
            // 
            // AboutDialog
            // 


            Size = new System.Drawing.Size(588, 361);
            Controls.Add(buttonOk);
            Controls.Add(labelDescription);
            Controls.Add(labelVersion);
            Controls.Add(labelName);
            Controls.Add(richTextBox);
            Controls.Add(pictureBox1);
            Name = "AboutDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "♣";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private SDUI.Button buttonOk;
        private RichTextBox richTextBox;
        private SDUI.Label labelName;
        private SDUI.Label labelDescription;
        private SDUI.Label labelVersion;
    }
}
