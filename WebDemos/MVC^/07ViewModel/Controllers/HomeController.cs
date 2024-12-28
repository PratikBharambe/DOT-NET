using _07ViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07ViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ProductViewModel product = new ProductViewModel()
            {
                Product = new Product() { Id = 404, Name = "ASUS Laptop", Price = 75800},
                CatagoryName = "Electronics",
                InStock = false,
                Message = "Company : ASUS, i7, Gen 11, RAM : 32GB"
            };
            return View(product);
        }

        public IActionResult ProductDetails(int id)
        {
            Product product = new Product() { 
                Id = 404,
                Name = "ASUS Laptop",
                Price = 75000
            };
            return View(product);
        }
    }
}
