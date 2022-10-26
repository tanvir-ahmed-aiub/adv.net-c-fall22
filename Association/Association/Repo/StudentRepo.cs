using Association.DB;
using Association.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Association.Repo
{
    public class StudentRepo
    {
        public static List<StudentModel> Get() {
            var db = new UMSFall22_cEntities();
            var students = new List<StudentModel>();
            foreach (var st in db.Students) {
                students.Add(new StudentModel() { 
                
                    Id = st.Id,
                    Name = st.Name, 
                    DepartmentId = st.DepartmentId,
                    StudentId = st.StudentId,
                });
            }
            return students;
            //return all students of db in usable format of app
        }
        public static StudentModel Get(int id)
        {
            var db = new UMSFall22_cEntities();
            var student = db.Students.Find(id);
            var st = new StudentModel() {
                Id = student.Id,
                Name= student.Name,
                StudentId = student.StudentId,
                DepartmentId = student.DepartmentId
            };
            return st;
            //return a single student of db in usable format of app
        }
        public static void Create(StudentModel student) {
            Student st = new Student();
            st.Name = student.Name;
            st.StudentId = student.StudentId;
            st.DepartmentId = student.DepartmentId;
            var db = new UMSFall22_cEntities();
            db.Students.Add(st);
            db.SaveChanges();
            //it will receive data in out app format and insert into db
        }

    }
}