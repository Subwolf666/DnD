using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Character;
using Base_Equipment;

namespace CreateCharacter {
    public class CreateNewCharacter : BaseCharacterSheet {
        private enum createCharacterStates {
            CHOOSERACE,
            CHOOSECLASS,
            CHOOSEHEIGHTANDWEIGHT,
            CHOOSEABILITIES,
            CALCULATEMAXIMUMHITPOINTS,
            CHOOSENAME,
            CHOOSESEX,                        
            MONEY,
            EQUIPINGARMORANDWEAPONS,
            DONE
        }

        public BaseCharacterSheet CreateANewCharacter() {

            bool bDontExitLoop = true;
            bool bExit = false;
            ClassSelection displayClass = new ClassSelection();
            RaceSelection displayRace = new RaceSelection();
            HeightAndWeightSelection displayHeightAndWeight = new HeightAndWeightSelection();
            AbilitiesSelection displayAbilities = new AbilitiesSelection();
            NameSelection displayName = new NameSelection();
            SexSelection displaySex = new SexSelection();
            BaseCharacterSheet baseCharacter = new BaseCharacterSheet();
            CharacterFormulas characterFormulas = new CharacterFormulas();
            Wealth wealthInCP = new Wealth();   // 100 cp = 1 gp

            createCharacterStates currentState = createCharacterStates.CHOOSERACE;
            createCharacterStates nextState = createCharacterStates.DONE;

            Console.TreatControlCAsInput = true;        // Prevent program from ending if CTL+C is pressed.
            do {
                switch (currentState) {
                    case createCharacterStates.CHOOSERACE:
                        baseCharacter.CharacterRace = displayRace.DisplayRaceSelection();
                        if (baseCharacter.CharacterRace == null) {
                            bExit = true;
                        }
                        nextState = createCharacterStates.CHOOSECLASS;
                        break;
                    case createCharacterStates.CHOOSECLASS:
                        baseCharacter.CharacterClass = displayClass.DisplayClassSelection();
                        if (baseCharacter.CharacterClass == null) {
                            bExit = true;
                        }
                        baseCharacter.CharacterProficiencyBonus = baseCharacter.CharacterClass.ProficiencyClassBonus[0].ProficiencyBonus; // First level character always has PB = 2. 
                        nextState = createCharacterStates.CHOOSEHEIGHTANDWEIGHT;
                        break;
                    case createCharacterStates.CHOOSEHEIGHTANDWEIGHT:
                        //baseCharacter.CharacterBaseHeightAndWeight = displayHeightAndWeight.GetHeightAndWeightForSelectedRace(baseCharacter.CharacterRace);
                        baseCharacter.CharacterHeightAndWeight = displayHeightAndWeight.DisplayHeightAndWeightSelection(baseCharacter.CharacterRace);
                        if (baseCharacter.CharacterHeightAndWeight == null) {
                            bExit = true;
                        }
                        nextState = createCharacterStates.CHOOSEABILITIES;
                        break;
                    case createCharacterStates.CHOOSEABILITIES:
                        baseCharacter.CharacterAbilityScores = displayAbilities.DisplayAbilitiesSelection(baseCharacter);
                        baseCharacter.CharacterAbilityModifiers = displayAbilities.GetBaseAbilityModifiersForselectedClass(baseCharacter.CharacterAbilityScores);
                        if (baseCharacter.CharacterAbilityScores == null) {
                            bExit = true;
                        }
                        nextState = createCharacterStates.CALCULATEMAXIMUMHITPOINTS;
                        break;
                    case createCharacterStates.CALCULATEMAXIMUMHITPOINTS:
                        baseCharacter.CharacterMaximumHitPoints = characterFormulas.CalcMaximumHitPoints(baseCharacter);
                        baseCharacter.CharacterCurrentHitPoints = baseCharacter.CharacterMaximumHitPoints;
                        nextState = createCharacterStates.CHOOSENAME;
                        break;
                    case createCharacterStates.CHOOSENAME:
                        baseCharacter.CharacterName = displayName.DisplayNameSelection();
                        if (baseCharacter.CharacterName == null) {
                            bExit = true;
                        }
                        nextState = createCharacterStates.CHOOSESEX;
                        break;
                    case createCharacterStates.CHOOSESEX:
                        baseCharacter.CharacterSex = displaySex.DisplaySexSelection();
                        if (baseCharacter.CharacterSex == null) {
                            bExit = true;
                        }
                        nextState = createCharacterStates.MONEY;
                        break;
                    case createCharacterStates.MONEY:    // Base Equipment
                        baseCharacter.CharacterGold = wealthInCP.StartingWealthClass(baseCharacter.CharacterClass.ClassType);
                        nextState = createCharacterStates.EQUIPINGARMORANDWEAPONS;
                        break;
                    case createCharacterStates.EQUIPINGARMORANDWEAPONS:
                        var kut = new Equiped();
                        baseCharacter.CharacterEquipedArmorNWeapons = kut.EquipWeaponsAndArmor(baseCharacter.CharacterClass);
                        nextState = createCharacterStates.DONE;
                        break;
                    case createCharacterStates.DONE:
                        baseCharacter.CharacterLevel = 1;   // starting level for new character
                        bDontExitLoop = false;
                        break;
                    default:
                        break;
                }

                // vraag hier naar keuze:
                // [B]ack voor terug
                // [E]xit voor stoppen
                // [S]ave character (afhankelijk van de state, alleen bij de laatste keuze.)
                if (bExit) {
                    baseCharacter = null;
                    nextState = createCharacterStates.DONE;
                    bDontExitLoop = false;
                }
                currentState = nextState;

            } while (bDontExitLoop);

            return baseCharacter;
        }
    }
}

            //var ArmorCollection = new ArmorTable();
            //var kutje = ArmorCollection.PopulateArmorTable();

            //foreach (var Armornogiets in kutje) {
            //    Console.WriteLine("type of armor: {0}", Armornogiets.Category);
            //    foreach (var Armor in Armornogiets.ArmorTypes) {
            //        Console.WriteLine(" Armor type: {0}", Armor.Name);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("press");
            //Console.ReadKey();
