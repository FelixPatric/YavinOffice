using Microsoft.AspNetCore.Mvc;
using YavinOffice.Data;
using YavinOffice.Model;

namespace YavinOffice.Controllers
{
    public class HomeController : Controller
    {
        private readonly SiteVisitorDbContext _context;

        public HomeController(SiteVisitorDbContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Details() 
        {
            return View();
        }
        public IActionResult Projects() 
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(SiteVisitorInfor siteVistorInfor)
        {
            _context.SiteVisitors.Add(siteVistorInfor);
            _context.SaveChanges();
            
            return View("index");
        }
    }
}
