using System;
using System.Collections.Generic;

namespace CountingDuplicates
{
    class Program
    {
        /*Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits 
         * that occur more than once in the input string. The input string can be assumed to contain only alphabets 
         * (both uppercase and lowercase) and numeric digits.
         * Example
         * "abcde" -> 0 # no characters repeats more than once
         * "aabbcde" -> 2 # 'a' and 'b'
         * "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
         * "indivisibility" -> 1 # 'i' occurs six times
         * "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
         * "aA11" -> 2 # 'a' and '1'
         * "ABBA" -> 2 # 'A' and 'B' each occur twice
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that returns the number of characters that appear 2 or more times in a given string.\n");
            Console.WriteLine($"The number of duplicated characters in the string '' is {DuplicateCount("")}.\n");
            Console.WriteLine($"The number of duplicated characters in the string 'abcde' is {DuplicateCount("abcde")}.\n");
            Console.WriteLine($"The number of duplicated characters in the string 'aabbcde' is {DuplicateCount("aabbcde")}.\n");
            Console.WriteLine($"The number of duplicated characters in the string 'aabBcde' is {DuplicateCount("aabBcde")}.\n");
            Console.WriteLine($"The number of duplicated characters in the string 'Indivisibility' is {DuplicateCount("Indivisibility")}.\n");
            Console.WriteLine($"The number of duplicated characters in the string 'Indivisibilities' is {DuplicateCount("Indivisibilities")}.\n");
        }
        public static int DuplicateCount(string str)
        {
            int numDuplicatedCharacters = 0;
            if (String.Equals(str, ""))
            {
                return numDuplicatedCharacters;
            }
            str = str.ToLower();
            List<char> checkedChars = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                int currentCharCount = 1;
                for (int j = i+1; j <= str.Length-1; j++)
                {
                    if (str[i]==str[j] && !checkedChars.Contains(str[i]))
                    {
                        currentCharCount++;
                        checkedChars.Add(str[i]);
                    }
                }
                if (currentCharCount>=2)
                {
                    numDuplicatedCharacters++;
                }
            }
            return numDuplicatedCharacters;
        }
    }
}
