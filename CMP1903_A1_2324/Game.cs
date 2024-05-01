using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
      int SevensPlayed;
      int SevensPlayer1Win;
      int SevensPlayer2Win;
      int SevensPlayerDraw;
      int SevensHigh = 0;
      int ThreePlayed;
      int ThreePlayer1Win;
      int ThreePlayer2Win;
      int ThreePlayerDraw;
      int ThreeHigh = 0;
      bool Condition = True;
      
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
          Console.WriteLine($"Round 1");
          SevensOut();
          Score = int SevensOut.Total;
          if (Score > SevensHigh)
          {
            SevensHigh = int Score;
          }
          SevensPlayed = int SevensPlayed + 1;
          while (Condition == True)
          {
            RoundChoice = Console.ReadLine($"Another round? (yes/no)");
            if (RoundChoice == ("yes" || "Yes"))
            {
              SevensOut();
              Score = int SevensOut.Total;
              if (Score > SevensHigh)
              {
                SevensHigh = int Score;
              }
              SevensPlayed = int SevensPlayed + 1;
            }
            if (RoundChoice == ("no" || "No"))
            {
              Condition = False;
            }
          }  
        }
        if (PartnerChoice == "Partner")
        {
          Console.WriteLine($"Player 1");
          SevensOut();
          SevensPlayed = int SevensPlayed + 1; 
          Player1Score = SevensOut.Total;
          if (Player1Score > SevensHigh)
          {
            SevensHigh = int Player1Score;
          }
          Console.WriteLine($"Player 2");
          SevensOut();
          SevensPlayed = int SevensPlayed + 1;
          Player2Score = SevensOut.Total;
          if (Player2Score > SevensHigh)
          {
            SevensHigh = int Player2Score;
          }
          if (Player1Score > Player2Score)
          {
            Console.WriteLine($"Player 1 wins!!");
            SevensPlayer1Win = int SevensPlayer1Win + 1;
          }
          if (Player1Score == Player2Score)
          {
            Console.WriteLine($"It is a draw!!");
            SevensPlayerDraw == int SevensPlayerDraw + 1;
          }
          if (Player1Score < Player2Score)
          {
            Console.WriteLine($"Player 2 wins!!");
            SevensPlayer2Win = int SevensPlayer2Win + 1;
          }
        }
      }
      
      if (GameChoice == 2)
      {
        Console.WriteLine($"You have chosen the Three or more game");
        PartnerChoice = Console.WriteLine($"Solo or partner play?");
        if (PartnerChoice == "Solo")
        {
          Console.WriteLine($"Round 1");
          ThreeOrMore();
          Score = int ThreeOrMore.PointCounter;
          if (Score > ThreeHigh)
          {
            ThreeHigh = int Score;
          }
          ThreePlayed = int ThreePlayed + 1;
          while (Condition == True)
          {
            RoundChoice = Console.ReadLine($"Another round? (yes/no)");
            if (RoundChoice == ("yes" || "Yes"))
            {
              ThreeOrMore();
              ThreePlayed = int ThreePlayed + 1;
            }
            if (RoundChoice == ("no" || "No"))
            {
              Condition = False;
            }
          }      
        }
        if (PartnerChoice == "Partner")
        {
          Console.WriteLine($"Player 1");
          ThreeOrMore();
          ThreePlayed = int ThreePlayed + 1;
          Player1Score = ThreeOrMore.PointCounter;
          if (Player1Score > ThreeHigh)
          {
            ThreeHigh = int Player1Score;
          }
          Console.WriteLine($"Player 2");
          ThreeOrMore();
          ThreePlayed = int ThreePlayed + 1;
          Player2Score = ThreeOrMore.PointCounter;
          if (Player2Score > ThreeHigh)
          {
            ThreeHigh = int Player2Score;
          }
          if (Player1Score > Player2Score)
          {
            Console.WriteLine($"Player 1 wins!!");
            ThreePlayer1Win = int ThreePlayer1Win + 1;
          }
          if (Player1Score == Player2Score)
          {
            Console.WriteLine($"It is a draw!!");
            ThreePlayerDraw = int ThreePlayerDraw + 1;
          }
          if (Player1Score < Player2Score)
          {
            Console.WriteLine($"Player 2 wins!!");
            ThreePlayer2Win = int ThreePlayer2Win + 1;
          }
        }
      }

      if (GameChoice == 3)
      {
        Console.WriteLine($"Displaying game statistics");
        Stats();
      }

      if (GameChoice == 4)
      {
        Console.WriteLine($"Running game tests...");
      }

    }
}
