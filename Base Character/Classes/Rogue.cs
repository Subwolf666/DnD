using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;
using Utilities;

namespace Base_Character {
    public class Rogue : Classes {
        public Rogue() {

            Name = Base_Character.ClassTypes.Rogue;
            ClassDescription = StringFunctions.ClassDescriptionTextRogue;
            PrimaryAbility = Base_Character.AbilityTypes.Dexterity;
            ClassFeaturesHitPointsHitDice = DiceBag.Dice.D8;
            ClassFeaturesHitPointsHitPointsAt1stLevel = 8; // 8 + Constitution modifier
            ClassFeaturesHitPointsHitPointsAtHigherLevels = 8; // 1d8 (or 5) + your Constitution modifier per cleric level after 1st
            ClassFeaturesProficienciesArmor = new Base_Equipment.Enums.ArmorTypes[] { Base_Equipment.Enums.ArmorTypes.ARMOR_ID_LIGHTARMOR };
            ClassFeaturesProficienciesWeapons = new Base_Equipment.Enums.ProficiencyWeaponsTypes[] { Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_SIMPLEMELEEWEAPONS, Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_HANDCROSSBOW, Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_LONGSWORD, Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_RAPIER, Base_Equipment.Enums.ProficiencyWeaponsTypes.WEAPONS_ID_SHORTSWORD };
            //public BaseTools ClassFeaturesProficienciesTools { get; set; }
            ClassFeaturesProficienciesSavingThrow = new Base_Character.AbilityTypes[] { Base_Character.AbilityTypes.Dexterity, Base_Character.AbilityTypes.Intelligence };
            ClassFeaturesProficienciesSkills = new BaseSkill[] { BaseSkill.ACROBATICS, BaseSkill.ATHLETICS, BaseSkill.DECEPTION, BaseSkill.STEALTH };
            ProficiencyClassBonus = new ProficiencyClassBonusRogue().PopulateProficiencyClassBonusRogue();
        }
    }
}

