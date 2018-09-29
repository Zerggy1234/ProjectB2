﻿namespace wServer.networking
{
    public enum PacketID : byte
    {
        Packet = 11,
        Reconnect = 39,
        Failure = 0,
        InvitedToGuild = 77,
        CreateGuildResult = 58,
        Damage = 47,
        GroundDamage = 64,
        File = 55,
        Pic = 28,
        Text = 25,
        Update = 26,
        AOE = 68,
        AllyShoot = 74,
        New_Tick = 62,
        TradeRequested = 61,
        TradeDone = 12,
        Notification = 63,
        Shoot = 13,
        MultiShoot = 19,
        NameResult = 20,
        AccountList = 46,
        GlobalNotification = 9,
        ClientStat = 75,
        Create_Success = 31,
        QuestObjId = 34,
        InvResult = 4,
        PlaySound = 44,
        BuyResult = 27,
        TradeStart = 67,
        TradeAccepted = 18,
        Show_Effect = 56,
        MapInfo = 60,
        Ping = 6,
        Goto = 52,
        TradeChanged = 23,
        Death = 41,
        Hello = 17,
        GuildRemove = 78,
        CreateGuild = 15,
        GuildInvite = 8,
        JoinGuild = 5,
        ChangeGuildRank = 40,
        Buy = 50,
        Create = 36,
        Teleport = 49,
        Pong = 16,
        Move = 7,
        PlayerShoot = 38,
        CheckCredits = 48,
        SquareHit = 51,
        ShootAck = 22,
        Escape = 42,
        PlayerText = 69,
        Load = 45,
        InvSwap = 65,
        GotoAck = 14,
        SetCondition = 10,
        EditAccountList = 53,
        RequestTrade = 21,
        OtherHit = 66,
        ChooseName = 33,
        PlayerHit = 24,
        AOEAck = 59,
        ChangeTrade = 37,
        UsePortal = 3,
        AcceptTrade = 57,
        UseItem = 30,
        CancelTrade = 1,
        EnemyHit = 76,
        InvDrop = 35,

        Visibullet = 80,
        TextBox = 81,
        TextBoxButton = 82,
        SwitchMusic = 83,
        Craft = 84,
        InvitedToParty = 85,
        JoinParty = 86,
        PartyInvite = 87,
        ItemSelectStart = 88,
        ItemSelectResult = 89,
        ItemResult = 90,
        GetTextInput = 91,
        TextInputResult = 92,

        GiveItem = 93,
        PlayerCheat = 94,
        MarketTrade = 95,
        MarketTradeResult = 96,
        MarketCreate = 97,

        //Broadcast = 100
    }
}
