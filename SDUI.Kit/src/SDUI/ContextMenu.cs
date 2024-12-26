using System;
using System.ComponentModel;
using System.Drawing;

namespace SDUI
{
    /// <summary>
    /// Represents a ContextMenu control.
    /// </summary>
    public class ContextMenu : MenuDropDown
    {
        public event CancelEventHandler Opening;

        /// <summary>
        /// Initializes a new instance of the ContextMenu class.
        /// </summary>
        public ContextMenu () : base ()
        {
        }

        /// <inheritdoc/>
        protected override bool IsTopLevelMenu => true;

        /// <inheritdoc/>
        public override void Show (Control parent, Point location)
        {
            var eventargs = new System.ComponentModel.CancelEventArgs (false);
            Opening?.Invoke (this, eventargs);
            if (eventargs.Cancel)
                return;

            Application.ActiveMenu ??= this;

            base.Show (parent, location);
        }
    }
}
