using Microsoft.AspNetCore.Mvc;
using TipCalculatorApp.Models;

namespace TipCalculatorApp.Controllers
{
    public class TipCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new TipCalculator());
        }

        [HttpPost]
        public IActionResult Index(TipCalculator model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateTip();
            }
            return View(model);
        }
    }
}

