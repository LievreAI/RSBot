using SDUI;
using SkiaSharp;

namespace RSBot.Views
{
    partial class ConfigDialog
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
            panel1 = new SDUI.Panel();
            btnCancel = new SDUI.Button();
            btnConfirm = new SDUI.Button();
            textBoxProxyIp = new SDUI.TextBox();
            label1 = new SDUI.Label();
            label2 = new SDUI.Label();
            label3 = new SDUI.Label();
            comboBoxProxyVersion = new SDUI.ComboBox();
            textBoxId = new SDUI.TextBox();
            label4 = new SDUI.Label();
            checkBoxOnOf = new SDUI.CheckBox();
            textBoxPw = new SDUI.TextBox();
            label6 = new SDUI.Label();
            label7 = new SDUI.Label();
            label8 = new SDUI.Label();
            textBoxPort = new SDUI.TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SKColors.Transparent;
            panel1.Border = new Padding(0, 1, 0, 0);
            panel1.BorderColor = SKColors.Transparent;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnConfirm);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 314);
            panel1.Name = "panel1";
            panel1.ShadowDepth = 4F;
            panel1.Size = new System.Drawing.Size(327, 49);
            panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Color = SKColors.Transparent;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(236, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.Radius = 6;
            btnCancel.ShadowDepth = 4F;
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Color = SKColors.Transparent;
            btnConfirm.DialogResult = DialogResult.OK;
            btnConfirm.Location = new System.Drawing.Point(12, 14);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Radius = 6;
            btnConfirm.ShadowDepth = 4F;
            btnConfirm.Size = new System.Drawing.Size(75, 23);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // textBoxProxyIp
            // 
            textBoxProxyIp.Location = new System.Drawing.Point(12, 72);
            textBoxProxyIp.MaxLength = 32767;
            textBoxProxyIp.MultiLine = false;
            textBoxProxyIp.Name = "textBoxProxyIp";
            textBoxProxyIp.Size = new System.Drawing.Size(220, 21);
            textBoxProxyIp.TabIndex = 2;
            textBoxProxyIp.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.ApplyGradient = false;
            label1.AutoSize = true;
            label1.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label1.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label1.GradientAnimation = false;
            label1.Location = new System.Drawing.Point(12, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Proxy Ip:";
            // 
            // label2
            // 
            label2.ApplyGradient = false;
            label2.AutoSize = true;
            label2.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label2.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label2.GradientAnimation = false;
            label2.Location = new System.Drawing.Point(240, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Proxy Port:";
            // 
            // label3
            // 
            label3.ApplyGradient = false;
            label3.AutoSize = true;
            label3.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label3.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label3.GradientAnimation = false;
            label3.Location = new System.Drawing.Point(14, 247);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Proxy Type:";
            // 
            // comboBoxProxyVersion
            // 
            comboBoxProxyVersion.Items.AddRange(new object[] { "Socks4", "Socks5" });
            comboBoxProxyVersion.Location = new System.Drawing.Point(14, 265);
            comboBoxProxyVersion.Name = "comboBoxProxyVersion";
            comboBoxProxyVersion.Radius = 5;
            comboBoxProxyVersion.ShadowDepth = 4F;
            comboBoxProxyVersion.Size = new System.Drawing.Size(301, 24);
            comboBoxProxyVersion.TabIndex = 5;
            // 
            // textBoxId
            // 
            textBoxId.Location = new System.Drawing.Point(14, 147);
            textBoxId.MaxLength = 32767;
            textBoxId.MultiLine = false;
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new System.Drawing.Size(301, 21);
            textBoxId.TabIndex = 2;
            textBoxId.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.ApplyGradient = false;
            label4.AutoSize = true;
            label4.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label4.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label4.GradientAnimation = false;
            label4.Location = new System.Drawing.Point(14, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(96, 15);
            label4.TabIndex = 3;
            label4.Text = "Proxy Username:";
            // 
            // checkBoxOnOf
            // 
            checkBoxOnOf.AutoSize = true;
            checkBoxOnOf.BackColor = SKColors.Transparent;
            checkBoxOnOf.Depth = 0;
            checkBoxOnOf.Location = new System.Drawing.Point(12, 9);
            checkBoxOnOf.MouseLocation = new System.Drawing.Point(-1, -1);
            checkBoxOnOf.Name = "checkBoxOnOf";
            checkBoxOnOf.Ripple = true;
            checkBoxOnOf.Size = new System.Drawing.Size(73, 30);
            checkBoxOnOf.TabIndex = 8;
            checkBoxOnOf.Text = "Activate";
            checkBoxOnOf.UseVisualStyleBackColor = false;
            // 
            // textBoxPw
            // 
            textBoxPw.Location = new System.Drawing.Point(14, 213);
            textBoxPw.MaxLength = 32767;
            textBoxPw.MultiLine = false;
            textBoxPw.Name = "textBoxPw";
            textBoxPw.Size = new System.Drawing.Size(301, 21);
            textBoxPw.TabIndex = 2;
            textBoxPw.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            label6.ApplyGradient = false;
            label6.AutoSize = true;
            label6.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label6.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label6.GradientAnimation = false;
            label6.Location = new System.Drawing.Point(14, 181);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(93, 15);
            label6.TabIndex = 3;
            label6.Text = "Proxy password:";
            // 
            // label7
            // 
            label7.ApplyGradient = false;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label7.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label7.GradientAnimation = false;
            label7.Location = new System.Drawing.Point(14, 127);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(238, 13);
            label7.TabIndex = 3;
            label7.Text = "If you don't want to use it, you can leave it blank.";
            // 
            // label8
            // 
            label8.ApplyGradient = false;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
            label8.Gradient = new SKColor[]
    {
    SKColors.Gray,
    SKColors.Black
    };
            label8.GradientAnimation = false;
            label8.Location = new System.Drawing.Point(16, 197);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(238, 13);
            label8.TabIndex = 3;
            label8.Text = "If you don't want to use it, you can leave it blank.";
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new System.Drawing.Point(238, 72);
            textBoxPort.MaxLength = 32767;
            textBoxPort.MultiLine = false;
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new System.Drawing.Size(75, 21);
            textBoxPort.TabIndex = 10;
            textBoxPort.Text = "0";
            textBoxPort.UseSystemPasswordChar = false;
            // 
            // ConfigDialog
            // 
            
            Size = new System.Drawing.Size(327, 363);
            Controls.Add(textBoxPort);
            Controls.Add(checkBoxOnOf);
            Controls.Add(comboBoxProxyVersion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(textBoxPw);
            Controls.Add(label1);
            Controls.Add(textBoxId);
            Controls.Add(textBoxProxyIp);
            Controls.Add(panel1);
            AllowMaximize = false;
            AllowMinimize = false;
            Name = "ConfigDialog";
            Text = "Proxy Config";
            Closing += ConfigDialog_FormClosing;
            Load += ExitDialog_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SDUI.Panel panel1;
        private SDUI.Button btnCancel;
        private SDUI.Button btnConfirm;
        private SDUI.TextBox textBoxProxyIp;
        private SDUI.Label label1;
        private SDUI.Label label2;
        private SDUI.Label label3;
        private SDUI.ComboBox comboBoxProxyVersion;
        private SDUI.TextBox textBoxId;
        private SDUI.Label label4;
        private SDUI.CheckBox checkBoxOnOf;
        private SDUI.TextBox textBoxPw;
        private SDUI.Label label6;
        private SDUI.Label label7;
        private SDUI.Label label8;
        private SDUI.TextBox textBoxPort;
    }
}