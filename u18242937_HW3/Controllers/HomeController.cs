using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using u18242937_HW3.Models;

namespace u18242937_HW3.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase files)
        {
            if(files != null && files.ContentLength > 0)
            {
                var fileName = Path.GetFileName(files.FileName);

                var path = Path.Combine(Server.MapPath("~/App_Data/Uploads"), fileName);

                files.SaveAs(path);
            }


            return RedirectToAction("AboutMe");
            

        }
        public ActionResult AboutMe()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}