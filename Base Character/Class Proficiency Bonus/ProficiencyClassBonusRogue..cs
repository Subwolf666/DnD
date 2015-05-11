using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class ProficiencyClassBonusRogue : ProficiencyClassBonus {

        public ProficiencyClassBonusRogue() { }

        public ProficiencyClassBonus[] PopulateProficiencyClassBonusRogue() {
            var table = new ProficiencyClassBonus[] {
                new ProficiencyClassBonus( 1, 2, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.FIGHTINGSTYLE, Base_Character.FeatureTypes.SECONDWIND}, 0, null),
                new ProficiencyClassBonus( 2, 2, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ACTIONSURGE1}, 0, null),
                new ProficiencyClassBonus( 3, 2, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.MARTIALARCHETYPE}, 0, null),
                new ProficiencyClassBonus( 4, 2, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonus( 5, 3, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.EXTRAATTACK}, 0, null),
                new ProficiencyClassBonus( 6, 3, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonus( 7, 3, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.MARTIALARCHETYPEFEATURE}, 0, null),
                new ProficiencyClassBonus( 8, 3, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonus( 9, 4, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.INDOMITABLE1}, 0, null),
                new ProficiencyClassBonus(10, 4, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.MARTIALARCHETYPEFEATURE}, 0, null),
                new ProficiencyClassBonus(11, 4, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.EXTRAATTACK2}, 0, null),
                new ProficiencyClassBonus(12, 4, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonus(13, 5, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.INDOMITABLE2}, 0, null),
                new ProficiencyClassBonus(14, 5, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonus(15, 5, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.MARTIALARCHETYPEFEATURE}, 0, null),
                new ProficiencyClassBonus(16, 5, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonus(17, 6, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ACTIONSURGE2, Base_Character.FeatureTypes.INDOMITABLE3}, 0, null),
                new ProficiencyClassBonus(18, 6, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.MARTIALARCHETYPEFEATURE}, 0, null),
                new ProficiencyClassBonus(19, 6, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.ABILITYSCOREIMPROVEMENT}, 0, null),
                new ProficiencyClassBonus(20, 6, new Base_Character.FeatureTypes[] {Base_Character.FeatureTypes.EXTRAATTACK3}, 0, null),
            };
            return table;
        }
    }
}
