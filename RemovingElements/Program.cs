using System;
using System.Collections.Generic;

namespace RemovingElements
{
    class Program
    {
        /*
         * Take an array and remove every second element out of that array. 
         * Always keep the first element and start removing with the next element.
         * None of the arrays will be empty, so you don't have to worry about that!
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Remove every other element from an array, staring with the second element.\n");
            object[] arr = new object[] { "Keep", "Remove", "Keep", "Remove", "Keep" ,"Remove", "Keep"};
            object[] trimmedArray = RemoveElements(arr);
            PrintArray(trimmedArray);

        }

        public static object[] RemoveElements(object[] arr)
        {
            List<object> everyOtherItem = new List<object>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    everyOtherItem.Add(arr[i]);
                }
            }
            return everyOtherItem.ToArray();
        }

        public static void PrintArray(object[] inputArray)
        {
            foreach (var x in inputArray)
            {
                Console.Write($"{x} ");
            }
        }
    }
}
