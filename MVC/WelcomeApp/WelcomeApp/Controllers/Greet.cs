using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeApp.Controllers
{
    public class Greet:Controller
    {
        public string Display()
        {
            if (DateTime.Now.Hour <= 12)
            {
                return "Good Morning";
            } 
            else if (DateTime.Now.Hour <= 16)
            {
                return "Good Afternoon";
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