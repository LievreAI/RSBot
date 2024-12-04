using SDUI;

namespace RSBot.Default.Views.Dialogs
{
    partial class TrainingAreasDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContextMenu = new SDUI.ContextMenu();
            this.createMenuItem = new MenuItem();
            this.listView = new SDUI.ListView();
            this.columnHeaderId = new ColumnHeader();
            this.columnHeaderName = new ColumnHeader();
            this.columnHeaderRegion = new ColumnHeader();
            this.columnHeaderX = new ColumnHeader();
            this.columnHeaderY = new ColumnHeader();
            this.columnHeaderR = new ColumnHeader();
            this.columnHeaderS = new ColumnHeader();
            this.panel1 = new SDUI.Panel();
            this.labelPos = new SDUI.Label();
            this.buttonCancel = new SDUI.Button();
            this.buttonAccept = new SDUI.Button();
            this.removeSelectedAreaMenuItem = new MenuItem();
            this.ContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new MenuItem[] {
            this.createMenuItem,
            this.removeSelectedAreaMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(189, 70);
            // 
            // createMenuItem
            // 
            this.createMenuItem.Name = "createMenuItem";
            this.createMenuItem.Text = "Create";
            this.createMenuItem.Click += this.createMenuItem_Click;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderRegion,
            this.columnHeaderX,
            this.columnHeaderY,
            this.columnHeaderR,
            this.columnHeaderS});
            this.listView.ContextMenu = this.ContextMenu;
            this.listView.Dock = DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(1, 1);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(613, 277);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.ViewType = ViewTypes.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 170;
            // 
            // columnHeaderRegion
            // 
            this.columnHeaderRegion.Text = "Region";
            this.columnHeaderRegion.Width = 150;
            // 
            // columnHeaderX
            // 
            this.columnHeaderX.Text = "X";
            // 
            // columnHeaderY
            // 
            this.columnHeaderY.Text = "Y";
            // 
            // columnHeaderR
            // 
            this.columnHeaderR.Text = "Radius";
            // 
            // columnHeaderS
            // 
            this.columnHeaderS.Text = "Selected";
            // 
            // panel1
            // 
            this.panel1.Border = new Padding(0, 1, 0, 0);
            this.panel1.Controls.Add(this.labelPos);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonAccept);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(1, 278);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDepth = 0F;
            this.panel1.Size = new System.Drawing.Size(613, 39);
            this.panel1.TabIndex = 2;
            // 
            // labelPos
            // 
            this.labelPos.ForeColor = new SkiaSharp.SKColor(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPos.Location = new System.Drawing.Point(203, 1);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(234, 36);
            this.labelPos.TabIndex = 1;
            this.labelPos.Text = "Experimental Window\r\nRight Click for create new";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(526, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Radius = 6;
            this.buttonCancel.ShadowDepth = 4F;
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Color = new SkiaSharp.SKColor(((int)(((byte)(56)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.buttonAccept.DialogResult = DialogResult.OK;
            this.buttonAccept.Location = new System.Drawing.Point(12, 8);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Radius = 6;
            this.buttonAccept.ShadowDepth = 4F;
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += this.buttonAccept_Click;
            // 
            // removeSelectedAreaMenuItem
            // 
            this.removeSelectedAreaMenuItem.Name = "removeSelectedAreaMenuItem";
            this.removeSelectedAreaMenuItem.Text = "Remove selected area";
            this.removeSelectedAreaMenuItem.Click += this.removeSelectedAreaMenuItem_Click;
            // 
            // TrainingAreasDialog
            // 
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panel1);
            this.Name = "TrainingAreasDialog";
            this.Padding = new Padding(1);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "[Experimental] Training Areas - Right click for create";
            this.Closing += TrainingAreas_FormClosing;
            this.Load += this.TrainingAreas_Load;
            this.ContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SDUI.ContextMenu ContextMenu;
        private MenuItem createMenuItem;
        private SDUI.ListView listView;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderX;
        private ColumnHeader columnHeaderY;
        private ColumnHeader columnHeaderR;
        private ColumnHeader columnHeaderS;
        private SDUI.Panel panel1;
        private SDUI.Button buttonCancel;
        private SDUI.Button buttonAccept;
        private ColumnHeader columnHeaderRegion;
        private SDUI.Label labelPos;
        private MenuItem removeSelectedAreaMenuItem;
    }
}