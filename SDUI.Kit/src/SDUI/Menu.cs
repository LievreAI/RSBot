using System;
using System.Drawing;
using System.Linq;

namespace SDUI
{
    /// <summary>
    /// Represents a Menu control.
    /// </summary>
    public class Menu : MenuBase
    {
        /// <summary>
        /// Initializes a new instance of the Menu class.
        /// </summary>
        public Menu ()
        {
            Dock = DockStyle.Top;
        }

        /// <inheritdoc/>
        protected override Size DefaultSize => new Size (600, 28);

        /// <inheritdoc/>
        public new static ControlStyle DefaultStyle = new ControlStyle (Control.DefaultStyle);

        /// <inheritdoc/>
        protected override bool IsTopLevelMenu => true;

        /// <inheritdoc/>
        protected override void LayoutItems ()
        {
            StackLayoutEngine.HorizontalExpand.Layout (ClientRectangle, Items.Cast<ILayoutable> ());
        }

        /// <inheritdoc/>
        protected override void OnDeselected (EventArgs e)
        {
            base.OnDeselected (e);

            Deactivate ();
        }


        /// <inheritdoc/>
        protected override void OnMouseDown (MouseEventArgs e)
        {
            base.OnMouseDown (e);

            if (Parent?.GetType() == typeof(FormTitleBar) && GetItemAtLocation(e.Location) == null) {
                // We won't get a MouseUp from the system for this, so don't capture the mouse
                Capture = false;
                FindForm ()?.BeginMoveDrag ();
            }
        }

        /// <inheritdoc/>
        protected override void OnHoverChanged (MenuItem? oldItem, MenuItem? newItem)
        {
            if (IsActivated && newItem != null)
                SelectedItem = newItem;
        }

        /// <inheritdoc/>
        public override ControlStyle Style { get; } = new ControlStyle (DefaultStyle);
    }
}
