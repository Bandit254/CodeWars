using System;
using System.Collections.Generic;
namespace EncryptThis
{
    class Program
    {
        /*Encrypt this!
        You want to create secret messages which can be deciphered by the Decipher this! kata. Here are the conditions:
        Your message is a string containing space separated words.
        You need to encrypt each word in the message using the following rules:
        The first letter needs to be converted to its ASCII code.
        The second letter needs to be switched with the last letter
        Keepin' it simple: There are no special characters in input.
        Examples:
        Kata.EncryptThis("Hello") == "72olle"
        Kata.EncryptThis("good") == "103doo"
        Kata.EncryptThis("hello world") == "104olle 119drlo"
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Encrypt a given string");
            string input1 = "";
            string input2 = "A";
            string input3 = "Ab";
            string input4 = "Abc";
            string input5 = "Abcd";
            string input6 = "A wise old owl lived in an oak";
            string input7 = "The more he saw the less he spoke";
            string input8 = "The less he spoke the more he heard";
            string input9 = "Why can we not all be like that wise old bird";
            string input10 = "Thank you Piotr for all your help";
            Console.WriteLine($"{EncryptThis(input1)}");
            Console.WriteLine($"{EncryptThis(input2)}");
            Console.WriteLine($"{EncryptThis(input3)}");
            Console.WriteLine($"{EncryptThis(input4)}");
            Console.WriteLine($"{EncryptThis(input5)}");
            Console.WriteLine($"{EncryptThis(input6)}");
            Console.WriteLine($"{EncryptThis(input7)}");
            Console.WriteLine($"{EncryptThis(input8)}");
            Console.WriteLine($"{EncryptThis(input9)}");
            Console.WriteLine($"{EncryptThis(input10)}");
        }

        public static string EncryptThis(string input)
        {
            string encryptedString = "";
            if (String.Equals(input,""))
            {
                return encryptedString;
            }
            string[] unencryptedSubStrings = input.Split(' ');
            string[] encryptedSubstrings = new string[unencryptedSubStrings.Length];
            for (int i = 0; i < unencryptedSubStrings.Length; i++)
            {
                string unSub = unencryptedSubStrings[i];
                string enSub = "";
                int firstLetter = (int)unSub[0];
                enSub += firstLetter.ToString();
                if (unSub.Length>2)
                {
                    for (int j = 1; j < unSub.Length; j++)
                    {
                        if (j==1)
                        {
                            enSub += unSub[unSub.Length - 1];
                        }
                        else if (j==unSub.Length-1)
                        {
                            enSub += unSub[1];
                        }
                        else
                        {
                            enSub += unSub[j];
                        }
                    }
                }
                else if(unSub.Length==2)
                {
                    enSub += unSub[1];
                }
                encryptedSubstrings[i] = enSub;
            }
            for (int k = 0; k < encryptedSubstrings.Length; k++)
            {
                if (k!=encryptedSubstrings.Length-1)
                {
                    encryptedString += $"{encryptedSubstrings[k]} ";
                }
                else
                {
                    encryptedString += $"{encryptedSubstrings[k]}";
                }
            }
            return encryptedString;
        }
    }
}
