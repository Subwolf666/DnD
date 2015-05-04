using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public enum FeatureTypes {
        NONE,
        SPELLCASTING,
        DIVINEDOMAIN,
        CHANNELDIVINITY1,
        CHANNELDIVINITY2,
        CHANNELDIVINITY3,
        DIVINEDOMAINFEATURE,
        ABILITYSCOREIMPROVEMENT,
        DESTROYUNDEAD12,
        DESTROYUNDEAD1,
        DESTROYUNDEAD2,
        DESTROYUNDEAD3,
        DESTROYUNDEAD4,
        DIVINEINTERVENTION,
        DIVINEINTERVENTIONIMPROVEMENT,
        ARCANERECOVERY,
        ARCANETRADITION,
        ARCANETRADITIONFEATURE,
        SPELLMASTERY,
        SIGNATURESPELL,
        FIGHTINGSTYLE,
        SECONDWIND,
        ACTIONSURGE1,
        MARTIALARCHETYPE,
        EXTRAATTACK,
        MARTIALARCHETYPEFEATURE,
        INDOMITABLE1,
        EXTRAATTACK2,
        INDOMITABLE2,
        ACTIONSURGE2,
        INDOMITABLE3,
        EXTRAATTACK3,
        EXPERTISE,
        SNEAKATTACK,
        THIEVESCANT,
        CUNNINGACTION,
        ROGUISHARCHETYPE,
        UNCANNYDODGE,
        EVASION,
        ROGUISHARCHETYPEFEATURE,
        RELIABLETALENT,
        BLINDSENSE,
        SLIPPERYMIND,
        ELUSIVE,
        STROKEOFLUCK,
    }

    public class ProficiencyClassBonusTable {

        public int Level { get; set; }
        public int ProficiencyBonus { get; set; }
        public FeatureTypes[] Features { get; set; }
        public int CantripsKnown { get; set; }
        public int[] SpellSlotsPerSpellLevel { get; set; }

        public ProficiencyClassBonusTable() { }

        public ProficiencyClassBonusTable(int level, int proficiencyBonus, FeatureTypes[] features, int cantripsKnown, int[] spellSlotsPerSpellLevel) {
            Level = level;
            ProficiencyBonus = proficiencyBonus;
            Features = features;
            CantripsKnown = cantripsKnown;
            SpellSlotsPerSpellLevel = spellSlotsPerSpellLevel;
        }
    }
}
