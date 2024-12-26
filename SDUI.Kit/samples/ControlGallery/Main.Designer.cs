using SDUI;

namespace RSBot.Chat.Views
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
            tabMain = new TabControl();
            tabAll = new TabPage();
            txtAll = new TextBox();
            Splitter6 = new Splitter ();
            txtSendAll = new TextBox();
            tabPrivate = new TabPage();
            txtPrivate = new TextBox();
            Splitter5 = new Splitter();
            panel1 = new Panel();
            textBoxPrivateMsg = new TextBox();
            txtRecievePrivate = new TextBox();
            tabParty = new TabPage();
            txtParty = new TextBox();
            Splitter4 = new Splitter();
            txtSendParty = new TextBox();
            tabGuild = new TabPage();
            txtGuild = new TextBox();
            Splitter3 = new Splitter();
            txtSendGuild = new TextBox();
            tabUnion = new TabPage();
            txtUnion = new TextBox();
            Splitter2 = new Splitter();
            txtSendUnion = new TextBox();
            tabAcademy = new TabPage();
            txtAcademy = new TextBox();
            Splitter1 = new Splitter();
            txtSendAcademy = new TextBox();
            tabGlobal = new TabPage();
            txtGlobal = new TextBox();
            tabStall = new TabPage();
            txtStall = new TextBox();
            tabUnique = new TabPage();
            UniqueText = new TextBox();
            tabMain.SuspendLayout();
            tabAll.SuspendLayout();
            tabPrivate.SuspendLayout();
            panel1.SuspendLayout();
            tabParty.SuspendLayout();
            tabGuild.SuspendLayout();
            tabUnion.SuspendLayout();
            tabAcademy.SuspendLayout();
            tabGlobal.SuspendLayout();
            tabStall.SuspendLayout();
            tabUnique.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.TabPages.Add(tabAll);
            tabMain.TabPages.Add(tabPrivate);
            tabMain.TabPages.Add(tabParty);
            tabMain.TabPages.Add(tabGuild);
            tabMain.TabPages.Add(tabUnion);
            tabMain.TabPages.Add(tabAcademy);
            tabMain.TabPages.Add(tabGlobal);
            tabMain.TabPages.Add(tabStall);
            tabMain.TabPages.Add(tabUnique);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new System.Drawing.Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new System.Drawing.Size(754, 477);
            tabMain.TabIndex = 0;
            // 
            // tabAll
            // 
            tabAll.Controls.Add(txtAll);
            tabAll.Controls.Add(Splitter6);
            tabAll.Controls.Add(txtSendAll);
            tabAll.Location = new System.Drawing.Point(4, 28);
            tabAll.Name = "tabAll";
            tabAll.Padding = new Padding(3);
            tabAll.Size = new System.Drawing.Size(746, 445);
            tabAll.TabIndex = 0;
            tabAll.Text = "All";
            // 
            // txtAll
            // 
            txtAll.Dock = DockStyle.Fill;
            txtAll.Location = new System.Drawing.Point(3, 3);
            txtAll.Name = "txtAll";
            txtAll.ReadOnly = true;
            txtAll.Size = new System.Drawing.Size(740, 408);
            txtAll.TabIndex = 2;
            txtAll.Text = "";
            // 
            // Splitter6
            // 
            Splitter6.Text = "Splitter6";
            // 
            // txtSendAll
            // 
            txtSendAll.Dock = DockStyle.Bottom;
            txtSendAll.Location = new System.Drawing.Point(3, 421);
            txtSendAll.MaxLength = 32767;
            txtSendAll.MultiLine = false;
            txtSendAll.Name = "txtSendAll";
            txtSendAll.Size = new System.Drawing.Size(740, 21);
            txtSendAll.TabIndex = 3;
            txtSendAll.Tag = "1";
            // 
            // tabPrivate
            // 
            tabPrivate.Controls.Add(txtPrivate);
            tabPrivate.Controls.Add(Splitter5);
            tabPrivate.Controls.Add(panel1);
            tabPrivate.Location = new System.Drawing.Point(4, 25);
            tabPrivate.Name = "tabPrivate";
            tabPrivate.Padding = new Padding(3);
            tabPrivate.Size = new System.Drawing.Size(746, 448);
            tabPrivate.TabIndex = 1;
            tabPrivate.Text = "Private";
            // 
            // txtPrivate
            // 
            txtPrivate.Dock = DockStyle.Fill;
            txtPrivate.Location = new System.Drawing.Point(3, 3);
            txtPrivate.Name = "txtPrivate";
            txtPrivate.Size = new System.Drawing.Size(740, 402);
            txtPrivate.TabIndex = 7;
            txtPrivate.Text = "";
            // 
            // Splitter5
            Splitter5.Text = "Splitter5";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxPrivateMsg);
            panel1.Controls.Add(txtRecievePrivate);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(3, 415);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(740, 30);
            panel1.TabIndex = 8;
            // 
            // textBoxPrivateMsg
            // 
            textBoxPrivateMsg.Location = new System.Drawing.Point(164, 3);
            textBoxPrivateMsg.MaxLength = 32767;
            textBoxPrivateMsg.MultiLine = false;
            textBoxPrivateMsg.Name = "textBoxPrivateMsg";
            textBoxPrivateMsg.Size = new System.Drawing.Size(573, 21);
            textBoxPrivateMsg.TabIndex = 4;
            textBoxPrivateMsg.Tag = "2";
            // 
            // txtRecievePrivate
            // 
            txtRecievePrivate.Location = new System.Drawing.Point(3, 3);
            txtRecievePrivate.MaxLength = 32767;
            txtRecievePrivate.MultiLine = false;
            txtRecievePrivate.Name = "txtRecievePrivate";
            txtRecievePrivate.Size = new System.Drawing.Size(155, 21);
            txtRecievePrivate.TabIndex = 4;
            // 
            // tabParty
            // 
            tabParty.Controls.Add(txtParty);
            tabParty.Controls.Add(Splitter4);
            tabParty.Controls.Add(txtSendParty);
            tabParty.Location = new System.Drawing.Point(4, 28);
            tabParty.Name = "tabParty";
            tabParty.Padding = new Padding(3);
            tabParty.Size = new System.Drawing.Size(746, 445);
            tabParty.TabIndex = 2;
            tabParty.Text = "Party";
            // 
            // txtParty
            // 
            txtParty.Dock = DockStyle.Fill;
            txtParty.Location = new System.Drawing.Point(3, 3);
            txtParty.Name = "txtParty";
            txtParty.ReadOnly = true;
            txtParty.Size = new System.Drawing.Size(740, 408);
            txtParty.TabIndex = 2;
            txtParty.Text = "";
            // 
            // Splitter4
            // 
            Splitter4.Text = "Splitter4";
            // 
            // txtSendParty
            // 
            txtSendParty.Dock = DockStyle.Bottom;
            txtSendParty.Location = new System.Drawing.Point(3, 421);
            txtSendParty.MaxLength = 32767;
            txtSendParty.MultiLine = false;
            txtSendParty.Name = "txtSendParty";
            txtSendParty.Size = new System.Drawing.Size(740, 21);
            txtSendParty.TabIndex = 3;
            txtSendParty.Tag = "4";
            // 
            // tabGuild
            // 
            tabGuild.Controls.Add(txtGuild);
            tabGuild.Controls.Add(Splitter3);
            tabGuild.Controls.Add(txtSendGuild);
            tabGuild.Location = new System.Drawing.Point(4, 28);
            tabGuild.Name = "tabGuild";
            tabGuild.Padding = new Padding(3);
            tabGuild.Size = new System.Drawing.Size(746, 445);
            tabGuild.TabIndex = 3;
            tabGuild.Text = "Guild";
            // 
            // txtGuild
            // 
            txtGuild.Dock = DockStyle.Fill;
            txtGuild.Location = new System.Drawing.Point(3, 3);
            txtGuild.Name = "txtGuild";
            txtGuild.ReadOnly = true;
            txtGuild.Size = new System.Drawing.Size(740, 408);
            txtGuild.TabIndex = 2;
            txtGuild.Text = "";
            // 
            // Splitter3
            // 
            Splitter3.Text = "Splitter3";
            // 
            // txtSendGuild
            // 
            txtSendGuild.Dock = DockStyle.Bottom;
            txtSendGuild.Location = new System.Drawing.Point(3, 421);
            txtSendGuild.MaxLength = 32767;
            txtSendGuild.MultiLine = false;
            txtSendGuild.Name = "txtSendGuild";
            txtSendGuild.Size = new System.Drawing.Size(740, 21);
            txtSendGuild.TabIndex = 3;
            txtSendGuild.Tag = "5";
            // 
            // tabUnion
            // 
            tabUnion.Controls.Add(txtUnion);
            tabUnion.Controls.Add(Splitter2);
            tabUnion.Controls.Add(txtSendUnion);
            tabUnion.Location = new System.Drawing.Point(4, 25);
            tabUnion.Name = "tabUnion";
            tabUnion.Padding = new Padding(3);
            tabUnion.Size = new System.Drawing.Size(746, 448);
            tabUnion.TabIndex = 6;
            tabUnion.Text = "Union";
            // 
            // txtUnion
            // 
            txtUnion.Dock = DockStyle.Fill;
            txtUnion.Location = new System.Drawing.Point(3, 3);
            txtUnion.Name = "txtUnion";
            txtUnion.ReadOnly = true;
            txtUnion.Size = new System.Drawing.Size(740, 411);
            txtUnion.TabIndex = 4;
            txtUnion.Text = "";
            // 
            // Splitter2
            // 
            Splitter2.Text = "Splitter2";
            // 
            // txtSendUnion
            // 
            txtSendUnion.Dock = DockStyle.Bottom;
            txtSendUnion.Location = new System.Drawing.Point(3, 424);
            txtSendUnion.MaxLength = 32767;
            txtSendUnion.MultiLine = false;
            txtSendUnion.Name = "txtSendUnion";
            txtSendUnion.Size = new System.Drawing.Size(740, 21);
            txtSendUnion.TabIndex = 5;
            txtSendUnion.Tag = "11";
            // 
            // tabAcademy
            // 
            tabAcademy.Controls.Add(txtAcademy);
            tabAcademy.Controls.Add(Splitter1);
            tabAcademy.Controls.Add(txtSendAcademy);
            tabAcademy.Location = new System.Drawing.Point(4, 28);
            tabAcademy.Name = "tabAcademy";
            tabAcademy.Padding = new Padding(3);
            tabAcademy.Size = new System.Drawing.Size(746, 445);
            tabAcademy.TabIndex = 4;
            tabAcademy.Text = "Academy";
            // 
            // txtAcademy
            // 
            txtAcademy.Dock = DockStyle.Fill;
            txtAcademy.Location = new System.Drawing.Point(3, 3);
            txtAcademy.Name = "txtAcademy";
            txtAcademy.ReadOnly = true;
            txtAcademy.Size = new System.Drawing.Size(740, 408);
            txtAcademy.TabIndex = 2;
            txtAcademy.Text = "";
            // 
            // Splitter1
            // 
            Splitter1.Text = "Splitter1";
            // 
            // txtSendAcademy
            // 
            txtSendAcademy.Dock = DockStyle.Bottom;
            txtSendAcademy.Location = new System.Drawing.Point(3, 421);
            txtSendAcademy.MaxLength = 32767;
            txtSendAcademy.MultiLine = false;
            txtSendAcademy.Name = "txtSendAcademy";
            txtSendAcademy.Size = new System.Drawing.Size(740, 21);
            txtSendAcademy.TabIndex = 3;
            txtSendAcademy.Tag = "16";
            // tabGlobal
            // 
            tabGlobal.Controls.Add(txtGlobal);
            tabGlobal.Location = new System.Drawing.Point(4, 28);
            tabGlobal.Name = "tabGlobal";
            tabGlobal.Padding = new Padding(3);
            tabGlobal.Size = new System.Drawing.Size(746, 445);
            tabGlobal.TabIndex = 5;
            tabGlobal.Text = "Global / Notice";
            // 
            // txtGlobal
            // 
            txtGlobal.Dock = DockStyle.Fill;
            txtGlobal.Location = new System.Drawing.Point(3, 3);
            txtGlobal.Name = "txtGlobal";
            txtGlobal.ReadOnly = true;
            txtGlobal.Size = new System.Drawing.Size(740, 439);
            txtGlobal.TabIndex = 2;
            txtGlobal.Text = "";
            // 
            // tabStall
            // 
            tabStall.Controls.Add(txtStall);
            tabStall.Location = new System.Drawing.Point(4, 28);
            tabStall.Name = "tabStall";
            tabStall.Padding = new Padding(3);
            tabStall.Size = new System.Drawing.Size(746, 445);
            tabStall.TabIndex = 5;
            tabStall.Text = "Stall";
            // 
            // txtStall
            // 
            txtStall.Dock = DockStyle.Fill;
            txtStall.Location = new System.Drawing.Point(3, 3);
            txtStall.Name = "txtStall";
            txtStall.ReadOnly = true;
            txtStall.Size = new System.Drawing.Size(740, 439);
            txtStall.TabIndex = 2;
            txtStall.Text = "";
            // 
            // tabUnique
            // 
            tabUnique.Controls.Add(UniqueText);
            tabUnique.Location = new System.Drawing.Point(4, 28);
            tabUnique.Name = "tabUnique";
            tabUnique.Padding = new Padding(3);
            tabUnique.Size = new System.Drawing.Size(746, 445);
            tabUnique.TabIndex = 7;
            tabUnique.Text = "Unique";
            // 
            // UniqueText
            // 
            UniqueText.Dock = DockStyle.Fill;
            UniqueText.Location = new System.Drawing.Point(3, 3);
            UniqueText.Name = "UniqueText";
            UniqueText.ReadOnly = true;
            UniqueText.Size = new System.Drawing.Size(740, 439);
            UniqueText.TabIndex = 3;
            UniqueText.Text = "";
            // 
            // Main
            // 
            Controls.Add(tabMain);
            Name = "Main";
            Size = new System.Drawing.Size(754, 477);
            tabMain.ResumeLayout(false);
            tabAll.ResumeLayout(false);
            tabPrivate.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabParty.ResumeLayout(false);
            tabGuild.ResumeLayout(false);
            tabUnion.ResumeLayout(false);
            tabAcademy.ResumeLayout(false);
            tabGlobal.ResumeLayout(false);
            tabStall.ResumeLayout(false);
            tabUnique.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabAll;
        private TabPage tabPrivate;
        private TabPage tabParty;
        private TabPage tabGuild;
        private TabPage tabAcademy;
        private TabPage tabGlobal;
        private TabPage tabStall;
        private TextBox txtSendAll;
        private TextBox txtAll;
        private TextBox txtSendParty;
        private TextBox txtParty;
        private TextBox txtSendGuild;
        private TextBox txtGuild;
        private TextBox txtSendAcademy;
        private TextBox txtAcademy;
        private TextBox txtGlobal;
        private TextBox txtStall;
        private TextBox txtRecievePrivate;
        private TabPage tabUnion;
        private TextBox txtSendUnion;
        private TextBox txtUnion;
        private TabPage tabUnique;
        internal TextBox UniqueText;
        private Splitter Splitter1;
        private Splitter Splitter2;
        private Splitter Splitter3;
        private Splitter Splitter4;
        private Splitter Splitter5;
        private Splitter Splitter6;
        private TextBox txtPrivate;
        private TextBox textBoxPrivateMsg;
        private Panel panel1;
    }
}
