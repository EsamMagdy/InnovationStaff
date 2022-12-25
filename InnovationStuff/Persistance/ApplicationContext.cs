using InnovationStuff.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InnovationStuff.Persistance
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}