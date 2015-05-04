using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseHeightAndWeightHillDwarf : BaseHeightAndWeight {
        public BaseHeightAndWeightHillDwarf() {

            // Base Height of the Hill Dwarf Race
            HeightFeet = 3;
            HeightInches = 8;
            HeightModifier = "2D4";

            // Base Weight of the Hill Dwarf Race
            WeightPounds = 115;
            WeightModifier = "2D6";
        }
    }
}
