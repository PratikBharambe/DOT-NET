using Microsoft.AspNetCore.Mvc;

namespace _03AttributeBasedRouting.controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        //[Route("Home")]
        [Route("~/")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
