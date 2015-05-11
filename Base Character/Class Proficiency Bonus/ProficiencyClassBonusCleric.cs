using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class ProficiencyClassBonusCleric : ProficiencyClassBonus {

        public ProficiencyClassBonusCleric() { }

        public ProficiencyClassBonus[] PopulateProficiencyClassBonusCleric() {
            var table = new ProficiencyClassBonus[] {
                new ProficiencyClassBonus( 1, 2, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.SPELLCASTING,     Base_Character.FeatureTypes.DIVINEDOMAIN},        3, new int[] {2, 0, 0, 0, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonus( 2, 2, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.CHANNELDIVINITY1, Base_Character.FeatureTypes.DIVINEDOMAINFEATURE}, 3, new int[] {3, 0, 0, 0, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonus( 3, 2, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.NONE},                                               3, new int[] {4, 2, 0, 0, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonus( 4, 2, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ABILITYSCOREIMPROVEMENT},                            4, new int[] {4, 3, 0, 0, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonus( 5, 3, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.DESTROYUNDEAD12},                                    4, new int[] {4, 3, 2, 0, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonus( 6, 3, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.CHANNELDIVINITY2, Base_Character.FeatureTypes.DIVINEDOMAINFEATURE}, 4, new int[] {4, 3, 3, 0, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonus( 7, 3, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.NONE},                                               4, new int[] {4, 3, 3, 1, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonus( 8, 3, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ABILITYSCOREIMPROVEMENT, Base_Character.FeatureTypes.DESTROYUNDEAD1, Base_Character.FeatureTypes.DIVINEDOMAINFEATURE}, 4, new int[] {4, 3, 3, 2, 0, 0, 0, 0, 0}),
                new ProficiencyClassBonus( 9, 4, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.NONE},                                               4, new int[] {4, 3, 3, 3, 1, 0, 0, 0, 0}),
                new ProficiencyClassBonus(10, 4, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.DIVINEINTERVENTION},                                 5, new int[] {4, 3, 3, 3, 2, 0, 0, 0, 0}),
                new ProficiencyClassBonus(11, 4, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.DESTROYUNDEAD2},                                     5, new int[] {4, 3, 3, 3, 2, 1, 0, 0, 0}),
                new ProficiencyClassBonus(12, 4, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ABILITYSCOREIMPROVEMENT},                            5, new int[] {4, 3, 3, 3, 2, 1, 0, 0, 0}),
                new ProficiencyClassBonus(13, 5, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.NONE},                                               5, new int[] {4, 3, 3, 3, 2, 1, 1, 0, 0}),
                new ProficiencyClassBonus(14, 5, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.DESTROYUNDEAD3},                                     5, new int[] {4, 3, 3, 3, 2, 1, 1, 0, 0}),
                new ProficiencyClassBonus(15, 5, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.NONE},                                               5, new int[] {4, 3, 3, 3, 2, 1, 1, 1, 0}),
                new ProficiencyClassBonus(16, 5, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ABILITYSCOREIMPROVEMENT},                            5, new int[] {4, 3, 3, 3, 2, 1, 1, 1, 0}),
                new ProficiencyClassBonus(17, 6, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.DESTROYUNDEAD4, Base_Character.FeatureTypes.DIVINEDOMAINFEATURE},   5, new int[] {4, 3, 3, 3, 2, 1, 1, 1, 1}),
                new ProficiencyClassBonus(18, 6, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.CHANNELDIVINITY3},                                   5, new int[] {4, 3, 3, 3, 3, 1, 1, 1, 1}),
                new ProficiencyClassBonus(19, 6, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ABILITYSCOREIMPROVEMENT},                            5, new int[] {4, 3, 3, 3, 3, 2, 1, 1, 1}),
                new ProficiencyClassBonus(20, 6, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.DIVINEINTERVENTIONIMPROVEMENT},                      5, new int[] {4, 3, 3, 3, 3, 2, 2, 1, 1}),
            };
            return table;
        }
    }
}
