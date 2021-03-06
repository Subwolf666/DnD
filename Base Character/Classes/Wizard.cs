﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;
using Utilities;

namespace Base_Character {
    public class Wizard : Classes {
        public Wizard() {

            Name = Base_Character.ClassTypes.Wizard;
            ClassDescription = StringFunctions.ClassDescriptionTextWizard;
            PrimaryAbility = Base_Character.AbilityTypes.Intelligence;
            ClassFeaturesHitPointsHitDice = DiceBag.Dice.D6;
            ClassFeaturesHitPointsHitPointsAt1stLevel = 6; // 6 + Constitution modifier
            ClassFeaturesHitPointsHitPointsAtHigherLevels = 6; // 1d6 (or 4) + your Constitution modifier per cleric level after 1st
            ClassFeaturesProficienciesArmor = new Base_Equipment.Enums.ArmorTypes[] { Base_Equipment.Enums.ArmorTypes.ARMOR_ID_NONE };
            ClassFeaturesProficienciesWeapons = new Base_Equipment.Enums.ProficiencyWeaponsTypes[] { Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_DAGGER, Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_DART, Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_SLING, Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_QUARTERSTAFF, Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_LIGHTCROSSBOW };
            //public BaseTools ClassFeaturesProficienciesTools { get; set; }
            ClassFeaturesProficienciesSavingThrow = new Base_Character.AbilityTypes[] { Base_Character.AbilityTypes.Intelligence, Base_Character.AbilityTypes.Wisdom };
            ClassFeaturesProficienciesSkills = new BaseSkill[] { BaseSkill.ARCANA, BaseSkill.HISTORY };
            ProficiencyClassBonus = new ProficiencyClassBonusWizard().PopulateProficiencyClassBonusWizard();
        }
    }
}

