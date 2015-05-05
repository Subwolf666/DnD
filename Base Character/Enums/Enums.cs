using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class Enums {
        public enum AbilityTypes {
            STRENGTH,
            DEXTERITY,
            CONSTITUTION,
            INTELLIGENCE,
            WISDOM,
            CHARISMA
        }
        public enum ClassTypes {
            CLERIC,
            FIGHTER,
            ROGUE,
            WIZARD
        }
        public enum RaceTypes {
            HUMANS,
            HILLDWARVES,
            MOUNTAINDWARVES,
            HIGHELVES,
            WOODELVES,
            LIGHTFOOTHALFLINGS,
            STOUTHALFLINGS
        }
        public enum RaceSizes {
            SMALL,
            MEDIUM
        }
        public enum FeatureTypes {  // ProficiencyBonus Feature Types
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
    }
}
