using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseCharacterRaceWoodElf : BaseCharacterRace {
        public BaseCharacterRaceWoodElf() {

            RaceType = RaceTypes.WOODELVES;
            RaceName = CharacterStrings.RaceTypeNames[(int)RaceType];
            RaceDescription = "With their unearthly grace and fine features, elves\n" +
                                "appear hauntingly beautiful to humans and members\n" +
                                "of many other races. They are slightly shorter than\n" +
                                "humans on average, ranging from well under 5 feet\n" +
                                "tall to just over 6 feet. They are more slender than\n" +
                                "humans, weighing only 100 to 145 pounds. Males and\n" +
                                "females are about the same height, and males are only\n" +
                                "marginally heavier than females.\n" +
                                "Elves’ coloration encompasses the normal human\n" +
                                "range and also includes skin in shades of copper,\n" +
                                "bronze, and almost bluish-white, hair of green or blue,\n" +
                                "and eyes like pools of liquid gold or silver. Elves have no\n" +
                                "facial and little body hair. They favor elegant clothing in\n" +
                                "bright colors, and they enjoy simple yet lovely jewelry.\n" +
                                "\n" +
                                "As a wood elf, you have keen senses and intuition, and\n" +
                                "your fleet feet carry you quickly and stealthily through\n" +
                                "your native forests. This category includes the wild\n" +
                                "elves (grugach) of Greyhawk and the Kagonesti of\n" +
                                "Dragonlance, as well as the races called wood elves in\n" +
                                "Greyhawk and the Forgotten Realms. In Faerûn, wood\n" +
                                "elves (also called wild elves, green elves, or forest elves)\n" +
                                "are reclusive and distrusting of non-elves.\n" +
                                "Wood elves’ skin tends to be copperish in hue,\n" +
                                "sometimes with traces of green. Their hair tends toward\n" +
                                "browns and blacks, but it is occasionally blond or\n" +
                                "copper-colored. Their eyes are green, brown, or hazel.";
            RaceSubrace = 2;
            // Racial Traits
            RaceTraitsAbilityScoreIncrease = new RaceAbilityScoreIncreaseWoodElf();
            RaceTraitsAge = 100.0f;
            RaceTraitsAlignment = 2;    // Lawfull
            RaceTraitsSize = RaceSizes.MEDIUM;
            RaceTraitsSpeed = 35;       // 35 feet
            RaceTraitsLanguages = 1;
            // Elf Weapon Training. You have proficiency with the
            // longsword, shortsword, shortbow, and longbow.
            //
            // Fleet of Foot. Your base walking speed
            // increases to 35 feet.
            //
            // Mask of the Wild. You can attempt to hide even when
            // you are only lightly obscured by foliage, heavy rain,
            // falling snow, mist, and other natural phenomena.
        }
    }
}
