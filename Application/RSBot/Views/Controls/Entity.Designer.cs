using SDUI;
using SkiaSharp;

namespace RSBot.Views.Controls
{
    partial class Entity
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
            lblType = new SDUI.Label();
            label1 = new SDUI.Label();
            lblEntityName = new SDUI.Label();
            progressHP = new SDUI.ProgressBar();
            SuspendLayout();
            // 
            // lblType
            // 
            lblType.ApplyGradient = false;
            lblType.BackColor = SKColors.Transparent;
            lblType.Dock = DockStyle.Bottom;
            lblType.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblType.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            lblType.GradientAnimation = false;
            lblType.Location = new System.Drawing.Point(0, 64);
            lblType.Name = "lblType";
            lblType.Size = new System.Drawing.Size(250, 19);
            lblType.TabIndex = 18;
            lblType.Text = "<none>";
            // 
            // label1
            // 
            label1.ApplyGradient = false;
            label1.AutoSize = true;
            label1.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label1.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label1.GradientAnimation = false;
            label1.Location = new System.Drawing.Point(20, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(26, 15);
            label1.TabIndex = 17;
            label1.Text = "HP:";
            // 
            // lblEntityName
            // 
            lblEntityName.ApplyGradient = false;
            lblEntityName.AutoSize = true;
            lblEntityName.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblEntityName.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            lblEntityName.GradientAnimation = false;
            lblEntityName.Location = new System.Drawing.Point(49, 12);
            lblEntityName.Name = "lblEntityName";
            lblEntityName.Padding = new Padding(3, 0, 3, 0);
            lblEntityName.Size = new System.Drawing.Size(108, 15);
            lblEntityName.TabIndex = 16;
            lblEntityName.Text = "No entity selected";
            // 
            // progressHP
            // 
            progressHP.BackColor = SKColors.Transparent;
            progressHP.ForeColor = SKColors.Firebrick;
            progressHP.Gradient = new SKColor[]
    {
    SKColors.Maroon,
    SKColors.Red
    };
            progressHP.Location = new System.Drawing.Point(52, 38);
            progressHP.Maximum = 100L;
            progressHP.Name = "progressHP";
            progressHP.Size = new System.Drawing.Size(180, 20);
            progressHP.TabIndex = 15;
            progressHP.Text = "0,00%";
            progressHP.Value = 0L;
            // 
            // Entity
            // 
            
            
            Controls.Add(lblType);
            Controls.Add(label1);
            Controls.Add(lblEntityName);
            Controls.Add(progressHP);
            MinimumSize = new System.Drawing.Size(250, 76);
            Name = "Entity";
            Size = new System.Drawing.Size(250, 83);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SDUI.Label label1;
        private SDUI.Label lblEntityName;
        private SDUI.ProgressBar progressHP;
        private SDUI.Label lblType;
    }
}
