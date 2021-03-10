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
        public ActionResult DonateProduct(ProfilModel pm)
        {
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
            SessionUtils.ConnectedUser.IdUser = pm.IdUser;
            SessionUtils.ConnectedUser.IdAdresse = pm.IdAdresse;
            ctx.InsertProduct(pm);
            return View(SessionUtils.ConnectedUser);

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