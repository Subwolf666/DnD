using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;
using Utilities;

namespace Base_Character {
    public class BaseCharacterClass {

        public string ClassName { get; set; }
        public Enums.ClassTypes ClassType { get; set; }
        public string ClassDescription { get; set; }
        public Enums.AbilityTypes PrimaryAbility { get; set; }
        public DiceBag.Dice ClassFeaturesHitPointsHitDice { get; set; }
        public int ClassFeaturesHitPointsHitPointsAt1stLevel { get; set; }
        public int ClassFeaturesHitPointsHitPointsAtHigherLevels { get; set; }
        public Base_Equipment.Enums.ArmorTypes[] ClassFeaturesProficienciesArmor { get; set; }
        public Base_Equipment.Enums.ProficiencyWeaponsTypes[] ClassFeaturesProficienciesWeapons { get; set; }
        //public BaseTools ClassFeaturesProficienciesTools { get; set; }
        public Enums.AbilityTypes[] ClassFeaturesProficienciesSavingThrow { get; set; }
        public BaseSkill[] ClassFeaturesProficienciesSkills { get; set; }
        //public int BaseEquipment { get; set; }
        public BaseProficiencyClassBonus[] ProficiencyClassBonus { get; set; }


        public BaseCharacterClass() { }

        public BaseCharacterClass(string className, Enums.ClassTypes classType, string classDescription, Enums.AbilityTypes primaryAbility, DiceBag.Dice classFeaturesHitPointsHitDice, int classFeaturesHitPointsHitPointsAt1stLevel, int classFeaturesHitPointsHitPointsAtHigherLevels, Base_Equipment.Enums.ArmorTypes[] classFeaturesProficienciesArmor, Base_Equipment.Enums.ProficiencyWeaponsTypes[] classFeaturesProficienciesWeapons, Enums.AbilityTypes[] classFeaturesProficienciesSavingThrow, BaseSkill[] classFeaturesProficienciesSkills, BaseProficiencyClassBonus[] proficiencyClassBonus) {
            ClassName = className;
            ClassType = classType;
            ClassDescription = classDescription;
            PrimaryAbility = primaryAbility;
            ClassFeaturesHitPointsHitDice = classFeaturesHitPointsHitDice;
            ClassFeaturesHitPointsHitPointsAt1stLevel = classFeaturesHitPointsHitPointsAt1stLevel;
            ClassFeaturesHitPointsHitPointsAtHigherLevels = classFeaturesHitPointsHitPointsAtHigherLevels;
            ClassFeaturesProficienciesArmor = classFeaturesProficienciesArmor;
            ClassFeaturesProficienciesWeapons = classFeaturesProficienciesWeapons;
            ClassFeaturesProficienciesSavingThrow = classFeaturesProficienciesSavingThrow;
            ClassFeaturesProficienciesSkills = classFeaturesProficienciesSkills;
            ProficiencyClassBonus = proficiencyClassBonus;
        }
    }
}
