using Microsoft.AspNetCore.Mvc;
using CalculatorWeb.Models;

namespace CalculatorWeb.Controllers
{
    public class MultiplicationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Multiplication multiplication = new Multiplication();

            return View(multiplication);
        }

        [HttpPost]
        public IActionResult Index(Multiplication m1)
        {
            return View(m1);
        }
    }
}
