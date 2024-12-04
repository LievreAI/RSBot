using RSBot.NavMeshApi.Mathematics;
using SkiaSharp;

namespace RSBot.Map.Renderer;

public static class GraphicsExtensions
{
    public static void DrawLine(this SKCanvas g, SKColor color, LineF line)
        => g.DrawLine(line.Min.X, line.Min.Z, line.Max.X, line.Max.Z, new SKPaint { Color = color });

    public static void DrawCircle(this SKCanvas g, SKColor color, CircleF circle)
        => g.DrawCircle(
            circle.Position.X - circle.Radius,
            circle.Position.Y - circle.Radius,
            circle.Radius * 2, new SKPaint { Color = color });

    public static void FillTriangleF(this SKCanvas g, SKColor brush, TriangleF triangle)
    {
        SKPoint[] points = new SKPoint[]
        {
            new SKPoint(triangle.P1.X, triangle.P1.Z),
            new SKPoint(triangle.P2.X, triangle.P2.Z),
            new SKPoint(triangle.P3.X, triangle.P3.Z)
        };

        SKPath path = new SKPath();
        path.MoveTo(points[0]); // İlk noktaya taşın
        for (int i = 1; i < points.Length; i++)
        {
            path.LineTo(points[i]); // Diğer noktalara çizgiler ekle
        }
        path.Close(); // Çokgeni kapat

        // SKPaint nesnesi oluştur ve dolgu rengini ayarla
        using (SKPaint paint = new SKPaint())
        {
            paint.Style = SKPaintStyle.Fill;
            paint.Color = brush; // Brush'ın rengini burada ayarlayın

            // Üçgeni doldur
            g.DrawPath(path, paint);
        }
    }

    public static void FillRectangleF(this SKCanvas g, SKColor brush, NavMeshApi.Mathematics.RectangleF rectangle)
    {
        SKPoint[] points = new SKPoint[]
        {
            new SKPoint(rectangle.TopLeft.X, 1920.0f - rectangle.TopLeft.Y),
            new SKPoint(rectangle.TopRight.X, 1920.0f - rectangle.TopRight.Y),
            new SKPoint(rectangle.BottomRight.X, 1920.0f - rectangle.BottomRight.Y),
            new SKPoint(rectangle.BottomLeft.X, 1920.0f - rectangle.BottomLeft.Y)
        };

        SKPath path = new SKPath();
        path.MoveTo(points[0]);
        for (int i = 1; i < points.Length; i++)
        {
            path.LineTo(points[i]);
        }
        path.Close();

        using (SKPaint paint = new SKPaint())
        {
            paint.Style = SKPaintStyle.Fill;
            paint.Color = brush;

            g.DrawPath(path, paint);
        }
    }
}
