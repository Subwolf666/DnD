using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class ArmorType : BaseEquipment {
        public string Description { get; set; }
        public int ArmorClass { get; set; }
        public string Strength { get; set; }
        public string Stealth { get; set; }

        public ArmorType(int id, string name, string description, int cost, int armorClass, string strength, string stealth, int weight) : base(id, name, cost, weight) {
            Description = description;
            ArmorClass = armorClass;
            Strength = strength;
            Stealth = stealth;
        }
    }
}
