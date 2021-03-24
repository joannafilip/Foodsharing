using Foodsharing.Infra;
using Foodsharing.Models;
using Foodsharing.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Foodsharing.Areas.Member.Controllers
{
    public class HomeController : Controller
    {
        // GET: Member/Home
        private string[] valideImageType = { ".png", ".jpg", ".jpeg" };

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


        public ActionResult MyProfile()
        {
            return View(SessionUtils.ConnectedUser);
        }
        [HttpGet]
        public ActionResult EditPhoto()
        {
            return View(SessionUtils.ConnectedUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPhoto(ProfilModel pm, HttpPostedFileBase FilePicture)
       {
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
            if (FilePicture.ContentLength > 0 && FilePicture.ContentLength< 20000)
            {
                string extension = Path.GetExtension(FilePicture.FileName);
                if (valideImageType.Contains(extension))
                {

                    string destFolder = Path.Combine(Server.MapPath("~/images/Users"), SessionUtils.ConnectedUser.IdUser.ToString());
                    if (!Directory.Exists(destFolder))
                    {
                        Directory.CreateDirectory(destFolder);
                    }


                    FilePicture.SaveAs(Path.Combine(destFolder, FilePicture.FileName));


                    SessionUtils.ConnectedUser.Photo = FilePicture.FileName;
                    ctx.EditUserProfilePhoto(SessionUtils.ConnectedUser);
                    return RedirectToAction("MyProfile", "Home");
                }
            }
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