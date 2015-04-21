using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //public List<DriverInfoPilot>;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (DriversStandings.GetDriverStandings() == null)
            {
                DriversStandings.MakeDriversStandings();
            }
            if (NewsPublishing.GetNewsColection() == null)
            {
                NewsPublishing.SetRssUrlFromDropListIndex(DropDownListRssUrls.SelectedIndex);
                NewsPublishing.ReadingNewsFromRssChanel();
            }
            if (TeamStandings.GetTeamStandings() == null)
            {
                TeamStandings.MakeTeamStandings();
            }
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
        ListItem newElement = new ListItem();
        newElement.Text = TextBoxSite.Text;
        NewsPublishing.AddListRssUrls(TextBoxUrl.Text);
        DropDownListRssUrls.Items.Add(newElement);
    }
    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        DropDownListRssUrls.Items.RemoveAt(DropDownListRssUrls.SelectedIndex);
        NewsPublishing.RemoveListUrls(DropDownListRssUrls.SelectedIndex);
    }
}