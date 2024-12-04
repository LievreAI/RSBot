using RSBot.Core;
using RSBot.Core.Client;
using RSBot.Core.Client.ReferenceObjects;
using RSBot.Core.Components;
using RSBot.Core.Event;
using RSBot.Core.Extensions;
using RSBot.Core.Objects;
using RSBot.Core.Objects.Spawn;
using RSBot.Map.Renderer;
using RSBot.NavMeshApi.Dungeon;
using SDUI;
using SkiaSharp;
using SkiaSharp.HarfBuzz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

using Region = RSBot.Core.Objects.Region;

namespace RSBot.Map.Views;

[ToolboxItem(false)]
public partial class Main : Panel
{
    /// <summary>
    ///     The grid size
    /// </summary>
    private const int GridSize = 3;

    /// <summary>
    ///     The Sector Image Size
    /// </summary>
    private const int SectorSize = 256;

    /// <summary>
    ///     The cached Images
    /// </summary>
    private readonly Dictionary<string, SKBitmap> _cachedImages;

    /// <summary>
    ///     The current sector graphic
    /// </summary>
    private SKBitmap _currentSectorGraphic;

    /// <summary>
    ///     The X Sector identifier
    /// </summary>
    private byte _currentXSec;

    /// <summary>
    ///     The Y Sector identifier
    /// </summary>
    private byte _currentYSec;


    /// <summary>
    ///     The map points
    /// </summary>
    private SKBitmap[] _mapEntityImages;

    /// <summary>
    ///     The Zoom identifier
    /// </summary>
    private readonly float _scale = SectorSize / 192.0f;

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    private readonly NavMeshRenderer _navMeshRenderer;

    /// <summary>
    /// The region name
    /// </summary>
    private string _regionName;

    /// <summary>
    ///     Initializes a new instance of the <see cref="Main" /> class.
    /// </summary>
    public Main()
    {
        InitializeComponent();
        if (DesignMode)
            return;

        _cachedImages ??= new();

        EventManager.SubscribeEvent("OnEnterGame", OnEnterGame);

        // All
        comboViewType.SelectedIndex = 6;
        checkEnableCollisions.Checked = Kernel.EnableCollisionDetection;
        tabNavMeshViewer.Visible = Kernel.Debug;

        if (Kernel.Debug)
        {
            _navMeshRenderer = new NavMeshRenderer()
            {
                Dock = DockStyle.Fill,
            };

            panelNavMeshRendererCanvas.Controls.Add(_navMeshRenderer);
            labelSectorInfo.Visible = true;
        }
    }

    #region Core Handlers

    private void OnEnterGame()
    {
        _cachedImages.Clear();
        if (_mapEntityImages == null)
            _mapEntityImages = new[]
            {
                Game.MediaPk2.GetFile("interface\\minimap\\mm_sign_character.ddj").ToImage(),
                Game.MediaPk2.GetFile("interface\\minimap\\mm_sign_animal.ddj").ToImage(),
                Game.MediaPk2.GetFile("interface\\minimap\\mm_sign_npc.ddj").ToImage(),
                Game.MediaPk2.GetFile("interface\\minimap\\mm_sign_otherplayer.ddj").ToImage(),
                Game.MediaPk2.GetFile("interface\\minimap\\mm_sign_monster.ddj").ToImage(),
                Game.MediaPk2.GetFile("interface\\minimap\\mm_sign_unique.ddj").ToImage(),
                Game.MediaPk2.GetFile("interface\\minimap\\mm_sign_party.ddj").ToImage(),
                Game.MediaPk2.GetFile("interface\\minimap\\mm_sign_unique.ddj").ToImage()
            };
    }

    #endregion Core Handlers

    /// <summary>
    ///     Adds the grid item.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="type">The type.</param>
    /// <param name="level">The level.</param>
    /// <param name="position"></param>
    private void AddGridItem(string name, string type, byte level, Position position)
    {
        if (string.IsNullOrWhiteSpace(name))
            name = LanguageManager.GetLang("NoName");

        var item = new ListViewItem(name);
        item.SubItems.Add(type);
        item.SubItems.Add(level.ToString());
        item.SubItems.Add(position.ToString());
        lvMonster.Items.Add(item);
    }

    /// <summary>
    ///     Draws the point at.
    /// </summary>
    private void DrawPointAt(SKCanvas gfx, Position position, int entityIndex)
    {
        var distanceToPosition = position.DistanceToPlayer();
        if (distanceToPosition > 150)
            return;

        try
        {
            var x = GetMapX(position);
            var y = GetMapY(position);

            using var img = new SKBitmap(_mapEntityImages[entityIndex].Info);

            if (entityIndex == 0)
            {
                using var image = RotateImage(img, Geometry.RadianToDegree(Game.Player.Movement.Angle));
                gfx.DrawBitmap(image,
                    x - img.Width / 2,
                    y - img.Height / 2);
            }
            else
                gfx.DrawBitmap(img, x - img.Width / 2, y - img.Height / 2);
        }
        catch
        {
        }
    }

    private void DrawRectangleAt(SKCanvas gfx, Position position, SKColor brush, Size size, string label = "")
    {
        var distanceToPosition = position.DistanceToPlayer();
        if (distanceToPosition > 150)
            return;

        try
        {
            var x = GetMapX(position);
            var y = GetMapY(position);

            var paint = new SKPaint { Color = brush };
            if (!string.IsNullOrEmpty(label))
                gfx.DrawText(label, x + size.Width, y - size.Width / 2, paint);

            gfx.DrawRect(x, y, size.Width, size.Height, paint);
        }
        catch
        {
        }
    }

    private void DrawLineAt(SKCanvas gfx, Position source, Position destination, SKColor color)
    {
        var distanceToPositionA = source.DistanceToPlayer();
        var distanceToPositionB = destination.DistanceToPlayer();
        if (distanceToPositionA > 150 || distanceToPositionB > 150)
            return;

        var srcX = GetMapX(source);
        var srcY = GetMapY(source);
        var destinationX = GetMapX(destination);
        var destinationY = GetMapY(destination);

        using var paint = new SKPaint { Color = color };
        gfx.DrawLine(srcX, srcY, destinationX, destinationY, paint);
    }

    private void DrawCircleAt(SKCanvas gfx, Position position, SKColor color, int diameter)
    {
        var distanceToPosition = position.DistanceToPlayer();
        if (distanceToPosition > 150)
            return;

        try
        {
            var x = GetMapX(position);
            var y = GetMapY(position);

            using var brush = new SKPaint { Color = color, IsAntialias = true };

            var diameterF = diameter * _scale;
            var point = new SKPoint(x - diameterF / 2, y - diameterF / 2);

            gfx.DrawCircle(point, diameterF, brush);

            gfx.DrawCircle(point.X, point.Y, diameterF, brush);
        }
        catch
        {
        }
    }

    /// <summary>
    ///     Fills the grid.
    /// </summary>
    private void PopulateMapAndGrid(SKCanvas graphics)
    {
        lvMonster.Items.Clear();

        try
        {
            if (Game.Player.Movement.HasDestination)
            {
                DrawLineAt(graphics, Game.Player.Movement.Source, Game.Player.Movement.Destination, SKColors.BlanchedAlmond);

                DrawCircleAt(graphics, Game.Player.Movement.Destination, SKColors.PaleGreen, 4);
            }

            //Draw walk script
            if (ScriptManager.Running)
            {
                var walkScript = ScriptManager.GetWalkScript();
                for (var i = 0; i < walkScript.Count; i++)
                {
                    var nextPosition = walkScript[i];

                    DrawLineAt(graphics, i != 0 ? walkScript[i - 1] : nextPosition, nextPosition, SKColors.LightBlue);
                    DrawCircleAt(graphics, nextPosition, SKColors.CornflowerBlue.Alpha(150), 4);
                }
            }

            if (Kernel.Bot.Running)
            {
                var position = Kernel.Bot.Botbase.Area.Position;
                var radius = Kernel.Bot.Botbase.Area.Radius;

                DrawCircleAt(graphics, position, SKColors.DarkRed.Alpha(100), radius * 2);
                DrawCircleAt(graphics, position, SKColors.LawnGreen.Alpha(50), radius);
            }

            if (comboViewType.SelectedIndex == 0 || comboViewType.SelectedIndex == 6)
                if (SpawnManager.TryGetEntities<SpawnedMonster>(out var monsters))
                    foreach (var entry in monsters)
                    {
                        AddGridItem(entry.Record.GetRealName(), entry.Rarity.GetName(),
                            entry.Record.Level, entry.Movement.Source);

                        if (Game.SelectedEntity?.UniqueId == entry.UniqueId)
                            DrawCircleAt(graphics, entry.Position, SKColors.Wheat.Alpha(100), 6);

                        if (entry.Rarity == MonsterRarity.Unique || entry.Rarity == MonsterRarity.Unique2)
                            DrawPointAt(graphics, entry.Position, 5);
                        else
                            DrawPointAt(graphics, entry.Position, 4);
                    }

            if (comboViewType.SelectedIndex == 4 || comboViewType.SelectedIndex == 6)
                if (SpawnManager.TryGetEntities<SpawnedCos>(out var coses))
                    foreach (var entry in coses)
                        // Avoid painting vehicles from main player
                        if (Game.Player.Vehicle?.UniqueId != entry.UniqueId)
                        {
                            AddGridItem(entry.Name, "Pet", entry.Record.Level, entry.Movement.Source);
                            DrawPointAt(graphics, entry.Movement.Source, 1);
                        }

            if (comboViewType.SelectedIndex == 2 || comboViewType.SelectedIndex == 6)
                if (Game.Party != null && Game.Party.Members != null)
                    foreach (var member in Game.Party.Members.ToArray())
                    {
                        if (Game.Player.Position.DistanceTo(member.Position) > 50)
                            continue;

                        if (member.Name == Game.Player.Name)
                            continue;

                        DrawPointAt(graphics, member.Position, 6);
                        AddGridItem(member.Name, "Party Member", member.Level, member.Position);
                    }

            if (comboViewType.SelectedIndex == 1 || comboViewType.SelectedIndex == 6)
                if (SpawnManager.TryGetEntities<SpawnedPlayer>(out var players))
                    foreach (var entry in players)
                    {
                        if (Game.Party != null && Game.Party.Members != null &&
                            Game.Party.GetMemberByName(entry.Name) != null)
                            return;

                        AddGridItem(entry.Name, "Player", 0, entry.Movement.Source);
                        DrawPointAt(graphics, entry.Movement.Source, 3);
                    }

            if (comboViewType.SelectedIndex == 3 || comboViewType.SelectedIndex == 6)
                if (SpawnManager.TryGetEntities<SpawnedNpcNpc>(out var npcs))
                    foreach (var entry in npcs)
                    {
                        AddGridItem(entry.Record.GetRealName(), entry.UniqueId.ToString(),
                            entry.Record.Level, entry.Movement.Source);
                        DrawPointAt(graphics, entry.Movement.Source, 2);
                    }

            if (comboViewType.SelectedIndex == 5 || comboViewType.SelectedIndex == 6)
                if (SpawnManager.TryGetEntities<SpawnedPortal>(out var portals))
                    foreach (var entry in portals)
                    {
                        AddGridItem(entry.Record.GetRealName(), "Teleport", 0, entry.Movement.Source);
                        DrawPointAt(graphics, entry.Movement.Source, 7);
                    }
        }
        catch (Exception ex)
        {
            Log.Debug($"[Map] Render error: {ex.Message}");
        }
    }

    private SKBitmap LoadSectorImage(string sectorImgName)
    {
        if (_cachedImages.ContainsKey(sectorImgName))
            return new SKBitmap(_cachedImages[sectorImgName].Info);

        if (Game.MediaPk2.FileExists(sectorImgName) && Game.MediaPk2.TryGetFile(sectorImgName, out var file))
        {
            var img = file.ToImage();
            _cachedImages.Add(sectorImgName, img);

            return new SKBitmap(_cachedImages[sectorImgName].Info);
        }

        return new SKBitmap(SectorSize, SectorSize);
    }


    /// <summary>
    ///     Redraw the map image
    /// </summary>
    private void RedrawMap()
    {
        // Set layer path & sectors
        var p = Game.Player.Movement.Source;

        var tempX = p.Region.X;
        var tempY = p.Region.Y;

        if (p.Region.IsDungeon)
        {
            tempX = p.GetSectorFromOffset(p.XOffset);
            tempY = p.GetSectorFromOffset(p.YOffset);
        }

        if (tempX == _currentXSec && tempY == _currentYSec)
            return;

        _currentXSec = tempX;
        _currentYSec = tempY;

        if (_cachedImages.Count >= 25)
            _cachedImages.Clear();

        try
        {
            _currentSectorGraphic = new SKBitmap(SectorSize * 3, SectorSize * 3);
            using var canvas = new SKCanvas(_currentSectorGraphic);
            canvas.Clear(SKColors.Transparent);
            canvas.DrawCircle(400, 300, 100, new SKPaint { Color = SKColors.Blue });

            var floorName = string.Empty;
            var dungeonName = string.Empty;
            if (p.Region.IsDungeon)
            {
                if (!p.TryGetNavMeshTransform(out var pTransform))
                    return;

                if (pTransform.Instance is not NavMeshInstBlock dungeonBlock)
                    return;

                if (dungeonBlock.Parent is not NavMeshDungeon dungeon)
                    return;

                floorName = dungeon.FloorStringIDs[dungeonBlock.FloorIndex]; //e.g "DH_A01_FLOOR01"
                var roomName = dungeon.RoomStringIDs[dungeonBlock.RoomIndex];
                var roomNameTranslated = Game.ReferenceManager.GetTranslation(roomName);

                _regionName = roomNameTranslated;
                dungeonName = RegionInfoManager.GetDungeonName(p.Region);
            }
            else
                _regionName = Game.ReferenceManager.GetTranslation(Game.Player.Position.Region.ToString());

            for (byte x = 0; x < GridSize; x++)
            {
                for (byte z = 0; z < GridSize; z++)
                {
                    var xSector = (byte)(_currentXSec + x - 1);
                    var ySector = (byte)(_currentYSec + z - 1);

                    var sectorImgName = GetMinimapFileName(new Region(xSector, ySector), dungeonName, floorName);
                    using var bitmap = LoadSectorImage(sectorImgName);
                    var pos = new SKPoint(bitmap.Width * x, bitmap.Height * (GridSize - 1 - z));

                    canvas.DrawBitmap(bitmap, pos);

                    if (Kernel.Debug)
                    {
                        using var paint = new SKPaint { Color = SKColors.Black };
                        canvas.DrawRect(pos.X, pos.Y, SectorSize, SectorSize, paint);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Log.Warn($"Error in minimap: {e.Message}");
        }
    }
    private string GetMinimapFileName(Region region, string dungeonName, string floorName)
    {
        if (!string.IsNullOrWhiteSpace(dungeonName) && !string.IsNullOrWhiteSpace(floorName))
        {
            return $"minimap_d\\{dungeonName}\\{floorName}_{region.X}x{region.Y}.ddj";
        }

        return $"minimap\\{region.X}x{region.Y}.ddj";
    }

    private SKBitmap RotateImage(SKBitmap image, float angle)
    {
        var sizedBitmap = new SKBitmap(image.Width + 1, image.Height + 1);

        using (var canvas = new SKCanvas(sizedBitmap))
        {
            canvas.Clear(SKColors.Transparent);

            SKMatrix rotationMatrix = SKMatrix.CreateRotationDegrees(
                angle,
                (image.Width + 1) / 2f,
                (image.Height + 1) / 2f
            );

            canvas.SetMatrix(rotationMatrix);
            canvas.DrawBitmap(image, 1, 1);
            canvas.Flush();
        }

        // Görüntüyü ters çevirmek (flip) için
        using (var flippedBitmap = new SKBitmap(sizedBitmap.Width, sizedBitmap.Height))
        using (var canvas = new SKCanvas(flippedBitmap))
        {
            // Y ekseni üzerinde Flip (ters çevir)
            SKMatrix flipMatrix = SKMatrix.CreateScale(1, -1, 0, sizedBitmap.Height / 2f);
            canvas.SetMatrix(flipMatrix);

            // Dönüştürülmüş bitmap'i çiz
            canvas.DrawBitmap(sizedBitmap, 0, 0);

            // Sonuç bitmap'i döndür
            return flippedBitmap;
        }
    }


    private void DrawObjects(SKCanvas graphics)
    {
        if (_currentSectorGraphic != null)
        {
            //graphics.InterpolationMode = InterpolationMode.Bicubic;
            //graphics.SmoothingMode = SmoothingMode.HighSpeed;
            //graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            //graphics.CompositingQuality = CompositingQuality.HighSpeed;

            SKPoint point = new()
            {
                X = mapCanvas.Width / 2f - SectorSize - Game.Player.Movement.Source.XSectorOffset / 10f * _scale,
                Y = mapCanvas.Height / 2f - SectorSize * 2f + Game.Player.Movement.Source.YSectorOffset / 10f * _scale
            };

            graphics.DrawBitmap(_currentSectorGraphic, point);

            PopulateMapAndGrid(graphics);
            DrawPointAt(graphics, Game.Player.Movement.Source, 0);
        }
    }

    private void trmInterval_Tick(object sender, EventArgs e)
    {
        if (Game.Player == null)
            return;

        if (!Visible)
            return;

        if (Kernel.Debug)
            labelSectorInfo.Text =
                $"{Game.Player.Movement.Source.Region} ({Game.Player.Movement.Source.Region.X}x{Game.Player.Movement.Source.Region.Y})";

        mapCanvas.Invalidate();
    }

    private void checkBoxAutoSelectUniques_CheckedChanged(object sender, EventArgs e)
    {
        PlayerConfig.Set("RSBot.Map.AutoSelectUnique", checkBoxAutoSelectUniques.Checked);
        timerUniqueChecker.Enabled = checkBoxAutoSelectUniques.Checked;
    }

    private void timerUniqueChecker_Tick(object sender, EventArgs e)
    {
        if (!checkBoxAutoSelectUniques.Checked)
            return;

        if (Kernel.Bot.Running)
            return;

        if (Game.SelectedEntity?.Record.Rarity == ObjectRarity.ClassD)
            return;

        if (SpawnManager.TryGetEntity<SpawnedMonster>(
                p => p.Record.Rarity == ObjectRarity.ClassD || p.Record.Rarity == ObjectRarity.ClassI,
                out var uniqueEntity))
            uniqueEntity.TrySelect();
    }

    private float GetMapX(Position gamePosition)
    {
        return mapCanvas.Width / 2f + (gamePosition.X - Game.Player.Movement.Source.X) * _scale;
    }

    private float GetMapY(Position gamePosition)
    {
        return mapCanvas.Height / 2f + (gamePosition.Y - Game.Player.Movement.Source.Y) * _scale * -1.0f;
    }

    private void mapCanvas_MouseClick(object sender, MouseEventArgs e)
    {
        if (!Game.Ready) return;

        var position = Game.Player.Movement.Source;
        position.XOffset = Game.Player.Movement.Source.XOffset +
                           (mapCanvas.Width / 2f - e.X) / SectorSize * 192f * 10 * -1f;
        position.YOffset = Game.Player.Movement.Source.YOffset + (mapCanvas.Height / 2f - e.Y) / SectorSize * 192f * 10;

        Game.Player.MoveTo(position, false);
    }

    private void checkEnableCollisions_CheckedChanged(object sender, EventArgs e)
    {
        Kernel.EnableCollisionDetection = checkEnableCollisions.Checked;
    }

    /// <summary>
    ///     Occurs before Main form is displayed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Main_Load(object sender, EventArgs e)
    {
        checkBoxAutoSelectUniques.Checked = PlayerConfig.Get("RSBot.Map.AutoSelectUnique", false);
        timerUniqueChecker.Enabled = checkBoxAutoSelectUniques.Checked;
    }

    private void btnNvmResetToPlayer_Click(object sender, EventArgs e)
    {
        if (Game.Player.Position.TryGetNavMeshTransform(out var playerTransform))
            _navMeshRenderer?.Update(playerTransform);
    }

    private void tabMinimap_Paint(object sender, PaintEventArgs e)
    {
        RedrawMap();
        DrawObjects(e.Canvas);

        var text = Game.Player.Position.ToString();

        var measuredText = TextMeasurer.MeasureText(text, mapCanvas);

        var x = mapCanvas.Width - measuredText.Width;

        using var bPaint = new SKPaint { Color = SKColors.Black };
        using var wPaint = new SKPaint { Color = SKColors.White };

        e.Canvas.DrawText(_regionName, 10, 5, bPaint);
        e.Canvas.DrawText(text, x - 8, 21 - measuredText.Height / 2, bPaint);
        e.Canvas.DrawText(text, x - 10, 20 - measuredText.Height / 2, wPaint);
    }
}