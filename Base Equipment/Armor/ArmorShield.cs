using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {
    public class ArmorShield : ArmorType {

        private const int SHIELD_ID_SHIELD = 1;

        public ArmorShield() { }

        public ArmorType[] PopulateShields() {
            var Shields = new ArmorType[] {
                new ArmorType(SHIELD_ID_SHIELD, "Shield", string.Empty, 1000, 2, null, null, 6),
            };
            return Shields;
        }

    }
}
