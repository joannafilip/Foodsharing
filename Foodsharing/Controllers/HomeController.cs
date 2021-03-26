
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
           
        public ActionResult Product(int page = 1, string searchString = null, string type = "", string sortOrder = "")
        {
            ViewBag.DateSort = String.IsNullOrEmpty(sortOrder) ? "date_desc" : "date_asc";
            ViewBag.NameSort = sortOrder == "name_desc" ? "" : "name_desc";
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.paginateProduct(page, searchString);

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