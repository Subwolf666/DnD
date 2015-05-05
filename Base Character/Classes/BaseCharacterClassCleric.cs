using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;
using Utilities;

namespace Base_Character {
    public class BaseCharacterClassCleric : BaseCharacterClass {
        public BaseCharacterClassCleric() {

            ClassType = Enums.ClassTypes.CLERIC;
            ClassName = CharacterStrings.ClassTypeText[(int)ClassType];
            ClassDescription = CharacterStrings.ClassDescriptionTextCleric;
            PrimaryAbility = Enums.AbilityTypes.WISDOM;
            ClassFeaturesHitPointsHitDice = DiceBag.Dice.D8;  // 1d8
            ClassFeaturesHitPointsHitPointsAt1stLevel = 8; // 8 + Constitution modifier
            ClassFeaturesHitPointsHitPointsAtHigherLevels = 8; // 1d8 (or 5) + your Constitution modifier per cleric level after 1st
            ClassFeaturesProficienciesArmor = new Base_Equipment.Enums.ArmorTypes[] { Base_Equipment.Enums.ArmorTypes.ARMOR_ID_LIGHTARMOR, Base_Equipment.Enums.ArmorTypes.ARMOR_ID_MEDIUMARMOR, Base_Equipment.Enums.ArmorTypes.ARMOR_ID_SHIELD };
            ClassFeaturesProficienciesWeapons = new Base_Equipment.Enums.ProficiencyWeaponsTypes[] { Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_SIMPLEMELEEWEAPONS, Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_SIMPLERANGEDWEAPONS };
            //public BaseTools ClassFeaturesProficienciesTools { get; set; }
            ClassFeaturesProficienciesSavingThrow = new Enums.AbilityTypes[] { Enums.AbilityTypes.WISDOM, Enums.AbilityTypes.CHARISMA };
            ClassFeaturesProficienciesSkills = new BaseSkill[] { BaseSkill.HISTORY, BaseSkill.INSIGHT };
            //Equipment
            ProficiencyClassBonus = new ProficiencyClassBonusCleric().PopulateProficiencyClassBonusCleric();
        }
    }
}

