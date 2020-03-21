using System;

namespace TwoOldestAges
{
    class Program
    {
        /*
         * The two oldest ages function/method needs to be completed. 
         * It should take an array of numbers as its argument and return the two highest numbers within the array. 
         * The returned value should be an array in the format [second oldest age, oldest age].
         * The order of the numbers passed in could be any order. The array will always include at least 2 items.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function to return an array of the two oldest ages from an array of unsorted ages.\n");

            int[] ages = new int[] { 1, 2, 10, 8 };
            int[] twoOldest = TwoOldestAges(ages);
            Console.WriteLine($"The two oldest ages are:\n");
            PrintArray(twoOldest);
            int[] ages2 = new int[] { 1, 5, 87, 45, 8, 8 };
            int[] twoOldest2 = TwoOldestAges(ages2);
            Console.WriteLine($"The two oldest ages are:\n");
            PrintArray(twoOldest2);

        }


        public static int[] TwoOldestAges(int[] ages)
        {
            int[] twoOldest = new int[2];
            int[] copyAges = new int[ages.Length];
            Array.Copy(ages, copyAges, ages.Length);
            Array.Sort(copyAges);
            twoOldest[0] = copyAges[copyAges.Length - 2];
            twoOldest[1] = copyAges[copyAges.Length - 1];
            return twoOldest;
        }

        public static void PrintArray(int[] inputArray)
        {
            foreach (int x in inputArray)
            {
                Console.Write($"{x} ");
            }
        }


    }
}
