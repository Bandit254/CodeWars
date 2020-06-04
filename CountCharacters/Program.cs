using System;
using System.Collections.Generic;

namespace CountCharacters
{
    class Program
    {
        /*The main idea is to count all the occurring characters(UTF-8) in string. 
         * If you have string like this aba then the result should be { 'a': 2, 'b': 1 }
        What if the string is empty? Then the result should be empty object literal { }
        For C#: Use a Dictionary<char, int> for this kata!
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Count the number of occurrences in a string and return a dictionary object that stores the character as the key and # instances of the character as the value.\n");

        }
        public static Dictionary<char, int> Count(string str)
        {
            if (str==null || str=="")
            {
                return null;
            }
            Dictionary<char, int> charCountsDict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                int charCount = 1;
                for (int j = i+1; j <= str.Length-1; j++)
                {
                    if (str[j]== str[i])
                    {
                        charCount++;
                    }
                }
                if (!charCountsDict.ContainsKey(str[i]))
                {
                    charCountsDict.Add(str[i], charCount);
                }
            }
            return charCountsDict;
        }
    }
}
