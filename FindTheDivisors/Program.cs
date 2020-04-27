using System;
using System.Collections.Generic;

namespace FindTheDivisors
{
    class Program
    {
        /*Create a function named divisors/Divisors that takes an integer n > 1 and returns an array with all of the integer's divisors(except for 1 and the number itself), from smallest to largest. 
         * If the number is prime return the string '(integer) is prime' (null in C#).
        Example:
        Kata.Divisors(12) => new int[] {2, 3, 4, 6};
        Kata.Divisors(25) => new int[] {5};
        Kata.Divisors(13) => null;
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Given a number, return an array of all the divisors of that number. If the number is a prime number, return null.\n");
            int[] array1 = FindTheDivisors(15);
            int[] array2 = FindTheDivisors(16);
            int[] array3 = FindTheDivisors(253);
            int[] array4 = FindTheDivisors(24);
            Console.WriteLine("\nThe divisors of 15 are:\n");
            foreach (int x in array1)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\nThe divisors of 16 are:\n");
            foreach (int x in array2)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\nThe divisors of 253 are:\n");
            foreach (int x in array3)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\nThe divisors of 24 are:\n");
            foreach (int x in array4)
            {
                Console.Write($"{x} ");
            }


        }
        public static int[] FindTheDivisors(int n)
        {
            if (n < 2)
            {
                return null;
            }
            List<int> divisorsList = new List<int>();
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i==0)
                {
                    divisorsList.Add(i);
                }
            }
            if (divisorsList.Count==0)
            {
                Console.WriteLine($"{n} is a prime number");
                return null;
            }
            divisorsList.Sort();
            int[] divisorsArray = new int[divisorsList.Count];
            for (int i = 0; i < divisorsList.Count; i++)
            {
                divisorsArray[i] = divisorsList[i];
            }
            return divisorsArray;
        }
    }
}
