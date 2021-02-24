using System;
using System.Text;

namespace StringToCamelCase
{
    class Program
    {
        /*
         Complete the method/function so that it converts dash/underscore delimited words into camel casing. 
         The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).

         Examples:
         "the-stealth-warrior" gets converted to "theStealthWarrior"
         "The_Stealth_Warrior" gets converted to "TheStealthWarrior"
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Convert a '-' or '_' delimited string to Camel Case (unless the first letter was capitalized already) with no spaces between words.\n");
            Console.WriteLine($"{ToCamelCase("the-stealth-warrior")}");
            Console.WriteLine($"{ToCamelCase("The_Stealth_Warrior")}");
            Console.WriteLine($"{ToCamelCase("dxmvojpaqw_qjaoyoxnqs-Mmxfjdcagb")}");
            //string[] dashesFirst = "the-stealth-warrior_Looks_Cool".Split('-');
            //foreach (string str in dashesFirst)
            //{
            //    Console.WriteLine($"{str}\n");
            //}
            //string[] underscoresFirst = "the_stealth_warrior-Looks-Cool".Split('_');
            //foreach (string str in underscoresFirst)
            //{
            //    Console.WriteLine($"{str}\n");
            //}
            //string[] mixedUnder = "the_stealth-warrior-Looks_Cool".Split('_');
            //foreach (string str in mixedUnder)
            //{
            //    Console.WriteLine($"{str}\n");
            //}
            //string[] mixedDash = "the-stealth_warrior-Looks_Cool".Split('_');
            //foreach (string str in mixedDash)
            //{
            //    Console.WriteLine($"{str}\n");
            //}
            //string[] splitSimultaneously = "the-stealth_warrior-Looks_Cool".Split('_', '-');
            //foreach (string str in splitSimultaneously)
            //{
            //    Console.WriteLine($"{str}\n");
            //}

        }

        public static string ToCamelCase(string str)
        {
            string[] strings = str.Split('_', '-');
            for (int i = 0; i < strings.Length; i++)
            {
                string currentWord = strings[i];
                char firstLetter = currentWord[0];
                if (i == 0 && (97 <= firstLetter && firstLetter <= 122))
                {
                    continue;
                }
                else if (i == 0 && (65 <= firstLetter && firstLetter <= 90))
                {
                    continue;
                }
                else if (97 <= firstLetter && firstLetter <= 122)
                {
                    int firstChar = (int)firstLetter;
                    firstChar -= 32;
                    firstLetter = (char)firstChar;
                    char[] letters = currentWord.ToCharArray();
                    letters[0] = firstLetter;
                    strings[i] = new string(letters);
                }
            }
            string camelCase = "";
            foreach (string word in strings)
            {
                camelCase += word;
            }
            return camelCase;
        }
    }
}
