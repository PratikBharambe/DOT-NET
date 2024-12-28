using System.Collections;
using _06Views.Models;
using Microsoft.AspNetCore.Mvc;

namespace _06Views.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Emp emp = new Emp() { Id = 15, Name = "Pratik", 
            Address = "Pune"};
            Cust cust = new Cust() { Id = 41, Name = "Lalit", Address = "Nanded" };
            ArrayList arrList = new ArrayList() { emp, cust };
            return View(arrList);
        }
    }
}
