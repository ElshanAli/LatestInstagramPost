using LatestInstagramPostsWithToken.Models;
using LatestInstagramPostsWithToken.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace LatestInstagramPostsWithToken.Controllers
{
    public class HomeController : Controller
    {
        private readonly InstagramService _instagramService;
        public HomeController(InstagramService instagramService)
        {
            _instagramService = instagramService;
        }

        public async Task<IActionResult> Index()
        {
            var media = await _instagramService.FetchRecentMediaAsync();
            return View(media);
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