using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            float milesDriven;
            float gallonsUsed;
            string input;
            float milesPerGallon;

            Console.WriteLine("How many miles have you driven?");
            input = Console.ReadLine();
            milesDriven = float.Parse(input);

            Console.WriteLine("How many gallons of gas have you consumed?");
            input = Console.ReadLine();
            gallonsUsed = float.Parse(input);

            milesPerGallon = milesDriven / gallonsUsed;

            Console.WriteLine("You are getting " + milesPerGallon + " miles per gallon.");
            Console.ReadLine();
        }
    }
}
