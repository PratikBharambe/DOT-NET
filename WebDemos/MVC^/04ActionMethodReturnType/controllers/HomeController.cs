using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace _04ActionMethodReturnType.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // http://localhost:6370/Home/GetSomeName?name=Pratik&surname=Bharambe
        public ActionResult<string> GetSomeName (string name, string surname)
        {
            return $"Name : {name} Surname : {surname}";
        }

        // http://localhost:6370/Home/GetMeSomeString/125?name=Pratik
        public string GetMeSomeString(int id, string name)
        {
            string opStr = $"Id = {id}, name = {name}";
            return opStr;
        }

        // http://localhost:6370/Home/GetMeSomeString2?Id=15&str=Hello%20From%20IET%20student
        public string GetMeSomeString2(int Id, string str)
        {
            string opStr = $"Id = {Id}, str = {str}";
            return opStr;
        }

        // http://localhost:6370/Home/GetJsonData
        public JsonResult GetJsonData()
        {
            var data = new
            {
                name = "Institute of Emerging Technology",
                address = "Model Colony, Pune",
                courses = new[] { "CPP", "WPT", "SDM&OS", "JAVA", "DSA", "J2EE", "Apptitube", "MS DOT NET" }
            };
            
            return Json(data);
            
        }

        // http://localhost:6370/Home/About
        public ViewResult About()
        {
            return View();
        }

        // http://localhost:6370/Home/DownloadFile 
        public FileResult DownloadFile()
        {
            string filePath = @"C:\Users\IET\Desktop\MS DOT NET Lab\WebDemos\MVC^\04ActionMethodReturnType\Data\spadex.pdf";
            var byteArray = System.IO.File.ReadAllBytes(filePath);
            return File(byteArray, "application/pdf", "spadex.pdf");
        }

        // http://localhost:6370/Home/DoNothing
        public EmptyResult DoNothing()
        {
            return new EmptyResult();
        }


        // http://localhost:6370/Home/GetStatusCode
        public StatusCodeResult GetStatusCode()
        {
            return StatusCode(500);
        }


        // http://localhost:6370/Home/GetSomeObject
        public ObjectResult GetSomeObject()
        {
            var obj = new { name = "Pratik", address = "Kund Khurd" };
            return new ObjectResult(obj);
        }

        [HttpGet("Home/GetDataAsync")]
        public async Task<IActionResult> GetDataAsync()
        {
            await Task.Delay(3000);
            return View("~/Views/Home/GetData.cshtml");
        }

    }
}
