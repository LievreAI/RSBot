using SDUI;
using SkiaSharp;

namespace RSBot.Alchemy.Views.Settings
{
    partial class AttributeInfoPanel
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
            this.components = new System.ComponentModel.Container();
            this.comboMaxValue = new SDUI.ComboBox();
            this.lblItemAmount = new SDUI.Label();
            this.Splitter1 = new SDUI.Splitter();
            this.checkSelected = new SDUI.CheckBox();
            this.lblFinished = new Label();
            this.SuspendLayout();
            // 
            // comboMaxValue
            //
            this.comboMaxValue.Items.AddRange(new object[] {
            "22%",
            "41%",
            "61%",
            "80%",
            "100%"});
            this.comboMaxValue.Location = new System.Drawing.Point(197, 5);
            this.comboMaxValue.Name = "comboMaxValue";
            this.comboMaxValue.Size = new System.Drawing.Size(121, 24);
            this.comboMaxValue.TabIndex = 1;
            // 
            // lblItemAmount
            // 
            this.lblItemAmount.AutoSize = true;
            this.lblItemAmount.ForeColor = SKColors.Black;
            this.lblItemAmount.Location = new System.Drawing.Point(324, 8);
            this.lblItemAmount.Name = "lblItemAmount";
            this.lblItemAmount.Size = new System.Drawing.Size(19, 15);
            this.lblItemAmount.TabIndex = 2;
            this.lblItemAmount.Text = "x0";
            // 
            // Splitter1
            // 
            this.Splitter1.Dock = DockStyle.Bottom;
            this.Splitter1.Location = new System.Drawing.Point(0, 32);
            this.Splitter1.Name = "Splitter1";
            this.Splitter1.Size = new System.Drawing.Size(438, 10);
            this.Splitter1.TabIndex = 3;
            this.Splitter1.Text = "Splitter1";
            // 
            // checkSelected
            // 
            this.checkSelected.AutoSize = true;
            this.checkSelected.BackColor = SKColors.Transparent;
            this.checkSelected.Checked = false;
            this.checkSelected.Location = new System.Drawing.Point(18, 8);
            this.checkSelected.Name = "checkSelected";
            this.checkSelected.Size = new System.Drawing.Size(96, 15);
            this.checkSelected.TabIndex = 4;
            this.checkSelected.Text = "Phy. reinforce";
            // 
            // lblFinished
            // 
            this.lblFinished.AutoSize = true;
            this.lblFinished.BackColor = SKColors.Transparent;
            this.lblFinished.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinished.ForeColor = SKColors.Green;
            this.lblFinished.Location = new System.Drawing.Point(378, 4);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(27, 25);
            this.lblFinished.TabIndex = 5;
            this.lblFinished.Text = "✓";
            // 
            // AttributeInfoPanel
            // 
            this.Controls.Add(this.lblFinished);
            this.Controls.Add(this.Splitter1);
            this.Controls.Add(this.lblItemAmount);
            this.Controls.Add(this.comboMaxValue);
            this.Controls.Add(this.checkSelected);
            this.Name = "AttributeInfoPanel";
            this.Size = new System.Drawing.Size(438, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SDUI.ComboBox comboMaxValue;
        private SDUI.Label lblItemAmount;
        private SDUI.Splitter Splitter1;
        private SDUI.CheckBox checkSelected;
        private Label lblFinished;
    }
}
