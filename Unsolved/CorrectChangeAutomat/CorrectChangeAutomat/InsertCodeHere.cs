using System;

namespace CorrectChangeAutomat
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            int paybackAmount = 234;
            int kr200 = 0;
            int kr20 = 0;
            int kr10 = 0;
            int kr2 = 0;
            while (paybackAmount > 200)
            {
                kr200 = kr200 + 1;
                paybackAmount = paybackAmount - 200;
            }

            while (paybackAmount > 20)
            {
                kr20 = kr20 + 1;
                paybackAmount = paybackAmount - 20;
            }

            while (paybackAmount > 10)
            {
                kr10 = kr10 + 1;
                paybackAmount = paybackAmount - 10;
            }

            while (paybackAmount >= 2)
            {
                kr2 = kr2 + 1;
                paybackAmount = paybackAmount - 2;
            }

            Console.WriteLine(paybackAmount);
            // The LAST line of code should be ABOVE this line
        }
    }
}