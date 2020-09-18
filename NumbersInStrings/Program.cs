using System;
using System.Collections.Generic;

namespace NumbersInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a string that contains at least two groups of digits, return the group of digits that makes the largest number.\n");
            string test1 = "gh12cdy695m1";
            string test2 = "2ti9iei7qhr5";
            string test3 = "vih61w8oohj5";
            string test4 = "f7g42g16hcu5";
            string test5 = "lu1j8qbbb85";
            Console.WriteLine($"{CompareNumbersInStrings(test1)}\n");
            Console.WriteLine($"{CompareNumbersInStrings(test2)}\n");
            Console.WriteLine($"{CompareNumbersInStrings(test3)}\n");
            Console.WriteLine($"{CompareNumbersInStrings(test4)}\n");
            Console.WriteLine($"{CompareNumbersInStrings(test5)}\n");

        }

        public static int CompareNumbersInStrings(string s)
        {
            List<int> numberGroups = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]=='0'|| s[i] == '1' || s[i] == '2' || s[i] == '3' || s[i] == '4' || s[i] == '5' || s[i] == '6' || s[i] == '7' || s[i] == '8' || s[i] == '9')
                {
                    string num = Convert.ToString(s[i]);
                    int nextIndex = i+1;
                    while (nextIndex <= s.Length-1 && (s[nextIndex] == '0' || s[nextIndex] == '1' || s[nextIndex] == '2' || s[nextIndex] == '3' || s[nextIndex] == '4' || s[nextIndex] == '5' || s[nextIndex] == '6' || s[nextIndex] == '7' || s[nextIndex] == '8' || s[nextIndex] == '9'))
                    {
                        num += s[nextIndex];
                        nextIndex++;
                    }
                    int currentNumber = Convert.ToInt32(num);
                    numberGroups.Add(currentNumber);
                }
            }
            numberGroups.Sort();
            return numberGroups[numberGroups.Count-1];
        }
    }
}
