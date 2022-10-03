using Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book book) {
            if (ModelState.IsValid) {
                return RedirectToAction("Index","Home");
            }

            return View(book);
        }

        public ActionResult Submit(Book book) {
            //ViewBag.BookName = Request["Title"];
            //ViewBag.BookName = form["Title"];
            ViewBag.BookName = book.Title;
            
            return View();
        }
    }
}