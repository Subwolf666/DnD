using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public enum ArmorTypes {
        ARMOR_ID_NONE = 1,
        ARMOR_ID_LIGHTARMOR = 2,
        ARMOR_ID_MEDIUMARMOR = 3,
        ARMOR_ID_HEAVYARMOR = 4,
        ARMOR_ID_SHIELD = 5,
    }
    public class ArmorTable {

        public ArmorTable() { }

        public ArmorCategory[] PopulateArmor() {
            var lightArmorTable = new ArmorLight();
            var mediumArmorTable = new ArmorMedium();
            var heavyArmorTable = new ArmorHeavy();
            var shieldTable = new ArmorShield();

            // Create LightArmorTable
            var test1 = lightArmorTable.PopulateLightArmor();
            var test2 = mediumArmorTable.PopulateMediumArmor();
            var test3 = heavyArmorTable.PopulateHeavyArmor();
            var test4 = shieldTable.PopulateShields();

            var AllArmors = new ArmorCategory[] {
                new ArmorCategory(ArmorTypes.ARMOR_ID_LIGHTARMOR, "Light Armor", "Made from supple and thin materials, light armor favors agile adventurers since it offers some protection without sacrificing mobility.", test1, 1, 1),
                new ArmorCategory(ArmorTypes.ARMOR_ID_MEDIUMARMOR, "Medium Armor", "Medium armor offers more protection than light armor, but it also impairs movement more.", test2, 5, 1),
                new ArmorCategory(ArmorTypes.ARMOR_ID_HEAVYARMOR, "Heavy Armor", "Of all the armor categories, heavy armor offers the best protection. These suits of armor cover the entire body and are designed to stop a wide range of attacks. Only proficient warriors can manage their weight and bulk", test3, 10, 5),
                new ArmorCategory(ArmorTypes.ARMOR_ID_SHIELD, "Shield", "A shield is made from wood or metal and is carried in one hand.", test4, 1, 1),
            };

            return AllArmors;
        }
    }
}

