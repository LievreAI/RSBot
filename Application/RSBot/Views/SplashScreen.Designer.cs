using SDUI;
using SkiaSharp;

namespace RSBot.Views
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            pictureBox = new PictureBox();
            referenceDataLoader = new System.ComponentModel.BackgroundWorker();
            logoLabel = new SDUI.Label();
            labelVersion = new SDUI.Label();
            label2 = new SDUI.Label();
            label3 = new SDUI.Label();
            lblLoading = new SDUI.Label();
            progressLoading = new SDUI.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SKColors.Transparent;
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Location = new System.Drawing.Point(0, 0);
            pictureBox.Margin = new Padding(4, 5, 4, 5);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(533, 91);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // referenceDataLoader
            // 
            referenceDataLoader.WorkerReportsProgress = true;
            referenceDataLoader.DoWork += referenceDataLoader_DoWork;
            referenceDataLoader.ProgressChanged += referenceDataLoader_ProgressChanged;
            // 
            // logoLabel
            // 
            logoLabel.BackColor = SKColors.Transparent;
            logoLabel.Dock = DockStyle.Top;
            logoLabel.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            logoLabel.Location = new System.Drawing.Point(0, 91);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new System.Drawing.Size(533, 100);
            logoLabel.TabIndex = 3;
            logoLabel.Text = "RSBOT";
            // 
            // labelVersion
            // 
            labelVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelVersion.AutoSize = true;
            labelVersion.BackColor = SKColors.Transparent;
            labelVersion.Enabled = false;
            labelVersion.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            labelVersion.Location = new System.Drawing.Point(121, 170);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new System.Drawing.Size(51, 21);
            labelVersion.TabIndex = 4;
            labelVersion.Text = "v1.0.0";
            // 
            // label2
            // 
            label2.BackColor = SKColors.Transparent;
            label2.Dock = DockStyle.Bottom;
            label2.Enabled = false;
            label2.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label2.Location = new System.Drawing.Point(0, 214);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(533, 32);
            label2.TabIndex = 5;
            label2.Text = "Free powerful bot for Silkroad Online servers";
            // 
            // label3
            // 
            label3.BackColor = SKColors.Transparent;
            label3.Dock = DockStyle.Bottom;
            label3.Enabled = false;
            label3.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label3.Location = new System.Drawing.Point(0, 246);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(533, 26);
            label3.TabIndex = 5;
            label3.Text = "Created with contributions from the community";
            // 
            // lblLoading
            // 
            lblLoading.BackColor = SKColors.Transparent;
            lblLoading.Dock = DockStyle.Top;
            lblLoading.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblLoading.Location = new System.Drawing.Point(0, 191);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new System.Drawing.Size(533, 21);
            lblLoading.TabIndex = 6;
            lblLoading.Text = "Loading";
            // 
            // progressLoading
            // 
            progressLoading.BackColor = SKColors.Transparent;
            progressLoading.Dock = DockStyle.Bottom;
            progressLoading.Location = new System.Drawing.Point(0, 272);
            progressLoading.Maximum = 100L;
            progressLoading.Name = "progressLoading";
            progressLoading.Size = new System.Drawing.Size(533, 18);
            progressLoading.TabIndex = 7;
            progressLoading.Text = "0 / 100";
            progressLoading.Value = 0L;
            // 
            // SplashScreen
            // 
            
            BorderColor = SKColors.Empty;
            Size = new System.Drawing.Size(533, 290);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(progressLoading);
            Controls.Add(lblLoading);
            Controls.Add(labelVersion);
            Controls.Add(logoLabel);
            Controls.Add(pictureBox);
            Cursor = Cursors.AppStarting;
            Location = new System.Drawing.Point(0, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SplashScreen";
            Padding = new Padding(0);
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private System.ComponentModel.BackgroundWorker referenceDataLoader;
        private SDUI.Label logoLabel;
        private SDUI.Label labelVersion;
        private SDUI.Label label2;
        private SDUI.Label label3;
        private SDUI.Label lblLoading;
        private SDUI.ProgressBar progressLoading;
    }
}