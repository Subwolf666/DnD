using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class ProficiencyClassBonus {

        public int Level { get; set; }
        public int ProficiencyBonus { get; set; }
        public FeatureTypes[] Features { get; set; }
        public int CantripsKnown { get; set; }
        public int[] SpellSlotsPerSpellLevel { get; set; }
        
        public ProficiencyClassBonus() { }

        public ProficiencyClassBonus(int level, int proficiencyBonus, FeatureTypes[] features, int cantripsKnown, int[] spellSlotsPerSpellLevel) {
            Level = level;
            ProficiencyBonus = proficiencyBonus;
            Features = features;
            CantripsKnown = cantripsKnown;
            SpellSlotsPerSpellLevel = spellSlotsPerSpellLevel;
        }
    }
}
