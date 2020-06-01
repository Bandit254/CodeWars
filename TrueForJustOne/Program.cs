using System;

namespace TrueForJustOne
{
    class Program
    {
        /*Create a function called one that accepts two params:
        -a sequence
        -a function
        and returns true only if the function in the params returns true for exactly one (1) item in the sequence.
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that accepts an array of Integers and a Boolean function. Return true if and only if the array of numbers evaluates to true only once when passed to the function parameter.\n");
            Console.WriteLine($"{One(new int[] { 1, 2, 3, 4, 5 }, v => v < 2)}");
            Console.WriteLine($"{One(new int[] { 1, 2, 3, 4, 5 }, v => v % 2 != 0)}");
            Console.WriteLine($"{One(new int[] { 1, 2, 3, 4, 5 }, v => v > 5)}");

        }
        public static bool One(int[] arr, Func<int, bool> fun)
        {
            if (arr==null || arr.Length==0)
            {
                return false;
            }
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (fun(arr[i])==true)
                {
                    count++;
                }
            }
            if (count==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
