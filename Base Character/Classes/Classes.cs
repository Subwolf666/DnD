using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;
using Utilities;

namespace Base_Character {
    public class Classes {

        public ClassTypes Name { get; set; }
        public string ClassDescription { get; set; }
        public AbilityTypes PrimaryAbility { get; set; }
        public DiceBag.Dice ClassFeaturesHitPointsHitDice { get; set; }
        public int ClassFeaturesHitPointsHitPointsAt1stLevel { get; set; }
        public int ClassFeaturesHitPointsHitPointsAtHigherLevels { get; set; }
        public Base_Equipment.Enums.ArmorTypes[] ClassFeaturesProficienciesArmor { get; set; }
        public Base_Equipment.Enums.ProficiencyWeaponsTypes[] ClassFeaturesProficienciesWeapons { get; set; }
        //public BaseTools ClassFeaturesProficienciesTools { get; set; }
        public AbilityTypes[] ClassFeaturesProficienciesSavingThrow { get; set; }
        public BaseSkill[] ClassFeaturesProficienciesSkills { get; set; }
        //public int BaseEquipment { get; set; }
        public ProficiencyClassBonus[] ProficiencyClassBonus { get; set; }


        public Classes() { }

        public Classes(ClassTypes classType, string classDescription, AbilityTypes primaryAbility, DiceBag.Dice classFeaturesHitPointsHitDice, int classFeaturesHitPointsHitPointsAt1stLevel, int classFeaturesHitPointsHitPointsAtHigherLevels, Base_Equipment.Enums.ArmorTypes[] classFeaturesProficienciesArmor, Base_Equipment.Enums.ProficiencyWeaponsTypes[] classFeaturesProficienciesWeapons, AbilityTypes[] classFeaturesProficienciesSavingThrow, BaseSkill[] classFeaturesProficienciesSkills, ProficiencyClassBonus[] proficiencyClassBonus) {
            Name = classType;
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
