using Foodsharing.Infra;
using Foodsharing.Models;
using Foodsharing.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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
                ProfilModel pf = ctx.UserAuth(lm);
                if (pf == null)
                {
                    ViewBag.Error = "Erreur Login/Password";
                    return View();
                }
                else
                {
                    SessionUtils.IsLogged = true;
                    SessionUtils.ConnectedUser = pf;
                    return RedirectToAction("Index", "Home", new { area = "Member" });
                }
            }
            else
            {
                return View();
            }
        }
        
        [HttpGet]
        public ActionResult SignUp()
        {
            return View(new SignUpModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(SignUpModel signUp, HttpPostedFileBase FilePicture)
        {

            if (ModelState.IsValid)
            {
                DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

                if (ctx.SaveSignUp(signUp))
                {
                    SessionUtils.IsLogged = true;
                    //ViewBag.SuccessMessage = "Hello, you're a member of Foodsharing community!";
                    return RedirectToAction("MyAccount", "Account");
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