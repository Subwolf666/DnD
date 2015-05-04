using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class ArmorHeavy : ArmorType {

        private const int HEAVYARMOR_ID_RINGMAIL = 1;
        private const int HEAVYARMOR_ID_CHAINMAIL = 2;
        private const int HEAVYARMOR_ID_SPLINT = 3;
        private const int HEAVYARMOR_ID_PLATE = 4;

        public ArmorHeavy() { }

        public ArmorType[] PopulateHeavyArmor() {
            var HeavyArmors = new ArmorType[] {
                new ArmorType(HEAVYARMOR_ID_RINGMAIL, "Ring mail", "This armor is leather armor with heavy " +
                                                    "rings sewn into it. The rings help reinforce the armor " +
                                                    "against blows from swords and axes. Ring mail is " +
                                                    "inferior to chain mail, and it’s usually worn only by those " +
                                                    "who can’t afford better armor", 3000, 14, null, "Disadvantage", 40),
                new ArmorType(HEAVYARMOR_ID_CHAINMAIL, "Chain mail", "Made of interlocking metal rings, chain " +
                                                    "mail includes a layer of quilted fabric worn underneath " +
                                                    "the mail to prevent chafing and to cushion the impact of " +
                                                    "blows. The suit includes gauntlets.", 7500, 16, "Str 13", "Disadvantage", 55),
                new ArmorType(HEAVYARMOR_ID_SPLINT, "Splint", "This armor is made of narrow vertical strips " +
                                                    "of metal riveted to a backing of leather that is worn over " +
                                                    "cloth padding. Flexible chain mail protects the joints.", 20000, 17, "Str 15", "Disadvantage", 60),
                new ArmorType(HEAVYARMOR_ID_PLATE, "Plate", "Plate consists of shaped, interlocking metal " +
                                                    "plates to cover the entire body. A suit of plate includes " +
                                                    "gauntlets, heavy leather boots, a visored helmet, and " +
                                                    "thick layers of padding underneath the armor. Buckles " +
                                                    "and straps distribute the weight over the body", 150000, 18, "Str 15", "Disadvantage", 65),
            };
            return HeavyArmors;
        }

    }
}
