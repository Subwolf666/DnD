using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;
using Utilities;

namespace Base_Character {
    public class BaseCharacterClassFighter : BaseCharacterClass {
        ProficiencyClassBonusTableFighter proficiencyClassBonus = new ProficiencyClassBonusTableFighter();

        public BaseCharacterClassFighter() {

            ClassType = ClassTypes.FIGHTER;
            ClassName = CharacterStrings.ClassTypeNames[(int)ClassType];
            ClassDescription = "A human in clanging plate armor holds her shield\n" +
                                "before her as she runs toward the massed goblins. An\n" +
                                "elf behind her, clad in studded leather armor, peppers\n" +
                                "the goblins with arrows loosed from his exquisite\n" +
                                "bow. The half-orc nearby shouts orders, helping\n" +
                                "the two combatants coordinate their assault to the\n" +
                                "best advantage.\n" +
                                "A dwarf in chain mail interposes his shield between\n" +
                                "the ogre’s club and his companion, knocking the deadly\n" +
                                "blow aside. His companion, a half-elf in scale armor,\n" +
                                "swings two scimitars in a blinding whirl as she circles\n" +
                                "the ogre, looking for a blind spot in its defenses.\n" +
                                "A gladiator fights for sport in an arena, a master with\n" +
                                "his trident and net, skilled at toppling foes and moving\n" +
                                "them around for the crowd’s delight—and his own\n" +
                                "tactical advantage. His opponent’s sword flares with\n" +
                                "blue light an instant before she sends lightning flashing\n" +
                                "forth to smite him.";

            PrimaryAbility = AbilityTypes.STRENGTH; // or Dexterity
            // Class Features
            ClassFeaturesHitPointsHitDice = DiceBag.Dice.D10;   // per fighter level
            ClassFeaturesHitPointsHitPointsAt1stLevel = 10; // 10 + Constitution modifier
            ClassFeaturesHitPointsHitPointsAtHigherLevels = 10; // 1d10 (or 6) + your Constitution modifier per cleric level after 1st
            ClassFeaturesProficienciesArmor = new ArmorTypes[] { ArmorTypes.ARMOR_ID_LIGHTARMOR, ArmorTypes.ARMOR_ID_MEDIUMARMOR, ArmorTypes.ARMOR_ID_HEAVYARMOR, ArmorTypes.ARMOR_ID_SHIELD};
            ClassFeaturesProficienciesWeapons = new WeaponsTypes[] { WeaponsTypes.WEAPONS_ID_SIMPLEMELEEWEAPONS, WeaponsTypes.WEAPONS_ID_SIMPLERANGEDWEAPONS, WeaponsTypes.WEAPONS_ID_MARTIALMELEEWEAPONS, WeaponsTypes.WEAPONS_ID_MARTIALRANGEDWEAPONS };
            //public BaseTools ClassFeaturesProficienciesTools { get; set; }
            ClassFeaturesProficienciesSavingThrow = new AbilityTypes[] { AbilityTypes.STRENGTH, AbilityTypes.CONSTITUTION };
            ClassFeaturesProficienciesSkills = new BaseSkill[] {BaseSkill.ACROBATICS, BaseSkill.ANIMALHANDLING};
            ProficiencyClassBonus = proficiencyClassBonus.PopulateProficiencyClassBonusTableFighter();

        }
    }
}

