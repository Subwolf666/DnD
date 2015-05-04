using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
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

    public class WeaponsSimpleMelee {

        public WeaponsSimpleMelee() { }

        public WeaponType[] PopulateSimpleMeleeWeapons() {
            var SimpleMeleeWeapons = new WeaponType[] {
                new WeaponType((int)SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_CLUB,           "Club",             10, "1D4", DamageTypes.BLUDGEONING, "bludgeoning",  2, new PropertiesTypes[] {PropertiesTypes.LIGHT}),
                new WeaponType((int)SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_DAGGER,         "Dagger",          200, "1D4", DamageTypes.PIERCING,    "piercing",     1, new PropertiesTypes[] {PropertiesTypes.FINESSE,  PropertiesTypes.LIGHT, PropertiesTypes.THROWN2060}),
                new WeaponType((int)SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_GREATCLUB,      "Greatclub",        20, "1D8", DamageTypes.BLUDGEONING, "bludgeoning", 10, new PropertiesTypes[] {PropertiesTypes.TWOHANDED}),
                new WeaponType((int)SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_HANDAXE,        "Handaxe",         500, "1D6", DamageTypes.SLASHING,    "slashing",     2, new PropertiesTypes[] {PropertiesTypes.LIGHT,    PropertiesTypes.THROWN2060}),
                new WeaponType((int)SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_JAVELIN,        "Javelin",          50, "1D6", DamageTypes.PIERCING,    "piercing",     2, new PropertiesTypes[] {PropertiesTypes.THROWN30120}),
                new WeaponType((int)SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_LIGHTHAMMER,    "Light hammer",    200, "1D4", DamageTypes.BLUDGEONING, "bludgeoning",  2, new PropertiesTypes[] {PropertiesTypes.LIGHT,    PropertiesTypes.THROWN2060}),
                new WeaponType((int)SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_MACE,           "Mace",            500, "1D6", DamageTypes.BLUDGEONING, "bludgeoning",  4, new PropertiesTypes[] {PropertiesTypes.NONE}),
                new WeaponType((int)SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_QUARTERSTAFF,   "Quarterstaff",     20, "1D6", DamageTypes.BLUDGEONING, "bludgeoning",  4, new PropertiesTypes[] {PropertiesTypes.VERSATILE1D8}),
                new WeaponType((int)SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_SICKLE,         "Sickle",          100, "1D4", DamageTypes.SLASHING,    "slashing",     2, new PropertiesTypes[] {PropertiesTypes.LIGHT}),
                new WeaponType((int)SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_SPEAR,          "Spear",           100, "1D6", DamageTypes.PIERCING,    "piercing",     3, new PropertiesTypes[] {PropertiesTypes.THROWN2060, PropertiesTypes.VERSATILE1D8}),
                new WeaponType((int)SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_UNARMEDSTRIKE,  "Unarmed strike",    0,   "1", DamageTypes.BLUDGEONING, "bludgeoning",  0, new PropertiesTypes[] {PropertiesTypes.NONE}),
            };
            return SimpleMeleeWeapons;
        }

    }
}
