using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class WeaponsMartialMelee {

        public WeaponsMartialMelee() { }

        public WeaponsType[] PopulateMartialMeleeWeapons() {
            var MartialMeleeWeapons = new WeaponsType[] {
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_BATTLEAXE,     "Battle Axe",  1000, "1D8",  Enums.DamageTypes.SLASHING,    "slashing",     4, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.VERSATILE1D8}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_FLAIL,         "Flail",       1000, "1D8",  Enums.DamageTypes.BLUDGEONING, "bludgeoning",  2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.NONE}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_GLAIVE,        "Glaive",      2000, "1D10", Enums.DamageTypes.SLASHING,    "slashing",     6, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.REACH, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_GREATAXE,      "Greataxe",    3000, "1D12", Enums.DamageTypes.SLASHING,    "slashing",     7, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_GREATSWORD,    "Greatsword",  5000, "2D6",  Enums.DamageTypes.SLASHING,    "slashing",     6, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_HALBERD,       "Halberd",     2000, "1D10", Enums.DamageTypes.SLASHING,    "slashing",     6, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.REACH, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_LANCE,         "Lance",       1000, "1D12", Enums.DamageTypes.PIERCING,    "piercing",     6, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.REACH, Enums.DamagePropertiesTypes.SPECIAL}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_LONGSWORD,     "Longsword",   1500, "1D8",  Enums.DamageTypes.SLASHING,    "slashing",     3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.VERSATILE1D10}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_MAUL,          "Maul",        1000, "2D6",  Enums.DamageTypes.BLUDGEONING, "bludgeoning", 10, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_MORNINGSTAR,   "Morningstar", 1500, "1D8",  Enums.DamageTypes.PIERCING,    "piercing",     4, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.NONE}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_PIKE,          "Pike",         500, "1D10", Enums.DamageTypes.PIERCING,    "piercing",    18, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.REACH, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_RAPIER,        "Rapier",      2500, "1D8",  Enums.DamageTypes.PIERCING,    "piercing",     2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.FINESSE}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_SCIMITAR,      "Scimitar",    2500, "1D6",  Enums.DamageTypes.SLASHING,    "slashing",     3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.FINESSE, Enums.DamagePropertiesTypes.LIGHT}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_SHORTSWORD,    "Shortsword",  1000, "1D6",  Enums.DamageTypes.PIERCING,    "piercing",     2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.FINESSE, Enums.DamagePropertiesTypes.LIGHT}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_TRIDENT,       "Trident",      500, "1D6",  Enums.DamageTypes.PIERCING,    "piercing",     4, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.THROWN2060, Enums.DamagePropertiesTypes.VERSATILE1D8}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_WARPICK,       "Warpick",      500, "1D8",  Enums.DamageTypes.PIERCING,    "piercing",     2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.NONE}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_WARHAMMER,     "Warhammer",   1500, "1D8",  Enums.DamageTypes.BLUDGEONING, "bludgeoning",  2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.VERSATILE1D10}),
                new WeaponsType((int)Enums.MartialMeleeWeaponsTypes.MARTIALMELEEWEAPON_ID_WHIP,          "Whip",         200, "1D4",  Enums.DamageTypes.SLASHING,    "slashing",     3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.FINESSE, Enums.DamagePropertiesTypes.REACH}),
            };
            return MartialMeleeWeapons;
        }

    }
}
