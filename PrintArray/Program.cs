using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numList = new int[] { 1, 1, 2, 3, 5, 8 };

            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine(numList[i]);
            }
            Console.ReadLine();
        }
    }
}
