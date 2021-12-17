using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeApp.ViewModel.Session;

namespace WelcomeApp.Controllers
{
    public class SessionController:Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var vm = new SessionIndexViewModel();
            
            if(Session["Counter"] ==null)
            {
                Session["Counter"] = 0;
            }
            vm.OldCounterValue = (int)Session["Counter"];
            Session["Counter"] = (int)Session["Counter"] + 1;

            vm.NewCounterValue = (int)Session["Counter"];
            vm.SessionIdValue = Session.SessionID;
        
            return View(vm);
        }

       
    }
}