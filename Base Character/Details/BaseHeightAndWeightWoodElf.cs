using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseHeightAndWeightWoodElf : BaseHeightAndWeight {
        public BaseHeightAndWeightWoodElf() {

            // Base Height of the Wood Elf Race
            HeightFeet = 4;
            HeightInches = 6;
            HeightModifier = "2D10";

            // Base Weight of the Wood Elf Race
            WeightPounds = 100;
            WeightModifier = "1D4";
        }
    }
}
