using System;
using System.Collections.Generic;

namespace OrderedCountOfCharacters
{
    class Program
    {
        /*
         * Count the number of occurrences of each character and return it as a list of tuples in order of appearance. 
         * For empty output return an empty list.
         * Kata.OrderedCount("abracadabra") == new List<Tuple<char, int>> () {
           new Tuple<char, int>('a', 5),
           new Tuple<char, int>('b', 2),
           new Tuple<char, int>('r', 2), 
           new Tuple<char, int>('c', 1),
           new Tuple<char, int>('d', 1)
           }
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Count how many times each character appears in a collection.\n");

        }
        public static List<Tuple<char, int>> OrderedCharacterCount(string input)
        {
            List<Tuple<char, int>> returnList = new List<Tuple<char, int>>();
            if (input==null)
            {
                return returnList;
            }
            List<char> recordedChars = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                int count = 1;
                if (!recordedChars.Contains(currentChar))
                {
                    recordedChars.Add(currentChar);
                    for (int j = i+1; j < input.Length; j++)
                    {
                        if (currentChar==input[j])
                        {
                            count++;
                        }
                    }
                    Tuple<char, int> currentPair = Tuple.Create(currentChar, count);
                    returnList.Add(currentPair);
                }
            }
            return returnList;
        }
    }
}
