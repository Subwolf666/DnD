using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class ArmorType : BaseEquipmentType {

        //public int ID { get; set; }
        //public string Name { get; set; }
        public string Description { get; set; }
        //public int Cost { get; set; }
        public int ArmorClass { get; set; }
        public string Strength { get; set; }
        public string Stealth { get; set; }
        //public int Weight { get; set; }

        public ArmorType() { }

        public ArmorType(int id, string name, string description, int cost, int armorClass, string strength, string stealth, int weight) {
            ID = id;
            Name = name;
            Description = description;
            Cost = cost;
            ArmorClass = armorClass;
            Strength = strength;
            Stealth = stealth;
            Weight = weight;
        }
    }
}
