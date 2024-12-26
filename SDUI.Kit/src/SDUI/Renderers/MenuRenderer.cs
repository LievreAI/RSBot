using System;
using System.Drawing;
using SkiaSharp;

namespace SDUI.Renderers
{
    /// <summary>
    /// Represents a class that can render a Menu.
    /// </summary>
    public class MenuRenderer : Renderer<Menu>
    {
        /// <inheritdoc/>
        protected override void Render (Menu control, PaintEventArgs e)
        {
            foreach (var item in control.Items)
                if (item is MenuSplitterItem msi)
                    RenderMenuSplitterItem (control, msi, e);
                else
                    RenderItem (control, item, e);
        }

        /// <summary>
        /// Renders a MenuItem.
        /// </summary>
        protected virtual void RenderItem (Menu control, MenuItem item, PaintEventArgs e)
        {
            if (!item.Visible)
                return;

            // Background
            var measrueText = TextMeasurer.MeasureText (item.Text, control);

            var padding = control.LogicalToDeviceUnits (item.Padding.Vertical);
            var background_color = item.Hovered || item.IsDropDownOpened ? Theme.ControlHighlightLowColor.Alpha (80) : Theme.BackgroundColor;
            e.Canvas.FillRoundedRectangle (item.Bounds.X, item.Bounds.Height / 2 - ((int)measrueText.Height + padding) / 2, item.Bounds.Width, (int)measrueText.Height + padding, background_color, 6, 6);

            // Text
            var font_color = item.Enabled ? Theme.ForegroundColor : Theme.ForegroundDisabledColor;
            var font_size = e.LogicalToDeviceUnits (Theme.FontSize);

            e.Canvas.DrawText (item.Text, Theme.UIFont, font_size, item.Bounds, font_color, ContentAlignment.MiddleCenter);
        }

        /// <summary>
        /// Renders a MenuSplitterItem.
        /// </summary>
        protected virtual void RenderMenuSplitterItem (Menu control, MenuSplitterItem item, PaintEventArgs e)
        {
            // Background
            e.Canvas.FillRectangle (item.Bounds, Theme.BackgroundColor);

            var center = item.Bounds.GetCenter ();
            var thickness = e.LogicalToDeviceUnits (1);
            var padding = e.LogicalToDeviceUnits (item.Padding);

            e.Canvas.DrawLine (center.X, item.Bounds.Top + padding.Top, center.X, item.Bounds.Bottom - padding.Bottom, item.Enabled ? Theme.ControlHighlightLowColor : Theme.ForegroundDisabledColor, thickness);
        }

        /// <summary>
        /// Gets the preferred size of a MenuItem.
        /// </summary>
        public virtual Size GetPreferredItemSize (Menu control, MenuItem item, Size proposedSize)
        {
            if (item is MenuSplitterItem msi)
                return GetPreferredSplitterItemSize (control, msi, proposedSize);

            var padding = control.LogicalToDeviceUnits (item.Padding.Horizontal);
            var font_size = control.LogicalToDeviceUnits (Theme.FontSize);
            var text_size = (int)Math.Round (TextMeasurer.MeasureText (item.Text, Theme.UIFont, font_size).Width);

            return new Size (text_size + padding, item.Bounds.Height);
        }

        /// <summary>
        /// Gets the preferred size of a MenuSplitterItem.
        /// </summary>
        protected virtual Size GetPreferredSplitterItemSize (Menu control, MenuSplitterItem item, Size proposedSize)
        {
            var padding = control.LogicalToDeviceUnits (item.Padding.Horizontal);
            var thickness = control.LogicalToDeviceUnits (1);

            return new Size (thickness + padding, item.Bounds.Height);
        }
    }
}
