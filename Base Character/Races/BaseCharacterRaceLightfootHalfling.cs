using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseCharacterRaceLightfootHalfling : BaseCharacterRace {
        public BaseCharacterRaceLightfootHalfling() {

            RaceType = Enums.RaceTypes.LIGHTFOOTHALFLINGS;
            RaceName = CharacterStrings.RaceTypeText[(int)RaceType];
            RaceDescription = CharacterStrings.RaceDescriptionTextLightfootHalfling;
            RaceSubrace = 2;
            // Racial Traits
            RaceTraitsAbilityScoreIncrease = new RaceAbilityScoreIncreaseLightfootHalfling();
            RaceTraitsAge = 18.0f;
            RaceTraitsAlignment = 2;    // Lawfull
            RaceTraitsSize = Enums.RaceSizes.SMALL;
            RaceTraitsSpeed = 25;       // feet
            RaceTraitsLanguages = 1;
            // Naturally Stealthy. You can attempt to hide even
            // when you are obscured only by a creature that is at least
            // one size larger than you.
        }
    }
}
