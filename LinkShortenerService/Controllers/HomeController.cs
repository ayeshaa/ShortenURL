using LinkShortenerService.Models;
using LinkShortenerService.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace LinkShortenerService.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IURLShortenerService _linkShortenerService;

        public HomeController(ILogger<HomeController> logger, IURLShortenerService linkShortenerService)
        {
            _logger = logger;
            _linkShortenerService = linkShortenerService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string link)
        {
            try
            {
                if (!link.Contains("http"))
                {
                    link = "http://" + link;
                }
                var shortUrl = _linkShortenerService.UrlShorten(link);
                return Json(shortUrl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
