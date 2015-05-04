using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseCharacterRaceHighElf : BaseCharacterRace {
        public BaseCharacterRaceHighElf() {

            RaceType = RaceTypes.HIGHELVES;
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
                                "As a high elf, you have a keen mind and a mastery of\n" +
                                "at least the basics of magic. In many of the worlds of\n" +
                                "D&D, there are two kinds of high elves. One type (which\n" +
                                "includes the gray elves and valley elves of Greyhawk,\n" +
                                "the Silvanesti of Dragonlance, and the sun elves of the\n" +
                                "Forgotten Realms) is haughty and reclusive, believing\n" +
                                "themselves to be superior to non-elves and even other\n" +
                                "elves. The other type (including the high elves of\n" +
                                "Greyhawk, the Qualinesti of Dragonlance, and the moon\n" +
                                "elves of the Forgotten Realms) are more common and\n" +
                                "more friendly, and often encountered among humans\n" +
                                "and other races.\n" +
                                "The sun elves of Faerûn (also called gold elves or\n" +
                                "sunrise elves) have bronze skin and hair of copper,\n" +
                                "black, or golden blond. Their eyes are golden, silver, or\n" +
                                "black. Moon elves (also called silver elves or gray elves)\n" +
                                "are much paler, with alabaster skin sometimes tinged\n" +
                                "with blue. They often have hair of silver-white, black,\n" +
                                "or blue, but various shades of blond, brown, and red\n" +
                                "are not uncommon. Their eyes are blue or green and\n" +
                                "flecked with gold.";
            RaceSubrace = 2;
            // Racial Traits
            RaceTraitsAbilityScoreIncrease = new  RaceAbilityScoreIncreaseHighElf();
            RaceTraitsAbilityScoreIncrease.Intelligence = 1;
            RaceTraitsAge = 100.0f;
            RaceTraitsAlignment = 2;    // Lawfull
            RaceTraitsSize = RaceSizes.MEDIUM;
            RaceTraitsSpeed = 30;       // 30 feet
            RaceTraitsLanguages = 2;
            // Elf Weapon Training. You have proficiency with the
            // longsword, shortsword, shortbow, and longbow.
            //
            // Cantrip. You know one cantrip of your choice from
            // the wizard spell list. Intelligence is your spellcasting
            // ability for it.
            //
            // Extra Language. You can speak, read, and write one
            // extra language of your choice.
        }
    }
}
