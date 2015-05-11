using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;

namespace Base_Character {
    public class Inventory {
        // array to store items
        public BaseEquipment[] Items { get; private set; }

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
                Items = new BaseEquipment[cap];
            else {
                BaseEquipment[] kut = Items;
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
        public int AddItem(BaseEquipment item) {
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
