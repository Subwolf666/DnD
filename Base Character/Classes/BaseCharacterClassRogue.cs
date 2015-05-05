using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;
using Utilities;

namespace Base_Character {
    public class BaseCharacterClassRogue : BaseCharacterClass {
        public BaseCharacterClassRogue() {

            ClassType = Enums.ClassTypes.ROGUE;
            ClassName = CharacterStrings.ClassTypeText[(int)ClassType];
            ClassDescription = CharacterStrings.ClassDescriptionTextRogue;
            PrimaryAbility = Enums.AbilityTypes.DEXTERITY;
            ClassFeaturesHitPointsHitDice = DiceBag.Dice.D8;
            ClassFeaturesHitPointsHitPointsAt1stLevel = 8; // 8 + Constitution modifier
            ClassFeaturesHitPointsHitPointsAtHigherLevels = 8; // 1d8 (or 5) + your Constitution modifier per cleric level after 1st
            ClassFeaturesProficienciesArmor = new ArmorTypes[] { ArmorTypes.ARMOR_ID_LIGHTARMOR };
            ClassFeaturesProficienciesWeapons = new WeaponsTypes[] { WeaponsTypes.WEAPONS_ID_SIMPLEMELEEWEAPONS, WeaponsTypes.WEAPONS_ID_HANDCROSSBOW, WeaponsTypes.WEAPONS_ID_LONGSWORD, WeaponsTypes.WEAPONS_ID_RAPIER, WeaponsTypes.WEAPONS_ID_SHORTSWORD };
            //public BaseTools ClassFeaturesProficienciesTools { get; set; }
            ClassFeaturesProficienciesSavingThrow = new Enums.AbilityTypes[] { Enums.AbilityTypes.DEXTERITY, Enums.AbilityTypes.INTELLIGENCE };
            ClassFeaturesProficienciesSkills = new BaseSkill[] { BaseSkill.ACROBATICS, BaseSkill.ATHLETICS, BaseSkill.DECEPTION, BaseSkill.STEALTH };
            ProficiencyClassBonus = new ProficiencyClassBonusRogue().PopulateProficiencyClassBonusRogue();
        }
    }
}

