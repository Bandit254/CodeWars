using System;
using System.Collections.Generic;

namespace EurekaNumbers
{
    class Program
    {
        /*The number 89 is the first integer with more than one digit that fulfills the property partially introduced in the title of this kata. 
         * What's the use of saying "Eureka"? Because this sum gives the same number.
         * In effect: 89 = 8^1 + 9^2
         * The next number in having this property is 135.
         * See this property again: 135 = 1^1 + 3^2 + 5^3
         * We need a function to collect these numbers, that may receive two integers a, b that defines the range [a, b] (inclusive) 
         * and outputs a list of the sorted numbers in the range that fulfills the property described above.
         * Let's see some cases:
         * sum_dig_pow(1, 10) == [1, 2, 3, 4, 5, 6, 7, 8, 9]
         * sum_dig_pow(1, 100) == [1, 2, 3, 4, 5, 6, 7, 8, 9, 89]
         * If there are no numbers of this kind in the range [a, b] the function should output an empty list.
         * sum_dig_pow(90, 100) == []
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that accepts two numbers that define the range of numbers to be searched and returns an array of all Eureka numbers within the given range.\n");
            foreach (long eurekaNum in SumDigPow(1,10))
            {
                Console.Write($"{eurekaNum} ");
            }
            Console.WriteLine($"\n");
            foreach (long eurekaNum in SumDigPow(1, 100))
            {
                Console.Write($"{eurekaNum} ");
            }
            Console.WriteLine($"\n");
            foreach (long eurekaNum in SumDigPow(1, 200))
            {
                Console.Write($"{eurekaNum} ");
            }
            Console.WriteLine($"\n");
        }
        public static long[] SumDigPow(long a, long b)
        {
            long[] numberRange = new long[b - a + 1];
            for (long i = 0; i < numberRange.Length; i++)
            {
                numberRange[i] = a + i;
            }
            List<long> eurekaList = new List<long>();
            for (int i = 0; i < numberRange.Length; i++)
            {
                long currentNum = numberRange[i];
                int digits = currentNum.ToString().Length;
                long sum = 0;
                for (int j = 0; j < digits; j++)
                {
                    sum += (long)Math.Pow((currentNum % 10), (digits - j));
                    currentNum /= 10;
                }
                if (sum==numberRange[i])
                {
                    eurekaList.Add(numberRange[i]);
                }
            }
            long[] eurekaArray = eurekaList.ToArray();
            return eurekaArray;
        }
    }
}
