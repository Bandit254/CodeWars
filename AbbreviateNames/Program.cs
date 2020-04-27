using System;

namespace AbbreviateNames
{
    class Program
    {
        /*
         * Write a function to convert a name into initials. 
         * This kata strictly takes two words with one space in between them.
           The output should be two capital letters with a dot separating them.
           It should look like this:
           Sam Harris => S.H
           Patrick Feeney => P.F 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that accepts two words and returns the first letter of each word separated by a period.\n");
            string name1 = "Sam Harris";
            Console.WriteLine($"The abbreviation of {name1} is {AbbreviateNames(name1)}");
            string name2 = "Patrick Feeney";
            Console.WriteLine($"The abbreviation of {name2} is {AbbreviateNames(name2)}");
        }
        public static string AbbreviateNames(string name)
        {
            string[] array = name.Split(' ', 2);
            string firstLetter = Convert.ToString(array[0][0]);
            string secondLetter = Convert.ToString(array[1][0]);
            string abbreviation =  firstLetter.ToUpper()+ "." + secondLetter.ToUpper();
            return abbreviation;
        }
    }
}
