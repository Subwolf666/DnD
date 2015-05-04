using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;
using Utilities;

namespace Base_Character {
    public class BaseCharacterClassWizard : BaseCharacterClass {
        public BaseCharacterClassWizard() {
            ProficiencyClassBonusTableWizard proficiencyClassBonus = new ProficiencyClassBonusTableWizard();

            ClassType = ClassTypes.WIZARD;
            ClassName = CharacterStrings.ClassTypeNames[(int)ClassType];
            ClassDescription = "Clad in the silver robes that denote her station, an\n" +
                                "elf closes her eyes to shut out the distractions of the\n" +
                                "battlefield and begins her quiet chant. Fingers weaving\n" +
                                "in front of her, she completes her spell and launches a\n" +
                                "tiny bead of fire toward the enemy ranks, where it erupts\n" +
                                "into a conflagration that engulfs the soldiers.\n" +
                                "Checking and rechecking his work, a human scribes\n" +
                                "an intricate magic circle in chalk on the bare stone\n" +
                                "floor, then sprinkles powdered iron along every line and\n" +
                                "graceful curve. When the circle is complete, he drones a\n" +
                                "long incantation. A hole opens in space inside the circle,\n" +
                                "bringing a whiff of brimstone from the otherworldly\n" +
                                "plane beyond.\n" +
                                "Crouching on the floor in a dungeon intersection, a\n" +
                                "gnome tosses a handful of small bones inscribed with\n" +
                                "mystic symbols, muttering a few words of power over\n" +
                                "them. Closing his eyes to see the visions more clearly,\n" +
                                "he nods slowly, then opens his eyes and points down the\n" +
                                "passage to his left.\n" +
                                "Wizards are supreme magic-users, defined and united\n" +
                                "as a class by the spells they cast. Drawing on the subtle\n" +
                                "weave of magic that permeates the cosmos, wizards cast\n" +
                                "spells of explosive fire, arcing lightning, subtle deception,\n" +
                                "and brute-force mind control. Their magic conjures\n" +
                                "monsters from other planes of existence, glimpses the\n" +
                                "future, or turns slain foes into zombies. Their mightiest\n" +
                                "spells change one substance into another, call meteors\n" +
                                "down from the sky, or open portals to other worlds.";

            PrimaryAbility = AbilityTypes.INTELLIGENCE;
            // Class Features
            ClassFeaturesHitPointsHitDice = DiceBag.Dice.D6;
            ClassFeaturesHitPointsHitPointsAt1stLevel = 6; // 6 + Constitution modifier
            ClassFeaturesHitPointsHitPointsAtHigherLevels = 6; // 1d6 (or 4) + your Constitution modifier per cleric level after 1st
            ClassFeaturesProficienciesArmor = new ArmorTypes[] { ArmorTypes.ARMOR_ID_NONE };
            ClassFeaturesProficienciesWeapons = new WeaponsTypes[] { WeaponsTypes.WEAPONS_ID_DAGGER, WeaponsTypes.WEAPONS_ID_DART, WeaponsTypes.WEAPONS_ID_SLING, WeaponsTypes.WEAPONS_ID_QUARTERSTAFF, WeaponsTypes.WEAPONS_ID_LIGHTCROSSBOW };
            //public BaseTools ClassFeaturesProficienciesTools { get; set; }
            ClassFeaturesProficienciesSavingThrow = new AbilityTypes[] { AbilityTypes.INTELLIGENCE, AbilityTypes.WISDOM };
            ClassFeaturesProficienciesSkills = new BaseSkill[] { BaseSkill.ARCANA, BaseSkill.HISTORY };
            ProficiencyClassBonus = proficiencyClassBonus.PopulateProficiencyClassBonusTableWizard();

        }
    }
}

