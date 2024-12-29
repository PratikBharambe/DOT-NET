using System.Diagnostics;
using _12PartialView.Models;
using Microsoft.AspNetCore.Mvc;

namespace _12PartialView.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<Product> productList = new List<Product>() { 
            new Product() { Id=1, Name="Laptop", Description = "16 gb ram 14 inch screen", Price = 150000, Image = "~/Images/laptop.jpg"},
            new Product() { Id=2, Name="Hard Disk", Description = "1TB Sandisk", Price = 5000, Image = "~/Images/harddisk.jpg"},
            new Product() { Id=3, Name="mobile", Description = "16 gb ram 6.6 inch screen", Price = 50000, Image = "~/Images/mobile.jpg"},
            };
            return View(productList);
        }



        public IActionResult About()
        {
            return View();
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
