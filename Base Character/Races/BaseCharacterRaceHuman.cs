using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseCharacterRaceHuman : BaseCharacterRace {
        public BaseCharacterRaceHuman() {

            RaceType = Enums.RaceTypes.HUMANS;
            RaceName = CharacterStrings.RaceTypeText[(int)RaceType];
            RaceDescription = CharacterStrings.RaceDescriptionTextHuman;
            RaceSubrace = 0;
            // Racial Traits
            RaceTraitsAbilityScoreIncrease = new RaceAbilityScoreIncreaseHuman();
            RaceTraitsAge = 17.0f;
            RaceTraitsAlignment = 0;
            RaceTraitsSize = Enums.RaceSizes.MEDIUM;
            RaceTraitsSpeed = 30;
            RaceTraitsLanguages = 2;
        }
    }
}

