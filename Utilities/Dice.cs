using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities {
    public static class Dice {
        private static Random randomGenerator = new Random();

        /// <summary>
        /// Pass a die roll string in any standard d20-type format, including 
        /// parenthetical rolls, and it will output a string breaking down each 
        /// roll as well as summing the total. This works very nicely. The code was
        /// hacked from java code from Malar's RPG Dice Version 0.9 By Simon Cederqvist 
        /// (simon.cederqvist(INSERT AT HERE) gmail.com). 13.March.2007
        /// http://users.tkk.fi/~scederqv/Dice/
        /// His same license still applies to this code. But if you figure out how to
        /// make a million dollars off this code, then you're smarter than me and 
        /// you deserve to keep it.  On the other hand, share and share alike. 
        /// </summary>
        /// <param name="diceString">This is a standard d20 die roll string, parenthesis 
        /// are allowed. Example Input: (2d8+9)+(3d6+1)-10</param>
        /// <returns>A string breaking down and summing the roll. Example Output: 
        /// (2d8+9)+(3d6+1)-10 = 7+4+9+5+1+2+1-10 = 20+9-10 = 19</returns>
        public static int Roll(string diceString) {
            StringBuilder finalResultBuilder = new StringBuilder();
            string tempString = "";
            int intermediateTotal = 0;
            ArrayList sums = new ArrayList();
            ArrayList items = new ArrayList();
            ArrayList dice = new ArrayList();
            int totals = 0;
            bool collate = false;
            bool positive = true;
            string validChars = "1234567890d";
            char[] diceCharArray = diceString.ToLower().ToCharArray();

            for (int i = 0; i < diceString.Length; i++) {
                switch (diceCharArray[i]) {
                    case '+': {
                            if (tempString.Length < 1) {
                                positive = true;
                                break;
                            }
                            dice = calcSubStringRoll(tempString);
                            for (int j = 0; j < dice.Count; j++) {
                                if (!positive) {
                                    items.Add(-1 * Convert.ToInt32(dice[j].ToString()));
                                    intermediateTotal += (-1 * Convert.ToInt32(dice[j].ToString()));
                                } else {
                                    items.Add(Convert.ToInt32(dice[j].ToString()));
                                    intermediateTotal += (Convert.ToInt32(dice[j].ToString()));
                                }
                            }
                            if (!collate) {
                                sums.Add(intermediateTotal);
                                intermediateTotal = 0;
                            }
                            positive = true;
                            tempString = "";
                            break;
                        }
                    case '-': {
                            if (tempString.Length < 1) {
                                positive = false;
                                break;
                            }
                            dice = calcSubStringRoll(tempString);
                            for (int j = 0; j < dice.Count; j++) {
                                if (!positive) {
                                    items.Add(-1 * Convert.ToInt32(dice[j].ToString()));
                                    intermediateTotal += (-1 * Convert.ToInt32(dice[j].ToString()));
                                } else {
                                    items.Add(Convert.ToInt32(dice[j].ToString()));
                                    intermediateTotal += (Convert.ToInt32(dice[j].ToString()));
                                }
                            }
                            if (!collate) {
                                sums.Add(intermediateTotal);
                                intermediateTotal = 0;
                            }
                            positive = false;
                            tempString = "";
                            break;
                        }
                    case '(': collate = true; break;
                    case ')': collate = false; break;
                    default: {
                            if (validChars.Contains("" + diceCharArray[i]))
                                tempString += diceCharArray[i];
                            break;
                        }
                }
            }

            // And once more for the remaining text
            if (tempString.Length > 0) {
                dice = calcSubStringRoll(tempString);

                for (int j = 0; j < dice.Count; j++) {
                    if (!positive) {
                        items.Add(-1 * Convert.ToInt32(dice[j].ToString()));
                        intermediateTotal += (-1 * Convert.ToInt32(dice[j].ToString()));
                    } else {
                        items.Add(Convert.ToInt32(dice[j].ToString()));
                        intermediateTotal += (Convert.ToInt32(dice[j].ToString()));
                    }
                }
                sums.Add(intermediateTotal);
//RW                intermediateTotal = 0;
            }

            //// Print it all.
            finalResultBuilder.Append(diceString + " = ");
            for (int i = 0; i < items.Count; i++) {
                if (Convert.ToInt32(items[i].ToString()) > 0 && i > 0)
                    finalResultBuilder.Append("+" + items[i].ToString());
                else
                    finalResultBuilder.Append(items[i].ToString());
            }
            if (sums.Count > 1 && items.Count > sums.Count) { // Don't print just one, or items again.
                finalResultBuilder.Append(" = ");
                for (int i = 0; i < sums.Count; i++) {
                    if (Convert.ToInt32(sums[i].ToString()) > 0 && i > 0)
                        finalResultBuilder.Append("+" + sums[i].ToString());
                    else
                        finalResultBuilder.Append(sums[i].ToString());
                }
            }
            for (int i = 0; i < sums.Count; i++)
                totals += Convert.ToInt32(sums[i].ToString());
            finalResultBuilder.Append(" = " + totals + "\n");

//RW            return finalResultBuilder.ToString();
            return intermediateTotal;
        }


        /// <summary>
        /// Rolls the specified number of die each with the specified number of
        /// sides and returns the numeric result as a string.  
        /// </summary>
        /// <param name="numberOfDice">The number of die to roll.</param>
        /// <param name="numberOfSides">The number of faces on each dice rolled.</param>
        /// <param name="rollMod"></param>
        /// <returns>A string containing the result of the roll.</returns>
        public static int Roll(int numberOfDice, int numberOfSides, int rollMod) {
            // don't allow a Number of Dice less than or equal to zero
            if (numberOfDice <= 0)
                throw new ApplicationException("Number of die must be greater than zero.");

            // don't allow a Number of Sides less than or equal to zero
            if (numberOfSides <= 0)
                throw new ApplicationException("Number of sides must be greater than zero.");

            // Declare the integer in which we will keep the total of the rolls
            int total = 0;

            // repeat once for each number of dice
            for (int i = 0; i < numberOfDice; i++) {
                // Create the random class used to generate random numbers.
                // See: http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpref/html/frlrfSystemRandomClassTopic.asp

                // Get a pseudo-random result for this roll
                int roll = randomGenerator.Next(1, numberOfSides);

                // Add the result of this roll to the total
                total += roll;

                //// Add the result of this roll to the string builder
                //result.AppendFormat("Dice {0:00}:\t{1}\n", i + 1, roll);
            }

            return (total + rollMod);

            //// Add a line to the result to seperate the rolls from the total
            //result.Append("\t\t--\n");

            //// Add the total to the result
            //result.AppendFormat("TOTAL:\t\t{0}\n", total);

            //// Now that we've finished building the result, get the string
            //// that we've been building and return it.
            //return result.ToString();            

        }

        /// <summary>
        /// This function merely breaks down the *basic* die roll string
        /// into the requsite integers. It is used by the above Roll(string) 
        /// method. 
        /// </summary>
        /// <param name="s">A simple die roll string, such as 3d6. Nothing more.</param>
        /// <returns>Returns an ArrayList of int's containing the various die
        /// rolls as passed in as a parameter.</returns>
        public static ArrayList calcSubStringRoll(string s) {
            int x, d;
            ArrayList dice = new ArrayList();
            if (s.Contains("d")) {
                x = Convert.ToInt32(s.Split('d')[0]);
                d = Convert.ToInt32(s.Split('d')[1]);

                // I loop here so that each roll is added to the ArrayList, and 
                // therefore works properly with the code I hacked from java above. 
                // in the dice i want (RW) we need to multiply the d with the dice roll. so no adding up dices.

                for (int i = 0; i < x; i++)
                    dice.Add(Dice.Roll(1, d, 0));
            } else
                dice.Add(Convert.ToInt32(s));

            return dice;
        }
    }
}