using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class SevensOut
    { 
        public SevensOut()
        {
            public int Total;
            
            private Die1 = int Roll();
            private Die2 = int Roll();
            Console.WriteLine($"Value of Die 1 is: {str Die1}");
            Console.WriteLine($"Value of Die 2 is: {str Die2}");
            if (int Die1 == int Die2)
            {
                Console.WriteLine($"You rolled a double!");
                private Die1 = int Die1 * 2;
                private Die2 = int Die2 * 2;
            }
            public Total = int Die1 + int Die2;
            Console.WriteLine($"Total of both die is: {str Total}");
            if (int Total == 7)
            {
                public Total = 0
                Console.WriteLine($"You're total is 7- Game over!!");
                Quit();
            }

            public bool GameOver(int Total)
            {
                return Total >= 7;
            }

        }

    }
}

//simulates two die rolls
//returns value of both 
//returns total of both die
//if die are equal, total is doubled
//if total equals 7, game is ended
