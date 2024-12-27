using Microsoft.AspNetCore.Mvc;

namespace _02DefaultController.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
