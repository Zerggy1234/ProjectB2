﻿namespace wServer.realm
{
    public enum CurrencyType
    {
        Gold = 0,
        Fame = 1,
        GuildFame = 2,
        Keys = 3
    }

    public enum StatsType : byte
    {
        MaximumHP = 0,
        HP = 1,
        Size = 2,
        MaximumMP = 3,
        MP = 4,
        ExperienceGoal = 5,
        Experience = 6,
        Level = 7,
        Inventory0 = 8,
        Inventory1 = 9,
        Inventory2 = 10,
        Inventory3 = 11,
        Inventory4 = 12,
        Inventory5 = 13,
        Inventory6 = 14,
        Inventory7 = 15,
        Inventory8 = 16,
        Inventory9 = 17,
        Inventory10 = 18,
        Inventory11 = 19,
        Attack = 20,
        Defense = 21,
        Speed = 22,
        Vitality = 26,
        Wisdom = 27,
        Dexterity = 28,
        Effects = 29,
        Stars = 30,
        Name = 31,
        Texture1 = 32,
        Texture2 = 33,
        MerchantMerchandiseType = 34,
        Credits = 35,
        SellablePrice = 36,
        PortalUsable = 37,
        AccountId = 38,
        CurrentFame = 39,
        SellablePriceCurrency = 40,
        ObjectConnection = 41,
        /*
         * Mask :F0F0F0F0
         * each byte -> type
         * 0:Dot
         * 1:ShortLine
         * 2:L
         * 3:Line
         * 4:T
         * 5:Cross
         * 0x21222112
        */
        MerchantRemainingCount = 42,
        MerchantRemainingMinute = 43,
        MerchantDiscount = 44,
        SellableRankRequirement = 45,
        HPBoost = 46,
        MPBoost = 47,
        AttackBonus = 48,
        DefenseBonus = 49,
        SpeedBonus = 50,
        VitalityBonus = 51,
        WisdomBonus = 52,
        DexterityBonus = 53,
        OwnerAccountId = 54,
        NameChangerStar = 55,
        NameChosen = 56,
        Fame = 57,
        FameGoal = 58,
        Glowing = 59,
        SinkOffset = 60,
        AltTextureIndex = 61,
        Guild = 62,
        GuildRank = 63,
        OxygenBar = 64,
        XpBoost = 65,
        Skin = 66,
        PvP = 67,
        Team = 68,
        Keys = 69,
        CanNexus = 70,
        Party = 71,
        PartyLeader = 72,
        InvData0 = 73,
        InvData1 = 74,
        InvData2 = 75,
        InvData3 = 76,
        InvData4 = 77,
        InvData5 = 78,
        InvData6 = 79,
        InvData7 = 80,
        InvData8 = 81,
        InvData9 = 82,
        InvData10 = 83,
        InvData11 = 84,
        Effect = 85,
        Luck = 120,
        Crit = 121,
        LuckBonus = 122,
        CritBonus = 123
        /*  Backpack1_0 = 86,
          Backpack1_1 = 87,
          Backpack1_2 = 88,
          Backpack1_3 = 89,
          Backpack1_4 = 90,
          Backpack1_5 = 91,
          Backpack1_6 = 92,
          Backpack1_7 = 93,
          Backpack2_0 = 94,
          Backpack2_1 = 95,
          Backpack2_2 = 96,
          Backpack2_3 = 97,
          Backpack2_4 = 98,
          Backpack2_5 = 99,
          Backpack2_6 = 100,
          Backpack2_7 = 101,
          HasBackpack1 = 102,
          HasBackpack2 = 103,
          InvData12 = 104,
          InvData13 = 105,
          InvData14 = 106,
          InvData15 = 107,
          InvData16 = 108,
          InvData17 = 109,
          InvData18 = 110,
          InvData19 = 111,
          InvData20 = 112,
          InvData21 = 113,
          InvData22 = 114,
          InvData23 = 115,
          InvData24 = 116,
          InvData25 = 117,
          InvData26 = 118,
          InvData27 = 119, */
    }
}