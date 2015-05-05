using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Character;
using Misc;

namespace CreateCharacter {
    public class ClassSelection {
        public BaseCharacterClass DisplayClassSelection() {

            ConsoleKeyInfo keyPress; // Creates a variable to hold the user's return response.
            ConsoleKey response; // Creates a variable to hold the user's return response.
            //Console.TreatControlCAsInput = true;    // Prevent program from ending if CTL+C is pressed.
            bool bDontExitLoop = true;

            Misc.Miscellaneous misc = new Misc.Miscellaneous();

            BaseCharacterClass characterClass = new BaseCharacterClass();

            do {
                Console.Clear();
                Console.WriteLine("Class Selection:");
                Console.WriteLine();
                Console.WriteLine("Choose a Class for your Character:");
                Console.WriteLine();

                // Display the different classes

                for (int i = 0; i < CharacterStrings.ClassTypeText.Count; i++) {
                    Console.WriteLine("[" + (i + 1).ToString() + "]" + " - " + CharacterStrings.ClassTypeText[i]);
                }
                Console.WriteLine();
                Console.WriteLine("[0] - Exit.");
                Console.WriteLine();

                keyPress = misc.GetNumberRange(0, CharacterStrings.ClassTypeText.Count);
                Console.Write("Are you sure? [Y/N]: "); // Asks the user to answer with Yes or No.
                response = misc.GetYOrN();
                if (response == ConsoleKey.Y) Console.WriteLine("Yes");
                else if (response == ConsoleKey.N) Console.WriteLine("No");
                if (response == ConsoleKey.Y) {
                    if (keyPress.Key == ConsoleKey.D0) {
                        characterClass = null;  // return an empty class
                    } else if (keyPress.Key == ConsoleKey.D1) {
                        characterClass = new BaseCharacterClassCleric();
                    } else if (keyPress.Key == ConsoleKey.D2) {
                        characterClass = new BaseCharacterClassFighter();
                    } else if (keyPress.Key == ConsoleKey.D3) {
                        characterClass = new BaseCharacterClassRogue();
                    } else if (keyPress.Key == ConsoleKey.D4) {
                        characterClass = new BaseCharacterClassWizard();
                    }
                    bDontExitLoop = false;
                }
            } while (bDontExitLoop);

            return characterClass;
        }
    }
}