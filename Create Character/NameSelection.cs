using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Character;
using Misc;

namespace CreateCharacter {
    public class NameSelection {
        public static string DisplayNameSelection() {
            bool bDontExitLoop = true;
            string name = string.Empty;

            do {
                Console.Clear();
                Console.WriteLine("Name Selection:");
                Console.WriteLine();
                Console.WriteLine("Choose a Name for your Character:");
                Console.WriteLine();

                Console.Write("Name: ");
                Console.TreatControlCAsInput = false; // Error in Console subsystems from microsoft.
                name = Console.ReadLine();
                Console.TreatControlCAsInput = true;

                // check if the name is within the rules: only char and not numbers or spaces
                bDontExitLoop = !CharacterDetailsFunctions.ValidateCharacterName(name);
            } while (bDontExitLoop);

            return name;
        }
    }
}
