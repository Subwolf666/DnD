using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class HighElf : Races {
        public HighElf() {

            Name = RaceTypes.Highelves;
            RaceDescription = StringFunctions.RaceDescriptionTextHighElves;
            RaceTraitsAbilityScoreIncrease = new  RaceAbilityScoreIncreaseHighElf();
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
