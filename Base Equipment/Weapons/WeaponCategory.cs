using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class WeaponCategory {

        public int ID { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public WeaponType[] WeaponTypes { get; set; }

        public WeaponCategory() { }

        public WeaponCategory(int id, string category, string description, WeaponType[] weaponTypes) {
            ID = id;
            Category = category;
            Description = description;
            WeaponTypes = weaponTypes;
        }
    }
}
