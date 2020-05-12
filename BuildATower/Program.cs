using System;

namespace BuildATower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Build a tower with a given number of floors.\n");
            int nFloors = 6;
            string[] tower = BuildATower(nFloors);
            foreach (string s in tower)
            {
                Console.WriteLine($"'{s}'");
            }

        }
        public static string[] BuildATower(int nFloors)
        {
            string[] tower = new string[nFloors];
            int floorWidth = 2 * nFloors - 1;
            int numStars = 1;
            int sideSpaces = (floorWidth-1) / 2;
            for (int i = 0; i < nFloors; i++)
            {
                string currentFloor = "";
                for (int k = 0; k < sideSpaces; k++)
                {
                    currentFloor += ' ';
                }
                for (int h = 0; h < numStars; h++)
                {
                    currentFloor += '*';
                }
                for (int k = 0; k < sideSpaces; k++)
                {
                    currentFloor += ' ';
                }
                tower[i] = currentFloor;
                sideSpaces--;
                numStars += 2;
            }
            return tower;
        }
    }
}
