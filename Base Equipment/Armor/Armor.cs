using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class Armor {
        public static BaseEquipment[] ArmorList { get { return PopulateArmor(); } }
        private static BaseEquipment[] PopulateArmor() {
            var to_return = new BaseEquipment[] {
            //new ArmorCategory(Enums.ArmorTypes.ARMOR_ID_LIGHTARMOR, "Light Armor", "Made from supple and thin materials, light armor favors agile adventurers since it offers some protection without sacrificing mobility.", ArmorLight.PopulateLightArmor(), 1, 1),
                new ArmorType(Enums.LIGHTARMOR_ID_PADDED, "Padded", "Padded armor consists of quilted layers of cloth and batting", 500, 11, null, "Disadvantage", 8),
                new ArmorType(Enums.LIGHTARMOR_ID_LEATHER, "Leather", "The breastplate and shoulder protectors of this armor are made of leather that has been stiffened by being boiled in oil. The rest of the armor is made of softer and more flexible materials.", 1000, 11, null, null, 10),
                new ArmorType(Enums.LIGHTARMOR_ID_STUDDEDLEATHER, "Padded", " Made from tough but flexible leather, studded leather is reinforced with close-set rivets or spikes.", 4500, 11, null, null, 13),
            //new ArmorCategory(Enums.ArmorTypes.ARMOR_ID_MEDIUMARMOR, "Medium Armor", "Medium armor offers more protection than light armor, but it also impairs movement more.", new ArmorMedium().PopulateMediumArmor(), 5, 1),
                new ArmorType(Enums.MEDIUMARMOR_ID_HIDE, "Hide", "This crude armor consists of thick furs and pelts. It is commonly worn by barbarian tribes, evil humanoids, and other folk who lack access to the tools and materials needed to create better armor.", 1000, 12, null, null, 12),
                new ArmorType(Enums.MEDIUMARMOR_ID_CHAINSHIRT, "Chain shirt", "Made of interlocking metal rings, a chain shirt is worn between layers of clothing or leather. This armor offers modest protection to the wearer’s upper body and allows the sound of the rings rubbing against one another to be muffled by outer layers.", 5000, 13, null, null, 20),
                new ArmorType(Enums.MEDIUMARMOR_ID_SCALEMAIL, "Scale mail", "This armor consists of a coat and leggings (and perhaps a separate skirt) of leather covered with overlapping pieces of metal, much like the scales of a fish. The suit includes gauntlets.", 5000, 14, null, "Disadvantage", 45),
                new ArmorType(Enums.MEDIUMARMOR_ID_BREASTPLATE, "Breastplate", "This armor consists of a fitted metal chest piece worn with supple leather. Although it leaves the legs and arms relatively unprotected, this armor provides good protection for the wearer’s vital organs while leaving the wearer relatively unencumbered.", 40000, 14, null, null, 20),
                new ArmorType(Enums.MEDIUMARMOR_ID_HALFPLATE, "Half plate", "Half plate consists of shaped metal plates that cover most of the wearer’s body. it does not include leg protection beyond simple greaves that are attached with leather straps.", 75000, 15, null, "Disadvantage", 40),
            //new ArmorCategory(Enums.ArmorTypes.ARMOR_ID_HEAVYARMOR, "Heavy Armor", "Of all the armor categories, heavy armor offers the best protection. These suits of armor cover the entire body and are designed to stop a wide range of attacks. Only proficient warriors can manage their weight and bulk", new ArmorHeavy().PopulateHeavyArmor(), 10, 5),
                new ArmorType(Enums.HEAVYARMOR_ID_RINGMAIL, "Ring mail", "This armor is leather armor with heavy rings sewn into it. The rings help reinforce the armor against blows from swords and axes. Ring mail is inferior to chain mail, and it’s usually worn only by those who can’t afford better armor", 3000, 14, null, "Disadvantage", 40),
                new ArmorType(Enums.HEAVYARMOR_ID_CHAINMAIL, "Chain mail", "Made of interlocking metal rings, chain mail includes a layer of quilted fabric worn underneath the mail to prevent chafing and to cushion the impact of blows. The suit includes gauntlets.", 7500, 16, "Str 13", "Disadvantage", 55),
                new ArmorType(Enums.HEAVYARMOR_ID_SPLINT, "Splint", "This armor is made of narrow vertical strips of metal riveted to a backing of leather that is worn over cloth padding. Flexible chain mail protects the joints.", 20000, 17, "Str 15", "Disadvantage", 60),
                new ArmorType(Enums.HEAVYARMOR_ID_PLATE, "Plate", "Plate consists of shaped, interlocking metal plates to cover the entire body. A suit of plate includes gauntlets, heavy leather boots, a visored helmet, and thick layers of padding underneath the armor. Buckles and straps distribute the weight over the body", 150000, 18, "Str 15", "Disadvantage", 65),
            //new ArmorCategory(Enums.ArmorTypes.ARMOR_ID_SHIELD, "Shield", "A shield is made from wood or metal and is carried in one hand.", new ArmorShield().PopulateShields(), 1, 1),
                new ArmorType(Enums.SHIELD_ID_SHIELD, "Shield", string.Empty, 1000, 2, null, null, 6),
            };
            return to_return;
        }
    }
}
