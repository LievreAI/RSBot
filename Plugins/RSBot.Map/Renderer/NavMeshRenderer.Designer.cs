using SDUI;
using System.Drawing;


namespace RSBot.Map.Renderer;

partial class NavMeshRenderer
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
        components = new System.ComponentModel.Container();
        contextRenderSettings = new ContextMenu();
        
        displayMenuItem = new MenuItem();
        regionIDMenuItem = new MenuItem();
        regionBorderMenuItem = new MenuItem();
        terrainMenuItem = new MenuItem();
        terrainCellIDMenuItem = new MenuItem();
        MenuSplitterItem1 = new MenuSplitterItem();
        terrainGlobalEdgesMenuItem = new MenuItem();
        terrainGlobalEdgeIDMenuItem = new MenuItem();
        MenuSplitterItem2 = new MenuSplitterItem();
        terrainInternalEdgesMenuItem = new MenuItem();
        terrainInternalEdgeIDMenuItem = new MenuItem();
        objectsMenuItem = new MenuItem();
        objectCellIDMenuItem = new MenuItem();
        objectGroundMenuItem = new MenuItem();
        MenuSplitterItem3 = new MenuSplitterItem();
        objectGlobalEdgesMenuItem1 = new MenuItem();
        objectGlobalEdgeIDMenuItem = new MenuItem();
        MenuSplitterItem4 = new MenuSplitterItem();
        objectInternalEdgesMenuItem1 = new MenuItem();
        objectInternalEdgeIDMenuItem = new MenuItem();
        raycastMenuItem = new MenuItem();
        contextRenderSettings.SuspendLayout();
        SuspendLayout();
        // 
        // contextRenderSettings
        // 
        contextRenderSettings.Items.AddRange(new MenuItem[] { displayMenuItem, raycastMenuItem });
        contextRenderSettings.Name = "ContextMenu1";
        contextRenderSettings.Size = new Size(194, 74);
        // 
        // displayMenuItem
        // 
        displayMenuItem.Items.AddRange(new MenuItem[] { regionIDMenuItem, regionBorderMenuItem, terrainMenuItem, objectsMenuItem });
        displayMenuItem.Name = "displayMenuItem";
        displayMenuItem.Text = "&Display";
        // 
        // regionIDMenuItem
        // 
        regionIDMenuItem.Checked = true;
        regionIDMenuItem.CheckOnClick = true;
        regionIDMenuItem.Name = "regionIDMenuItem";
        regionIDMenuItem.Text = "RegionID";
        regionIDMenuItem.Click += regionIDMenuItem_CheckedChange;
        // 
        // regionBorderMenuItem
        // 
        regionBorderMenuItem.Checked = true;
        regionBorderMenuItem.CheckOnClick = true;
        regionBorderMenuItem.Name = "regionBorderMenuItem";
        regionBorderMenuItem.Text = "RegionBorder";
        regionBorderMenuItem.Click += regionBorderMenuItem_CheckedChange;
        // 
        // terrainMenuItem
        // 
        terrainMenuItem.Items.AddRange(new MenuItem[] { terrainCellIDMenuItem, MenuSplitterItem1, terrainGlobalEdgesMenuItem, terrainGlobalEdgeIDMenuItem, MenuSplitterItem2, terrainInternalEdgesMenuItem, terrainInternalEdgeIDMenuItem });
        terrainMenuItem.Name = "terrainMenuItem";
        terrainMenuItem.Text = "Terrain";
        // 
        // terrainCellIDMenuItem
        // 
        terrainCellIDMenuItem.CheckOnClick = true;
        terrainCellIDMenuItem.Name = "terrainCellIDMenuItem";
        terrainCellIDMenuItem.Text = "&CellID";
        terrainCellIDMenuItem.Click += terrainCellIDMenuItem_Click;
        // 
        // MenuSplitterItem1
        // 
        MenuSplitterItem1.Name = "MenuSplitterItem1";
        // 
        // terrainGlobalEdgesMenuItem
        // 
        terrainGlobalEdgesMenuItem.Checked = true;
        terrainGlobalEdgesMenuItem.CheckOnClick = true;
        terrainGlobalEdgesMenuItem.Name = "terrainGlobalEdgesMenuItem";
        terrainGlobalEdgesMenuItem.Text = "&GlobalEdges";
        terrainGlobalEdgesMenuItem.Click += globalEdgesMenuItem_CheckedChanged;
        // 
        // terrainGlobalEdgeIDMenuItem
        // 
        terrainGlobalEdgeIDMenuItem.CheckOnClick = true;
        terrainGlobalEdgeIDMenuItem.Name = "terrainGlobalEdgeIDMenuItem";
        terrainGlobalEdgeIDMenuItem.Text = "&GlobalEdgeID";
        terrainGlobalEdgeIDMenuItem.Click += terrainGlobalEdgeIDMenuItem_Click;
        // 
        // MenuSplitterItem2
        // 
        MenuSplitterItem2.Name = "MenuSplitterItem2";
        // 
        // terrainInternalEdgesMenuItem
        // 
        terrainInternalEdgesMenuItem.Checked = true;
        terrainInternalEdgesMenuItem.CheckOnClick = true;
        terrainInternalEdgesMenuItem.Name = "terrainInternalEdgesMenuItem";
        terrainInternalEdgesMenuItem.Text = "&InternalEdges";
        terrainInternalEdgesMenuItem.Click += internalEdgesMenuItem_CheckedChanged;
        // 
        // terrainInternalEdgeIDMenuItem
        // 
        terrainInternalEdgeIDMenuItem.CheckOnClick = true;
        terrainInternalEdgeIDMenuItem.Name = "terrainInternalEdgeIDMenuItem";
        terrainInternalEdgeIDMenuItem.Text = "&InternalEdgeID";
        terrainInternalEdgeIDMenuItem.Click += terrainInternalEdgeIDMenuItem_Click;
        // 
        // objectsMenuItem
        // 
        objectsMenuItem.Items.AddRange(new MenuItem[] { objectCellIDMenuItem, objectGroundMenuItem, MenuSplitterItem3, objectGlobalEdgesMenuItem1, objectGlobalEdgeIDMenuItem, MenuSplitterItem4, objectInternalEdgesMenuItem1, objectInternalEdgeIDMenuItem });
        objectsMenuItem.Name = "objectsMenuItem";
        objectsMenuItem.Text = "Objects";
        // 
        // objectCellIDMenuItem
        // 
        objectCellIDMenuItem.CheckOnClick = true;
        objectCellIDMenuItem.Name = "objectCellIDMenuItem";
        objectCellIDMenuItem.Text = "&CellID";
        objectCellIDMenuItem.Click += objectCellIDMenuItem_Click;
        // 
        // objectGroundMenuItem
        // 
        objectGroundMenuItem.Checked = true;
        objectGroundMenuItem.CheckOnClick = true;
        objectGroundMenuItem.Name = "objectGroundMenuItem";
        objectGroundMenuItem.Text = "&Ground";
        objectGroundMenuItem.Click += groundMenuItem_CheckedChanged;
        // 
        // MenuSplitterItem3
        // 
        MenuSplitterItem3.Name = "MenuSplitterItem3";
        // 
        // objectGlobalEdgesMenuItem1
        // 
        objectGlobalEdgesMenuItem1.Checked = true;
        objectGlobalEdgesMenuItem1.CheckOnClick = true;
        objectGlobalEdgesMenuItem1.Name = "objectGlobalEdgesMenuItem1";
        objectGlobalEdgesMenuItem1.Text = "&GlobalEdges";
        objectGlobalEdgesMenuItem1.Click += globalEdgesMenuItem1_CheckedChanged;
        // 
        // objectGlobalEdgeIDMenuItem
        // 
        objectGlobalEdgeIDMenuItem.CheckOnClick = true;
        objectGlobalEdgeIDMenuItem.Name = "objectGlobalEdgeIDMenuItem";
        objectGlobalEdgeIDMenuItem.Text = "&GlobalEdgeID";
        objectGlobalEdgeIDMenuItem.Click += objectGlobalEdgeIDMenuItem_Click;
        // 
        // MenuSplitterItem4
        // 
        MenuSplitterItem4.Name = "MenuSplitterItem4";
        // 
        // objectInternalEdgesMenuItem1
        // 
        objectInternalEdgesMenuItem1.Checked = true;
        objectInternalEdgesMenuItem1.CheckOnClick = true;
        objectInternalEdgesMenuItem1.Name = "objectInternalEdgesMenuItem1";
        objectInternalEdgesMenuItem1.Text = "&InternalEdges";
        objectInternalEdgesMenuItem1.Click += internalEdgesMenuItem1_CheckedChanged;
        // 
        // objectInternalEdgeIDMenuItem
        // 
        objectInternalEdgeIDMenuItem.CheckOnClick = true;
        objectInternalEdgeIDMenuItem.Name = "objectInternalEdgeIDMenuItem";
        objectInternalEdgeIDMenuItem.Text = "&InternalEdgeID";
        objectInternalEdgeIDMenuItem.Click += objectInternalEdgeIDMenuItem_Click;
        // 
        // raycastMenuItem
        // 
        raycastMenuItem.CheckOnClick = true;
        raycastMenuItem.Name = "raycastMenuItem";
        raycastMenuItem.Text = "Raycast visualizer";
        raycastMenuItem.Click += raycastMenuItem_CheckedChanged;
        // 
        // NavMeshRenderer
        // 
        ContextMenu = contextRenderSettings;
        Margin = new Padding(3, 4, 3, 4);
        Name = "NavMeshRenderer";
        Size = new Size(293, 341);
        contextRenderSettings.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ContextMenu contextRenderSettings;
    private MenuItem displayMenuItem;
    private MenuItem regionIDMenuItem;
    private MenuItem regionBorderMenuItem;
    private MenuItem terrainMenuItem;
    private MenuItem terrainGlobalEdgesMenuItem;
    private MenuItem terrainInternalEdgesMenuItem;
    private MenuItem objectsMenuItem;
    private MenuItem objectGlobalEdgesMenuItem1;
    private MenuItem objectInternalEdgesMenuItem1;
    private MenuItem objectGroundMenuItem;
    private MenuItem terrainCellIDMenuItem;
    private MenuSplitterItem MenuSplitterItem1;
    private MenuItem terrainGlobalEdgeIDMenuItem;
    private MenuSplitterItem MenuSplitterItem2;
    private MenuItem terrainInternalEdgeIDMenuItem;
    private MenuItem objectCellIDMenuItem;
    private MenuSplitterItem MenuSplitterItem3;
    private MenuItem objectGlobalEdgeIDMenuItem;
    private MenuSplitterItem MenuSplitterItem4;
    private MenuItem objectInternalEdgeIDMenuItem;
    private MenuItem raycastMenuItem;
}
