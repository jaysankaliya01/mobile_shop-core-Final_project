using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

//[Authorize(Roles = "User")]
namespace mobile_shop_core_.Controllers 
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
