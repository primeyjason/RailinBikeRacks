using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LearningALanguage()
        {
            
            return View("LearningALanguage");
        }

        public ActionResult Benefits()
        {

            return View("Benefits");
        }
        public ActionResult Resources()
        {

            return View("Resources");
        }

        public ActionResult OurProgram()
        {

            return View("OurProgram");
        }


        public ActionResult AboutUs()
        {

            return View("AboutUs");
        }

        public ActionResult ContactUs()
        {

            return View("ContactUs");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContactUs([Bind(Include = "ID,FullName,Phone,Email,Request")] ContactUsModel contactUsInfo)
        {
            
            if (ModelState.IsValid)
            {
                string body = "";
                body = $"<html><h3>Name:</h3><p>{contactUsInfo.FullName}</p><h3>Email:</h3><p>{contactUsInfo.Email}</p><h3>Phone:</h3><p>{contactUsInfo.Phone}</p><h3>Request:</h3><p>{contactUsInfo.Request.Replace("\n", "<br>")}</p></html>";
                EmailProvider.Send(System.Configuration.ConfigurationManager.AppSettings["Mags"], "Expression Of Interest - Language Factory", body); 
                return RedirectToAction("ThankYou");
            }

            return View();

            
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}