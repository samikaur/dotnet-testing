using System;

namespace UnitTests.Utils
{
    public class MathUtil
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Fibbonacci(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n < 0) throw new ArgumentException($"Cannot calculate Fibonacci number for negative value {n}");
            if (n == 0) return 0; // To return the first Fibonacci number   
            if (n == 1) return 1; // To return the second Fibonacci number   


            for (var i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
        }
    }
}
