using Microsoft.AspNetCore.Mvc;

namespace session2_mvc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }


    }
}
