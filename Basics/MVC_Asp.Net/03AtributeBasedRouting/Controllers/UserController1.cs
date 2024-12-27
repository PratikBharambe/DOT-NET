using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace _03AtributeBasedRouting.Controllers
{
    [Route("{Controller}")]
    public class UserController1 : Controller
    {
       [Route("{Action}")]
        public IActionResult Index()
        {
            return View();
        }

        public int GetNumber(int? id) //int? nullable
        {
            return id ??= 7980;  //id ??=7980 If id is null  
        }
    }
}
