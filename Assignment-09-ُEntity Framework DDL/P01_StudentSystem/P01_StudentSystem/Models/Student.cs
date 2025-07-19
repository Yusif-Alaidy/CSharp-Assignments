using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public DateTime Birthday { get; set; }
        public String Name { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public bool? RegisteredOn { get; set; }


        // Relations 
        // - Objects
        public ICollection<Course> courses { get; set; }
        public ICollection<StudentCourse> studentCourses { get; set; }
        public ICollection<Homework> Homeworks { get; set; }

        // - Foreign Keys


    }
}
