using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfoilo.Data;
using portfoilo.Models;
using System.Diagnostics;

namespace portfoilo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult About()
        {
            return View();
        }
        public async Task<IActionResult> Skills()
        {
            var skill = await _context.Skills.OrderBy(s => s.Category).ThenByDescending(s => s.Level).ToListAsync();
            return View(skill);
        }
        public async Task<IActionResult> Projects()
        {
            var project = await _context.Projects.OrderBy(p => p.Id).ToListAsync();
            return View(project);
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(Message message)
        {
            if (ModelState.IsValid)
            {
                message.ReceivedAt = DateTime.UtcNow;
                _context.Messages.Add(message);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Your message has been sent";
                return RedirectToAction("Contact");
            }
            return View(message);
        }
    }
}
