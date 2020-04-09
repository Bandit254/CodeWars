using System;

namespace NumbersInOrder
{
    class Program
    {
        /*
         * In this Kata, your function receives an array of integers as input. 
         * Your task is to determine whether the numbers are in ascending order. 
         * An array is said to be in ascending order if there are no two adjacent integers where the left integer exceeds the right integer in value.
           For the purposes of this Kata, you may assume that all inputs are valid, i.e. non-empty arrays containing only integers.
           Note that an array of 1 integer is automatically considered to be sorted in ascending order since all (zero) adjacent pairs of integers satisfy the condition that the left integer does not exceed the right integer in value. 
           An empty list is considered a degenerate case and therefore will not be tested in this Kata - feel free to raise an Issue if you see such a list being tested.
           For example:
           Kata.IsAscOrder(new int[]{1,2,4,7,19}) == true
           Kata.IsAscOrder(new int[]{1,2,3,4,5}) == true
           Kata.IsAscOrder(new int[]{1,6,10,18,2,4,20}) == false
           Kata.IsAscOrder(new int[]{9,8,7,6,5,4,3,2,
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that determines if a given array of numbers is in ascending order.\n");
            Console.WriteLine($"{NumbersInOrder(new int[] { 1, 2 })}");
            Console.WriteLine($"{NumbersInOrder(new int[] { 2, 1 })}");
            Console.WriteLine($"{NumbersInOrder(new int[] { 1, 2, 3 })}");
            Console.WriteLine($"{NumbersInOrder(new int[] { 1, 3, 2 })}");
            Console.WriteLine($"{NumbersInOrder(new int[] { 2, 1, 3 })}");
            Console.WriteLine($"{NumbersInOrder(new int[] { 2, 3, 1 })}");
            Console.WriteLine($"{NumbersInOrder(new int[] { 3, 1, 2 })}");
            Console.WriteLine($"{NumbersInOrder(new int[] { 3, 2, 1 })}");
        }

        public static bool NumbersInOrder(int[] arr)
        {
            if (arr.Length==1)
            {
                return true;
            }
            bool inOrder = true;
            for (int i = 0; i < arr.Length-1; i++)
            {
                    if (arr[i]>arr[i+1])
                    {
                        inOrder = false;
                    }
            }
            return inOrder;
        }
    }
}
