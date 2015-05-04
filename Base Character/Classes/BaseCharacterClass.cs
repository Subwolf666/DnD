using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;
using Utilities;

namespace Base_Character {
    public enum ClassTypes {
        CLERIC,
        FIGHTER,
        ROGUE,
        WIZARD
    }

    public class BaseCharacterClass {
        public string ClassName { get; set; }
        public ClassTypes ClassType { get; set; }
        public string ClassDescription { get; set; }

        public AbilityTypes PrimaryAbility { get; set; }

        // Class Features
        public DiceBag.Dice ClassFeaturesHitPointsHitDice { get; set; }
        public int ClassFeaturesHitPointsHitPointsAt1stLevel { get; set; }
        public int ClassFeaturesHitPointsHitPointsAtHigherLevels { get; set; }
        public ArmorTypes[] ClassFeaturesProficienciesArmor { get; set; }
        public WeaponsTypes[] ClassFeaturesProficienciesWeapons { get; set; }
        //public BaseTools ClassFeaturesProficienciesTools { get; set; }
        public AbilityTypes[] ClassFeaturesProficienciesSavingThrow { get; set; }
        public BaseSkill[] ClassFeaturesProficienciesSkills { get; set; }
        public ProficiencyClassBonusTable[] ProficiencyClassBonus { get; set; }

        public BaseCharacterClass() { }

    }
}
