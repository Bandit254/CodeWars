using System;

namespace TwoSum
{
    class Program
    {
        /*Write a function that takes an array of numbers (integers for the tests) and a target number. 
         * It should find two different items in the array that, when added together, give the target value. 
         * The indices of these items should then be returned in a tuple like so: (index1, index2).
         * For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.
         * The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers; 
         * target will always be the sum of two different items from that array).
         * Based on: http://oj.leetcode.com/problems/two-sum/
         * twoSum [1, 2, 3] 4 === (0, 2)
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that returns a tuple (array of length two) of the two indices of the numbers from an array that add up to a desired value.\n");
            foreach (int index in TwoSum(new[] { 1, 2, 3 }, 4))
            {
                Console.Write($"{index} ");
            }
            Console.WriteLine("\n");
            foreach (int index in TwoSum(new[] { 1234, 5678, 9012 }, 14690))
            {
                Console.Write($"{index} ");
            }
            Console.WriteLine("\n");
            foreach (int index in TwoSum(new[] { 2, 2, 3 }, 4))
            {
                Console.Write($"{index} ");
            }
            Console.WriteLine("\n");
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            int indexOne = 0;
            int indexTwo = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j <= numbers.Length-1; j++)
                {
                    if (numbers[i]+numbers[j]==target)
                    {
                        indexOne = i;
                        indexTwo = j;
                    }
                }
            }
            int[] resultArray = new int[] { indexOne, indexTwo };
            return resultArray;
        }
    }
}
