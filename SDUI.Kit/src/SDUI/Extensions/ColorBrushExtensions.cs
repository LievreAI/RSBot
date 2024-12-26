using System.Drawing.Drawing2D;
using SkiaSharp;

namespace System.Drawing;

public static class ColorExtentions
{
    public static SKColor Determine(this SKColor color)
    {
        byte value = 0;

        var luminance = (0.299 * color.Red + 0.587 * color.Green + 0.114 * color.Blue) / 255;

        if (luminance > 0.5)
            value = 0; // bright colors - black font
        else
            value = 255; // dark colors - white font

        return new SKColor(value, value, value);
    }

    public static Color Determine (this Color color)
    {
        var value = 0;

        double luminance = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;

        if (luminance > 0.5)
            value = 0; // bright colors - black font
        else
            value = 255; // dark colors - white font

        return Color.FromArgb (value, value, value);
    }

    /// <summary>
    /// Creates color with corrected brightness.
    /// </summary>
    /// <param name="color">Color to correct.</param>
    /// <param name="correctionFactor">The brightness correction factor. Must be between -1 and 1. 
    /// Negative values produce darker colors.</param>
    /// <returns>
    /// Corrected <see cref="Color"/> structure.
    /// </returns>
    public static Color Brightness(this Color color, float correctionFactor)
    {
        float red = (float)color.R;
        float green = (float)color.G;
        float blue = (float)color.B;

        if (correctionFactor < 0)
        {
            correctionFactor = 1 + correctionFactor;
            red *= correctionFactor;
            green *= correctionFactor;
            blue *= correctionFactor;
        }
        else
        {
            red = (255 - red) * correctionFactor + red;
            green = (255 - green) * correctionFactor + green;
            blue = (255 - blue) * correctionFactor + blue;
        }

        return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
    }

    /// <summary>
    /// Is the color dark <c>true</c>; otherwise <c>false</c>
    /// </summary>
    /// <param name="color">The color</param>
    public static bool IsDark(this SKColor color)
    {
        return (384 - color.Red - color.Green - color.Blue) > 0;
    }

    /// <summary>
    /// Set alpha value for this color
    /// </summary>
    /// <param name="color">The color</param>
    /// <param name="alpha">The alpha</param>
    public static SKColor Alpha(this SKColor color, byte alpha)
    {
        return new SKColor (color.Red, color.Green, color.Blue, alpha);
    }

    /// <summary>
    /// Removes the alpha component of a color.
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    public static SKColor RemoveAlpha (this SKColor color)
    {
        return new SKColor(color.Red, color.Green, color.Blue);
    }


    /// <summary>
    /// Removes the alpha component of a color.
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    public static Color RemoveAlpha (this Color color)
    {
        return Color.FromArgb (color.R, color.G, color.B);
    }

    public static SKColor BlendWith (this Color backgroundColor, Color frontColor, double blend)
    {
        double ratio = blend / 255d;
        double invRatio = 1d - ratio;
        var r = (byte)((backgroundColor.R * invRatio) + (frontColor.R * ratio));
        var g = (byte)((backgroundColor.G * invRatio) + (frontColor.G * ratio));
        var b = (byte)((backgroundColor.B * invRatio) + (frontColor.B * ratio));
        return new SKColor(r, g, b, (byte)Math.Abs (frontColor.A - backgroundColor.A));
    }
}
