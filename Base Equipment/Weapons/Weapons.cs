using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class Weapons {

        public static BaseEquipment[] PopulateWeapons() {

            var to_return = new BaseEquipment[] {
                new WeaponsType(Enums.EquipmentTypes.SIMPLEMELEEWEAPON_ID_CLUB,           "Club",             10, "1D4", Enums.DamageTypes.BLUDGEONING, "bludgeoning",  2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.LIGHT}),
                new WeaponsType(Enums.EquipmentTypes.SIMPLEMELEEWEAPON_ID_DAGGER,         "Dagger",          200, "1D4", Enums.DamageTypes.PIERCING,    "piercing",     1, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.FINESSE,  Enums.DamagePropertiesTypes.LIGHT, Enums.DamagePropertiesTypes.THROWN2060}),
                new WeaponsType(Enums.EquipmentTypes.SIMPLEMELEEWEAPON_ID_GREATCLUB,      "Greatclub",        20, "1D8", Enums.DamageTypes.BLUDGEONING, "bludgeoning", 10, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType(Enums.EquipmentTypes.SIMPLEMELEEWEAPON_ID_HANDAXE,        "Handaxe",         500, "1D6", Enums.DamageTypes.SLASHING,    "slashing",     2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.LIGHT,    Enums.DamagePropertiesTypes.THROWN2060}),
                new WeaponsType(Enums.EquipmentTypes.SIMPLEMELEEWEAPON_ID_JAVELIN,        "Javelin",          50, "1D6", Enums.DamageTypes.PIERCING,    "piercing",     2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.THROWN30120}),
                new WeaponsType(Enums.EquipmentTypes.SIMPLEMELEEWEAPON_ID_LIGHTHAMMER,    "Light hammer",    200, "1D4", Enums.DamageTypes.BLUDGEONING, "bludgeoning",  2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.LIGHT,    Enums.DamagePropertiesTypes.THROWN2060}),
                new WeaponsType(Enums.EquipmentTypes.SIMPLEMELEEWEAPON_ID_MACE,           "Mace",            500, "1D6", Enums.DamageTypes.BLUDGEONING, "bludgeoning",  4, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.NONE}),
                new WeaponsType(Enums.EquipmentTypes.SIMPLEMELEEWEAPON_ID_QUARTERSTAFF,   "Quarterstaff",     20, "1D6", Enums.DamageTypes.BLUDGEONING, "bludgeoning",  4, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.VERSATILE1D8}),
                new WeaponsType(Enums.EquipmentTypes.SIMPLEMELEEWEAPON_ID_SICKLE,         "Sickle",          100, "1D4", Enums.DamageTypes.SLASHING,    "slashing",     2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.LIGHT}),
                new WeaponsType(Enums.EquipmentTypes.SIMPLEMELEEWEAPON_ID_SPEAR,          "Spear",           100, "1D6", Enums.DamageTypes.PIERCING,    "piercing",     3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.THROWN2060, Enums.DamagePropertiesTypes.VERSATILE1D8}),
                new WeaponsType(Enums.EquipmentTypes.SIMPLEMELEEWEAPON_ID_UNARMEDSTRIKE,  "Unarmed strike",    0,   "1", Enums.DamageTypes.BLUDGEONING, "bludgeoning",  0, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.NONE}),

                new WeaponsType(Enums.EquipmentTypes.MARTIALRANGEDWEAPON_ID_BLOWGUN,       "Blowgun",        1000, "1",    Enums.DamageTypes.PIERCING, "piercing",  1, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION25100, Enums.DamagePropertiesTypes.LOADING}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALRANGEDWEAPON_ID_HANDCROSSBOW,  "Hand Crossbow",  7500, "1D6",  Enums.DamageTypes.PIERCING, "piercing",  3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION30120, Enums.DamagePropertiesTypes.LIGHT, Enums.DamagePropertiesTypes.LOADING}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALRANGEDWEAPON_ID_HEAVYCROSSBOW, "Heavy Crossbow", 5000, "1D10", Enums.DamageTypes.PIERCING, "piercing", 18, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION100400, Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.LOADING, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALRANGEDWEAPON_ID_LONGBOW,       "Longbow",        5000, "1D8",  Enums.DamageTypes.PIERCING, "piercing",  2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION150600, Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALRANGEDWEAPON_ID_NET,           "Net",             100, "0",    Enums.DamageTypes.NONE,     "",          3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.SPECIAL, Enums.DamagePropertiesTypes.THROWN515}),

                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_BATTLEAXE,     "Battle Axe",  1000, "1D8",  Enums.DamageTypes.SLASHING,    "slashing",     4, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.VERSATILE1D8}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_FLAIL,         "Flail",       1000, "1D8",  Enums.DamageTypes.BLUDGEONING, "bludgeoning",  2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.NONE}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_GLAIVE,        "Glaive",      2000, "1D10", Enums.DamageTypes.SLASHING,    "slashing",     6, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.REACH, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_GREATAXE,      "Greataxe",    3000, "1D12", Enums.DamageTypes.SLASHING,    "slashing",     7, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_GREATSWORD,    "Greatsword",  5000, "2D6",  Enums.DamageTypes.SLASHING,    "slashing",     6, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_HALBERD,       "Halberd",     2000, "1D10", Enums.DamageTypes.SLASHING,    "slashing",     6, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.REACH, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_LANCE,         "Lance",       1000, "1D12", Enums.DamageTypes.PIERCING,    "piercing",     6, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.REACH, Enums.DamagePropertiesTypes.SPECIAL}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_LONGSWORD,     "Longsword",   1500, "1D8",  Enums.DamageTypes.SLASHING,    "slashing",     3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.VERSATILE1D10}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_MAUL,          "Maul",        1000, "2D6",  Enums.DamageTypes.BLUDGEONING, "bludgeoning", 10, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_MORNINGSTAR,   "Morningstar", 1500, "1D8",  Enums.DamageTypes.PIERCING,    "piercing",     4, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.NONE}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_PIKE,          "Pike",         500, "1D10", Enums.DamageTypes.PIERCING,    "piercing",    18, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.REACH, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_RAPIER,        "Rapier",      2500, "1D8",  Enums.DamageTypes.PIERCING,    "piercing",     2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.FINESSE}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_SCIMITAR,      "Scimitar",    2500, "1D6",  Enums.DamageTypes.SLASHING,    "slashing",     3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.FINESSE, Enums.DamagePropertiesTypes.LIGHT}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_SHORTSWORD,    "Shortsword",  1000, "1D6",  Enums.DamageTypes.PIERCING,    "piercing",     2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.FINESSE, Enums.DamagePropertiesTypes.LIGHT}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_TRIDENT,       "Trident",      500, "1D6",  Enums.DamageTypes.PIERCING,    "piercing",     4, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.THROWN2060, Enums.DamagePropertiesTypes.VERSATILE1D8}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_WARPICK,       "Warpick",      500, "1D8",  Enums.DamageTypes.PIERCING,    "piercing",     2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.NONE}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_WARHAMMER,     "Warhammer",   1500, "1D8",  Enums.DamageTypes.BLUDGEONING, "bludgeoning",  2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.VERSATILE1D10}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALMELEEWEAPON_ID_WHIP,          "Whip",         200, "1D4",  Enums.DamageTypes.SLASHING,    "slashing",     3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.FINESSE, Enums.DamagePropertiesTypes.REACH}),

                new WeaponsType(Enums.EquipmentTypes.MARTIALRANGEDWEAPON_ID_BLOWGUN,       "Blowgun",        1000, "1",    Enums.DamageTypes.PIERCING, "piercing",  1, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION25100, Enums.DamagePropertiesTypes.LOADING}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALRANGEDWEAPON_ID_HANDCROSSBOW,  "Hand Crossbow",  7500, "1D6",  Enums.DamageTypes.PIERCING, "piercing",  3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION30120, Enums.DamagePropertiesTypes.LIGHT, Enums.DamagePropertiesTypes.LOADING}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALRANGEDWEAPON_ID_HEAVYCROSSBOW, "Heavy Crossbow", 5000, "1D10", Enums.DamageTypes.PIERCING, "piercing", 18, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION100400, Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.LOADING, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALRANGEDWEAPON_ID_LONGBOW,       "Longbow",        5000, "1D8",  Enums.DamageTypes.PIERCING, "piercing",  2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION150600, Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType(Enums.EquipmentTypes.MARTIALRANGEDWEAPON_ID_NET,           "Net",             100, "0",    Enums.DamageTypes.NONE,     "",          3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.SPECIAL, Enums.DamagePropertiesTypes.THROWN515}),
            };
            //var AllWeapons = new WeaponCategory[] {
            //    new WeaponCategory(Enums.WeaponsTypes.WEAPONS_ID_SIMPLEMELEEWEAPONS, "Simple melee weapons", string.Empty, new WeaponsSimpleMelee().PopulateSimpleMeleeWeapons()),
            //    new WeaponCategory(Enums.WeaponsTypes.WEAPONS_ID_SIMPLERANGEDWEAPONS, "Simple ranged weapons", string.Empty, new WeaponsSimpleRanged().PopulateSimpleRangedWeapons()),
            //    new WeaponCategory(Enums.WeaponsTypes.WEAPONS_ID_MARTIALMELEEWEAPONS, "Martial melee weapons", string.Empty, new WeaponsMartialMelee().PopulateMartialMeleeWeapons()),
            //    new WeaponCategory(Enums.WeaponsTypes.WEAPONS_ID_MARTIALRANGEDWEAPONS, "Martial ranged weapons", string.Empty, new WeaponsMartialRanged().PopulateMartialRangedWeapons()),
            //};

            return to_return;
        }
    }
}
