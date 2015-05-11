using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class LightfootHalfling : Races {
        public LightfootHalfling() {

            Name = RaceTypes.Lightfoothalflings;
            RaceDescription = StringFunctions.RaceDescriptionTextLightfootHalfling;
            RaceTraitsAbilityScoreIncrease = new RaceAbilityScoreIncreaseLightfootHalfling();
            RaceTraitsAge = 18.0f;
            RaceTraitsAlignment = 2;    // Lawfull
            RaceTraitsSize = RaceSizes.SMALL;
            RaceTraitsSpeed = 25;       // feet
            RaceTraitsLanguages = 1;
            // Naturally Stealthy. You can attempt to hide even
            // when you are obscured only by a creature that is at least
            // one size larger than you.
        }
    }
}
