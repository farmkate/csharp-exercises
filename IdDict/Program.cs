using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    Console.Write("ID: ");
                    int newID = Int32.Parse(Console.ReadLine());

                    students.Add(newStudent, newID);
                }
            }
            while (newStudent != "");

            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<string, int> student in students)
            {
                Console.WriteLine(student.Key + " (ID #" + student.Value + ")");
            }
            Console.ReadLine();
        }
    }
}
