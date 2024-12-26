using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace SDUI
{
    public enum MessageBoxButtons
    {
        None,
        OK,
        YesNo,
        YesNoCancel
    }

    public enum MessageBoxIcon
    {
        None,
        Information,
        Warning,
        Question,
        Error,
        Exclamation,
    }

    public class MessageBox
    {
        public static Task<DialogResult> Show (Form owner, string caption, string message, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icons = MessageBoxIcon.None)
        {
            return new MessageBoxForm (caption, message, buttons, icons).ShowDialog (owner);
        }

        public static Task<DialogResult> Show (Control owner, string caption, string message, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icons = MessageBoxIcon.None)
        {
            return new MessageBoxForm (caption, message, buttons, icons).ShowDialog (owner.FindForm());
        }

        public static Task<DialogResult> Show (string caption, string message, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icons = MessageBoxIcon.None)
        {
            return new MessageBoxForm (caption, message, buttons, icons).ShowDialog ();
        }

        public static Task<DialogResult> Show (Form owner, string caption, string message = "")
        {
            return new MessageBoxForm (caption, message).ShowDialog(owner);
        }
    }
    /// <summary>
    /// Represents a popup dialog used to inform the user of a message.
    /// </summary>
    public class MessageBoxForm : Form
    {
        private readonly MessageBoxIcon icons = MessageBoxIcon.None;
        private readonly MessageBoxButtons buttons = MessageBoxButtons.OK;
        private readonly Button ok_button;
        private readonly Button[] buttonList = new Button[3];
        private readonly TextBox label;

        /// <summary>
        /// Initializes a new instance of the MessageBoxForm class.
        /// </summary>
        public MessageBoxForm ()
        {
            StartPosition = FormStartPosition.CenterParent;
            AllowMinimize = false;
            AllowMaximize = false;

            label = Controls.Add (new TextBox {
                Dock = DockStyle.Fill,
                Height = 105,
                MultiLine = true,
                ReadOnly = true,
                Padding = new Padding (10)
            });

            var labelPanel = Controls.Add (new Panel {
                Dock = DockStyle.Bottom,
                Height = 45
            });

            label.Style.BackgroundColor = Theme.BackgroundColor;
            label.Style.Border.Width = 0;

            switch (buttons) {
                case MessageBoxButtons.None:
                case MessageBoxButtons.OK:
                    buttonList[0] = labelPanel.Controls.Add (new Button {
                        Text = "OK",
                        Left = 150,
                        Top = 0
                    });
                    buttonList[0].Click += (o, e) => Close ();
                    break;
                case MessageBoxButtons.YesNo:
                    break;
                case MessageBoxButtons.YesNoCancel:
                    break;
                default:
                    break;
            }
            ok_button = labelPanel.Controls.Add (new Button {
                Text = "OK",
                Left = 150,
                Top = 0
            });

            ok_button.Click += (o, e) => Close ();
        }

        /// <summary>
        /// Initializes a new instance of the MessageBoxForm class with the specified title and message.
        /// </summary>
        public MessageBoxForm (string title, string message) : this ()
        {
            Text = title;
            label.Text = message;

            CalculateDialogSize ();
        }

        /// <summary>
        /// Initializes a new instance of the MessageBoxForm class with the specified title and message.
        /// </summary>
        public MessageBoxForm (string title, string message, MessageBoxButtons buttons, MessageBoxIcon icons) 
            : this (title, message)
        {
            Text = title;
            label.Text = message;
            this.icons = icons;
            this.buttons = buttons;

            CalculateDialogSize ();
        }

        private void CalculateDialogSize ()
        {
            var num_lines = label?.Text?.Count (c => c == '\n') ?? 0;

            if (num_lines > 10)
                Size = new Size (800, 400);
            else if (num_lines > 4)
                Size = new Size (600, 300);
            else
                Size = new Size (400, 200);

            var totalSize = (Size.Width - buttonList.Sum (c => c?.Width)) / 2;

            ok_button.Left = totalSize.Value;
        }

        /// <inheritdoc/>
        protected override Size DefaultSize => new Size (400, 200);

        /// <summary>
        /// Gets or sets the message of the dialog.
        /// </summary>
        public string Message {
            get => label.Text;
            set {
                if (label.Text != value) {
                    label.Text = value;
                    CalculateDialogSize ();
                }
            }
        }
    }
}
