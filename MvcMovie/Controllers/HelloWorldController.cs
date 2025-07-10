using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public string Welcome(string name,int age=1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, your age is: {age}"); 
        //}

        public IActionResult Welcome(string name, int age = 1)
        {
            ViewData["Message"] = "Hi" + name;
            ViewData["Age"] = age;
            return View();
        }
    }
}   
