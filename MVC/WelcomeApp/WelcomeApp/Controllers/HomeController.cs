using System;
using System.Web.Mvc;

namespace WelcomeApp.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index(string username)
        {
            if (username == null)
            {
                ViewBag.username = "No username";
            }
            else
            {
                ViewBag.username = username;
            }
            return View();
        }

        public string Display(string username)
        {
            string name="";
            int i;
            for(i = 0;i <= 9; i++){
                name += username;
                name += "<br>";
            }
            return name;
        }

        public string Greet()
        {
            if (DateTime.Now.Hour <= 12)
            {
                return "<h1>Good Morning</h1>";
            }
            else if (DateTime.Now.Hour <= 16)
            {
                return "<h1>Good Afternoon</h1>";
            }
            else if (DateTime.Now.Hour <= 20)
            {
                return "Good Evening";
            }
            else
            {
                return "Good Night";
            }
        }
    }

}