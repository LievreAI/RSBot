using SDUI;
using SkiaSharp;

namespace RSBot.CommandCenter.Views
{
    partial class Main
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
            checkEnable = new SDUI.CheckBox();
            btnResetToDefaults = new SDUI.Button();
            tabControl1 = new SDUI.TabControl();
            tabPage1 = new TabPage();
            panelActions = new SDUI.Panel();
            tabPage2 = new TabPage();
            lblChatCommandDescriptions = new TextBox();
            label1 = new SDUI.Label();
            tabPage3 = new TabPage();
            label2 = new SDUI.Label();
            btnSave = new SDUI.Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // checkEnable
            // 
            checkEnable.AutoSize = true;
            checkEnable.BackColor = SKColors.Transparent;
            checkEnable.Location = new System.Drawing.Point(132, 368);
            checkEnable.Margin = new Padding(0);
            checkEnable.Name = "checkEnable";
            checkEnable.Ripple = true;
            checkEnable.Size = new System.Drawing.Size(161, 30);
            checkEnable.TabIndex = 0;
            checkEnable.Text = "Enable command center";
            checkEnable.UseVisualStyleBackColor = false;
            checkEnable.CheckedChanged += checkEnable_CheckedChanged;
            // 
            // btnResetToDefaults
            // 
            btnResetToDefaults.Color = SKColors.Transparent;
            btnResetToDefaults.Location = new System.Drawing.Point(8, 371);
            btnResetToDefaults.Name = "btnResetToDefaults";
            btnResetToDefaults.ShadowDepth = 4F;
            btnResetToDefaults.Size = new System.Drawing.Size(118, 23);
            btnResetToDefaults.TabIndex = 3;
            btnResetToDefaults.Text = "Reset to defaults";
            btnResetToDefaults.UseVisualStyleBackColor = true;
            btnResetToDefaults.Click += btnResetToDefaults_Click;
            // 
            // tabControl1
            // 
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.Location = new System.Drawing.Point(8, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(385, 359);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SKColors.White;
            tabPage1.Controls.Add(panelActions);
            tabPage1.Location = new System.Drawing.Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new System.Drawing.Size(377, 327);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Emote commands";
            // 
            // panelActions
            // 
            panelActions.AutoScroll = true;
            panelActions.BackColor = SKColors.Transparent;
            panelActions.Border = new Padding(0, 0, 0, 0);
            panelActions.BorderColor = SKColors.Transparent;
            panelActions.Dock = DockStyle.Fill;
            panelActions.Location = new System.Drawing.Point(3, 3);
            panelActions.Name = "panelActions";
            panelActions.ShadowDepth = 4F;
            panelActions.Size = new System.Drawing.Size(371, 321);
            panelActions.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SKColors.White;
            tabPage2.Controls.Add(lblChatCommandDescriptions);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new System.Drawing.Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new System.Drawing.Size(377, 327);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chat commands";
            // 
            // lblChatCommandDescriptions
            // 
            lblChatCommandDescriptions.Location = new System.Drawing.Point(21, 47);
            lblChatCommandDescriptions.Name = "lblChatCommandDescriptions";
            lblChatCommandDescriptions.ReadOnly = true;
            lblChatCommandDescriptions.Size = new System.Drawing.Size(335, 277);
            lblChatCommandDescriptions.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(281, 15);
            label1.TabIndex = 0;
            label1.Text = "Type the following commands into the game chat";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SKColors.White;
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new System.Drawing.Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new System.Drawing.Size(377, 327);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Notifications";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(134, 157);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 15);
            label2.TabIndex = 0;
            label2.Text = "<coming soon>";
            // 
            // btnSave
            // 
            btnSave.ForeColor = SKColors.White;
            btnSave.Location = new System.Drawing.Point(311, 371);
            btnSave.Name = "btnSave";
            btnSave.ShadowDepth = 4F;
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Main
            // 
            
            
            Controls.Add(btnSave);
            Controls.Add(tabControl1);
            Controls.Add(btnResetToDefaults);
            Controls.Add(checkEnable);
            Name = "Main";
            Size = new System.Drawing.Size(400, 405);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SDUI.CheckBox checkEnable;
        private SDUI.Button btnResetToDefaults;
        private SDUI.TabControl tabControl1;
        private TabPage tabPage1;
        private SDUI.Panel panelActions;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private SDUI.Label label1;
        private TextBox lblChatCommandDescriptions;
        private SDUI.Label label2;
        private SDUI.Button btnSave;
    }
}
