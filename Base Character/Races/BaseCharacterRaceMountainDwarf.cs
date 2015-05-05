using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseCharacterRaceMountainDwarf : BaseCharacterRace {
        public BaseCharacterRaceMountainDwarf() {

            RaceType = Enums.RaceTypes.MOUNTAINDWARVES;
            RaceName = CharacterStrings.RaceTypeText[(int)RaceType];
            RaceDescription = CharacterStrings.RaceDescriptionTextMountainDwarf;
            RaceSubrace = 2;
            // Racial Traits
            RaceTraitsAbilityScoreIncrease = new RaceAbilityScoreIncreaseMountainDwarf();
            RaceTraitsAge = 50.0f;
            RaceTraitsAlignment = 2;    // Lawfull
            RaceTraitsSize = Enums.RaceSizes.MEDIUM;
            RaceTraitsSpeed = 25;       // 25 feet
            RaceTraitsLanguages = 1;
            // Dwarven Armor Training: you have proficiency with light and medium armor
        }
    }
}
