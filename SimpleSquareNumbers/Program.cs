using System;
using System.Collections.Generic;

namespace SimpleSquareNumbers
{
    class Program
    {
        /*In this Kata, you will be given a number n (n > 0). 
         * Your task will be to return the smallest square number N (N > 0) 
         * such that n + N is also a perfect square. 
         * If there is no answer, return -1
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Given some integer, return the smallest number that, when added to the given integer, results in a perfect square number.\n");
            Console.WriteLine($"{PerfectSquare(1)}");
            Console.WriteLine($"{PerfectSquare(2)}");
            Console.WriteLine($"{PerfectSquare(3)}");
            Console.WriteLine($"{PerfectSquare(4)}");
            Console.WriteLine($"{PerfectSquare(5)}");
            Console.WriteLine($"{PerfectSquare(7)}");
            Console.WriteLine($"{PerfectSquare(8)}");
            Console.WriteLine($"{PerfectSquare(9)}");
            Console.WriteLine($"{PerfectSquare(10)}");
            Console.WriteLine($"{PerfectSquare(11)}");
            Console.WriteLine($"{PerfectSquare(13)}");
            Console.WriteLine($"{PerfectSquare(17)}");
            Console.WriteLine($"{PerfectSquare(88901)}");
            Console.WriteLine($"{PerfectSquare(290101)}");
            Console.WriteLine($"{PerfectSquare(9999999)}");
            Console.WriteLine($"{PerfectSquare(99999999)}");
            Console.WriteLine($"{PerfectSquare(999999999)}");
            Console.WriteLine($"{PerfectSquare(1000000000)}");
        }
        public static long PerfectSquare(long n)
        {
            bool foundNum = false;
            long perfSquare = 0;
            Dictionary<long, long> perfectSquares = new Dictionary<long, long>();
            for (int i = 0; i < 200000; i++)
            {
                perfectSquares.Add(i, i * i);
            }
            for (long i = 0; i < 200000; i++)
            {
                long sum = n + perfectSquares[i];
                if (perfectSquares.ContainsValue(sum))
                {
                    perfSquare = perfectSquares[i];
                    foundNum = true;
                    break;
                }
            }
            if (foundNum)
            {
                return perfSquare;
            }
            else
            {
                return -1;
            }
        }
    }
}
