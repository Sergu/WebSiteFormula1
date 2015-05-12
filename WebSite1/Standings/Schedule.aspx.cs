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
            }
            Season.InnerText = "Season :  " + GrandPrixList.Formula1Season;
            RepeaterSchedules.DataSource = GrandPrixList.GetScheduleList();
            RepeaterSchedules.DataBind();
        }
    }
}