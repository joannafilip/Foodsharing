using Foodsharing.Models;
using System;
using System.Collections.Generic;
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

        public ActionResult OfferedProducts()
        {
            return View(new DonateProductModel());
        }
    }
}