using SDUI;

namespace RSBot.Views.Controls
{
    partial class MiniCosControl
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
            Hp = new SDUI.ProgressBar();
            Hgp = new SDUI.ProgressBar();
            Satiety = new SDUI.ProgressBar();
            Icon = new Panel();
            Level = new Label();
            panel = new SDUI.Panel();
            Icon.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // Hp
            // 
            Hp.Dock = DockStyle.Top;
            Hp.Location = new System.Drawing.Point(3, 41);
            Hp.Maximum = 100L;
            Hp.Name = "Hp";
            Hp.Size = new System.Drawing.Size(34, 5);
            Hp.TabIndex = 1;
            Hp.Value = 55L;
            Hp.Click += OnClick_Redirector;
            // 
            // Hgp
            // 
            Hgp.Dock = DockStyle.Top;
            Hgp.Location = new System.Drawing.Point(3, 46);
            Hgp.Maximum = 100L;
            Hgp.Name = "Hgp";
            Hgp.Size = new System.Drawing.Size(34, 5);
            Hgp.TabIndex = 2;
            Hgp.Value = 55L;
            Hgp.Click += OnClick_Redirector;
            // 
            // Satiety
            // 
            Satiety.Dock = DockStyle.Top;
            Satiety.Location = new System.Drawing.Point(3, 51);
            Satiety.Maximum = 100L;
            Satiety.Name = "Satiety";
            Satiety.Size = new System.Drawing.Size(34, 5);
            Satiety.TabIndex = 3;
            Satiety.Value = 55L;
            Satiety.Click += OnClick_Redirector;
            // 
            // Icon
            // 
            Icon.Controls.Add(Level);
            Icon.Dock = DockStyle.Top;
            Icon.Location = new System.Drawing.Point(3, 3);
            Icon.Name = "Icon";
            Icon.Size = new System.Drawing.Size(34, 38);
            Icon.TabIndex = 4;
            Icon.Click += OnClick_Redirector;
            // 
            // Level
            // 
            Level.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Level.AutoSize = true;
            Level.BackColor = new SkiaSharp.SKColor(150, 0, 0, 0);
            Level.Location = new System.Drawing.Point(0, 23);
            Level.Name = "Level";
            Level.Size = new System.Drawing.Size(26, 12);
            Level.TabIndex = 0;
            Level.Text = "lv 52";
            Level.Click += OnClick_Redirector;
            // 
            // panel
            // 
            panel.Border = new Padding(1);
            panel.Controls.Add(Satiety);
            panel.Controls.Add(Hgp);
            panel.Controls.Add(Hp);
            panel.Controls.Add(Icon);
            panel.Dock = DockStyle.Fill;
            panel.Location = new System.Drawing.Point(1, 1);
            panel.Name = "panel";
            panel.Padding = new Padding(3);
            panel.ShadowDepth = 4F;
            panel.Size = new System.Drawing.Size(40, 60);
            panel.TabIndex = 1;
            panel.Click += OnClick_Redirector;
            // 
            // MiniCosControl
            // 
            Controls.Add(panel);
            Margin = new Padding(0);
            Name = "MiniCosControl";
            Padding = new Padding(1);
            Size = new System.Drawing.Size(42, 62);
            Icon.ResumeLayout(false);
            Icon.PerformLayout();
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public SDUI.ProgressBar Hp;
        public SDUI.ProgressBar Satiety;
        public SDUI.ProgressBar Hgp;
        public Label Level;
        private SDUI.Panel panel;
        public Panel Icon;
    }
}
