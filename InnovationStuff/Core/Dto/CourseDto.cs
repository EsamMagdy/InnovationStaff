using InnovationStuff.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace InnovationStuff.Core.Dto
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void AddCourse(Student student,List<Course> courses)
        {
            var course = courses.SingleOrDefault(s => s.Id == Id);

            if (course == null) throw new HttpResponseException(HttpStatusCode.NotFound);

            student.Courses.Add(course);
        }
    }
}