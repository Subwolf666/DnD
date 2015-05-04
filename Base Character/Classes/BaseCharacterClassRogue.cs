using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;
using Utilities;

namespace Base_Character {
    public class BaseCharacterClassRogue : BaseCharacterClass {
        ProficiencyClassBonusTableRogue proficiencyClassBonus = new ProficiencyClassBonusTableRogue();

        public BaseCharacterClassRogue() {

            ClassType = ClassTypes.ROGUE;
            ClassName = CharacterStrings.ClassTypeNames[(int)ClassType];
            ClassDescription = "Signaling for her companions to wait, a halfling creeps\n" +
                                "forward through the dungeon hall. She presses an ear\n" +
                                "to the door, then pulls out a set of tools and picks the\n" +
                                "lock in the blink of an eye. Then she disappears into\n" +
                                "the shadows as her fighter friend moves forward to kick\n" +
                                "the door open.\n" +
                                "A human lurks in the shadows of an alley while his\n" +
                                "accomplice prepares for her part in the ambush. When\n" +
                                "their target—a notorious slaver—passes the alleyway,\n" +
                                "the accomplice cries out, the slaver comes to investigate,\n" +
                                "and the assassin’s blade cuts his throat before he can\n" +
                                "make a sound.\n" +
                                "Suppressing a giggle, a gnome waggles her fingers\n" +
                                "and magically lifts the key ring from the guard’s belt.\n" +
                                "In a moment, the keys are in her hand, the cell door is\n" +
                                "open, and she and her companions are free to make\n" +
                                "their escape.\n" +
                                "Rogues rely on skill, stealth, and their foes’\n" +
                                "vulnerabilities to get the upper hand in any situation.\n" +
                                "They have a knack for finding the solution to just about\n" +
                                "any problem, demonstrating a resourcefulness and\n" +
                                "versatility that is the cornerstone of any successful\n" +
                                "adventuring party";

            PrimaryAbility = AbilityTypes.DEXTERITY;
            
            // Class Features
            ClassFeaturesHitPointsHitDice = DiceBag.Dice.D8;
            ClassFeaturesHitPointsHitPointsAt1stLevel = 8; // 8 + Constitution modifier
            ClassFeaturesHitPointsHitPointsAtHigherLevels = 8; // 1d8 (or 5) + your Constitution modifier per cleric level after 1st

            ClassFeaturesProficienciesArmor = new ArmorTypes[] { ArmorTypes.ARMOR_ID_LIGHTARMOR };
            ClassFeaturesProficienciesWeapons = new WeaponsTypes[] { WeaponsTypes.WEAPONS_ID_SIMPLEMELEEWEAPONS, WeaponsTypes.WEAPONS_ID_HANDCROSSBOW, WeaponsTypes.WEAPONS_ID_LONGSWORD, WeaponsTypes.WEAPONS_ID_RAPIER, WeaponsTypes.WEAPONS_ID_SHORTSWORD };
            //public BaseTools ClassFeaturesProficienciesTools { get; set; }

            ClassFeaturesProficienciesSavingThrow = new AbilityTypes[] { AbilityTypes.DEXTERITY, AbilityTypes.INTELLIGENCE };
            ClassFeaturesProficienciesSkills = new BaseSkill[] { BaseSkill.ACROBATICS, BaseSkill.ATHLETICS, BaseSkill.DECEPTION, BaseSkill.STEALTH };
            ProficiencyClassBonus = proficiencyClassBonus.PopulateProficiencyClassBonusTableRogue();
        }
    }
}

