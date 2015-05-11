using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class ArmorCategory : ArmorType {

        public Enums.EquipmentTypes ID { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        //public ArmorType[] ArmorTypes { get; set; }
        public int Donning { get; set; }
        public int Doffing { get; set; }

        //public ArmorCategory() { }

        public ArmorCategory(Enums.EquipmentTypes id, string category, string description, ArmorType[] armorTypes, int donning, int doffing) : base(armorTypes) {
            ID = id;
            Category = category;
            Description = description;
            //ArmorTypes = armorTypes;
            Donning = donning;
            Doffing = doffing;
        }
    }
}
