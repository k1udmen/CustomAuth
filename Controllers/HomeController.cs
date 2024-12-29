using CustomAuth.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomAuth.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Anasayfaya donduren aksiyon methodu
        public IActionResult Index()
        {
            return View();
        }

        //Privacy'e aksiyon methodu
        public IActionResult Privacy()
        {
            return View();
        }

        //Hata sayfasina aksiyon methodu
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
