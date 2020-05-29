using System;

namespace GreetMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a method that takes one argument as name and then greets that name, capitalized and ends with an exclamation point.\n");
            string name = "riley";
            string name1 = "Jack";
            Console.WriteLine($"{Greet(name)}\n");
            Console.WriteLine($"{Greet(name1)}\n");
        }

        public static string Greet(string name)
        {
            string formattedName = "";
            formattedName += Char.ToUpper(name[0]);
            for (int i = 1; i < name.Length; i++)
            {
                formattedName += Char.ToLower(name[i]);
            }
            string finalGreeting = "Hello " + formattedName + "!";
            return finalGreeting;
        }
    }
}
