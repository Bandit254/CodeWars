using System;

namespace NthPowerRulesThemAll
{
    class Program
    {
        /*You are provided with array of positive non-zero ints and int n representing n-th power (n >= 2).
         * For the given array, calculate the sum of each value to the n-th power. Then subtract the sum of the original array.
         * Example 1: Input: {1, 2, 3}, 3 --> (1 ^ 3 + 2 ^ 3 + 3 ^ 3 ) - (1 + 2 + 3) --> 36 - 6 --> Output: 30
         * Example 2: Input: {1, 2}, 5 --> (1 ^ 5 + 2 ^ 5) - (1 + 2) --> 33 - 3 --> Output: 30
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Given an array of numbers and a power, find the difference between the sum of each array item raised to the power and the sum of each item (not raised to any power).\n");
            Console.WriteLine($"The result of the array (1, 2, 3) and the power of 3 is {ModifiedSum(new int[] { 1, 2, 3 }, 3)}.\n");
            Console.WriteLine($"The result of the array (1, 2) and the power of 5 is {ModifiedSum(new int[] { 1, 2 }, 5)}.\n");
        }
        public static int ModifiedSum(int[] a, int n)
        {
            int powerSum = 0;
            int normalSum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                powerSum += (int)Math.Pow(a[i], n);
            }
            for (int i = 0; i < a.Length; i++)
            {
                normalSum += a[i];
            }
            return powerSum - normalSum;
        }
    }
}
