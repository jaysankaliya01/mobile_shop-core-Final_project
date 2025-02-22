using Microsoft.AspNetCore.Mvc;

namespace mobile_shop_core_.Area.User.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
