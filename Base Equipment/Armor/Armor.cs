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

    public class Inventory {
        // array to store items
        public BaseEquipmentType[] Items { get; private set; }

        // Inventory capacity is array length
        public int Capacity { get { return (Items == null) ? 0 : Items.Length; } }

        // Constructor
        public Inventory(int capacity = 10) {
            SetInventorySize(capacity);
        }

        // Set size of inventory, retaining contents where possible
        public void SetInventorySize(int cap) {
            if (cap <= 0)
                Items = null;
            else if (Items == null)
                Items = new BaseEquipmentType[cap];
            else {
                BaseEquipmentType[] kut = Items;
                Array.Resize(ref kut, cap);
            }
        }

        // Get index number of first free slot in inventory
        public int FirstAvail() {
            if (Items != null) {
                for (int i = 0; i < Items.Length; ++i) {
                    if (Items[i] == null)
                        return i;
                }
            }
            return -1;
        }

        // Add item to array, returning index or -1 on failure
        public int AddItem(BaseEquipmentType item) {
            if (Items != null) {
                for (int i = 0; i < Items.Length; ++i) {
                    if (Items[i] == null) {
                        Items[i] = item;
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}

