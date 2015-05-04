using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class WeaponsSimpleRanged {

        private const int SIMPLERANGEDWEAPON_ID_LIGHTCROSSBOW = 1;
        private const int SIMPLERANGEDWEAPON_ID_DART = 2;
        private const int SIMPLERANGEDWEAPON_ID_SHORTBOW = 3;
        private const int SIMPLERANGEDWEAPON_ID_SLING = 4;

        public WeaponsSimpleRanged() { }

        // add 
        // Properties class
        public WeaponType[] PopulateSimpleRangedWeapons() {
            var SimpleRangedWeapons = new WeaponType[] {
                new WeaponType(SIMPLERANGEDWEAPON_ID_LIGHTCROSSBOW, "Light crossbow", 2500, "1D8", DamageTypes.PIERCING, "piercing", 5, new PropertiesTypes[] {PropertiesTypes.LIGHT}),
                new WeaponType(SIMPLERANGEDWEAPON_ID_DART, "Dart", 5, "1D4", DamageTypes.PIERCING, "piercing", -4, new PropertiesTypes[] {PropertiesTypes.FINESSE,  PropertiesTypes.THROWN2060}),
                new WeaponType(SIMPLERANGEDWEAPON_ID_SHORTBOW, "Shortbow", 2500, "1D6", DamageTypes.PIERCING, "piercing", 2, new PropertiesTypes[] {PropertiesTypes.AMMUNITION80320, PropertiesTypes.TWOHANDED}),
                new WeaponType(SIMPLERANGEDWEAPON_ID_SLING, "Sling", 10, "1D4", DamageTypes.BLUDGEONING, "bludgeoning", 0, new PropertiesTypes[] {PropertiesTypes.AMMUNITION30120}),
            };
            return SimpleRangedWeapons;
        }
    }
}
