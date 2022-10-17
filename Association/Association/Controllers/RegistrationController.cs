using Association.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Association.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [HttpGet]
        public ActionResult Index()
        {
            UMSFall22_cEntities db = new UMSFall22_cEntities();

            return View(db.Courses.ToList());
        }
        [HttpPost]
        public ActionResult Index(int[] courses) {
            UMSFall22_cEntities db = new UMSFall22_cEntities();
            foreach (var id in courses) {
                db.CourseStudents.Add(new CourseStudent() { 
                    CourseId = id,
                    StudentId = 1,

                });   
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}