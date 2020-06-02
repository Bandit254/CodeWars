using System;
using System.Collections.Generic;

namespace WelcomeLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function  that greets visitors of your website in their native language.\n");
            Console.WriteLine($"{Greet("english")}\n");
            Console.WriteLine($"{Greet("dutch")}\n");
            Console.WriteLine($"{Greet("IP_ADDRESS_INVALID")}\n");
            Console.WriteLine($"{Greet("")}\n");
            Console.WriteLine($"{Greet("2")}\n");
            Console.WriteLine($"{Greet("lithuanian")}\n");
            Console.WriteLine($"{Greet("GERMAN")}\n");
            Console.WriteLine($"{Greet("FrEnCh")}\n");
        }
        public static string Greet(string language)
        {
            Dictionary<string, string> nativeGreetings = new Dictionary<string, string>();
            nativeGreetings.Add("english", "Welcome");
            nativeGreetings.Add("czech", "Vitejte");
            nativeGreetings.Add("danish", "Velkomst");
            nativeGreetings.Add("dutch", "Welkom");
            nativeGreetings.Add("estonian", "Tere tulemast");
            nativeGreetings.Add("finnish", "Tervetuloa");
            nativeGreetings.Add("flemish", "Welgekomen");
            nativeGreetings.Add("french", "Bienvenue");
            nativeGreetings.Add("german", "Willkommen");
            nativeGreetings.Add("irish", "Failte");
            nativeGreetings.Add("italian", "Benvenuto");
            nativeGreetings.Add("latvian", "Gaidits");
            nativeGreetings.Add("lithuanian", "Laukiamas");
            nativeGreetings.Add("polish", "Witamy");
            nativeGreetings.Add("spanish", "Bienvenido");
            nativeGreetings.Add("swedish", "Valkommen");
            nativeGreetings.Add("welsh", "Croeso");
            string nativeLanguage = language.ToLower();
            string natGreeting = "";
            if (nativeGreetings.TryGetValue(nativeLanguage, out natGreeting))
            {
                return natGreeting;
            }
            else
            {
                return "Welcome";
            }
        }
    }
}
