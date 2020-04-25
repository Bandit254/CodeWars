using System;
using System.Collections.Generic;

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
            
            Console.WriteLine($"{CatchNumber(new int[] { 1, 3, 4, 5, 6, 7, 8 })}");
            Console.WriteLine($"{CatchNumber(new int[] { 7, 8, 1, 2, 4, 5, 6 })}");
            Console.WriteLine($"{CatchNumber(new int[] { 1, 2, 3, 5 })}");
            Console.WriteLine($"{CatchNumber(new int[] { 1, 2 })}");
            Console.WriteLine($"{CatchNumber(new int[] { 2, 3, 4 })}");
            Console.WriteLine($"{CatchNumber(new int[] { 13, 11, 10, 3, 2, 1, 4, 5, 6, 9, 7, 8 })}");
            
            /*
            int[] sortedArray1 = SortArray(new int[] { 1, 3, 4, 5, 6, 7, 8 });
            foreach (int x in sortedArray1)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");
            int[] sortedArray2 = SortArray(new int[] { 7, 8, 1, 2, 4, 5, 6 });
            foreach (int x in sortedArray2)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");
            int[] sortedArray3 = SortArray(new int[] { 1, 2, 3, 5 });
            foreach (int x in sortedArray3)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");
            int[] sortedArray4 = SortArray(new int[] { 1, 2 });
            foreach (int x in sortedArray4)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");
            int[] sortedArray5 = SortArray(new int[] { 2, 3, 4 });
            foreach (int x in sortedArray5)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");
            int[] sortedArray6 = SortArray(new int[] { 13, 11, 10, 3, 2, 1, 4, 5, 6, 9, 7, 8 });
            foreach (int x in sortedArray6)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");
            */
        }
        public static int FindNumber(int[] array)
        {
            int missingNo = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i]!=array[j])
                    {
                        if (array[i]<array[j])
                        {
                            int temp = array[j];
                            array[j] = array[i];
                            array[i] = temp;
                        }
                    }
                }
            }
            int[] fullArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length + 1; i++)
            {
                fullArray[i] = i + 1;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]!=fullArray[i])
                {
                    missingNo = fullArray[i];
                }
            }
            if (missingNo==0)
            {
                missingNo = fullArray[array.Length];
            }
            return missingNo;
        }

        public static int CatchNumber(int[] array)
        {
            int missingNo = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list.Contains(i+1)!)
                {
                    missingNo = i + 1;
                }
            }
            if (missingNo==0)
            {
                missingNo = array.Length + 1;
            }

            return missingNo;
        }

        public static int[] SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] != array[j])
                    {
                        if (array[i] < array[j])
                        {
                            int temp = array[j];
                            array[j] = array[i];
                            array[i] = temp;
                        }
                    }
                }
            }
            return array;
        }
    }
}
