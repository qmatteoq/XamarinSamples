using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsLibrary.Services;
using NewsLibrary.Models;

namespace RssReader.Pages
{
    public class IndexModel : PageModel
    {
        public List<FeedItem> NewsList = new List<FeedItem>();

        public async Task OnGet()
        {
            RssService service = new RssService();
            string url = "https://blogs.msdn.microsoft.com/appconsult/feed/";
            NewsList = await service.GetNews(url);
        }
    }
}