using IntroEF.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var db = new StudentMS_cEntities();
            var students = db.Students.ToList();
            return View(students);
        }
        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student st) {
            //add to db
            var db = new StudentMS_cEntities();
            db.Students.Add(st);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id) {
            var db = new StudentMS_cEntities();
            var ext = (  from st in db.Students
                         where st.Id == id
                       select st).SingleOrDefault();
            return View(ext);
        }
        [HttpPost]
        public ActionResult Edit(Student s) {
            var db = new StudentMS_cEntities();
            var ext = (from st in db.Students
                       where st.Id == s.Id
                       select st).SingleOrDefault();
            ext.Name = s.Name;
            ext.Dob = s.Dob;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}