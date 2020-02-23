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

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        public string CalcSum(int num1, int num2, string? name)
        {
            int sum = num1 + num2;


            return HtmlEncoder.Default.Encode($"Hello {name}, Your sum is: {sum}");
        }
    }
}