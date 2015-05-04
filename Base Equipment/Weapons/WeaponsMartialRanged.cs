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
                new WeaponType((int)MartialRangedWeaponsTypes.MARTIALRANGEDWEAPON_ID_BLOWGUN,       "Blowgun",        1000, "1",    DamageTypes.PIERCING, "piercing",  1, new PropertiesTypes[] {PropertiesTypes.AMMUNITION25100, PropertiesTypes.LOADING}),
                new WeaponType((int)MartialRangedWeaponsTypes.MARTIALRANGEDWEAPON_ID_HANDCROSSBOW,  "Hand Crossbow",  7500, "1D6",  DamageTypes.PIERCING, "piercing",  3, new PropertiesTypes[] {PropertiesTypes.AMMUNITION30120, PropertiesTypes.LIGHT, PropertiesTypes.LOADING}),
                new WeaponType((int)MartialRangedWeaponsTypes.MARTIALRANGEDWEAPON_ID_HEAVYCROSSBOW, "Heavy Crossbow", 5000, "1D10", DamageTypes.PIERCING, "piercing", 18, new PropertiesTypes[] {PropertiesTypes.AMMUNITION100400, PropertiesTypes.HEAVY, PropertiesTypes.LOADING, PropertiesTypes.TWOHANDED}),
                new WeaponType((int)MartialRangedWeaponsTypes.MARTIALRANGEDWEAPON_ID_LONGBOW,       "Longbow",        5000, "1D8",  DamageTypes.PIERCING, "piercing",  2, new PropertiesTypes[] {PropertiesTypes.AMMUNITION150600, PropertiesTypes.HEAVY, PropertiesTypes.TWOHANDED}),
                new WeaponType((int)MartialRangedWeaponsTypes.MARTIALRANGEDWEAPON_ID_NET,           "Net",             100, "0",    DamageTypes.NONE,     "",          3, new PropertiesTypes[] {PropertiesTypes.SPECIAL, PropertiesTypes.THROWN515}),
            };
            return MartialRangedWeapons;
        }

    }
}
