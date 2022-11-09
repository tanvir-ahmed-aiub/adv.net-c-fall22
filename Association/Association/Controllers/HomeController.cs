using Association.AuthFilter;
using Association.Models;
using Association.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Association.Controllers
{
    [Logged]
    public class HomeController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login() {
            return View();   
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModel model) {
            if (ModelState.IsValid) {
                var rt = AuthRepo.Login(model);
                //if login fails
                if (rt.GetType().Name.Equals("Boolean") && rt == false)
                {
                    TempData["msg"] = "Username Password is Invalid";
                    return RedirectToAction("Login");
                }
                //login succeeds
                Session["logged"] = rt.Username;
                return RedirectToAction("Index", "Student");
            }
            return View(model);
            
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}