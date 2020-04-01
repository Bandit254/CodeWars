using System;

namespace IntegerDifference
{
    class Program
    {
        /*
         * Write a function that accepts two arguments: an array/list of integers and another integer n.
           Determine the number of times where two integers in the array have a difference of n.
           For example:
           IntDiff({1, 1, 5, 6, 9, 16, 27}, 4) // 3 ~ (1,5), (1,5), (5,9)
           IntDiff({1, 1, 3, 3}, 2) // 4 ~ (1,3), (1,3), (1,3), (1,3)
           Note: your code should not modify the input
         */
        static void Main(string[] args)
        {
           Console.WriteLine("Calculate the number of times the specified difference occurs in a given array of integers.\n");
           Console.WriteLine($"{IntDiff(new int[]{ 1, 1, 5, 6, 9, 16, 27}, 4)}");
           Console.WriteLine($"{IntDiff(new int[] { 1, 1, 3, 3 }, 2)}");
        }

        public static int IntDiff(int[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j!=i)
                    {
                        if ((arr[j] - arr[i]) == n)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }


    }
}
