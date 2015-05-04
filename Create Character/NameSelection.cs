using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Character;
using Misc;

namespace CreateCharacter {
    public class NameSelection {
        public string DisplayNameSelection() {
            ConsoleKey response; // Creates a variable to hold the user's return response.
            Console.TreatControlCAsInput = true;    // Prevent program from ending if CTL+C is pressed.
            bool bDontExitLoop = true;
            Misc.Miscellaneous misc = new Misc.Miscellaneous();

            string name;
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
                if (CharacterDetailsFunctions.ValidateCharacterName(name)) {
                    // check if player is ok with name.
                    Console.Write("Are you sure? [Y/N]: "); // Asks the user to answer with Yes or No.
                    response = misc.GetYOrN();
                    if (response == ConsoleKey.Y) {
                        bDontExitLoop = false;
                    }
                }
            } while (bDontExitLoop);

            return name;
        }
    }
}
