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
            private TestDie = new Die();
            for (int i = 0, i < 1000; i++)
            {
                private int Result = Die.Roll();
                Debug.Assert(Result >= 1 && Result <=6, "Die roll out of range");
            }
        }

        public static void TestSeven()
        {
            private TestSeven = new SevensOut();
            Debug.Assert(TestSeven.GameOver(7), "Sevens out total score error");
            Debug.Assert(TestSeven.GameOver(9), "Sevens out total score error");
            Debug.Assert(!TestSeven.GameOver(6), "Sevens out total score error");
        }

        public static void TestThree()
        {
            private TestThree = new ThreeOrMore();
            Debug.Assert(TestThree.WinnerFound(20), "Three or more score error");
            Debug.Assert(TestThree.WinnerFound(24), "Three or more score error");
            Debug.Assert(!TestThree.WinnerFound(18), "Three or more score error");
        }
    }
}
