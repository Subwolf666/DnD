using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class Enums {
        public enum DamagePropertiesTypes {
            NONE,
            AMMUNITION25100,    // (range 25/100)
            AMMUNITION30120,    // (range 30/120)
            AMMUNITION80320,    // (range 80/320)
            AMMUNITION100400,   // (range 100/400)
            AMMUNITION150600,   // (range 150/600)
            FINESSE,
            HEAVY,
            THROWN515,          // (range 5/15)
            THROWN2060,         // (range 20/60)
            THROWN30120,        // (range 30/120)
            LIGHT,
            LOADING,
            TWOHANDED,
            REACH,
            SPECIAL,
            VERSATILE1D8,       // 1D8
            VERSATILE1D10       // 1D10
        }
        public enum DamageTypes {
            NONE,
            ACID,
            BLUDGEONING,
            COLD,
            FIRE,
            FORCE,
            LIGHTING,
            NECROTIC,
            PIERCING,
            POISON,
            PSYCHIC,
            RADIANT,
            SLASHING,
            THUNDER,
        }
    }
}
