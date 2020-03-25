using MyFirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplication.Controllers
{
    public class DeveloperInfoController : Controller
    {
        // GET: DeveloperInfo
        public ActionResult Index()
        {
            DeveloperInformation info = new DeveloperInformation();
            info.Name = "Adam Ackerman";
            
            return View(info);
        }

        public ActionResult EasyWay()
        {
            ViewBag.Message = "Wow, this way is a lot easier!";
            return View();
        }
    }
}