using SDUI;

namespace RSBot.Views.Controls.Cos
{
    partial class CosController
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
            Splitter = new SDUI.Splitter();
            panel = new Panel();
            topPanel = new Panel();
            panelTopCenter = new Panel();
            panelTopRight = new Panel();
            buttonNext = new SDUI.Button();
            panelTopLeft = new Panel();
            buttonPrev = new SDUI.Button();
            Splitter1 = new SDUI.Splitter();
            topPanel.SuspendLayout();
            panelTopRight.SuspendLayout();
            panelTopLeft.SuspendLayout();
            SuspendLayout();
            // 
            // Splitter
            // 
            Splitter.Dock = DockStyle.Bottom;
            Splitter.Location = new System.Drawing.Point(3, 95);
            Splitter.Name = "Splitter";
            Splitter.Size = new System.Drawing.Size(242, 4);
            Splitter.TabIndex = 2;
            // 
            // panel
            // 
            panel.Dock = DockStyle.Fill;
            panel.Location = new System.Drawing.Point(3, 63);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(242, 32);
            panel.TabIndex = 3;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(panelTopCenter);
            topPanel.Controls.Add(panelTopRight);
            topPanel.Controls.Add(panelTopLeft);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(3, 3);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(242, 56);
            topPanel.TabIndex = 4;
            // 
            // panelTopCenter
            // 
            panelTopCenter.Dock = DockStyle.Fill;
            panelTopCenter.Location = new System.Drawing.Point(23, 0);
            panelTopCenter.Name = "panelTopCenter";
            panelTopCenter.Size = new System.Drawing.Size(196, 56);
            panelTopCenter.TabIndex = 6;
            // 
            // panelTopRight
            // 
            panelTopRight.Controls.Add(buttonNext);
            panelTopRight.Dock = DockStyle.Right;
            panelTopRight.Location = new System.Drawing.Point(219, 0);
            panelTopRight.Name = "panelTopRight";
            panelTopRight.Size = new System.Drawing.Size(23, 56);
            panelTopRight.TabIndex = 5;
            // 
            // buttonNext
            // 
            buttonNext.Dock = DockStyle.Fill;
             buttonNext.Location = new System.Drawing.Point(0, 0);
            buttonNext.Name = "buttonNext";
            buttonNext.ShadowDepth = 4F;
            buttonNext.Size = new System.Drawing.Size(23, 56);
            buttonNext.TabIndex = 1;
            buttonNext.Text = "4";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Visible = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // panelTopLeft
            // 
            panelTopLeft.Controls.Add(buttonPrev);
            panelTopLeft.Dock = DockStyle.Left;
            panelTopLeft.Location = new System.Drawing.Point(0, 0);
            panelTopLeft.Name = "panelTopLeft";
            panelTopLeft.Size = new System.Drawing.Size(23, 56);
            panelTopLeft.TabIndex = 4;
            // 
            // buttonPrev
            // 
            buttonPrev.Dock = DockStyle.Fill;
            buttonPrev.Location = new System.Drawing.Point(0, 0);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.ShadowDepth = 4F;
            buttonPrev.Size = new System.Drawing.Size(23, 56);
            buttonPrev.TabIndex = 2;
            buttonPrev.Text = "3";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Visible = false;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // Splitter1
            // 
            Splitter1.Dock = DockStyle.Top;
            Splitter1.Location = new System.Drawing.Point(3, 59);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new System.Drawing.Size(242, 4);
            Splitter1.TabIndex = 5;
            // 
            // CosController
            // 
            
            
            Controls.Add(panel);
            Controls.Add(Splitter1);
            Controls.Add(topPanel);
            Controls.Add(Splitter);
            Name = "CosController";
            Padding = new Padding(3);
            Size = new System.Drawing.Size(248, 102);
            topPanel.ResumeLayout(false);
            panelTopRight.ResumeLayout(false);
            panelTopLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SDUI.Splitter Splitter;
        private Panel panel;
        private Panel topPanel;
        private Panel panelTopCenter;
        private Panel panelTopRight;
        private SDUI.Button buttonNext;
        private Panel panelTopLeft;
        private SDUI.Button buttonPrev;
        private SDUI.Splitter Splitter1;
    }
}
