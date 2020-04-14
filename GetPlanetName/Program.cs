using System;

namespace GetPlanetName
{
    class Program
    {
        //The function is not returning the correct values. Can you figure out why?
        static void Main(string[] args)
        {
            Console.WriteLine("Fix the code so that the switch case appropriately returns the planet name associated with the planet's order in the solar system!");
            Console.WriteLine($"{GetPlanetName(3)}");
        }
        public static string GetPlanetName(int id)
        {
            string name;
            switch (id)
            {
                case 1:
                    name = "Mercury";
                    break;
                case 2:
                    name = "Venus";
                    break;
                case 3:
                    name = "Earth";
                    break;
                case 4:
                    name = "Mars";
                    break;
                case 5:
                    name = "Jupiter";
                    break;
                case 6:
                    name = "Saturn";
                    break;
                case 7:
                    name = "Uranus";
                    break;
                case 8:
                    name = "Neptune";
                    break;
                default:
                    name = "Pluto";
                    break;
            }
            return name;
        }
    }
}
