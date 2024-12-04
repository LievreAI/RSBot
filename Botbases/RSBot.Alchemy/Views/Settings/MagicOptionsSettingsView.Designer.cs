using SDUI;
using SkiaSharp;

namespace RSBot.Alchemy.Views.Settings
{
    partial class MagicOptionsSettingsView
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
            this.lvMagicOptions = new SDUI.ListView();
            this.columnHeader1 = new ColumnHeader();
            this.columnHeader2 = new ColumnHeader();
            this.columnHeader3 = new ColumnHeader();
            this.columnHeader4 = new ColumnHeader();
            this.SuspendLayout();
            // 
            // lvMagicOptions
            // 
            this.lvMagicOptions.CheckBoxes = true;
            this.lvMagicOptions.Columns.AddRange(new ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMagicOptions.Dock = DockStyle.Fill;
            this.lvMagicOptions.ForeColor = SKColors.Black;
            this.lvMagicOptions.FullRowSelect = true;
            this.lvMagicOptions.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.lvMagicOptions.Location = new System.Drawing.Point(0, 0);
            this.lvMagicOptions.Name = "lvMagicOptions";
            this.lvMagicOptions.Size = new System.Drawing.Size(434, 267);
            this.lvMagicOptions.TabIndex = 0;
            this.lvMagicOptions.UseCompatibleStateImageBehavior = false;
            this.lvMagicOptions.ViewType = ViewTypes.Details;
            this.lvMagicOptions.ItemChecked += this.lvMagicOptions_ItemChecked;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Option";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Current";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Max";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Num. Stones";
            this.columnHeader4.Width = 80;
            // 
            // MagicOptionsSettingsView
            // 
            this.Controls.Add(this.lvMagicOptions);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MagicOptionsSettingsView";
            this.Size = new System.Drawing.Size(434, 267);
            this.ResumeLayout(false);

        }

        #endregion

        private SDUI.ListView lvMagicOptions;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
