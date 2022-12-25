using InnovationStuff.Core.Dto;
using InnovationStuff.Persistance;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Data.Entity;

namespace InnovationStuff.Controllers.Api
{
    public class CoursesController : ApiController
    {
        private readonly ApplicationContext _context;
        public CoursesController()
        {
            _context = new ApplicationContext();
        }

        [HttpPost]
        public void CreateCourse(StudentCourseDto studentCourse)
        {

            var student = _context.Students
                                  .Include(s => s.Courses)
                                  .ToList()
                                  .SingleOrDefault(s => s.Id == studentCourse.StudentId);

            if (student == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            student.Courses.Clear();

            if (studentCourse.Courses == null)
            {
                _context.SaveChanges();
                return;
            }

            var courses = _context.Courses.ToList();

            studentCourse.Courses.ForEach(c => c.AddCourse(student, courses));

            _context.SaveChanges();
        }

    }
}
