using System;
using System.Collections.Generic;
using System.Drawing;
using SkiaSharp;

namespace SDUI
{
    /// <summary>
    /// Represents a ListViewItem.
    /// </summary>
    public class ListViewGroup : ListViewItem
    {
        public string Header;

        public ListViewGroup (string text) :base(text) { Text = text; }
        public ListViewGroup () { }

        public List<ListViewItem> Items { get; set; } = new ();
    }

    /// <summary>
    /// Represents a ListViewItem.
    /// </summary>
    public class ListViewSubItem : ListViewItem
    {

    }

    public class ListViewItem : ICloneable
    {
        public SKTextAlign TextAlign {  get; set; }

        public ListViewItem (string[] subitems) 
        { 
            foreach (var subitem in subitems)
                SubItems.Add(subitem);
        }

        public ListViewItem (string text) { Text = text; SubItems.Add (text); }
        public ListViewItem () { }

        public object Group { get; set; }

        public List<string> SubItems { get; set; } = new ();

        /// <summary>
        /// Gets the current bounding box of the item.
        /// </summary>
        public Rectangle Bounds { get; private set; }

        /// <summary>
        /// Gets or sets the image displayed on the item.
        /// </summary>
        public SKBitmap? Image { get; set; }

        /// <summary>
        /// Gets the ListView this item is currently a part of.
        /// </summary>
        public ListView? Parent { get; internal set; }

        /// <summary>
        /// Gets or sets a value indicating if the item is currently selected.
        /// </summary>
        public bool Selected { get; set; }

        /// <summary>
        /// Sets the bounding box of the item. This is internal API and should not be called.
        /// </summary>
        public void SetBounds (int x, int y, int width, int height)
        {
            Bounds = new Rectangle (x, y, width, height);
        }

        public object Clone ()
        {
            return new ListViewItem() { Bounds = Bounds, Group = Group, Image = Image, SubItems = SubItems, Tag = Tag, Text = Text, Name = Name, Parent = Parent, Selected  = Selected };
        }

        /// <summary>
        /// Gets or sets an object with additional user data about this item.
        /// </summary>
        public object? Tag { get; set; }

        /// <summary>
        /// Gets or sets the text displayed on the item.
        /// </summary>
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the text displayed on the item.
        /// </summary>
        public string ToolTipText { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the text displayed on the item.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        public int Index { get; set; }

        public bool Checked { get; set; }
        public SKColor ForeColor { get; set; }
    }
}
