using SDUI;
using System.ComponentModel;
using System.Drawing;

namespace RSBot.Views.Controls;

[ToolboxItem(false)]
public class CosControlBase : Panel
{
    private Label label1;
    protected Label labelLevel;
    protected Label lblPetName;
    private Panel panel1;
    protected ProgressBar progressHP;

    public CosControlBase()
    {
        MiniCosControl = new MiniCosControl();
        MiniCosControl.Dock = DockStyle.Left;
        InitializeComponent();
    }

    public MiniCosControl MiniCosControl { get; }

    public virtual void Initialize()
    {
    }

    public virtual void Reset()
    {
        progressHP.Value = 0;
        MiniCosControl.Hp.Value = 0;

        progressHP.Maximum = 0;
        MiniCosControl.Hp.Maximum = 0;
    }

    private void InitializeComponent()
    {
        label1 = new Label();
        lblPetName = new Label();
        progressHP = new ProgressBar();
        panel1 = new Panel();
        labelLevel = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(14, 44);
        label1.Name = "label1";
        label1.Size = new Size(26, 15);
        label1.TabIndex = 20;
        label1.Text = "HP:";
        // 
        // lblPetName
        // 
        lblPetName.AutoSize = true;
        lblPetName.Dock = DockStyle.Left;
        lblPetName.Location = new Point(0, 0);
        lblPetName.Name = "lblPetName";
        lblPetName.Size = new Size(81, 15);
        lblPetName.TabIndex = 19;
        lblPetName.Text = "No pet found";
        // 
        // progressHP
        // 

        progressHP.Location = new Point(48, 45);
        progressHP.Maximum = 100L;
        progressHP.Name = "progressHP";
        progressHP.Size = new Size(180, 16);
        progressHP.TabIndex = 18;
        progressHP.Text = "0 / 100";
        progressHP.Value = 0L;
        // 
        // panel1
        // 
        panel1.Border = new Padding(0, 0, 0, 0);
        panel1.Controls.Add(labelLevel);
        panel1.Controls.Add(lblPetName);
        panel1.Location = new Point(48, 18);
        panel1.Name = "panel1";
        panel1.ShadowDepth = 4F;
        panel1.Size = new Size(180, 21);
        panel1.TabIndex = 21;
        // 
        // labelLevel
        // 
        labelLevel.AutoSize = true;
        labelLevel.Dock = DockStyle.Left;
        labelLevel.Location = new Point(81, 0);
        labelLevel.Name = "labelLevel";
        labelLevel.Size = new Size(0, 15);
        labelLevel.TabIndex = 20;
        // 
        // CosControlBase
        // 
        Controls.Add(panel1);
        Controls.Add(label1);
        Controls.Add(progressHP);
        Name = "CosControlBase";
        Size = new Size(243, 79);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}