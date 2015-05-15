using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Standings_Schedule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if(GrandPrixList.GetScheduleList() == null)
            {
                GrandPrixList.MakeGrandPrixList();
                Cache.Insert("GrandPrixList", GrandPrixList.GetScheduleList(), null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);
            }
            else
            {
                if (GetGrandPrixListFromCache().Count != 0)
                {
                    GrandPrixList.SetScheduleList(Cache["GrandPrixList"] as List<GrandPrix>);
                }
                else
                {
                    GrandPrixList.MakeGrandPrixList();
                    Cache.Insert("GrandPrixList", GrandPrixList.GetScheduleList(), null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);
                }
            }
            Season.InnerText = "Season :  " + GrandPrixList.Formula1Season;
            RepeaterSchedules.DataSource = GrandPrixList.GetScheduleList();
            RepeaterSchedules.DataBind();
        }
    }

    private List<GrandPrix> GetGrandPrixListFromCache()
    {
        var grandPrixList = Cache["GrandPrixList"] as List<GrandPrix>;
        return grandPrixList;
    }
}