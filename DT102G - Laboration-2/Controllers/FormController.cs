using DT102G___Laboration_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

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
                // Konvertera formulärsobjekt till JSON-sträng.
                string jStr = JsonConvert.SerializeObject(form);
                // Spara formulärsobjekt som en sessionsvariabel.
                HttpContext.Session.SetString("FormSession", jStr);
                // Skicka användaren till nästa steg.
                return RedirectToAction("Result");
            }
            // Skriv ut felmeddelanden.
            else
            {
                return View();
            }
        }

        public IActionResult Result()
        {
            string jStr = HttpContext.Session.GetString("FormSession");
            // Konvertera JSON-sträng till formulärsobjekt.
            var form = JsonConvert.DeserializeObject<Form>(jStr);
            // Skriv ut data med ViewData.
            ViewData["Age"] = form.Age;
            // Skriv ut data med ViewBag.
            ViewBag.Gender = form.Gender;
            // Skriv ut data med parameterpassning.
            return View(form);
        }
    }
}