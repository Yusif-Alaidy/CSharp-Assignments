using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Homework
    {
    public int HomeworkId { get; set; }

        public string Content { get; set; } = string.Empty;

        public ContentType ContentType { get; set; }

        public DateTime SubmissionTime { get; set; }


        // Relations 
        // - Objects
        public Student student { get; set; }
        public Course course { get; set; }
        // - Foreign Keys
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }

    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
}
