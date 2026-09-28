using Microsoft.AspNetCore.Mvc;
using Lab15_CustomRouting.Models;

namespace Lab15_CustomRouting.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Details(int id)
        {
            Employee emp = new Employee
            {
                Id = id,
                Name = "Employee " + id,
                Department = "IT"
            };

            return View(emp);
        }
    }
}