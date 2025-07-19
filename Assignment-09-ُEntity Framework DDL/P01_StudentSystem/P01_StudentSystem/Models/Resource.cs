using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        
        public string Url { get; set; }
        public ResourceType Type { get; set; }

        // Relations 
        // - Objects
        public Course Course { get; set; }
        // - Foreign Keys
        public int CourseId { get; set; }
    }
    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }
}
