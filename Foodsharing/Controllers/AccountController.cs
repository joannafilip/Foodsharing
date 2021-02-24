﻿using Foodsharing.Infra;
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
        
        public ActionResult Index()
        {
            return View();
        }
         public ActionResult MyAccount()
        {
            ViewBag.Message = "Your contact page.";

            return View(new LoginModel());
        }

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
                    ViewBag.SuccessMessage = "Hello, you're a member of Foodsharing community!";
                    return View();
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

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(LoginModel lm)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (lm.Login != "Joanna" && lm.Password != "test")
        //        {
        //            ViewBag.Error = "Erreur Login/Password";
        //            return View();
        //        }
        //        else
        //        {
        //            SessionUtils.IsLogged = true;
        //            ViewBag.Error = "Erreur Login/Password";
        //            return View();
        //            //return RedirectToAction("Index", "Home", new { area = "Membre" });
        //        }
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
    }
}