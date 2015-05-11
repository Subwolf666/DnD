using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Character;
using Misc;

namespace CreateCharacter {
    public class ClassSelection {
        public static Classes DisplayClassSelection() {

            ConsoleKeyInfo keyPress; // Creates a variable to hold the user's return response.
            bool bDontExitLoop = true;
            Classes characterClass = new Classes();

            do {
                Console.Clear();
                Console.WriteLine("Class Selection:");
                Console.WriteLine();
                Console.WriteLine("Choose a Class for your Character:");
                Console.WriteLine();

                for (int i = 0; i < StringFunctions.ClassTypeText.Count - 1; i++) {
                    Console.WriteLine("[" + (i + 1).ToString() + "]" + " - " + StringFunctions.ClassTypeText[i + 1]);
                }
                Console.WriteLine();

                keyPress = Miscellaneous.GetNumberRange(1, StringFunctions.ClassTypeText.Count - 1);
                    if (keyPress.Key == ConsoleKey.D1) {
                        characterClass = new Cleric();
                    } else if (keyPress.Key == ConsoleKey.D2) {
                        characterClass = new Fighter();
                    } else if (keyPress.Key == ConsoleKey.D3) {
                        characterClass = new Rogue();
                    } else if (keyPress.Key == ConsoleKey.D4) {
                        characterClass = new Wizard();
                    }
                    bDontExitLoop = false;
            } while (bDontExitLoop);

            return characterClass;
        }
    }
}
//Console.WriteLine("[0] - Exit.");
//Console.WriteLine();
//Console.Write("Are you sure? [Y/N]: "); // Asks the user to answer with Yes or No.
//response = misc.GetYOrN();
//if (response == ConsoleKey.Y) Console.WriteLine("Yes");
//else if (response == ConsoleKey.N) Console.WriteLine("No");
//if (response == ConsoleKey.Y) {
//if (keyPress.Key == ConsoleKey.D0) {
//    characterClass = null;  // return an empty class
//} else 
