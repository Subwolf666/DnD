using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;

namespace Base_Character {
    public class BaseHeightAndWeightHuman : BaseHeightAndWeight {
        public BaseHeightAndWeightHuman() {

            // Base Height of the Human Race
            HeightFeet = 4;
            HeightInches = 8;
            HeightModifier = "2D10";

            // Base Weight of the Human Race
            WeightPounds = 110;
            WeightModifier = "2D4";
        }
    }
}
