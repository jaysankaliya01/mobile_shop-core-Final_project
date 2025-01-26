using Microsoft.AspNetCore.Mvc;
using mobile_shop_core_.Models;
using System.Collections.Generic;
using System.Linq;
namespace mobile_shop_core_.Views.Home
{
    public class ProductController : Controller
    {
        private static List<Product> Products = new List<Product>();

        public IActionResult Index()
        {
            return View(Products);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = Products.Count > 0 ? Products.Max(p => p.Id) + 1 : 1; // Auto-increment ID
                Products.Add(product);
                return RedirectToAction("Index");
            }
            return View("Index", Products);
        }

        [HttpPost]
        public IActionResult EditProduct(Product updatedProduct)
        {
            var product = Products.FirstOrDefault(p => p.Id == updatedProduct.Id);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Category = updatedProduct.Category;
                product.Shop = updatedProduct.Shop;
                product.Quantity = updatedProduct.Quantity;
                product.Price = updatedProduct.Price;
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                Products.Remove(product);
            }
            return RedirectToAction("Index");
        }
    }
}
