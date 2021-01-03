using System;

namespace EasyTimeConvert
{
    class Program
    {
        /*
        This kata requires you to convert minutes(int) to hours and minutes in the format hh:mm(string).
        If the input is 0 or negative value, then you should return "00:00"
        Hint: use the modulo operation to solve this challenge.The modulo operation simply returns the remainder after a division.For example the remainder of 5 / 2 is 1, so 5 modulo 2 is 1.
        Example
        If the input is 78, then you should return "01:18", because 78 minutes converts to 1 hour and 18 minutes.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that converts a given number of minutes into a string representing the corresponding hours and minutes.\n");
            Console.WriteLine($"{TimeConvert(0)}");
            Console.WriteLine($"{TimeConvert(-6)}");
            Console.WriteLine($"{TimeConvert(8)}");
            Console.WriteLine($"{TimeConvert(32)}");
            Console.WriteLine($"{TimeConvert(75)}");
        }

        public static string TimeConvert(int num)
        {
            if (num <= 0)
            {
                return "00:00";
            }
            int hours = num / 60;
            int minutes = num % 60;
            string hoursStr = "";
            string minStr = "";
            if (hours < 10)
            {
                hoursStr = "0" + $"{hours}";
            }
            else
            {
                hoursStr = $"{hours}";            
            }
            if (minutes < 10)
            {
                minStr = "0" + $"{minutes}";
            }
            else
            {
                minStr = $"{minutes}";
            }
            string time = hoursStr + ":" + minStr;
            return time;
        }
    }
}
