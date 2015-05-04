using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class ProficiencyClassBonusTableWizard : ProficiencyClassBonusTable {

        public ProficiencyClassBonusTableWizard() { }

        public ProficiencyClassBonusTable[] PopulateProficiencyClassBonusTableWizard() {
            var table = new ProficiencyClassBonusTable[] {
                new ProficiencyClassBonusTable( 1, 2, new FeatureTypes[] {FeatureTypes.SPELLCASTING, FeatureTypes.ARCANERECOVERY}, 3, new int[] {2, 0, 0, 0, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonusTable( 2, 2, new FeatureTypes[] {FeatureTypes.ARCANETRADITION},                           3, new int[] {3, 0, 0, 0, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonusTable( 3, 2, new FeatureTypes[] {FeatureTypes.NONE},                                      3, new int[] {4, 2, 0, 0, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonusTable( 4, 2, new FeatureTypes[] {FeatureTypes.ABILITYSCOREIMPROVEMENT},                   4, new int[] {4, 3, 0, 0, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonusTable( 5, 3, new FeatureTypes[] {FeatureTypes.NONE},                                      4, new int[] {4, 3, 2, 0, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonusTable( 6, 3, new FeatureTypes[] {FeatureTypes.ARCANETRADITIONFEATURE},                    4, new int[] {4, 3, 3, 0, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonusTable( 7, 3, new FeatureTypes[] {FeatureTypes.NONE},                                      4, new int[] {4, 3, 3, 1, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonusTable( 8, 3, new FeatureTypes[] {FeatureTypes.ABILITYSCOREIMPROVEMENT},                   4, new int[] {4, 3, 3, 2, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonusTable( 9, 4, new FeatureTypes[] {FeatureTypes.NONE},                                      4, new int[] {4, 3, 3, 3, 1, 0, 0, 0, 0}),
                new ProficiencyClassBonusTable(10, 4, new FeatureTypes[] {FeatureTypes.ARCANETRADITIONFEATURE},                    5, new int[] {4, 3, 3, 3, 2, 0, 0, 0, 0}),
                new ProficiencyClassBonusTable(11, 4, new FeatureTypes[] {FeatureTypes.NONE},                                      5, new int[] {4, 3, 3, 3, 2, 1, 0, 0, 0}),
                new ProficiencyClassBonusTable(12, 4, new FeatureTypes[] {FeatureTypes.ABILITYSCOREIMPROVEMENT},                   5, new int[] {4, 3, 3, 3, 2, 1, 0, 0, 0}),
                new ProficiencyClassBonusTable(13, 5, new FeatureTypes[] {FeatureTypes.NONE},                                      5, new int[] {4, 3, 3, 3, 2, 1, 1, 0, 0}),
                new ProficiencyClassBonusTable(14, 5, new FeatureTypes[] {FeatureTypes.ARCANETRADITIONFEATURE},                    5, new int[] {4, 3, 3, 3, 2, 1, 1, 0, 0}),
                new ProficiencyClassBonusTable(15, 5, new FeatureTypes[] {FeatureTypes.NONE},                                      5, new int[] {4, 3, 3, 3, 2, 1, 1, 1, 0}),
                new ProficiencyClassBonusTable(16, 5, new FeatureTypes[] {FeatureTypes.ABILITYSCOREIMPROVEMENT},                   5, new int[] {4, 3, 3, 3, 2, 1, 1, 1, 0}),
                new ProficiencyClassBonusTable(17, 6, new FeatureTypes[] {FeatureTypes.NONE},                                      5, new int[] {4, 3, 3, 3, 2, 1, 1, 1, 1}),
                new ProficiencyClassBonusTable(18, 6, new FeatureTypes[] {FeatureTypes.SPELLMASTERY},                              5, new int[] {4, 3, 3, 3, 3, 1, 1, 1, 1}),
                new ProficiencyClassBonusTable(19, 6, new FeatureTypes[] {FeatureTypes.ABILITYSCOREIMPROVEMENT},                   5, new int[] {4, 3, 3, 3, 3, 2, 1, 1, 1}),
                new ProficiencyClassBonusTable(20, 6, new FeatureTypes[] {FeatureTypes.SIGNATURESPELL},                            5, new int[] {4, 3, 3, 3, 3, 2, 2, 1, 1}),
            };
            return table;
        }
    }
}
