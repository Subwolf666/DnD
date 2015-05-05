using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Character;
using Misc;

namespace CreateCharacter {
    public class SexSelection {
        public string DisplaySexSelection() {
            ConsoleKeyInfo keyPress; // Creates a variable to hold the user's return response.
            ConsoleKey response; // Creates a variable to hold the user's return response.
            Console.TreatControlCAsInput = true;    // Prevent program from ending if CTL+C is pressed.
            bool bDontExitLoop = true;
            string sex = string.Empty;
            Misc.Miscellaneous misc = new Misc.Miscellaneous();

            do {
                Console.Clear();
                Console.WriteLine("Sex Selection:");
                Console.WriteLine();
                Console.WriteLine("Choose your Character Sex:");
                Console.WriteLine();

                for (int i = 0; i < CharacterStrings.RaceSexText.Count; i++) { // Display the different sexes

                    Console.WriteLine("[" + (i + 1).ToString() + "]" + " - " + CharacterStrings.RaceSexText[i]);
                }
                Console.WriteLine();
                Console.WriteLine("[0] - Exit.");
                Console.WriteLine();
                keyPress = misc.GetNumberRange(0, CharacterStrings.RaceSexText.Count);

                Console.Write("Are you sure? [Y/N]: "); // Asks the user to answer with Yes or No.
                response = misc.GetYOrN();
                if (response == ConsoleKey.Y) {
                    if (keyPress.Key == ConsoleKey.D0) {
                        sex = null;
                    } else if (keyPress.Key == ConsoleKey.D1) sex = CharacterStrings.RaceSexText[0];
                    else if (keyPress.Key == ConsoleKey.D2) sex = CharacterStrings.RaceSexText[1];
                    bDontExitLoop = false;
                }
            } while (bDontExitLoop);

            return sex;
        }
    }
}


