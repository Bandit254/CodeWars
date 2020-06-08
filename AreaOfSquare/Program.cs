using System;

namespace AreaOfSquare
{
    class Program
    {
        /*Complete the function that calculates the area of a square, 
         * when the length of the circular arc A is given as the input. 
         * Return the result rounded to two decimals.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the area of a square given the length of a circular arc that runs from one corner of the circle to the other.\n");
            Console.WriteLine($"Given an arc of 2, the area of the circle is {SquareArea(2)}.\n");
            Console.WriteLine($"Given an arc of 0, the area of the circle is {SquareArea(0)}.\n");
            Console.WriteLine($"Given an arc of 14.05, the area of the circle is {SquareArea(80)}.\n");
        }
        public static double SquareArea(double A)
        {
            double radius = (4 * A) / (2 * Math.PI);
            double area = radius * radius;
            double result = Math.Round(area, 2);
            return result;
        }
    }
}
