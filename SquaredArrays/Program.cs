using System;

namespace SquaredArrays
{
    class Program
    {
        /*
         * Given two arrays a and b write a function comp(a, b) (compSame(a, b) in Clojure) that checks whether the two arrays have the "same" elements, with the same multiplicities. 
         * "Same" means, here, that the elements in b are the elements in a squared, regardless of the order.
            Example:
            Valid arrays
            a = [121, 144, 19, 161, 19, 144, 19, 11]  
            b = [121, 14641, 20736, 361, 25921, 361, 20736, 361]
            comp(a, b) returns true because in b 121 is the square of 11, 14641 is the square of 121, 20736 the square of 144, 361 the square of 19, 25921 the square of 161, and so on. 
            It gets obvious if we write b's elements in terms of squares:
            a = [121, 144, 19, 161, 19, 144, 19, 11] 
            b = [11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19]
            Invalid arrays
            If we change the first number to something else, comp may not return true anymore:
            a = [121, 144, 19, 161, 19, 144, 19, 11]  
            b = [132, 14641, 20736, 361, 25921, 361, 20736, 361]
            comp(a,b) returns false because in b 132 is not the square of any number of a.
            a = [121, 144, 19, 161, 19, 144, 19, 11]  
            b = [121, 14641, 20736, 36100, 25921, 361, 20736, 361]
            comp(a,b) returns false because in b 36100 is not the square of any number of a.
            Remarks
            a or b might be [] (all languages except R, Shell).
            a or b might be nil or null or None or nothing (except in Haskell, Elixir, C++, Rust, R, Shell, PureScript).
            If a or b are nil (or null or None), the problem doesn't make sense so return false.
            */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a method that determines if all elements of an array are the squares of an element in another array.\n");
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };
            Console.WriteLine($"{CompareArrays(a, b)}");
        }
        public static bool CompareArrays(int[] a, int[] b)
        {
            bool isSquare=false;
            int matchingItems = 0;
            if (a==null || b==null)
            {
                return isSquare;
            }
            if (a.Length!=b.Length)
            {
                return isSquare;
            }
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (b[i]==(a[j]*a[j]))
                    {
                        matchingItems++;
                        break;
                    }
                }
            }
            if (matchingItems==b.Length)
            {
                isSquare = true;
            }
            return isSquare;
        }
    }
}
