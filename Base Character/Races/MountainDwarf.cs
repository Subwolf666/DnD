using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class MountainDwarf : Races {
        public MountainDwarf() {

            Name = RaceTypes.Mountaindwarves;
            RaceDescription = StringFunctions.RaceDescriptionTextMountainDwarf;
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
