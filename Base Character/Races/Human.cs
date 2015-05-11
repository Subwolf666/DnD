using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class Human : Races {
        public Human() {

            Name = Base_Character.RaceTypes.Humans;
            RaceDescription = StringFunctions.RaceDescriptionTextHuman;
            RaceTraitsAbilityScoreIncrease = new RaceAbilityScoreIncreaseHuman();
            RaceTraitsAge = 17.0f;
            RaceTraitsAlignment = 0;
            RaceTraitsSize = Base_Character.RaceSizes.MEDIUM;
            RaceTraitsSpeed = 30;
            RaceTraitsLanguages = 2;
        }
    }
}

