using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson1.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        // GET: Store
        public ActionResult Details(string product)
        {
            if (product == null)
            {
                return View("error!");
            }



            ViewBag.Product = product;
            return View(); 
        }
    }
}