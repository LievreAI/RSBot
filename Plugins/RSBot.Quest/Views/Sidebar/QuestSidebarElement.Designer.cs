using SDUI;
using SkiaSharp;

namespace RSBot.Quest.Views.Sidebar
{
    partial class QuestSidebarElement
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
            lblTitle = new SDUI.Label();
            pQuests = new SDUI.Panel();
            Splitter1 = new SDUI.Splitter();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.ApplyGradient = false;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblTitle.Gradient = new SKColor[] { SKColors.Gray, SKColors.Black };
            lblTitle.GradientAnimation = false;
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(250, 30);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Questlog";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pQuests
            // 
            pQuests.AutoScroll = true;
            pQuests.BackColor = SKColors.Transparent;
            pQuests.Border = new Padding(0, 0, 0, 0);
            pQuests.BorderColor = SKColors.Transparent;
            pQuests.Dock = DockStyle.Fill;
            pQuests.Location = new System.Drawing.Point(0, 36);
            pQuests.Name = "pQuests";
            pQuests.ShadowDepth = 0F;
            pQuests.Size = new System.Drawing.Size(250, 265);
            pQuests.TabIndex = 3;
            // 
            // Splitter1
            // 
            Splitter1.Dock = DockStyle.Top;
            Splitter1.Location = new System.Drawing.Point(0, 30);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new System.Drawing.Size(250, 6);
            Splitter1.TabIndex = 4;
            Splitter1.Text = "Splitter1";
            // 
            // QuestSidebarElement
            // 
            Controls.Add(pQuests);
            Controls.Add(Splitter1);
            Controls.Add(lblTitle);
            Name = "QuestSidebarElement";
            Size = new System.Drawing.Size(250, 301);
            ResumeLayout(false);
        }

        #endregion
        private SDUI.Label lblTitle;
        private SDUI.Panel pQuests;
        private SDUI.Splitter Splitter1;
    }
}
