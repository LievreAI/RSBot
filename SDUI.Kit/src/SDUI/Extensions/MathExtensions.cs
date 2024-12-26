using System;
using System.Collections.Generic;
using System.Text;

namespace SDUI
{
    static class MathExtensions
    {
        public static int Clamp (this int value, int minimum, int maximum)
        {
            value = Math.Min (value, maximum);
            value = Math.Max (value, minimum);

            return value;
        }

        public static long Clamp (this long value, long minimum, long maximum)
        {
            value = Math.Min (value, maximum);
            value = Math.Max (value, minimum);

            return value;
        }
    }
}
