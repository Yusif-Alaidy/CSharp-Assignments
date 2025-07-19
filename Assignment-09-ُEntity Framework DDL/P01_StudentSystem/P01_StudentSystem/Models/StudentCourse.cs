using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    //[PrimaryKey(nameof(CourseId), nameof(CourseId))]
    internal class StudentCourse
    {
       
        // Relations 
        // - Objects
        public Course Course { get; set; } 
        public Student student { get; set; }
        // - Foreign Keys
        public int CourseId { get; set; }
        public int StudentId { get; set; }
    }
}
