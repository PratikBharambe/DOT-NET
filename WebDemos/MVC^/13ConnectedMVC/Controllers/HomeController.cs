using System.Diagnostics;
using _13ConnectedMVC.DAL;
using _13ConnectedMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13ConnectedMVC.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            TestDbContext testDbContext = new TestDbContext();
            var allEmps = testDbContext.GetAllEMployees();
            return View(allEmps);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
