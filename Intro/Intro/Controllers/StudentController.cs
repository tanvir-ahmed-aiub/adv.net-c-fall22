using Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Name = "Tanvir Ahmed";
            ViewData["Cgpa"] = 2.45;
            ViewBag.Courses = new String[] { "Adv Web", "Adv Net", "DS", "Java" };

            return View();
        }
        public ActionResult List()
        {
            List<Student> students = new List<Student>();
            for (int i = 1; i <= 10; i++)
            {
                var s1 = new Student() {
                    Id = i,
                    Name = "Student " + i,
                    Cgpa = 3.45f,
                    Bg = "A+",
                    Dob = "12.12.12"
                };
                students.Add(s1);
            }
            return View(students) ;
        }
        public ActionResult Details(int id) {
            Student s1 = new Student() { 
                Id = id,
                Name ="Student " + id,
                Dob = "2323",
                Cgpa = 2.45f,
                Bg = "O+"
            };
            return View(s1);    
        }
        
        public ActionResult Profile() {
            //return Redirect("https://www.aiub.edu");
            TempData["msg"] = "Redirected from student/profile";
            return RedirectToAction("About","Home");
        }
        public ActionResult Contact() {
            return View();
        }
    }
}