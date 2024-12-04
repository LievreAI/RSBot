using SDUI;

namespace RSBot.Views.Dialog;

partial class CommandDialog
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
        this.panel1 = new SDUI.Panel();
        this.btnAdd = new SDUI.Button();
        this.btnCancel = new SDUI.Button();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Border = new Padding(0, 0, 0, 0);
        this.panel1.Controls.Add(this.btnAdd);
        this.panel1.Controls.Add(this.btnCancel);
        this.panel1.Dock = DockStyle.Bottom;
        this.panel1.Location = new System.Drawing.Point(0, 2);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(252, 44);
        this.panel1.TabIndex = 3;
        // 
        // btnAdd
        // 
        this.btnAdd.DialogResult = DialogResult.OK;
        this.btnAdd.Location = new System.Drawing.Point(90, 9);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(75, 23);
        this.btnAdd.TabIndex = 1;
        this.btnAdd.Text = "Add";
        this.btnAdd.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = SDUI.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(171, 9);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 1;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // CommandDialog
        // 
        this.Size = new System.Drawing.Size(252, 46);
        this.Controls.Add(this.panel1);
        this.Name = "CommandDialog";
        this.Text = "CommandDialog";
        this.panel1.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private SDUI.Panel panel1;
    private SDUI.Button btnAdd;
    private SDUI.Button btnCancel;
}