using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseProficiencyClassBonus {

        public int Level { get; set; }
        public int ProficiencyBonus { get; set; }
        public Enums.FeatureTypes[] Features { get; set; }
        public int CantripsKnown { get; set; }
        public int[] SpellSlotsPerSpellLevel { get; set; }
        
        public BaseProficiencyClassBonus() { }

        public BaseProficiencyClassBonus(int level, int proficiencyBonus, Enums.FeatureTypes[] features, int cantripsKnown, int[] spellSlotsPerSpellLevel) {
            Level = level;
            ProficiencyBonus = proficiencyBonus;
            Features = features;
            CantripsKnown = cantripsKnown;
            SpellSlotsPerSpellLevel = spellSlotsPerSpellLevel;
        }
    }
}
