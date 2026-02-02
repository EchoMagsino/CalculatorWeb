using Microsoft.AspNetCore.Mvc;
using CalculatorWeb.Models;

namespace CalculatorWeb.Controllers
{
    public class AdditionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            
            ViewBag.Title = "Addition Calculator";
            Addition addition = new Addition();
            addition.Sum = 0;
            return View(addition);
        }

        [HttpPost]

        public IActionResult Index(Addition a1) 
        {
            a1.CalculateSum();

            return View(a1);
        }

        
    }
}
