using System;
using System.Collections.Generic;

namespace SubtractTheSum
{
    class Program
    {
        /*Complete the function which get an input number n such that n >= 10 and n < 10000, then:
         *Sum all the digits of n.
         *Subtract the sum from n, and it is your new n.
         *If the new n is in the list below return the associated fruit, otherwise return back to task 1.
         *Example
         *n = 325
         *sum = 3+2+5 = 10
         *n = 325-10 = 315 (not in the list)
         *sum = 3+1+5 = 9
         *n = 315-9 = 306 (not in the list)
         *sum = 3+0+6 = 9
         *n =306-9 = 297 (not in the list)
         *. ...until you find the first n in the list below (list included in the function).
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Follow a series of additions/subtractions of the digits of a given number to return a fruit name.\n");
            Console.WriteLine($"{SubtractSum(10)}");
            Console.WriteLine($"{SubtractSum(11)}");
            Console.WriteLine($"{SubtractSum(12)}");
            Console.WriteLine($"{SubtractSum(13)}");
            Console.WriteLine($"{SubtractSum(14)}");
            Console.WriteLine($"{SubtractSum(15)}");
            Console.WriteLine($"{SubtractSum(16)}");
            Console.WriteLine($"{SubtractSum(17)}");
            Console.WriteLine($"{SubtractSum(18)}");
            Console.WriteLine($"{SubtractSum(19)}");
            Console.WriteLine($"{SubtractSum(20)}");
            Console.WriteLine($"{SubtractSum(21)}");
            Console.WriteLine($"{SubtractSum(32)}");
            Console.WriteLine($"{SubtractSum(43)}");
            Console.WriteLine($"{SubtractSum(54)}");
            Console.WriteLine($"{SubtractSum(69)}");
            Console.WriteLine($"{SubtractSum(70)}");
            Console.WriteLine($"{SubtractSum(98)}");
            Console.WriteLine($"{SubtractSum(101)}");
            Console.WriteLine($"{SubtractSum(254)}");
            Console.WriteLine($"{SubtractSum(1001)}");
            Console.WriteLine($"{SubtractSum(5001)}");
            Console.WriteLine($"{SubtractSum(9999)}");

        }
        public static Dictionary<int, string> fruitNames = new Dictionary<int, string>();
        public static string SubtractSum(int number)
        {
            if (number < 10 || number > 10000)
            {
                return "Error - number out of bounds.";
            }
            
            fruitNames.TryAdd(1, "kiwi");
            fruitNames.TryAdd(2, "pear");
            fruitNames.TryAdd(3, "kiwi");
            fruitNames.TryAdd(4, "banana");
            fruitNames.TryAdd(5, "melon");
            fruitNames.TryAdd(6, "banana");
            fruitNames.TryAdd(7, "melon");
            fruitNames.TryAdd(8, "pineapple");
            fruitNames.TryAdd(9, "apple");
            fruitNames.TryAdd(10, "pineapple");
            fruitNames.TryAdd(11, "cucumber");
            fruitNames.TryAdd(12, "pineapple");
            fruitNames.TryAdd(13, "cucumber");
            fruitNames.TryAdd(14, "orange");
            fruitNames.TryAdd(15, "grape");
            fruitNames.TryAdd(16, "orange");
            fruitNames.TryAdd(17, "grape");
            fruitNames.TryAdd(18, "apple");
            fruitNames.TryAdd(19, "grape");
            fruitNames.TryAdd(20, "cherry");
            fruitNames.TryAdd(21, "pear");
            fruitNames.TryAdd(22, "cherry");
            fruitNames.TryAdd(23, "pear");
            fruitNames.TryAdd(24, "kiwi");
            fruitNames.TryAdd(25, "banana");
            fruitNames.TryAdd(26, "kiwi");
            fruitNames.TryAdd(27, "apple");
            fruitNames.TryAdd(28, "melon");
            fruitNames.TryAdd(29, "banana");
            fruitNames.TryAdd(30, "melon");
            fruitNames.TryAdd(31, "pineapple");
            fruitNames.TryAdd(32, "melon");
            fruitNames.TryAdd(33, "pineapple");
            fruitNames.TryAdd(34, "cucumber");
            fruitNames.TryAdd(35, "orange");
            fruitNames.TryAdd(36, "apple");
            fruitNames.TryAdd(37, "orange");
            fruitNames.TryAdd(38, "grape");
            fruitNames.TryAdd(39, "orange");
            fruitNames.TryAdd(40, "grape");
            fruitNames.TryAdd(41, "cherry");
            fruitNames.TryAdd(42, "pear");
            fruitNames.TryAdd(43, "cherry");
            fruitNames.TryAdd(44, "pear");
            fruitNames.TryAdd(45, "apple");
            fruitNames.TryAdd(46, "pear");
            fruitNames.TryAdd(47, "kiwi");
            fruitNames.TryAdd(48, "banana");
            fruitNames.TryAdd(49, "kiwi");
            fruitNames.TryAdd(50, "banana");
            fruitNames.TryAdd(51, "melon");
            fruitNames.TryAdd(52, "pineapple");
            fruitNames.TryAdd(53, "melon");
            fruitNames.TryAdd(54, "apple");
            fruitNames.TryAdd(55, "cucumber");
            fruitNames.TryAdd(56, "pineapple");
            fruitNames.TryAdd(57, "cucumber");
            fruitNames.TryAdd(58, "orange");
            fruitNames.TryAdd(59, "cucumber");
            fruitNames.TryAdd(60, "orange");
            fruitNames.TryAdd(61, "grape");
            fruitNames.TryAdd(62, "cherry");
            fruitNames.TryAdd(63, "apple");
            fruitNames.TryAdd(64, "cherry");
            fruitNames.TryAdd(65, "pear");
            fruitNames.TryAdd(66, "cherry");
            fruitNames.TryAdd(67, "pear");
            fruitNames.TryAdd(68, "kiwi");
            fruitNames.TryAdd(69, "pear");
            fruitNames.TryAdd(70, "kiwi");
            fruitNames.TryAdd(71, "banana");
            fruitNames.TryAdd(72, "apple");
            fruitNames.TryAdd(73, "banana");
            fruitNames.TryAdd(74, "melon");
            fruitNames.TryAdd(75, "pineapple");
            fruitNames.TryAdd(76, "melon");
            fruitNames.TryAdd(77, "pineapple");
            fruitNames.TryAdd(78, "cucumber");
            fruitNames.TryAdd(79, "pineapple");
            fruitNames.TryAdd(80, "cucumber");
            fruitNames.TryAdd(81, "apple");
            fruitNames.TryAdd(82, "grape");
            fruitNames.TryAdd(83, "orange");
            fruitNames.TryAdd(84, "grape");
            fruitNames.TryAdd(85, "cherry");
            fruitNames.TryAdd(86, "grape");
            fruitNames.TryAdd(87, "cherry");
            fruitNames.TryAdd(88, "pear");
            fruitNames.TryAdd(89, "cherry");
            fruitNames.TryAdd(90, "apple");
            fruitNames.TryAdd(91, "kiwi");
            fruitNames.TryAdd(92, "banana");
            fruitNames.TryAdd(93, "kiwi");
            fruitNames.TryAdd(94, "banana");
            fruitNames.TryAdd(95, "melon");
            fruitNames.TryAdd(96, "banana");
            fruitNames.TryAdd(97, "melon");
            fruitNames.TryAdd(98, "pineapple");
            fruitNames.TryAdd(99, "apple");
            fruitNames.TryAdd(100, "pineapple");
            //int numcopy = number;
            //int sum = 0;
            //while (numcopy > 0)
            //{
            //    sum += numcopy % 10;
            //    numcopy /= 10;
            //}
            //int fruitnumber = number - sum;
            int fruitNumber = GetFruitNumber(number);
            string fruitName = fruitNames[fruitNumber];
            return fruitName;
        }
        public static int GetFruitNumber(int inputNumber)
        {
            int numCopy = inputNumber;
            int sum = 0;
            while (numCopy > 0)
            {
                sum += numCopy % 10;
                numCopy /= 10;
            }
            int fruitNumber = inputNumber - sum;
            if (fruitNumber > 100)
            {
                return GetFruitNumber(fruitNumber);
            }
            else
            {
                return fruitNumber;
            }
        }
    }
}
