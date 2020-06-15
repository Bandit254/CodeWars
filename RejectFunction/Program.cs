using System;
using System.Collections.Generic;

namespace RejectFunction
{
    class Program
    {
        /*Implement a function which filters out array values which satisfy the given predicate.
         * Kata.Reject(new int[] {1, 2, 3, 4, 5, 6}, (n) => n % 2 == 0)  =>  new int[] {1, 3, 5}
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function to filter (reject) values from a given collection based on a given predicate.\n");
            foreach (int x in Reject(new int[] { 1, 2, 3, 4, 5, 6 }, (n) => n % 2 == 0))
            {
                Console.Write($"{x} ");
            }
        }
        public static int[] Reject(int[] array, Func<int, bool> predicate)
        {
            List<int> filteredResults = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!predicate(array[i]))
                {
                    filteredResults.Add(array[i]);
                }
            }
            return filteredResults.ToArray();
        }
    }
}
