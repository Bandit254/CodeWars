using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove the left-most duplicates of all duplicated numbers in an array.\n");
            foreach (int x in RemoveDuplicates(new int[] { 3, 4, 4, 3, 6, 3 }))
            {
                Console.Write($"{x} ");
            }
        }
        public static int[] RemoveDuplicates(int[] arr)
        {
            List<int> duplicates = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]==arr[j] && !duplicates.Contains(arr[i]))
                    {
                        duplicates.Add(arr[i]);
                    }
                }
            }
            List<int> originalSet = arr.ToList<int>();
            foreach (int duplicate in duplicates)
            {
                int lastIndex = Array.FindLastIndex(arr, x=>x==duplicate);
                for (int i = 0; i < lastIndex; i++)
                {
                    if (originalSet[i]==duplicate)
                    {
                        originalSet.Remove(originalSet[i]);
                    }
                }
            }
            int[] finalResults = originalSet.ToArray();
            return finalResults;
        }
    }
}
