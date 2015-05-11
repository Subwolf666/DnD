using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class ArmorMedium {

        public ArmorMedium() { }

        public ArmorType[] PopulateMediumArmor() {
            var MediumArmors = new ArmorType[] {
                //new ArmorType((int)Enums.MediumArmorTypes.MEDIUMARMOR_ID_HIDE, "Hide", "This crude armor consists of thick furs and " +
                //                                    "pelts. It is commonly worn by barbarian tribes, evil " +
                //                                    "humanoids, and other folk who lack access to the tools " +
                //                                    "and materials needed to create better armor.", 1000, 12, null, null, 12),
                //new ArmorType((int)Enums.MediumArmorTypes.MEDIUMARMOR_ID_CHAINSHIRT, "Chain shirt", "Made of interlocking metal rings, a chain " +
                //                                    "shirt is worn between layers of clothing or leather. This " +
                //                                    "armor offers modest protection to the wearer’s upper " +
                //                                    "body and allows the sound of the rings rubbing against " +
                //                                    "one another to be muffled by outer layers.", 5000, 13, null, null, 20),
                //new ArmorType((int)Enums.MediumArmorTypes.MEDIUMARMOR_ID_SCALEMAIL, "Scale mail", "This armor consists of a coat and leggings " +
                //                                    "(and perhaps a separate skirt) of leather covered with " +
                //                                    "overlapping pieces of metal, much like the scales of a " +
                //                                    "fish. The suit includes gauntlets.", 5000, 14, null, "Disadvantage", 45),
                //new ArmorType((int)Enums.MediumArmorTypes.MEDIUMARMOR_ID_BREASTPLATE, "Breastplate", "This armor consists of a fitted metal " +
                //                                    "chest piece worn with supple leather. Although it leaves " +
                //                                    "the legs and arms relatively unprotected, this armor " +
                //                                    "provides good protection for the wearer’s vital organs " +
                //                                    "while leaving the wearer relatively unencumbered.", 40000, 14, null, null, 20),
                //new ArmorType((int)Enums.MediumArmorTypes.MEDIUMARMOR_ID_HALFPLATE, "Half plate", "Half plate consists of shaped metal plates " +
                //                                    "that cover most of the wearer’s body. it does not include " +
                //                                    "leg protection beyond simple greaves that are attached " +
                //                                    "with leather straps.", 75000, 15, null, "Disadvantage", 40),
            };
            return MediumArmors;
        }

    }
}
