using InnovationStuff.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InnovationStuff.Core.ViewModel
{
    public class StudentsCourses
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        [Display(Name = "Course")]
        public int CourseId { get; set; }
    }
}