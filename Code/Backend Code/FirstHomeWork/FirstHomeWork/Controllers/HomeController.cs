using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstHomeWork.Controllers
{
    public class HomeController : Controller
    {
        //public ContentResult index(int id, string name)
        //{
        //var result = new ContentResult();
        // result.Content = "This is Content";
        // return result;
        //}
       //public JsonResult Json()
       //{
           // var result = new JsonResult(new { name = "Tabriz", surname = "Mammadov" });
           // return result;
        //}

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            ViewData["Id"] = id;
            ViewBag.Id = 79;

            TempData["Id"] = id;
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}
