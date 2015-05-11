using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class WeaponsSimpleMelee {

        public WeaponsSimpleMelee() { }

        public WeaponsType[] PopulateSimpleMeleeWeapons() {
            var SimpleMeleeWeapons = new WeaponsType[] {
                //new WeaponsType((int)Enums.SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_CLUB,           "Club",             10, "1D4", Enums.DamageTypes.BLUDGEONING, "bludgeoning",  2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.LIGHT}),
                //new WeaponsType((int)Enums.SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_DAGGER,         "Dagger",          200, "1D4", Enums.DamageTypes.PIERCING,    "piercing",     1, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.FINESSE,  Enums.DamagePropertiesTypes.LIGHT, Enums.DamagePropertiesTypes.THROWN2060}),
                //new WeaponsType((int)Enums.SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_GREATCLUB,      "Greatclub",        20, "1D8", Enums.DamageTypes.BLUDGEONING, "bludgeoning", 10, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.TWOHANDED}),
                //new WeaponsType((int)Enums.SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_HANDAXE,        "Handaxe",         500, "1D6", Enums.DamageTypes.SLASHING,    "slashing",     2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.LIGHT,    Enums.DamagePropertiesTypes.THROWN2060}),
                //new WeaponsType((int)Enums.SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_JAVELIN,        "Javelin",          50, "1D6", Enums.DamageTypes.PIERCING,    "piercing",     2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.THROWN30120}),
                //new WeaponsType((int)Enums.SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_LIGHTHAMMER,    "Light hammer",    200, "1D4", Enums.DamageTypes.BLUDGEONING, "bludgeoning",  2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.LIGHT,    Enums.DamagePropertiesTypes.THROWN2060}),
                //new WeaponsType((int)Enums.SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_MACE,           "Mace",            500, "1D6", Enums.DamageTypes.BLUDGEONING, "bludgeoning",  4, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.NONE}),
                //new WeaponsType((int)Enums.SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_QUARTERSTAFF,   "Quarterstaff",     20, "1D6", Enums.DamageTypes.BLUDGEONING, "bludgeoning",  4, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.VERSATILE1D8}),
                //new WeaponsType((int)Enums.SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_SICKLE,         "Sickle",          100, "1D4", Enums.DamageTypes.SLASHING,    "slashing",     2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.LIGHT}),
                //new WeaponsType((int)Enums.SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_SPEAR,          "Spear",           100, "1D6", Enums.DamageTypes.PIERCING,    "piercing",     3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.THROWN2060, Enums.DamagePropertiesTypes.VERSATILE1D8}),
                //new WeaponsType((int)Enums.SimpleMeleeWeaponsTypes.SIMPLEMELEEWEAPON_ID_UNARMEDSTRIKE,  "Unarmed strike",    0,   "1", Enums.DamageTypes.BLUDGEONING, "bludgeoning",  0, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.NONE}),
            };
            return SimpleMeleeWeapons;
        }

    }
}
