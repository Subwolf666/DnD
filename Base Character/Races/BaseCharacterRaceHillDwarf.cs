using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseCharacterRaceHillDwarf : BaseCharacterRace {
        public BaseCharacterRaceHillDwarf() {

            RaceType = RaceTypes.HILLDWARVES;
            RaceName = CharacterStrings.RaceTypeNames[(int)RaceType];
            RaceDescription = "Bold and hardy, dwarves are known as skilled warriors,\n" +
                                "miners, and workers of stone and metal. Though they\n" +
                                "stand well under 5 feet tall, dwarves are so broad and\n" +
                                "compact that they can weigh as much as a human standing\n" +
                                "nearly two feet taller. Their courage and endurance are\n" +
                                "also easily a match for any of the larger folk.\n" +
                                "Dwarven skin ranges from deep brown to a paler\n" +
                                "hue tinged with red, but the most common shades are\n" +
                                "light brown or deep tan, like certain tones of earth.\n" +
                                "Their hair, worn long but in simple styles, is usually\n" +
                                "black, gray, or brown, though paler dwarves often have\n" +
                                "red hair. Male dwarves value their beards highly and\n" +
                                "groom them carefully\n" +
                                "\n" +
                                "As a hill dwarf, you have keen senses, deep intuition,\n" +
                                "and remarkable resilience. The gold dwarves of Faerûn\n" +
                                "in their mighty southern kingdom are hill dwarves, as\n" +
                                "are the exiled Neidar and the debased Klar of Krynn in\n" +
                                "the Dragonlance setting.";
            RaceSubrace = 2;
            // Racial Traits
            RaceTraitsAbilityScoreIncrease = new RaceAbilityScoreIncreaseHillDwarf();
            RaceTraitsAge = 50.0f;
            RaceTraitsAlignment = 2;    // Lawfull
            RaceTraitsSize = RaceSizes.MEDIUM;
            RaceTraitsSpeed = 25;       // 25 feet
            RaceTraitsLanguages = 1;
            //Dwarven Toughness. Your hit point maximum increases by 1, and it increases by 1 every time you gain a level.
        }
    }
}
