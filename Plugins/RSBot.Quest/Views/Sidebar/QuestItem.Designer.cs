using SDUI;
using SkiaSharp;

namespace RSBot.Quest.Views.Sidebar
{
    partial class QuestItem
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
            components = new System.ComponentModel.Container();
            panel1 = new SDUI.Panel();
            btnRemove = new SDUI.Button();
            lblObjective = new SDUI.Label();
            lblQuestName = new SDUI.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SKColors.Transparent;
            panel1.Border = new Padding(0, 0, 0, 0);
            panel1.BorderColor = SKColors.Transparent;
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(lblObjective);
            panel1.Controls.Add(lblQuestName);
            panel1.Location = new System.Drawing.Point(4, 4);
            panel1.Margin = new Padding(8);
            panel1.Name = "panel1";
            panel1.ShadowDepth = 4F;
            panel1.Size = new System.Drawing.Size(239, 56);
            panel1.TabIndex = 0;
            // 
            // btnRemove
            // 
            btnRemove.Color = SKColors.Empty;
            btnRemove.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRemove.Location = new System.Drawing.Point(214, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Radius = 16;
            btnRemove.ShadowDepth = 1F;
            btnRemove.Size = new System.Drawing.Size(18, 18);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "x";
            btnRemove.TextAlign = ContentAlignment.MiddleRight;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblObjective
            // 
            lblObjective.ApplyGradient = false;
            lblObjective.Dock = DockStyle.Fill;
            lblObjective.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblObjective.Gradient = new SKColor[] { SKColors.Gray, SKColors.Black };
            lblObjective.GradientAnimation = false;
            lblObjective.Location = new System.Drawing.Point(0, 26);
            lblObjective.Name = "lblObjective";
            lblObjective.Padding = new Padding(6, 2, 4, 4);
            lblObjective.Size = new System.Drawing.Size(239, 30);
            lblObjective.TabIndex = 1;
            lblObjective.Text = "Objective 1 with a very long title";
            // 
            // lblQuestName
            // 
            lblQuestName.ApplyGradient = false;
            lblQuestName.Dock = DockStyle.Top;
            lblQuestName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQuestName.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblQuestName.Gradient = new SKColor[] { SKColors.Gray, SKColors.Black };
            lblQuestName.GradientAnimation = false;
            lblQuestName.Location = new System.Drawing.Point(0, 0);
            lblQuestName.Margin = new Padding(0);
            lblQuestName.Name = "lblQuestName";
            lblQuestName.Padding = new Padding(6, 8, 4, 4);
            lblQuestName.Size = new System.Drawing.Size(239, 26);
            lblQuestName.TabIndex = 0;
            lblQuestName.Text = "QuestLog A";
            // 
            // QuestItem
            // 
            
            
            Controls.Add(panel1);
            Name = "QuestItem";
            Size = new System.Drawing.Size(248, 65);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SDUI.Panel panel1;
        private SDUI.Label lblObjective;
        private SDUI.Label lblQuestName;
        private SDUI.Button btnRemove;
    }
}
