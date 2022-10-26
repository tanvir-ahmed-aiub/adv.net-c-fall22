using Association.Models;
using Association.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Association.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            return View(StudentRepo.Get());
        }
        [HttpGet]
        public ActionResult Create() {
            ViewBag.Departments = DepartmentRepo.Get();
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentModel student) {

            if (ModelState.IsValid) {
                StudentRepo.Create(student);
                return RedirectToAction("Index");   
            }
            ViewBag.Departments = DepartmentRepo.Get();
            return View(student);
        }
        public ActionResult Details(int id) {

            return View(StudentRepo.Get(id));
        }
    }
}