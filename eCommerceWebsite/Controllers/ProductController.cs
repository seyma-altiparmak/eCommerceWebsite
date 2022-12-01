using eCommerceWebsite.Data;
using Microsoft.AspNetCore.Mvc;
namespace eCommerceWebsite.Controllers
{
    public class ProductController:Controller
    {
        private readonly AppDBContext? _context;

        public ProductController(AppDBContext? context)
        {
            _context = context;
        }

        public IActionResult Index() {
            var data = _context.Products.ToList();
            return View();
        }
    }
}
