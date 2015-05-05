using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseCharacterRaceHighElf : BaseCharacterRace {
        public BaseCharacterRaceHighElf() {

            RaceType = Enums.RaceTypes.HIGHELVES;
            RaceName = CharacterStrings.RaceTypeText[(int)RaceType];
            RaceDescription = CharacterStrings.RaceDescriptionTextHighElves;
            RaceSubrace = 2;
            RaceTraitsAbilityScoreIncrease = new  RaceAbilityScoreIncreaseHighElf();
            RaceTraitsAbilityScoreIncrease.Intelligence = 1;
            RaceTraitsAge = 100.0f;
            RaceTraitsAlignment = 2;    // Lawfull
            RaceTraitsSize = Enums.RaceSizes.MEDIUM;
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
