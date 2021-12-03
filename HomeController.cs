using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            // ViewResult myView = View();
            return View();
        }
        [HttpPost("/result")]
        public IActionResult Result(string name, string location, string language, string comment)
        {
            ViewBag.StudentName = name;
            ViewBag.Location = location;
            ViewBag.FavLanguage = language;
            ViewBag.Comment = comment;
            return View();
        }
    }
}