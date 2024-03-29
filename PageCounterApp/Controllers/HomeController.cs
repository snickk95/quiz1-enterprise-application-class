﻿using Microsoft.AspNetCore.Mvc;
using PageCounterApp.Services;
using PageCounterApp.Models;
namespace PageCounterApp.Controllers
{
    
    public class HomeController : Controller
    {
        private IPageCount pageCount;

        public HomeController(IPageCount newPageCount) 
        {
            pageCount = newPageCount;
        }
        [HttpGet()]
        public IActionResult Index()
        {
            return View(pageCount.IncrementPageCount("Home"));//returns the int from the interface function call to the view displayed by the model
        }
    }
}