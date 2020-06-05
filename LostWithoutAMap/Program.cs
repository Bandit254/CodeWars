using System;
using System.Linq;

namespace LostWithoutAMap
{
    class Program
    {
        /*Given an array of integers, return a new array with each value doubled.
         * For example:
         * [1, 2, 3] --> [2, 4, 6]
         * For the beginner, try to use the map method - it comes in very handy quite a lot so is a good one to know.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Double each item in a given array.\n");
            foreach (int x in Maps(new int[] { 1, 2, 3 }))
            {
                Console.Write($"{x} ");
            }
        }
        public static int[] Maps(int[] x)
        {
            int[] xDouble = x.Select(i => i * 2).ToArray();
            return xDouble;
        }
    }
}
