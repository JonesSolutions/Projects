using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDemo.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int id = 1)
        {
            //return "Welcome to my application";

            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {id}");

            ViewData["message"] = "Hello " + name;
            ViewData["numTimes"] = id;

            return View();
         }

    }
}
