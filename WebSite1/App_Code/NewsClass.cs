using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Сводное описание для NewsClass
/// </summary>

public class NewsClass
{
    public int NewsID { get; set; }
    public string SiteUrl { get; set; }
    public string RssLinq { get; set; }
}