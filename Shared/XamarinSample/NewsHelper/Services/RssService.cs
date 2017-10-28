﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using NewsLibrary.Models;

namespace NewsLibrary.Services
{
    public class RssService
    {
        public async Task<List<FeedItem>> GetNews(string url)
        {
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync(url);
            var xdoc = XDocument.Parse(data);
            return (from item in xdoc.Descendants("item")
                    select new FeedItem
                    {
                        Title = (string)item.Element("title"),
                        Description = (string)item.Element("description"),
                        Link = (string)item.Element("link")
                    }).ToList();
        }
    }

}
