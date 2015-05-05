using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public enum MartialRangedWeaponsTypes {
        MARTIALRANGEDWEAPON_ID_BLOWGUN = 1,
        MARTIALRANGEDWEAPON_ID_HANDCROSSBOW = 2,
        MARTIALRANGEDWEAPON_ID_HEAVYCROSSBOW = 3,
        MARTIALRANGEDWEAPON_ID_LONGBOW = 4,
        MARTIALRANGEDWEAPON_ID_NET = 5,
    }
    public class WeaponsMartialRanged {

        public WeaponsMartialRanged() { }

        public WeaponType[] PopulateMartialRangedWeapons() {
            var MartialRangedWeapons = new WeaponType[] {
                new WeaponType((int)MartialRangedWeaponsTypes.MARTIALRANGEDWEAPON_ID_BLOWGUN,       "Blowgun",        1000, "1",    Enums.DamageTypes.PIERCING, "piercing",  1, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION25100, Enums.DamagePropertiesTypes.LOADING}),
                new WeaponType((int)MartialRangedWeaponsTypes.MARTIALRANGEDWEAPON_ID_HANDCROSSBOW,  "Hand Crossbow",  7500, "1D6",  Enums.DamageTypes.PIERCING, "piercing",  3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION30120, Enums.DamagePropertiesTypes.LIGHT, Enums.DamagePropertiesTypes.LOADING}),
                new WeaponType((int)MartialRangedWeaponsTypes.MARTIALRANGEDWEAPON_ID_HEAVYCROSSBOW, "Heavy Crossbow", 5000, "1D10", Enums.DamageTypes.PIERCING, "piercing", 18, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION100400, Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.LOADING, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponType((int)MartialRangedWeaponsTypes.MARTIALRANGEDWEAPON_ID_LONGBOW,       "Longbow",        5000, "1D8",  Enums.DamageTypes.PIERCING, "piercing",  2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION150600, Enums.DamagePropertiesTypes.HEAVY, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponType((int)MartialRangedWeaponsTypes.MARTIALRANGEDWEAPON_ID_NET,           "Net",             100, "0",    Enums.DamageTypes.NONE,     "",          3, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.SPECIAL, Enums.DamagePropertiesTypes.THROWN515}),
            };
            return MartialRangedWeapons;
        }

    }
}
