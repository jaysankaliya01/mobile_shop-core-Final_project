using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
//using YourNamespace.Models; // Replace with your models namespace
//using YourNamespace.Data;   // Replace with your data context namespace
using System.Linq;
using mobile_shop_core_.Models;


//[Authorize(Roles = "Admin")]
//[Authorize(Roles = "Admin")]
namespace mobile_shop_core_.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _context;
        public AdminController(ILogger<HomeController> context)
        {
            _context = context;
        }

        // Display all products
        public IActionResult Products()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        // Add product: GET
        public IActionResult AddProduct()
        {
            return View();
        }

        // Add product: POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Products");
            }
            return View(product);
        }

        // Edit product: GET
        public IActionResult EditProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // Edit product: POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Products");
            }
            return View(product);
        }

        // Delete product
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return RedirectToAction("Products");
        }

    }
}
