using _06EEntityFrameworkCodeFirst.DAL;
using _06EEntityFrameworkCodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace _06EEntityFrameworkCodeFirst.Controllers
{
    public class HomeController : Controller
    {

        private readonly TestDbContext? _dbContext;

        public HomeController(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Movies> movies = _dbContext.Movies.ToList();
            return View(movies);
        }
    }
}
