using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RectanglesIntoSquares
{
    class Program
    {
        /*
         * The drawing below gives an idea of how to cut a given "true" rectangle into squares ("true" rectangle meaning that the two dimensions are different).
         * Can you translate this drawing into an algorithm?

           You will be given two dimensions:
           
           a positive integer length (parameter named lng)
           a positive integer width (parameter named wdth)

           You will return an array or list with the size of each of the squares:

             sqInRect(5, 3) should return [3, 2, 1, 1]
             sqInRect(3, 5) should return [3, 2, 1, 1]
           
           Notes:
           lng == wdth as a starting case would be an entirely different problem and the drawing is planned to be interpreted with lng != wdth.
           When the initial parameters are so that lng == wdth, the solution [lng] would be the most obvious but not in the spirit of this kata so, in that case, return None/nil/null/Nothing
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that determines how many squares can be made out of a rectangle, and returns a list/array containing the side lengths of each square. \n");
            int[] resultArray = RectangleToSquares(5, 3);
            foreach (int side in resultArray)
            {
                Console.Write($"{side} ");
            }
        }

        public static int[] RectangleToSquares(int lng, int wdth)
        {
            if (lng == wdth)
            {
                return null;
            }
            List<int> resultList = new List<int>();
            int startArea = lng * wdth;
            while (startArea > 0)
            {
                int longSide;
                int shortSide;
                if (lng >= wdth)
                {
                    longSide = lng;
                    shortSide = wdth;
                }
                else
                {
                    longSide = wdth;
                    shortSide = lng;
                }
                resultList.Add(shortSide);
                int intermediateArea = shortSide * shortSide;
                if (lng >= wdth)
                {
                    lng -= wdth;
                }
                else
                {
                    wdth -= lng;
                }
                startArea -= intermediateArea;
            }
            int[] resultArray = resultList.ToArray();
            return resultArray;

        }
    }
}
