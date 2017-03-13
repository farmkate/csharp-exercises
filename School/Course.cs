using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private string title;  // I want title to be a readonly field 
        private static double creditHours; // created as static because this will not likely change
        private List<string> studentRoster;

        // if Student name is enrolled in class add the credit hours to their numberOfCredits

        public string Title
        {
            get; set;
        }


    }
}
