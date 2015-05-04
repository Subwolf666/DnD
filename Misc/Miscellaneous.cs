using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc {
    public class Miscellaneous {

        public ConsoleKey GetCharInput() {
            ConsoleKey response;    // Creates a variable to hold the user's response.
            do {
                while (Console.KeyAvailable) // Flushes the input queue.
                    Console.ReadKey();

                response = Console.ReadKey(true).Key;   // Get the user's response.
                //if (response == ConsoleKey.F) Console.WriteLine("Female");
                //else if (response == ConsoleKey.M) Console.WriteLine("Male");
            } while ((response != ConsoleKey.F) && (response != ConsoleKey.M)); // If the user did not respond with a 'Y' or an 'N', repeat the loop.

            return response;
        }

        public ConsoleKeyInfo GetNumberRange(int lowNumber, int highNumber) {
            ConsoleKeyInfo response;    // Creates a variable to hold the user's response.
            int iKeyPressed;
            bool bKeyPressed;

//            Console.Write("Choose a number [{0}, {1}]: ", lowNumber, highNumber);
            do {
                while (Console.KeyAvailable) // Flushes the input queue.
                    Console.ReadKey();

                response = Console.ReadKey(true);
                bKeyPressed = int.TryParse(response.KeyChar.ToString(), out iKeyPressed);
                if (bKeyPressed) {
                    if (iKeyPressed >= lowNumber && iKeyPressed <= highNumber) {
                        Console.WriteLine(response.KeyChar);
                    } else {
                        bKeyPressed = false;
                    }
                }
            } while (!bKeyPressed);
            return response;
        }

        public ConsoleKey GetYOrN() {

            ConsoleKey response;    // Creates a variable to hold the user's response.
            //Console.Write("Are you sure? [Y/N]: "); // Asks the user to answer with Yes or No.
            do {
                while (Console.KeyAvailable) // Flushes the input queue.
                    Console.ReadKey();

                response = Console.ReadKey(true).Key;   // Get the user's response.
                //if (response == ConsoleKey.Y) Console.WriteLine("Yes");
                //else if (response == ConsoleKey.N) Console.WriteLine("No");
            } while ((response != ConsoleKey.Y) && (response != ConsoleKey.N)); // If the user did not respond with a 'Y' or an 'N', repeat the loop.
            
            return response;
        }
    }
}
