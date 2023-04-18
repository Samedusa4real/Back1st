using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult About()
        {
            return View();
        }
    }
}
