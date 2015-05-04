using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    class AllArmor {

        public static readonly List<ArmorType> LightArmorTypes = new List<ArmorType>();
        public static readonly List<ArmorCategory> ArmorCategories = new List<ArmorCategory>();

        public const int ARMOR_ID_LIGHTARMOR = 1;
        public const int ARMOR_ID_MEDIUMARMOR = 2;
        public const int ARMOR_ID_HEAVYARMOR = 3;
        public const int ARMOR_ID_SHIELD = 4;

        public const int LIGHTARMOR_ID_PADDED = 1;
        public const int LIGHTARMOR_ID_LEATHER = 2;
        public const int LIGHTARMOR_ID_STUDDEDLEATHER = 3;

        public static void PopulateLightArmor() {
            LightArmorTypes.Add(new ArmorType(LIGHTARMOR_ID_PADDED, "Padded", "Padded armor consists of quilted layers of cloth and batting", 500, 11, null, "Disadvantage", 8));
            LightArmorTypes.Add(new ArmorType(LIGHTARMOR_ID_LEATHER, "Leather", "The breastplate and shoulder protectors of this armor are made of leather that has been stiffened by being boiled in oil. The rest of the armor is made of softer and more flexible materials.", 1000, 11, null, null, 10));
            LightArmorTypes.Add(new ArmorType(LIGHTARMOR_ID_STUDDEDLEATHER, "Padded", " Made from tough but flexible leather, studded leather is reinforced with close-set rivets or spikes.", 4500, 11, null, null, 13));
        }

        public void PopulateArmor() {

            //ArmorCategory LightArmor = new ArmorCategory(ARMOR_ID_LIGHTARMOR, "Light Armor", "Made from supple and thin materials, light armor favors agile adventurers since it offers some protection without sacrificing mobility", 1, 1);
        }
    }
}
