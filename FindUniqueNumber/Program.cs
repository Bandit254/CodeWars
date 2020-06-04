using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FindUniqueNumber
{
    class Program
    {
        /* There is an array with some numbers. All numbers are equal except for one. Try to find it!
         * findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
         * findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
         * It’s guaranteed that array contains at least 3 numbers.
         * The tests contain some very huge arrays, so think about performance.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Find the one unique number from a given collection.\n");
            Console.WriteLine($"{GetUnique(new[] { 1, 2, 2, 2 })}\n");
            Console.WriteLine($"{GetUnique(new[] { -2, 2, 2, 2 })}\n");
            Console.WriteLine($"{GetUnique(new[] { 11, 11, 14, 11, 11 })}\n");
            int[] testArray = new int[100000000];
            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = 3;
            }
            Random x = new Random();
            int xR = x.Next(0, 100000000);
            testArray[xR] = 54;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"{GetUniqueV2(testArray)}");
            stopwatch.Stop();
            Console.WriteLine($"The index of the unique number is {xR}");
            Console.WriteLine($"The time elapsed is {stopwatch.ElapsedMilliseconds}");

        }
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int[] numberArray = numbers.ToArray<int>();
            int repeatedNum = 0;
            bool foundRepeatNum = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = i+1; j <= 3; j++)
                {
                    if (numberArray[i]== numberArray[j])
                    {
                        repeatedNum = numberArray[i];
                        foundRepeatNum = true;
                        break;
                    }
                }
                if (foundRepeatNum)
                {
                    break;
                }
            }
            int uniqueNum = BinarySearch(numberArray, repeatedNum);
            return uniqueNum;
        }
        public static int BinarySearch(int[] searchArray, int repeatedNum)
        {
            int nonRepeatedNum = 0;
            bool foundNum = false;
            for (int i = 0; i < (searchArray.Length/2); i++)
            {
                if (searchArray[i]!=repeatedNum)
                {
                    nonRepeatedNum = searchArray[i];
                    foundNum = true;
                    break;
                }
            }
            if (foundNum==false)
            {
                int length = (searchArray.Length)/2;
                if (searchArray.Length%2!=0)
                {
                    length++;
                }
                int[] otherHalf = new int[length];
                Array.Copy(searchArray, (searchArray.Length / 2), otherHalf, 0,length);
                //for (int i = 0; i < otherHalf.Length; i++)
                //{
                //    otherHalf[i] = searchArray[(searchArray.Length / 2) + i];
                //}
                return BinarySearch(otherHalf, repeatedNum);
            }
            else
            {
                return nonRepeatedNum;
            }
        }
        public static int GetUniqueV2(IEnumerable<int> numbers)
        {
            int[] numberArray = numbers.ToArray<int>();
            int repeatedNum = 0;
            bool foundRepeatNum = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j <= 3; j++)
                {
                    if (numberArray[i] == numberArray[j])
                    {
                        repeatedNum = numberArray[i];
                        foundRepeatNum = true;
                        break;
                    }
                }
                if (foundRepeatNum)
                {
                    break;
                }
            }
            int uniqueNum = 0;
            for (int i = 0; i <= numberArray.Length/2; i++)
            {
                if (numberArray[i]!=repeatedNum)
                {
                    uniqueNum = numberArray[i];
                }
                else if (numberArray[numberArray.Length-1-i]!=repeatedNum)
                {
                    uniqueNum = numberArray[numberArray.Length - 1 - i];
                }
            }
            return uniqueNum;
        }
    }
}
