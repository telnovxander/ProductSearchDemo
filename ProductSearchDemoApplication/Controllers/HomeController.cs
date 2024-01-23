using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductSearchDemoApplication.AppData;
using ProductSearchDemoApplication.Models;
using System.Diagnostics;
using System.Linq;

namespace ProductSearchDemoApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            var productViewModels = products.Select(p => new ProductViewModel
            {
                Description = p.Description,
                ImagePath = p.ImagePath
            }).ToList();

            return View(productViewModels);
        }

        [HttpGet]
        public IActionResult SearchProducts(string searchString)
        {
            var searchResults = _context.Products
                .Where(p => string.IsNullOrEmpty(searchString) || p.Description.ToLower().Contains(searchString.ToLower()))
                .Select(p => new ProductViewModel
                {
                    Description = p.Description,
                    ImagePath = p.ImagePath
                })
                .ToList();

            return Json(searchResults);
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
    }
}
