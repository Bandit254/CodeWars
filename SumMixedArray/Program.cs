using System;

namespace SumMixedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.\n");
            Console.WriteLine($"The sum of the array (9, 3, '7', '3') is {SumMix(new object[] { 9, 3, "7", "3" })}.\n");
            Console.WriteLine($"The sum of the array ('5', '0', 9, 3, 2, 1, '9', 6, 7) is {SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 })}.\n");
            Console.WriteLine($"The sum of the array ('3', 6, 6, 0, '5', 8, 5, '6', 2, '0') is {SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" })}.\n");
        }
        public static int SumMix(object[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] is int)
                {
                    sum += (int)x[i];
                }
                else if (x[i] is string)
                {
                    sum += Convert.ToInt32(x[i]);
                }
            }
            return sum;
        }
    }
}
