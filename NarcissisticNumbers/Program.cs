using System;

namespace NarcissisticNumbers
{
    class Program
    {
        /* A Narcissistic Number is a number which is the sum of its own digits, each raised to the power of the number of digits in a given base. 
         * In this Kata, we will restrict ourselves to decimal (base 10).
         * For example, take 153 (3 digits):
         * 
         * 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
         * 
         * and 1634 (4 digits):
         * 
         * 1^4 + 6^4 + 3^4 + 4^4 = 1 + 1296 + 81 + 256 = 1634
         * 
         * The Challenge:
         * Your code must return true or false depending upon whether the given number is a Narcissistic number in base 10.
         * Error checking for text strings or other invalid inputs is not required, only valid integers will be passed into the function.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that returns 'true' is a given number is the sum of its digits each raised to the number of digits in the number, and false otherwise. If the result is true, the number is said to be 'narcissistic'.\n");
            Console.WriteLine($"{Narcissistic(1)}");
            Console.WriteLine($"{Narcissistic(371)}");
            Console.WriteLine($"{Narcissistic(153)}");
            Console.WriteLine($"{Narcissistic(1634)}");
            Console.WriteLine($"{Narcissistic(54)}");
        }
        public static bool Narcissistic(int value)
        {
            int copy = value;
            int copyForDigitCount = value;
            int numDigits = 0;
            int sum = 0;
            while (copyForDigitCount>0)
            {
                numDigits++;
                copyForDigitCount /= 10;
            }
            while (copy>0)
            {
                sum += (int)Math.Pow(copy % 10, numDigits);
                copy /= 10;
            }
            if (sum==value)
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
