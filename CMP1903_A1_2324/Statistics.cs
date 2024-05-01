using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Statistics
    {
      public Stats()
      {
        Console.WriteLine($"Displaying game statistics: ");
        
        Console.WriteLine($"Seven's Out statistics: ");
        Console.WriteLine($"Amount of games played: " + {str Game.SevensPlayed});
        Console.WriteLine($"Number of Player 1 wins: " + {str Game.SevensPlayer1Win});
        Console.WriteLine($"Number of Player 2 wins: " + {str Game.SevensPlayer2Win});
        Console.WriteLine($"Number of draws: " + {str Game.SevensPlayerDraw});
        Console.WriteLine($"High score: " + {str Game.SevensHigh});

        Console.WriteLine($"Three or more statistics");
        Console.WriteLine($"Amount of games played: " + {str Game.ThreePlayed});
        Console.WriteLine($"Number of Player 1 wins: " + {str Game.ThreePlayer1Win});
        Console.WriteLine($"Number of Player 2 wins: " + {str Game.ThreePlayer2Win});
        Console.WriteLine($"Number of draws: " + {str Game.ThreePlayerDraw});
        Console.WriteLine($"High score: " + {str Game.ThreeHigh});
      }  
    }
}
