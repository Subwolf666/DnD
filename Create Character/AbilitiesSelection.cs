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
        private int[] CharacterAbilityScores = new int[6] {
            0, 0, 0, 0, 0, 0
        };
        private int[] RacialAbilityScores = new int[6] {
            0, 0, 0, 0, 0, 0
        };

        public BaseCharacterAbilities DisplayAbilitiesSelection(BaseCharacterSheet character) {

            ConsoleKeyInfo keyPress; // Creates a variable to hold the user's return response.
            //Console.TreatControlCAsInput = true;    // Prevent program from ending if CTL+C is pressed.
            bool bDontExitLoop = true;
            //int heightAndWeightModifier = 0;

            BaseCharacterAbilities Abilities = new BaseCharacterAbilities();
            BaseCharacterAbilities currentAbilityScore;
            //BaseAbilities racialAbilitiesIncrease;

            Abilities = currentAbilityScore = GetBaseAbilityScoresForSelectedClass(character.CharacterClass);

            CreateAbilitiesScoreArray(Abilities); // nodig om de ability modifiers te maken
            CreateRacialAbilitiesArray(character.CharacterRace.RaceTraitsAbilityScoreIncrease);

            do {
                Console.Clear();
                Console.WriteLine("Class Abilities Selection:");
                Console.WriteLine();
                Console.WriteLine("Race: " + character.CharacterRace.RaceName);
                Console.WriteLine("Class: " + character.CharacterClass.ClassName);
                Console.WriteLine("==========================================");
                // Display the different Abilities
                Console.WriteLine("[#] - Ability: BaseAbility + RacialAbility + (AbilityModifier)");
                for (int i = 0; i < CharacterStrings.AbilityNames.Count; i++) {
                    Console.Write("[" + (i + 1).ToString() + "] -");
                    Console.Write("{0,13}:", CharacterStrings.AbilityNames[i]);
                    Console.Write("{0,3} + ", CharacterAbilityScores[i].ToString());
                    Console.Write("{0,1} ", RacialAbilityScores[i].ToString());
                    Console.WriteLine("({0,2})", AbilityScoresAndModifiers.DetermineAbilityScoreAndModifier((CharacterAbilityScores[i] + RacialAbilityScores[i])).ToString());
                }
                Console.WriteLine();
                Console.WriteLine("[R]eroll Ability Score. (NOT IMPLEMENTED YET)");
                Console.WriteLine("[S]ave Current Height and Exit.");
                Console.WriteLine("[0] - Exit");
                Console.WriteLine();
                
                keyPress = Console.ReadKey(true);
                if (keyPress.Key == ConsoleKey.D0) {
                    currentAbilityScore = null;
                    bDontExitLoop = false;
                } else if (keyPress.Key == ConsoleKey.R) {
                    // roll the dice and add to height
                    //heightAndWeightModifier = Dice.Roll(HeightAndWeight.BaseHeightModifier);
                    //Console.WriteLine();
                    //Console.WriteLine("Answer: " + heightAndWeightModifier.ToString() + "\"");
                    //currentHeightAndWeight.BaseHeightFeet = HeightAndWeight.BaseHeightFeet;
                    //currentHeightAndWeight.BaseHeightInches = HeightAndWeight.BaseHeightInches + heightAndWeightModifier;
                    //if (currentHeightAndWeight.BaseHeightInches > 12) {
                    //    ++currentHeightAndWeight.BaseHeightFeet;
                    //    currentHeightAndWeight.BaseHeightInches -= 12;
                    //}
                } else if (keyPress.Key == ConsoleKey.S) {
                    currentAbilityScore.Strength = CharacterAbilityScores[0] + RacialAbilityScores[0];
                    currentAbilityScore.Dexterity = CharacterAbilityScores[1] + RacialAbilityScores[1];
                    currentAbilityScore.Constitution = CharacterAbilityScores[2] + RacialAbilityScores[2];
                    currentAbilityScore.Intelligence = CharacterAbilityScores[3] + RacialAbilityScores[3];
                    currentAbilityScore.Wisdom = CharacterAbilityScores[4] + RacialAbilityScores[4];
                    currentAbilityScore.Charisma = CharacterAbilityScores[5] + RacialAbilityScores[5];
                    bDontExitLoop = false;
                }
            } while (bDontExitLoop);

            return currentAbilityScore;
        }

        public BaseCharacterAbilities GetBaseAbilityModifiersForselectedClass(BaseCharacterAbilities AbilityScores) {
            BaseCharacterAbilities AbilityModifier = new BaseCharacterAbilities();

            if (AbilityScores != null) {
                CreateAbilitiesScoreArray(AbilityScores);
                AbilityModifier.Strength = AbilityScoresAndModifiers.DetermineAbilityScoreAndModifier(AbilityScores.Strength);
                AbilityModifier.Dexterity = AbilityScoresAndModifiers.DetermineAbilityScoreAndModifier(AbilityScores.Dexterity);
                AbilityModifier.Constitution = AbilityScoresAndModifiers.DetermineAbilityScoreAndModifier(AbilityScores.Constitution);
                AbilityModifier.Intelligence = AbilityScoresAndModifiers.DetermineAbilityScoreAndModifier(AbilityScores.Intelligence);
                AbilityModifier.Wisdom = AbilityScoresAndModifiers.DetermineAbilityScoreAndModifier(AbilityScores.Wisdom);
                AbilityModifier.Charisma = AbilityScoresAndModifiers.DetermineAbilityScoreAndModifier(AbilityScores.Charisma);
            } else {
                AbilityModifier = null;
            }

            return AbilityModifier;
        }

        private BaseCharacterAbilities GetBaseAbilityScoresForSelectedClass(BaseCharacterClass characterClass) {
            BaseCharacterAbilities temp;
            if (characterClass.ClassType == Enums.ClassTypes.FIGHTER) {
                temp = new BaseCharacterAbilitiesFighter();
            } else if (characterClass.ClassType == Enums.ClassTypes.CLERIC) {
                temp = new BaseCharacterAbilitiesCleric();
            } else if (characterClass.ClassType == Enums.ClassTypes.ROGUE) {
                temp = new BaseCharacterAbilitiesRogue();
            } else if (characterClass.ClassType == Enums.ClassTypes.WIZARD) {
                temp = new BaseCharacterAbilitiesWizard();
            } else {
                temp = new BaseCharacterAbilitiesFighter();
            }

            return temp;
        }

        private void CreateAbilitiesScoreArray(BaseCharacterAbilities Abilities) {
            CharacterAbilityScores[0] = Abilities.Strength;
            CharacterAbilityScores[1] = Abilities.Dexterity;
            CharacterAbilityScores[2] = Abilities.Constitution;
            CharacterAbilityScores[3] = Abilities.Intelligence;
            CharacterAbilityScores[4] = Abilities.Wisdom;
            CharacterAbilityScores[5] = Abilities.Charisma;
        }
        
        private void CreateRacialAbilitiesArray(BaseCharacterAbilities Abilities) {
            RacialAbilityScores[0] = Abilities.Strength;
            RacialAbilityScores[1] = Abilities.Dexterity;
            RacialAbilityScores[2] = Abilities.Constitution;
            RacialAbilityScores[3] = Abilities.Intelligence;
            RacialAbilityScores[4] = Abilities.Wisdom;
            RacialAbilityScores[5] = Abilities.Charisma;
        }
    }
}