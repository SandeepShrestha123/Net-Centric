using Microsoft.AspNetCore.Mvc;
using Lab11_MvcDemo.Models;
using System.Collections.Generic;

namespace Lab11_MvcDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 75000 },
                new Product { Id = 2, Name = "Mouse", Price = 500 },
                new Product { Id = 3, Name = "Keyboard", Price = 1200 }
            };

            return View(products);
        }
    }
}