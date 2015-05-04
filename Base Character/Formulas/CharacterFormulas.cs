using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class CharacterFormulas {

        public int CalcMaximumHitPoints(BaseCharacterSheet baseCharacter) {
            int maximumHitPoints;

            maximumHitPoints = baseCharacter.CharacterClass.ClassFeaturesHitPointsHitPointsAt1stLevel + baseCharacter.CharacterAbilityModifiers.Constitution;

            return maximumHitPoints;
        }

        public int CalcArmorClass() {
            // Depending on the armor you wear, you might add some or all of your Dexterity modifier to your Armor Class, as described in chapter 5.

            return 0;
        }
    }
}
