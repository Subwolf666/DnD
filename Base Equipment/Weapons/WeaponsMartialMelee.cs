using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public enum MartialMeleeWeaponsTypes {
        MARTIALMELEEWEAPON_ID_BATTLEAXE = 1,
        MARTIALMELEEWEAPON_ID_FLAIL = 2,
        MARTIALMELEEWEAPON_ID_GLAIVE = 3,
        MARTIALMELEEWEAPON_ID_GREATAXE = 4,
        MARTIALMELEEWEAPON_ID_GREATSWORD = 5,
        MARTIALMELEEWEAPON_ID_HALBERD = 6,
        MARTIALMELEEWEAPON_ID_LANCE = 7,
        MARTIALMELEEWEAPON_ID_LONGSWORD = 8,
        MARTIALMELEEWEAPON_ID_MAUL = 9,
        MARTIALMELEEWEAPON_ID_MORNINGSTAR = 10,
        MARTIALMELEEWEAPON_ID_PIKE = 11,
        MARTIALMELEEWEAPON_ID_RAPIER = 12,
        MARTIALMELEEWEAPON_ID_SCIMITAR = 13,
        MARTIALMELEEWEAPON_ID_SHORTSWORD = 14,
        MARTIALMELEEWEAPON_ID_TRIDENT = 15,
        MARTIALMELEEWEAPON_ID_WARPICK = 16,
        MARTIALMELEEWEAPON_ID_WARHAMMER = 17,
        MARTIALMELEEWEAPON_ID_WHIP = 18,
    }
    public class WeaponsMartialMelee {

        public WeaponsMartialMelee() { }

        // add 
        // Properties classes onderscheid
        public WeaponType[] PopulateMartialMeleeWeapons() {
            var MartialMeleeWeapons = new WeaponType[] {
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_BATTLEAXE,     "Battle Axe",  1000, "1D8",  DamageTypes.SLASHING,    "slashing",     4, new PropertiesTypes[] {PropertiesTypes.VERSATILE1D8}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_FLAIL,         "Flail",       1000, "1D8",  DamageTypes.BLUDGEONING, "bludgeoning",  2, new PropertiesTypes[] {PropertiesTypes.NONE}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_GLAIVE,        "Glaive",      2000, "1D10", DamageTypes.SLASHING,    "slashing",     6, new PropertiesTypes[] {PropertiesTypes.HEAVY, PropertiesTypes.REACH, PropertiesTypes.TWOHANDED}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_GREATAXE,      "Greataxe",    3000, "1D12", DamageTypes.SLASHING,    "slashing",     7, new PropertiesTypes[] {PropertiesTypes.HEAVY, PropertiesTypes.TWOHANDED}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_GREATSWORD,    "Greatsword",  5000, "2D6",  DamageTypes.SLASHING,    "slashing",     6, new PropertiesTypes[] {PropertiesTypes.HEAVY, PropertiesTypes.TWOHANDED}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_HALBERD,       "Halberd",     2000, "1D10", DamageTypes.SLASHING,    "slashing",     6, new PropertiesTypes[] {PropertiesTypes.HEAVY, PropertiesTypes.REACH, PropertiesTypes.TWOHANDED}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_LANCE,         "Lance",       1000, "1D12", DamageTypes.PIERCING,    "piercing",     6, new PropertiesTypes[] {PropertiesTypes.REACH, PropertiesTypes.SPECIAL}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_LONGSWORD,     "Longsword",   1500, "1D8",  DamageTypes.SLASHING,    "slashing",     3, new PropertiesTypes[] {PropertiesTypes.VERSATILE1D10}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_MAUL,          "Maul",        1000, "2D6",  DamageTypes.BLUDGEONING, "bludgeoning", 10, new PropertiesTypes[] {PropertiesTypes.HEAVY, PropertiesTypes.TWOHANDED}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_MORNINGSTAR,   "Morningstar", 1500, "1D8",  DamageTypes.PIERCING,    "piercing",     4, new PropertiesTypes[] {PropertiesTypes.NONE}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_PIKE,          "Pike",         500, "1D10", DamageTypes.PIERCING,    "piercing",    18, new PropertiesTypes[] {PropertiesTypes.HEAVY, PropertiesTypes.REACH, PropertiesTypes.TWOHANDED}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_RAPIER,        "Rapier",      2500, "1D8",  DamageTypes.PIERCING,    "piercing",     2, new PropertiesTypes[] {PropertiesTypes.FINESSE}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_SCIMITAR,      "Scimitar",    2500, "1D6",  DamageTypes.SLASHING,    "slashing",     3, new PropertiesTypes[] {PropertiesTypes.FINESSE, PropertiesTypes.LIGHT}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_SHORTSWORD,    "Shortsword",  1000, "1D6",  DamageTypes.PIERCING,    "piercing",     2, new PropertiesTypes[] {PropertiesTypes.FINESSE, PropertiesTypes.LIGHT}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_TRIDENT,       "Trident",      500, "1D6",  DamageTypes.PIERCING,    "piercing",     4, new PropertiesTypes[] {PropertiesTypes.THROWN2060, PropertiesTypes.VERSATILE1D8}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_WARPICK,       "Warpick",      500, "1D8",  DamageTypes.PIERCING,    "piercing",     2, new PropertiesTypes[] {PropertiesTypes.NONE}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_WARHAMMER,     "Warhammer",   1500, "1D8",  DamageTypes.BLUDGEONING, "bludgeoning",  2, new PropertiesTypes[] {PropertiesTypes.VERSATILE1D10}),
                new WeaponType((int)MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_WHIP,          "Whip",         200, "1D4",  DamageTypes.SLASHING,    "slashing",     3, new PropertiesTypes[] {PropertiesTypes.FINESSE, PropertiesTypes.REACH}),
            };
            return MartialMeleeWeapons;
        }

    }
}
