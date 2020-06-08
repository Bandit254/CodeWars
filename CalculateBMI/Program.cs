using System;

namespace CalculateBMI
{
    class Program
    {
        /*Write function bmi that calculates body mass index (bmi = weight / height ^ 2).
         * if bmi <= 18.5 return "Underweight"
         * if bmi <= 25.0 return "Normal"
         * if bmi <= 30.0 return "Overweight"
         * if bmi > 30 return "Obese"
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that calculates a person's BMI, given their height and weight.\n");

        }
        public static string Bmi(double weight, double height)
        {
            string bmiCategory="";
            double bmi = weight / (Math.Pow(height, 2));
            if (bmi<=18.5)
            {
                bmiCategory = "Underweight";
            }
            else if (bmi <= 25.0)
            {
                bmiCategory = "Normal";
            }
            else if (bmi <= 30.0)
            {
                bmiCategory = "Overweight";
            }
            else if (bmi > 30.0)
            {
                bmiCategory = "Obese";
            }
            return bmiCategory;
        }
    }
}
