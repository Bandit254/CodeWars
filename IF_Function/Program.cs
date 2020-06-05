using System;

namespace IF_Function
{
    class Program
    {
        /* Who likes keywords? Nobody likes keywords, so why use them?
         * You know what keyword I use too much? if! We should make a function called _if, 
         * with its arguments as a logical test and two functions/lambdas where the first function is executed if the boolean is true, 
         * and the second if it's false, like an if/else statement, so that we don't have to mess around with those nasty keywords! 
         * Even so, It should support truthy/falsy types just like the keyword.
         * Example:
         * Kata.If(true, () => Console.WriteLine("True"), () => Console.WriteLine("False"));
                        // write "True" to console
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that takes a boolean condition and two functions as parameters. The master function executes the first function parameter if the boolean is true, and the second function if the boolean is false.\n");
            If(false, () => Console.WriteLine("True"), () => Console.WriteLine("False"));
        }
        public static void If(bool condition, Action func1, Action func2)
        {
            Action func3 = condition ? func1 : func2;
            func3();
        }
    }
}
