using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace mobile_shop_core_.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        // Login
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, false, false);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(email);
                var roles = await _userManager.GetRolesAsync(user);

                if (roles.Contains("Admin"))
                    return RedirectToAction("Index", "Admin");  // Redirect to Admin Panel
                else
                    return RedirectToAction("Index", "User");   // Redirect to User Panel
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View();
        }

        // Logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        // Access Denied
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
