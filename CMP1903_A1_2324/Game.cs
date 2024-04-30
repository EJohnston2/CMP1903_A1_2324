using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        Console.WriteLine($"Games menu:");
        Console.WriteLine($"1. Seven's out game");
        Console.WriteLine($"2. Three or more game");
        Console.WriteLine($"3. View stats");
        Console.WriteLine($"4. Tests");
        
        int GameChoice = Console.ReadLine($"Enter your selection");

        if (GameChoice == 1)
        {
            Console.WriteLine($"You have chosen the Seven's out game");
            PartnerChoice = Console.ReadLine($"Solo or partner play?");
            if (PartnerChoice == "Solo")
            {
                
            }
        }

    }
}
