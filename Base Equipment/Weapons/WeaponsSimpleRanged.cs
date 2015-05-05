using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class WeaponsSimpleRanged {

        public WeaponsSimpleRanged() { }

        public WeaponsType[] PopulateSimpleRangedWeapons() {
            var SimpleRangedWeapons = new WeaponsType[] {
                new WeaponsType((int)Enums.SimpleRangedWeaponsTypes.SIMPLERANGEDWEAPON_ID_LIGHTCROSSBOW, "Light crossbow", 2500, "1D8", Enums.DamageTypes.PIERCING, "piercing", 5, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.LIGHT}),
                new WeaponsType((int)Enums.SimpleRangedWeaponsTypes.SIMPLERANGEDWEAPON_ID_DART, "Dart", 5, "1D4", Enums.DamageTypes.PIERCING, "piercing", -4, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.FINESSE,  Enums.DamagePropertiesTypes.THROWN2060}),
                new WeaponsType((int)Enums.SimpleRangedWeaponsTypes.SIMPLERANGEDWEAPON_ID_SHORTBOW, "Shortbow", 2500, "1D6", Enums.DamageTypes.PIERCING, "piercing", 2, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION80320, Enums.DamagePropertiesTypes.TWOHANDED}),
                new WeaponsType((int)Enums.SimpleRangedWeaponsTypes.SIMPLERANGEDWEAPON_ID_SLING, "Sling", 10, "1D4", Enums.DamageTypes.BLUDGEONING, "bludgeoning", 0, new Enums.DamagePropertiesTypes[] {Enums.DamagePropertiesTypes.AMMUNITION30120}),
            };
            return SimpleRangedWeapons;
        }
    }
}
