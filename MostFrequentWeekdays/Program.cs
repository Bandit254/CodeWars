using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace MostFrequentWeekdays
{
    class Program
    {
        /*What is your favourite day of the week? Check if it's the most frequent day of the week in the year.
        You are given a year as integer (e. g. 2001). You should return the most frequent day(s) of the week in that year. 
        The result has to be a list of days sorted by the order of days in week (e. g. ['Monday', 'Tuesday'], ['Saturday', 'Sunday'], ['Monday', 'Sunday']). 
        Week starts with Monday.
        Input: Year as an int.
        Output: The list of most frequent days sorted by the order of days in week (from Monday to Sunday).
        Preconditions:
        Week starts on Monday.
        Year is between 1583 and 4000.
        Calendar is Gregorian.
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("You are given a year as integer (e. g. 2001). You should return the most frequent day(s) of the week in that year.\n");
            int year1 = 2427;
            int year2 = 2185;
            int year3 = 2860;
            int year4 = 2016;
            int year5 = 1770;
            int year6 = 2001;
            int year7 = 1968;
            int year8 = 1785;
            int year9 = 1910;
            int year10 = 2135;
            int year11 = 3043;
            int year12 = 3150;
            int year13 = 3361;
            int year14 = 1901;
            int year15 = 3230;
            int year16 = 1794;
            int year17 = 1986;
            Console.WriteLine($"The most frequent day(s) in the year {year1} is:\n");
            foreach (string day in MostFrequentDays(year1))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year2} is:\n");
            foreach (string day in MostFrequentDays(year2))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year3} is:\n");
            foreach (string day in MostFrequentDays(year3))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year4} is:\n");
            foreach (string day in MostFrequentDays(year4))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year5} is:\n");
            foreach (string day in MostFrequentDays(year5))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year6} is:\n");
            foreach (string day in MostFrequentDays(year6))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year7} is:\n");
            foreach (string day in MostFrequentDays(year7))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year8} is:\n");
            foreach (string day in MostFrequentDays(year8))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year9} is:\n");
            foreach (string day in MostFrequentDays(year9))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year10} is:\n");
            foreach (string day in MostFrequentDays(year10))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year11} is:\n");
            foreach (string day in MostFrequentDays(year11))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year12} is:\n");
            foreach (string day in MostFrequentDays(year12))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year13} is:\n");
            foreach (string day in MostFrequentDays(year13))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year14} is:\n");
            foreach (string day in MostFrequentDays(year14))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year15} is:\n");
            foreach (string day in MostFrequentDays(year15))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year16} is:\n");
            foreach (string day in MostFrequentDays(year16))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The most frequent day(s) in the year {year17} is:\n");
            foreach (string day in MostFrequentDays(year17))
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine("\n");
        }
        public static string[] MostFrequentDays(int year)
        {
            if (year<1583 || year>4000)
            {
                return new string[0];
            }
            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);
            int daysInYear = lastDay.Subtract(firstDay).Days;
            int mondays = 0;
            int tuesdays = 0;
            int wednesdays = 0;
            int thursdays = 0;
            int fridays = 0;
            int saturdays = 0;
            int sundays = 0;
            DateTime nextDay = firstDay.AddDays(1);

            if (String.Equals("Monday",firstDay.DayOfWeek.ToString()))
            {
                mondays++;
            }
            else if (String.Equals("Tuesday", firstDay.DayOfWeek.ToString()))
            {
                tuesdays++;
            }
            else if (String.Equals("Wednesday", firstDay.DayOfWeek.ToString()))
            {
                wednesdays++;
            }
            else if (String.Equals("Thursday", firstDay.DayOfWeek.ToString()))
            {
                thursdays++;
            }
            else if (String.Equals("Friday", firstDay.DayOfWeek.ToString()))
            {
                fridays++;
            }
            else if (String.Equals("Saturday", firstDay.DayOfWeek.ToString()))
            {
                saturdays++;
            }
            else if (String.Equals("Sunday", firstDay.DayOfWeek.ToString()))
            {
                sundays++;
            }

            if (String.Equals("Monday", nextDay.DayOfWeek.ToString()))
            {
                mondays++;
            }
            else if (String.Equals("Tuesday", nextDay.DayOfWeek.ToString()))
            {
                tuesdays++;
            }
            else if (String.Equals("Wednesday", nextDay.DayOfWeek.ToString()))
            {
                wednesdays++;
            }
            else if (String.Equals("Thursday", nextDay.DayOfWeek.ToString()))
            {
                thursdays++;
            }
            else if (String.Equals("Friday", nextDay.DayOfWeek.ToString()))
            {
                fridays++;
            }
            else if (String.Equals("Saturday", nextDay.DayOfWeek.ToString()))
            {
                saturdays++;
            }
            else if (String.Equals("Sunday", nextDay.DayOfWeek.ToString()))
            {
                sundays++;
            }

            while (nextDay<lastDay)
            {
                nextDay = nextDay.AddDays(1);
                if (String.Equals("Monday", nextDay.DayOfWeek.ToString()))
                {
                    mondays++;
                }
                else if (String.Equals("Tuesday", nextDay.DayOfWeek.ToString()))
                {
                    tuesdays++;
                }
                else if (String.Equals("Wednesday", nextDay.DayOfWeek.ToString()))
                {
                    wednesdays++;
                }
                else if (String.Equals("Thursday", nextDay.DayOfWeek.ToString()))
                {
                    thursdays++;
                }
                else if (String.Equals("Friday", nextDay.DayOfWeek.ToString()))
                {
                    fridays++;
                }
                else if (String.Equals("Saturday", nextDay.DayOfWeek.ToString()))
                {
                    saturdays++;
                }
                else if (String.Equals("Sunday", nextDay.DayOfWeek.ToString()))
                {
                    sundays++;
                }
            }
            List<string> mostCommonDays = new List<string>();
            if (mondays>=tuesdays && mondays >= wednesdays && mondays >= thursdays && mondays >= fridays && mondays >= saturdays && mondays >= sundays)
            {
                mostCommonDays.Add("Monday");
            }
            if (tuesdays >= mondays && tuesdays >= wednesdays && tuesdays >= thursdays && tuesdays >= fridays && tuesdays >= saturdays && tuesdays >= sundays)
            {
                mostCommonDays.Add("Tuesday");
            }
            if (wednesdays >= mondays && wednesdays >= tuesdays && wednesdays >= thursdays && wednesdays >= fridays && wednesdays >= saturdays && wednesdays >= sundays)
            {
                mostCommonDays.Add("Wednesday");
            }
            if (thursdays >= mondays && thursdays >= tuesdays && thursdays >= wednesdays && thursdays >= fridays && thursdays >= saturdays && thursdays >= sundays)
            {
                mostCommonDays.Add("Thursday");
            }
            if (fridays >= mondays && fridays >= tuesdays && fridays >= wednesdays && fridays >= thursdays && fridays >= saturdays && fridays >= sundays)
            {
                mostCommonDays.Add("Friday");
            }
            if (saturdays >= mondays && saturdays >= tuesdays && saturdays >= wednesdays && saturdays >= thursdays && saturdays >= fridays && saturdays >= sundays)
            {
                mostCommonDays.Add("Saturday");
            }
            if (sundays >= mondays && sundays >= tuesdays && sundays >= wednesdays && sundays >= thursdays && sundays >= fridays && sundays >= saturdays)
            {
                mostCommonDays.Add("Sunday");
            }
            string[] mostCommonDayArray = mostCommonDays.ToArray();
            return mostCommonDayArray;
        }
    }
}
