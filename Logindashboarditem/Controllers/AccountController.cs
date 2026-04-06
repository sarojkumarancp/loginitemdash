using Logindashboarditem.Models;
using Microsoft.AspNetCore.Mvc;

namespace Logindashboarditem.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;

            // Seed user
            if (!_context.Users.Any())
            {
                _context.Users.Add(new User { Username = "admin", Password = "1234" });
                _context.SaveChanges();
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users
            .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("User", username);
                return RedirectToAction("Index", "Dashboard");
            }

            ViewBag.Error = "Invalid Username or Password";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

    }
}
