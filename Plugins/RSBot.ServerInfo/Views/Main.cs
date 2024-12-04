using System.ComponentModel;

using RSBot.General.Components;
using SDUI;

namespace RSBot.ServerInfo.Views;

[ToolboxItem(false)]
public partial class Main : Panel
{
    public Main()
    {
        
        InitializeComponent();

        UpdateServerInfo();
    }

    private void UpdateServerInfo()
    {
        lvServerInfo.Items.Clear();

        if (Serverlist.Servers == null) return;

        foreach (var server in Serverlist.Servers)
        {
            var toInsert = new ListViewItem(new[]
            {
                server.Name,
                server.State
            });
            lvServerInfo.Items.Add(toInsert);
        }
    }
}