using RSBot.Core;
using RSBot.Core.Client.ReferenceObjects;
using RSBot.Core.Event;
using RSBot.Core.Extensions;
using RSBot.Core.Network;
using RSBot.Core.Objects;
using RSBot.Core.Objects.Inventory;
using SDUI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Button = SDUI.Button;
using ListViewExtensions = RSBot.Core.Extensions.ListViewExtensions;

namespace RSBot.Inventory.Views;

[ToolboxItem(false)]
public partial class Main : Panel
{
    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    private readonly object _lock;

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    private int _selectedIndex;

    /// <summary>
    ///     Initializes a new instance of the <see cref="Main" /> class.
    /// </summary>
    public Main()
    {
        _lock = new object();
        InitializeComponent();
        SubscribeEvents();
    }

    /// <summary>
    ///     Subscribes the events.
    /// </summary>
    private void SubscribeEvents()
    {
        EventManager.SubscribeEvent("OnLoadCharacter", OnLoadCharacter);
        EventManager.SubscribeEvent("OnUpdateInventoryItem", new Action<byte>(OnUpdateInventoryItem));
        EventManager.SubscribeEvent("OnUseItem", new Action<byte>(OnUpdateInventoryItem));
        EventManager.SubscribeEvent("OnInventoryUpdate", UpdateInventoryList);
    }

    private void OnLoadCharacter()
    {
        UpdateInventoryList();
    }

    /// <summary>
    ///     Calling when update inventory item
    /// </summary>
    /// <param name="slot"></param>
    private void OnUpdateInventoryItem(byte slot)
    {
        var key = slot;
        if (!((key >= 0) && (key < listViewMain.Items.Count)))
            return;

        lock (_lock)
        {
            var inventoryItem = Game.Player.Inventory.GetItemAt(slot);
            if (inventoryItem == null)
                return;

            var listViewItem = listViewMain.Items[key];

            var name = inventoryItem.Record.GetRealName();
            if (inventoryItem.OptLevel > 0)
                name += " (+" + inventoryItem.OptLevel + ")";

            listViewItem.SubItems[0] = name;
            listViewItem.SubItems[1] = inventoryItem.Amount.ToString();

            if (inventoryItem.Record.IsEquip)
                listViewItem.SubItems[2] = inventoryItem.Record.GetRarityName();

            listViewItem.LoadItemImageAsync(inventoryItem.Record);
        }
    }

    /// <summary>
    ///     Updates the inventory list.
    /// </summary>
    public void UpdateInventoryList()
    {
        if (!Visible)
            return;

        if (Game.Player == null)
            return;

        lock (_lock)
        {
            listViewMain.Items.Clear();

            switch (_selectedIndex)
            {
                case 0:
                    var itemsPlayer = Game.Player.Inventory.GetNormalPartItems();
                    foreach (var item in itemsPlayer)
                        AddItem(item);

                    lblFreeSlots.Text = Game.Player.Inventory.FreeSlots + "/" + Game.Player.Inventory.Capacity;
                    break;

                case 1:

                    var items = Game.Player.Inventory.GetEquippedPartItems();
                    foreach (var item in items)
                        AddItem(item);

                    lblFreeSlots.Text = items.Count + " / 13";

                    break;

                case 2:

                    foreach (var item in Game.Player.Avatars)
                        AddItem(item);

                    lblFreeSlots.Text = "0";

                    break;

                case 3:

                    if (!Game.Player.HasActiveAbilityPet)
                    {
                        return;
                    }

                    foreach (var item in Game.Player.AbilityPet.Inventory)
                        AddItem(item);

                    lblFreeSlots.Text = Game.Player.AbilityPet.Inventory.FreeSlots + "/" +
                                        Game.Player.AbilityPet.Inventory.Capacity;

                    break;

                case 4:

                    if (Game.Player.Storage == null)
                    {
                        return;
                    }

                    foreach (var item in Game.Player.Storage)
                        AddItem(item);

                    lblFreeSlots.Text = Game.Player.Storage.FreeSlots + "/" + Game.Player.Storage.Capacity;

                    break;

                case 5:

                    if (Game.Player.GuildStorage == null)
                    {
                        return;
                    }

                    foreach (var item in Game.Player.GuildStorage)
                        AddItem(item);

                    lblFreeSlots.Text = Game.Player.GuildStorage.FreeSlots + "/" + Game.Player.GuildStorage.Capacity;

                    break;

                case 6:

                    if (Game.Player.JobTransport == null)
                    {
                        return;
                    }

                    foreach (var item in Game.Player.JobTransport.Inventory)
                        AddItem(item);

                    lblFreeSlots.Text = Game.Player.JobTransport.Inventory.FreeSlots + "/" +
                                        Game.Player.JobTransport.Inventory.Capacity;


                    break;

                case 7:

                    if (Game.Player.Job2SpecialtyBag == null)
                    {
                        return;
                    }

                    foreach (var item in Game.Player.Job2SpecialtyBag)
                        AddItem(item);

                    lblFreeSlots.Text = Game.Player.Job2SpecialtyBag.FreeSlots + "/" +
                                        Game.Player.Job2SpecialtyBag.Capacity;


                    break;

                case 8:

                    if (Game.Player.Job2 == null)
                    {
                        return;
                    }

                    foreach (var item in Game.Player.Job2)
                        AddItem(item);

                    lblFreeSlots.Text = Game.Player.Job2.FreeSlots + "/" + Game.Player.Job2.Capacity;

                    break;

                case 9:

                    if (!Game.Player.HasActiveFellowPet)
                    {
                        return;
                    }

                    foreach (var item in Game.Player.Fellow.Inventory)
                        AddItem(item);

                    lblFreeSlots.Text = Game.Player.Fellow.Inventory.FreeSlots + "/" +
                                        Game.Player.Fellow.Inventory.Capacity;


                    break;
            }

        }
    }

    /// <summary>
    ///     Adds the item.
    /// </summary>
    /// <param name="item">The item.</param>
    private void AddItem(InventoryItem item)
    {
        if (item == null)
            return;

        var name = item.Record?.GetRealName() ?? "";
        if (item.OptLevel > 0)
            name += " (+" + item.OptLevel + ")";

        var lvItem = new ListViewItem();
        lvItem.Text = name;

        listViewMain.Items.Add(lvItem);
        lvItem.Tag = item;
        lvItem.SubItems.Add(item.Amount.ToString());

        if (item.Record.IsEquip)
            lvItem.SubItems.Add(item.Record.GetRarityName());

        if (_selectedIndex == 0)
        {
            var useItemsAtTrainingPlace =
                PlayerConfig.GetArray<string>("RSBot.Inventory.ItemsAtTrainplace");

            //if (useItemsAtTrainingPlace.Contains(item.Record.CodeName))
            //    lvItem.Font = new Font(lvItem.Font, FontStyle.Bold);
        }

        lvItem.LoadItemImageAsync(item.Record);
    }

    /// <summary>
    ///     Handles the visible changed event of the parent.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void Main_VisibleChanged(object sender, EventArgs e)
    {
        UpdateInventoryList();
    }

    /// <summary>
    ///     Handles the Click event of the btnReload control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void buttonUseItem_Click(object sender, EventArgs e)
    {
        if (listViewMain.SelectedIndices.Count != 1)
            return;

        var listViewItem = listViewMain.SelectedItems[0];
        var inventoryItem = listViewItem.Tag as InventoryItem;
        inventoryItem?.Use();
    }

    /// <summary>
    ///     Handles the mouse double click event of the listviewmain control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void listViewMain_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (listViewMain.SelectedItems.Count <= 0)
            return;

        if (!Kernel.Debug)
            return;

        var itemForm = new ItemProperties(listViewMain.SelectedItems[0].Tag as InventoryItem);
        itemForm.Show();
    }

    /// <summary>
    ///     Handles the selected index changed event of the button's control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void ButtonSwitcher(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (_selectedIndex == button.TabIndex)
            return;

        _selectedIndex = button.TabIndex;

        //Only character inventory sorting is supported for now!
        btnSort.Visible = _selectedIndex == 0;
        checkAutoSort.Visible = _selectedIndex == 0;

        foreach (var control in topPanel.Controls.OfType<Button>())
        {
            if (control.TabIndex > 9)
                continue;

            //control.Color = Color.Transparent;

            //if (control == button)
            //{
            //    var backColor = ColorScheme.BorderColor.Determine().Alpha(85);
            //    control.ForeColor = backColor.Determine();
            //    control.Color = backColor;
            //}

            control.Invalidate();
        }

        UpdateInventoryList();
    }

    private void dropMenuItem_Click(object sender, EventArgs e)
    {
        if (listViewMain.SelectedIndices.Count != 1)
            return;

        var listViewItem = listViewMain.SelectedItems[0];
        var inventoryItem = listViewItem.Tag as InventoryItem;
        if (inventoryItem == null)
            return;

        var cos = _selectedIndex == 3;
        inventoryItem?.Drop(cos, Game.Player.AbilityPet.UniqueId);
    }

    private void ContextMenu_Opening(object sender, CancelEventArgs e)
    {
        if (listViewMain.SelectedIndices.Count != 1)
        {
            e.Cancel = true;
            return;
        }

        var listViewItem = listViewMain.SelectedItems[0];
        if (listViewItem.Tag is not InventoryItem inventoryItem)
            return;

        if (_selectedIndex != 0)
        {
            useMenuItem.Visible = false;
            moveToLastDeathPositionMenuItem.Visible = false;
            moveToLastRecallPositionMenuItem.Visible = false;
            moveToPetMenuItem.Visible = false;
            moveToPlayerMenuItem.Visible = _selectedIndex == 3;
            selectMapLocationMenuItem.Visible = false;
            return;
        }

        var canUse = (inventoryItem.Record.CanUse & ObjectUseType.Yes) != 0;
        if (canUse)
        {
            var useItems = PlayerConfig.GetArray<string>("RSBot.Inventory.ItemsAtTrainplace");
            useItemAtTrainingPlaceMenuItem.Checked = useItems.Contains(inventoryItem.Record.CodeName);
            useItemAtTrainingPlaceMenuItem.Enabled = true;

            var purposiveItems = PlayerConfig.GetArray<string>("RSBot.Inventory.AutoUseAccordingToPurpose");
            autoUseAccordingToPurposeMenuItem.Checked = purposiveItems.Contains(inventoryItem.Record.CodeName);
            autoUseAccordingToPurposeMenuItem.Enabled = true;
        }
        else
        {
            useItemAtTrainingPlaceMenuItem.Checked = false;
            useItemAtTrainingPlaceMenuItem.Enabled = false;

            autoUseAccordingToPurposeMenuItem.Checked = false;
            autoUseAccordingToPurposeMenuItem.Enabled = false;
        }

        var isReverseScroll = inventoryItem.Equals(new TypeIdFilter(3, 3, 3, 3));
        useMenuItem.Visible = !isReverseScroll;
        useMenuItem.Enabled = inventoryItem.Record.CanUse != ObjectUseType.No;
        moveToLastDeathPositionMenuItem.Visible = isReverseScroll;
        moveToLastRecallPositionMenuItem.Visible = isReverseScroll;
        selectMapLocationMenuItem.Visible = isReverseScroll;
        dropMenuItem.Visible = inventoryItem.Record.CanDrop != ObjectDropType.No;

        moveToPetMenuItem.Visible = Game.Player.AbilityPet != null && _selectedIndex != 3;
        moveToPlayerMenuItem.Visible = _selectedIndex == 3;

        if (isReverseScroll)
        {
            var tagItem = selectMapLocationMenuItem.Tag as InventoryItem;
            if (tagItem != inventoryItem)
            {
                selectMapLocationMenuItem.Tag = inventoryItem;
                selectMapLocationMenuItem.Items.Clear();

                foreach (var item in Game.ReferenceManager.OptionalTeleports)
                {
                    var mapName = Game.ReferenceManager.GetTranslation(item.Value.Region.ToString());

                    var menuItem = new MenuItem { Text = mapName };

                    menuItem.Click += (itemSender, itemEvent) => { inventoryItem.UseTo(7, item.Value.ID); };

                    selectMapLocationMenuItem.Items.Add(menuItem);
                }
            }
        }
    }

    private void moveToLastRecallPositionMenuItem_Click(object sender, EventArgs e)
    {
        if (listViewMain.SelectedIndices.Count != 1)
            return;

        var listViewItem = listViewMain.SelectedItems[0];
        var inventoryItem = listViewItem.Tag as InventoryItem;
        if (inventoryItem == null)
            return;

        inventoryItem.UseTo(2);
    }

    private void moveToLastDeathPositionMenuItem_Click(object sender, EventArgs e)
    {
        if (listViewMain.SelectedIndices.Count != 1)
            return;

        var listViewItem = listViewMain.SelectedItems[0];
        var inventoryItem = listViewItem.Tag as InventoryItem;
        if (inventoryItem == null)
            return;

        inventoryItem.UseTo(3);
    }

    private void moveToPetMenuItem_Click(object sender, EventArgs e)
    {
        if (listViewMain.SelectedIndices.Count != 1)
            return;

        var listViewItem = listViewMain.SelectedItems[0];
        var inventoryItem = listViewItem.Tag as InventoryItem;
        if (inventoryItem == null)
            return;

        if (Game.Player.AbilityPet != null)
            return;

        var freeSlot = Game.Player.AbilityPet.Inventory.GetFreeSlot();
        if (freeSlot == 0xFF)
            return;

        var packet = new Packet(0x7034);
        packet.WriteByte(InventoryOperation.SP_MOVE_ITEM_PC_PET);
        packet.WriteUInt(Game.Player.AbilityPet.UniqueId);
        packet.WriteByte(inventoryItem.Slot);
        packet.WriteByte(freeSlot);
        PacketManager.SendPacket(packet, PacketDestination.Server);
    }

    private void moveToPlayerMenuItem_Click(object sender, EventArgs e)
    {
        if (listViewMain.SelectedIndices.Count != 1)
            return;

        var listViewItem = listViewMain.SelectedItems[0];
        var inventoryItem = listViewItem.Tag as InventoryItem;
        if (inventoryItem == null)
            return;

        if (Game.Player.AbilityPet == null)
            return;

        var freeSlot = Game.Player.Inventory.GetFreeSlot();
        if (freeSlot == 0xFF)
            return;

        var packet = new Packet(0x7034);
        packet.WriteByte(InventoryOperation.SP_MOVE_ITEM_PET_PC);
        packet.WriteUInt(Game.Player.AbilityPet.UniqueId);
        packet.WriteByte(inventoryItem.Slot);
        packet.WriteByte(freeSlot);
        PacketManager.SendPacket(packet, PacketDestination.Server);
    }

    private void btnSort_Click(object sender, EventArgs e)
    {
        Task.Run(() => Game.Player?.Inventory?.Sort());
    }

    private void checkAutoSort_CheckedChanged(object sender, EventArgs e)
    {
        PlayerConfig.Set("RSBot.Inventory.AutoSort", checkAutoSort.Checked);
    }

    private void useItemAtTrainingPlaceMenuItem_Click(object sender, EventArgs e)
    {
        if (listViewMain.SelectedItems.Count == 0)
            return;

        var lvItem = listViewMain.SelectedItems[0];
        var itemsToUse = PlayerConfig.GetArray<string>("RSBot.Inventory.ItemsAtTrainplace").ToList();
        var selectedItem = (InventoryItem)lvItem.Tag;
        if (selectedItem == null)
            return;

        var useSelectedItem = itemsToUse.Contains(selectedItem.Record.CodeName);

        if (useSelectedItem)
        {
            itemsToUse.Remove(selectedItem.Record.CodeName);
        }
        else
        {
            itemsToUse.Add(selectedItem.Record.CodeName);
        }

        useItemAtTrainingPlaceMenuItem.Checked = !useItemAtTrainingPlaceMenuItem.Checked;
        PlayerConfig.SetArray("RSBot.Inventory.ItemsAtTrainplace", itemsToUse);
    }

    private void autoUseAccordingToPurposeMenuItem_Click(object sender, EventArgs e)
    {
        if (listViewMain.SelectedItems.Count == 0)
            return;

        var lvItem = listViewMain.SelectedItems[0];

        var itemsToUse = PlayerConfig.GetArray<string>("RSBot.Inventory.AutoUseAccordingToPurpose").ToList();
        var selectedItem = (InventoryItem)lvItem.Tag;
        if (selectedItem == null)
            return;

        var useSelectedItem = itemsToUse.Contains(selectedItem.Record.CodeName);

        if (useSelectedItem)
        {
            itemsToUse.Remove(selectedItem.Record.CodeName);
        }
        else
        {
            itemsToUse.Add(selectedItem.Record.CodeName);
        }

        useItemAtTrainingPlaceMenuItem.Checked = !useItemAtTrainingPlaceMenuItem.Checked;
        PlayerConfig.SetArray("RSBot.Inventory.AutoUseAccordingToPurpose", itemsToUse);
    }

    /// <summary>
    ///     Occurs before Main form is displayed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Main_Load(object sender, EventArgs e)
    {
        checkAutoSort.Checked = PlayerConfig.Get("RSBot.Inventory.AutoSort", false);
    }
}