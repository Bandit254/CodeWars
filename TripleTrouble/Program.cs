using System;

namespace TripleTrouble
{
    class Program
    {
        /*
         * Create a function that will return a string that combines all of the letters of the three inputed strings in groups. 
         * Taking the first letter of all of the inputs and grouping them next to each other. 
         * Do this for every letter, see example below!
         * E.g. Input: "aa", "bb" , "cc" => Output: "abcabc"
         * Note: You can expect all of the inputs to be the same length.
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that combines the first (and each subsequent) letters of three uniform-length input strings.\n");
            string one = "aa";
            string two = "bb";
            string three = "cc";
            Console.WriteLine($"The combination, in sequence, of all the letters in the three strings is: {TripleTrouble(one, two, three)}.\n");
        }

        public static string TripleTrouble(string one, string two, string three)
        {
            string tripleString="";
            for (int i = 0; i < one.Length; i++)
            {
                tripleString += one[i];
                tripleString += two[i];
                tripleString += three[i];
            }
            return tripleString;
        }
    }
}
