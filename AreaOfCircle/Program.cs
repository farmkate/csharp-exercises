using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius;
            double area;
            double pi = Math.PI;
            string input;

            do
            {
                Console.Write("Enter a radius: ");
                input = Console.ReadLine();
                radius = float.Parse(input);
            } while (radius < 1);


            //a = pi*r*r
            area = pi * Math.Pow(radius, 2);
            Console.WriteLine("The area of a circle of radius " + radius + " is " + area);
            Console.ReadLine();

            //string output = $"The area of the circle is {area}";
            //$ is called string interpelation

            //output = String.Forma()
            //output = output.
        }
    }
}
