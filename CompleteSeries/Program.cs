using System;
using System.ComponentModel;

namespace CompleteSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are given an array of non-negative integers, your task is to complete the series from 0 to the highest number in the array. If the numbers in the sequence provided are not in order you should order them, but if a value repeats, then you must return a sequence with only one item, and the value of that item must be 0.\n");
            int[] test1 = new int[] { 0, 1 };
            int[] test2 = new int[] { 1, 4, 6 };
            int[] test3 = new int[] { 3, 4, 5 };
            int[] test4 = new int[] { 2, 1 };
            int[] test5 = new int[] { 1, 4, 4, 6 };
            foreach (int x in CompleteSeries(test1))
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");
            foreach (int x in CompleteSeries(test2))
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");
            foreach (int x in CompleteSeries(test3))
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");
            foreach (int x in CompleteSeries(test4))
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");
            foreach (int x in CompleteSeries(test5))
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");

        }
        public static int[] CompleteSeries(int[] arr)
        {
            int[] zeroArray = new int[] { 0 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j <= arr.Length-1; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        return zeroArray;
                    }
                }
            }
            int maxValue=arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]>maxValue)
                {
                    maxValue = arr[i];
                }
            }
            int[] completedSeries = new int[maxValue + 1];
            for (int i = 0; i < completedSeries.Length; i++)
            {
                completedSeries[i] = i;
            }
            return completedSeries;
        }
    }
}
