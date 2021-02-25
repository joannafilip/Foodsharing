using Foodsharing.Infra;
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
    public class AccountController : Controller
    {
        // GET: Account

        [HttpGet]
        public ActionResult MyAccount()
        {
            ViewBag.Message = "Your contact page.";

            return View(new LoginModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MyAccount(LoginModel lm)
        {
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
            if (ModelState.IsValid)
            {
                if (!ctx.UserAuth(lm))
                {
                    ViewBag.Error = "Erreur Login/Password";
                    return View();
                }
                else
                {
                    SessionUtils.IsLogged = true;
                    ViewBag.SuccessMessage = "ok.";
                    return RedirectToAction("Index", "Home", new { area = "Member" });
                }
            }
            else
            {
                return View();
            }
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult MyAccount(LoginModel lm)
        //{
        //    if (ModelState.IsValid)
        //        {
        //            UserModel um = ctx.UserAuth(lm);
        //            if (um == null)
        //            {
        //                ViewBag.Error = "Erreur Login/Password";
        //                return View();
        //        }
        //            else
        //            {
        //                SessionUtils.IsLogged = true;
        //                SessionUtils.ConnectedUser = um;
        //                return RedirectToAction("Index", "Home", new { area = "Membre" });
        //            }
        //        }
        //            else
        //        {
        //             return View();
        //            }
        //}




















        [HttpGet]
        public ActionResult SignUp()
        {
            return View(new SignUpModel());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(SignUpModel signUp)
        {
            if (ModelState.IsValid)
            {
                DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

                if (ctx.SaveSignUp(signUp))
                {
                    SessionUtils.IsLogged = true;
                    ViewBag.SuccessMessage = "Hello, you're a member of Foodsharing community!";
                    return RedirectToAction("Index", "Home", new { area = "Member" });
                }
                else
                {
                    ViewBag.ErrorMessage = "Try once again!";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Sign Up error";
                return View();
            }

        }

       
    }
}