using SDUI;

namespace RSBot.Map.Views.Dialog
{
    partial class EntityDetailsDialog
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
            this.propEntity = new PropertyGrid();
            this.SuspendLayout();
            // 
            // propEntity
            // 
            this.propEntity.Dock = DockStyle.Fill;
            this.propEntity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.propEntity.Location = new System.Drawing.Point(0, 0);
            this.propEntity.Margin = new Padding(1);
            this.propEntity.Name = "propEntity";
            this.propEntity.Size = new System.Drawing.Size(458, 450);
            this.propEntity.TabIndex = 1;
            // 
            // EntityDetailsDialog
            //
            this.Controls.Add(this.propEntity);
            this.Name = "EntityDetailsDialog";
            this.Text = "Entity details";
            this.ResumeLayout(false);

        }

        #endregion

        private PropertyGrid propEntity;
    }
}