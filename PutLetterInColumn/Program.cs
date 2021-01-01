using System;

namespace PutLetterInColumn
{
    class Program
    {
        /*
          Create a function that takes index [0, 8] and a character. 
          It returns a string with columns. Put character in column marked with index.
          Ex.: index = 2, character = 'B'
            | | |B| | | | | | |
             0 1 2 3 4 5 6 7 8
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Create a function that takes index [0, 8] and a character. It returns a string with columns. Put the character in the column indicated by the given index.");
            Console.WriteLine($"{BuildRowText(2, 'A')}");
            Console.WriteLine($"{BuildRowText(0, 'A')}");
            Console.WriteLine($"{BuildRowText(8, 'A')}");
        }

        public static string BuildRowText(int index, char character)
        {
            string result = "|";
            for (int i = 0; i < 9; i++)
            {
                if (i == index)
                {
                    result += character;
                    result += '|';
                }
                else
                {
                    result += " |";
                }                
            }
            return result;
        }
    }
}
