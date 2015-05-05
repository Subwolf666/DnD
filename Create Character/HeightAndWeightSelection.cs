using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Character;
using Misc;
using Utilities;

namespace CreateCharacter {
    public class HeightAndWeightSelection : BaseHeightAndWeight {
        public BaseHeightAndWeight DisplayHeightAndWeightSelection(BaseCharacterRace characterRace) {

            ConsoleKeyInfo keyPress; // Creates a variable to hold the user's return response.
            Console.TreatControlCAsInput = true;    // Prevent program from ending if CTL+C is pressed.
            bool bDontExitLoop = true;
            int heightAndWeightModifier = 0;

            BaseHeightAndWeight currentHeightAndWeight, HeightAndWeight;
            currentHeightAndWeight = GetHeightAndWeightForSelectedRace(characterRace);
            HeightAndWeight = GetHeightAndWeightForSelectedRace(characterRace);

            do {
                Console.Clear();
                Console.WriteLine("Race Height Selection:");
                Console.WriteLine();
                Console.WriteLine("Race: " + characterRace.RaceName);
                Console.WriteLine("==========================================");
                Console.WriteLine("Base Height: " + HeightAndWeight.HeightFeet + "\'" + HeightAndWeight.HeightInches + "\"");
                Console.WriteLine("Height Modifier: " + HeightAndWeight.HeightModifier + " (Inches)");
                Console.WriteLine();
                Console.WriteLine("Current Height: " + currentHeightAndWeight.HeightFeet + "\'" + currentHeightAndWeight.HeightInches + "\"");
                Console.WriteLine();
                Console.WriteLine("[R]eroll Height Modifier.");
                Console.WriteLine("[S]ave Current Height and Exit.");
                Console.WriteLine("[0] - Exit");
                Console.WriteLine();

                keyPress = Console.ReadKey(true);
                if (keyPress.Key == ConsoleKey.D0) {
                    currentHeightAndWeight = null;
                    bDontExitLoop = false;
                } else if (keyPress.Key == ConsoleKey.R) {
                    // roll the dice and add to height
                    heightAndWeightModifier = Dice.Roll(HeightAndWeight.HeightModifier);
                    Console.WriteLine();
                    Console.WriteLine("Answer: " + heightAndWeightModifier.ToString() + "\"");
                    currentHeightAndWeight.HeightFeet = HeightAndWeight.HeightFeet;
                    currentHeightAndWeight.HeightInches = HeightAndWeight.HeightInches + heightAndWeightModifier;
                    if (currentHeightAndWeight.HeightInches >= 12) {
                        ++currentHeightAndWeight.HeightFeet;
                        currentHeightAndWeight.HeightInches -= 12;
                    }
                } else if (keyPress.Key == ConsoleKey.S) {
                    bDontExitLoop = false;
                }
            } while (bDontExitLoop);

            heightAndWeightModifier = 0;
            bDontExitLoop = true;
            if (keyPress.Key != ConsoleKey.D0) {
                do {
                    Console.Clear();
                    Console.WriteLine("Race Weight Selection:");
                    Console.WriteLine();
                    Console.WriteLine("Race: " + characterRace.RaceName);
                    Console.WriteLine("==========================================");
                    // Display the Adjust Weight modifiers
                    Console.WriteLine("Base Weight: " + HeightAndWeight.WeightPounds + "lbs");
                    Console.WriteLine("Weight Modifier: " + HeightAndWeight.WeightModifier);
                    Console.WriteLine();
                    Console.WriteLine("Current Weight: " + currentHeightAndWeight.WeightPounds + " lbs");
                    Console.WriteLine();
                    Console.WriteLine("[R]eroll Weight Modifier.");
                    Console.WriteLine("[S]ave Current Height and Exit.");
                    Console.WriteLine("[0] - Exit");
                    Console.WriteLine();

                    keyPress = Console.ReadKey(true);
                    if (keyPress.Key == ConsoleKey.D0) {
                        currentHeightAndWeight = null;
                        bDontExitLoop = false;
                    } else if (keyPress.Key == ConsoleKey.R) {
                        // roll the dice and add to weight
                        heightAndWeightModifier = Dice.Roll(HeightAndWeight.WeightModifier);
                        currentHeightAndWeight.WeightPounds = HeightAndWeight.WeightPounds + heightAndWeightModifier;
                        Console.WriteLine();
                        Console.WriteLine("Answer: " + heightAndWeightModifier.ToString() + " lbs");
                    } else if (keyPress.Key == ConsoleKey.S) {
                        bDontExitLoop = false;
                    }
                } while (bDontExitLoop);
            }

            return currentHeightAndWeight;
        }

        public BaseHeightAndWeight GetHeightAndWeightForSelectedRace(BaseCharacterRace characterRace) {
            BaseHeightAndWeight temp;
            if (characterRace.RaceType == Enums.RaceTypes.HUMANS) {
                temp = new BaseHeightAndWeightHuman();
            } else if (characterRace.RaceType == Enums.RaceTypes.HILLDWARVES) {
                temp = new BaseHeightAndWeightHillDwarf();
            } else if (characterRace.RaceType == Enums.RaceTypes.MOUNTAINDWARVES) {
                temp = new BaseHeightAndWeightMountainDwarf();
            } else if (characterRace.RaceType == Enums.RaceTypes.HIGHELVES) {
                temp = new BaseHeightAndWeightHighElf();
            } else if (characterRace.RaceType == Enums.RaceTypes.WOODELVES) {
                temp = new BaseHeightAndWeightWoodElf();
            } else if (characterRace.RaceType == Enums.RaceTypes.LIGHTFOOTHALFLINGS) {
                temp = new BaseHeightAndWeightLightfootHalfling();
            } else if (characterRace.RaceType == Enums.RaceTypes.STOUTHALFLINGS) {
                temp = new BaseHeightAndWeightStoutHalfling();
            } else {
                temp = new BaseHeightAndWeightHuman();
            }

            return temp;
        }
    }
}
