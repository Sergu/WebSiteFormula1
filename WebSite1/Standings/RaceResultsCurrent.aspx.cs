using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Standings_RaceResultsCurrent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (DriversStandings.GetDriverStandings() == null)
            {
                DriversStandings.MakeDriversStandings();
            }
            RepeaterDriverStandingsFull.DataSource = DriversStandings.GetDriverStandings();
            RepeaterDriverStandingsFull.DataBind();
        }
    }


    protected void ButtonBackCurrentRace_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
}