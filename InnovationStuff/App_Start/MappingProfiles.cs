using AutoMapper;
using InnovationStuff.Core.Dto;
using InnovationStuff.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnovationStuff.App_Start
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            Mapper.CreateMap<Student, StudentDto>();
            Mapper.CreateMap<StudentDto, Student>();

            Mapper.CreateMap<Course, CourseDto>();
            Mapper.CreateMap<CourseDto, Course>();
        }
    }
}