using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnovationStuff.Core.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<Course> Courses { get; set; }
        public Student()
        {
            Courses = new HashSet<Course>();
        }
    }
}