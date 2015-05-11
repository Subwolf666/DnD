using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class WeaponsType : BaseEquipment {
        public string DamageDice { get; set; }
        public Enums.DamageTypes DamageType { get; set; }
        public string DamageName { get; set; }
        public Enums.DamagePropertiesTypes[] Properties { get; set; }

        public WeaponsType(int id, string name, int cost, string damageDice, Enums.DamageTypes damageType, string damageName, int weight, Enums.DamagePropertiesTypes[] properties) : base(id, name, cost, weight) {
            DamageDice = damageDice;
            DamageType = damageType;
            DamageName = damageName;
            Properties = properties;
        }

    }
}
