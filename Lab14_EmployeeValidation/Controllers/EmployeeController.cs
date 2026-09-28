using Microsoft.AspNetCore.Mvc;
using Lab14_EmployeeValidation.Models;

namespace Lab14_EmployeeValidation.Controllers
{
	public class EmployeeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Employee model)
		{
			if (ModelState.IsValid)
			{
				ViewBag.Message = "Employee registered successfully: " + model.Name;
				ModelState.Clear();
				return View(new Employee());
			}
			return View(model);
		}
	}
}