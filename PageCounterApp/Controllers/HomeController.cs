using Microsoft.AspNetCore.Mvc;
using PageCounterApp.Services;

namespace PageCounterApp.Controllers
{
    public class HomeController : Controller
    {
        private PageCount PageCount = new PageCount();
        public HomeController(PageCount count)
        {
            PageCount = count;
        }

        public IActionResult Index()
        {
            PageCount.Count("Home");
            return View();
        }
    }
}