using MvcBookStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBookStore.Controllers
{
    public class HomeController : Controller
    {
        private BSContext db = new BSContext();

        public ActionResult Index()
        {
            ViewBag.Content = db.Books.Select(el => el.Genre).ToList().Distinct().Take(5).ToList();
            ViewBag.Books = db.Books.Take(10).ToList();
            return View();
        }

        public ActionResult Store(string id)
        {            
            if(id == "All")
                return View(db.Books.Take(10).ToList());
            return View(db.Books.Where(el => el.Genre == id).Take(10).ToList());
        }

        public ActionResult LeftMenu()
        {
            return PartialView("LMenu", db.Books.Select(el => el.Genre).ToList().Distinct().Take(5).ToList());
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
