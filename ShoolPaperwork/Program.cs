using System;

namespace ShoolPaperwork
{
    class Program
    {
        /*Your classmates asked you to copy some paperwork for them. 
         * You know that there are 'n' classmates and the paperwork has 'm' pages.
         * Your task is to calculate how many blank pages do you need.
         * Example:
         * Paperwork(5, 5) == 25
         * Note: if n < 0 or m < 0 return 0!
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function to multiply two numbers together.\n");
            Console.WriteLine($"{Paperwork(5, 5)}");
        }
        public static int Paperwork(int n, int m)
        {
            if (n<0 || m<0)
            {
                return 0;
            }
            return n * m;
        }
    }
}
