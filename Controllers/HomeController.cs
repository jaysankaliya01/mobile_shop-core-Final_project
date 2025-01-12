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
        // Admin Controller
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
        public IActionResult User_Addto_Cart_Page()
        {
            return View();
        }
        public IActionResult User_Home
            ()
        {
            return View();
        }



        //  ================== Products Controllers ========================

        //Mobile_Section
        public IActionResult Mobile_Section
            ()
        {
            return View();
        }
        public IActionResult Samsung
           ()
        {
            return View();
        }
        public IActionResult Vivo
           ()
        {
            return View();
        }
        public IActionResult IPhone
           ()
        {
            return View();
        }
        public IActionResult MI
           ()
        {
            return View();
        }
        public IActionResult OnePlus
           ()
        {
            return View();
        }
        public IActionResult Realme
           ()
        {
            return View();
        }



        //Samsung Products Controllers 
        public IActionResult Samsung_Buds
            ()
        {
            return View();
        }
        public IActionResult Samsung_Mobile
            ()
        {
            return View();
        }
        public IActionResult Samsung_Charger
            ()
        {
            return View();
        }
        public IActionResult Samsung_Cable
            ()
        {
            return View();
        }
        public IActionResult Samsung_Cover
            ()
        {
            return View();
        }

        //IPhone Products Controllers 
        public IActionResult IPhone_Buds
            ()
        {
            return View();
        }
        public IActionResult IPhone_Mobile
            ()
        {
            return View();
        }
        public IActionResult IPhone_Charger
            ()
        {
            return View();
        }
        public IActionResult IPhone_Cable
            ()
        {
            return View();
        }
        public IActionResult IPhone_Cover
            ()
        {
            return View();
        }

        //Vivo Products Controllers 
        public IActionResult Vivo_Buds
            ()
        {
            return View();
        }
        public IActionResult Vivo_Mobile
            ()
        {
            return View();
        }
        public IActionResult Vivo_Charger
            ()
        {
            return View();
        }
        public IActionResult Vivo_Cable
            ()
        {
            return View();
        }
        public IActionResult Vivo_Cover
            ()
        {
            return View();
        }


        //OnePlus Products Controllers 
        public IActionResult OnePlus_Buds
            ()
        {
            return View();
        }
        public IActionResult OnePlus_Mobile
            ()
        {
            return View();
        }
        public IActionResult OnePlus_Charger
            ()
        {
            return View();
        }
        public IActionResult OnePlus_Cable
            ()
        {
            return View();
        }
        public IActionResult OnePlus_Cover
            ()
        {
            return View();
        }

        //MI Products Controllers 
        public IActionResult MI_Buds
            ()
        {
            return View();
        }
        public IActionResult MI_Mobile
            ()
        {
            return View();
        }
        public IActionResult MI_Charger
            ()
        {
            return View();
        }
        public IActionResult MI_Cable
            ()
        {
            return View();
        }
        public IActionResult MI_Cover
            ()
        {
            return View();
        }


        //Realme Products Controllers 
        public IActionResult Realme_Buds
            ()
        {
            return View();
        }
        public IActionResult Realme_Mobile
            ()
        {
            return View();
        }
        public IActionResult Realme_Charger
            ()
        {
            return View();
        }
        public IActionResult Realme_Cable
            ()
        {
            return View();
        }
        public IActionResult Realme_Cover
            ()
        {
            return View();
        }






        // Controllers Down Side Area
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
