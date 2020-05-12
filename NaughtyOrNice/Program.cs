using System;
using System.Linq;
using System.Collections.Generic;

namespace NaughtyOrNice
{
    class Program
    {
        /*It's almost Christmas! That means Santa's making his list, and checking it twice. 
         * Unfortunately, elves accidentally mixed the Naughty and Nice list together! Santa needs your help to save Christmas!
        Save Christmas!
        Santa needs you to write two functions. Both of the functions accept a sequence of objects. 
        The first one returns a sequence containing only the names of the nice people, and the other returns a sequence containing only the names of the naughty people. 
        Return an empty sequence [] if the result from either of the functions contains no names.
        The objects in the passed will represent people. Each object contains two properties: name and wasNice.
        name - The name of the person
        wasNice - True if the person was nice this year, false if they were naughty
        Person Object Examples
        In C# the class Person is pre-loaded with the properties:
        public string Name { get; set; }
        public bool WasNice { get; set; }
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Naughty or Nice?\n");


        }
        public class Person
        {
            public string Name { get; set; }
            public bool WasNice { get; set; }
        }
        public static IEnumerable<string> GetNaughtyNames(IEnumerable<Person> people)
        {
            var naughtyPeople = people.Where(p=>p.WasNice==false).Select(p=>p.Name);
            return naughtyPeople;
        }

        public static IEnumerable<string> GetNiceNames(IEnumerable<Person> people)
        {
            var nicePeople = people.Where(p => p.WasNice == true).Select(p => p.Name);
            return nicePeople;
        }
    }
}
