using SDUI;
using SkiaSharp;

namespace RSBot.Views.Controls
{


    partial class Character
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
            label3 = new SDUI.Label();
            label4 = new SDUI.Label();
            lblLevel = new SDUI.Label();
            lblGold = new SDUI.Label();
            lblSP = new SDUI.Label();
            lblPlayerName = new SDUI.Label();
            lblStr = new SDUI.Label();
            label9 = new SDUI.Label();
            lblInt = new SDUI.Label();
            label11 = new SDUI.Label();
            progressEXP = new SDUI.ProgressBar();
            progressMP = new SDUI.ProgressBar();
            progressHP = new SDUI.ProgressBar();
            Splitter1 = new SDUI.Splitter();
            SuspendLayout();
            // 
            // label3
            // 
            label3.ApplyGradient = false;
            label3.AutoSize = true;
            label3.BackColor = SKColors.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label3.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label3.GradientAnimation = false;
            label3.Location = new System.Drawing.Point(535, 26);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 17);
            label3.TabIndex = 4;
            label3.Text = "Gold:";
            // 
            // label4
            // 
            label4.ApplyGradient = false;
            label4.AutoSize = true;
            label4.BackColor = SKColors.Transparent;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label4.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label4.GradientAnimation = false;
            label4.Location = new System.Drawing.Point(547, 48);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(26, 17);
            label4.TabIndex = 5;
            label4.Text = "SP:";
            // 
            // lblLevel
            // 
            lblLevel.ApplyGradient = false;
            lblLevel.BackColor = SKColors.Transparent;
            lblLevel.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblLevel.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            lblLevel.GradientAnimation = false;
            lblLevel.Location = new System.Drawing.Point(347, 4);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new System.Drawing.Size(65, 15);
            lblLevel.TabIndex = 6;
            lblLevel.Text = "0";
            // 
            // lblGold
            // 
            lblGold.ApplyGradient = false;
            lblGold.AutoSize = true;
            lblGold.BackColor = SKColors.Transparent;
            lblGold.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblGold.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            lblGold.GradientAnimation = false;
            lblGold.Location = new System.Drawing.Point(577, 29);
            lblGold.Name = "lblGold";
            lblGold.Size = new System.Drawing.Size(13, 15);
            lblGold.TabIndex = 7;
            lblGold.Text = "0";
            // 
            // lblSP
            // 
            lblSP.ApplyGradient = false;
            lblSP.AutoSize = true;
            lblSP.BackColor = SKColors.Transparent;
            lblSP.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblSP.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            lblSP.GradientAnimation = false;
            lblSP.Location = new System.Drawing.Point(577, 50);
            lblSP.Name = "lblSP";
            lblSP.Size = new System.Drawing.Size(13, 15);
            lblSP.TabIndex = 8;
            lblSP.Text = "0";
            // 
            // lblPlayerName
            // 
            lblPlayerName.ApplyGradient = false;
            lblPlayerName.AutoSize = true;
            lblPlayerName.BackColor = SKColors.Transparent;
            lblPlayerName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPlayerName.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblPlayerName.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            lblPlayerName.GradientAnimation = false;
            lblPlayerName.Location = new System.Drawing.Point(7, 4);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new System.Drawing.Size(84, 17);
            lblPlayerName.TabIndex = 9;
            lblPlayerName.Text = "Not in game";
            // 
            // lblStr
            // 
            lblStr.ApplyGradient = false;
            lblStr.AutoSize = true;
            lblStr.BackColor = SKColors.Transparent;
            lblStr.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblStr.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            lblStr.GradientAnimation = false;
            lblStr.Location = new System.Drawing.Point(468, 29);
            lblStr.Name = "lblStr";
            lblStr.Size = new System.Drawing.Size(13, 15);
            lblStr.TabIndex = 11;
            lblStr.Text = "0";
            // 
            // label9
            // 
            label9.ApplyGradient = false;
            label9.AutoSize = true;
            label9.BackColor = SKColors.Transparent;
            label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label9.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label9.GradientAnimation = false;
            label9.Location = new System.Drawing.Point(430, 26);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(33, 17);
            label9.TabIndex = 10;
            label9.Text = "STR:";
            // 
            // lblInt
            // 
            lblInt.ApplyGradient = false;
            lblInt.AutoSize = true;
            lblInt.BackColor = SKColors.Transparent;
            lblInt.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblInt.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            lblInt.GradientAnimation = false;
            lblInt.Location = new System.Drawing.Point(468, 50);
            lblInt.Name = "lblInt";
            lblInt.Size = new System.Drawing.Size(13, 15);
            lblInt.TabIndex = 13;
            lblInt.Text = "0";
            // 
            // label11
            // 
            label11.ApplyGradient = false;
            label11.AutoSize = true;
            label11.BackColor = SKColors.Transparent;
            label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label11.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label11.GradientAnimation = false;
            label11.Location = new System.Drawing.Point(432, 48);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(32, 17);
            label11.TabIndex = 12;
            label11.Text = "INT:";
            // 
            // progressEXP
            // 
            progressEXP.BackColor = SKColors.Transparent;
            progressEXP.ForeColor = new SkiaSharp.SKColor(0, 192, 0);
            progressEXP.Gradient = new SKColor[]
    {
    SKColors.DarkGreen,
    SKColors.Lime
    };
            progressEXP.Location = new System.Drawing.Point(10, 49);
            progressEXP.Maximum = 1L;
            progressEXP.MaxPercentShowValue = 99.99F;
            progressEXP.Name = "progressEXP";
            progressEXP.PercentIndices = 2;
            progressEXP.Radius = 6;
            progressEXP.ShowAsPercent = true;
            progressEXP.ShowValue = true;
            progressEXP.Size = new System.Drawing.Size(402, 20);
            progressEXP.TabIndex = 2;
            progressEXP.Text = "0.00%";
            progressEXP.Value = 0L;
            // 
            // progressMP
            // 
            progressMP.BackColor = SKColors.Transparent;
            progressMP.Gradient = new SKColor[]
    {
    SKColors.MidnightBlue,
    SKColors.RoyalBlue
    };
            progressMP.Location = new System.Drawing.Point(214, 26);
            progressMP.Maximum = 1L;
            progressMP.MaxPercentShowValue = 100F;
            progressMP.Name = "progressMP";
            progressMP.PercentIndices = 2;
            progressMP.Radius = 6;
            progressMP.ShowAsPercent = false;
            progressMP.ShowValue = true;
            progressMP.Size = new System.Drawing.Size(198, 20);
            progressMP.TabIndex = 1;
            progressMP.Text = "0 / 1";
            progressMP.Value = 0L;
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
            progressHP.Location = new System.Drawing.Point(10, 26);
            progressHP.Maximum = 1L;
            progressHP.MaxPercentShowValue = 100F;
            progressHP.Name = "progressHP";
            progressHP.PercentIndices = 2;
            progressHP.Radius = 6;
            progressHP.ShowAsPercent = false;
            progressHP.ShowValue = true;
            progressHP.Size = new System.Drawing.Size(198, 20);
            progressHP.TabIndex = 0;
            progressHP.Text = "0 / 1";
            progressHP.Value = 0L;
            // 
            // Splitter1
            // 
            Splitter1.Dock = DockStyle.Bottom;
            Splitter1.Location = new System.Drawing.Point(0, 73);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new System.Drawing.Size(695, 2);
            Splitter1.TabIndex = 14;
            Splitter1.Visible = false;
            // 
            // Character
            // 
            
            
            Controls.Add(Splitter1);
            Controls.Add(lblInt);
            Controls.Add(label11);
            Controls.Add(lblStr);
            Controls.Add(label9);
            Controls.Add(lblPlayerName);
            Controls.Add(lblSP);
            Controls.Add(lblGold);
            Controls.Add(lblLevel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(progressEXP);
            Controls.Add(progressMP);
            Controls.Add(progressHP);
            Name = "Character";
            Size = new System.Drawing.Size(695, 75);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SDUI.ProgressBar progressHP;
        private SDUI.ProgressBar progressMP;
        private SDUI.ProgressBar progressEXP;
        private SDUI.Label label3;
        private SDUI.Label label4;
        private SDUI.Label lblLevel;
        private SDUI.Label lblGold;
        private SDUI.Label lblSP;
        private SDUI.Label lblPlayerName;
        private SDUI.Label lblStr;
        private SDUI.Label label9;
        private SDUI.Label lblInt;
        private SDUI.Label label11;
        private SDUI.Splitter Splitter1;
    }
}
