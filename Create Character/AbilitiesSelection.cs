using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Character;
using Misc;
using Utilities;

namespace CreateCharacter {
    public class AbilitiesSelection {
        public static Abilities DisplayAbilitiesSelection(Base_Character.ClassTypes classType, Base_Character.Races race) {

            ConsoleKeyInfo keyPress; // Creates a variable to hold the user's return response.
            bool bDontExitLoop = true;

            Abilities currentAbilityScore, baseAbilities;
            currentAbilityScore = baseAbilities = GetBaseAbilityScoresForSelectedClass(classType);
            Abilities racialAbilities = race.RaceTraitsAbilityScoreIncrease;
            
            do {
                Console.Clear();
                Console.WriteLine("Class Abilities Selection:");
                Console.WriteLine();
                Console.WriteLine("Race: " + StringFunctions.RaceTypeText[(int)race.Name]);
                Console.WriteLine("Class: " + StringFunctions.ClassTypeText[(int)classType]);
                Console.WriteLine("==========================================");
                Console.WriteLine("[#] -      Ability: Base + Racial + (Modifier)");
                for (int i = 0; i < StringFunctions.AbilityNames.Count; i++) {
                    Console.Write("[" + (i + 1).ToString() +"] -");
                    Console.Write("{0,13}: ", StringFunctions.AbilityNames[i]);
                    Console.Write("{0,3}  +   ", baseAbilities.AbilitiesToInt()[i].ToString());
                    Console.Write("{0,1}    + ", racialAbilities.AbilitiesToInt()[i].ToString());
                    Console.WriteLine("   ({0,2})", CharacterFormulas.DetermineAbilityModifier(baseAbilities.AbilitiesToInt()[i] + racialAbilities.AbilitiesToInt()[i]).ToString());
                }
                Console.WriteLine();
//                Console.WriteLine("[R]eroll Ability Score. (NOT IMPLEMENTED YET)");
                Console.WriteLine("[S]ave Current Ability Score and Exit.");
                Console.WriteLine();
                
                keyPress = Console.ReadKey(true);
//                if (keyPress.Key == ConsoleKey.R) {
//                } else
                if (keyPress.Key == ConsoleKey.S) {
                    currentAbilityScore.Add(racialAbilities);
                    bDontExitLoop = false;
                }
            } while (bDontExitLoop);
            return currentAbilityScore;
        }

        public static Abilities GetBaseAbilityModifiersForselectedClass(Abilities abilityScores) {
            Abilities AbilityModifier = new Abilities();
            int[] to_return = new int[abilityScores.AbilitiesToInt().Length];
            if (abilityScores != null) {
                to_return = CharacterFormulas.DetermineAbilityModifier(abilityScores.AbilitiesToInt());
                AbilityModifier = new Abilities(to_return[0], to_return[1], to_return[2], to_return[3], to_return[4], to_return[5]);
            } else {
                AbilityModifier = null;
            }

            return AbilityModifier;
        }

        // My choice for now, later on this can be changed into rolling dice or whatever.
        // http://home.earthlink.net/~duanevp/dnd/stat_generation.htm
        private static Abilities GetBaseAbilityScoresForSelectedClass(Base_Character.ClassTypes classType) {
            Abilities temp;
            if (classType == Base_Character.ClassTypes.Fighter) {
                temp = new AbilitiesFighter();
            } else if (classType == Base_Character.ClassTypes.Cleric) {
                temp = new AbilitiesCleric();
            } else if (classType == Base_Character.ClassTypes.Rogue) {
                temp = new AbilitiesRogue();
            } else if (classType == Base_Character.ClassTypes.Wizard) {
                temp = new AbilitiesWizard();
            } else {
                temp = new AbilitiesFighter();
            }

            return temp;
        }
    }
}