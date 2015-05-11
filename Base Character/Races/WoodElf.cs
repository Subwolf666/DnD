using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class WoodElf : Races {
        public WoodElf() {

            Name = RaceTypes.Woodelves;
            RaceDescription = StringFunctions.RaceDescriptionTextWoodElf;
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
