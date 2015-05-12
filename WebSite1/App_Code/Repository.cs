using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для Repository
/// </summary>
public class Repository
{
    private TestDBContext context = new TestDBContext();

    public IEnumerable<News> NewsProperty
    {
        get { return context.News; }
    }
}