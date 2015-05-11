using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class ArmorCategory {

        public int CatID { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public ArmorType[] ArmorTypes { get; set; }
        public int Donning { get; set; }
        public int Doffing { get; set; }

        public ArmorCategory(int catid, string category, string description, ArmorType[] armorTypes, int donning, int doffing) {
            CatID = catid;
            Category = category;
            Description = description;
            ArmorTypes = armorTypes;
            Donning = donning;
            Doffing = doffing;
        }
    }
}
