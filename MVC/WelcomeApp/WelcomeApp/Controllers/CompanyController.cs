using System.Web.Mvc;
using WelcomeApp.ViewModel.Company;

namespace WelcomeApp.Controllers
{
    public class CompanyController:Controller
    {
        public ActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel 
            { ImgURL= @"/assets/download.jpg",
              Description ="AurionPro Solution Ltd",
              Address="Rabale"                          
            }; 
            return View(vm);
        }
    }
}