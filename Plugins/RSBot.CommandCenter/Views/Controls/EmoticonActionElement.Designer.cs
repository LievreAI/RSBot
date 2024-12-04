using SDUI;

namespace RSBot.CommandCenter.Views.Controls
{
    partial class EmoticonActionElement
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
            picIcon = new PictureBox();
            comboAction = new SDUI.ComboBox();
            lblName = new SDUI.Label();
            Splitter1 = new SDUI.Splitter();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // picIcon
            // 
            picIcon.Location = new System.Drawing.Point(11, 9);
            picIcon.Name = "picIcon";
            picIcon.Size = new System.Drawing.Size(32, 32);
            picIcon.TabIndex = 0;
            picIcon.TabStop = false;
            // 
            // comboAction
            // 
            comboAction.Location = new System.Drawing.Point(58, 19);
            comboAction.Name = "comboAction";
            comboAction.ShadowDepth = 4F;
            comboAction.Size = new System.Drawing.Size(188, 24);
            comboAction.TabIndex = 1;
            comboAction.SelectedIndexChanged += comboAction_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            lblName.Location = new System.Drawing.Point(58, 3);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(53, 15);
            lblName.TabIndex = 2;
            lblName.Text = "<name>";
            // 
            // Splitter1
            // 
            Splitter1.Dock = DockStyle.Bottom;
            Splitter1.Location = new System.Drawing.Point(0, 43);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new System.Drawing.Size(277, 10);
            Splitter1.TabIndex = 3;
            Splitter1.Text = "Splitter1";
            // 
            // EmoticonActionElement
            // 
            Controls.Add(Splitter1);
            Controls.Add(lblName);
            Controls.Add(comboAction);
            Controls.Add(picIcon);
            Name = "EmoticonActionElement";
            Size = new System.Drawing.Size(277, 53);
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SDUI.PictureBox picIcon;
        private SDUI.ComboBox comboAction;
        private SDUI.Label lblName;
        private SDUI.Splitter Splitter1;
    }
}
