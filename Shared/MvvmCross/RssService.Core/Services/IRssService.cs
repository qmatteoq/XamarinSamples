using System.Collections.Generic;
using System.Threading.Tasks;
using RssService.Core.Models;

namespace RssService.Core.Services
{
    public interface IRssService
    {
        Task<List<FeedItem>> GetNewsAsync(string url);
    }
}