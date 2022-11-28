namespace UMSCodeFirst.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UMSCodeFirst.EF.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UMSCodeFirst.EF.UMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UMSCodeFirst.EF.UMSContext context)
        {
            List<Department> depts = new List<Department>();
            for (int i = 1; i < 4; i++) {
                depts.Add(new Department()
                {
                    DeptId = i,
                    Name = Guid.NewGuid().ToString().Substring(0, 5)
                }); ;

            }
            List<Student> students = new List<Student>();
            Random random = new Random();
            for (int i = 1; i <= 10000; i++) {
                students.Add(new Student()
                {
                    Id = i,
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    DId = random.Next(1, 3)

                }); ;
            }
            context.Departments.AddOrUpdate(depts.ToArray());
            context.Students.AddOrUpdate(students.ToArray());
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
