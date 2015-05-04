using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public enum BaseSkill {
        ATHLETICS,
        ACROBATICS,
        SLEIGHTOFHAND,
        STEALTH,
        ARCANA,
        HISTORY,
        INVESTIGATION,
        NATURE,
        RELIGION,
        ANIMALHANDLING,
        INSIGHT,
        MEDICINE,
        PERCEPTION,
        SURVIVAL,
        DECEPTION,
        INTIMIDATION,
        PERFORMANCE,
        PERSUASION,
    }
    public class BaseSkills {

        public BaseSkill[] Skills { get; set; }

        public BaseSkills() { }

        public BaseSkills(BaseSkill[] skills) {

            Skills = skills;
        }

    }
}
