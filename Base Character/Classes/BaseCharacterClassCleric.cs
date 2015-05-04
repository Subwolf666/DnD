using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;
using Utilities;

namespace Base_Character {
    public class BaseCharacterClassCleric : BaseCharacterClass {
        ProficiencyClassBonusTableCleric proficiencyClassBonus = new ProficiencyClassBonusTableCleric();

        public BaseCharacterClassCleric() {

            ClassType = ClassTypes.CLERIC;
            ClassName = CharacterStrings.ClassTypeNames[(int)ClassType];
            ClassDescription = "Arms and eyes upraised toward the sun and a prayer\n" +
                                "on his lips, an elf begins to glow with an inner light that\n" +
                                "spills out to heal his battle-worn companions.\n" +
                                "Chanting a song of glory, a dwarf swings his axe\n" +
                                "in wide swaths to cut through the ranks of orcs\n" +
                                "arrayed against him, shouting praise to the gods with\n" +
                                "every foe’s fall.\n" +
                                "Calling down a curse upon the forces of undeath, a\n" +
                                "human lifts her holy symbol as light pours from it to\n" +
                                "drive back the zombies crowding in on her companions.\n" +
                                "Clerics are intermediaries between the mortal world\n" +
                                "and the distant planes of the gods. As varied as the gods\n" +
                                "they serve, clerics strive to embody the handiwork of\n" +
                                "their deities. No ordinary priest, a cleric is imbued with\n" +
                                "divine magic.";

            PrimaryAbility = AbilityTypes.WISDOM;
            // Class Features
            ClassFeaturesHitPointsHitDice = DiceBag.Dice.D8;  // 1d8
            ClassFeaturesHitPointsHitPointsAt1stLevel = 8; // 8 + Constitution modifier
            ClassFeaturesHitPointsHitPointsAtHigherLevels = 8; // 1d8 (or 5) + your Constitution modifier per cleric level after 1st
            ClassFeaturesProficienciesArmor = new ArmorTypes[] { ArmorTypes.ARMOR_ID_LIGHTARMOR, ArmorTypes.ARMOR_ID_MEDIUMARMOR, ArmorTypes.ARMOR_ID_SHIELD };
            ClassFeaturesProficienciesWeapons = new WeaponsTypes[] { WeaponsTypes.WEAPONS_ID_SIMPLEMELEEWEAPONS, WeaponsTypes.WEAPONS_ID_SIMPLERANGEDWEAPONS };
            //public BaseTools ClassFeaturesProficienciesTools { get; set; }
            ClassFeaturesProficienciesSavingThrow = new AbilityTypes[] { AbilityTypes.WISDOM, AbilityTypes.CHARISMA };
            ClassFeaturesProficienciesSkills = new BaseSkill[] { BaseSkill.HISTORY, BaseSkill.INSIGHT };
            ProficiencyClassBonus = proficiencyClassBonus.PopulateProficiencyClassBonusTableCleric();
            
        }
    }
}

