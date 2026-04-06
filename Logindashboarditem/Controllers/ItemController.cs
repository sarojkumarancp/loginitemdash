using Logindashboarditem.Models;
using Microsoft.AspNetCore.Mvc;

namespace Logindashboarditem.Controllers
{
    public class ItemController : Controller
    {
       
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.ItemMasters.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ItemMaster item)
        {
            _context.ItemMasters.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
