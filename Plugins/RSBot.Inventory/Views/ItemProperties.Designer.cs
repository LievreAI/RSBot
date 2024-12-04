using SDUI;

namespace RSBot.Inventory.Views
{
    partial class ItemProperties
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
            this.propItem.Size = new System.Drawing.Size(439, 577);
            this.propItem.TabIndex = 0;
            // 
            // ItemProperties
            // 
            this.Size = new System.Drawing.Size(439, 577);
            this.Controls.Add(this.propItem);
            this.Margin = new Padding(1);
            this.Name = "ItemProperties";
            this.Text = "Item Properties";
            this.ResumeLayout(false);

        }

        #endregion

        private PropertyGrid propItem;
    }
}