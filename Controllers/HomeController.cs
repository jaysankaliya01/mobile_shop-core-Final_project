using System.Diagnostics;
using System.Reflection;
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


        //  Users Controller

        // User_Aboutus
        public IActionResult User_Aboutus()
        {
            return View();
        }

        // User_Contactus
        public IActionResult User_Contactus()
        {
            return View();
        }

        //User_Addto_Cart_Page
        public IActionResult User_Addto_Cart_Page()
        {
            return View();
        }

        // User_Home
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

        // Mobile Accessories
        public IActionResult Mobile_Accessories
           ()
        {
            return View();
        }
        //Gallery
        public IActionResult Gallery
          ()
        {
            return View();
        }

        // Samsung
        public IActionResult Samsung
           ()
        {
            return View();
        }

        //Vivo
        public IActionResult Vivo
           ()
        {
            return View();
        }

        // IPhone
        public IActionResult IPhone
           ()
        {
            return View();
        }

        // MI
        public IActionResult MI
           ()
        {
            return View();
        }

        // OnePlus
        public IActionResult OnePlus
           ()
        {
            return View();
        }

        // Realme
        public IActionResult Realme
           ()
        {
            return View();
        }



        //Samsung Products Controllers 

        // Samsung_Buds
        public IActionResult Samsung_Buds
            ()
        {
            return View();
        }

        // Samsung_Mobile
        public IActionResult Samsung_Mobile
            ()
        {
            return View();
        }

        // Samsung_Charger
        public IActionResult Samsung_Charger
            ()
        {
            return View();
        }

        // Samsung_Cable
        public IActionResult Samsung_Cable
            ()
        {
            return View();
        }

        // Samsung_Cover
        public IActionResult Samsung_Cover
            ()
        {
            return View();
        }

        //IPhone Products Controllers 

        // IPhone_Buds
        public IActionResult IPhone_Buds
            ()
        {
            return View();
        }

        // IPhone_Mobile
        public IActionResult IPhone_Mobile
            ()
        {
            return View();
        }

        // IPhone_Charger
        public IActionResult IPhone_Charger
            ()
        {
            return View();
        }

        // IPhone_Cable
        public IActionResult IPhone_Cable
            ()
        {
            return View();
        }

        // IPhone_Cover
        public IActionResult IPhone_Cover
            ()
        {
            return View();
        }

        //Vivo Products Controllers 

        // Vivo_Buds
        public IActionResult Vivo_Buds
            ()
        {
            return View();
        }

        // Vivo_Mobile
        public IActionResult Vivo_Mobile
            ()
        {
            return View();
        }

        // Vivo_Charger
        public IActionResult Vivo_Charger
            ()
        {
            return View();
        }
        // Vivo_Cable
        public IActionResult Vivo_Cable
            ()
        {
            return View();
        }

        // Vivo_Cover
        public IActionResult Vivo_Cover
            ()
        {
            return View();
        }


        //OnePlus Products Controllers 

        // OnePlus_Buds
        public IActionResult OnePlus_Buds
            ()
        {
            return View();
        }

        // OnePlus_Mobile
        public IActionResult OnePlus_Mobile
            ()
        {
            return View();
        }

        // OnePlus_Charger
        public IActionResult OnePlus_Charger
            ()
        {
            return View();
        }

        // OnePlus_Cable
        public IActionResult OnePlus_Cable
            ()
        {
            return View();
        }

        // OnePlus_Cover
        public IActionResult OnePlus_Cover
            ()
        {
            return View();
        }

        //MI Products Controllers 

        //MI_Buds
        public IActionResult MI_Buds
            ()
        {
            return View();
        }

        //MI_Mobile
        public IActionResult MI_Mobile
            ()
        {
            return View();
        }

        //MI_Charger
        public IActionResult MI_Charger
            ()
        {
            return View();
        }

        // MI_Cable
        public IActionResult MI_Cable
            ()
        {
            return View();
        }

        // MI_Cover
        public IActionResult MI_Cover
            ()
        {
            return View();
        }


        //Realme Products Controllers 

        // Realme_Buds
        public IActionResult Realme_Buds
            ()
        {
            return View();
        }

        // Realme_Mobile
        public IActionResult Realme_Mobile
            ()
        {
            return View();
        }

        // Realme_Charger
        public IActionResult Realme_Charger
            ()
        {
            return View();
        }

        // Realme_Cable
        public IActionResult Realme_Cable
            ()
        {
            return View();
        }

        // Realme_Cover
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
