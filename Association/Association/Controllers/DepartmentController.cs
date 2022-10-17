using Association.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Association.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            UMSFall22_cEntities db = new UMSFall22_cEntities();

            return View(db.Departments.ToList());
        }
        public ActionResult Details(int id) {
            UMSFall22_cEntities db = new UMSFall22_cEntities();
            var dept = (from d in db.Departments
                        where d.Id == id
                        select d).SingleOrDefault();
            //var courses = (from c in db.Courses
            //               where c.DepartmentId == id
            //               select c).ToList();
            //var students = (from s in db.Students
            //                where s.DepartmentId == id
            //                select s).ToList();

            //ViewBag.courses = courses;
            //ViewBag.students = students;
            return View(dept);
        }
    }
}