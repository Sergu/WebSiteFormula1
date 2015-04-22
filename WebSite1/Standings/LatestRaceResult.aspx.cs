using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Standings_LatestRaceResult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if(LatestRaceInfo.GetLatestRaceResult()==null)
            {
                LatestRaceInfo.MakeLatestRaceResult();
            }
            RaceName.InnerText = LatestRaceInfo.GetGrandPrixName();
            RaceDate.InnerText = "Date :  " + LatestRaceInfo.GetGrandPrixDate();
            RepeaterLastRace.DataSource = LatestRaceInfo.GetLatestRaceResult();
            RepeaterLastRace.DataBind();
        }
    }
}