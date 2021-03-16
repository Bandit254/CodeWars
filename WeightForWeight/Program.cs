using System;
using System.Collections.Generic;

namespace WeightForWeight
{
    class Program
    {
        /*
        My friend John and I are members of the "Fat to Fit Club (FFC)". John is worried because each month a list with the weights of members is published and each month he is the last on the list which means he is the heaviest.
        I am the one who establishes the list so I told him: "Don't worry any more, I will modify the order of the list". It was decided to attribute a "weight" to numbers. The weight of a number will be from now on the sum of its digits.
        For example 99 will have "weight" 18, 100 will have "weight" 1 so in the list 100 will come before 99.
        Given a string with the weights of FFC members in normal order can you give this string ordered by "weights" of these numbers?

        Example:
        "56 65 74 100 99 68 86 180 90" ordered by numbers weights becomes: 
        
        "100 180 90 56 65 74 68 86 99"
        
        When two numbers have the same "weight", let us class them as if they were strings (alphabetical ordering) and not numbers:
        
        180 is before 90 since, having the same "weight" (9), it comes before as a string.
        
        All numbers in the list are positive numbers and the list can be empty.
        
        Note:
        It may happen that the input string have leading, trailing whitespaces and more than a unique whitespace between two consecutive numbers
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that orders a list of people's weights by a 'weight' calculated by the adding the digits of the person's weight.\n");
            Console.WriteLine($"{orderWeight("103 123 4444 99 2000")}");
            Console.WriteLine($"{orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123")}");
        }

        public static string orderWeight(string strng)
        {
            string[] splitStrng = strng.Split();
            List<string> stringWeights = new List<string>();
            for (int i = 0; i < splitStrng.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(splitStrng[i]))
                {
                    continue;
                }
                stringWeights.Add(splitStrng[i]);
            }
            List<long> weights = new List<long>();
            for (int i = 0; i < stringWeights.Count; i++)
            {
                long weightLng = Convert.ToInt64(stringWeights[i]);
                long weight = 0;
                while (weightLng > 0)
                {
                    weight += weightLng % 10;
                    weightLng /= 10;
                }
                weights.Add(weight);
            }
            for (int i = 0; i < weights.Count-1; i++)
            {
                for (int j = i+1; j < weights.Count; j++)
                {
                    if (weights[j] < weights[i])
                    {
                        long tempWeight = weights[j];
                        weights[j] = weights[i];
                        weights[i] = tempWeight;
                        string tempString = stringWeights[j];
                        stringWeights[j] = stringWeights[i];
                        stringWeights[i] = tempString;
                    }
                }
            }
            for (int i = 0; i < weights.Count-1; i++)
            {
                for (int j = i+1; j < weights.Count; j++)
                {
                    if (weights[j] == weights[i])
                    {
                        bool swapped = false;
                        string numJ = stringWeights[j];
                        string numI = stringWeights[i];
                        if (numJ.Length < numI.Length && numI[0] == numI[0])
                        {
                            long tempWeight = weights[j];
                            weights[j] = weights[i];
                            weights[i] = tempWeight;
                            string tempString = stringWeights[j];
                            stringWeights[j] = stringWeights[i];
                            stringWeights[i] = tempString;
                        }
                        else
                        {
                            for (int k = 0; k < numJ.Length; k++)
                            {
                                for (int l = 0; l < numI.Length; l++)
                                {
                                    if (numJ[k] < numI[l])
                                    {
                                        long tempWeight = weights[j];
                                        weights[j] = weights[i];
                                        weights[i] = tempWeight;
                                        string tempString = stringWeights[j];
                                        stringWeights[j] = stringWeights[i];
                                        stringWeights[i] = tempString;
                                        swapped = true;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                    if (swapped)
                                    {
                                        break;
                                    }
                                }
                                if (swapped)
                                {
                                    break;
                                }
                            }
                        }
                        
                    }
                }
            }
            string weightedList = "";
            for (int i = 0; i < stringWeights.Count; i++)
            {
                if (i == stringWeights.Count - 1)
                {
                    weightedList += $"{stringWeights[i]}";
                }
                else
                {
                    weightedList += $"{stringWeights[i]} ";
                }
            }
            return weightedList;
        }
    }
}
