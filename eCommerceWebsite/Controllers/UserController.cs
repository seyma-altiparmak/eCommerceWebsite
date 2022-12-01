using eCommerceWebsite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerceWebsite.Controllers
{
    public class UserController:Controller
    {
        private readonly AppDBContext? _context;

        public UserController(AppDBContext? context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Users.ToListAsync();
            return View();
        }
    }
}
