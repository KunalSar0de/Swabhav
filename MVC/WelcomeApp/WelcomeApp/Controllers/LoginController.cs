
using System.Web.Mvc;
using WelcomeApp.ViewModel.Login;

namespace WelcomeApp.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new LoginIndexViewModel());
        }

        [HttpPost]
        public ActionResult Index(LoginIndexViewModel vm)
        {
            if (AuthCredentials(vm.UserName, vm.UserPassword)==true)
            {
                vm.Message = "Wrong credentials";
            }
            else
            {
                vm.Message = "Successfull Login";
            }
            return View(vm);
        }


        //service
        public bool AuthCredentials(string username,string password)
        {      
            if(username!="admin" || password != "admin")
            {               
                return true;
            }
            return false;
        }
    }
}