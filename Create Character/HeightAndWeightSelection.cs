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
        public static BaseHeightAndWeight DisplayHeightAndWeightSelection(Races characterRace) {

            ConsoleKeyInfo keyPress; // Creates a variable to hold the user's return response.
            bool bDontExitLoop = true;
            int heightAndWeightModifier = 0;

            BaseHeightAndWeight currentHeightAndWeight, BaseHeightAndWeight;
            currentHeightAndWeight = GetHeightAndWeightForSelectedRace(characterRace.Name);
            BaseHeightAndWeight = GetHeightAndWeightForSelectedRace(characterRace.Name);

// Display Height Selection
            do {
                Console.Clear();
                Console.WriteLine("Race Height Selection:");
                Console.WriteLine();
                Console.WriteLine("Race: " + StringFunctions.RaceTypeText[(int)characterRace.Name]);
                Console.WriteLine("==========================================");
                Console.WriteLine("Base Height: " + BaseHeightAndWeight.HeightFeet + "\'" + BaseHeightAndWeight.HeightInches + "\"");
                Console.WriteLine("Height Modifier: " + BaseHeightAndWeight.HeightModifier + " (Inches)");
                Console.WriteLine();
                Console.WriteLine("Current Height: " + currentHeightAndWeight.HeightFeet + "\'" + currentHeightAndWeight.HeightInches + "\"");
                Console.WriteLine();
                Console.WriteLine("[R]eroll Height Modifier.");
                Console.WriteLine("[S]ave Current Height and Exit.");
                Console.WriteLine();

                keyPress = Console.ReadKey(true);
                if (keyPress.Key == ConsoleKey.R) {
                    // roll the Height Modifier Dice and add to height
                    heightAndWeightModifier = Dice.Roll(BaseHeightAndWeight.HeightModifier);
                    currentHeightAndWeight.HeightFeet = BaseHeightAndWeight.HeightFeet;
                    currentHeightAndWeight.HeightInches = BaseHeightAndWeight.HeightInches + heightAndWeightModifier;
                    while (currentHeightAndWeight.HeightInches >= 12) {
                            ++currentHeightAndWeight.HeightFeet;
                            currentHeightAndWeight.HeightInches -= 12;
                    }
                } else if (keyPress.Key == ConsoleKey.S) {
                    bDontExitLoop = false;
                }
            } while (bDontExitLoop);

// Display Weight Selection
            heightAndWeightModifier = 0;
            bDontExitLoop = true;
            do {
                Console.Clear();
                Console.WriteLine("Race Weight Selection:");
                Console.WriteLine();
                Console.WriteLine("Race: " + StringFunctions.RaceTypeText[(int)characterRace.Name]);
                Console.WriteLine("==========================================");
                Console.WriteLine("Base Weight: " + BaseHeightAndWeight.WeightPounds + "lbs");
                Console.WriteLine("Weight Modifier: " + BaseHeightAndWeight.WeightModifier);
                Console.WriteLine();
                Console.WriteLine("Current Weight: " + currentHeightAndWeight.WeightPounds + " lbs");
                Console.WriteLine();
                Console.WriteLine("[R]eroll Weight Modifier.");
                Console.WriteLine("[S]ave Current Height and Exit.");
                Console.WriteLine();

                keyPress = Console.ReadKey(true);
                if (keyPress.Key == ConsoleKey.R) {
                    // roll the Weight Modifier dice and add to weight
                    heightAndWeightModifier = Dice.Roll(BaseHeightAndWeight.WeightModifier);
                    currentHeightAndWeight.WeightPounds = BaseHeightAndWeight.WeightPounds + heightAndWeightModifier;
                } else if (keyPress.Key == ConsoleKey.S) {
                    bDontExitLoop = false;
                }
            } while (bDontExitLoop);

            return currentHeightAndWeight;
        }

        private static BaseHeightAndWeight GetHeightAndWeightForSelectedRace(Base_Character.RaceTypes raceType ) {
            BaseHeightAndWeight temp;
            if (raceType == Base_Character.RaceTypes.Humans) {
                temp = new BaseHeightAndWeightHuman();
            } else if (raceType == Base_Character.RaceTypes.Hilldwarves) {
                temp = new BaseHeightAndWeightHillDwarf();
            } else if (raceType == Base_Character.RaceTypes.Mountaindwarves) {
                temp = new BaseHeightAndWeightMountainDwarf();
            } else if (raceType == Base_Character.RaceTypes.Highelves) {
                temp = new BaseHeightAndWeightHighElf();
            } else if (raceType == Base_Character.RaceTypes.Woodelves) {
                temp = new BaseHeightAndWeightWoodElf();
            } else if (raceType == Base_Character.RaceTypes.Lightfoothalflings) {
                temp = new BaseHeightAndWeightLightfootHalfling();
            } else if (raceType == Base_Character.RaceTypes.Stouthalflings) {
                temp = new BaseHeightAndWeightStoutHalfling();
            } else {
                temp = new BaseHeightAndWeightHuman();
            }

            return temp;
        }
    }
}
