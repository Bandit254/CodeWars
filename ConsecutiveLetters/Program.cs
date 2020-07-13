using System;

namespace ConsecutiveLetters
{
    class Program
    {
        /* In this Kata, we will check if a string contains consecutive letters as they appear in the English alphabet 
         * and if each letter occurs only once.
         * Rules are: (1) the letters are adjacent in the English alphabet, and (2) each letter occurs only once.
         * For example: 
         * solve("abc") = True, because it contains a,b,c
         * solve("abd") = False, because a, b, d are not consecutive/adjacent in the alphabet, and c is missing.
         * solve("dabc") = True, because it contains a, b, c, d
         * solve("abbc") = False, because b does not occur once.
         * solve("v") = True
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that determines if all letters in a string are adjacent to each other in the alphabet AND that checks to make sure each letter occurs only once.\n");
            Console.WriteLine($"String = 'abc', result = {ConsecutiveLetterCheck("abc")}.\n");
            Console.WriteLine($"String = 'abd', result = {ConsecutiveLetterCheck("abd")}.\n");
            Console.WriteLine($"String = 'dabc', result = {ConsecutiveLetterCheck("dabc")}.\n");
            Console.WriteLine($"String = 'abbc', result = {ConsecutiveLetterCheck("abbc")}.\n");
            Console.WriteLine($"String = 'v', result = {ConsecutiveLetterCheck("v")}.\n");
        }
        public static bool ConsecutiveLetterCheck(string s)
        {
            if (s.Length==1)
            {
                return true;
            }
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i+1; j <= s.Length-1; j++)
                {
                    if (s[i]==s[j])
                    {
                        return false;
                    }
                }
            }
            bool allConsecutive = false;
            int numConsecutive = 0;
            for (int h = 0; h < s.Length; h++)
            {
                for (int k = h+1; k <= s.Length-1; k++)
                {
                    int diff = (int)(s[k] - s[h]);
                    if (Math.Abs(diff) == 1)
                    {
                        numConsecutive++;
                    }
                }
            }
            if (numConsecutive==s.Length-1)
            {
                allConsecutive = true;
            }
            return allConsecutive;
        }
    }
}
