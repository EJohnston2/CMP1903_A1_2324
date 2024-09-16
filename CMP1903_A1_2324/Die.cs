using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        int RollValue;
        int Total;

        public int Roll(Random _rand)
        { 
            RollValue1 = int _rand.Next(1, 7, 1);
            Console.WriteLine($"Value of Die 1 is: {str RollValue1}");
            RollValue2 = int _rand.Next(1, 7, 1);
            Console.WriteLine($"Value of Die 2 is: {str RollValue2}");
            if (int RollValue1 == int RollValue2)
            {
                Console.WriteLine($"You rolled doubles!");
                RollValue1 = int RollValue1 * 2;
                RollValue2 = int RollValue2 * 2;
            }
            Total = int RollValue1 + int RollValue2;
            Console.WriteLine($"Total of both die is: {str Total}");
            if (int Total == 7)
            {
                Console.WriteLine($"End of Game");
                Quit();
            }
        }

        //simulates two die rolls
        //produces a random value between 1 and 6
        //returns the value of both of the die
        //if the die are equal, the total is doubled
        //die values are added to find a total
        //returns the value of the total
        //if total equals to 7, code breaks

        
    }
}
