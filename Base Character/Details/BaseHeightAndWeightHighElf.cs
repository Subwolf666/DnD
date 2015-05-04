using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;

namespace Base_Character {
    public class BaseHeightAndWeightHighElf : BaseHeightAndWeight {
        public BaseHeightAndWeightHighElf() {

            // Base Height of the High Elf Race
            HeightFeet = 4;
            HeightInches = 6;
            HeightModifier = "2D10";

            // Base Weight of the High Elf Race
            WeightPounds = 90;
            WeightModifier = "1D4";
        }
    }
}
