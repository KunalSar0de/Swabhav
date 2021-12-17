using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeApp.ViewModel.Application;
using WelcomeApp.ViewModel.Session;

namespace WelcomeApp.Controllers
{
    public class SummeryController:Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<int> counters = new List<int>();
            counters.Add((int)Session["Counter"]);
            counters.Add((int)HttpContext.Application["Counter"]);
            ViewData["counters"]= counters;
            return View();
        }
    }
}