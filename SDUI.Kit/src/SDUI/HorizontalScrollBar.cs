﻿using System;
using System.Drawing;

namespace SDUI
{
    /// <summary>
    /// Represents a HorizontalScrollBar control.
    /// </summary>
    public class HorizontalScrollBar : ScrollBar
    {
        /// <summary>
        /// Initializes a new instance of the HorizontalScrollBar class.
        /// </summary>
        public HorizontalScrollBar ()
        {
        }

        /// <inheritdoc/>
        protected override Size DefaultSize => new Size (80, 15);
    }
}
