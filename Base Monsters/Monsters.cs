using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Monsters {
    public class Monsters {
        public static BaseMonsterSheet[] MonstersList { get { return PopulateMonsters(); } }
        private static BaseMonsterSheet[] PopulateMonsters() {
            var to_return = new BaseMonsterSheet[] {
            // Level 1 Monsters
                new BaseMonsterSheet(Enums.MONSTER_ID_HALFLINGSLINGER, "Halfling Slinger", 1, Role.Artillery, Size.Small, Origin.Natural, Type.Humanoid, Keywords.None, 100, 4, Senses.Perception, 5, Aura.None, 22, 22, 15, 12, 15, 13, 5, SavingThrowEffect.AgainstFear, 6),
            };
            return to_return;
        }
    }
}
