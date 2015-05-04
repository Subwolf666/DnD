using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseHeightAndWeight {

        public int HeightFeet { get; set; }
        public int HeightInches { get; set; }
        public string HeightModifier { get; set; }

        public int WeightPounds { get; set; }
        public string WeightModifier { get; set; }

        /*
         *  Example:
         *  Human height is 4'8" + 2D10 inches
         *  2D10 gives a total of 12.
         *  The height = 4'8" + 12 inches = 5'8".
         *  For weight use the same roll from the 2D10 (is 12)
         *  is 12 * 2D4 pounds. 2D4 gives a total of 3.
         *  The weight = 110 pounds + (12 * 3) = 146 pounds.
         */
    }
}
