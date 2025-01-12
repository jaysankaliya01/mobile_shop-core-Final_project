using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mobile_shop_core_.Models;

namespace mobile_shop_core_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Admin_Dashboard()
        {
            return View();
        }
        public IActionResult User_Aboutus()
        {
            return View();
        }
        public IActionResult User_Contactus()
        {
            return View();
        }
        public IActionResult User_Home
            ()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
