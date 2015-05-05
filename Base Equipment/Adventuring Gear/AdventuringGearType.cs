using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class AdventuringGearType {

        public int ID { get; set; }
        public string Item { get; set; }
        public int Cost { get; set; }
        public int Weight { get; set; }
        public string DamageDice { get; set; }
        public Enums.DamageTypes DamageType { get; set; }
        public string DamageName { get; set; }
        public Enums.DamagePropertiesTypes[] Properties { get; set; }

        public AdventuringGearType() { }

        public AdventuringGearType(int id, string name, int cost, string damageDice, Enums.DamageTypes damageType, string damageName, int weight, Enums.DamagePropertiesTypes[] properties) {
            ID = id;
            Item = name;
            Cost = cost;
            DamageDice = damageDice;
            DamageType = damageType;
            DamageName = damageName;
            Weight = weight;
            Properties = properties;
        }

    }
}
