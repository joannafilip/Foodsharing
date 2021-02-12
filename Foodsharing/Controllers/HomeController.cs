
using Foodsharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foodsharing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            return View(productViewModel);
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
        public ActionResult Product()
        {
            ProductViewModel productViewModel = new ProductViewModel();

            return View(productViewModel);
        }
        public ActionResult Blog()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            return View(productViewModel);
        }
        public ActionResult MyAccount()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}