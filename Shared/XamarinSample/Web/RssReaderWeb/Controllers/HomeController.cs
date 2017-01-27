using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsLibrary.Services;

namespace RssReaderWeb.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            RssService service = new RssService();
            var news = await service.GetNews("https://blogs.msdn.microsoft.com/appconsult/feed/");

            return View(news);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
