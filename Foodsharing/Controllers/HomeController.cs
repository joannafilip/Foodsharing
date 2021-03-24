
using Foodsharing.Models;
using Foodsharing.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foodsharing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel hm = new HomeViewModel();
            return View(hm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "About";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

                if (ctx.SaveContact(contact))
                {
                    ViewBag.SuccessMessage = "Message bien envoyé";
                    return View();
                }
                else
                {
                    ViewBag.ErrorMessage = "Message non enregistré";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Formulaire error";
                return View();
            }

        }
           
        public ActionResult Product(string sortOrder = "", string searchString = null, int page = 1)
        {
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

            //ViewBag.DateSort = String.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
            //ViewBag.PriceSort = sortOrder == "price_desc" ? "price_asc" : "price_desc";
            //ViewBag.Class = "active";
            //ViewBag.Message = "Your class page.";
            ProductViewModel productViewModel = new ProductViewModel();
            //ctx.PaginateProduct (sortOrder, searchString, page);

            return View(productViewModel);

        }

        public ActionResult SingleProductPage()
        {
            

            return View(new ProductContent());

        }

        public ActionResult Blog()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            return View(productViewModel);
        }
      
    }
}