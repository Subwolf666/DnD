using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Stats;

namespace Base_Character {
    public class Races {

        public RaceTypes Name { get; set; }
        public string RaceDescription { get; set; }
        public Abilities RaceTraitsAbilityScoreIncrease { get; set; }
        public float RaceTraitsAge { get; set; }
        public int RaceTraitsAlignment { get; set; }
        public RaceSizes RaceTraitsSize { get; set; }
        public int RaceTraitsSpeed { get; set; }
        public int RaceTraitsLanguages { get; set; }


        public Races() { }

        public Races(RaceTypes raceType, string raceDescription, Abilities raceTraitsAbilityScoreIncrease, float raceTraitsAge, int raceTraitsAlignment, RaceSizes raceTraitsSize, int raceTraitsSpeed, int raceTraitsLanguages) {
            Name = raceType;
            RaceDescription = raceDescription;
            RaceTraitsAbilityScoreIncrease = raceTraitsAbilityScoreIncrease;
            RaceTraitsAge = raceTraitsAge;
            RaceTraitsAlignment = raceTraitsAlignment;
            RaceTraitsSize = raceTraitsSize;
            RaceTraitsSpeed = raceTraitsSpeed;
            RaceTraitsLanguages = raceTraitsLanguages;
        }
    }
}
