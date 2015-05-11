using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class StoutHalfling : Races {
        public StoutHalfling() {

            Name = RaceTypes.Stouthalflings;
            RaceDescription = StringFunctions.RaceDescriptionTextStoutHalfling;
            RaceTraitsAbilityScoreIncrease = new RaceAbilityScoreIncreaseStoutHalfling();
            RaceTraitsAge = 18.0f;
            RaceTraitsAlignment = 2;    // Lawfull
            RaceTraitsSize = RaceSizes.MEDIUM;
            RaceTraitsSpeed = 25;       // feet
            RaceTraitsLanguages = 1;
            // Stout Resilience. You have advantage on saving
            // throws against poison, and you have resistance
            // against poison damage.
        }
    }
}
