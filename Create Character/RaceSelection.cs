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
        public BaseCharacterRace DisplayRaceSelection() {

            ConsoleKey response; // Creates a variable to hold the user's return response.
            ConsoleKeyInfo keyPress; // Creates a variable to hold the user's return response.
            Console.TreatControlCAsInput = true;    // Prevent program from ending if CTL+C is pressed.
            bool bDontExitLoop = true;
            
            BaseCharacterRace characterRace = new BaseCharacterRace();
            Misc.Miscellaneous misc = new Misc.Miscellaneous();

            do {
                Console.Clear();
                Console.WriteLine("Race Selection:");
                Console.WriteLine();
                Console.WriteLine("Choose a Race for your Character:");
                Console.WriteLine();

                for (int i = 0; i < CharacterStrings.RaceTypeNames.Count; i++) { // Display the different races

                    Console.WriteLine("[" + (i + 1).ToString() + "]" + " - " + CharacterStrings.RaceTypeNames[i]);
                }
                Console.WriteLine();
                Console.WriteLine("[0] - Exit.");
                Console.WriteLine();

                keyPress = misc.GetNumberRange(0, CharacterStrings.RaceTypeNames.Count);
                Console.Write("Are you sure? [Y/N]: "); // Asks the user to answer with Yes or No.
                response = misc.GetYOrN();
                if (response == ConsoleKey.Y) Console.WriteLine("Yes");
                else if (response == ConsoleKey.N) Console.WriteLine("No");
                if (response == ConsoleKey.Y) {
                    if (keyPress.Key == ConsoleKey.D0) {
                        characterRace = null;   // return an empty race
                    } else if (keyPress.Key == ConsoleKey.D1) {
                        characterRace = new BaseCharacterRaceHuman();
                    } else if (keyPress.Key == ConsoleKey.D2) {
                        characterRace = new BaseCharacterRaceHillDwarf();
                    } else if (keyPress.Key == ConsoleKey.D3) {
                        characterRace = new BaseCharacterRaceMountainDwarf();
                    } else if (keyPress.Key == ConsoleKey.D4) {
                        characterRace = new BaseCharacterRaceHighElf();
                    } else if (keyPress.Key == ConsoleKey.D5) {
                        characterRace = new BaseCharacterRaceWoodElf();
                    } else if (keyPress.Key == ConsoleKey.D6) {
                        characterRace = new BaseCharacterRaceLightfootHalfling();
                    } else if (keyPress.Key == ConsoleKey.D7) {
                        characterRace = new BaseCharacterRaceStoutHalfling();
                    }
                    bDontExitLoop = false;
                }
            } while (bDontExitLoop);

            return characterRace;
        }
    }
}