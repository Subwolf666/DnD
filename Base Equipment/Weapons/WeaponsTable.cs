using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public enum WeaponsTypes {
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

    public class WeaponsTable {

        public WeaponsTable() { }

        public WeaponCategory[] PopulateWeapons() {
            var SimpleMeleeWeaponsTable = new WeaponsSimpleMelee();
            var SimpleRangedWeaponsTable = new WeaponsSimpleRanged();
            var MartialMeleeWeaponsTable = new WeaponsMartialMelee();
            var MartialRangedWeaponsTable = new WeaponsMartialRanged();

            // Create LightArmorTable
            var test1 = SimpleMeleeWeaponsTable.PopulateSimpleMeleeWeapons();
            var test2 = SimpleRangedWeaponsTable.PopulateSimpleRangedWeapons();
            var test3 = MartialMeleeWeaponsTable.PopulateMartialMeleeWeapons();
            var test4 = MartialRangedWeaponsTable.PopulateMartialRangedWeapons();

            var AllWeapons = new WeaponCategory[] {
                new WeaponCategory((int)WeaponsTypes.WEAPONS_ID_SIMPLEMELEEWEAPONS, "Simple melee weapons", string.Empty, test1),
                new WeaponCategory((int)WeaponsTypes.WEAPONS_ID_SIMPLERANGEDWEAPONS, "Simple ranged weapons", string.Empty, test2),
                new WeaponCategory((int)WeaponsTypes.WEAPONS_ID_MARTIALMELEEWEAPONS, "Martial melee weapons", string.Empty, test3),
                new WeaponCategory((int)WeaponsTypes.WEAPONS_ID_MARTIALRANGEDWEAPONS, "Martial ranged weapons", string.Empty, test4),
            };

            return AllWeapons;
        }
    }
}
