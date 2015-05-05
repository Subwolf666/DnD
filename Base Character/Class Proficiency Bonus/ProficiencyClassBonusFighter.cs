using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class ProficiencyClassBonusFighter : BaseProficiencyClassBonus {

        public ProficiencyClassBonusFighter() { }

        public BaseProficiencyClassBonus[] PopulateProficiencyClassBonusFighter() {
            var table = new BaseProficiencyClassBonus[] {
                new BaseProficiencyClassBonus( 1, 2, new Enums.FeatureTypes[] {Enums.FeatureTypes.FIGHTINGSTYLE, Enums.FeatureTypes.SECONDWIND}, 0, null),
                new BaseProficiencyClassBonus( 2, 2, new Enums.FeatureTypes[] {Enums.FeatureTypes.ACTIONSURGE1}, 0, null),
                new BaseProficiencyClassBonus( 3, 2, new Enums.FeatureTypes[] {Enums.FeatureTypes.MARTIALARCHETYPE}, 0, null),
                new BaseProficiencyClassBonus( 4, 2, new Enums.FeatureTypes[] {Enums.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new BaseProficiencyClassBonus( 5, 3, new Enums.FeatureTypes[] {Enums.FeatureTypes.EXTRAATTACK}, 0, null),
                new BaseProficiencyClassBonus( 6, 3, new Enums.FeatureTypes[] {Enums.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new BaseProficiencyClassBonus( 7, 3, new Enums.FeatureTypes[] {Enums.FeatureTypes.MARTIALARCHETYPEFEATURE}, 0, null),
                new BaseProficiencyClassBonus( 8, 3, new Enums.FeatureTypes[] {Enums.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new BaseProficiencyClassBonus( 9, 4, new Enums.FeatureTypes[] {Enums.FeatureTypes.INDOMITABLE1}, 0, null),
                new BaseProficiencyClassBonus(10, 4, new Enums.FeatureTypes[] {Enums.FeatureTypes.MARTIALARCHETYPEFEATURE}, 0, null),
                new BaseProficiencyClassBonus(11, 4, new Enums.FeatureTypes[] {Enums.FeatureTypes.EXTRAATTACK2}, 0, null),
                new BaseProficiencyClassBonus(12, 4, new Enums.FeatureTypes[] {Enums.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new BaseProficiencyClassBonus(13, 5, new Enums.FeatureTypes[] {Enums.FeatureTypes.INDOMITABLE2}, 0, null),
                new BaseProficiencyClassBonus(14, 5, new Enums.FeatureTypes[] {Enums.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new BaseProficiencyClassBonus(15, 5, new Enums.FeatureTypes[] {Enums.FeatureTypes.MARTIALARCHETYPEFEATURE}, 0, null),
                new BaseProficiencyClassBonus(16, 5, new Enums.FeatureTypes[] {Enums.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new BaseProficiencyClassBonus(17, 6, new Enums.FeatureTypes[] {Enums.FeatureTypes.ACTIONSURGE2, Enums.FeatureTypes.INDOMITABLE3}, 0, null),
                new BaseProficiencyClassBonus(18, 6, new Enums.FeatureTypes[] {Enums.FeatureTypes.MARTIALARCHETYPEFEATURE}, 0, null),
                new BaseProficiencyClassBonus(19, 6, new Enums.FeatureTypes[] {Enums.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new BaseProficiencyClassBonus(20, 6, new Enums.FeatureTypes[] {Enums.FeatureTypes.EXTRAATTACK3}, 0, null),
            };
            return table;
        }
    }
}
