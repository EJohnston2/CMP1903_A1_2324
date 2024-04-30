using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class ThreeOrMore
    {
      int Counter; 
      int PointCounter;
      
      public ThreeOrMore()
      {
        Die1 = int Roll();
        Die2 = int Roll();
        Die3 = int Roll():
        Die4 = int Roll();
        Die5 = int Roll();

        int[] DieValues = {Die1, Die2, Die3, Die4, Die5};

        Console.WriteLine($"Your die values are: ");
        Console.WriteLine(DieValues[]);

        for i in range(1, 6, 1)
        {
          for j in range((i+1), 6, 1)
          {
            if (DieValues[i] == DieValues[j]) 
            {
              Counter = int Counter + 1;
            }
          }
        }

        if (Counter == 2)
        {
          Console.WriteLine($"You have rolled two of the same values");
          Choice = Console.ReadLine($"Rethrow all die or rethrow the remaining three die?");
          if (Choice == ("Rethrow all die" || "Rethrow all" || "All"))
          {
            NewDie1 = int Roll();
            NewDie2 = int Roll();
            NewDie3 = int Roll();
            NewDie4 = int Roll();
            NewDie5 = int Roll();

            int[] NewDieValues = {NewDie1, NewDie2, NewDie3, NewDie4, NewDie5};
            Console.WriteLine($"Your new die values are: ");
            Console.WriteLine(NewDieValues[]);

            for c in range(1, 6, 1)
            {
              for d in range((c+1), 6, 1)
              {
                if (NewDieValues[c] == NewDieValues[d])
                {
                  Counter = int Counter + 1;
                }
              }
            }

            if (Counter == 3)
            {
              Console.WriteLine($"You have rolled three of the same!");
              Console.WriteLine($"Three points!!");
              PointCounter = int PointCounter + 3;
            }
            if (Counter == 4)
            {
              Console.WriteLine($"You have rolled four of the same!");
              Console.WriteLine($"Six points!!");
              PointCounter = int PointCounter + 6;
            }
            if (Counter == 5)
            {
              Console.WriteLine($"You have rolled five of the same!");
              Console.WriteLine($"Twelve points!!");
              PointCounter = int PointCounter + 12; 
            }
          }
          if (Choice == ("Rethrow the remaining three die" || "Remaining three" || "Rethrow three remaining" || "Three" || "Remaining"))
          {
            NewDie3 = int Roll();
            NewDie4 = int Roll();
            NewDie5 = int Roll();

            int[] UpdatedDieValues = {Die1, Die2, NewDie3, NewDie4, NewDie5};
            Console.WriteLine($"Your updated die values are: "};
            Console.WriteLine(UpdatedDieValues[]);

            for a in range(1, 6, 1)
            {
              for b in range((a+1), 6, 1)
              {
                if (UpdatedDieValues[a] == UpdatedDieValues[b])
                {
                  Counter = int Counter + 1;
                }  
              }
            }

            if (Counter == 3)
            {   
              Console.WriteLine($"You have rolled three of the same!");
              Console.WriteLine($"Three points!!");
              PointCounter = int PointCounter + 3;
            }
            if (Counter == 4)
            {
              Console.WriteLine($"You have rolled four of the same!");
              Console.WriteLine($"Six points!!");
              PointCounter = int PointCounter + 6;
            }
            if (Counter == 5)
            {
              Console.WriteLine($"You have rolled five of the same!");
              Console.WriteLine($"Twelve points!!");
              PointCounter = int PointCounter + 12;
            }
      }
      if (Counter == 3)
      {
        Console.WriteLine($"You have rolled three of the same!");
        Console.WriteLine($"Three points!!");
        PointCounter = int PointCounter + 3;
      }
      if (Counter == 4)
      {
        Console.WriteLine($"You have rolled four of the same!");
        Console.WriteLine($"Six points!!");
        PointCounter = int PointCounter + 6;
      }
      if (Counter == 5)
      {
        Console.WriteLine($"You have rolled five of the same!");
        Console.WriteLine($"Twelve points!!");
        PointCounter = int PointCounter + 12;
			}

	 		Console.WriteLine($"You have scored " + {str PointCounter} + " points!");
			if (int PointCounter >= 20)
			{
				Console.WriteLine($"You have reached 20!");
				Console.WriteLine($"Winner!");
			}

	   }										
   }
}
}
															
                              
                              
                              
