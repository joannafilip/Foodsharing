using Foodsharing.Infra;
using Foodsharing.Models;
using Foodsharing.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foodsharing.Areas.Member.Controllers
{
    public class HomeController : Controller
    {
        // GET: Member/Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DonateProduct()
        {

            return View(SessionUtils.ConnectedUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DonateProduct(DonateProductModel pm)
        {
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
            //if (ModelState.IsValid)
            //{
                if(pm == null)

                {
                    ViewBag.Error = "Erreur";
                    return RedirectToAction("Index", "DonateProduct", new { area = "" });
                }
                else
                {
                    SessionUtils.ConnectedUser.DonateProduct = pm;
                    ctx.InsertProduct(SessionUtils.ConnectedUser);
                    return RedirectToAction("Index", "Home", new { area = "" });
            }
               
                
            //}
            //else
            //{
            //    return RedirectToAction("Index", "Home", new { area = "" });
            //}
        }

        [HttpGet]
        public ActionResult MyProfile()
        {
            
            
            return View(SessionUtils.ConnectedUser);
                
            
        }
        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}