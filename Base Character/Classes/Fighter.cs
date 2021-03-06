﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;
using Utilities;

namespace Base_Character {
    public class Fighter : Classes {
        public Fighter() {

            Name = Base_Character.ClassTypes.Fighter;
            ClassDescription = StringFunctions.ClassDescriptionTextFighter;
            PrimaryAbility = Base_Character.AbilityTypes.Strength; // or Dexterity
            ClassFeaturesHitPointsHitDice = DiceBag.Dice.D10;   // per fighter level
            ClassFeaturesHitPointsHitPointsAt1stLevel = 10; // 10 + Constitution modifier
            ClassFeaturesHitPointsHitPointsAtHigherLevels = 10; // 1d10 (or 6) + your Constitution modifier per cleric level after 1st
            ClassFeaturesProficienciesArmor = new Base_Equipment.Enums.ArmorTypes[] { Base_Equipment.Enums.ArmorTypes.ARMOR_ID_LIGHTARMOR, Base_Equipment.Enums.ArmorTypes.ARMOR_ID_MEDIUMARMOR, Base_Equipment.Enums.ArmorTypes.ARMOR_ID_HEAVYARMOR, Base_Equipment.Enums.ArmorTypes.ARMOR_ID_SHIELD };
            ClassFeaturesProficienciesWeapons = new Base_Equipment.Enums.ProficiencyWeaponsTypes[] { Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_SIMPLEMELEEWEAPONS, Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_SIMPLERANGEDWEAPONS, Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_MARTIALMELEEWEAPONS, Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_MARTIALRANGEDWEAPONS };
            //public BaseTools ClassFeaturesProficienciesTools { get; set; }
            ClassFeaturesProficienciesSavingThrow = new Base_Character.AbilityTypes[] { Base_Character.AbilityTypes.Strength, Base_Character.AbilityTypes.Constitution };
            ClassFeaturesProficienciesSkills = new BaseSkill[] {BaseSkill.ACROBATICS, BaseSkill.ANIMALHANDLING};
            ProficiencyClassBonus = new ProficiencyClassBonusFighter().PopulateProficiencyClassBonusFighter();
        }
    }
}

