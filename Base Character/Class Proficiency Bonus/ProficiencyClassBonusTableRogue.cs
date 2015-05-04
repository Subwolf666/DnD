using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class ProficiencyClassBonusTableRogue : ProficiencyClassBonusTable {

        public ProficiencyClassBonusTableRogue() { }

        public ProficiencyClassBonusTable[] PopulateProficiencyClassBonusTableRogue() {
            var table = new ProficiencyClassBonusTable[] {
                new ProficiencyClassBonusTable( 1, 2, new FeatureTypes[] {FeatureTypes.FIGHTINGSTYLE, FeatureTypes.SECONDWIND}, 0, null),
                new ProficiencyClassBonusTable( 2, 2, new FeatureTypes[] {FeatureTypes.ACTIONSURGE1}, 0, null),
                new ProficiencyClassBonusTable( 3, 2, new FeatureTypes[] {FeatureTypes.MARTIALARCHETYPE}, 0, null),
                new ProficiencyClassBonusTable( 4, 2, new FeatureTypes[] {FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonusTable( 5, 3, new FeatureTypes[] {FeatureTypes.EXTRAATTACK}, 0, null),
                new ProficiencyClassBonusTable( 6, 3, new FeatureTypes[] {FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonusTable( 7, 3, new FeatureTypes[] {FeatureTypes.MARTIALARCHETYPEFEATURE}, 0, null),
                new ProficiencyClassBonusTable( 8, 3, new FeatureTypes[] {FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonusTable( 9, 4, new FeatureTypes[] {FeatureTypes.INDOMITABLE1}, 0, null),
                new ProficiencyClassBonusTable(10, 4, new FeatureTypes[] {FeatureTypes.MARTIALARCHETYPEFEATURE}, 0, null),
                new ProficiencyClassBonusTable(11, 4, new FeatureTypes[] {FeatureTypes.EXTRAATTACK2}, 0, null),
                new ProficiencyClassBonusTable(12, 4, new FeatureTypes[] {FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonusTable(13, 5, new FeatureTypes[] {FeatureTypes.INDOMITABLE2}, 0, null),
                new ProficiencyClassBonusTable(14, 5, new FeatureTypes[] {FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonusTable(15, 5, new FeatureTypes[] {FeatureTypes.MARTIALARCHETYPEFEATURE}, 0, null),
                new ProficiencyClassBonusTable(16, 5, new FeatureTypes[] {FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonusTable(17, 6, new FeatureTypes[] {FeatureTypes.ACTIONSURGE2, FeatureTypes.INDOMITABLE3}, 0, null),
                new ProficiencyClassBonusTable(18, 6, new FeatureTypes[] {FeatureTypes.MARTIALARCHETYPEFEATURE}, 0, null),
                new ProficiencyClassBonusTable(19, 6, new FeatureTypes[] {FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonusTable(20, 6, new FeatureTypes[] {FeatureTypes.EXTRAATTACK3}, 0, null),
            };
            return table;
        }
    }
}
