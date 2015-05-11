using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class Abilities {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public Abilities() { }

        public Abilities(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) {
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        public int[] AbilitiesToInt() {
            int[] to_return = new int[] { Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma };
            return to_return;
        }

        public void Add(Abilities abilities2) {
            Strength += abilities2.Strength;
            Dexterity += abilities2.Dexterity;
            Constitution += abilities2.Constitution;
            Intelligence += abilities2.Intelligence;
            Wisdom += abilities2.Wisdom;
            Charisma += abilities2.Charisma;
        }
    }
}
