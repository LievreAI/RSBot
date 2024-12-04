using SDUI;
using SkiaSharp;

namespace RSBot.Inventory.Views
{
    partial class Main
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
            lblFreeSlots = new SDUI.Label();
            listViewMain = new SDUI.ListView();
            colName = new ColumnHeader();
            colAmount = new ColumnHeader();
            colGenderRace = new ColumnHeader();
            ContextMenu = new SDUI.ContextMenu();
            useMenuItem = new MenuItem();
            dropMenuItem = new MenuItem();
            moveToPetMenuItem = new MenuItem();
            moveToPlayerMenuItem = new MenuItem();
            moveToLastDeathPositionMenuItem = new MenuItem();
            moveToLastRecallPositionMenuItem = new MenuItem();
            selectMapLocationMenuItem = new MenuItem();
            useItemAtTrainingPlaceMenuItem = new MenuItem();
            autoUseAccordingToPurposeMenuItem = new MenuItem();
            panel1 = new SDUI.Panel();
            checkAutoSort = new SDUI.CheckBox();
            btnSort = new SDUI.Button();
            buttonInventory = new SDUI.Button();
            buttonEquipment = new SDUI.Button();
            buttonAvatars = new SDUI.Button();
            buttonGrabpet = new SDUI.Button();
            topPanel = new SDUI.Panel();
            buttonSpecialty = new SDUI.Button();
            buttonGuildStorage = new SDUI.Button();
            buttonFellowPet = new SDUI.Button();
            buttonJobTransport = new SDUI.Button();
            buttonStorage = new SDUI.Button();
            buttonJobEquipment = new SDUI.Button();
            ContextMenu.SuspendLayout();
            panel1.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblFreeSlots
            // 
            lblFreeSlots.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblFreeSlots.Location = new System.Drawing.Point(47, 13);
            lblFreeSlots.Name = "lblFreeSlots";
            lblFreeSlots.Size = new System.Drawing.Size(17, 20);
            lblFreeSlots.TabIndex = 4;
            lblFreeSlots.Text = "0";
            // 
            // listViewMain
            // 
            listViewMain.Columns.AddRange(new ColumnHeader[] { colName, colAmount, colGenderRace });
            listViewMain.ContextMenu = ContextMenu;
            listViewMain.Dock = DockStyle.Fill;
            listViewMain.FullRowSelect = true;
            listViewMain.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewMain.Location = new System.Drawing.Point(0, 38);
            listViewMain.Name = "listViewMain";
            listViewMain.Size = new System.Drawing.Size(792, 375);
            listViewMain.TabIndex = 2;
            listViewMain.ViewType = ViewTypes.Details;
            listViewMain.DoubleClick += listViewMain_MouseDoubleClick;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 381;
            // 
            // colAmount
            // 
            colAmount.Text = "Amount";
            colAmount.Width = 62;
            // 
            // colGenderRace
            // 
            colGenderRace.Text = "Rarity";
            colGenderRace.Width = 153;
            // 
            // ContextMenu
            // 
            ContextMenu.Items.AddRange(new MenuItem[] { useMenuItem, dropMenuItem, moveToPetMenuItem, moveToPlayerMenuItem, moveToLastDeathPositionMenuItem, moveToLastRecallPositionMenuItem, selectMapLocationMenuItem, useItemAtTrainingPlaceMenuItem, autoUseAccordingToPurposeMenuItem });
            ContextMenu.Name = "ContextMenu";
            ContextMenu.Size = new System.Drawing.Size(238, 202);
            ContextMenu.Opening += ContextMenu_Opening;
            // 
            // useMenuItem
            // 
            useMenuItem.Name = "useMenuItem";
            useMenuItem.Text = "Use";
            useMenuItem.Click += buttonUseItem_Click;
            // 
            // dropMenuItem
            // 
            dropMenuItem.Name = "dropMenuItem";
            dropMenuItem.Text = "Drop";
            dropMenuItem.Click += dropMenuItem_Click;
            // 
            // moveToPetMenuItem
            // 
            moveToPetMenuItem.Name = "moveToPetMenuItem";
            moveToPetMenuItem.Text = "Move to active pet";
            moveToPetMenuItem.Click += moveToPetMenuItem_Click;
            // 
            // moveToPlayerMenuItem
            // 
            moveToPlayerMenuItem.Name = "moveToPlayerMenuItem";
            moveToPlayerMenuItem.Text = "Move to player";
            moveToPlayerMenuItem.Click += moveToPlayerMenuItem_Click;
            // 
            // moveToLastDeathPositionMenuItem
            // 
            moveToLastDeathPositionMenuItem.Name = "moveToLastDeathPositionMenuItem";
            moveToLastDeathPositionMenuItem.Text = "Move to last death position";
            moveToLastDeathPositionMenuItem.Click += moveToLastDeathPositionMenuItem_Click;
            // 
            // moveToLastRecallPositionMenuItem
            // 
            moveToLastRecallPositionMenuItem.Name = "moveToLastRecallPositionMenuItem";
            moveToLastRecallPositionMenuItem.Text = "Move to Last recall position";
            moveToLastRecallPositionMenuItem.Click += moveToLastRecallPositionMenuItem_Click;
            // 
            // selectMapLocationMenuItem
            // 
            selectMapLocationMenuItem.Name = "selectMapLocationMenuItem";
            selectMapLocationMenuItem.Text = "Select Map Location";
            // 
            // useItemAtTrainingPlaceMenuItem
            // 
            useItemAtTrainingPlaceMenuItem.Name = "useItemAtTrainingPlaceMenuItem";
            useItemAtTrainingPlaceMenuItem.Text = "Use item at training place";
            useItemAtTrainingPlaceMenuItem.Click += useItemAtTrainingPlaceMenuItem_Click;
            // 
            // autoUseAccordingToPurposeMenuItem
            // 
            autoUseAccordingToPurposeMenuItem.Name = "autoUseAccordingToPurposeMenuItem";
            autoUseAccordingToPurposeMenuItem.Text = "Auto use according to purpose";
            autoUseAccordingToPurposeMenuItem.Click += autoUseAccordingToPurposeMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Border = new Padding(0, 1, 0, 0);
            panel1.Controls.Add(checkAutoSort);
            panel1.Controls.Add(btnSort);
            panel1.Controls.Add(lblFreeSlots);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 413);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.ShadowDepth = 4F;
            panel1.Size = new System.Drawing.Size(792, 45);
            panel1.TabIndex = 6;
            // 
            // checkAutoSort
            // 
            checkAutoSort.Depth = 0;
            checkAutoSort.Location = new System.Drawing.Point(636, 7);
            checkAutoSort.Margin = new Padding(0);
            checkAutoSort.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAutoSort.Name = "checkAutoSort";
            checkAutoSort.Ripple = true;
            checkAutoSort.Size = new System.Drawing.Size(72, 15);
            checkAutoSort.TabIndex = 6;
            checkAutoSort.Text = "Auto sort";
            checkAutoSort.UseVisualStyleBackColor = false;
            checkAutoSort.CheckedChanged += checkAutoSort_CheckedChanged;
            // 
            // btnSort
            // 
            btnSort.Color = new SkiaSharp.SKColor(56, 155, 90);
            btnSort.ForeColor = SKColors.White;
            btnSort.Location = new System.Drawing.Point(714, 2);
            btnSort.Name = "btnSort";
            btnSort.Radius = 6;
            btnSort.ShadowDepth = 4F;
            btnSort.Size = new System.Drawing.Size(75, 23);
            btnSort.TabIndex = 5;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // buttonInventory
            // 
            buttonInventory.Color = SKColors.Transparent;
            buttonInventory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonInventory.Location = new System.Drawing.Point(9, 8);
            buttonInventory.Name = "buttonInventory";
            buttonInventory.Radius = 6;
            buttonInventory.ShadowDepth = 4F;
            buttonInventory.Size = new System.Drawing.Size(62, 22);
            buttonInventory.TabIndex = 0;
            buttonInventory.Text = "Inventory";
            buttonInventory.UseVisualStyleBackColor = true;
            buttonInventory.Click += ButtonSwitcher;
            // 
            // buttonEquipment
            // 
            buttonEquipment.Color = SKColors.Transparent;
            buttonEquipment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonEquipment.Location = new System.Drawing.Point(77, 8);
            buttonEquipment.Name = "buttonEquipment";
            buttonEquipment.Radius = 6;
            buttonEquipment.ShadowDepth = 4F;
            buttonEquipment.Size = new System.Drawing.Size(69, 22);
            buttonEquipment.TabIndex = 1;
            buttonEquipment.Text = "Equipment";
            buttonEquipment.UseVisualStyleBackColor = true;
            buttonEquipment.Click += ButtonSwitcher;
            // 
            // buttonAvatars
            // 
            buttonAvatars.Color = SKColors.Transparent;
            buttonAvatars.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAvatars.Location = new System.Drawing.Point(245, 8);
            buttonAvatars.Name = "buttonAvatars";
            buttonAvatars.Radius = 6;
            buttonAvatars.ShadowDepth = 4F;
            buttonAvatars.Size = new System.Drawing.Size(57, 22);
            buttonAvatars.TabIndex = 2;
            buttonAvatars.Text = "Avatars";
            buttonAvatars.UseVisualStyleBackColor = true;
            buttonAvatars.Click += ButtonSwitcher;
            // 
            // buttonGrabpet
            // 
            buttonGrabpet.Color = SKColors.Transparent;
            buttonGrabpet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonGrabpet.Location = new System.Drawing.Point(308, 8);
            buttonGrabpet.Name = "buttonGrabpet";
            buttonGrabpet.Radius = 6;
            buttonGrabpet.ShadowDepth = 4F;
            buttonGrabpet.Size = new System.Drawing.Size(59, 22);
            buttonGrabpet.TabIndex = 3;
            buttonGrabpet.Text = "Grab Pet";
            buttonGrabpet.UseVisualStyleBackColor = true;
            buttonGrabpet.Click += ButtonSwitcher;
            // 
            // topPanel
            // 
            topPanel.BackColor = SKColors.Transparent;
            topPanel.Border = new Padding(0, 0, 0, 1);
            topPanel.BorderColor = SKColors.Transparent;
            topPanel.Controls.Add(buttonSpecialty);
            topPanel.Controls.Add(buttonGuildStorage);
            topPanel.Controls.Add(buttonGrabpet);
            topPanel.Controls.Add(buttonInventory);
            topPanel.Controls.Add(buttonFellowPet);
            topPanel.Controls.Add(buttonJobTransport);
            topPanel.Controls.Add(buttonStorage);
            topPanel.Controls.Add(buttonJobEquipment);
            topPanel.Controls.Add(buttonEquipment);
            topPanel.Controls.Add(buttonAvatars);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(8);
            topPanel.ShadowDepth = 4F;
            topPanel.Size = new System.Drawing.Size(792, 38);
            topPanel.TabIndex = 8;
            // 
            // buttonSpecialty
            // 
            buttonSpecialty.Color = SKColors.Transparent;
            buttonSpecialty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonSpecialty.Location = new System.Drawing.Point(553, 8);
            buttonSpecialty.Name = "buttonSpecialty";
            buttonSpecialty.Radius = 6;
            buttonSpecialty.ShadowDepth = 4F;
            buttonSpecialty.Size = new System.Drawing.Size(66, 22);
            buttonSpecialty.TabIndex = 7;
            buttonSpecialty.Text = "Specialty";
            buttonSpecialty.UseVisualStyleBackColor = true;
            buttonSpecialty.Click += ButtonSwitcher;
            // 
            // buttonGuildStorage
            // 
            buttonGuildStorage.Color = SKColors.Transparent;
            buttonGuildStorage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonGuildStorage.Location = new System.Drawing.Point(684, 8);
            buttonGuildStorage.Name = "buttonGuildStorage";
            buttonGuildStorage.Radius = 6;
            buttonGuildStorage.ShadowDepth = 4F;
            buttonGuildStorage.Size = new System.Drawing.Size(81, 22);
            buttonGuildStorage.TabIndex = 5;
            buttonGuildStorage.Text = "Guild Storage";
            buttonGuildStorage.UseVisualStyleBackColor = true;
            buttonGuildStorage.Click += ButtonSwitcher;
            // 
            // buttonFellowPet
            // 
            buttonFellowPet.Color = SKColors.Transparent;
            buttonFellowPet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonFellowPet.Location = new System.Drawing.Point(373, 8);
            buttonFellowPet.Name = "buttonFellowPet";
            buttonFellowPet.Radius = 6;
            buttonFellowPet.ShadowDepth = 4F;
            buttonFellowPet.Size = new System.Drawing.Size(84, 22);
            buttonFellowPet.TabIndex = 9;
            buttonFellowPet.Text = "Fellow Pet";
            buttonFellowPet.UseVisualStyleBackColor = true;
            buttonFellowPet.Click += ButtonSwitcher;
            // 
            // buttonJobTransport
            // 
            buttonJobTransport.Color = SKColors.Transparent;
            buttonJobTransport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonJobTransport.Location = new System.Drawing.Point(463, 8);
            buttonJobTransport.Name = "buttonJobTransport";
            buttonJobTransport.Radius = 6;
            buttonJobTransport.ShadowDepth = 4F;
            buttonJobTransport.Size = new System.Drawing.Size(84, 22);
            buttonJobTransport.TabIndex = 6;
            buttonJobTransport.Text = "Job Transport";
            buttonJobTransport.UseVisualStyleBackColor = true;
            buttonJobTransport.Click += ButtonSwitcher;
            // 
            // buttonStorage
            // 
            buttonStorage.Color = SKColors.Transparent;
            buttonStorage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonStorage.Location = new System.Drawing.Point(625, 8);
            buttonStorage.Name = "buttonStorage";
            buttonStorage.Radius = 6;
            buttonStorage.ShadowDepth = 4F;
            buttonStorage.Size = new System.Drawing.Size(53, 22);
            buttonStorage.TabIndex = 4;
            buttonStorage.Text = "Storage";
            buttonStorage.UseVisualStyleBackColor = true;
            buttonStorage.Click += ButtonSwitcher;
            // 
            // buttonJobEquipment
            // 
            buttonJobEquipment.Color = SKColors.Transparent;
            buttonJobEquipment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonJobEquipment.Location = new System.Drawing.Point(152, 8);
            buttonJobEquipment.Name = "buttonJobEquipment";
            buttonJobEquipment.Radius = 6;
            buttonJobEquipment.ShadowDepth = 4F;
            buttonJobEquipment.Size = new System.Drawing.Size(87, 22);
            buttonJobEquipment.TabIndex = 8;
            buttonJobEquipment.Text = "Job Equipment";
            buttonJobEquipment.UseVisualStyleBackColor = true;
            buttonJobEquipment.Click += ButtonSwitcher;
            // 
            // Main
            // 
            
            
            Controls.Add(listViewMain);
            Controls.Add(topPanel);
            Controls.Add(panel1);
            Name = "Main";
            Size = new System.Drawing.Size(792, 458);
            ParentChanged += Main_Load;
            VisibleChanged += Main_VisibleChanged;
            ContextMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SDUI.ListView listViewMain;
        private ColumnHeader colName;
        private ColumnHeader colAmount;
        private SDUI.Label label2;
        private SDUI.Label lblFreeSlots;
        private ColumnHeader colGenderRace;
        private SDUI.Panel panel1;
        private SDUI.Button buttonInventory;
        private SDUI.Button buttonEquipment;
        private SDUI.Button buttonAvatars;
        private SDUI.Button buttonGrabpet;
        private SDUI.Panel topPanel;
        private SDUI.Button buttonSpecialty;
        private SDUI.Button buttonGuildStorage;
        private SDUI.Button buttonJobTransport;
        private SDUI.Button buttonStorage;
        private SDUI.Button buttonJobEquipment;
        private SDUI.ContextMenu ContextMenu;
        private MenuItem useMenuItem;
        private MenuItem dropMenuItem;
        private MenuItem moveToLastDeathPositionMenuItem;
        private MenuItem moveToLastRecallPositionMenuItem;
        private MenuItem selectMapLocationMenuItem;
        private MenuItem moveToPetMenuItem;
        private MenuItem moveToPlayerMenuItem;
        private SDUI.Button buttonFellowPet;
        private SDUI.Button btnSort;
        private SDUI.CheckBox checkAutoSort;
        private MenuItem useItemAtTrainingPlaceMenuItem;
        private MenuItem autoUseAccordingToPurposeMenuItem;
    }
}
