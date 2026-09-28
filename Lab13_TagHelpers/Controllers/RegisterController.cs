using Microsoft.AspNetCore.Mvc;
using Lab13_TagHelpers.Models;

namespace Lab13_TagHelpers.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(RegisterModel model)
        {
            ViewBag.Message = "Registered: " + model.Name + " (" + model.Email + ")";
            return View("Index", model);
        }
    }
}