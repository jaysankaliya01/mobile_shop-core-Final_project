using ECommercePlatform.Constants;
using ECommercePlatform.Filters;
using Microsoft.AspNetCore.Mvc;

namespace mobile_shop_core_.Areas.Admin.Controllers
{
    [Area(UserRole.Admin)]
    [AdminAuthCheck]
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewData["ActiveMenu"] = "Home";

            return View();
        }
    }
}
