using System;
using System.Collections.Generic;

namespace TitleCase
{
    class Program
    {
        /*
         * A string is considered to be in title case if each word in the string is either 
         * (a) capitalized (that is, only the first letter of the word is in upper case) or 
         * (b) considered to be an exception and put entirely into lower case unless it is the first word, which is always capitalised.
         * Write a function that will convert a string into title case, given an optional list of exceptions (minor words). 
         * The list of minor words will be given as a string with each word separated by a space. 
         * Your function should ignore the case of the minor words string -- it should behave in the same way even if the case of the minor word string is changed.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Convert a given string into Title Case while ignoring a given set of minor words (such as 'the').\n");
            Console.WriteLine($"{TitleCase("a clash of KINGS", "a an the of")}.\n");
            Console.WriteLine($"{TitleCase("THE WIND IN THE WILLOWS", "The In")}.\n");
            Console.WriteLine($"{TitleCase("")}.\n");
            Console.WriteLine($"{TitleCase("the quick brown fox")}.\n");
            Console.WriteLine($"{TitleCase("aBC deF Ghi",null)}.\n");
        }
        public static string TitleCase(string title, string minorWords = "")
        {
            if (title=="")
            {
                return "";
            }
            title = title.ToLower();
            string[] titleArray = title.Split(' ');
            if (minorWords != "" && minorWords != null)
            {
                minorWords = minorWords.ToLower();
            }
            List<string> minorList = new List<string>();
            if (minorWords!=null)
            {
                string[] minorWordsArray = minorWords.Split(' ');
                for (int i = 0; i < minorWordsArray.Length; i++)
                {
                    minorList.Add(minorWordsArray[i]);
                }
            }
            string[] lilWordArray = minorList.ToArray();

            for (int i = 0; i < titleArray.Length; i++)
            {
                if (i==0)
                {
                    string firstWord = "";
                    firstWord += Char.ToUpper(titleArray[i][0]);
                    for (int j = 1; j < titleArray[i].Length; j++)
                    {
                        firstWord += titleArray[i][j];
                    }
                    titleArray[i] = firstWord;
                }
                else
                {
                    if ((minorWords!="" && minorWords!=null))
                    {
                        bool isMinor = false;
                        for (int h = 0; h < lilWordArray.Length; h++)
                        {
                            if (lilWordArray[h]==titleArray[i])
                            {
                                isMinor = true;
                            }
                        }
                        if (isMinor==true)
                        {
                            continue;
                        }
                    }
                    string currentWord = "";
                    currentWord += Char.ToUpper(titleArray[i][0]);
                    for (int k = 1; k < titleArray[i].Length; k++)
                    {
                        currentWord += titleArray[i][k];
                    }
                    titleArray[i] = currentWord;
                }
            }
            string titleCaseString = "";
            for (int i = 0; i < titleArray.Length; i++)
            {
                if (i!=titleArray.Length-1)
                {
                    titleCaseString += $"{titleArray[i]} ";
                }
                else
                {
                    titleCaseString += titleArray[i];
                }
            }
            return titleCaseString;
        }
    }
}
