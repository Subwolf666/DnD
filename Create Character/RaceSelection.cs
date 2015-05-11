using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Character;
using Character_Races;
using Misc;
using Utilities;

namespace CreateCharacter {
    public class RaceSelection {
        public static Races DisplayRaceSelection() {

            ConsoleKeyInfo keyPress; // Creates a variable to hold the user's return response.
            Races characterRace = new Races();
            bool bDontExitLoop = true;

            do {
                Console.Clear();
                Console.WriteLine("Race Selection:");
                Console.WriteLine();
                Console.WriteLine("Choose a Race for your Character:");
                Console.WriteLine();

                for (int i = 0; i < StringFunctions.RaceTypeText.Count - 1; i++) {

                    Console.WriteLine("[" + (i + 1).ToString() + "]" + " - " + StringFunctions.RaceTypeText[i + 1]);
                }
                Console.WriteLine();

                keyPress = Miscellaneous.GetNumberRange(1, StringFunctions.RaceTypeText.Count - 1);
                if (keyPress.Key == ConsoleKey.D1) {
                    characterRace = new Human();
                } else if (keyPress.Key == ConsoleKey.D2) {
                    characterRace = new HillDwarf();
                } else if (keyPress.Key == ConsoleKey.D3) {
                    characterRace = new MountainDwarf();
                } else if (keyPress.Key == ConsoleKey.D4) {
                    characterRace = new HighElf();
                } else if (keyPress.Key == ConsoleKey.D5) {
                    characterRace = new WoodElf();
                } else if (keyPress.Key == ConsoleKey.D6) {
                    characterRace = new LightfootHalfling();
                } else if (keyPress.Key == ConsoleKey.D7) {
                    characterRace = new StoutHalfling();
                }
                bDontExitLoop = false;
            } while (bDontExitLoop);

            return characterRace;
        }
    }
}
//Console.WriteLine("[0] - Exit.");
//Console.WriteLine();
//                Console.Write("Are you sure? [Y/N]: "); // Asks the user to answer with Yes or No.
//                response = misc.GetYOrN();
//                if (response == ConsoleKey.Y) Console.WriteLine("Yes");
//                else if (response == ConsoleKey.N) Console.WriteLine("No");
//                if (response == ConsoleKey.Y) {
//if (keyPress.Key == ConsoleKey.D0) {
//    characterRace.Name = RaceTypes.Invalid;   // return an invalid race
//} else 
