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
            if (i == j) 
            {
              Counter = int Counter + 1
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
          }
          if (Choice == ("Rethrow the remaining three die" || "Remaining three" || "Rethrow three remaining" || "Three" || "Remaining")
          {
            NewDie3 = int Roll();
            NewDie4 = int Roll();
            NewDie5 = int Roll();

            int[] UpdatedDieValues = {Die1, Die2, NewDie3, NewDie4, NewDie5};
            Console.WriteLine($"Your updated die values are: "};
            Console.WriteLine(UpdatedDieValues);
          }     
