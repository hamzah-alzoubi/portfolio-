using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfoilo.Data;


namespace portfoilo.Controllers
{
    [Authorize(Roles = "Admin")]

    public class MessagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MessagesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Messages.OrderByDescending(m => m.ReceivedAt).ToListAsync();
            return View(data);
        }
    }
}
