using System;

namespace DigitalRoot
{
    class Program
    {
        /*
          In this kata, you must create a digital root function.
        A digital root is the recursive sum of all the digits in a number. 
        Given n, take the sum of the digits of n. If that value has more than one digit, 
        continue reducing in this way until a single-digit number is produced. 
        This is only applicable to the natural numbers.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that calculates the digital root (sum of digits) of a given number).\n");
            long digRoot1 = 16;
            long digRoot2 = 942;
            long digRoot3 = 132189;
            long digRoot4 = 493193;
            long digRoot5 = 456;
            Console.WriteLine($"The digital root of {digRoot1} is {DigitalRoot(digRoot1)}.\n");
            Console.WriteLine($"The digital root of {digRoot2} is {DigitalRoot(digRoot2)}.\n");
            Console.WriteLine($"The digital root of {digRoot3} is {DigitalRoot(digRoot3)}.\n");
            Console.WriteLine($"The digital root of {digRoot4} is {DigitalRoot(digRoot4)}.\n");
            Console.WriteLine($"The digital root of {digRoot5} is {DigitalRoot(digRoot5)}.\n");

        }

        public static long DigitalRoot(long n)
        {
            long digitalRoot=0;
            int digitalRootSum=0;
            while (n > 0) 
            {
                digitalRoot += (n % 10);
                n = n / 10;
            }
            while (digitalRoot>9)
            {
               return DigitalRoot(digitalRoot);
            }
            digitalRootSum = (int)digitalRoot;
            return digitalRootSum;
        }














        public static int SumOfDigits(long n)
        {
            
            int digitalRoot = 0;
            double x = (double)n;
            string inputNumberString = x.ToString();
            int[] numArray = new int[inputNumberString.Length];
            for (int i = 0; i < inputNumberString.Length; i++)
            {
                numArray[i] = (int)inputNumberString[i];
            }
            foreach (int i in numArray)
            {
                digitalRoot += 1;
            }
            if (digitalRoot>9)
            {
                DigitalRoot(digitalRoot);
            }
            return digitalRoot;
        }
    }
}
