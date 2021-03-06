﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class Enums {
        public static readonly int EQUIPMENT_ID_NONE = 0;
        public static readonly int SHIELD_ID = 1000;
        public static readonly int SHIELD_ID_SHIELD = 1001;

        public static readonly int LIGHTARMOR_ID = 2000;
        public static readonly int LIGHTARMOR_ID_PADDED = 2001;
        public static readonly int LIGHTARMOR_ID_LEATHER = 2002;
        public static readonly int LIGHTARMOR_ID_STUDDEDLEATHER = 2003;

        public static readonly int MEDIUMARMOR_ID = 3000;
        public static readonly int MEDIUMARMOR_ID_HIDE = 3001;
        public static readonly int MEDIUMARMOR_ID_CHAINSHIRT = 3002;
        public static readonly int MEDIUMARMOR_ID_SCALEMAIL = 3003;
        public static readonly int MEDIUMARMOR_ID_BREASTPLATE = 3004;
        public static readonly int MEDIUMARMOR_ID_HALFPLATE = 3005;

        public static readonly int HEAVYARMOR_ID = 4000;
        public static readonly int HEAVYARMOR_ID_RINGMAIL = 4001;
        public static readonly int HEAVYARMOR_ID_CHAINMAIL = 4002;
        public static readonly int HEAVYARMOR_ID_SPLINT = 4003;
        public static readonly int HEAVYARMOR_ID_PLATE = 4004;

        public static readonly int SIMPLEMELEEWEAPON_ID_CLUB = 10000;
        public static readonly int SIMPLEMELEEWEAPON_ID_DAGGER = 10002;
        public static readonly int SIMPLEMELEEWEAPON_ID_GREATCLUB = 10003;
        public static readonly int SIMPLEMELEEWEAPON_ID_HANDAXE = 10004;
        public static readonly int SIMPLEMELEEWEAPON_ID_JAVELIN = 10005;
        public static readonly int SIMPLEMELEEWEAPON_ID_LIGHTHAMMER = 10006;
        public static readonly int SIMPLEMELEEWEAPON_ID_MACE = 10007;
        public static readonly int SIMPLEMELEEWEAPON_ID_QUARTERSTAFF = 10008;
        public static readonly int SIMPLEMELEEWEAPON_ID_SICKLE = 10009;
        public static readonly int SIMPLEMELEEWEAPON_ID_SPEAR = 10010;
        public static readonly int SIMPLEMELEEWEAPON_ID_UNARMEDSTRIKE = 10011;

        public static readonly int SIMPLERANGEDWEAPON_ID_LIGHTCROSSBOW = 11001;
        public static readonly int SIMPLERANGEDWEAPON_ID_DART = 11002;
        public static readonly int SIMPLERANGEDWEAPON_ID_SHORTBOW = 11003;
        public static readonly int SIMPLERANGEDWEAPON_ID_SLING = 11004;

        public static readonly int MARTIALMELEEWEAPON_ID_BATTLEAXE = 12001;
        public static readonly int MARTIALMELEEWEAPON_ID_FLAIL = 12002;
        public static readonly int MARTIALMELEEWEAPON_ID_GLAIVE = 12003;
        public static readonly int MARTIALMELEEWEAPON_ID_GREATAXE = 12004;
        public static readonly int MARTIALMELEEWEAPON_ID_GREATSWORD = 12005;
        public static readonly int MARTIALMELEEWEAPON_ID_HALBERD = 12006;
        public static readonly int MARTIALMELEEWEAPON_ID_LANCE = 12007;
        public static readonly int MARTIALMELEEWEAPON_ID_LONGSWORD = 12008;
        public static readonly int MARTIALMELEEWEAPON_ID_MAUL = 12009;
        public static readonly int MARTIALMELEEWEAPON_ID_MORNINGSTAR = 12010;
        public static readonly int MARTIALMELEEWEAPON_ID_PIKE = 12011;
        public static readonly int MARTIALMELEEWEAPON_ID_RAPIER = 12012;
        public static readonly int MARTIALMELEEWEAPON_ID_SCIMITAR = 12013;
        public static readonly int MARTIALMELEEWEAPON_ID_SHORTSWORD = 12014;
        public static readonly int MARTIALMELEEWEAPON_ID_TRIDENT = 12015;
        public static readonly int MARTIALMELEEWEAPON_ID_WARPICK = 12016;
        public static readonly int MARTIALMELEEWEAPON_ID_WARHAMMER = 12017;
        public static readonly int MARTIALMELEEWEAPON_ID_WHIP = 12018;

        public static readonly int MARTIALRANGEDWEAPON_ID_BLOWGUN = 13001;
        public static readonly int MARTIALRANGEDWEAPON_ID_HANDCROSSBOW = 13002;
        public static readonly int MARTIALRANGEDWEAPON_ID_HEAVYCROSSBOW = 13003;
        public static readonly int MARTIALRANGEDWEAPON_ID_LONGBOW = 13004;
        public static readonly int MARTIALRANGEDWEAPON_ID_NET = 13005;



        //public enum ShieldsTypes {
        //    SHIELD_ID_NONE = 0,
        //    SHIELD_ID_SHIELD = 1,
        //}
        //public enum LightArmorTypes {
        //    LIGHTARMOR_ID_NONE = 0,
        //    LIGHTARMOR_ID_PADDED = 1,
        //    LIGHTARMOR_ID_LEATHER = 2,
        //    LIGHTARMOR_ID_STUDDEDLEATHER = 3,
        //}
        //public enum MediumArmorTypes {
        //    MEDIUMARMOR_ID_NONE = 0,
        //    MEDIUMARMOR_ID_HIDE = 1,
        //    MEDIUMARMOR_ID_CHAINSHIRT = 2,
        //    MEDIUMARMOR_ID_SCALEMAIL = 3,
        //    MEDIUMARMOR_ID_BREASTPLATE = 4,
        //    MEDIUMARMOR_ID_HALFPLATE = 5,
        //}
        //public enum HeavyArmorTypes {
        //    HEAVYARMOR_ID_NONE = 0,
        //    HEAVYARMOR_ID_RINGMAIL = 1,
        //    HEAVYARMOR_ID_CHAINMAIL = 2,
        //    HEAVYARMOR_ID_SPLINT = 3,
        //    HEAVYARMOR_ID_PLATE = 4,
        //}
        public enum ArmorTypes {
            ARMOR_ID_NONE = 0,
            ARMOR_ID_LIGHTARMOR = 1,
            ARMOR_ID_MEDIUMARMOR = 2,
            ARMOR_ID_HEAVYARMOR = 3,
            ARMOR_ID_SHIELD = 4,
        }
        public enum DamagePropertiesTypes {
            NONE,
            AMMUNITION25100,    // (range 25/100)
            AMMUNITION30120,    // (range 30/120)
            AMMUNITION80320,    // (range 80/320)
            AMMUNITION100400,   // (range 100/400)
            AMMUNITION150600,   // (range 150/600)
            FINESSE,
            HEAVY,
            THROWN515,          // (range 5/15)
            THROWN2060,         // (range 20/60)
            THROWN30120,        // (range 30/120)
            LIGHT,
            LOADING,
            TWOHANDED,
            REACH,
            SPECIAL,
            VERSATILE1D8,       // 1D8
            VERSATILE1D10       // 1D10
        }
        public enum DamageTypes {
            NONE,
            ACID,
            BLUDGEONING,
            COLD,
            FIRE,
            FORCE,
            LIGHTING,
            NECROTIC,
            PIERCING,
            POISON,
            PSYCHIC,
            RADIANT,
            SLASHING,
            THUNDER,
        }
        public enum WeaponsTypes {
            WEAPONS_ID_SIMPLEMELEEWEAPONS = 1,
            WEAPONS_ID_SIMPLERANGEDWEAPONS = 2,
            WEAPONS_ID_MARTIALMELEEWEAPONS = 3,
            WEAPONS_ID_MARTIALRANGEDWEAPONS = 4,
        }
        public enum ProficiencyWeaponsTypes {
            WEAPONS_ID_SIMPLEMELEEWEAPONS = 1,
            WEAPONS_ID_SIMPLERANGEDWEAPONS = 2,
            WEAPONS_ID_MARTIALMELEEWEAPONS = 3,
            WEAPONS_ID_MARTIALRANGEDWEAPONS = 4,
            WEAPONS_ID_HANDCROSSBOW = 5,
            WEAPONS_ID_LONGSWORD = 6,
            WEAPONS_ID_RAPIER = 7,
            WEAPONS_ID_SHORTSWORD = 8,
            WEAPONS_ID_DAGGER = 9,
            WEAPONS_ID_DART = 10,
            WEAPONS_ID_SLING = 11,
            WEAPONS_ID_QUARTERSTAFF = 12,
            WEAPONS_ID_LIGHTCROSSBOW = 13,
        }
        //public enum SimpleMeleeWeaponsTypes {
        //    SIMPLEMELEEWEAPON_ID_CLUB = 1,
        //    SIMPLEMELEEWEAPON_ID_DAGGER = 2,
        //    SIMPLEMELEEWEAPON_ID_GREATCLUB = 3,
        //    SIMPLEMELEEWEAPON_ID_HANDAXE = 4,
        //    SIMPLEMELEEWEAPON_ID_JAVELIN = 5,
        //    SIMPLEMELEEWEAPON_ID_LIGHTHAMMER = 6,
        //    SIMPLEMELEEWEAPON_ID_MACE = 7,
        //    SIMPLEMELEEWEAPON_ID_QUARTERSTAFF = 8,
        //    SIMPLEMELEEWEAPON_ID_SICKLE = 9,
        //    SIMPLEMELEEWEAPON_ID_SPEAR = 10,
        //    SIMPLEMELEEWEAPON_ID_UNARMEDSTRIKE = 11,
        //}
        //public enum SimpleRangedWeaponsTypes {
        //    SIMPLERANGEDWEAPON_ID_LIGHTCROSSBOW = 1,
        //    SIMPLERANGEDWEAPON_ID_DART = 2,
        //    SIMPLERANGEDWEAPON_ID_SHORTBOW = 3,
        //    SIMPLERANGEDWEAPON_ID_SLING = 4,
        //}
        //public enum MartialMeleeWeaponsTypes {
        //    MARTIALMELEEWEAPON_ID_BATTLEAXE = 1,
        //    MARTIALMELEEWEAPON_ID_FLAIL = 2,
        //    MARTIALMELEEWEAPON_ID_GLAIVE = 3,
        //    MARTIALMELEEWEAPON_ID_GREATAXE = 4,
        //    MARTIALMELEEWEAPON_ID_GREATSWORD = 5,
        //    MARTIALMELEEWEAPON_ID_HALBERD = 6,
        //    MARTIALMELEEWEAPON_ID_LANCE = 7,
        //    MARTIALMELEEWEAPON_ID_LONGSWORD = 8,
        //    MARTIALMELEEWEAPON_ID_MAUL = 9,
        //    MARTIALMELEEWEAPON_ID_MORNINGSTAR = 10,
        //    MARTIALMELEEWEAPON_ID_PIKE = 11,
        //    MARTIALMELEEWEAPON_ID_RAPIER = 12,
        //    MARTIALMELEEWEAPON_ID_SCIMITAR = 13,
        //    MARTIALMELEEWEAPON_ID_SHORTSWORD = 14,
        //    MARTIALMELEEWEAPON_ID_TRIDENT = 15,
        //    MARTIALMELEEWEAPON_ID_WARPICK = 16,
        //    MARTIALMELEEWEAPON_ID_WARHAMMER = 17,
        //    MARTIALMELEEWEAPON_ID_WHIP = 18,
        //}
        //public enum MartialRangedWeaponsTypes {
        //    MARTIALRANGEDWEAPON_ID_BLOWGUN = 1,
        //    MARTIALRANGEDWEAPON_ID_HANDCROSSBOW = 2,
        //    MARTIALRANGEDWEAPON_ID_HEAVYCROSSBOW = 3,
        //    MARTIALRANGEDWEAPON_ID_LONGBOW = 4,
        //    MARTIALRANGEDWEAPON_ID_NET = 5,
        //}
    }
}
