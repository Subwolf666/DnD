using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Character;
using Misc;

namespace CreateCharacter {
    public class GenderSelection {
        public static GenderTypes DisplayGenderSelection() {
            ConsoleKeyInfo keyPress; // Creates a variable to hold the user's return response.
            bool bDontExitLoop = true;
            GenderTypes gender = GenderTypes.Invalid;

            do {
                Console.Clear();
                Console.WriteLine("Gender Selection:");
                Console.WriteLine();
                Console.WriteLine("Choose your Character Sex:");
                Console.WriteLine();

                for (int i = 0; i < StringFunctions.RaceGenderText.Count - 1; i++) { // Display the different sexes

                    Console.WriteLine("[" + (i + 1).ToString() + "]" + " - " + StringFunctions.RaceGenderText[i + 1]);
                }
                Console.WriteLine();
                keyPress = Miscellaneous.GetNumberRange(1, StringFunctions.RaceGenderText.Count - 1);
                if (keyPress.Key == ConsoleKey.D1) gender = GenderTypes.Female;
                else if (keyPress.Key == ConsoleKey.D2) gender = GenderTypes.Male;
                else gender = GenderTypes.Invalid;
                bDontExitLoop = false;
            } while (bDontExitLoop);

            return gender;
        }
    }
}


