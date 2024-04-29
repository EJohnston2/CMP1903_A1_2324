using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class SevensOut
    {
        int Total; 

        public SevensOut()
        {
            Die1 = int Roll();
            Die2 = int Roll();
            Console.WriteLine($"Value of Die 1 is: {str Die1}");
            Console.WriteLine($"Value of Die 2 is: {str Die2}");
            if (int Die1 == int Die2)
            {
                Console.WriteLine($"You rolled a double!");
                Die1 = int Die1 * 2;
                Die2 = int Die2 * 2;
            }
            Total = int Die1 + int Die2;
            Console.WriteLine($"Total of both die is: {str Total}");
            if (int Total == 7)
            {
                Console.WriteLine($"You're total is 7- Game over!!");
                Quit();
            }

        }

    }
}
