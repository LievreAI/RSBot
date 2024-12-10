using HarfBuzzSharp;
using RSBot.Core.Extensions;
using RSBot.NavMeshApi;
using RSBot.NavMeshApi.Dungeon;
using RSBot.NavMeshApi.Mathematics;
using RSBot.NavMeshApi.Object;
using RSBot.NavMeshApi.Terrain;
using SDUI;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;


namespace RSBot.Map.Renderer;

public partial class NavMeshRenderer : Panel
{
    private bool _isDragging;
    private SKPoint _dragPosition;

    private NavMeshTransform _transform;
    private NavMeshTransform _mouseTransform;
    private NavMeshRaycastHit? _hit = null;

    private readonly SKFont _font;
    private readonly SKFont _smallFont;

    private float _zoom = 1.0f;

    private bool _drawRegionId = true;
    private bool _drawRegionBorder = true;
    private bool _drawTerrainGlobalEdges = true;
    private bool _drawTerrainInternalEdges = true;
    private bool _drawObjectGlobalEdges = true;
    private bool _drawObjectInternalEdges = true;
    private bool _drawObjectGround = true;

    private bool _drawTerrainCellID = false;
    private bool _drawTerrainGlobalEdgeID = false;
    private bool _drawTerrainInternalEdgeID = false;
    private bool _drawObjectCellID = false;
    private bool _drawObjectGlobalEdgeID = false;
    private bool _drawObjectInternalEdgeID = false;

    private bool _raycastVisualizer = false;

    public NavMeshRenderer()
    {
        this.InitializeComponent();

        if (this.DesignMode)
            return;

        _font = new(SKTypeface.FromFamilyName("Arial", 64, 32, SKFontStyleSlant.Upright));
        _smallFont = new(SKTypeface.FromFamilyName("Arial", 32, 16, SKFontStyleSlant.Upright));
        _transform = new NavMeshTransform(Vector3.Zero);
        _mouseTransform = new NavMeshTransform(Vector3.Zero);
    }

    public void Update(NavMeshTransform transform)
    {
        if (_transform != null && transform.Position.Distance(_transform.Position) < 1)
            return;

        _transform = transform;
        _mouseTransform = new NavMeshTransform(Vector3.Zero);

        this.Invalidate();
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        e.Canvas.Clear(SKColors.Black);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (_transform?.Region == 0u)
            return;

        var g = e.Canvas;

        var matrix = new SKMatrix();
        matrix.ScaleX = this.Width / 1920.0f * _zoom;
        matrix.ScaleY = this.Height / 1920.0f * _zoom;
        matrix.TransX = 960.0f - _transform.Offset.X;
        matrix.TransY = 960 - _transform.Offset.Z;
        g.SetMatrix(matrix);

        var set = new HashSet<int>();

        if (_transform.Region.IsDungeon)
        {
            if (!NavMeshManager.TryGetNavMeshDungeon(_transform.Region, out var dungeon))
                return;

            this.DrawNavMeshDungeon(set, g, dungeon);
        }
        else
        {
            for (int rz = _transform.Region.Z - 1; rz < _transform.Region.Z + 2; rz++)
            {
                for (int rx = _transform.Region.X - 1; rx < _transform.Region.X + 2; rx++)
                {
                    var rid = new RID((byte)rx, (byte)rz);
                    if (!NavMeshManager.TryGetNavMeshTerrain(rid, out var terrain))
                        continue;

                    foreach (var edge in terrain.GlobalEdges)
                        edge.Link();

                    this.DrawTerrain(set, g, terrain);
                }
            }
        }

        var localMouseOffset = RID.Transform(_mouseTransform.Offset, _transform.Region, _mouseTransform.Region);
        if (_raycastVisualizer)
        {
            g.DrawLine(_transform.Offset.X, _transform.Offset.Z, localMouseOffset.X, localMouseOffset.Z, SKColors.White);
            if (_hit != null)
            {
                var localHitOffset = RID.Transform(_hit.Position, _transform.Region, _hit.Region);
                g.DrawLine(_transform.Offset.X, _transform.Offset.Z, localHitOffset.X, localHitOffset.Z, SKColors.Red);
            }
        }

        matrix.Invert();
       
        g.ResetMatrix();

        g.DrawText($"Player: {_transform}", Rectangle.Empty, this, SDUI.ContentAlignment.TopLeft);
        g.DrawText($"Cursor: {_mouseTransform}", new Rectangle(new Point(0, 12), Size.Empty), this, SDUI.ContentAlignment.TopLeft);


        if (_hit != null)
            g.DrawText($"Hit: {_hit}", new Rectangle(new Point(0, 12), Size.Empty), this, SDUI.ContentAlignment.TopLeft, selectionColor: SKColors.Red);
    }

    private void DrawNavMeshDungeon(HashSet<int> set, SKCanvas g, NavMeshDungeon dungeon)
    {
        if (_transform.Instance is not NavMeshInstBlock currentBlock)
            return;

        foreach (var block in dungeon.Blocks.Where(b => b.FloorIndex == currentBlock.FloorIndex))
        {
            var blockMatrix = new SKMatrix();
            blockMatrix = SKMatrix.CreateRotation(block.Yaw * (180.0f / MathF.PI), block.LocalPosition.X, block.LocalPosition.Z);
            blockMatrix.TransX = block.LocalPosition.X;
            blockMatrix.TransY = block.LocalPosition.Z;
            g.SetMatrix(blockMatrix);

            this.DrawNavMeshObj(g, block.ID, block.NavMeshObj);
            g.ResetMatrix();
            blockMatrix.Invert();

            g.SetMatrix(blockMatrix);

            set.Add(block.ID);

            foreach (var obj in block.ObjectList)
                g.DrawCircle(obj.Circle.Position.X, obj.Circle.Position.Y, obj.Circle.Radius, new SKPaint() { Color = SKColors.Red });
        }
    }

    private void DrawTerrain(HashSet<int> set, SKCanvas g, NavMeshTerrain terrain)
    {
        var dx = (terrain.Region.X - _transform.Region.X) * RID.Width;
        var dz = (terrain.Region.Z - _transform.Region.Z) * RID.Length;

        var matrix = SKMatrix.CreateTranslation(dx, dz);
        g.SetMatrix(matrix);

        if (_drawRegionBorder)
            g.DrawRectangle(0, 0, 1920 - 1, 1920 - 1, SKColors.Magenta);

        using var skPaint = new SKPaint()
        {
            Color = SKColors.White,
        };

        if (_drawTerrainCellID)
        {

            foreach (var cell in terrain.Cells)
                g.DrawText($"{cell}", cell.RectangleF.Center.X, cell.RectangleF.Center.Y, _smallFont, skPaint);
        }

        if (_drawTerrainGlobalEdges)
        {
            foreach (var edge in terrain.GlobalEdges)
            {
                var pen = edge.Flag.ToPen();
                g.DrawLine(pen, edge.Line);

                if (_drawTerrainGlobalEdgeID)
                    g.DrawText($"{edge}", edge.Line.Center.X, edge.Line.Center.Y, _smallFont, skPaint);
            }
        }

        if (_drawTerrainInternalEdges)
        {
            foreach (var edge in terrain.InternalEdges)
            {
                var pen = edge.Flag.ToPen();
                g.DrawLine(pen, edge.Line);

                if (_drawTerrainInternalEdgeID)
                    g.DrawText($"{edge}", edge.Line.Center.X, edge.Line.Center.Y, _smallFont, skPaint);
            }
        }

        foreach (var obj in terrain.Instances)
        {
            if (set.Contains(obj.WorldUID))
                continue;

            var objMatrix = SKMatrix.CreateRotation(obj.Yaw * (180.0f / MathF.PI), obj.LocalPosition.X, obj.LocalPosition.Z);
            g.SetMatrix(objMatrix);

            this.DrawNavMeshObj(g, obj.WorldUID, obj.NavMeshObj);
            g.ResetMatrix();

            objMatrix.Invert();
            g.SetMatrix(objMatrix);

            set.Add(obj.WorldUID);
        }

        if (_drawRegionId)
            g.DrawText($"{terrain.Region}", 0,0, _smallFont, skPaint);

        matrix.Invert();
        g.SetMatrix(matrix);
    }

    private void DrawNavMeshObj(SKCanvas g, int id, NavMeshObj obj)
    {
        using var skPaint = new SKPaint()
        {
            Color = SKColors.White,
        };

        if (_drawObjectGround)
        {
            foreach (var cell in obj.Cells)
            {
                g.FillTriangleF(id.ToColor(), cell.Triangle);

                if (_drawObjectCellID)
                {
                    string label;
                    if (cell.EventZone == NavMeshEventZone.Empty)
                        label = $"{cell}";
                    else
                        label = $"{cell} [{obj.Events[cell.EventZone.Index]}, {cell.EventZone.Flag}]";


                    g.DrawText(label, cell.Triangle.Center.X, cell.Triangle.Center.Y, _smallFont, skPaint);
                }
            }
        }

        if (_drawObjectGlobalEdges)
        {
            foreach (var edge in obj.GlobalEdges)
            {
                g.DrawLine(edge.Flag.ToPen(), edge.Line);

                if (_drawObjectGlobalEdgeID)
                {
                    string label;
                    if (edge.EventZone == NavMeshEventZone.Empty)
                        label = $"{edge}";
                    else
                        label = $"{edge} [{obj.Events[edge.EventZone.Index]}, {edge.EventZone.Flag}]";

                    g.DrawText(label, edge.Line.Center.X, edge.Line.Center.Y, _smallFont, skPaint);
                }

            }

        }

        if (_drawObjectInternalEdges)
        {
            foreach (var edge in obj.InternalEdges)
            {
                g.DrawLine(edge.Flag.ToPen(), edge.Line);

                if (_drawObjectInternalEdgeID)
                {
                    string label;
                    if (edge.EventZone == NavMeshEventZone.Empty)
                        label = $"{edge}";
                    else
                        label = $"{edge} [{obj.Events[edge.EventZone.Index]}, {edge.EventZone.Flag}]";

                    g.DrawText(label, edge.Line.Center.X, edge.Line.Center.Y, _smallFont, skPaint);
                }
            }
        }
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
        base.OnMouseWheel(e);

        if (_raycastVisualizer)
            return;

        _zoom += e.Delta.X * 0.001f;

        if (_zoom < 0.5)
            _zoom = 0.5f;

        if (_zoom > 1.5)
            _zoom = 2;

        this.Invalidate();
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);

        if (_isDragging)
        {
            var dx = _dragPosition.X - e.X;
            var dy = _dragPosition.Y - e.Y;
            _dragPosition = new SKPoint(e.Location.X, e.Location.Y);

            _transform.Offset += new Vector3(dx * (RID.Width / this.Width), 0, dy * (RID.Length / this.Height));
            _transform.Normalize();
            _hit = null;
        }

        _mouseTransform.Region = _transform.Region;
        _mouseTransform.Offset = new Vector3(_transform.Offset.X - 960.0f + (e.X * (RID.Width / this.Width)), 0.0f, _transform.Offset.Z - 960.0f + (e.Y * (RID.Length / this.Height)));
        _mouseTransform.Normalize();

        NavMeshManager.ResolveCellAndHeight(_transform);
        NavMeshManager.ResolveCellAndHeight(_mouseTransform);

        this.Invalidate();
    }

    protected async override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);

        if (e.Button == MouseButtons.Left && _raycastVisualizer)
        {
            try
            {
                this.Raycast();
            }
            catch (Exception ex)
            {
                await MessageBox.Show(this, ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        if (e.Button == MouseButtons.Right)
            contextRenderSettings.Show(this, e.Location);

        if (e.Button == MouseButtons.Middle)
        {
            _dragPosition = new SKPoint(e.Location.X, e.Location.Y);
            _isDragging = true;
        }
    }
    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);

        if (e.Button == MouseButtons.Middle)
            _isDragging = false;
    }

    private void Raycast()
    {
        _hit = null;
        var source = new NavMeshTransform(_transform);
        var destination = new NavMeshTransform(_mouseTransform);

        if (!NavMeshManager.Raycast(source, destination, NavMeshRaycastType.Move, out NavMeshRaycastHit? hit) && hit != null)
        {
            _hit = hit;
            return;
        }
    }

    private void regionIDMenuItem_CheckedChange(object sender, EventArgs e)
    {
        _drawRegionId = regionIDMenuItem.Checked;
        this.Invalidate();
    }

    private void regionBorderMenuItem_CheckedChange(object sender, EventArgs e)
    {
        _drawRegionBorder = regionBorderMenuItem.Checked;
        this.Invalidate();
    }

    private void globalEdgesMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        _drawTerrainGlobalEdges = terrainGlobalEdgesMenuItem.Checked;
        this.Invalidate();
    }

    private void internalEdgesMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        _drawTerrainInternalEdges = terrainInternalEdgesMenuItem.Checked;
        this.Invalidate();
    }

    private void globalEdgesMenuItem1_CheckedChanged(object sender, EventArgs e)
    {
        _drawObjectGlobalEdges = objectGlobalEdgesMenuItem1.Checked;
        this.Invalidate();
    }

    private void internalEdgesMenuItem1_CheckedChanged(object sender, EventArgs e)
    {
        _drawObjectInternalEdges = objectInternalEdgesMenuItem1.Checked;
        this.Invalidate();
    }

    private void groundMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        _drawObjectGround = objectGroundMenuItem.Checked;
        this.Invalidate();
    }

    private void terrainCellIDMenuItem_Click(object sender, EventArgs e)
    {
        _drawTerrainCellID = terrainCellIDMenuItem.Checked;
        this.Invalidate();
    }

    private void terrainGlobalEdgeIDMenuItem_Click(object sender, EventArgs e)
    {
        _drawTerrainGlobalEdgeID = terrainGlobalEdgeIDMenuItem.Checked;
        this.Invalidate();
    }

    private void terrainInternalEdgeIDMenuItem_Click(object sender, EventArgs e)
    {
        _drawTerrainInternalEdgeID = terrainInternalEdgeIDMenuItem.Checked;
        this.Invalidate();
    }

    private void objectCellIDMenuItem_Click(object sender, EventArgs e)
    {
        _drawObjectCellID = objectCellIDMenuItem.Checked;
        this.Invalidate();
    }

    private void objectGlobalEdgeIDMenuItem_Click(object sender, EventArgs e)
    {
        _drawObjectGlobalEdgeID = objectGlobalEdgeIDMenuItem.Checked;
        this.Invalidate();
    }

    private void objectInternalEdgeIDMenuItem_Click(object sender, EventArgs e)
    {
        _drawObjectInternalEdgeID = objectInternalEdgeIDMenuItem.Checked;
        this.Invalidate();
    }

    private void raycastMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        _raycastVisualizer = raycastMenuItem.Checked;
        _zoom = 1;

        this.Invalidate();
    }
}
