using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Testing
    {
        public static void TestDie()
        {
            private Test = new Die();
            for (int i = 0, i < 1000; i++)
            {
                private int Result = Die.Roll();
                Debug.Assert(Result >= 1 && Result <=6, "Die roll out of range");
            }
        }

        public static void TestSeven()
        {
            private Test = new SevensOut();
            Debug.Assert(Test.GameOver(7), "Sevens out total score error");
            Debug.Assert(Test.GameOver(9), "Sevens out total score error");
            Debug.Assert(!Test.GameOver(6), "Sevens out total score error");
        }

        public static void TestThree()
        {
            private Test = new ThreeOrMore();
            Debug.Assert(Test.WinnerFound(20), "Three or more score error");
            Debug.Assert(Test.WinnerFound(24), "Three or more score error");
            Debug.Assert(!Test.WinnerFound(18), "Three or more score error");
        }
    }
}
