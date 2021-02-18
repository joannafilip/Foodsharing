using Foodsharing.Infra;
using Foodsharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foodsharing.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
         public ActionResult MyAccount()
        {
            ViewBag.Message = "Your contact page.";

            return View(new LoginModel());
        }
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel lm)
        {
            if (ModelState.IsValid)
            {
                if (lm.Login != "Joanna" && lm.Password != "test")
                {
                    ViewBag.Error = "Erreur Login/Password";
                    return View();
                }
                else
                {
                    SessionUtils.IsLogged = true;
                    return RedirectToAction("Index", "Home", new { area = "Membre" });
                }
            }
            else
            {
                return View();
            }
        }
    }
}