using RSBot.Core.Client.ReferenceObjects;
using RSBot.Core.Objects;
using RSBot.Core.Objects.Skill;
using SDUI;
using SkiaSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RSBot.Core.Extensions;

public static class ListViewExtensions
{
    /// <summary>
    ///     The cached image list for skills
    /// </summary>
    public static Dictionary<string, SKBitmap> StaticImageList;

    /// <summary>
    ///     The cached image list for items
    /// </summary>
    public static Dictionary<string, SKBitmap> StaticItemsImageList;

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    static ListViewExtensions()
    {
        StaticImageList = new();

        StaticItemsImageList = new();
    }

    /// <summary>
    ///     The sync object
    /// </summary>
    private static object _lock { get; } = new();

    /// <summary>
    ///     Load the skill image into the ImageList of the <seealso cref="ListViewItem" />
    /// </summary>
    public static Task LoadSkillImage(this ListViewItem listViewItem)
    {
        lock (_lock)
        {
            try
            {
                if (listViewItem.Tag is SkillInfo skill)
                {
                    var imageKey = "skill:" + skill.Id;
                    if (!StaticImageList.ContainsKey(imageKey))
                        StaticImageList.Add(imageKey, skill.Record.GetIcon());

                    //Renders the image
                    listViewItem.Image = StaticImageList[imageKey];
                }

                if (listViewItem.Tag is ItemPerk perk)
                {
                    var imageKey = "perk:" + perk.ItemId;
                    if (!StaticImageList.ContainsKey(imageKey))
                        StaticImageList.Add(imageKey, perk.Item?.GetIcon() ?? new SKBitmap(0, 0));

                    listViewItem.Image = StaticImageList[imageKey];
                }
            }
            catch
            {
                Log.Debug("Error while loading skill image");
            }
        }

        return Task.CompletedTask;
    }

    /// <summary>
    ///     Load the item image into the ListViewItem
    /// </summary>
    public static Task LoadItemImage(this ListViewItem listViewItem, RefObjItem item)
    {
        lock (_lock)
        {
            //No need to reload the image from the PK2
            if (!StaticItemsImageList.ContainsKey(item.CodeName))
                StaticItemsImageList.Add(item.CodeName, item.GetIcon());

            //Renders the image
            listViewItem.Image = StaticItemsImageList[item.CodeName];
        }

        return Task.CompletedTask;
    }

    /// <summary>
    ///     Load the skill image into the ImageList of the <seealso cref="ListViewItem" /> with async
    /// </summary>
    public static async void LoadSkillImageAsync(this ListViewItem item)
    {
        await item.LoadSkillImage();
    }

    /// <summary>
    ///     Load the skill image into the ImageList of the <seealso cref="ListViewItem" /> with async
    /// </summary>
    public static async void LoadItemImageAsync(this ListViewItem listViewItem, RefObjItem item)
    {
        await listViewItem.LoadItemImage(item);
    }

    /// <summary>
    ///     Load the skill image into the ImageList of the <seealso cref="ListViewItem" /> with async
    /// </summary>
    public static async void LoadItemImageAsync(this ListViewItem listViewItem, RefShopGood good)
    {
        try
        {
            var refPackageItem = Game.ReferenceManager.GetRefPackageItem(good.RefPackageItemCodeName);
            var refItem = Game.ReferenceManager.GetRefItem(refPackageItem.RefItemCodeName);

            await listViewItem.LoadItemImage(refItem);
        }
        catch
        {
        }
    }

    /// <summary>
    ///     Loads the skill images into the ImageList of the <seealso cref="ListView" /> control.
    /// </summary>
    public static async void LoadSkillImagesAsync(this ListView listView)
    {
        foreach (ListViewItem item in listView.Items)
            await item.LoadSkillImage();
    }
}