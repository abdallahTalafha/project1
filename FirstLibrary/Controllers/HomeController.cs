using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
           
            return View(db.Categories.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult search()
        {

            return View();
        }
        [HttpPost]
        public ActionResult search(string searchName)
        {
            var result = db.Books.Where(a => a.BookTitle.Contains(searchName)
            || a.Category.CategoryName.Contains(searchName)).ToList();
            return View();
        }
    }
}