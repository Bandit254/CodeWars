using System;

namespace FindTheOddInt
{
    class Program
    {
        /*Given an array, find the integer that appears an odd number of times.
        There will always be only one integer that appears an odd number of times.
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Find the number in an array that appears an odd number of times!\n");
            int[] seq = new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            Console.WriteLine($"{FinddTheOddInt(seq)}");
        }

        public static int FinddTheOddInt(int[] seq)
        {
            int oddNumberOut = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                int currentNumber = seq[i];
                int numberOfAppearances = 0;
                for (int j = 0; j < seq.Length; j++)
                {
                    if (currentNumber==seq[j])
                    {
                        numberOfAppearances++;
                    }
                }
                if (numberOfAppearances%2!=0)
                {
                    oddNumberOut = currentNumber;
                    break;
                }
            }
            return oddNumberOut;
        }
    }
}
