using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseCharacterRaceHillDwarf : BaseCharacterRace {
        public BaseCharacterRaceHillDwarf() {

            RaceType = Enums.RaceTypes.HILLDWARVES;
            RaceName = CharacterStrings.RaceTypeText[(int)RaceType];
            RaceDescription = CharacterStrings.RaceDescriptionTextHillDwarf;
            RaceSubrace = 2;
            // Racial Traits
            RaceTraitsAbilityScoreIncrease = new RaceAbilityScoreIncreaseHillDwarf();
            RaceTraitsAge = 50.0f;
            RaceTraitsAlignment = 2;    // Lawfull
            RaceTraitsSize = Enums.RaceSizes.MEDIUM;
            RaceTraitsSpeed = 25;       // 25 feet
            RaceTraitsLanguages = 1;
            //Dwarven Toughness. Your hit point maximum increases by 1, and it increases by 1 every time you gain a level.
        }
    }
}
