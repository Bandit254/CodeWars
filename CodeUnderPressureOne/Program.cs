using System;

namespace CodeUnderPressureOne
{
    class Program
    {
        /*Code as fast as you can! You need to double the integer and return it.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Double the given integer!\n");
            int n = 4;
            Console.WriteLine($"The double of {n} is {DoubleInteger(n)}.\n");
        }

        public static int DoubleInteger(int n)
        {
            int doubledInteger = 2 * n;
            return doubledInteger;
        }
    }
}
