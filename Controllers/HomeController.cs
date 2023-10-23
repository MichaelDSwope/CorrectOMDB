using AspNetCore;
using Microsoft.AspNetCore.Mvc;     
using OMDB.Models;
using System.Diagnostics;

namespace OMDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult GetMovieTitle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result([FromForm]Movies movies) 
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("GetMovie");
            }
            return View(); 
        }

        
        public IActionResult Index()
        {
            return View();
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