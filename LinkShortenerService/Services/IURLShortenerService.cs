using LinkShortenerService.Models;

namespace LinkShortenerService.Services
{
    public interface IURLShortenerService
    {
        URLResponse UrlShorten(string url);
    }
}
