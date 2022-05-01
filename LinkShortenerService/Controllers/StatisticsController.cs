using LinkShortenerService.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LinkShortenerService.Controllers
{
    public class StaticsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IURLShortenerService _linkShortenerService;

        public StaticsController(ILogger<HomeController> logger, IURLShortenerService linkShortenerService)
        {
            _linkShortenerService = linkShortenerService;
        }
        public IActionResult Index()
        {
            var urlStatistics = _linkShortenerService.UrlShorten("domain");
            return View();
        }
    }
}
