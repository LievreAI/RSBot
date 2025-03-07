using System;
using System.Collections.Generic;
using System.Linq;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Core.Event;
using RSBot.Core.Objects.Party;
using RSBot.Core.Objects.Spawn;
using RSBot.Party.Bundle.PartyMatching.Objects;

namespace RSBot.Party.Bundle.AutoParty;

/// <summary>
/// Manages automatic party functionality including invitations and joining
/// </summary>
internal class AutoPartyBundle
{
    private int _lastPartyListingCacheTick;
    private int _lastTick;
    private List<PartyEntry> _partyEntriesCache;

    /// <summary>
    /// Gets or sets the configuration for auto party
    /// </summary>
    public AutoPartyConfig Config { get; set; }

    /// <summary>
    /// Initializes a new instance of the AutoPartyBundle class
    /// </summary>
    public AutoPartyBundle()
    {
        EventManager.SubscribeEvent("OnTick", OnTick);
    }

    /// <summary>
    /// Refreshes the configuration from settings
    /// </summary>
    public void Refresh()
    {
        Config = new AutoPartyConfig
        {
            PlayerList = PlayerConfig.GetArray<string>("RSBot.Party.AutoPartyList"),
            InviteAll = PlayerConfig.Get<bool>("RSBot.Party.InviteAll"),
            AcceptAll = PlayerConfig.Get<bool>("RSBot.Party.AcceptAll"),
            AcceptFromList = PlayerConfig.Get<bool>("RSBot.Party.AcceptList"),
            InviteFromList = PlayerConfig.Get<bool>("RSBot.Party.InviteList"),
            OnlyAtTrainingPlace = PlayerConfig.Get<bool>("RSBot.Party.AtTrainingPlace"),
            ExperienceAutoShare = PlayerConfig.Get<bool>("RSBot.Party.EXPAutoShare"),
            ItemAutoShare = PlayerConfig.Get<bool>("RSBot.Party.ItemAutoShare"),
            AllowInvitations = PlayerConfig.Get<bool>("RSBot.Party.AllowInvitations"),
            AcceptIfBotIsStopped = PlayerConfig.Get<bool>("RSBot.Party.AcceptIfBotStopped"),
            LeaveIfMasterNot = PlayerConfig.Get<bool>("RSBot.Party.LeaveIfMasterNot"),
            LeaveIfMasterNotName = PlayerConfig.Get<string>("RSBot.Party.LeaveIfMasterNotName"),
            CenterPosition = Kernel.Bot.Botbase.Area.Position,
            AutoJoinByName = PlayerConfig.Get("RSBot.Party.AutoJoin.ByName", false),
            AutoJoinByTitle = PlayerConfig.Get("RSBot.Party.AutoJoin.ByTitle", false),
            AutoJoinByNameContent = PlayerConfig.Get("RSBot.Party.AutoJoin.Name", string.Empty),
            AutoJoinByTitleContent = PlayerConfig.Get("RSBot.Party.AutoJoin.Title", string.Empty),
            AlwaysFollowThePartyMaster = PlayerConfig.Get("RSBot.Party.AlwaysFollowPartyMaster", false)
        };

        if (!Game.Party.IsInParty)
            Game.Party.Settings = new PartySettings(Config.ExperienceAutoShare, Config.ItemAutoShare, Config.AllowInvitations);
    }

    /// <summary>
    /// Handles the tick event for auto party functionality
    /// </summary>
    public void OnTick()
    {
        var elapsed = Kernel.TickCount - _lastTick;
        if (elapsed > 5000)
        {
            CheckForAutoPartyJoin();
            CheckForPlayers();

            _lastTick = Kernel.TickCount;
        }
    }

    /// <summary>
    /// Checks for auto party join conditions
    /// </summary>
    private void CheckForAutoPartyJoin()
    {
        if (Game.Party.IsInParty)
            return;

        if (!Config.AutoJoinByName && !Config.AutoJoinByTitle)
            return;

        var elapsed = Kernel.TickCount - _lastPartyListingCacheTick;

        // Update cache every minute
        if (elapsed >= 60000)
        {
            _partyEntriesCache = new List<PartyEntry>(64);

            byte page = 0;
            while (true)
            {
                var currentPage = Container.PartyMatching.RequestPartyList(page);

                _partyEntriesCache.AddRange(currentPage.Parties);

                if (currentPage.Page == currentPage.PageCount - 1)
                    break;

                page++;
            }

            _lastPartyListingCacheTick = Kernel.TickCount;
        }

        if (Config.AutoJoinByName)
        {
            var partyEntry = _partyEntriesCache.Find(p => p.Leader == Config.AutoJoinByNameContent);
            if (partyEntry != null && Container.PartyMatching.Join(partyEntry.Id))
                return;
        }

        if (Config.AutoJoinByTitle)
        {
            var partyEntry = _partyEntriesCache.Find(p =>
                p.Title.Contains(Config.AutoJoinByTitleContent, StringComparison.CurrentCultureIgnoreCase));
            if (partyEntry != null)
                Container.PartyMatching.Join(partyEntry.Id);
        }
    }

    /// <summary>
    /// Checks for players that can be invited to the party
    /// </summary>
    public void CheckForPlayers()
    {
        if (Game.Party.IsInParty &&
            !Game.Party.IsLeader &&
            Config.LeaveIfMasterNot &&
            !string.IsNullOrWhiteSpace(Config.LeaveIfMasterNotName))
            if (Config.LeaveIfMasterNotName != Game.Party.Leader.Name)
                Game.Party.Leave();

        if (!Game.Party.CanInvite)
            return;

        var limit = 8;
        if (!Game.Party.Settings.ExperienceAutoShare && !Game.Party.Settings.ItemAutoShare)
            limit = 4;

        if (Game.Party.Members?.Count > limit)
            return;

        if (Config.OnlyAtTrainingPlace &&
            Game.Player.Movement.Source.DistanceTo(Config.CenterPosition) > 50)
            return;

        if (!SpawnManager.TryGetEntities<SpawnedPlayer>(out var players))
            return;

        foreach (var player in players)
        {
            if (Game.Party.IsInParty && Game.Party.GetMemberByName(player.Name) != null)
                continue;

            if (Config.InviteAll)
            {
                Game.Party.Invite(player.UniqueId);
                continue;
            }

            if (Config.PlayerList.Contains(player.Name) && Config.InviteFromList)
                Game.Party.Invite(player.UniqueId);
        }
    }
} 