using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnovationStuff.Core.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
        public Course()
        {
            Students = new HashSet<Student>();
        }
    }
}