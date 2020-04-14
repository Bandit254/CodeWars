using System;
using System.Collections.Generic;

namespace CountLettersInString
{
    class Program
    {
        /*
         * Take a string str and return a string that is made up of the number of occurances of each english letter in str, 
         * followed by that letter. The string shouldn't contain zeros; leave them out.
         * An empty string, or one with no letters, should return an empty string.
         * Notes:
            Ignore all case
            str will never be null
            Examples
            "This is a test sentence."  =>  "1a1c4e1h2i2n4s4t"
            ""  =>  ""
            "555"  =>  ""
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Return a string containing the each letter from an input string and the number of times that letter appears.\n");
            string str = "This is a test sentence.";
            string result = StringLetterCount(str);
            Console.WriteLine($"{result}");
        }
        public static string StringLetterCount(string str)
        {
            string result = "";
            str = str.ToLower();
            string sortedString = "";
            List<string> sortedList = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]<=122&&str[i]>=97)
                {
                    string currentLetter = Convert.ToString(str[i]);
                    sortedList.Add(currentLetter);
                }
            }
            sortedList.Sort();
            for (int i = 0; i < sortedList.Count; i++)
            {
                sortedString += sortedList[i];
            }
            List<string> letterCounts = new List<string>();
            for (int i = 0; i < sortedString.Length; i++)
            {
                if (sortedString[i]<=122 && sortedString[i]>=97)
                {
                    char currentChar = sortedString[i];
                    int count = 1;
                    for (int j = i+1; j < sortedString.Length; j++)
                    {
                        if (sortedString[j]==currentChar)
                        {
                            count++;
                        }
                    }
                    string countString = Convert.ToString(count);
                    string currentLetter = Convert.ToString(currentChar);
                    if (letterCounts.Contains(currentLetter)==false)
                    {
                        letterCounts.Add(countString);
                        letterCounts.Add(currentLetter);
                    }
                }
            }
            for (int i = 0; i < letterCounts.Count; i++)
            {
                result += letterCounts[i];
            }
            return result;
        }
    }
}
