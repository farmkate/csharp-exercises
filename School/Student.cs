using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private string name;
        private int studentId;
        private int numberOfCredits = 0;
        private double gpa = 0;

        public string Name
        {
            get {return name; }
            internal set { name = value; }
        }

        public int StudentId
        {
            get { return studentId; }
            internal set { studentId = value; }
        }

        public int NumberOfCredits
        {
            get; set;
        }

        public double Gpa
        {
            get; set;
        }

    }
}
