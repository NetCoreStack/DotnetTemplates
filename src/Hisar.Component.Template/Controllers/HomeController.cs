using Hisar.Component.Template.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Hisar.Component.Template.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.StrProperty = DateTime.Now.ToString();
            return View();
        }
        
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(GuidelineViewModel model)
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrationJson([FromBody]GuidelineViewModel model)
        {
            return Json(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}