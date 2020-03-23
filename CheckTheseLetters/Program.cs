using System;
using System.Collections.Generic;

namespace CheckTheseLetters
{
    class Program
    {
        /*Write a function that checks if all the letters in the second string are present in the first one at least once, regardless of how many times they appear:
          ["ab", "aaa"]    =>  true
          ["trances", "nectar"]    =>  true
          ["compadres", "DRAPES"]  =>  true
          ["parses", "parsecs"]    =>  false
          Function should not be case sensitive, as indicated in example #2. 
          Note: both strings are presented as a single argument in the form of an array.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function to check if all of the letters in one string are present in a second string.\n");
            string[] arr = new string[] { "ab", "aaa" };
            Console.WriteLine($"The letters in the string 'aaa' are contained in the string 'ab': {LetterCheck(arr)}.\n");
            string[] arr2 = new string[] { "trances", "nectar" };
            Console.WriteLine($"The letters in the string 'nectar' are contained in the string 'trances': {LetterCheck(arr2)}.\n");
            string[] arr3 = new string[] { "compadres", "DRAPES" };
            Console.WriteLine($"The letters in the string 'DRAPES' are contained in the string 'compadres': {LetterCheck(arr3)}.\n");
            string[] arr4 = new string[] { "parses", "parsecs" };
            Console.WriteLine($"The letters in the string 'parsecs' are contained in the string 'parses': {LetterCheck(arr4)}.\n");
        }
        public static bool LetterCheck(string[] arr)
        {
            bool allPresent = false;
            string first = arr[0].ToLower();
            string second = arr[1].ToLower();
            char[] firstChars = first.ToCharArray();
            char[] secondChars = second.ToCharArray();
            List<char> firstList = new List<char>();
            firstList.AddRange(firstChars);
            List<char> secondList = new List<char>();
            secondList.AddRange(secondChars);
            for (int i = 0; i < secondList.Count; i++)
            {
                if (!firstList.Contains(secondList[i]))
                {
                    allPresent = false;
                    break;
                }
                else
                {
                    allPresent = true;
                }
            }
            return allPresent;
        }

    }
}
