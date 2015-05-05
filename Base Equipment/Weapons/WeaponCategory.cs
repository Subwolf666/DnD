using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class WeaponCategory {

        public Enums.WeaponsTypes ID { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public WeaponsType[] WeaponTypes { get; set; }

        public WeaponCategory() { }

        public WeaponCategory(Enums.WeaponsTypes id, string category, string description, WeaponsType[] weaponTypes) {
            ID = id;
            Category = category;
            Description = description;
            WeaponTypes = weaponTypes;
        }
    }
}
