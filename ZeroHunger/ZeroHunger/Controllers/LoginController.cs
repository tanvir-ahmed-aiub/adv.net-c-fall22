
using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroHunger.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User u) {
            var user = UserService.GetUser(u.Uname);
            if (user != null) {
                if (user.Password.Equals(u.Password))
                {
                    Session["logged"] = user.Uname;
                    Session["type"] = user.Type;
                    switch (user.Type) {
                        case "Ngo":
                            return RedirectToAction("Ngo","Dashboard");
                        case "Emp":
                            return RedirectToAction("Emp", "Dashboard");
                        case "Res":
                            return RedirectToAction("Res", "Dashboard");
                    }
                    //return RedirectToAction("Index", "Home");
                }
            }
            TempData["msg"] = "Invalid Username or Password";
            return RedirectToAction("Index");

        }
    }
}