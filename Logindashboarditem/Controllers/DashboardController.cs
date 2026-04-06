using Microsoft.AspNetCore.Mvc;

namespace Logindashboarditem.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("User") == null)
                return RedirectToAction("Login", "UserLogin");

            return View();
        }
    }
}
