using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class ArmorLight {
        public static BaseEquipment[] PopulateLightArmor() {
            var LightArmors = new BaseEquipment[] {
                new ArmorType(Enums.LIGHTARMOR_ID_PADDED, "Padded", "Padded armor consists of quilted layers of cloth and batting", 500, 11, null, "Disadvantage", 8),
                new ArmorType(Enums.LIGHTARMOR_ID_LEATHER, "Leather", "The breastplate and shoulder protectors of this armor are made of leather that has been stiffened by being boiled in oil. The rest of the armor is made of softer and more flexible materials.", 1000, 11, null, null, 10),
                new ArmorType(Enums.LIGHTARMOR_ID_STUDDEDLEATHER, "Padded", " Made from tough but flexible leather, studded leather is reinforced with close-set rivets or spikes.", 4500, 11, null, null, 13),
            };
            return LightArmors;
        }

    }
}
