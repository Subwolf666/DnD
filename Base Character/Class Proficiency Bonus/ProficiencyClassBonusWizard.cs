using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class ProficiencyClassBonusWizard : BaseProficiencyClassBonus {

        public ProficiencyClassBonusWizard() { }

        public BaseProficiencyClassBonus[] PopulateProficiencyClassBonusWizard() {
            var table = new BaseProficiencyClassBonus[] {
                new BaseProficiencyClassBonus( 1, 2, new Enums.FeatureTypes[] {Enums.FeatureTypes.SPELLCASTING, Enums.FeatureTypes.ARCANERECOVERY}, 3, new int[] {2, 0, 0, 0, 0, 0, 0, 0, 0}),
                new BaseProficiencyClassBonus( 2, 2, new Enums.FeatureTypes[] {Enums.FeatureTypes.ARCANETRADITION},                           3, new int[] {3, 0, 0, 0, 0, 0, 0, 0, 0}),
                new BaseProficiencyClassBonus( 3, 2, new Enums.FeatureTypes[] {Enums.FeatureTypes.NONE},                                      3, new int[] {4, 2, 0, 0, 0, 0, 0, 0, 0}),
                new BaseProficiencyClassBonus( 4, 2, new Enums.FeatureTypes[] {Enums.FeatureTypes.ABILITYSCOREIMPROVEMENT},                   4, new int[] {4, 3, 0, 0, 0, 0, 0, 0, 0}),
                new BaseProficiencyClassBonus( 5, 3, new Enums.FeatureTypes[] {Enums.FeatureTypes.NONE},                                      4, new int[] {4, 3, 2, 0, 0, 0, 0, 0, 0}),
                new BaseProficiencyClassBonus( 6, 3, new Enums.FeatureTypes[] {Enums.FeatureTypes.ARCANETRADITIONFEATURE},                    4, new int[] {4, 3, 3, 0, 0, 0, 0, 0, 0}),
                new BaseProficiencyClassBonus( 7, 3, new Enums.FeatureTypes[] {Enums.FeatureTypes.NONE},                                      4, new int[] {4, 3, 3, 1, 0, 0, 0, 0, 0}),
                new BaseProficiencyClassBonus( 8, 3, new Enums.FeatureTypes[] {Enums.FeatureTypes.ABILITYSCOREIMPROVEMENT},                   4, new int[] {4, 3, 3, 2, 0, 0, 0, 0, 0}),
                new BaseProficiencyClassBonus( 9, 4, new Enums.FeatureTypes[] {Enums.FeatureTypes.NONE},                                      4, new int[] {4, 3, 3, 3, 1, 0, 0, 0, 0}),
                new BaseProficiencyClassBonus(10, 4, new Enums.FeatureTypes[] {Enums.FeatureTypes.ARCANETRADITIONFEATURE},                    5, new int[] {4, 3, 3, 3, 2, 0, 0, 0, 0}),
                new BaseProficiencyClassBonus(11, 4, new Enums.FeatureTypes[] {Enums.FeatureTypes.NONE},                                      5, new int[] {4, 3, 3, 3, 2, 1, 0, 0, 0}),
                new BaseProficiencyClassBonus(12, 4, new Enums.FeatureTypes[] {Enums.FeatureTypes.ABILITYSCOREIMPROVEMENT},                   5, new int[] {4, 3, 3, 3, 2, 1, 0, 0, 0}),
                new BaseProficiencyClassBonus(13, 5, new Enums.FeatureTypes[] {Enums.FeatureTypes.NONE},                                      5, new int[] {4, 3, 3, 3, 2, 1, 1, 0, 0}),
                new BaseProficiencyClassBonus(14, 5, new Enums.FeatureTypes[] {Enums.FeatureTypes.ARCANETRADITIONFEATURE},                    5, new int[] {4, 3, 3, 3, 2, 1, 1, 0, 0}),
                new BaseProficiencyClassBonus(15, 5, new Enums.FeatureTypes[] {Enums.FeatureTypes.NONE},                                      5, new int[] {4, 3, 3, 3, 2, 1, 1, 1, 0}),
                new BaseProficiencyClassBonus(16, 5, new Enums.FeatureTypes[] {Enums.FeatureTypes.ABILITYSCOREIMPROVEMENT},                   5, new int[] {4, 3, 3, 3, 2, 1, 1, 1, 0}),
                new BaseProficiencyClassBonus(17, 6, new Enums.FeatureTypes[] {Enums.FeatureTypes.NONE},                                      5, new int[] {4, 3, 3, 3, 2, 1, 1, 1, 1}),
                new BaseProficiencyClassBonus(18, 6, new Enums.FeatureTypes[] {Enums.FeatureTypes.SPELLMASTERY},                              5, new int[] {4, 3, 3, 3, 3, 1, 1, 1, 1}),
                new BaseProficiencyClassBonus(19, 6, new Enums.FeatureTypes[] {Enums.FeatureTypes.ABILITYSCOREIMPROVEMENT},                   5, new int[] {4, 3, 3, 3, 3, 2, 1, 1, 1}),
                new BaseProficiencyClassBonus(20, 6, new Enums.FeatureTypes[] {Enums.FeatureTypes.SIGNATURESPELL},                            5, new int[] {4, 3, 3, 3, 3, 2, 2, 1, 1}),
            };
            return table;
        }
    }
}
