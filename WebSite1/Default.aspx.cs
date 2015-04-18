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
    protected void DriverInfoButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Standings/DriverInfo.aspx");
    }
    protected void CurrentRaceButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Standings/RaceResultsCurrent.aspx");
    }
}