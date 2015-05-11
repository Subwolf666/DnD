using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public struct CharacterMoney {
        public int Platinum;
        public int Gold;
        public int Copper;
        public int Silver;

        public void SortCopper() {
            int copper = this.Copper;

            if (copper >= 1000) {
                this.Platinum = copper / 1000;
                copper -= this.Platinum * 1000;
            }
            if (copper >= 100) {
                this.Gold = copper / 100;
                copper -= this.Gold * 100;
            }
            if (copper >= 10) {
                this.Silver = copper / 10;
                copper -= this.Silver * 10;
            }
            this.Copper = copper;
        }
    }

    public class Wealth {

        public Wealth() {

        }

        public static CharacterMoney StartingWealthClass(Base_Character.ClassTypes classType) {
            CharacterMoney funds = new CharacterMoney();

            switch (classType) {
                case Base_Character.ClassTypes.Cleric:
                    funds.Copper = StartingWealthCleric();
                    break;
                case Base_Character.ClassTypes.Fighter:
                    funds.Copper = StartingWealthFighter();
                    break;
                case Base_Character.ClassTypes.Rogue:
                    funds.Copper = StartingWealthRogue();
                    break;
                case Base_Character.ClassTypes.Wizard:
                    funds.Copper = StartingWealthWizard();
                    break;
                default:
                    funds.Copper = -1; // No funds...
                    break;
            }
            funds.SortCopper();
            return funds;
        }

        private static int StartingWealthCleric() {
            // Funds: 5D4 x 10 GP
            int funds = (20 * 10) * 100;
            return funds;
        }

        private static int StartingWealthFighter() {
            // Funds: 5D4 x 10 GP
            int funds = (20 * 10) * 100;
            return funds;
        }

        private static int StartingWealthRogue() {
            // Funds: 4D4 x 10 GP
            int funds = (16 * 10) * 100;
            return funds;
        }

        private static int StartingWealthWizard() {
            // Funds: 4D4 x 10 GP
            int funds = (16 * 10) * 100;
            return funds;
        }
    }
}
