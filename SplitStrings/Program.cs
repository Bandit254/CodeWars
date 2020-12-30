using System;

namespace SplitStrings
{
    class Program
    {
        /*
        Complete the solution so that it splits the string into pairs of two characters. 
        If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

        Examples:

        SplitString.Solution("abc"); // should return ["ab", "c_"]
        SplitString.Solution("abcdef"); // should return ["ab", "cd", "ef"]
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that splits a string into an array of two-character strings.\n");
            string input1 = "abc";
            string input2 = "abcdef";
            foreach (string str in SplitString(input1))
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine("\n");
            foreach (string str in SplitString(input2))
            {
                Console.Write($"{str} ");
            }

        }

        public static string[] SplitString(string str)
        {
            if (str.Length % 2 == 0)
            {
                int numWords = str.Length / 2;
                string[] output = new string[numWords];
                int i = 0;
                int j = 1;
                int counter = 0;
                while (counter < numWords)
                {
                    string nextStr = "";
                    nextStr += str[i];
                    nextStr += str[j];
                    output[counter] = nextStr;
                    i += 2;
                    j += 2;
                    counter++;
                }
                return output;
            }
            else
            {
                int numWords = str.Length / 2 + 1;
                string[] output = new string[numWords];
                int i = 0;
                int j = 1;
                int counter = 0;
                while (counter < numWords - 1)
                {
                    string nextStr = "";
                    nextStr += str[i];
                    nextStr += str[j];
                    output[counter] = nextStr;
                    i += 2;
                    j += 2;
                    counter++;
                }
                string lastStr = "";
                lastStr += str[i];
                lastStr += '_';
                output[counter] = lastStr;                
                return output;
            }
        }
    }
}
