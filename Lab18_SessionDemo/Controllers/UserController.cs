using Microsoft.AspNetCore.Mvc;

namespace Lab18_SessionDemo.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult SetName()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetName(string name)
        {
            HttpContext.Session.SetString("UserName", name);  
            return RedirectToAction("GetName");
        }

        // retrieve name
        public IActionResult GetName()
        {
            string name = HttpContext.Session.GetString("UserName"); 
            ViewBag.UserName = name;
            return View();
        }
    }
}