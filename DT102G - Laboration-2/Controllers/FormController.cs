using DT102G___Laboration_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DT102G___Laboration_2.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
                return View();
        }

        [HttpGet]
        public IActionResult Questionaire()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Questionaire(Form form)
        {
            // Skicka till resultatsidan om alla formulärsfälten validerar korrekt.. 
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result", form);
            }
            // Skriv ut felmeddelanden.
            else
            {
                return View(form);
            }
        }

        public IActionResult Result(Form form)
        {
            // Skriv ut data med ViewData.
            ViewData["Age"] = form.Age;
            // Skriv ut data med ViewBag.
            ViewBag.Gender = form.Gender;
            // Skriv ut data med parameterpassning.
            return View(form);
        }
    }
}