using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public enum RaceTypes {
        HUMANS,
        HILLDWARVES,
        MOUNTAINDWARVES,
        HIGHELVES,
        WOODELVES,
        LIGHTFOOTHALFLINGS,
        STOUTHALFLINGS
    }
    public enum RaceSizes {
        SMALL,
        MEDIUM
    }

    public class BaseCharacterRace {

        public string RaceName { get; set; }
        public RaceTypes RaceType { get; set; }
        public string RaceDescription { get; set; }
        public int RaceSubrace { get; set; }

        public BaseCharacterAbilities RaceTraitsAbilityScoreIncrease { get; set; }
        public float RaceTraitsAge { get; set; }
        public int RaceTraitsAlignment { get; set; }
        public RaceSizes RaceTraitsSize { get; set; }
        public int RaceTraitsSpeed { get; set; }
        public int RaceTraitsLanguages { get; set; }

        public BaseCharacterRace() { }

    }
}
/*
 * Races:
 * 10 = Humans
 * 20 = Dwarves
 * 30 = Elves
 * 40 = Halflings
Subraces:
 * 
 * 21 = Hill Dwarf
 * 22 = Mountain Dwarf
 * 31 = High Elf
 * 32 = Wood Elf
 * 41 = Lightfoot Halfling
 * 42 = Stout Halfling
*/