using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class Enums {
        public enum ShieldsTypes {
            SHIELD_ID_NONE = 0,
            SHIELD_ID_SHIELD = 1,
        }
        public enum LightArmorTypes {
            LIGHTARMOR_ID_NONE = 0,
            LIGHTARMOR_ID_PADDED = 1,
            LIGHTARMOR_ID_LEATHER = 2,
            LIGHTARMOR_ID_STUDDEDLEATHER = 3,
        }
        public enum MediumArmorTypes {
            MEDIUMARMOR_ID_NONE = 0,
            MEDIUMARMOR_ID_HIDE = 1,
            MEDIUMARMOR_ID_CHAINSHIRT = 2,
            MEDIUMARMOR_ID_SCALEMAIL = 3,
            MEDIUMARMOR_ID_BREASTPLATE = 4,
            MEDIUMARMOR_ID_HALFPLATE = 5,
        }
        public enum HeavyArmorTypes {
            HEAVYARMOR_ID_NONE = 0,
            HEAVYARMOR_ID_RINGMAIL = 1,
            HEAVYARMOR_ID_CHAINMAIL = 2,
            HEAVYARMOR_ID_SPLINT = 3,
            HEAVYARMOR_ID_PLATE = 4,
        }
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
        public enum SimpleMeleeWeaponsTypes {
            SIMPLEMELEEWEAPON_ID_CLUB = 1,
            SIMPLEMELEEWEAPON_ID_DAGGER = 2,
            SIMPLEMELEEWEAPON_ID_GREATCLUB = 3,
            SIMPLEMELEEWEAPON_ID_HANDAXE = 4,
            SIMPLEMELEEWEAPON_ID_JAVELIN = 5,
            SIMPLEMELEEWEAPON_ID_LIGHTHAMMER = 6,
            SIMPLEMELEEWEAPON_ID_MACE = 7,
            SIMPLEMELEEWEAPON_ID_QUARTERSTAFF = 8,
            SIMPLEMELEEWEAPON_ID_SICKLE = 9,
            SIMPLEMELEEWEAPON_ID_SPEAR = 10,
            SIMPLEMELEEWEAPON_ID_UNARMEDSTRIKE = 11,
        }
        public enum SimpleRangedWeaponsTypes {
            SIMPLERANGEDWEAPON_ID_LIGHTCROSSBOW = 1,
            SIMPLERANGEDWEAPON_ID_DART = 2,
            SIMPLERANGEDWEAPON_ID_SHORTBOW = 3,
            SIMPLERANGEDWEAPON_ID_SLING = 4,
        }
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
        public enum MartialRangedWeaponsTypes {
            MARTIALRANGEDWEAPON_ID_BLOWGUN = 1,
            MARTIALRANGEDWEAPON_ID_HANDCROSSBOW = 2,
            MARTIALRANGEDWEAPON_ID_HEAVYCROSSBOW = 3,
            MARTIALRANGEDWEAPON_ID_LONGBOW = 4,
            MARTIALRANGEDWEAPON_ID_NET = 5,
        }
    }
}
