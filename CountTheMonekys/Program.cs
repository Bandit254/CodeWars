using System;

namespace CountTheMonekys
{
    class Program
    {
        /*You take your son to the forest to see the monkeys. 
         * You know that there are a certain number there (n), but your son is too young to just appreciate the full number, 
         * he has to start counting them from 1.
         * As a good parent, you will sit and count with him. 
         * Given the number (n), populate an array with all numbers up to and including that number, but excluding zero.
         * For example:
         * monkeyCount(10) // --> new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
         * monkeyCount(1) // --> new int[]{1}
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that populates an array with every number from 1 up to a given number.\n");

            foreach (int monkey in MonkeyCount(5))
            {
                Console.Write($"{monkey} ");
            }
            Console.WriteLine("\n");
            foreach (int monkey in MonkeyCount(3))
            {
                Console.Write($"{monkey} ");
            }
            Console.WriteLine("\n");
            foreach (int monkey in MonkeyCount(9))
            {
                Console.Write($"{monkey} ");
            }
            Console.WriteLine("\n");
            foreach (int monkey in MonkeyCount(10))
            {
                Console.Write($"{monkey} ");
            }
            Console.WriteLine("\n");
            foreach (int monkey in MonkeyCount(20))
            {
                Console.Write($"{monkey} ");
            }
            Console.WriteLine("\n");
        }
        public static int[] MonkeyCount(int n)
        {
            int[] monkeys = new int[n];
            for (int i = 0; i < n; i++)
            {
                monkeys[i] = i + 1;
            }
            return monkeys;
        }
    }
}
