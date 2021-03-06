﻿using System;
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
    private static string CurrentRssUrl {get;set;}

    //private static List<string> listRssUrls = new List<string> { "http://www.f1-world.ru/news/rssexp6.xml", "http://www.f1news.ru/export/news.xml", "http://www.championat.com/xml/rss_auto_f1-article.xml", "http://www.autofaq.com.ua/rss/blog/formula-1/" };
    private static List<string> listRssUrls;
    public static IEnumerable<Feed> GetNewsColection()
    {
        return NewsCollection;
    }

    public static void SetRssUrlFromDropListIndex(int index)
    {
        if (index != -1)
        {
            CurrentRssUrl = listRssUrls.ElementAt(index);
        }
        else
            CurrentRssUrl = null;
    }

    public static void AddUrlToList(string url)
    {
        listRssUrls.Add(url);
    }

    public static void SetListRssUrls(List<String> newListUrls)
    {
        listRssUrls = newListUrls;
    }

    public static void RemoveUrlFromList(int index)
    {
        listRssUrls.RemoveAt(index);
    }
    public static void ReadingNewsFromRssChanel()
    {
        string rssFeedUrl = CurrentRssUrl;
        NewsCollection = new List<Feed>();
        try
        {
            XDocument xDoc = new XDocument();
            xDoc = XDocument.Load(rssFeedUrl);

            var k = xDoc.Descendants("item");
          
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
            NewsCollection.Clear();
        }
    }
}