using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTask.HelpClass;
using TestTask.Models;

namespace TestTask.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDb db = new ApplicationDb();
        public ActionResult Index()
        {
            int[] array = new int[5];
            ViewBag.Array = WorkWithNumbers.Count(array);
            ViewBag.StartArray = array;
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            ViewBag.StartList = numbers;
            ViewBag.List = WorkWithNumbers.Delete(numbers);
            return View();
        }
        [HttpGet]
        public string DeleteChar(string str)
        {
            return new string(str.Distinct().ToArray());
        }

        public ActionResult Shop()
        {
            var data = db.Magazines;
            return View(data);
        }

        public ActionResult Products(int id)
        {
            return View(db.Products.Where(p => p.shopid == id));
        }

    }
}