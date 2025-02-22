using Microsoft.AspNetCore.Mvc;

namespace mobile_shop_core_.Area.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
