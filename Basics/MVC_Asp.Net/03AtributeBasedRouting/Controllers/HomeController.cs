using Microsoft.AspNetCore.Mvc;

namespace _03AtributeBasedRouting.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
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
