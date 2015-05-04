using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class ArmorLight : ArmorType {

        private const int LIGHTARMOR_ID_PADDED = 1;
        private const int LIGHTARMOR_ID_LEATHER = 2;
        private const int LIGHTARMOR_ID_STUDDEDLEATHER = 3;

        public ArmorLight() { }

        // Create LightArmorTable
        public ArmorType[] PopulateLightArmor() {
            var LightArmors = new ArmorType[] {
                new ArmorType(LIGHTARMOR_ID_PADDED, "Padded", "Padded armor consists of quilted layers of cloth and batting", 500, 11, null, "Disadvantage", 8),
                new ArmorType(LIGHTARMOR_ID_LEATHER, "Leather", "The breastplate and shoulder protectors of this armor are made of leather that has been stiffened by being boiled in oil. The rest of the armor is made of softer and more flexible materials.", 1000, 11, null, null, 10),
                new ArmorType(LIGHTARMOR_ID_STUDDEDLEATHER, "Padded", " Made from tough but flexible leather, studded leather is reinforced with close-set rivets or spikes.", 4500, 11, null, null, 13),
            };
            return LightArmors;
        }

    }
}
