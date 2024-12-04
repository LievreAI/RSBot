namespace RSBot.Views.Controls.Cos;

partial class Fellow
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
        label3 = new SDUI.Label();
        label2 = new SDUI.Label();
        progressEXP = new SDUI.ProgressBar();
        progressSatiety = new SDUI.ProgressBar();
        progressBarStoredSp = new SDUI.ProgressBar();
        label4 = new SDUI.Label();
        SuspendLayout();
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
        label3.Location = new System.Drawing.Point(10, 88);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(30, 15);
        label3.TabIndex = 23;
        label3.Text = "EXP:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
        label2.Location = new System.Drawing.Point(-1, 66);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(41, 15);
        label2.TabIndex = 22;
        label2.Text = "Satie..:";
        // 
        // progressEXP
        // 
        progressEXP.Location = new System.Drawing.Point(48, 88);
        progressEXP.Maximum = 100L;
        progressEXP.Name = "progressEXP";
        progressEXP.Size = new System.Drawing.Size(180, 16);
        progressEXP.TabIndex = 19;
        progressEXP.Text = "0.00%";
        progressEXP.Value = 0L;
        // 
        // progressSatiety
        // 
        progressSatiety.Location = new System.Drawing.Point(48, 66);
        progressSatiety.Maximum = 100L;
        progressSatiety.Name = "progressSatiety";
        progressSatiety.Size = new System.Drawing.Size(180, 16);
        progressSatiety.TabIndex = 18;
        progressSatiety.Text = "0 / 100";
        progressSatiety.Value = 0L;
        // 
        // progressBarStoredSp
        // 
        progressBarStoredSp.ForeColor = new SkiaSharp.SKColor(0, 192, 0);
        progressBarStoredSp.Location = new System.Drawing.Point(48, 110);
        progressBarStoredSp.Maximum = 100L;
        progressBarStoredSp.Name = "progressBarStoredSp";
        progressBarStoredSp.Size = new System.Drawing.Size(180, 16);
        progressBarStoredSp.TabIndex = 19;
        progressBarStoredSp.Text = "0 / 100";
        progressBarStoredSp.Value = 0L;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = new SkiaSharp.SKColor(0, 0, 0);
        label4.Location = new System.Drawing.Point(17, 110);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(23, 15);
        label4.TabIndex = 23;
        label4.Text = "Sp:";
        // 
        // Fellow
        // 
        
        
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(progressBarStoredSp);
        Controls.Add(progressEXP);
        Controls.Add(progressSatiety);
        MaximumSize = new System.Drawing.Size(242, 135);
        MinimumSize = new System.Drawing.Size(242, 135);
        Name = "Fellow";
        Size = new System.Drawing.Size(242, 135);
        Controls.SetChildIndex(progressSatiety, 0);
        Controls.SetChildIndex(progressEXP, 0);
        Controls.SetChildIndex(progressBarStoredSp, 0);
        Controls.SetChildIndex(label2, 0);
        Controls.SetChildIndex(label3, 0);
        Controls.SetChildIndex(label4, 0);
        Controls.SetChildIndex(progressHP, 0);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private SDUI.Label label3;
    private SDUI.Label label2;
    private SDUI.ProgressBar progressEXP;
    private SDUI.ProgressBar progressSatiety;
    private SDUI.ProgressBar progressBarStoredSp;
    private SDUI.Label label4;
}
