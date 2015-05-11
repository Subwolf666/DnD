using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;

namespace Base_Character {
    public class CharacterFormulas {
        public static DiceBag bag = new DiceBag();

        // Hit Dice, Current Level, Constitution modifier
        public static int CalcMaximumHitPoints(DiceBag.Dice hitDie, int level, int constModifier) {
            int maximumHitPoints = 0;

            if (level == 1) {
                maximumHitPoints = (int)hitDie + constModifier;
            } else {
                for (int i = 1; i < level; i++) {
                    maximumHitPoints += bag.Roll(hitDie) + constModifier;
                }
            }
            return maximumHitPoints;
        }

        public static int CalcArmorClass() {
            // Depending on the armor you wear, you might add some or all of your Dexterity modifier to your Armor Class, as described in chapter 5.

            return 0;
        }

        public static int[] DetermineAbilityModifier(int[] score) {
            int[] modifier = { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < score.Length - 1; i++) {
                switch (score[i]) {
                    case 1:
                        modifier[i] = -5;
                        break;
                    case 2:
                    case 3:
                        modifier[i] = -4;
                        break;
                    case 4:
                    case 5:
                        modifier[i] = -3;
                        break;
                    case 6:
                    case 7:
                        modifier[i] = -2;
                        break;
                    case 8:
                    case 9:
                        modifier[i] = -1;
                        break;
                    case 10:
                    case 11:
                        modifier[i] = 0;
                        break;
                    case 12:
                    case 13:
                        modifier[i] = +1;
                        break;
                    case 14:
                    case 15:
                        modifier[i] = +2;
                        break;
                    case 16:
                    case 17:
                        modifier[i] = +3;
                        break;
                    case 18:
                    case 19:
                        modifier[i] = +4;
                        break;
                    case 20:
                    case 21:
                        modifier[i] = +5;
                        break;
                    case 22:
                    case 23:
                        modifier[i] = +6;
                        break;
                    case 24:
                    case 25:
                        modifier[i] = +7;
                        break;
                    case 26:
                    case 27:
                        modifier[i] = +8;
                        break;
                    case 28:
                    case 29:
                        modifier[i] = +9;
                        break;
                    case 30:
                        modifier[i] = +10;
                        break;
                    default:
                        modifier[i] = 0;
                        break;
                }
            }
            return modifier;

        }
        public static int DetermineAbilityModifier(int score) {
            int modifier = 0;

            switch (score) {
                case 1:
                    modifier = -5;
                    break;
                case 2:
                case 3:
                    modifier = -4;
                    break;
                case 4:
                case 5:
                    modifier = -3;
                    break;
                case 6:
                case 7:
                    modifier = -2;
                    break;
                case 8:
                case 9:
                    modifier = -1;
                    break;
                case 10:
                case 11:
                    modifier = 0;
                    break;
                case 12:
                case 13:
                    modifier = +1;
                    break;
                case 14:
                case 15:
                    modifier = +2;
                    break;
                case 16:
                case 17:
                    modifier = +3;
                    break;
                case 18:
                case 19:
                    modifier = +4;
                    break;
                case 20:
                case 21:
                    modifier = +5;
                    break;
                case 22:
                case 23:
                    modifier = +6;
                    break;
                case 24:
                case 25:
                    modifier = +7;
                    break;
                case 26:
                case 27:
                    modifier = +8;
                    break;
                case 28:
                case 29:
                    modifier = +9;
                    break;
                case 30:
                    modifier = +10;
                    break;
                default:
                    modifier = 0;
                    break;
            }
            return modifier;

        }
    }
}
