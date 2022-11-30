using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UMSCodeFirst.EF.Models;

namespace UMSCodeFirst.EF
{
    public class UMSContext: DbContext
    {
        public UMSContext() 
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}