using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class Armor {

        public Armor() { }

        public ArmorCategory[] PopulateArmor() {

            var AllArmors = new ArmorCategory[] {
                new ArmorCategory(Enums.ArmorTypes.ARMOR_ID_NONE, "No armor", "No description", null, 0, 0),
                new ArmorCategory(Enums.ArmorTypes.ARMOR_ID_LIGHTARMOR, "Light Armor", "Made from supple and thin materials, light armor favors agile adventurers since it offers some protection without sacrificing mobility.", new ArmorLight().PopulateLightArmor(), 1, 1),
                new ArmorCategory(Enums.ArmorTypes.ARMOR_ID_MEDIUMARMOR, "Medium Armor", "Medium armor offers more protection than light armor, but it also impairs movement more.", new ArmorMedium().PopulateMediumArmor(), 5, 1),
                new ArmorCategory(Enums.ArmorTypes.ARMOR_ID_HEAVYARMOR, "Heavy Armor", "Of all the armor categories, heavy armor offers the best protection. These suits of armor cover the entire body and are designed to stop a wide range of attacks. Only proficient warriors can manage their weight and bulk", new ArmorHeavy().PopulateHeavyArmor(), 10, 5),
                new ArmorCategory(Enums.ArmorTypes.ARMOR_ID_SHIELD, "Shield", "A shield is made from wood or metal and is carried in one hand.", new ArmorShield().PopulateShields(), 1, 1),
            };

            return AllArmors;
        }
    }
}

