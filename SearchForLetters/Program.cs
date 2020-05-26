using System;
using System.Collections.Generic;

namespace SearchForLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that accepts an input string of arbitrary length and returns a string with length 26. Each letter in the input string must be represented by a '1' in the output string in the position corresponding to the letter's position in the alphabet. If the input string does not contain every letter of the alphabet, the output string will indicate letters not present with a '0'.\n");
            string input1 = "a **&  bZ";
            string input2 = "!!a$% &RgTT";
            Console.WriteLine($"{Change(input1)}");
            Console.WriteLine($"{Change(input2)}");
        }
        public static string Change(string input)
        {
            string lettersInString = "";
            if (String.Equals(input,null))
            {
                return "00000000000000000000000000";
            }
            string inputString = input.ToLower();
            List<int> letterIndexes = new List<int>();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i]>='a' && inputString[i]<='z')
                {
                    int indexOfLetter = Convert.ToInt32(inputString[i] - 97);
                    letterIndexes.Add(indexOfLetter);
                }
            }
            if (letterIndexes.Count==0)
            {
                return "00000000000000000000000000";
            }
            for (int i = 0; i < 26; i++)
            {
                if (letterIndexes.Contains(i))
                {
                    lettersInString += 1;
                }
                else
                {
                    lettersInString += 0;
                }
            }
            return lettersInString;
        }
    }
}
