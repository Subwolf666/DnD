using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseCharacterRaceHuman : BaseCharacterRace {
        public BaseCharacterRaceHuman() {

            RaceType = RaceTypes.HUMANS;
            RaceName = CharacterStrings.RaceTypeNames[(int)RaceType];
            RaceDescription = "In the reckonings of most worlds, humans are the\n" +
                                "youngest of the common races, late to arrive on the\n" +
                                "world scene and short-lived in comparison to dwarves,\n" +
                                "elves, and dragons. Perhaps it is because of their\n" +
                                "shorter lives that they strive to achieve as much as\n" +
                                "they can in the years they are given. Or maybe they\n" +
                                "feel they have something to prove to the elder races,\n" +
                                "and that’s why they build their mighty empires on the\n" +
                                "foundation of conquest and trade. Whatever drives them,\n" +
                                "humans are the innovators, the achievers, and the\n" +
                                "pioneers of the worlds.";
            RaceSubrace = 0;
            // Racial Traits
            RaceTraitsAbilityScoreIncrease = new RaceAbilityScoreIncreaseHuman();
            RaceTraitsAge = 17.0f;
            RaceTraitsAlignment = 0;
            RaceTraitsSize = RaceSizes.MEDIUM;
            RaceTraitsSpeed = 30;
            RaceTraitsLanguages = 2;
        }
    }
}

