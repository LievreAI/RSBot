using System;
using System.Collections.ObjectModel;
using System.Linq;
using SkiaSharp;

namespace SDUI
{
    /// <summary>
    /// Represents a collection of ListViewItems.
    /// </summary>
    public class ListViewItemCollection : KeyedCollection<object, ListViewItem>
    {
        private readonly ListView owner;

        internal ListViewItemCollection (ListView owner)
        {
            this.owner = owner;
        }

        /// <summary>
        /// Adds a new ListViewItem to the collection with the specified text.
        /// </summary>
        public ListViewItem Add (string text)
        {
            var item = new ListViewItem {
                Text = text
            };

            Add (item);

            return item;
        }

        /// <summary>
        /// Adds a new ListViewItem to the collection with the specified text and image.
        /// </summary>
        public ListViewItem Add (string text, SKBitmap image)
        {
            var item = new ListViewItem {
                Text = text,
                Image = image
            };

            InsertItem (Count, item);

            return item;
        }

        /// <inheritdoc/>
        protected override void ClearItems ()
        {
            foreach (var item in Items)
                item.Parent = null;

            base.ClearItems ();

            owner.Invalidate ();
        }

        protected override object GetKeyForItem (ListViewItem item)
        {
            return string.IsNullOrWhiteSpace(item.Name) ? Count.ToString() : item.Name;
        }

        /// <inheritdoc/>
        protected override void InsertItem (int index, ListViewItem item)
        {
            base.InsertItem (index, item);

            item.Parent = owner;
            owner.Invalidate ();
        }

        /// <inheritdoc/>
        protected override void RemoveItem (int index)
        {
            var item = this[index];

            base.RemoveItem (index);

            item.Parent = null;
            owner.Invalidate ();
        }

        /// <inheritdoc/>
        protected override void SetItem (int index, ListViewItem item)
        {
            var old_item = this.ElementAtOrDefault (index);

            if (old_item != null)
                old_item.Parent = null;

            base.SetItem (index, item);

            item.Parent = owner;
            owner.Invalidate ();
        }

        public void AddRange(ListViewItem[] array)
        {
            foreach (var item in array) {
                this.Add (item);
            }
        }
    }
}
