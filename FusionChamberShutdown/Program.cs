using System;

namespace FusionChamberShutdown
{
    class Program
    {
        /*
        A laboratory is testing how atoms react in ionic state during nuclear fusion. 
        They introduce different elements with Hydrogen in high temperature and pressurized chamber. 
        Due to unknown reason the chamber lost its power and the elements in it started precipitating
        Given the number of atoms of Carbon [C],Hydrogen[H] and Oxygen[O] in the chamber. 
        Calculate how many molecules of Water [H2O], Carbon Dioxide [CO2] and Methane [CH4] will be produced following the order of reaction affinity below:

        1. Hydrogen reacts with Oxygen   = H2O
        2. Carbon   reacts with Oxygen   = CO2
        3. Carbon   reacts with Hydrogen = CH4

        FOR EXAMPLE:
        (C,H,O) = (45,11,100)
        return no. of water, carbon dioxide and methane molecules
        Output should be like:
        (5,45,0)
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Determine the number of water, carbon dioxide, and methane molecules that will precipitate from a given number of carbon, hyrdogen, and oxygen atoms.\n");
            int carbon = 354;
            int hydrogen = 1023230;
            int oxygen = 0;
            int h2o = 0;
            int co2 = 0;
            int ch4 = 0;

            (h2o, co2, ch4) = FusionReactor(carbon, hydrogen, oxygen);

            Console.WriteLine($"Given {carbon} carbon atoms, {hydrogen} hydrogen atoms, and {oxygen} oxygen atoms, the fusion reactor will cause {h2o} water molecules, {co2} carbon dioxide molecules, and {ch4} methane molecules to precipitate out. \n");
        }

        public static (int, int, int) FusionReactor(int carbon, int hydrogen, int oxygen)
        {
            int h2o = 0;
            int co2 = 0;
            int ch4 = 0;

            // Make as many water molecules as possible:
            while (hydrogen >= 2 && oxygen >= 1)
            {
                h2o += 1;
                hydrogen -= 2;
                oxygen -= 1;
            }

            // Make as many carbon dioxide molecules as possible:
            while (carbon >= 1 && oxygen >= 2)
            {
                co2 += 1;
                carbon -= 1;
                oxygen -= 2;
            }

            // Make as many methane molecules as possible:
            while (carbon >= 1 && hydrogen >= 4)
            {
                ch4 += 1;
                carbon -= 1;
                hydrogen -= 4;
            }

            return (h2o, co2, ch4);
        }
    }
}
