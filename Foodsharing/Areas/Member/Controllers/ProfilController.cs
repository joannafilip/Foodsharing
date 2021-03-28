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
    public class ProfilController : Controller
    {
        // GET: Member/Profil
        public ActionResult PickUpProduct()
        {
            return View(new DonateProductModel());
        }

        public ActionResult OfferedProducts(ProfilModel pm)
        {
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

            pm = SessionUtils.ConnectedUser;
            return View(ctx.GetProductsFromMembre(pm));
            //return View(new DonateProductModel());
        }
    }
}