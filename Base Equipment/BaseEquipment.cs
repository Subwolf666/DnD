using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class BaseEquipment {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Weight { get; set; }

        public BaseEquipment(int id, string name, int cost, int weight) {
            ID = id;
            Name = name;
            Cost = cost;
            Weight = weight;
        }
    }
}
