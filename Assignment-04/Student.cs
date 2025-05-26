using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    class Student
    {
        // Static field for auto-incremented ID
        private static int nextId = 1000;
        // Properties:
        public readonly int StudentId;
        public string Name;
        public int Age;
        public List<Course> Courses = new();

        // Constractor
        public Student(string Name, int Age)
        {
            this.StudentId = nextId++;
            this.Name = Name;
            this.Age = Age;
        }

        // Method:
        public bool Enroll(Course course)
        {
            bool enroll = false;
            if (Courses.Contains(course) == false)
            {
                Courses.Add(course);
                enroll = true;
            }
            return enroll;
        }
        public string PrintDetails()
        {
            return $"\n\t\t╔=======================================╗\n" +
                     $"\t\t║   Student Id       ==>: {StudentId}    \n" +
                     $"\t\t║   Student Name     ==>: {Name}         \n" +
                     $"\t\t║   Student Age      ==>: {Age}          \n" +
                     $"\t\t╚=======================================╝\n";
        }
    }
}
