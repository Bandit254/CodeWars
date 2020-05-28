using System;

namespace DiagonalStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In this kata, you have a string array has N elements and each element of array has N length (NxN). You must first sort the array alphabetically. And output consists of letters obtained diagonally (from upper left to lower right). If input array is not square(NxN) (array with 0 length is not accept as square too) or is empty returns NULL.\n");
            Console.WriteLine("As of now, the program does not handle duplicate strings.\n");
            string[] test1 = new string[] { "abcd", "kata", "1234", "qwer" };
            string[] test2 = new string[] { "1a8er", "B36jh", "AiYe3", "B1t0a", "g47uj" };
            string[] test3 = new string[] { "ab", "12" };
            string[] test4 = new string[] { "xyz", "xyz", "xyz" };
            string[] test5 = new string[] { "abcd", "kata", "abcd", "qwer" };
            foreach (string s in DiagonalsOfSquare(test1))
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine("\n");
            foreach (string s in DiagonalsOfSquare(test2))
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine("\n");
            foreach (string s in DiagonalsOfSquare(test3))
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine("\n");
            foreach (string s in DiagonalsOfSquare(test4))
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine("\n");
            foreach (string s in DiagonalsOfSquare(test5))
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine("\n");
        }
        public static string[] DiagonalsOfSquare(string[] array)
        {
            if (array.Length==0)
            {
                return null;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length!=array.Length)
                {
                    return null;
                }
            }
            static string[] RotateArray(string[] array)
            {
                string[] rotatedArray = new string[array.Length];
                for (int j = 0; j < array.Length; j++)
                {
                    if (j - 1 < 0)
                    {
                        rotatedArray[j - 1 + array.Length] = array[j];
                    }
                    else if (j - 1 >= 0)
                    {
                        rotatedArray[j - 1] = array[j];
                    }
                }
                return rotatedArray;
            }
            string[] originalOrder = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                originalOrder[i] = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i][0]<array[j][0])
                    {
                        string temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            string[] results = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                string diagonal = "";
                for (int j = 0; j < array.Length; j++)
                {
                    diagonal += array[j][j];
                }
                int diagResultIndex=0;
                for (int k = 0; k < originalOrder.Length; k++)
                {
                    if (String.Equals(array[0],originalOrder[k]))
                    {
                        diagResultIndex = k;
                    }
                }
                results[diagResultIndex] = diagonal;
                array = RotateArray(array);
            }
            return results;
        }
    }
}
