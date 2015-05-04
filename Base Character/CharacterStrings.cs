using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public static class CharacterStrings {

        public static readonly ReadOnlyCollection<string> RaceSexNames = new ReadOnlyCollection<string>(
            new string[] {
                "Female",
                "Male"
            }
        );

        public static readonly ReadOnlyCollection<string> RaceTypeNames = new ReadOnlyCollection<string>(
            new string[] {
                "Humans",
                "Hill Dwarves",
                "Mountain Dwarves",
                "High Elves",
                "Wood Elves",
                "Lightfoot Halflings",
                "Stout Halflings"
            }
        );

        public static readonly ReadOnlyCollection<string> ClassTypeNames = new ReadOnlyCollection<string>(
            new string[] {
                "Cleric",
                "Fighter",
                "Rogue",
                "Wizard"
            }
        );

        public static readonly ReadOnlyCollection<string> AbilityNames = new ReadOnlyCollection<string>(
            new string[] {
                "Strength",
                "Dexterity",
                "Constitution",
                "Intelligence",
                "Wisdom",
                "Charisma",
            }
        );

        public static readonly ReadOnlyCollection<string> AbilityShortNames = new ReadOnlyCollection<string>(
            new string[] {
                "STR",
                "DEX",
                "CON",
                "INT",
                "WIS",
                "CHA",
            }
        );

        public static readonly ReadOnlyCollection<string> AbilityMeasure = new ReadOnlyCollection<string>(
            new string[] {
                "Natural athleticism, bodily power",
                "Physical agility, reflexes, balance, poise",
                "Health, stamina, vital force",
                "Mental acuity, information recall, analytical skill",
                "Awareness, intuition, insight",
                "Confidence, eloquence, leadership"
            }
        );

        public static readonly ReadOnlyCollection<string> AbilityImportance = new ReadOnlyCollection<string>(
            new string[] {
                "Fighter",
                "Rogue",
                "Everyone",
                "Wizard",
                "Cleric",
                "Leaders and diplomatic characters"
            }
        );
    }
}
        //public static readonly ReadOnlyCollection<string> abilityImportance = new ReadOnlyCollection<string>(
        //    new string[] {
        //    }
        //);
