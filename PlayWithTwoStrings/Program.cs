using System;

namespace PlayWithTwoStrings
{
    class Program
    {
        /*Input Strings a and b: For every character in string a swap the casing of every occurrence of the same character in string b. 
         * Then do the same casing swap with the inputs reversed. 
         * Return a single string consisting of the changed version of a followed by the changed version of b. 
         * A char of a is in b regardless if it's in upper or lower case
         * 
         * a) swap the case of characters in string b for every occurrence of that character in string a
         * char 'a' occurs twice in string a, so we swap all 'a' in string b twice. This means we start with "bababa" then "bAbAbA" => "bababa"
         * char 'b' occurs twice in string a and so string b moves as follows: start with "bababa" then "BaBaBa" => "bababa"
         * 
         * b) then, swap the case of characters in string a for every occurrence in string b
         * char 'a' occurs 3 times in string b. So string a swaps cases as follows: start with "abab" then => "AbAb" => "abab" => "AbAb"
         * char 'b' occurs 3 times in string b. So string a swaps as follow: start with "AbAb" then => "ABAB" => "AbAb" => "ABAB".
         * 
         * c) merge new strings a and b
         * return "ABABbababa"
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Combine two strings after switching the case of each character an inordinate number of times.\n");

        }
        public string WorkOnStrings(string a, string b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (Char.ToLower(a[i])==Char.ToLower(b[i]))
                    {
                        if (Char.IsUpper(b[i]))
                        {
                            //b[i] = Char.ToLower(b[i]);
                        }
                    }
                }

            }
            return a + b;
        }
    }
}
