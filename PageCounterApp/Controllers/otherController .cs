using Microsoft.AspNetCore.Mvc;
using PageCounterApp.Services;
using PageCounterApp.Models;
namespace PageCounterApp.Controllers
{
    
    public class otherController : Controller
    {
        private IPageCount pageCount;

        public otherController(IPageCount newPageCount) 
        {
            pageCount = newPageCount;
        }
        [HttpGet()]
        public IActionResult Index()
        {
            return View(pageCount.IncrementPageCount("other"));//returns the int from the interface function call to the view displayed by the model
        }
    }
}