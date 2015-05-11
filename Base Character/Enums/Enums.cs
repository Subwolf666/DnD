using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public enum GenderTypes {
        Invalid,
        Female,
        Male,
    }
    public enum AbilityTypes {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma,
    }
    public enum ClassTypes {
        Invalid,
        Cleric,
        Fighter,
        Rogue,
        Wizard,
    }
    public enum RaceTypes {
        Invalid,
        Humans,
        Hilldwarves,
        Mountaindwarves,
        Highelves,
        Woodelves,
        Lightfoothalflings,
        Stouthalflings,
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

    //public class EnumParser {
    //    private EnumParser() { }

    //    public static GenderTypes parse_gender(int choice) {
    //        try {
    //            return (GenderTypes)Enum.ToObject(typeof(GenderTypes), choice);
    //        } catch (ArgumentException) {
    //            return GenderTypes.Invalid;
    //        }
    //    }

    //    public static string get_race_name(RaceTypes racetype) {
    //        string to_return;
    //        to_return = StringFunctions.RaceTypeText[(int)racetype];
    //        return to_return;
    //    }

    //    public static string[] get_race_names() {
    //        string[] race_names = Enum.GetNames(typeof(RaceTypes));
    //        string[] to_return = new string[race_names.Length - 1];
    //        for (int i = 0, j = 0; i < race_names.Length; i++) {
    //            if (race_names[i] != "Invalid") {
    //                if (race_names[i] == "HalfElf")
    //                    to_return[j++] = "Half-Elf";
    //                else if (race_names[i] == "HalfOrc")
    //                    to_return[j++] = "Half-Orc";
    //                else
    //                    to_return[j++] = race_names[i];
    //            }
    //        }
    //        return to_return;
    //    }

    //    //public static string[] get_class_names() {
    //    //    string[] class_names = Enum.GetNames(typeof(Class));
    //    //    string[] to_return = new string[class_names.Length - 1];
    //    //    for (int i = 0, j = 0; i < class_names.Length; i++) {
    //    //        if (class_names[i] != "Invalid") to_return[j++] = class_names[i];
    //    //    }
    //    //    return to_return;
    //    //}
    //}
}
