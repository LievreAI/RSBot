using SDUI;
using SkiaSharp;

namespace RSBot.Views.Dialog
{
    partial class ProfileSelectionDialog
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
            comboProfiles = new SDUI.ComboBox();
            label1 = new SDUI.Label();
            btnOK = new SDUI.Button();
            checkSaveSelection = new SDUI.CheckBox();
            buttonCreateProfile = new SDUI.Button();
            buttonDeleteProfile = new SDUI.Button();
            SuspendLayout();
            // 
            // comboProfiles
            // 
            comboProfiles.Location = new System.Drawing.Point(122, 18);
            comboProfiles.Name = "comboProfiles";
            comboProfiles.Radius = 5;
            comboProfiles.ShadowDepth = 4F;
            comboProfiles.Size = new System.Drawing.Size(191, 24);
            comboProfiles.TabIndex = 1;
            comboProfiles.SelectedIndexChanged += comboProfiles_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.ApplyGradient = false;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label1.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label1.GradientAnimation = false;
            label1.Location = new System.Drawing.Point(20, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 17);
            label1.TabIndex = 2;
            label1.Text = "Select a profile:";
            // 
            // btnOK
            // 
            btnOK.Color = SKColors.DodgerBlue;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnOK.ForeColor = SKColors.White;
            btnOK.Location = new System.Drawing.Point(134, 84);
            btnOK.Name = "btnOK";
            btnOK.Radius = 8;
            btnOK.ShadowDepth = 4F;
            btnOK.Size = new System.Drawing.Size(136, 36);
            btnOK.TabIndex = 4;
            btnOK.Text = "CONTINUE";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // checkSaveSelection
            // 
            checkSaveSelection.AutoSize = true;
            checkSaveSelection.BackColor = SKColors.Transparent;
            checkSaveSelection.Depth = 0;
            checkSaveSelection.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            checkSaveSelection.Location = new System.Drawing.Point(125, 45);
            checkSaveSelection.Margin = new Padding(0);
            checkSaveSelection.MouseLocation = new System.Drawing.Point(-1, -1);
            checkSaveSelection.Name = "checkSaveSelection";
            checkSaveSelection.Ripple = true;
            checkSaveSelection.Size = new System.Drawing.Size(119, 30);
            checkSaveSelection.TabIndex = 6;
            checkSaveSelection.Text = "Save selection";
            checkSaveSelection.UseVisualStyleBackColor = false;
            checkSaveSelection.CheckedChanged += checkSaveSelection_CheckedChanged;
            // 
            // buttonCreateProfile
            // 
            buttonCreateProfile.Color = SKColors.Green;
            buttonCreateProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonCreateProfile.ForeColor = SKColors.White;
            buttonCreateProfile.Location = new System.Drawing.Point(316, 14);
            buttonCreateProfile.Name = "buttonCreateProfile";
            buttonCreateProfile.Radius = 6;
            buttonCreateProfile.ShadowDepth = 4F;
            buttonCreateProfile.Size = new System.Drawing.Size(32, 32);
            buttonCreateProfile.TabIndex = 8;
            buttonCreateProfile.Text = "";
            buttonCreateProfile.UseVisualStyleBackColor = true;
            buttonCreateProfile.Click += buttonCreateProfile_Click;
            // 
            // buttonDeleteProfile
            // 
            buttonDeleteProfile.Location = new System.Drawing.Point(350, 14);
            buttonDeleteProfile.Name = "buttonDeleteProfile";
            buttonDeleteProfile.Radius = 6;
            buttonDeleteProfile.ShadowDepth = 4F;
            buttonDeleteProfile.Size = new System.Drawing.Size(32, 32);
            buttonDeleteProfile.TabIndex = 8;
            buttonDeleteProfile.Text = "✕";
            buttonDeleteProfile.UseVisualStyleBackColor = true;
            buttonDeleteProfile.Click += buttonDeleteProfile_Click;
            // 
            // ProfileSelectionDialog
            // 
            
            
            Size = new System.Drawing.Size(389, 129);
            Controls.Add(btnOK);
            Controls.Add(buttonDeleteProfile);
            Controls.Add(buttonCreateProfile);
            Controls.Add(checkSaveSelection);
            Controls.Add(label1);
            Controls.Add(comboProfiles);
            Name = "ProfileSelectionDialog";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SDUI.ComboBox comboProfiles;
        private SDUI.Label label1;
        private SDUI.Button btnOK;
        private SDUI.CheckBox checkSaveSelection;
        private SDUI.Button buttonCreateProfile;
        private SDUI.Button buttonDeleteProfile;
    }
}