using Microsoft.AspNetCore.Mvc;
using PasswordGeneratorApp.Models;

namespace PasswordGeneratorApp.Controllers
{
    public class PasswordGeneratorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new PasswordGenerator());
        }

        [HttpPost]
        public IActionResult Index(PasswordGenerator model)
        {
            if (ModelState.IsValid)
            {
                model.GeneratePassword();
                Console.WriteLine("Password Generated: " + model.GeneratedPassword); // Mensaje de registro
            }
            else
            {
                Console.WriteLine("Model State is not valid"); // Mensaje de registro
            }
            return View(model);
        }
    }
}

