using Microsoft.AspNetCore.Mvc;
using PageCounterApp.Services;
using PageCounterApp.Models;
namespace PageCounterApp.Controllers
{
    public class HomeController : Controller
    {
        private PageCount PageCount;
        SimpleInt count;
        public HomeController() 
        {
            count = new SimpleInt();
            PageCount = new PageCount();
        }
        [HttpGet()]
        public IActionResult Index()
        {
            count.count = PageCount.Count("Home");
            return View(count);
        }
    }
}