using InnovationStuff.Persistance;
using System.Linq;
using System.Data.Entity;
using System.Web.Http;
using InnovationStuff.Core.Dto;
using System.Net;
using AutoMapper;
using InnovationStuff.Core.Models;

namespace InnovationStuff.Controllers.Api
{
    public class StudentsController : ApiController
    {
        private readonly ApplicationContext _context;
        public StudentsController()
        {
            _context = new ApplicationContext();
        }


        [HttpGet]
        public IHttpActionResult GetStudents()
        {
            var studentDtos = _context.Students
                           .Include(s => s.Courses)
                           .ToList()
                           .Select(Mapper.Map<Student, StudentDto>);

            return Ok(studentDtos);
        }

        [HttpGet]
        public StudentDto GetStudent(int id)
        {
            var student = _context.Students
                                .Include(s => s.Courses)
                                .SingleOrDefault(s => s.Id == id);

            if (student == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


            return Mapper.Map<Student, StudentDto>(student);
        }
    }
}
