using System;

namespace Disemvowell_Trolls
{
    class Program
    {
        /*
         Trolls are attacking your comment section!

A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

Your task is to write a function that takes a string and return a new string with all vowels removed.

For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

Note: for this kata y isn't considered a vowel.
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Remove the vowels from a given string.\n");
            string str = "This website is for losers LOL!";
            Console.WriteLine($"{Disemvowell(str)}");
        }
        //My Solution:
        public static string Disemvowell(string str)
        {
            string returnString = "";
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                        returnString += "";
                        break;
                    case 'e':
                        returnString += "";
                        break;
                    case 'i':
                        returnString += "";
                        break;
                    case 'o':
                        returnString += "";
                        break;
                    case 'u':
                        returnString += "";
                        break;
                    case 'A':
                        returnString += "";
                        break;
                    case 'E':
                        returnString += "";
                        break;
                    case 'I':
                        returnString += "";
                        break;
                    case 'O':
                        returnString += "";
                        break;
                    case 'U':
                        returnString += "";
                        break;
                    default:
                        returnString += str[i];
                        break;
                }
            }
            return returnString;
        }

        /*Other Solutions from CodeWarriors:
         
        public static string Disemvowel(string str)
        {
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }

        public static string Disemvowel(string str)
         {
            return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
         }

        public static string Disemvowel(string str)
         {
             string strNew = "";

            string[] strings = str.Split('a', 'u', 'e', 'i', 'o', 'A', 'U', 'E', 'I', 'O');

            foreach (var item in strings)
            {
                strNew += item;
            }
            
            return strNew;
            }


        */
    }
}
