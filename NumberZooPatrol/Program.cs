using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberZooPatrol
{
    class Program
    {
        /*
        You're working in a number zoo, and it seems that one of the numbers has gone missing!
        Zoo workers have no idea what number is missing, and are too incompetent to figure it out, so they're hiring you to do it for them.
        In case the zoo loses another number, they want your program to work regardless of how many numbers there are in total.
        Task:
        Write a function that takes a shuffled list of unique numbers from 1 to n with one element missing(which can be any number including n). 
        Return this missing number.
        Note: huge lists will be tested
        Examples:
        [1, 3, 4]  =>  2
        [1, 2, 3]  =>  4
        [4, 2, 3]  =>  1
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Find the missing number in a given array.\n");
            Console.WriteLine($"{FindNumber(new int[] { 1, 3, 4 })}\n");
            Console.WriteLine($"{FindNumber(new int[] { 1, 2, 3 })}\n");
            Console.WriteLine($"{FindNumber(new int[] { 4, 2, 3})}\n");

        }
        public static int FindNumber(int[] array)
        {
            int missingNo = 0;
            int last = array.Length+1;
            if (!array.Contains(last))
            {
                missingNo = last;
                return missingNo;
            }
            else if (!array.Contains(1))
            {
                missingNo = 1;
                return missingNo;
            }
            int[] fullArray = new int[last];
            for (int i = 0; i < fullArray.Length; i++)
            {
                fullArray[i] = i + 1;
            }
            for (int i = 0; i < fullArray.Length; i++)
            {
                if (!array.Contains(fullArray[i]))
                {
                    missingNo = fullArray[i];
                    break;
                }
            }
            return missingNo;
        }
    }
}
