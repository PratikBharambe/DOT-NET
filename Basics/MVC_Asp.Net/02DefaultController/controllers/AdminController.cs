using Microsoft.AspNetCore.Mvc;

namespace _02DefaultController.controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
