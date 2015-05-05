using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseCharacterRace {

        public string RaceName { get; set; }
        public Enums.RaceTypes RaceType { get; set; }
        public string RaceDescription { get; set; }
        public int RaceSubrace { get; set; }
        public BaseCharacterAbilities RaceTraitsAbilityScoreIncrease { get; set; }
        public float RaceTraitsAge { get; set; }
        public int RaceTraitsAlignment { get; set; }
        public Enums.RaceSizes RaceTraitsSize { get; set; }
        public int RaceTraitsSpeed { get; set; }
        public int RaceTraitsLanguages { get; set; }


        public BaseCharacterRace() { }

        public BaseCharacterRace(string raceName, Enums.RaceTypes raceType, string raceDescription, int raceSubRace, BaseCharacterAbilities raceTraitsAbilityScoreIncrease, float raceTraitsAge, int raceTraitsAlignment, Enums.RaceSizes raceTraitsSize, int raceTraitsSpeed, int raceTraitsLanguages) {
            RaceName = raceName;
            RaceType = raceType;
            RaceDescription = raceDescription;
            RaceSubrace = raceSubRace;
            RaceTraitsAbilityScoreIncrease = raceTraitsAbilityScoreIncrease;
            RaceTraitsAge = raceTraitsAge;
            RaceTraitsAlignment = raceTraitsAlignment;
            RaceTraitsSize = raceTraitsSize;
            RaceTraitsSpeed = raceTraitsSpeed;
            RaceTraitsLanguages = raceTraitsLanguages;
        }
    }
}
