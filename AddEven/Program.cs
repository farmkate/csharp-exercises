using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddEven
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbersList = new List<int>(){ 6, 5, 8, 1, 3, 5, 9, 4};
            List<int> numList = new List<int>();
            int sum = 0;
            string input;
            int numbers;


            Console.WriteLine("Enter a list of integers (or ENTER to finish):");
            do
            {
                input = Console.ReadLine();
                if (input != "")
                {
                    numbers = Int32.Parse(input);
                    numList.Add(numbers);
                }
            }while (input != "");

            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] % 2 == 0)
                {
                    sum = sum + numList[i];
                }

            }

            Console.WriteLine("The sum of the even numbers in your list is " + sum);
            Console.ReadLine();

        }
    }
}
