using System;
using System.Drawing;
using System.IO;
using RSBot.Core.Client;
using RSBot.FileSystem;
using SkiaSharp;

namespace RSBot.Core.Extensions;

public static class Pk2Extensions
{
    /// <summary>
    ///     Gets the stream from a DDJ file in the Pk2 archive and converts the DDS Format to System.Image.
    /// </summary>
    /// <param name="file">The archive.</param>
    /// <returns></returns>
    public static SKBitmap ToImage(this IFile file)
    {
        var ddjBuffer = file.OpenRead().ReadAllBytes();

        try
        {
            var ddsBuffer = new byte[ddjBuffer.Length - 20];
            Array.ConstrainedCopy(ddjBuffer, 20, ddsBuffer, 0, ddjBuffer.Length - 20); //Cuts the first 20 bytes.
            using var memory = new MemoryStream(ddsBuffer);
            return SKBitmap.FromImage(SKImage.FromEncodedData(memory));
        }
        catch
        {
            return new SKBitmap(16, 16);
        }
    }
}