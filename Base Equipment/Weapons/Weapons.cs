using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class Weapons {

        public Weapons() { }

        public WeaponCategory[] PopulateWeapons() {

            var AllWeapons = new WeaponCategory[] {
                new WeaponCategory(Enums.WeaponsTypes.WEAPONS_ID_SIMPLEMELEEWEAPONS, "Simple melee weapons", string.Empty, new WeaponsSimpleMelee().PopulateSimpleMeleeWeapons()),
                new WeaponCategory(Enums.WeaponsTypes.WEAPONS_ID_SIMPLERANGEDWEAPONS, "Simple ranged weapons", string.Empty, new WeaponsSimpleRanged().PopulateSimpleRangedWeapons()),
                new WeaponCategory(Enums.WeaponsTypes.WEAPONS_ID_MARTIALMELEEWEAPONS, "Martial melee weapons", string.Empty, new WeaponsMartialMelee().PopulateMartialMeleeWeapons()),
                new WeaponCategory(Enums.WeaponsTypes.WEAPONS_ID_MARTIALRANGEDWEAPONS, "Martial ranged weapons", string.Empty, new WeaponsMartialRanged().PopulateMartialRangedWeapons()),
            };

            return AllWeapons;
        }
    }
}
