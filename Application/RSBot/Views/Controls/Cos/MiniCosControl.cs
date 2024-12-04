using SDUI;
using SkiaSharp;
using System;
using System.ComponentModel;
using System.Drawing;


namespace RSBot.Views.Controls;

[ToolboxItem(false)]
public partial class MiniCosControl : Panel
{
    private bool _selected;

    public MiniCosControl()
    {
        InitializeComponent();
    }

    public bool Selected
    {
        get => _selected;
        set
        {
            _selected = value;
            panel.BorderColor = value ? SKColors.Yellow : SKColors.Transparent;
        }
    }

    private void OnClick_Redirector(object sender, MouseEventArgs e)
    {
        OnClick(e);
    }
}