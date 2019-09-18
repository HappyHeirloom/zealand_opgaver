using System;

namespace WTF
{
    public class MysticNumbers
    {
        #region Methods
        public static int ThreeNumbers(int a, int b, int c)
        {
            int result = 0;

            if (b > a)
            {
                result = b;
                if (c > b)
                {
                    result = c;
                }
            }
            else
            {
                result = a;
                if (c > a)
                {
                    result = c;
                }
            }

            Console.WriteLine(result);
            return result;
        }

        public static int TwoNumbers(int a, int b)
        {
            int result = 0;

            if (b > a)
            {
                result = b;
            } else
            {
                if (a > b)
                {
                    result = b;
                }
            }

            Console.WriteLine(result);
            return result;
        }

        #endregion
    }
}