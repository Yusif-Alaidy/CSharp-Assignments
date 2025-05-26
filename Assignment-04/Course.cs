using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_04
{
    class Course
    {
        // Static field for auto-incremented ID
        private static int nextId = 1000;

        // Properties:
        public int courseId;
        public string title;
        public Instructor instructor;

        // Constractor
        public Course(string title, Instructor instructor)
        {
            this.courseId = nextId++;
            this.title = title;
            this.instructor = instructor;
        }

        // Methods:
        public string PrintDetails()
        {
        return $"\n\t\t╔=======================================╗\n" +
                 $"\t\t║   Course Id         ==>: {courseId}       \n" +
                 $"\t\t║   Course Name       ==>: {title}          \n" +
                 $"\t\t║   Instructor name   ==>: {instructor.Name}\n" +
                 $"\t\t╚=======================================╝\n";
        }

    }
}
