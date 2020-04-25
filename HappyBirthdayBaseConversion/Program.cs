using System;

namespace HappyBirthdayBaseConversion
{
    class Program
    {
        /*
         * As you may know, once some people pass their teens, they jokingly only celebrate their 20th or 21st birthday, forever. 
         With some maths skills, that's totally possible - you only need to select the correct number base!
         For example, if they turn 32, that's exactly 20 - in base 16... Already 39? That's just 21, in base 19!
         Your task is to translate the given age to the much desired 20 (or 21) years, and indicate the number base, in the format specified below.
         Note: input will be always > 21
         Examples:
         32  -->  "32? That's just 20, in base 16!"
         39  -->  "39? That's just 21, in base 19!
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Convert a given decimal number to either 20 or 21 in a different number-base.\n ");
            Console.WriteLine($"{AgeConversion(32)}");

        }

        public static string AgeConversion(int n)
        {
            string convertedAge = "";
            int baseNum = 2;            
            for (baseNum = 2; baseNum < Int32.MaxValue; baseNum++)
            {
                string digits = "";
                string reversedDigits = "";
                int trueAge = n;
                while (trueAge > 0)
                {
                    digits += Convert.ToString(trueAge % baseNum);
                    trueAge /= baseNum;                    
                }
                for (int i = (digits.Length-1); i >= 0; i--)
                {
                    reversedDigits += digits[i];
                }
                if (String.Equals(reversedDigits,"20") || String.Equals(reversedDigits,"21"))
                {
                    convertedAge = reversedDigits;
                    break;
                }
            }
            
            string finalMessage = $"{n}? That's just {convertedAge}, in base {baseNum}!";
            return finalMessage;
        }
    }
}
