using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;

namespace Base_Character {
    public class BaseHeightAndWeightMountainDwarf : BaseHeightAndWeight {
        public BaseHeightAndWeightMountainDwarf() {

            // Base Height of the Mountain Dwarf Race
            HeightFeet = 4;
            HeightInches = 0;
            HeightModifier = "2D4";

            // Base Weight of the Mountain Dwarf Race
            WeightPounds = 130;
            WeightModifier = "2D6";
        }
    }
}
