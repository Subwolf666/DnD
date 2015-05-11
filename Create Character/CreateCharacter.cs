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
            CHOOSELEVEL,
            CHOOSERACE,
            CHOOSECLASS,
            CHOOSEABILITIES,
//            CHOOSESKILLS,           // Not implemented
//            SELECTFEATS,            // Not implemented
            CHOOSEHEIGHTANDWEIGHT,
            CALCULATEMAXIMUMHITPOINTS,
            CHOOSENAME,
            CHOOSEGENDER,
            MONEY,
            EQUIPINGARMORANDWEAPONS,
            DONE
        }

        public static BaseCharacterSheet CreateANewCharacter() {

            bool bDontExitLoop = true;
            bool bExit = false;
            BaseCharacterSheet baseCharacter = new BaseCharacterSheet();

            createCharacterStates currentState = createCharacterStates.EQUIPINGARMORANDWEAPONS;// CHOOSELEVEL;
            createCharacterStates nextState = createCharacterStates.DONE;

            do {
                switch (currentState) {
                    case createCharacterStates.CHOOSELEVEL:
                        baseCharacter.CharacterLevel = 1;
                        nextState = createCharacterStates.CHOOSERACE;
                        break;
                    case createCharacterStates.CHOOSERACE:
                        baseCharacter.CharacterRace = RaceSelection.DisplayRaceSelection();
                        nextState = createCharacterStates.CHOOSECLASS;
                        break;
                    case createCharacterStates.CHOOSECLASS:
                        baseCharacter.CharacterClass = ClassSelection.DisplayClassSelection();
                        baseCharacter.CharacterProficiencyBonus = 2; // baseCharacter.CharacterClass.ProficiencyClassBonus[0].ProficiencyBonus; // First level character always has PB = 2. 
                        nextState = createCharacterStates.CHOOSEABILITIES;
                        break;
                    case createCharacterStates.CHOOSEABILITIES:
                        baseCharacter.CharacterAbilityScores = AbilitiesSelection.DisplayAbilitiesSelection(baseCharacter.CharacterClass.Name, baseCharacter.CharacterRace);
                        baseCharacter.CharacterAbilityModifiers = AbilitiesSelection.GetBaseAbilityModifiersForselectedClass(baseCharacter.CharacterAbilityScores);
                        nextState = createCharacterStates.CHOOSEHEIGHTANDWEIGHT;
                        break;
                    case createCharacterStates.CHOOSEHEIGHTANDWEIGHT:
                        baseCharacter.CharacterHeightAndWeight = HeightAndWeightSelection.DisplayHeightAndWeightSelection(baseCharacter.CharacterRace);
                        nextState = createCharacterStates.CALCULATEMAXIMUMHITPOINTS;
                        break;
                    case createCharacterStates.CALCULATEMAXIMUMHITPOINTS:
                        baseCharacter.CharacterMaximumHitPoints = CharacterFormulas.CalcMaximumHitPoints(baseCharacter.CharacterClass.ClassFeaturesHitPointsHitDice, baseCharacter.CharacterLevel, baseCharacter.CharacterAbilityModifiers.Constitution);
                        baseCharacter.CharacterCurrentHitPoints = baseCharacter.CharacterMaximumHitPoints;
                        nextState = createCharacterStates.CHOOSENAME;
                        break;
                    case createCharacterStates.CHOOSENAME:
                        baseCharacter.CharacterName = NameSelection.DisplayNameSelection();
                        nextState = createCharacterStates.CHOOSEGENDER;
                        break;
                    case createCharacterStates.CHOOSEGENDER:
                        baseCharacter.Gender = GenderSelection.DisplayGenderSelection();
                        nextState = createCharacterStates.MONEY;
                        break;
                    case createCharacterStates.MONEY:    // Base Equipment
                        baseCharacter.CharacterGold = Wealth.StartingWealthClass(baseCharacter.CharacterClass.Name);
                        nextState = createCharacterStates.EQUIPINGARMORANDWEAPONS;
                        break;
                    case createCharacterStates.EQUIPINGARMORANDWEAPONS:
                        var armor = Armor.ArmorList;
                        var weapons = Weapons.WeaponsList;
                        Inventory inventory = new Inventory(52);
                        foreach (var armortype in armor) {
                            inventory.AddItem(armortype);
                            if (armortype.ID == Enums.MEDIUMARMOR_ID_CHAINSHIRT) {
                                baseCharacter.EquipedArmor = armortype;
                            }
                        }
                        foreach (var weapontype in weapons) {
                            inventory.AddItem(weapontype);
                            if (weapontype.ID == Enums.MARTIALMELEEWEAPON_ID_GREATSWORD) {
                                baseCharacter.EquipedWeapon = weapontype;
                            }
                        }
                        // make function to get an armor_id_ARMORTYPE (eg HEAVYARMOR_ID_CHAINMAIL)
                        nextState = createCharacterStates.DONE;
                        break;
                    case createCharacterStates.DONE:
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
