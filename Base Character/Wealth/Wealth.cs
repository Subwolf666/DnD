using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class Wealth {

        public int pp { get; set; } // Platinum Pieces
        public int gp { get; set; } // Gold
        public int ep { get; set; } // Electrum
        public int sp { get; set; } // Silver
        public int cp { get; set; } // Copper

        public Wealth() {

        }

        public int StartingWealthClass(ClassTypes classType) {
            int funds;

            switch (classType) {
                case ClassTypes.CLERIC:
                    funds = StartingWealthCleric();
                    break;
                case ClassTypes.FIGHTER:
                    funds = StartingWealthFighter();
                    break;
                case ClassTypes.ROGUE:
                    funds = StartingWealthRogue();
                    break;
                case ClassTypes.WIZARD:
                    funds = StartingWealthWizard();
                    break;
                default:
                    funds = -1; // No funds...
                    break;
            }
            return funds;
        }

        private int StartingWealthCleric() {
            // Funds: 5D4 x 10 GP
            int funds = (20 * 10) * 100;
            return funds;
        }

        private int StartingWealthFighter() {
            // Funds: 5D4 x 10 GP
            int funds = (20 * 10) * 100;
            return funds;
        }

        private int StartingWealthRogue() {
            // Funds: 4D4 x 10 GP
            int funds = (16 * 10) * 100;
            return funds;
        }

        private int StartingWealthWizard() {
            // Funds: 4D4 x 10 GP
            int funds = (16 * 10) * 100;
            return funds;
        }
    }
}
