using System;

namespace Isograms
{
    class Program
    {
        /*
         * An isogram is a word that has no repeating letters, consecutive or non-consecutive. 
         * Implement a function that determines whether a string that contains only letters is an isogram. 
         * Assume the empty string is an isogram. Ignore letter case.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Determine whether or not a word is an isogram.\n");
            string str= "Dermatoglyphics";
            string str1 = "aba";
            string str2 = "moOse";
            Console.WriteLine($"{str} is an Isogram: {IsIsogram(str)}\n");
            Console.WriteLine($"{str1} is an Isogram: {IsIsogram(str1)}\n");
            Console.WriteLine($"{str2} is an Isogram: {IsIsogram(str2)}\n");
        }

        public static bool IsIsogram(string str)
        {
            bool isIsogram = true;
            string lower = str.ToLower();//To ignore letter case
            for (int i = 0; i < lower.Length; i++)
            {
                for (int j = i+1; j < lower.Length; j++)
                {
                    if (String.Equals(lower[i],lower[j]))
                    {
                        isIsogram = false;
                    }

                }
            }
            return isIsogram;
        }
    }
}
