using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width;
            string input;
            int area;

            Console.WriteLine("What is the height of the rectangle (integer please)?");
            input = Console.ReadLine();
            height = int.Parse(input);

            Console.WriteLine("What is the width of the rectanble (integer please)?");
            input = Console.ReadLine();
            width = int.Parse(input);

            area = height * width;
            Console.WriteLine("The area of the rectangle is " + area);
            Console.ReadLine();
        }
    }
}
