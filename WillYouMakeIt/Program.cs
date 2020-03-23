using System;

namespace WillYouMakeIt
{
    class Program
    {
        /* You were camping with your friends far away from home, but when it's time to go back, 
         * you realize that your fuel is running out and the nearest pump is 50 miles away! 
         * You know that on average, your car runs on about 25 miles per gallon. There are 2 gallons left. 
         * Considering these factors, write a function that tells you if it is possible to get to the pump or not. 
         * Function should return true (1 in Prolog) if it is possible and false (0 in Prolog) if not. 
         * The input values are always positive.
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function to determine if you have enough gas left to make it to a gas station.\n");
            uint mpg = 25;
            uint distanceToPump = 51;
            uint fuelLeft = 2;
            Console.WriteLine($"We are {distanceToPump} miles away from the nearest gas station, and our car gets {mpg}mpg. Since we have {fuelLeft} gallons of gas, can we make it? {ZeroFuel(distanceToPump, mpg, fuelLeft)}.\n");
        }

        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            bool willYouMakeIt = true;
            if (distanceToPump > (mpg*fuelLeft))
            {
                willYouMakeIt = false;
            }
            return willYouMakeIt;
        }

    }
}
