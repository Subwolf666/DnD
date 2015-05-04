using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;

namespace Base_Character {
    public class BaseHeightAndWeightStoutHalfling : BaseHeightAndWeight {
        public BaseHeightAndWeightStoutHalfling() {

            // Base Height of the Stout Halfling Race
            HeightFeet = 2;
            HeightInches = 7;
            HeightModifier = "2D4";

            // Base Weight of the Stout Halfling Race
            WeightPounds = 35;
            WeightModifier = "1D1";
        }
    }
}
