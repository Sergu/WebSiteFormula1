using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private Repository repository;

    protected IEnumerable<News> GetNewsList()
    {
        return repository.NewsProperty;
    }
    //public List<DriverInfoPilot>;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (DriversStandings.GetDriverStandings() == null)
            {
                DriversStandings.MakeDriversStandings();
                Cache.Insert("DriverStandings",DriversStandings.GetDriverStandings(),null,DateTime.Now.AddMinutes(60),TimeSpan.Zero);                
            }
            else
            {
                    if (GetDriverStandingsFromCache().Count != 0)
                {
                    DriversStandings.SetDriverStandings(Cache["DriverStandings"] as List<Driver>);
                }
                else
                {
                    DriversStandings.MakeDriversStandings();
                    Cache.Insert("DriverStandings", DriversStandings.GetDriverStandings(), null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);
                }               
                
            }
            if (NewsPublishing.GetNewsColection() == null)
            {
                NewsPublishing.SetRssUrlFromDropListIndex(DropDownListRssUrls.SelectedIndex);
                NewsPublishing.ReadingNewsFromRssChanel();
            }
            if (TeamStandings.GetTeamStandings() == null)
            {
                TeamStandings.MakeTeamStandings();
                Cache.Insert("TeamStandings", TeamStandings.GetTeamStandings(), null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);
            }
            else
            {
                if (GetTeamStandingsFromCache().Count != 0)
                {
                    TeamStandings.SetTeamStandings(Cache["TeamStandings"] as List<Team>);
                }
                else
                {
                    TeamStandings.MakeTeamStandings();
                    Cache.Insert("TeamStandings", TeamStandings.GetTeamStandings(), null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);
                }
            }
            if (repository == null)
            {
                repository = new Repository();

                List<string> listRssUrls = new List<string>();
                foreach(News newsClass in GetNewsList())
                {
                    DropDownListRssUrls.Items.Add(newsClass.SiteUrl);
                    listRssUrls.Add(newsClass.RssLinq);
                }
                NewsPublishing.SetListRssUrls(listRssUrls);
            }

            //Cache.Insert("DriverStandings", DriversStandings.GetDriverStandings, null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);

            //RepeaterDrivers.DataSource = DriversStandings.GetFirstTenDrivers();
            RepeaterDrivers.DataSource = DriversStandings.GetDriverStandings();
            RepeaterDrivers.DataBind();
            RepeaterNews.DataSource = NewsPublishing.GetNewsColection();
            RepeaterNews.DataBind();
            RepeaterTeamStandings.DataSource = TeamStandings.GetTeamStandings();
            RepeaterTeamStandings.DataBind();
        }
    }

    protected void ButtonRefresh_Click(object sender, EventArgs e)
    {
        NewsPublishing.ReadingNewsFromRssChanel();
        RepeaterNews.DataSource = NewsPublishing.GetNewsColection();
        RepeaterNews.DataBind();
    }
    protected void DropDownListRssUrls_SelectedIndexChanged(object sender, EventArgs e)
    {
        NewsPublishing.SetRssUrlFromDropListIndex(DropDownListRssUrls.SelectedIndex);
        NewsPublishing.ReadingNewsFromRssChanel();
        RepeaterNews.DataSource = NewsPublishing.GetNewsColection();
        RepeaterNews.DataBind();
    }
    protected void ButtonUrlAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ListItem newElement = new ListItem();
            newElement.Text = TextBoxSite.Text;
            NewsPublishing.AddUrlToList(TextBoxUrl.Text);
            DropDownListRssUrls.Items.Add(newElement);
            using (TestDBContext context = new TestDBContext())
            {
                News news = new News();
                news.RssLinq = TextBoxUrl.Text;
                news.SiteUrl = TextBoxSite.Text;
                context.News.Add(news);
                context.SaveChanges();
            }
        }
    }
    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        int PrimaryKey = DropDownListRssUrls.SelectedIndex + 1;
        using (TestDBContext context = new TestDBContext())
        {
            context.News.Remove(context.News.Where(n => n.SiteUrl == DropDownListRssUrls.SelectedItem.Text).First());
            context.SaveChanges();
        }
        NewsPublishing.RemoveUrlFromList(DropDownListRssUrls.SelectedIndex);
        DropDownListRssUrls.Items.RemoveAt(DropDownListRssUrls.SelectedIndex);
    }

    private List<Driver> GetDriverStandingsFromCache()
    {
        var ListDriverStandings = Cache["DriverStandings"] as List<Driver>;

        return ListDriverStandings;
    }
    private List<Team> GetTeamStandingsFromCache()
    {
        var listTeam = Cache["TeamStandings"] as List<Team>;
        return listTeam;
    }
}