using Microsoft.AspNetCore.Mvc;
using CalculatorWeb.Models;

namespace CalculatorWeb.Controllers
{
    public class AdditionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            
       
            return View();
        }

        [HttpPost]

        public IActionResult Index(Addition a1) 
        {
            

            return View(a1);
        }

        
    }
}
