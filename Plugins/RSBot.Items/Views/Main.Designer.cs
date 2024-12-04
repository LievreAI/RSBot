using SDUI;
using System.ComponentModel;
using System.Drawing;


namespace RSBot.Items.Views
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            ListViewGroup listViewGroup1 = new ListViewGroup("Potion trader");
            ListViewGroup listViewGroup2 = new ListViewGroup("Stable keeper");
            ListViewGroup listViewGroup3 = new ListViewGroup("Protector trader");
            ListViewGroup listViewGroup4 = new ListViewGroup("Weapon trader");
            ListViewGroup listViewGroup5 = new ListViewGroup("Accessory trader");
            contextShoppingList = new SDUI.ContextMenu();
            menuChangeAmount = new MenuItem();
            MenuSplitterItem1 = new MenuSplitterItem();
            menuRemoveItem = new MenuItem();
            contextAvailableProducts = new SDUI.ContextMenu();
            menuAddToShoppingList = new MenuItem();
            tabMain = new SDUI.TabControl();
            tabBuyFilter = new TabPage();
            splitContainer = new SplitContainer();
            listAvailableProducts = new SDUI.ListView();
            colAvailableName = new ColumnHeader();
            panel1 = new SDUI.Panel();
            label6 = new SDUI.Label();
            checkShowEquipment = new SDUI.CheckBox();
            txtShopSearch = new SDUI.TextBox();
            comboStore = new SDUI.ComboBox();
            label1 = new SDUI.Label();
            listShoppingList = new SDUI.ListView();
            colName = new ColumnHeader();
            colAmount = new ColumnHeader();
            panel2 = new SDUI.Panel();
            Splitter5 = new SDUI.Splitter();
            groupBox1 = new SDUI.GroupBox();
            checkSellItemsFromPet = new SDUI.CheckBox();
            checkStoreItemsFromPet = new SDUI.CheckBox();
            checkRepairGear = new SDUI.CheckBox();
            checkEnable = new SDUI.CheckBox();
            tabSellFilter = new TabPage();
            listFilter = new SDUI.ListView();
            colItemName = new ColumnHeader();
            colItemLevel = new ColumnHeader();
            colGender = new ColumnHeader();
            colPickup = new ColumnHeader();
            colSell = new ColumnHeader();
            collStore = new ColumnHeader();
            contextList = new SDUI.ContextMenu();
            btnAddToSell = new MenuItem();
            btnAddToStore = new MenuItem();
            btnPickup = new MenuItem();
            btnPickOnlyCharacter = new MenuItem();
            MenuSplitterItem2 = new MenuSplitterItem();
            btnDontSell = new MenuItem();
            btnDontStore = new MenuItem();
            btnDontPickup = new MenuItem();
            filterPanel = new SDUI.Panel();
            groupOthers = new SDUI.GroupBox();
            checkAlchemy = new SDUI.CheckBox();
            checkQuest = new SDUI.CheckBox();
            checkAmmo = new SDUI.CheckBox();
            checkCoin = new SDUI.CheckBox();
            checkOther = new SDUI.CheckBox();
            Splitter1 = new SDUI.Splitter();
            groupWeapons = new SDUI.GroupBox();
            checkAxe = new SDUI.CheckBox();
            checkHarp = new SDUI.CheckBox();
            checkDagger = new SDUI.CheckBox();
            checkXBow = new SDUI.CheckBox();
            checkWRod = new SDUI.CheckBox();
            checkShield = new SDUI.CheckBox();
            checkCRod = new SDUI.CheckBox();
            check2HSword = new SDUI.CheckBox();
            check1HSword = new SDUI.CheckBox();
            checkStaff = new SDUI.CheckBox();
            checkBow = new SDUI.CheckBox();
            checkSpear = new SDUI.CheckBox();
            checkGlave = new SDUI.CheckBox();
            checkSword = new SDUI.CheckBox();
            checkBlade = new SDUI.CheckBox();
            Splitter2 = new SDUI.Splitter();
            groupAccessories = new SDUI.GroupBox();
            checkNecklace = new SDUI.CheckBox();
            checkEarring = new SDUI.CheckBox();
            checkRing = new SDUI.CheckBox();
            Splitter3 = new SDUI.Splitter();
            groupClothes = new SDUI.GroupBox();
            checkHand = new SDUI.CheckBox();
            checkLegs = new SDUI.CheckBox();
            checkHeavy = new SDUI.CheckBox();
            checkLight = new SDUI.CheckBox();
            checkClothes = new SDUI.CheckBox();
            checkBoot = new SDUI.CheckBox();
            checkChest = new SDUI.CheckBox();
            checkShoulder = new SDUI.CheckBox();
            checkHead = new SDUI.CheckBox();
            Splitter4 = new SDUI.Splitter();
            groupGender = new SDUI.GroupBox();
            checkEuropean = new SDUI.CheckBox();
            checkChinese = new SDUI.CheckBox();
            checkFemale = new SDUI.CheckBox();
            checkBoxRareItems = new SDUI.CheckBox();
            checkMale = new SDUI.CheckBox();
            label3 = new SDUI.Label();
            numDegreeFrom = new SDUI.NumUpDown();
            numDegreeTo = new SDUI.NumUpDown();
            label4 = new SDUI.Label();
            panel3 = new SDUI.Panel();
            panel7 = new SDUI.Panel();
            labelResult = new SDUI.Label();
            btnResetFilter = new SDUI.Button();
            btnSearch = new SDUI.Button();
            btnReload = new SDUI.Button();
            txtSellSearch = new SDUI.TextBox();
            pictureBox1 = new PictureBox();
            tabPage1 = new TabPage();
            groupBoxOptions = new SDUI.GroupBox();
            checkPickupGold = new SDUI.CheckBox();
            checkAllEquips = new SDUI.CheckBox();
            checkEverything = new SDUI.CheckBox();
            checkPickupRare = new SDUI.CheckBox();
            checkQuestItems = new SDUI.CheckBox();
            checkPickupBlue = new SDUI.CheckBox();
            groupBoxGeneral = new SDUI.GroupBox();
            cbDontPickupWhileBotting = new SDUI.CheckBox();
            cbJustpickmyitems = new SDUI.CheckBox();
            checkDontPickupInBerzerk = new SDUI.CheckBox();
            checkEnableAbilityPet = new SDUI.CheckBox();
            contextShoppingList.SuspendLayout();
            contextAvailableProducts.SuspendLayout();
            tabMain.SuspendLayout();
            tabBuyFilter.SuspendLayout();
            ((ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabSellFilter.SuspendLayout();
            contextList.SuspendLayout();
            filterPanel.SuspendLayout();
            groupOthers.SuspendLayout();
            groupWeapons.SuspendLayout();
            groupAccessories.SuspendLayout();
            groupClothes.SuspendLayout();
            groupGender.SuspendLayout();
            panel3.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            tabPage1.SuspendLayout();
            groupBoxOptions.SuspendLayout();
            groupBoxGeneral.SuspendLayout();
            SuspendLayout();
            // 
            // contextShoppingList
            // 
            contextShoppingList.Items.AddRange(new MenuItem[] { menuChangeAmount, MenuSplitterItem1, menuRemoveItem });
            contextShoppingList.Name = "contextShoppingList";
            contextShoppingList.Size = new Size(136, 54);
            // 
            // menuChangeAmount
            // 
            menuChangeAmount.Text = "Change amount";
            menuChangeAmount.Click += menuChangeAmount_Click;
            // 
            // menuRemoveItem
            menuRemoveItem.Text = "Remove";
            menuRemoveItem.Click += menuRemoveItem_Click;
            // 
            // contextAvailableProducts
            // 
            contextAvailableProducts.Items.AddRange(new MenuItem[] { menuAddToShoppingList });
            contextAvailableProducts.Name = "contextAvailableProducts";
            contextAvailableProducts.Size = new Size(157, 26);
            // 
            // menuAddToShoppingList
            // 
            menuAddToShoppingList.Text = "Add to shopping list";
            menuAddToShoppingList.Click += menuAddToShoppingList_Click;
            // 
            // tabMain
            // 
            tabMain.TabPages.Add(tabBuyFilter);
            tabMain.TabPages.Add(tabSellFilter);
            tabMain.TabPages.Add(tabPage1);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.Radius = new Padding(4);
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(754, 473);
            tabMain.TabIndex = 7;
            // 
            // tabBuyFilter
            // 
            tabBuyFilter.Controls.Add(splitContainer);
            tabBuyFilter.Controls.Add(Splitter5);
            tabBuyFilter.Controls.Add(groupBox1);
            tabBuyFilter.Location = new Point(4, 28);
            tabBuyFilter.Name = "tabBuyFilter";
            tabBuyFilter.Padding = new Padding(8);
            tabBuyFilter.Size = new Size(746, 441);
            tabBuyFilter.TabIndex = 0;
            tabBuyFilter.Text = "Shopping";
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(8, 8);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(listAvailableProducts);
            splitContainer.Panel1.Controls.Add(panel1);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(listShoppingList);
            splitContainer.Panel2.Controls.Add(panel2);
            splitContainer.Size = new Size(730, 355);
            splitContainer.SplitterWidth = 1;
            splitContainer.TabIndex = 6;
            // 
            // listAvailableProducts
            // 
            listAvailableProducts.ContextMenu = contextAvailableProducts;
            listAvailableProducts.Dock = DockStyle.Fill;
            listAvailableProducts.Location = new Point(0, 57);
            listAvailableProducts.Name = "listAvailableProducts";
            listAvailableProducts.Size = new Size(336, 298);
            listAvailableProducts.TabIndex = 4;
            // 
            // colAvailableName
            // 
            colAvailableName.Text = "Name";
            colAvailableName.Width = 261;
            // 
            // panel1
            // 
            panel1.Border = new Padding(0, 0, 0, 1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(checkShowEquipment);
            panel1.Controls.Add(txtShopSearch);
            panel1.Controls.Add(comboStore);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.ShadowDepth = 4F;
            panel1.Size = new Size(336, 57);
            panel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 32);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Search:";
            // 
            // checkShowEquipment
            // 
            checkShowEquipment.AutoSize = true;
            checkShowEquipment.Location = new Point(212, 21);
            checkShowEquipment.Margin = new Padding(0);
            checkShowEquipment.Name = "checkShowEquipment";
            checkShowEquipment.Ripple = true;
            checkShowEquipment.Size = new Size(122, 30);
            checkShowEquipment.TabIndex = 9;
            checkShowEquipment.Text = "Show equipment";
            checkShowEquipment.UseVisualStyleBackColor = false;
            checkShowEquipment.CheckedChanged += checkShowEquipment_CheckedChanged;
            // 
            // txtShopSearch
            // 
            txtShopSearch.Location = new Point(61, 29);
            txtShopSearch.MaxLength = 32767;
            txtShopSearch.MultiLine = false;
            txtShopSearch.Name = "txtShopSearch";
            txtShopSearch.Size = new Size(144, 21);
            txtShopSearch.TabIndex = 8;
            txtShopSearch.UseSystemPasswordChar = false;
            txtShopSearch.TextChanged += txtShopSearch_TextChanged;
            // 
            // comboStore
            // 
            comboStore.Items.AddRange(new object[] { "Potion trader", "Stable keeper", "Protector trader", "Weapon trader", "Accessory trader" });
            comboStore.Location = new Point(61, 4);
            comboStore.Name = "comboStore";
            comboStore.ShadowDepth = 4F;
            comboStore.Size = new Size(144, 23);
            comboStore.TabIndex = 2;
            comboStore.SelectedIndexChanged += comboStore_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 5;
            label1.Text = "Store:";
            // 
            // listShoppingList
            // 
            listShoppingList.ContextMenu = contextShoppingList;
            listShoppingList.Dock = DockStyle.Fill;
            listViewGroup1.Header = "Potion trader";
            listViewGroup1.Name = "groupPotion";
            listViewGroup2.Header = "Stable keeper";
            listViewGroup2.Name = "groupStable";
            listViewGroup3.Header = "Protector trader";
            listViewGroup3.Name = "groupProtector";
            listViewGroup4.Header = "Weapon trader";
            listViewGroup4.Name = "groupWeapon";
            listViewGroup5.Header = "Accessory trader";
            listViewGroup5.Name = "groupAccessory";
            listShoppingList.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3, listViewGroup4, listViewGroup5 });
            listShoppingList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listShoppingList.Location = new Point(0, 57);
            listShoppingList.Name = "listShoppingList";
            listShoppingList.Size = new Size(393, 298);
            listShoppingList.TabIndex = 3;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 273;
            // 
            // colAmount
            // 
            colAmount.Text = "Amount";
            colAmount.Width = 95;
            // 
            // panel2
            // 
            panel2.Border = new Padding(0, 0, 0, 1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.ShadowDepth = 4F;
            panel2.Size = new Size(393, 57);
            panel2.TabIndex = 7;
            // 
            // Splitter5
            // 
            Splitter5.Dock = DockStyle.Bottom;
            Splitter5.Location = new Point(8, 363);
            Splitter5.Name = "Splitter5";
            Splitter5.Size = new Size(730, 10);
            Splitter5.TabIndex = 9;
            Splitter5.Text = "Splitter5";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkSellItemsFromPet);
            groupBox1.Controls.Add(checkStoreItemsFromPet);
            groupBox1.Controls.Add(checkRepairGear);
            groupBox1.Controls.Add(checkEnable);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(8, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 10, 3, 3);
            groupBox1.ShadowDepth = 4;
            groupBox1.Size = new Size(730, 60);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "General setup";
            // 
            // checkSellItemsFromPet
            // 
            checkSellItemsFromPet.AutoSize = true;
            checkSellItemsFromPet.Checked = true;
            checkSellItemsFromPet.CheckState = CheckState.Checked;
            checkSellItemsFromPet.Location = new Point(425, 27);
            checkSellItemsFromPet.Margin = new Padding(0);
            checkSellItemsFromPet.Name = "checkSellItemsFromPet";
            checkSellItemsFromPet.Ripple = true;
            checkSellItemsFromPet.Size = new Size(132, 30);
            checkSellItemsFromPet.TabIndex = 3;
            checkSellItemsFromPet.Text = "Sell items from pet";
            checkSellItemsFromPet.UseVisualStyleBackColor = false;
            checkSellItemsFromPet.CheckedChanged += checkShoppingSetting_CheckedChanged;
            // 
            // checkStoreItemsFromPet
            // 
            checkStoreItemsFromPet.AutoSize = true;
            checkStoreItemsFromPet.Checked = true;
            checkStoreItemsFromPet.CheckState = CheckState.Checked;
            checkStoreItemsFromPet.Location = new Point(567, 27);
            checkStoreItemsFromPet.Margin = new Padding(0);
            checkStoreItemsFromPet.Name = "checkStoreItemsFromPet";
            checkStoreItemsFromPet.Ripple = true;
            checkStoreItemsFromPet.Size = new Size(142, 30);
            checkStoreItemsFromPet.TabIndex = 4;
            checkStoreItemsFromPet.Text = "Store items from pet";
            checkStoreItemsFromPet.UseVisualStyleBackColor = false;
            checkStoreItemsFromPet.CheckedChanged += checkShoppingSetting_CheckedChanged;
            // 
            // checkRepairGear
            // 
            checkRepairGear.AutoSize = true;
            checkRepairGear.Checked = true;
            checkRepairGear.CheckState = CheckState.Checked;
            checkRepairGear.Location = new Point(231, 27);
            checkRepairGear.Margin = new Padding(0);
            checkRepairGear.Name = "checkRepairGear";
            checkRepairGear.Ripple = true;
            checkRepairGear.Size = new Size(179, 30);
            checkRepairGear.TabIndex = 1;
            checkRepairGear.Text = "Automaticaly repair all gear";
            checkRepairGear.UseVisualStyleBackColor = false;
            checkRepairGear.CheckedChanged += checkShoppingSetting_CheckedChanged;
            // 
            // checkEnable
            // 
            checkEnable.AutoSize = true;
            checkEnable.Checked = true;
            checkEnable.CheckState = CheckState.Checked;
            checkEnable.Location = new Point(13, 27);
            checkEnable.Margin = new Padding(0);
            checkEnable.Name = "checkEnable";
            checkEnable.Ripple = true;
            checkEnable.Size = new Size(200, 30);
            checkEnable.TabIndex = 0;
            checkEnable.Text = "Automaticaly run when in town";
            checkEnable.UseVisualStyleBackColor = false;
            checkEnable.CheckedChanged += checkShoppingSetting_CheckedChanged;
            // 
            // tabSellFilter
            // 
            tabSellFilter.Controls.Add(listFilter);
            tabSellFilter.Controls.Add(filterPanel);
            tabSellFilter.Controls.Add(panel3);
            tabSellFilter.Controls.Add(pictureBox1);
            tabSellFilter.Location = new Point(4, 28);
            tabSellFilter.Name = "tabSellFilter";
            tabSellFilter.Size = new Size(746, 441);
            tabSellFilter.TabIndex = 1;
            tabSellFilter.Text = "Item filter";
            // 
            // listFilter
            // 
            listFilter.ContextMenu = contextList;
            listFilter.Dock = DockStyle.Fill;
            listFilter.Location = new Point(265, 0);
            listFilter.Name = "listFilter";
            listFilter.Size = new Size(481, 405);
            listFilter.TabIndex = 5;
            // 
            // colItemName
            // 
            colItemName.Text = "Name";
            colItemName.Width = 150;
            // 
            // colItemLevel
            // 
            colItemLevel.Text = "Level";
            colItemLevel.Width = 59;
            // 
            // colGender
            // 
            colGender.Text = "Gender";
            colGender.Width = 73;
            // 
            // colPickup
            // 
            colPickup.Text = "Pickup";
            // 
            // colSell
            // 
            colSell.Text = "Sell";
            // 
            // collStore
            // 
            collStore.Text = "Store";
            // 
            // contextList
            // 
            contextList.Items.AddRange(new MenuItem[] { btnAddToSell, btnAddToStore, btnPickup, btnPickOnlyCharacter, MenuSplitterItem2, btnDontSell, btnDontStore, btnDontPickup });
            contextList.Name = "contextSellList";
            contextList.Size = new Size(207, 164);
            contextList.Opening += contextList_Opening;
            // 
            // btnAddToSell
            // 
            btnAddToSell.Text = "Sell";
            btnAddToSell.Click += btnAddToSell_Click;
            // 
            // btnAddToStore
            // 
            btnAddToStore.Text = "Store";
            btnAddToStore.Click += btnAddToStore_Click;
            // 
            // btnPickup
            // 
            btnPickup.Text = "Pickup";
            btnPickup.Click += btnPickup_Click;
            // 
            // btnPickOnlyCharacter
            // 
            btnPickOnlyCharacter.Text = "Pickup only character";
            btnPickOnlyCharacter.Click += btnPickOnlyCharacter_Click;
            // 
            // btnDontSell
            // 
            btnDontSell.Text = "Don't sell";
            btnDontSell.Click += btnDontSell_Click;
            // 
            // btnDontStore
            // 
            btnDontStore.Text = "Don't store";
            btnDontStore.Click += btnDontStore_Click;
            // 
            // btnDontPickup
            // 
            btnDontPickup.Text = "Don't pickup";
            btnDontPickup.Click += btnDontPickup_Click;
            // 
            // filterPanel
            // 
            filterPanel.AutoScroll = true;
            filterPanel.Border = new Padding(0, 0, 1, 0);
            filterPanel.Controls.Add(groupOthers);
            filterPanel.Controls.Add(Splitter1);
            filterPanel.Controls.Add(groupWeapons);
            filterPanel.Controls.Add(Splitter2);
            filterPanel.Controls.Add(groupAccessories);
            filterPanel.Controls.Add(Splitter3);
            filterPanel.Controls.Add(groupClothes);
            filterPanel.Controls.Add(Splitter4);
            filterPanel.Controls.Add(groupGender);
            filterPanel.Dock = DockStyle.Left;
            filterPanel.Location = new Point(0, 0);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(12);
            filterPanel.ShadowDepth = 4F;
            filterPanel.Size = new Size(265, 405);
            filterPanel.TabIndex = 20;
            // 
            // groupOthers
            // 
            groupOthers.Controls.Add(checkAlchemy);
            groupOthers.Controls.Add(checkQuest);
            groupOthers.Controls.Add(checkAmmo);
            groupOthers.Controls.Add(checkCoin);
            groupOthers.Controls.Add(checkOther);
            groupOthers.Dock = DockStyle.Top;
            groupOthers.Location = new Point(12, 611);
            groupOthers.Name = "groupOthers";
            groupOthers.Padding = new Padding(3, 10, 3, 3);
            groupOthers.ShadowDepth = 4;
            groupOthers.Size = new Size(224, 111);
            groupOthers.TabIndex = 42;
            groupOthers.TabStop = false;
            groupOthers.Text = "Others";
            // 
            // checkAlchemy
            // 
            checkAlchemy.AutoSize = true;
            checkAlchemy.Location = new Point(97, 53);
            checkAlchemy.Margin = new Padding(0);
            checkAlchemy.Name = "checkAlchemy";
            checkAlchemy.Ripple = true;
            checkAlchemy.Size = new Size(76, 30);
            checkAlchemy.TabIndex = 19;
            checkAlchemy.Text = "Alchemy";
            checkAlchemy.UseVisualStyleBackColor = false;
            // 
            // checkQuest
            // 
            checkQuest.AutoSize = true;
            checkQuest.Location = new Point(9, 29);
            checkQuest.Margin = new Padding(0);
            checkQuest.Name = "checkQuest";
            checkQuest.Ripple = true;
            checkQuest.Size = new Size(62, 30);
            checkQuest.TabIndex = 19;
            checkQuest.Text = "Quest";
            checkQuest.UseVisualStyleBackColor = false;
            // 
            // checkAmmo
            // 
            checkAmmo.AutoSize = true;
            checkAmmo.Location = new Point(9, 53);
            checkAmmo.Margin = new Padding(0);
            checkAmmo.Name = "checkAmmo";
            checkAmmo.Ripple = true;
            checkAmmo.Size = new Size(66, 30);
            checkAmmo.TabIndex = 19;
            checkAmmo.Text = "Ammo";
            checkAmmo.UseVisualStyleBackColor = false;
            // 
            // checkCoin
            // 
            checkCoin.AutoSize = true;
            checkCoin.Location = new Point(97, 29);
            checkCoin.Margin = new Padding(0);
            checkCoin.Name = "checkCoin";
            checkCoin.Ripple = true;
            checkCoin.Size = new Size(54, 30);
            checkCoin.TabIndex = 19;
            checkCoin.Text = "Coin";
            checkCoin.UseVisualStyleBackColor = false;
            // 
            // checkOther
            // 
            checkOther.AutoSize = true;
            checkOther.Location = new Point(9, 78);
            checkOther.Margin = new Padding(0);
            checkOther.Name = "checkOther";
            checkOther.Ripple = true;
            checkOther.Size = new Size(61, 30);
            checkOther.TabIndex = 19;
            checkOther.Text = "Other";
            checkOther.UseVisualStyleBackColor = false;
            // 
            // Splitter1
            // 
            Splitter1.Dock = DockStyle.Top;
            Splitter1.Location = new Point(12, 601);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new Size(224, 10);
            Splitter1.TabIndex = 5;
            Splitter1.Text = "Splitter1";
            // 
            // groupWeapons
            // 
            groupWeapons.Controls.Add(checkAxe);
            groupWeapons.Controls.Add(checkHarp);
            groupWeapons.Controls.Add(checkDagger);
            groupWeapons.Controls.Add(checkXBow);
            groupWeapons.Controls.Add(checkWRod);
            groupWeapons.Controls.Add(checkShield);
            groupWeapons.Controls.Add(checkCRod);
            groupWeapons.Controls.Add(check2HSword);
            groupWeapons.Controls.Add(check1HSword);
            groupWeapons.Controls.Add(checkStaff);
            groupWeapons.Controls.Add(checkBow);
            groupWeapons.Controls.Add(checkSpear);
            groupWeapons.Controls.Add(checkGlave);
            groupWeapons.Controls.Add(checkSword);
            groupWeapons.Controls.Add(checkBlade);
            groupWeapons.Dock = DockStyle.Top;
            groupWeapons.Location = new Point(12, 384);
            groupWeapons.Margin = new Padding(6);
            groupWeapons.Name = "groupWeapons";
            groupWeapons.Padding = new Padding(3, 10, 3, 3);
            groupWeapons.ShadowDepth = 4;
            groupWeapons.Size = new Size(224, 217);
            groupWeapons.TabIndex = 40;
            groupWeapons.TabStop = false;
            groupWeapons.Text = "Weapons";
            // 
            // checkAxe
            // 
            checkAxe.AutoSize = true;
            checkAxe.Location = new Point(99, 180);
            checkAxe.Margin = new Padding(0);
            checkAxe.Name = "checkAxe";
            checkAxe.Ripple = true;
            checkAxe.Size = new Size(50, 30);
            checkAxe.TabIndex = 10;
            checkAxe.Text = "Axe";
            checkAxe.UseVisualStyleBackColor = false;
            // 
            // checkHarp
            // 
            checkHarp.AutoSize = true;
            checkHarp.Location = new Point(7, 180);
            checkHarp.Margin = new Padding(0);
            checkHarp.Name = "checkHarp";
            checkHarp.Ripple = true;
            checkHarp.Size = new Size(56, 30);
            checkHarp.TabIndex = 10;
            checkHarp.Text = "Harp";
            checkHarp.UseVisualStyleBackColor = false;
            // 
            // checkDagger
            // 
            checkDagger.AutoSize = true;
            checkDagger.Location = new Point(99, 155);
            checkDagger.Margin = new Padding(0);
            checkDagger.Name = "checkDagger";
            checkDagger.Ripple = true;
            checkDagger.Size = new Size(70, 30);
            checkDagger.TabIndex = 9;
            checkDagger.Text = "Dagger";
            checkDagger.UseVisualStyleBackColor = false;
            // 
            // checkXBow
            // 
            checkXBow.AutoSize = true;
            checkXBow.Location = new Point(7, 155);
            checkXBow.Margin = new Padding(0);
            checkXBow.Name = "checkXBow";
            checkXBow.Ripple = true;
            checkXBow.Size = new Size(65, 30);
            checkXBow.TabIndex = 9;
            checkXBow.Text = "X-Bow";
            checkXBow.UseVisualStyleBackColor = false;
            // 
            // checkWRod
            // 
            checkWRod.AutoSize = true;
            checkWRod.Location = new Point(99, 130);
            checkWRod.Margin = new Padding(0);
            checkWRod.Name = "checkWRod";
            checkWRod.Ripple = true;
            checkWRod.Size = new Size(68, 30);
            checkWRod.TabIndex = 8;
            checkWRod.Text = "W-Rod";
            checkWRod.UseVisualStyleBackColor = false;
            // 
            // checkShield
            // 
            checkShield.AutoSize = true;
            checkShield.Location = new Point(161, 180);
            checkShield.Margin = new Padding(0);
            checkShield.Name = "checkShield";
            checkShield.Ripple = true;
            checkShield.Size = new Size(63, 30);
            checkShield.TabIndex = 5;
            checkShield.Text = "Shield";
            checkShield.UseVisualStyleBackColor = false;
            // 
            // checkCRod
            // 
            checkCRod.AutoSize = true;
            checkCRod.Location = new Point(7, 130);
            checkCRod.Margin = new Padding(0);
            checkCRod.Name = "checkCRod";
            checkCRod.Ripple = true;
            checkCRod.Size = new Size(64, 30);
            checkCRod.TabIndex = 7;
            checkCRod.Text = "C-Rod";
            checkCRod.UseVisualStyleBackColor = false;
            // 
            // check2HSword
            // 
            check2HSword.AutoSize = true;
            check2HSword.Location = new Point(99, 105);
            check2HSword.Margin = new Padding(0);
            check2HSword.Name = "check2HSword";
            check2HSword.Ripple = true;
            check2HSword.Size = new Size(83, 30);
            check2HSword.TabIndex = 6;
            check2HSword.Text = "2H Sword";
            check2HSword.UseVisualStyleBackColor = false;
            // 
            // check1HSword
            // 
            check1HSword.AutoSize = true;
            check1HSword.Location = new Point(7, 105);
            check1HSword.Margin = new Padding(0);
            check1HSword.Name = "check1HSword";
            check1HSword.Ripple = true;
            check1HSword.Size = new Size(83, 30);
            check1HSword.TabIndex = 5;
            check1HSword.Text = "1H Sword";
            check1HSword.UseVisualStyleBackColor = false;
            // 
            // checkStaff
            // 
            checkStaff.AutoSize = true;
            checkStaff.Location = new Point(99, 80);
            checkStaff.Margin = new Padding(0);
            checkStaff.Name = "checkStaff";
            checkStaff.Ripple = true;
            checkStaff.Size = new Size(54, 30);
            checkStaff.TabIndex = 5;
            checkStaff.Text = "Staff";
            checkStaff.UseVisualStyleBackColor = false;
            // 
            // checkBow
            // 
            checkBow.AutoSize = true;
            checkBow.Location = new Point(7, 80);
            checkBow.Margin = new Padding(0);
            checkBow.Name = "checkBow";
            checkBow.Ripple = true;
            checkBow.Size = new Size(53, 30);
            checkBow.TabIndex = 4;
            checkBow.Text = "Bow";
            checkBow.UseVisualStyleBackColor = false;
            // 
            // checkSpear
            // 
            checkSpear.AutoSize = true;
            checkSpear.Location = new Point(99, 55);
            checkSpear.Margin = new Padding(0);
            checkSpear.Name = "checkSpear";
            checkSpear.Ripple = true;
            checkSpear.Size = new Size(60, 30);
            checkSpear.TabIndex = 3;
            checkSpear.Text = "Spear";
            checkSpear.UseVisualStyleBackColor = false;
            // 
            // checkGlave
            // 
            checkGlave.AutoSize = true;
            checkGlave.Location = new Point(7, 55);
            checkGlave.Margin = new Padding(0);
            checkGlave.Name = "checkGlave";
            checkGlave.Ripple = true;
            checkGlave.Size = new Size(60, 30);
            checkGlave.TabIndex = 2;
            checkGlave.Text = "Glave";
            checkGlave.UseVisualStyleBackColor = false;
            // 
            // checkSword
            // 
            checkSword.AutoSize = true;
            checkSword.Location = new Point(99, 30);
            checkSword.Margin = new Padding(0);
            checkSword.Name = "checkSword";
            checkSword.Ripple = true;
            checkSword.Size = new Size(64, 30);
            checkSword.TabIndex = 1;
            checkSword.Text = "Sword";
            checkSword.UseVisualStyleBackColor = false;
            // 
            // checkBlade
            // 
            checkBlade.AutoSize = true;
            checkBlade.Location = new Point(7, 30);
            checkBlade.Margin = new Padding(0);
            checkBlade.Name = "checkBlade";
            checkBlade.Ripple = true;
            checkBlade.Size = new Size(60, 30);
            checkBlade.TabIndex = 0;
            checkBlade.Text = "Blade";
            checkBlade.UseVisualStyleBackColor = false;
            // 
            // Splitter2
            // 
            Splitter2.Dock = DockStyle.Top;
            Splitter2.Location = new Point(12, 374);
            Splitter2.Name = "Splitter2";
            Splitter2.Size = new Size(224, 10);
            Splitter2.TabIndex = 45;
            Splitter2.Text = "Splitter2";
            // 
            // groupAccessories
            // 
            groupAccessories.Controls.Add(checkNecklace);
            groupAccessories.Controls.Add(checkEarring);
            groupAccessories.Controls.Add(checkRing);
            groupAccessories.Dock = DockStyle.Top;
            groupAccessories.Location = new Point(12, 316);
            groupAccessories.Name = "groupAccessories";
            groupAccessories.Padding = new Padding(3, 10, 3, 3);
            groupAccessories.ShadowDepth = 4;
            groupAccessories.Size = new Size(224, 58);
            groupAccessories.TabIndex = 44;
            groupAccessories.TabStop = false;
            groupAccessories.Text = "Accessories";
            // 
            // checkNecklace
            // 
            checkNecklace.AutoSize = true;
            checkNecklace.Location = new Point(65, 26);
            checkNecklace.Margin = new Padding(0);
            checkNecklace.Name = "checkNecklace";
            checkNecklace.Ripple = true;
            checkNecklace.Size = new Size(79, 30);
            checkNecklace.TabIndex = 4;
            checkNecklace.Text = "Necklace";
            checkNecklace.UseVisualStyleBackColor = false;
            // 
            // checkEarring
            // 
            checkEarring.AutoSize = true;
            checkEarring.Location = new Point(151, 26);
            checkEarring.Margin = new Padding(0);
            checkEarring.Name = "checkEarring";
            checkEarring.Ripple = true;
            checkEarring.Size = new Size(68, 30);
            checkEarring.TabIndex = 3;
            checkEarring.Text = "Earring";
            checkEarring.UseVisualStyleBackColor = false;
            // 
            // checkRing
            // 
            checkRing.AutoSize = true;
            checkRing.Location = new Point(5, 26);
            checkRing.Margin = new Padding(0);
            checkRing.Name = "checkRing";
            checkRing.Ripple = true;
            checkRing.Size = new Size(54, 30);
            checkRing.TabIndex = 2;
            checkRing.Text = "Ring";
            checkRing.UseVisualStyleBackColor = false;
            // 
            // Splitter3
            // 
            Splitter3.Dock = DockStyle.Top;
            Splitter3.Location = new Point(12, 306);
            Splitter3.Name = "Splitter3";
            Splitter3.Size = new Size(224, 10);
            Splitter3.TabIndex = 46;
            Splitter3.Text = "Splitter3";
            // 
            // groupClothes
            // 
            groupClothes.Controls.Add(checkHand);
            groupClothes.Controls.Add(checkLegs);
            groupClothes.Controls.Add(checkHeavy);
            groupClothes.Controls.Add(checkLight);
            groupClothes.Controls.Add(checkClothes);
            groupClothes.Controls.Add(checkBoot);
            groupClothes.Controls.Add(checkChest);
            groupClothes.Controls.Add(checkShoulder);
            groupClothes.Controls.Add(checkHead);
            groupClothes.Dock = DockStyle.Top;
            groupClothes.Location = new Point(12, 161);
            groupClothes.Name = "groupClothes";
            groupClothes.Padding = new Padding(3, 10, 3, 3);
            groupClothes.ShadowDepth = 4;
            groupClothes.Size = new Size(224, 145);
            groupClothes.TabIndex = 41;
            groupClothes.TabStop = false;
            groupClothes.Text = "Clothes";
            // 
            // checkHand
            // 
            checkHand.AutoSize = true;
            checkHand.Location = new Point(93, 106);
            checkHand.Margin = new Padding(0);
            checkHand.Name = "checkHand";
            checkHand.Ripple = true;
            checkHand.Size = new Size(59, 30);
            checkHand.TabIndex = 8;
            checkHand.Text = "Hand";
            checkHand.UseVisualStyleBackColor = false;
            // 
            // checkLegs
            // 
            checkLegs.AutoSize = true;
            checkLegs.Location = new Point(5, 106);
            checkLegs.Margin = new Padding(0);
            checkLegs.Name = "checkLegs";
            checkLegs.Ripple = true;
            checkLegs.Size = new Size(49, 30);
            checkLegs.TabIndex = 7;
            checkLegs.Text = "Leg";
            checkLegs.UseVisualStyleBackColor = false;
            // 
            // checkHeavy
            // 
            checkHeavy.AutoSize = true;
            checkHeavy.Location = new Point(158, 28);
            checkHeavy.Margin = new Padding(0);
            checkHeavy.Name = "checkHeavy";
            checkHeavy.Ripple = true;
            checkHeavy.Size = new Size(63, 30);
            checkHeavy.TabIndex = 6;
            checkHeavy.Text = "Heavy";
            checkHeavy.UseVisualStyleBackColor = false;
            // 
            // checkLight
            // 
            checkLight.AutoSize = true;
            checkLight.Location = new Point(93, 28);
            checkLight.Margin = new Padding(0);
            checkLight.Name = "checkLight";
            checkLight.Ripple = true;
            checkLight.Size = new Size(57, 30);
            checkLight.TabIndex = 6;
            checkLight.Text = "Light";
            checkLight.UseVisualStyleBackColor = false;
            // 
            // checkClothes
            // 
            checkClothes.AutoSize = true;
            checkClothes.Location = new Point(5, 28);
            checkClothes.Margin = new Padding(0);
            checkClothes.Name = "checkClothes";
            checkClothes.Ripple = true;
            checkClothes.Size = new Size(70, 30);
            checkClothes.TabIndex = 6;
            checkClothes.Text = "Clothes";
            checkClothes.UseVisualStyleBackColor = false;
            // 
            // checkBoot
            // 
            checkBoot.AutoSize = true;
            checkBoot.Location = new Point(93, 81);
            checkBoot.Margin = new Padding(0);
            checkBoot.Name = "checkBoot";
            checkBoot.Ripple = true;
            checkBoot.Size = new Size(55, 30);
            checkBoot.TabIndex = 4;
            checkBoot.Text = "Boot";
            checkBoot.UseVisualStyleBackColor = false;
            // 
            // checkChest
            // 
            checkChest.AutoSize = true;
            checkChest.Location = new Point(5, 81);
            checkChest.Margin = new Padding(0);
            checkChest.Name = "checkChest";
            checkChest.Ripple = true;
            checkChest.Size = new Size(60, 30);
            checkChest.TabIndex = 4;
            checkChest.Text = "Chest";
            checkChest.UseVisualStyleBackColor = false;
            // 
            // checkShoulder
            // 
            checkShoulder.AutoSize = true;
            checkShoulder.Location = new Point(93, 56);
            checkShoulder.Margin = new Padding(0);
            checkShoulder.Name = "checkShoulder";
            checkShoulder.Ripple = true;
            checkShoulder.Size = new Size(78, 30);
            checkShoulder.TabIndex = 4;
            checkShoulder.Text = "Shoulder";
            checkShoulder.UseVisualStyleBackColor = false;
            // 
            // checkHead
            // 
            checkHead.AutoSize = true;
            checkHead.Location = new Point(5, 56);
            checkHead.Margin = new Padding(0);
            checkHead.Name = "checkHead";
            checkHead.Ripple = true;
            checkHead.Size = new Size(58, 30);
            checkHead.TabIndex = 4;
            checkHead.Text = "Head";
            checkHead.UseVisualStyleBackColor = false;
            // 
            // Splitter4
            // 
            Splitter4.Dock = DockStyle.Top;
            Splitter4.Location = new Point(12, 151);
            Splitter4.Name = "Splitter4";
            Splitter4.Size = new Size(224, 10);
            Splitter4.TabIndex = 47;
            Splitter4.Text = "Splitter4";
            // 
            // groupGender
            // 
            groupGender.Controls.Add(checkEuropean);
            groupGender.Controls.Add(checkChinese);
            groupGender.Controls.Add(checkFemale);
            groupGender.Controls.Add(checkBoxRareItems);
            groupGender.Controls.Add(checkMale);
            groupGender.Controls.Add(label3);
            groupGender.Controls.Add(numDegreeFrom);
            groupGender.Controls.Add(numDegreeTo);
            groupGender.Controls.Add(label4);
            groupGender.Dock = DockStyle.Top;
            groupGender.Location = new Point(12, 12);
            groupGender.Margin = new Padding(6);
            groupGender.Name = "groupGender";
            groupGender.Padding = new Padding(3, 10, 3, 3);
            groupGender.ShadowDepth = 4;
            groupGender.Size = new Size(224, 139);
            groupGender.TabIndex = 44;
            groupGender.TabStop = false;
            groupGender.Text = "Gender and Degree";
            // 
            // checkEuropean
            // 
            checkEuropean.AutoSize = true;
            checkEuropean.Location = new Point(99, 53);
            checkEuropean.Margin = new Padding(0);
            checkEuropean.Name = "checkEuropean";
            checkEuropean.Ripple = true;
            checkEuropean.Size = new Size(81, 30);
            checkEuropean.TabIndex = 9;
            checkEuropean.Text = "European";
            checkEuropean.UseVisualStyleBackColor = false;
            // 
            // checkChinese
            // 
            checkChinese.AutoSize = true;
            checkChinese.Location = new Point(16, 53);
            checkChinese.Margin = new Padding(0);
            checkChinese.Name = "checkChinese";
            checkChinese.Ripple = true;
            checkChinese.Size = new Size(72, 30);
            checkChinese.TabIndex = 9;
            checkChinese.Text = "Chinese";
            checkChinese.UseVisualStyleBackColor = false;
            // 
            // checkFemale
            // 
            checkFemale.AutoSize = true;
            checkFemale.Location = new Point(99, 30);
            checkFemale.Margin = new Padding(0);
            checkFemale.Name = "checkFemale";
            checkFemale.Ripple = true;
            checkFemale.Size = new Size(68, 30);
            checkFemale.TabIndex = 9;
            checkFemale.Text = "Female";
            checkFemale.UseVisualStyleBackColor = false;
            // 
            // checkBoxRareItems
            // 
            checkBoxRareItems.AutoSize = true;
            checkBoxRareItems.Location = new Point(16, 76);
            checkBoxRareItems.Margin = new Padding(0);
            checkBoxRareItems.Name = "checkBoxRareItems";
            checkBoxRareItems.Ripple = true;
            checkBoxRareItems.Size = new Size(84, 30);
            checkBoxRareItems.TabIndex = 40;
            checkBoxRareItems.Text = "Rare (Sox)";
            checkBoxRareItems.UseVisualStyleBackColor = false;
            // 
            // checkMale
            // 
            checkMale.AutoSize = true;
            checkMale.Location = new Point(16, 30);
            checkMale.Margin = new Padding(0);
            checkMale.Name = "checkMale";
            checkMale.Ripple = true;
            checkMale.Size = new Size(56, 30);
            checkMale.TabIndex = 9;
            checkMale.Text = "Male";
            checkMale.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 113);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 31;
            label3.Text = "Degree:";
            // 
            // numDegreeFrom
            // 
            numDegreeFrom.Location = new Point(58, 109);
            numDegreeFrom.MinimumSize = new Size(80, 25);
            numDegreeFrom.Name = "numDegreeFrom";
            numDegreeFrom.Size = new Size(80, 25);
            numDegreeFrom.TabIndex = 32;
            // 
            // numDegreeTo
            // 
            numDegreeTo.Location = new Point(140, 109);
            numDegreeTo.MinimumSize = new Size(80, 25);
            numDegreeTo.Name = "numDegreeTo";
            numDegreeTo.Size = new Size(80, 25);
            numDegreeTo.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 109);
            label4.Name = "label4";
            label4.Size = new Size(18, 19);
            label4.TabIndex = 33;
            label4.Text = "~";
            // 
            // panel3
            // 
            panel3.Border = new Padding(0, 0, 0, 0);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(labelResult);
            panel3.Controls.Add(btnResetFilter);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(btnReload);
            panel3.Controls.Add(txtSellSearch);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 405);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.ShadowDepth = 4F;
            panel3.Size = new Size(746, 36);
            panel3.TabIndex = 40;
            // 
            // panel7
            // 
            panel7.Border = new Padding(0, 0, 0, 0);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.ShadowDepth = 4F;
            panel7.Size = new Size(746, 1);
            panel7.TabIndex = 41;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(280, 11);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 15);
            labelResult.TabIndex = 40;
            // 
            // btnResetFilter
            // 
            btnResetFilter.Location = new Point(12, 7);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.ShadowDepth = 4F;
            btnResetFilter.Size = new Size(96, 23);
            btnResetFilter.TabIndex = 39;
            btnResetFilter.Text = "Reset";
            btnResetFilter.UseVisualStyleBackColor = true;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(667, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDepth = 4F;
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnApply_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(112, 7);
            btnReload.Name = "btnReload";
            btnReload.ShadowDepth = 4F;
            btnReload.Size = new Size(137, 23);
            btnReload.TabIndex = 39;
            btnReload.Text = "Apply";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnApply_Click;
            // 
            // txtSellSearch
            // 
            txtSellSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtSellSearch.Location = new Point(442, 7);
            txtSellSearch.MaxLength = 32767;
            txtSellSearch.MultiLine = false;
            txtSellSearch.Name = "txtSellSearch";
            txtSellSearch.Size = new Size(221, 21);
            txtSellSearch.TabIndex = 20;
            txtSellSearch.UseSystemPasswordChar = false;
            txtSellSearch.KeyDown += txtSellSearch_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(465, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBoxOptions);
            tabPage1.Controls.Add(groupBoxGeneral);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(746, 441);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Pickup settings";
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.Controls.Add(checkPickupGold);
            groupBoxOptions.Controls.Add(checkAllEquips);
            groupBoxOptions.Controls.Add(checkEverything);
            groupBoxOptions.Controls.Add(checkPickupRare);
            groupBoxOptions.Controls.Add(checkQuestItems);
            groupBoxOptions.Controls.Add(checkPickupBlue);
            groupBoxOptions.Location = new Point(6, 117);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Padding = new Padding(3, 8, 3, 3);
            groupBoxOptions.ShadowDepth = 4;
            groupBoxOptions.Size = new Size(734, 100);
            groupBoxOptions.TabIndex = 0;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "Options";
            // 
            // checkPickupGold
            // 
            checkPickupGold.AutoSize = true;
            checkPickupGold.Checked = true;
            checkPickupGold.CheckState = CheckState.Checked;
            checkPickupGold.Location = new Point(15, 32);
            checkPickupGold.Margin = new Padding(0);
            checkPickupGold.Name = "checkPickupGold";
            checkPickupGold.Ripple = true;
            checkPickupGold.Size = new Size(94, 30);
            checkPickupGold.TabIndex = 0;
            checkPickupGold.Text = "Pickup gold";
            checkPickupGold.UseVisualStyleBackColor = false;
            checkPickupGold.CheckedChanged += checkPickupSettings_CheckedChanged;
            // 
            // checkAllEquips
            // 
            checkAllEquips.AutoSize = true;
            checkAllEquips.Location = new Point(272, 61);
            checkAllEquips.Margin = new Padding(0);
            checkAllEquips.Name = "checkAllEquips";
            checkAllEquips.Ripple = true;
            checkAllEquips.Size = new Size(148, 30);
            checkAllEquips.TabIndex = 4;
            checkAllEquips.Text = "Pickup all equip items";
            checkAllEquips.UseVisualStyleBackColor = false;
            checkAllEquips.CheckedChanged += checkPickupSettings_CheckedChanged;
            // 
            // checkEverything
            // 
            checkEverything.AutoSize = true;
            checkEverything.Location = new Point(506, 61);
            checkEverything.Margin = new Padding(0);
            checkEverything.Name = "checkEverything";
            checkEverything.Ripple = true;
            checkEverything.Size = new Size(126, 30);
            checkEverything.TabIndex = 5;
            checkEverything.Text = "Pickup everything";
            checkEverything.UseVisualStyleBackColor = false;
            checkEverything.CheckedChanged += checkPickupSettings_CheckedChanged;
            // 
            // checkPickupRare
            // 
            checkPickupRare.AutoSize = true;
            checkPickupRare.Checked = true;
            checkPickupRare.CheckState = CheckState.Checked;
            checkPickupRare.Location = new Point(15, 61);
            checkPickupRare.Margin = new Padding(0);
            checkPickupRare.Name = "checkPickupRare";
            checkPickupRare.Ripple = true;
            checkPickupRare.Size = new Size(164, 30);
            checkPickupRare.TabIndex = 3;
            checkPickupRare.Text = "Always pickup rare items";
            checkPickupRare.UseVisualStyleBackColor = false;
            checkPickupRare.CheckedChanged += checkPickupSettings_CheckedChanged;
            // 
            // checkQuestItems
            // 
            checkQuestItems.AutoSize = true;
            checkQuestItems.Location = new Point(506, 32);
            checkQuestItems.Margin = new Padding(0);
            checkQuestItems.Name = "checkQuestItems";
            checkQuestItems.Ripple = true;
            checkQuestItems.Size = new Size(132, 30);
            checkQuestItems.TabIndex = 2;
            checkQuestItems.Text = "Pickup quest items";
            checkQuestItems.UseVisualStyleBackColor = false;
            checkQuestItems.CheckedChanged += checkPickupSettings_CheckedChanged;
            // 
            // checkPickupBlue
            // 
            checkPickupBlue.AutoSize = true;
            checkPickupBlue.Location = new Point(272, 32);
            checkPickupBlue.Margin = new Padding(0);
            checkPickupBlue.Name = "checkPickupBlue";
            checkPickupBlue.Ripple = true;
            checkPickupBlue.Size = new Size(167, 30);
            checkPickupBlue.TabIndex = 1;
            checkPickupBlue.Text = "Always pickup blue items";
            checkPickupBlue.UseVisualStyleBackColor = false;
            checkPickupBlue.CheckedChanged += checkPickupSettings_CheckedChanged;
            // 
            // groupBoxGeneral
            // 
            groupBoxGeneral.Controls.Add(cbDontPickupWhileBotting);
            groupBoxGeneral.Controls.Add(cbJustpickmyitems);
            groupBoxGeneral.Controls.Add(checkDontPickupInBerzerk);
            groupBoxGeneral.Controls.Add(checkEnableAbilityPet);
            groupBoxGeneral.Location = new Point(6, 6);
            groupBoxGeneral.Name = "groupBoxGeneral";
            groupBoxGeneral.Padding = new Padding(3, 10, 3, 3);
            groupBoxGeneral.ShadowDepth = 4;
            groupBoxGeneral.Size = new Size(734, 95);
            groupBoxGeneral.TabIndex = 0;
            groupBoxGeneral.TabStop = false;
            groupBoxGeneral.Text = "General";
            // 
            // cbDontPickupWhileBotting
            // 
            cbDontPickupWhileBotting.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbDontPickupWhileBotting.AutoSize = true;
            cbDontPickupWhileBotting.Location = new Point(281, 56);
            cbDontPickupWhileBotting.Margin = new Padding(0);
            cbDontPickupWhileBotting.Name = "cbDontPickupWhileBotting";
            cbDontPickupWhileBotting.Ripple = true;
            cbDontPickupWhileBotting.Size = new Size(207, 30);
            cbDontPickupWhileBotting.TabIndex = 3;
            cbDontPickupWhileBotting.Text = "Don't pickup items while botting";
            cbDontPickupWhileBotting.UseVisualStyleBackColor = false;
            cbDontPickupWhileBotting.CheckedChanged += checkPickupSettings_CheckedChanged;
            // 
            // cbJustpickmyitems
            // 
            cbJustpickmyitems.AutoSize = true;
            cbJustpickmyitems.Location = new Point(281, 26);
            cbJustpickmyitems.Margin = new Padding(0);
            cbJustpickmyitems.Name = "cbJustpickmyitems";
            cbJustpickmyitems.Ripple = true;
            cbJustpickmyitems.Size = new Size(129, 30);
            cbJustpickmyitems.TabIndex = 1;
            cbJustpickmyitems.Text = "Just pick my items";
            cbJustpickmyitems.UseVisualStyleBackColor = false;
            cbJustpickmyitems.CheckedChanged += checkPickupSettings_CheckedChanged;
            // 
            // checkDontPickupInBerzerk
            // 
            checkDontPickupInBerzerk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkDontPickupInBerzerk.AutoSize = true;
            checkDontPickupInBerzerk.Location = new Point(15, 56);
            checkDontPickupInBerzerk.Margin = new Padding(0);
            checkDontPickupInBerzerk.Name = "checkDontPickupInBerzerk";
            checkDontPickupInBerzerk.Ripple = true;
            checkDontPickupInBerzerk.Size = new Size(224, 30);
            checkDontPickupInBerzerk.TabIndex = 2;
            checkDontPickupInBerzerk.Text = "Don't pickup items in berzerk mode";
            checkDontPickupInBerzerk.UseVisualStyleBackColor = false;
            checkDontPickupInBerzerk.CheckedChanged += checkPickupSettings_CheckedChanged;
            // 
            // checkEnableAbilityPet
            // 
            checkEnableAbilityPet.AutoSize = true;
            checkEnableAbilityPet.Checked = true;
            checkEnableAbilityPet.CheckState = CheckState.Checked;
            checkEnableAbilityPet.Location = new Point(15, 26);
            checkEnableAbilityPet.Margin = new Padding(0);
            checkEnableAbilityPet.Name = "checkEnableAbilityPet";
            checkEnableAbilityPet.Ripple = true;
            checkEnableAbilityPet.Size = new Size(195, 30);
            checkEnableAbilityPet.TabIndex = 0;
            checkEnableAbilityPet.Text = "Use ability pet to pickup items ";
            checkEnableAbilityPet.UseVisualStyleBackColor = false;
            checkEnableAbilityPet.CheckedChanged += checkPickupSettings_CheckedChanged;

            Controls.Add(tabMain);
            Name = "Main";
            Size = new Size(754, 473);
            contextShoppingList.ResumeLayout(false);
            contextAvailableProducts.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabBuyFilter.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabSellFilter.ResumeLayout(false);
            contextList.ResumeLayout(false);
            filterPanel.ResumeLayout(false);
            groupOthers.ResumeLayout(false);
            groupOthers.PerformLayout();
            groupWeapons.ResumeLayout(false);
            groupWeapons.PerformLayout();
            groupAccessories.ResumeLayout(false);
            groupAccessories.PerformLayout();
            groupClothes.ResumeLayout(false);
            groupClothes.PerformLayout();
            groupGender.ResumeLayout(false);
            groupGender.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            tabPage1.ResumeLayout(false);
            groupBoxOptions.ResumeLayout(false);
            groupBoxOptions.PerformLayout();
            groupBoxGeneral.ResumeLayout(false);
            groupBoxGeneral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SDUI.ContextMenu contextAvailableProducts;
        private MenuItem menuAddToShoppingList;
        private SDUI.ContextMenu contextShoppingList;
        private MenuItem menuChangeAmount;
        private MenuSplitterItem MenuSplitterItem1;
        private MenuItem menuRemoveItem;
        private SDUI.TabControl tabMain;
        private TabPage tabSellFilter;
        private SDUI.ListView listFilter;
        private ColumnHeader colItemName;
        private ColumnHeader colItemLevel;
        private ColumnHeader colSell;
        private ColumnHeader collStore;
        private SDUI.TextBox txtSellSearch;
        private ColumnHeader colGender;
        private SDUI.ContextMenu contextList;
        private MenuItem btnAddToSell;
        private MenuItem btnAddToStore;
        private SDUI.Button btnSearch;
        private MenuSplitterItem MenuSplitterItem2;
        private MenuItem btnDontSell;
        private MenuItem btnDontStore;
        private SDUI.Panel filterPanel;
        private SDUI.GroupBox groupOthers;
        private SDUI.CheckBox checkAlchemy;
        private SDUI.CheckBox checkOther;
        private SDUI.GroupBox groupClothes;
        private SDUI.GroupBox groupWeapons;
        private SDUI.Button btnReload;
        private SDUI.CheckBox checkBlade;
        private SDUI.CheckBox checkSword;
        private SDUI.CheckBox checkSpear;
        private SDUI.CheckBox checkGlave;
        private SDUI.CheckBox checkBow;
        private SDUI.CheckBox check2HSword;
        private SDUI.CheckBox check1HSword;
        private SDUI.CheckBox checkStaff;
        private SDUI.CheckBox checkWRod;
        private SDUI.CheckBox checkCRod;
        private SDUI.CheckBox checkXBow;
        private SDUI.CheckBox checkHarp;
        private SDUI.CheckBox checkDagger;
        private SDUI.CheckBox checkHead;
        private SDUI.CheckBox checkBoot;
        private SDUI.CheckBox checkChest;
        private SDUI.CheckBox checkShoulder;
        private SDUI.CheckBox checkShield;
        private SDUI.GroupBox groupAccessories;
        private SDUI.CheckBox checkEarring;
        private SDUI.CheckBox checkRing;
        private SDUI.CheckBox checkNecklace;
        private SDUI.GroupBox groupGender;
        private SDUI.Label label3;
        private SDUI.NumUpDown numDegreeFrom;
        private SDUI.NumUpDown numDegreeTo;
        private SDUI.Label label4;
        private SDUI.CheckBox checkLight;
        private SDUI.CheckBox checkClothes;
        private SDUI.CheckBox checkHeavy;
        private SDUI.CheckBox checkAxe;
        private SDUI.CheckBox checkLegs;
        private SDUI.CheckBox checkHand;
        private MenuItem btnPickup;
        private MenuItem btnDontPickup;
        private PictureBox pictureBox1;
        private TabPage tabPage1;
        private SDUI.GroupBox groupBoxGeneral;
        private SDUI.CheckBox checkPickupGold;
        private ColumnHeader colPickup;
        private SDUI.CheckBox checkPickupRare;
        private SDUI.CheckBox checkEnableAbilityPet;
        private SDUI.Button btnResetFilter;
        private SDUI.CheckBox checkDontPickupInBerzerk;
        private SDUI.CheckBox cbJustpickmyitems;
        private SDUI.CheckBox cbDontPickupWhileBotting;
        private SDUI.Panel panel3;
        private SDUI.Label labelResult;
        private SDUI.Panel panel7;
        private SDUI.CheckBox checkBoxRareItems;
        private SDUI.CheckBox checkEuropean;
        private SDUI.CheckBox checkChinese;
        private SDUI.CheckBox checkFemale;
        private SDUI.CheckBox checkMale;
        private SDUI.CheckBox checkQuest;
        private SDUI.CheckBox checkCoin;
        private SDUI.CheckBox checkAmmo;
        private TabPage tabBuyFilter;
        private SDUI.GroupBox groupBox1;
        private SDUI.CheckBox checkSellItemsFromPet;
        private SDUI.CheckBox checkRepairGear;
        private SDUI.CheckBox checkEnable;
        private SplitContainer splitContainer;
        private SDUI.ListView listAvailableProducts;
        private ColumnHeader colAvailableName;
        private SDUI.Panel panel1;
        private SDUI.Label label6;
        private SDUI.CheckBox checkShowEquipment;
        private SDUI.TextBox txtShopSearch;
        private SDUI.ComboBox comboStore;
        private SDUI.Label label1;
        private SDUI.ListView listShoppingList;
        private ColumnHeader colName;
        private ColumnHeader colAmount;
        private SDUI.Panel panel2;
        private SDUI.Splitter Splitter3;
        private SDUI.Splitter Splitter4;
        private SDUI.Splitter Splitter1;
        private SDUI.Splitter Splitter2;
        private SDUI.Splitter Splitter5;
        private SDUI.CheckBox checkStoreItemsFromPet;
        private SDUI.CheckBox checkPickupBlue;
        private MenuItem btnPickOnlyCharacter;
        private SDUI.CheckBox checkQuestItems;
        private SDUI.CheckBox checkAllEquips;
        private SDUI.CheckBox checkEverything;
        private SDUI.GroupBox groupBoxOptions;
    }
}
