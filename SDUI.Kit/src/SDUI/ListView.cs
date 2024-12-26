using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using SDUI.Renderers;

namespace SDUI
{
    public enum ColumnHeaderStyle
    {
        None,
        Nonclickable,
        Clickable
    }

    public class ColumnHeader : ListViewItem
    {
        public int Width;
    }

    public enum ViewTypes
    {
        Details
    }

    /// <summary>
    /// Represents a ListView control.
    /// Note the ListView control has not been fully developed, and probably does not contain enough functionality to be useful yet.
    /// </summary>
    public class ListView : Control
    {
        public bool FullRowSelect { get; set; }
        public bool CheckBoxes { get; set; }
        public bool UseCompatibleStateImageBehavior { get; set; }

        public ViewTypes ViewType { get; set; } = ViewTypes.Details;
        public ColumnHeaderStyle HeaderStyle { get; set; } = ColumnHeaderStyle.Clickable;

        /// <summary>
        /// Initializes a new instance of the ListView class.
        /// </summary>
        public ListView ()
        {
            Items = new(this);
            Groups = new(this);
            Columns = new(this);
        }

        /// <inheritdoc/>
        protected override Padding DefaultPadding => new Padding (3);

        /// <inheritdoc/>
        protected override Size DefaultSize => new Size (450, 450);

        /// <inheritdoc/>
        public new static ControlStyle DefaultStyle = new ControlStyle (Control.DefaultStyle,
            (style) => style.BackgroundColor = Theme.ControlLowColor);

        /// <summary>
        /// Raised when a list view item is double-clicked.
        /// </summary>
        public event EventHandler<EventArgs<ListViewItem>>? ItemDoubleClicked;

        /// <summary>
        /// Raised when a list view item is checked
        /// </summary>
        public event EventHandler<ItemCheckedEventArgs>? ItemChecked;

        /// <summary>
        /// Gets the collection of items contained by this ListView.
        /// </summary>
        public ListViewItemCollection Columns { get; }

        /// <summary>
        /// Gets the collection of items contained by this ListView.
        /// </summary>
        public ListViewItemCollection Groups { get; }

        /// <summary>
        /// Gets the collection of items contained by this ListView.
        /// </summary>
        public ListViewItemCollection Items { get; }

        // Lays out the ListViewItems.
        private void LayoutItems ()
        {
            var bounds = PaddedClientRectangle;
            var item_size = LogicalToDeviceUnits (70);
            var item_margin = LogicalToDeviceUnits (6);

            var x = bounds.Left;
            var y = bounds.Top;

            foreach (var item in Items) {
                item.SetBounds (x, y, item_size, item_size);
                x += item_size + item_margin;

                if (x + item_size > bounds.Width) {
                    x = bounds.Left;
                    y += item_size + item_margin;
                }
            }
        }

        /// <inheritdoc/>
        protected override void OnClick (MouseEventArgs e)
        {
            base.OnClick (e);

            var clicked_item = Items.FirstOrDefault (tp => tp.Bounds.Contains (e.Location));

            SelectedItem = clicked_item;
        }

        /// <inheritdoc/>
        protected override void OnDoubleClick (MouseEventArgs e)
        {
            base.OnDoubleClick (e);

            var clicked_item = Items.FirstOrDefault (tp => tp.Bounds.Contains (e.Location));

            if (clicked_item != null)
                ItemDoubleClicked?.Invoke (this, new EventArgs<ListViewItem> (clicked_item));
        }

        /// <inheritdoc/>
        protected override void OnPaint (PaintEventArgs e)
        {
            base.OnPaint (e);

            LayoutItems ();

            RenderManager.Render (this, e);
        }

        public void MoveSelectedItems (MoveDirection direction)
        {
            
        }

        /// <summary>
        /// Gets or sets the currently selected item, if any. If there are multiple selected items, the first selected item will be returned.
        /// </summary>
        public ListViewItem? SelectedItem {
            get => Items.FirstOrDefault (i => i.Selected);
            set {
                var current_item = Items.FirstOrDefault (i => i.Selected);

                if (current_item == value)
                    return;

                if (current_item != null)
                    current_item.Selected = false;

                if (value != null)
                    value.Selected = true;

                Invalidate ();
            }
        }

        /// <summary>
        /// Gets or sets the currently selected item, if any. If there are multiple selected items, the first selected item will be returned.
        /// </summary>
        public List<ListViewItem> SelectedItems {
            get => Items.Where (i => i.Selected).ToList();
            set {
                foreach (ListViewItem item in value) {
                    item.Selected = true;
                }

                Invalidate ();
            }
        }
        
        /// <summary>
         /// Gets or sets the currently selected item, if any. If there are multiple selected items, the first selected item will be returned.
         /// </summary>
        public List<ListViewItem> CheckedItems {
            get => Items.Where (i => i.Checked).ToList ();
            set {
                foreach (ListViewItem item in value) {
                    item.Checked = true;
                }

                Invalidate ();
            }
        }

        /// <summary>
        /// Gets or sets the currently selected item, if any. If there are multiple selected items, the first selected item will be returned.
        /// </summary>
        public List<int> SelectedIndices {
            get {
                var array = new List<int> ();
                for(int i = 0; i < Items.Count; i++){
                    if (Items[i].Selected)
                        array.Add(i);
                }

                return array;
            }
            set {
                foreach (var i in value) {
                    if (!(i < 0 && i > Items.Count - 1))
                        Items[i].Selected = true;
                }

                Invalidate ();
            }
        }

        /// <inheritdoc/>
        public override ControlStyle Style { get; } = new ControlStyle (DefaultStyle);
    }
}
