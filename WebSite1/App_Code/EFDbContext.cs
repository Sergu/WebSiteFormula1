using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;   

/// <summary>
/// Сводное описание для EFDbContext
/// </summary>
public class EFDbContext : DbContext
{
    public EFDbContext()
        : base("name=TestDBContext")
    {
    }
    public DbSet<NewsClass> News { get; set; }
}