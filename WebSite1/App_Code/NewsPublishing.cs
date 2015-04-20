using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Сводное описание для NewsPublishing
/// </summary>
public class NewsPublishing
{
    private static List<Feed> NewsCollection;
    public static IEnumerable<Feed> GetNewsColection()
    {
        return NewsCollection;
    }
    public static void ReadingNewsFromRssChanel()
    {
        string rssFeedUrl = "http://www.f1-world.ru/news/rssexp6.xml";
        NewsCollection = new List<Feed>();
        try
        {
            XDocument xDoc = new XDocument();
            xDoc = XDocument.Load(rssFeedUrl);

            var items = (from x in xDoc.Descendants("item")
                         select new
                         {
                             title = x.Element("title").Value,
                             link = x.Element("link").Value,
                             pubDate = x.Element("pubDate").Value,
                             description = x.Element("description").Value,
                         });
            if (items != null)
            {
                foreach (var i in items)
                {
                    Feed feed = new Feed
                    {
                        Title = i.title,
                        Link = i.link,
                        PublishDate = i.pubDate,
                        Description = i.description,
                    };
                    NewsCollection.Add(feed);
                }
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}