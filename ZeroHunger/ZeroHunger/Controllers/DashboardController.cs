using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroHunger.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Ngo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ngo(CollectionRequest col) {
            //call to bll
            RequestService.Create(col);
            return View();
        }
        public ActionResult Emp()
        {
            return View();
        }
        public ActionResult Res()
        {
            return View();
        }
    }
}