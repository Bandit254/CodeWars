using System;

namespace CountOccurences
{
    class Program
    {
        /*
         * Create a function called that accepts 2 string arguments and returns an integer of the count of occurrences the 2nd argument is found in the first one.
            If no occurrences can be found, a count of 0 should be returned.
            The first argument can be an empty string.
            The second string argument will always be of length 1.
            */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that accepts two strings, and returns the count of occurrences of the second string in the first string.\n ");
            string str = "Hello";
            string letter = "o";
            string letter2 = "l";
            string str2 = "";
            string letter3 = "z";
            Console.WriteLine($"The number of occurrences of {letter} in {str} is: {StrCount(str, letter)}.\n");
            Console.WriteLine($"The number of occurrences of {letter2} in {str} is: {StrCount(str, letter2)}.\n");
            Console.WriteLine($"The number of occurrences of {letter3} in {str2} is: {StrCount(str2, letter3)}.\n");
        }

        public static int StrCount(string str, string letter)
        {
            int stringCount = 0;
            char comparison = Convert.ToChar(letter);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == comparison)
                {
                    stringCount++;
                }
            }

            return stringCount;
        }
    }
}
