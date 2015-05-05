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

            ClassType = Enums.ClassTypes.WIZARD;
            ClassName = CharacterStrings.ClassTypeText[(int)ClassType];
            ClassDescription = CharacterStrings.ClassDescriptionTextWizard;
            PrimaryAbility = Enums.AbilityTypes.INTELLIGENCE;
            ClassFeaturesHitPointsHitDice = DiceBag.Dice.D6;
            ClassFeaturesHitPointsHitPointsAt1stLevel = 6; // 6 + Constitution modifier
            ClassFeaturesHitPointsHitPointsAtHigherLevels = 6; // 1d6 (or 4) + your Constitution modifier per cleric level after 1st
            ClassFeaturesProficienciesArmor = new ArmorTypes[] { ArmorTypes.ARMOR_ID_NONE };
            ClassFeaturesProficienciesWeapons = new WeaponsTypes[] { WeaponsTypes.WEAPONS_ID_DAGGER, WeaponsTypes.WEAPONS_ID_DART, WeaponsTypes.WEAPONS_ID_SLING, WeaponsTypes.WEAPONS_ID_QUARTERSTAFF, WeaponsTypes.WEAPONS_ID_LIGHTCROSSBOW };
            //public BaseTools ClassFeaturesProficienciesTools { get; set; }
            ClassFeaturesProficienciesSavingThrow = new Enums.AbilityTypes[] { Enums.AbilityTypes.INTELLIGENCE, Enums.AbilityTypes.WISDOM };
            ClassFeaturesProficienciesSkills = new BaseSkill[] { BaseSkill.ARCANA, BaseSkill.HISTORY };
            ProficiencyClassBonus = new ProficiencyClassBonusWizard().PopulateProficiencyClassBonusWizard();
        }
    }
}

