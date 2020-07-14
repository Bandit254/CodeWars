using System;
using System.Collections.Generic;

namespace BestSoccerMatch
{
    class Program
    {
        /*
         * "AL-AHLY" and "Zamalek" are the best teams in Egypt, but "AL-AHLY" always wins the matches between them. 
         * "Zamalek" managers want to know what is the best match they've played so far.
         * The best match is the match they lost with the minimum goal difference.
         * If there is more than one match with the same difference, choose the one "Zamalek" scored more goals in. 
         * Given the information about all matches they played, return the index of the best match (0-based). 
         * If more than one valid result, return the smallest index.
         * Example
         * For ALAHLYGoals = [6,4] and zamalekGoals = [1,2], the output should be 1.
         * Because 4 - 2 is less than 6 - 1
         * For ALAHLYGoals = [1,2,3,4,5] and zamalekGoals = [0,1,2,3,4], the output should be 4.
         * The goal difference of all matches are 1, but at 4th match "Zamalek" scored more goals in. So the result is 4.
         * Input/Output
         * [input] integer array ALAHLYGoals
         * The number of goals "AL-AHLY" scored in each match.
         * [input] integer array zamalekGoals
         * The number of goals "Zamalek" scored in each match. It is guaranteed that zamalekGoals[i] < ALAHLYGoals[i] for each element.
         * [output] an integer
         * Index of the best match.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that determine's Zamalek's best loss(es) against AL-AHLY.\n");
            Console.WriteLine($"{BestMatch(new int[] { 6, 4 }, new int[] { 1, 2 })}.\n");
            Console.WriteLine($"{BestMatch(new int[] { 1 }, new int[] { 0 })}.\n");
            Console.WriteLine($"{BestMatch(new int[] { 1, 2, 3, 4, 5 }, new int[] { 0, 1, 2, 3, 4 })}.\n");
            Console.WriteLine($"{BestMatch(new int[] { 3, 4, 3 }, new int[] { 1, 1, 2 })}.\n");
            Console.WriteLine($"{BestMatch(new int[] { 4, 3, 4 }, new int[] { 1, 1, 1 })}.\n");
            Console.WriteLine($"{BestMatch(new int[] { 9, 8, 15, 16, 12, 5, 9, 15, 7, 17, 9, 13, 15, 18, 8 }, new int[] { 3, 0, 6, 10, 7, 3, 4, 10, 3, 10, 5, 4, 10, 9, 6})}.\n");
        }
        public static int BestMatch(int[] goals1, int[] goals2)
        {
            int bestMatchIndex = 0;
            int[] goalDifferentials = new int[goals2.Length];
            for (int i = 0; i < goals1.Length; i++)
            {
                goalDifferentials[i] = goals1[i] - goals2[i];
            }
            int minGoalDiff = 10000;
            for (int i = 0; i < goalDifferentials.Length; i++)
            {
                if (minGoalDiff>goalDifferentials[i])
                {
                    minGoalDiff = goalDifferentials[i];
                }
            }
            List<int> minGoalIndexes = new List<int>();
            for (int i = 0; i < goalDifferentials.Length; i++)
            {
                if (goalDifferentials[i]==minGoalDiff)
                {
                    minGoalIndexes.Add(i);
                }
            }
            if (minGoalIndexes.Count==1)
            {
                bestMatchIndex = minGoalIndexes[0];
                return bestMatchIndex;
            }
            int zamalekMaxGoals = 0;
            int maxGoalIndex = 0;
            for (int i = 0; i < minGoalIndexes.Count; i++)
            {
                if (zamalekMaxGoals < goals2[minGoalIndexes[i]])
                {
                    zamalekMaxGoals = goals2[minGoalIndexes[i]];
                    maxGoalIndex = minGoalIndexes[i];
                }
            }
            for (int i = 0; i < minGoalIndexes.Count; i++)
            {
                if (minGoalIndexes[i]==maxGoalIndex)
                {
                    bestMatchIndex = minGoalIndexes[i];
                }
            }
            return bestMatchIndex;
        }
    }
}
