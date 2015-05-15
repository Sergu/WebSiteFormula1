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
                Cache.Insert("LatestRaceResults", LatestRaceInfo.GetLatestRaceResult(), null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);
            }
            else
            {
                if (GetLatestRaceInfoFromCache().Count != 0)
                {
                    LatestRaceInfo.SetLatestRaceResult(Cache["LatestRaceResults"] as List<LatestRaceInfo.DriverRaceResult>);
                }
                else
                {
                    LatestRaceInfo.MakeLatestRaceResult();
                    Cache.Insert("LatestRaceResults", LatestRaceInfo.GetLatestRaceResult(), null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);
                }
            }
            RaceName.InnerText = LatestRaceInfo.GetGrandPrixName();
            RaceDate.InnerText = "Date :  " + LatestRaceInfo.GetGrandPrixDate();
            RepeaterLastRace.DataSource = LatestRaceInfo.GetLatestRaceResult();
            RepeaterLastRace.DataBind();
        }
    }

    private List<LatestRaceInfo.DriverRaceResult> GetLatestRaceInfoFromCache()
    {
        var latestRaceRes = Cache["LatestRaceResults"] as List<LatestRaceInfo.DriverRaceResult>;
        return latestRaceRes;
    }
}