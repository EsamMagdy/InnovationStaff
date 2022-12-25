using System.Collections.Generic;

namespace InnovationStuff.Core.Dto
{
    public class StudentCourseDto
    {

        public int StudentId { get; set; }
        public List<CourseDto> Courses { get; set; }

    }
}