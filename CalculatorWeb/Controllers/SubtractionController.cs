using Microsoft.AspNetCore.Mvc;
using CalculatorWeb.Models;
namespace CalculatorWeb.Controllers
{
    public class SubtractionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Index(Subtraction s1)
        { 
            return View(s1);

        }
    }
}
