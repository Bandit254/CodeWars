using System;

namespace StatsForAthleticAssociation
{
    class Program
    {
        /*
        You are the "computer expert" of a local Athletic Association (C.A.A.). Many teams of runners come to compete. Each time you get a string of all race results of every team who has run. 
        For example here is a string showing the individual results of a team of 5 runners:

        "01|15|59, 1|47|6, 01|17|20, 1|32|34, 2|3|17"

        Each part of the string is of the form: h|m|s where h, m, s (h for hour, m for minutes, s for seconds) are positive or null integer (represented as strings) with one or two digits. 
        There are no traps in this format.

        To compare the results of the teams you are asked for giving three statistics; range, average and median.

        Range : difference between the lowest and highest values. In {4, 6, 9, 3, 7} the lowest value is 3, and the highest is 9, so the range is 9 − 3 = 6.

        Mean or Average : To calculate mean, add together all of the numbers in a set and then divide the sum by the total count of numbers.

        Median : In statistics, the median is the number separating the higher half of a data sample from the lower half. 
        The median of a finite list of numbers can be found by arranging all the observations from lowest value to highest value and picking the middle one (e.g., the median of {3, 3, 5, 9, 11} is 5) when there is an odd number of observations. 
        If there is an even number of observations, then there is no single middle value; the median is then defined to be the mean of the two middle values (the median of {3, 5, 6, 9} is (5 + 6) / 2 = 5.5).

        Your task is to return a string giving these 3 values. For the example given above, the string result will be

        "Range: 00|47|18 Average: 01|35|15 Median: 01|32|34"

        of the form: "Range: hh|mm|ss Average: hh|mm|ss Median: hh|mm|ss"`

        where hh, mm, ss are integers (represented by strings) with each 2 digits.

        Remarks:
        if a result in seconds is ab.xy... it will be given truncated as ab.
        if the given string is "" you will return "" 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program that can analyze the running times of a team of runners (given as strings) and return the Range, Average, and Median times for the team.\n");
            //int[] test = new int[] { 3, 6, 2, 1, 0, 8, 200 };
            //Array.Sort(test);
            //foreach (int num in test)
            //{
            //    Console.WriteLine($"{num}");
            //}
            //int testNum = 9317;
            //int hrs = testNum / 3600;
            //testNum = testNum - (hrs* 3600);
            //int min = testNum / 60;
            //testNum = testNum - (min * 60);
            //int sec = testNum;
            //Console.WriteLine($"Hours = {hrs}, Minutes = {min}, Seconds = {sec}");
            Console.WriteLine($"{CalculateTeamStats("01|15|59, 1|47|16, 01|17|20, 1|32|34, 2|17|17")}");
            Console.WriteLine($"{CalculateTeamStats("02|15|59, 2|47|16, 02|17|20, 2|32|34, 2|17|17, 2|22|00, 2|31|41")}");

        }

        public static string CalculateTeamStats(string strg)
        {
            if (String.Equals(strg,""))
            {
                return "";
            }
            string[] inputTimes = strg.Split(",");
            for (int i = 0; i < inputTimes.Length; i++)
            {
                inputTimes[i] = inputTimes[i].Trim();
            }
            int[] parsedRunnerTimes = new int[inputTimes.Length];
            for (int i = 0; i < inputTimes.Length; i++)
            {
                string[] runnerTime = inputTimes[i].Split("|");
                parsedRunnerTimes[i] = Convert.ToInt32(runnerTime[0]) * 3600 + Convert.ToInt32(runnerTime[1]) * 60 + Convert.ToInt32(runnerTime[2]);
            }
            Array.Sort(parsedRunnerTimes);
            int rangeTotalSeconds = parsedRunnerTimes[parsedRunnerTimes.Length - 1] - parsedRunnerTimes[0];
            double averageTotalSeconds = 0;
            double sumTimes = 0;
            for (int i = 0; i < parsedRunnerTimes.Length; i++)
            {
                sumTimes += Convert.ToDouble(parsedRunnerTimes[i]);
            }
            averageTotalSeconds = sumTimes / parsedRunnerTimes.Length;
            double medianTotalSeconds = 0;
            if (parsedRunnerTimes.Length % 2 != 0)
            {
                medianTotalSeconds = Convert.ToDouble(parsedRunnerTimes[parsedRunnerTimes.Length / 2]);
            }
            else
            {
                double upper = Convert.ToDouble(parsedRunnerTimes[parsedRunnerTimes.Length / 2]);
                double lower = Convert.ToDouble(parsedRunnerTimes[parsedRunnerTimes.Length / 2 - 1]);
                medianTotalSeconds = (upper + lower) / 2;
            }

            int[] finalValues = new int[9];

            finalValues[0] = rangeTotalSeconds / 3600;
            rangeTotalSeconds = rangeTotalSeconds - (finalValues[0] * 3600);
            finalValues[1] = rangeTotalSeconds / 60;
            rangeTotalSeconds = rangeTotalSeconds - (finalValues[1] * 60);
            finalValues[2] = rangeTotalSeconds;

            finalValues[3] = Convert.ToInt32(Math.Truncate(averageTotalSeconds / 3600));
            averageTotalSeconds = averageTotalSeconds - (finalValues[3] * 3600);
            finalValues[4] = Convert.ToInt32(Math.Truncate(averageTotalSeconds / 60));
            averageTotalSeconds = averageTotalSeconds - (finalValues[4] * 60);
            finalValues[5] = Convert.ToInt32(Math.Truncate(averageTotalSeconds));

            finalValues[6] = Convert.ToInt32(Math.Truncate(medianTotalSeconds / 3600));
            medianTotalSeconds = medianTotalSeconds - (finalValues[6] * 3600);
            finalValues[7] = Convert.ToInt32(Math.Truncate(medianTotalSeconds / 60));
            medianTotalSeconds = medianTotalSeconds - (finalValues[7] * 60);
            finalValues[8] = Convert.ToInt32(Math.Truncate(medianTotalSeconds));

            string[] finalStringValues = new string[9];
            for (int i = 0; i < finalValues.Length; i++)
            {
                if (finalValues[i]<10)
                {
                    finalStringValues[i] = "0" + finalValues[i];
                }
                else
                {
                    finalStringValues[i] = Convert.ToString(finalValues[i]);
                }
            }

            return $"Range: {finalStringValues[0]}|{finalStringValues[1]}|{finalStringValues[2]} Average: {finalStringValues[3]}|{finalStringValues[4]}|{finalStringValues[5]} Median: {finalStringValues[6]}|{finalStringValues[7]}|{finalStringValues[8]}";
        }
    }
}
