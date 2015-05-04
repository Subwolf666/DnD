using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Base_Abilities;
using Base_Character;
using Base_Equipment;
using Character_Details;

namespace Base_Character {
    public class BaseCharacterSheet {

        public string CharacterName { get; set; }                   // Character Name
        public int CharacterLevel { get; set; }                  // Character Level
        public string CharacterSex { get; set; }                  // Character Sex
        public BaseCharacterRace CharacterRace { get; set; }        // Character Race
        public BaseCharacterClass CharacterClass { get; set; }      // Character Class
        public int CharacterAlignment { get; set; }              // Character Alignment maybe an int
        public int CharacterExperiencePoints { get; set; }          // Character Experience Points

        public BaseCharacterAbilities CharacterAbilityScores { get; set; }
        public BaseCharacterAbilities CharacterAbilityModifiers { get; set; }

        //public int CharacterInspiration { get; set; }               // Character Inspiration Points
        //public int CharacterProficiencyBonus { get; set; }          // Character Proficiency Bonus Points
        ////
        //public int CharacterSavingThrowsStrength { get; set; }
        //public int CharacterSavingThrowsDexterity { get; set; }
        //public int CharacterSavingThrowsConstitution { get; set; }
        //public int CharacterSavingThrowsIntelligence { get; set; }
        //public int CharacterSavingThrowsWisdom { get; set; }
        //public int CharacterSavingThrowsCharisma { get; set; }
        ////
        //public int CharacterSavingSkillsAcrobaticsDex { get; set; }
        //public int CharacterSavingSkillsAnimalHandlingWis { get; set; }
        //public int CharacterSavingSkillsArcanaInt { get; set; }
        //public int CharacterSavingSkillsAthleticsStr { get; set; }
        //public int CharacterSavingSkillsDeceptionCha { get; set; }
        //public int CharacterSavingSkillsHistoryInt { get; set; }
        //public int CharacterSavingSkillsInsightWis { get; set; }
        //public int CharacterSavingSkillsIntimidationCha { get; set; }
        //public int CharacterSavingSkillsInvestigationInt { get; set; }
        //public int CharacterSavingSkillsMedicineWis { get; set; }
        //public int CharacterSavingSkillsNatureInt { get; set; }
        //public int CharacterSavingSkillsPerceptionWis { get; set; }
        //public int CharacterSavingSkillsPerformanceCha { get; set; }
        //public int CharacterSavingSkillsPersuasionCha { get; set; }
        //public int CharacterSavingSkillsReligionInt { get; set; }
        //public int CharacterSavingSkillsSleightOfHandDex { get; set; }
        //public int CharacterSavingSkillsStealthDex { get; set; }
        //public int CharacterSavingSkillsSurvivalWis { get; set; }
        ////
        //public int CharacterPassiveWisdomPerception { get; set; }
        ////
        //public int CharacterOtherProficienciesAndLanguages { get; set; }

        //public int CharacterArmorClass { get; set; }                // Character Armor Class Points
        //public int CharacterInitiative { get; set; }                // Character Initiative Points
        //public int CharacterSpeed { get; set; }                     // Character Speed
        ////
        public int CharacterCurrentHitPoints { get; set; }
        public int CharacterMaximumHitPoints { get; set; }
        //public int CharacterTemporaryHitPoints { get; set; }
        //public int CharacterHitDice { get; set; }                   // Hit Dice short for Hit Point Dice
        //// Death Saves
        ////  Successes
        ////  Failures
        //public int CharacterAttacksSpellCasting { get; set; }
        public int CharacterGold { get; set; }                      // CP, SP, EP, CP, PP
        //public BaseEquipment CharacterEquipment { get; set; }

        //public int CharacterPersonalityTraits { get; set; }
        //public int CharacterIdeals { get; set; }
        //public int CharacterBonds { get; set; }
        //public int CharacterFlaws { get; set; }
        //public int CharacterFeaturesAndTraits { get; set; }

        //public int CharacterAge { get; set; }
        public BaseHeightAndWeight CharacterBaseHeightAndWeight { get; set; }
        public BaseHeightAndWeight CharacterHeightAndWeight { get; set; }
        //public BaseHeightAndWeight CharacterWeight { get; set; }
        //public int CharacterEyes { get; set; }
        //public int CharacterSkin { get; set; }
        //public int CharacterHair { get; set; }

        //public int CharacterAppearance { get; set; }
        //public int CharacterBackStory { get; set; }

        //public int CharacterAlliesAndOrganization { get; set; }
        //// name, symbol

        //public int CharacterAdditionalFeaturesAndTraits { get; set; }
        //public int CharacterTreasure { get; set; }

        //// Spellcasting
        //public int CharacterSpellCastingClass { get; set; }
        ////
        //public int CharacterSpellCastingAbility { get; set; }
        //public int CharacterSpellSaveDC { get; set; }
        //public int CharacterSpellAttackBonus { get; set; }
        ////
        //public int CharacterCantrips { get; set; }
        ////public int CharacterSpellLevel
        //// Verder uitwerken of in een aparte class onderbrengen.

    }
}
