﻿using POGOProtos.Enums;

namespace PokemonGo_UWP.Utils {
    public enum AchievementType {
        [BadgeTypeAttribute(BadgeType.BadgeTravelKm)]
        [BronzeAttribute(10)]
        [SilverAttribute(100)]
        [GoldAttribute(1000)]
        Jogger,
        [BadgeTypeAttribute(BadgeType.BadgePokedexEntries)]
        [BronzeAttribute(5)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        Kanto,
        [BadgeTypeAttribute(BadgeType.BadgeCaptureTotal)]
        [BronzeAttribute(30)]
        [SilverAttribute(500)]
        [GoldAttribute(2000)]
        Collector,
        [BadgeTypeAttribute(BadgeType.BadgeEvolvedTotal)]
        [BronzeAttribute(3)]
        [SilverAttribute(20)]
        [GoldAttribute(200)]
        Scientist,
        [BadgeTypeAttribute(BadgeType.BadgeHatchedTotal)]
        [BronzeAttribute(10)]
        [SilverAttribute(100)]
        [GoldAttribute(1000)]
        Breeder,
        [BadgeTypeAttribute(BadgeType.BadgePokestopsVisited)]
        [BronzeAttribute(100)]
        [SilverAttribute(1000)]
        [GoldAttribute(2000)]
        Backpacker,
        [BadgeTypeAttribute(BadgeType.BadgeBigMagikarp)]
        [BronzeAttribute(3)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        Fisherman,
        [BadgeTypeAttribute(BadgeType.BadgeBattleAttackWon)]
        [BronzeAttribute(10)]
        [SilverAttribute(100)]
        [GoldAttribute(1000)]
        BattleGirl,
        [BadgeTypeAttribute(BadgeType.BadgeBattleTrainingWon)]
        [BronzeAttribute(10)]
        [SilverAttribute(100)]
        [GoldAttribute(1000)]
        AceTrainer,
        [BadgeTypeAttribute(BadgeType.Normal)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        SchoolKid,
        [BadgeTypeAttribute(BadgeType.Flying)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        BirdKeeper,
        [BadgeTypeAttribute(BadgeType.Poison)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        PunkGirl,
        [BadgeTypeAttribute(BadgeType.Bug)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        BugCatcher,
        [BadgeTypeAttribute(BadgeType.Ghost)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        HexManiac,
        [BadgeTypeAttribute(BadgeType.Water)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        Swimmer,
        [BadgeTypeAttribute(BadgeType.Grass)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        Gardener,
        [BadgeTypeAttribute(BadgeType.Electric)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        Rocker,
        [BadgeTypeAttribute(BadgeType.Psychic)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        Psychic,
        [BadgeTypeAttribute(BadgeType.Ice)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        Skier,
        [BadgeTypeAttribute(BadgeType.Ground)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        RuinManiac,
        [BadgeTypeAttribute(BadgeType.Fire)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        Kindler,
        [BadgeTypeAttribute(BadgeType.Fairy)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        FairyTaleGirl,
        [BadgeTypeAttribute(BadgeType.Dragon)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        DragonTamer,
        [BadgeTypeAttribute(BadgeType.BadgeSmallRattata)]
        [BronzeAttribute(3)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        Youngster,
        [BadgeTypeAttribute(BadgeType.Steel)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        DepotAgent,
        [BadgeTypeAttribute(BadgeType.Rock)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        Hiker,
        [BadgeTypeAttribute(BadgeType.Fighting)]
        [BronzeAttribute(10)]
        [SilverAttribute(50)]
        [GoldAttribute(200)]
        BlackBelt
    }
}
