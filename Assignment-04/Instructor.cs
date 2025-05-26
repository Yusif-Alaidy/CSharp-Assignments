using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    class Instructor
    {
        // Static field for auto-incremented ID
        private static int nextId = 100;
        // Properties:
        public int InstructorId;
        public string Name;
        public string Specialization;

        // Constructor
        public Instructor(string Name, string Specialization)
        {
            this.InstructorId = nextId++;
            this.Name = Name;
            this.Specialization = Specialization;
        }

        // Methods:
        string PrintDetails()
        {
            return "";
        }
    }
}
