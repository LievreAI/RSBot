namespace SDUI;

partial class InputDialog
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
        lblTitle = new Label();
        lblMessage = new Label();
        txtValue = new TextBox();
        btnOK = new Button();
        btnCancel = new Button();
        comboBox = new ComboBox();
        numValue = new NumUpDown();
        panel1 = new Panel();
        panel1.SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Location = new System.Drawing.Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(324, 20);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Input";
        // 
        // lblMessage
        // 
        lblMessage.Dock = DockStyle.Top;
        lblMessage.Location = new System.Drawing.Point(0, 20);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new System.Drawing.Size(324, 46);
        lblMessage.TabIndex = 2;
        lblMessage.Text = "Please enter a value";
        // 
        // txtValue
        // 
        txtValue.Location = new System.Drawing.Point(11, 83);
        txtValue.MaxLength = 32767;
        txtValue.MultiLine = false;
        txtValue.Name = "txtValue";
        txtValue.Size = new System.Drawing.Size(299, 25);
        txtValue.TabIndex = 0;
        txtValue.UseSystemPasswordChar = false;
        txtValue.KeyDown += txtValue_PreviewKeyDown;
        // 
        // btnOK
        // 
        btnOK.DialogResult = DialogResult.OK;
        btnOK.Location = new System.Drawing.Point(11, 6);
        btnOK.Name = "btnOK";
        btnOK.ShadowDepth = 4F;
        btnOK.Size = new System.Drawing.Size(106, 29);
        btnOK.TabIndex = 0;
        btnOK.Text = "OK";
        btnOK.UseVisualStyleBackColor = true;
        btnOK.Click += btnOK_Click;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.Location = new System.Drawing.Point(223, 6);
        btnCancel.Name = "btnCancel";
        btnCancel.ShadowDepth = 4F;
        btnCancel.Size = new System.Drawing.Size(91, 29);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        // 
        // comboBox
        // 
        comboBox.Location = new System.Drawing.Point(12, 80);
        comboBox.Name = "comboBox";
        comboBox.ShadowDepth = 4F;
        comboBox.Size = new System.Drawing.Size(277, 29);
        comboBox.TabIndex = 4;
        comboBox.Visible = false;
        // 
        // numValue
        // 
        numValue.Location = new System.Drawing.Point(12, 77);
        numValue.Maximum = 32765;
        numValue.Minimum = 1;
        numValue.MinimumSize = new System.Drawing.Size(80, 25);
        numValue.Name = "numValue";
        numValue.Size = new System.Drawing.Size(156, 34);
        numValue.TabIndex = 5;
        numValue.Value = 1;
        numValue.KeyUp += numValue_KeyUp;
        // 
        // panel1
        // 
        panel1.Border = new Padding(0, 1, 0, 0);
        panel1.Controls.Add(btnOK);
        panel1.Controls.Add(btnCancel);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new System.Drawing.Point(0, 125);
        panel1.Name = "panel1";
        panel1.ShadowDepth = 4F;
        panel1.Size = new System.Drawing.Size(324, 39);
        panel1.TabIndex = 6;
        // 
        // InputDialog
        // 
        Size = new System.Drawing.Size(324, 164);
        Controls.Add(panel1);
        Controls.Add(numValue);
        Controls.Add(comboBox);
        Controls.Add(txtValue);
        Controls.Add(lblMessage);
        Controls.Add(lblTitle);
        Name = "InputDialog";
        StartPosition = FormStartPosition.CenterParent;
        Closing += InputDialog_FormClosing;
        panel1.ResumeLayout(false);
    }

    #endregion

    private SDUI.Label lblTitle;
    private SDUI.Label lblMessage;
    private TextBox txtValue;
    private SDUI.Button btnOK;
    private SDUI.Button btnCancel;
    private ComboBox comboBox;
    private Panel panel1;
    private NumUpDown numValue;
}
