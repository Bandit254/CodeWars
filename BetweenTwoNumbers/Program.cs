using System;

namespace BetweenTwoNumbers
{
    class Program
    {
        /*
         * Build a function that can get all the integers between two given numbers.
           Example:
           (2,9)
           Should give you this output back:
           [ 3, 4, 5, 6, 7, 8 ]
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Build a function that can get all the integers between two given numbers.\n");
            foreach (int num in Range(210, 210))
            {
                Console.Write($"{num} ");
            }
        }

        public static int[] Range(int startNum, int endNum)
        {
            if (startNum == endNum)
            {
                return new int[0]; 
            }
            int numMissing = endNum - startNum - 1;
            int nextNum = startNum + 1;
            int[] between = new int[numMissing];
            for (int i = 0; i < numMissing; i++)
            {
                between[i] = nextNum;
                nextNum++;
            }
            return between;
        }
    }
}
