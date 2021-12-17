using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeApp.ViewModel.Application;

namespace WelcomeApp.Controllers
{
    public class ApplicationController:Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var vm = new ApplicationIndexViewModel();

            if (HttpContext.Application["Counter"]  == null)
            {
                HttpContext.Application["Counter"] = 0;
            }
            vm.OldCounterValue = (int)HttpContext.Application["Counter"];
            HttpContext.Application["Counter"] = (int)HttpContext.Application["Counter"] + 1;

            vm.NewCounterValue = (int)HttpContext.Application["Counter"];
            

            return View(vm);
        }
    }
}