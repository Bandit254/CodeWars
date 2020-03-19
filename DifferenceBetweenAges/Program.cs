using System;

namespace DifferenceBetweenAges
{
    class Program
    {
        /*
         * At the annual family gathering, the family likes to find the oldest living family member’s age and the youngest family member’s age 
         * and calculate the difference between them.
           You will be given an array of all the family members' ages, in any order. 
           The ages will be given in whole numbers, so a baby of 5 months, will have an ascribed ‘age’ of 0. 
           Return a new array with [youngest age, oldest age, difference between the youngest and oldest age].
           */
        static void Main(string[] args)
        {
            Console.WriteLine("Given an array of ages, return a new array that lists the youngest age, oldest age, and the difference between them.\n ");
            int[] ages = new int[] { 60, 29, 62, 33, 27, 24 };
            int[] differenceBetweenAges = DifferenceInAges(ages);
            PrintArray(differenceBetweenAges);


        }

        public static int[] DifferenceInAges(int[] ages)
        {
            int[] differenceArray = new int[3];
            Array.Sort(ages);
            int youngest = ages[0];
            int oldest = ages[ages.Length - 1];
            int diffAges = oldest - youngest;
            differenceArray[0] = youngest;
            differenceArray[1] = oldest;
            differenceArray[2] = diffAges;

            return differenceArray;
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
