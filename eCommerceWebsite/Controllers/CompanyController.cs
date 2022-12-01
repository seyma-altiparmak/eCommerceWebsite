using eCommerceWebsite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace eCommerceWebsite.Controllers
{
    public class CompanyController:Controller
    {
        private readonly AppDBContext? _context;

        public CompanyController(AppDBContext? context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Companies.ToListAsync();
            return View();
        }
    }
}
