using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseCharacterRaceMountainDwarf : BaseCharacterRace {
        public BaseCharacterRaceMountainDwarf() {

            RaceType = RaceTypes.MOUNTAINDWARVES;
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
                                "As a mountain dwarf, you’re strong and hardy,\n" +
                                "accustomed to a difficult life in rugged terrain. You’re\n" +
                                "probably on the tall side (for a dwarf), and tend toward\n" +
                                "lighter coloration. The shield dwarves of northern\n" +
                                "Faerûn, as well as the ruling Hylar clan and the noble\n" +
                                "Daewar clan of Dragonlance, are mountain dwarves.";
            RaceSubrace = 2;
            // Racial Traits
            RaceTraitsAbilityScoreIncrease = new RaceAbilityScoreIncreaseMountainDwarf();
            RaceTraitsAge = 50.0f;
            RaceTraitsAlignment = 2;    // Lawfull
            RaceTraitsSize = RaceSizes.MEDIUM;
            RaceTraitsSpeed = 25;       // 25 feet
            RaceTraitsLanguages = 1;
            // Dwarven Armor Training: you have proficiency with light and medium armor
        }
    }
}
