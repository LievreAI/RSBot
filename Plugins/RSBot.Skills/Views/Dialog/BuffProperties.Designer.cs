﻿using SDUI;

namespace RSBot.Skills.Views
{
    partial class BuffProperties
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
            this.propItem = new PropertyGrid();
            this.SuspendLayout();
            // 
            // propItem
            // 
            this.propItem.Dock = DockStyle.Fill;
            this.propItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.propItem.Location = new System.Drawing.Point(0, 0);
            this.propItem.Margin = new Padding(1);
            this.propItem.Name = "propItem";
            this.propItem.Size = new System.Drawing.Size(435, 450);
            this.propItem.TabIndex = 1;
            // 
            // BuffProperties
            //
            this.Size = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.propItem);
            this.Name = "BuffProperties";
            this.Text = "Buff Properties";
            this.ResumeLayout(false);

        }

        #endregion

        private PropertyGrid propItem;
    }
}