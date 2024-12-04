using RSBot.NavMeshApi.Edges;
using SkiaSharp;
using System.Drawing;

namespace RSBot.Map.Renderer;

public static class NavMeshExtenions
{
    public static SKColor ToPen(this NavMeshEdgeFlag flag)
    {
        if ((flag & NavMeshEdgeFlag.Blocked) != 0)
            return SKColors.Red;

        if ((flag & NavMeshEdgeFlag.Railing) != 0)
            return SKColors.Blue;

        return SKColors.Lime;
    }

    internal static SKColor ToColor(this int i)
    {
        // https://discussions.unity.com/t/how-can-i-get-the-pre-defined-color-of-a-navmesh-area/193595/3
        static int Bit(int a, int b) => (a & 1 << b) >> b;

        if (i == 0)
            return new SKColor(0, 192, 255, 128);

        int r = (Bit(i, 4) + Bit(i, 1) * 2 + 1) * 63;
        int g = (Bit(i, 3) + Bit(i, 2) * 2 + 1) * 63;
        int b = (Bit(i, 5) + Bit(i, 0) * 2 + 1) * 63;
        return new SKColor((byte)r, (byte)g, (byte)b, 128);
    }
}
