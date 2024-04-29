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
        
        public int Roll(Random _rand)
        {
            RollValue = int _rand.Next(1, 7, 1);
            return RollValue;
        }

    //simulates a dice roll
    //creates a random number between 1 to 6
    }
}
