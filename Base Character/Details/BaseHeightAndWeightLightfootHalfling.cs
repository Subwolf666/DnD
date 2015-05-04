using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseHeightAndWeightLightfootHalfling : BaseHeightAndWeight {
        public BaseHeightAndWeightLightfootHalfling() {

            // Base Height of the Lightfoot Halfling Race
            HeightFeet = 2;
            HeightInches = 7;
            HeightModifier = "2D4";

            // Base Weight of the Lightfoot Halfling Race
            WeightPounds = 35;
            WeightModifier = "1D1"; // just 1
        }
    }
}
