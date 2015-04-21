using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;


public partial class Standings_Standings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (DriversStandings.GetDriverStandings() == null)
            {
                DriversStandings.MakeDriversStandings();
            }
        }
        RepeaterDriversGeneric.DataSource = DriversStandings.GetDriverStandings();
        RepeaterDriversGeneric.DataBind();       
    }

    public void asd(string numb)
    {
        string s = numb;
        if (s != null)
        {

        }
    }
    protected void DriverBlock_DataBinding(object sender, EventArgs e)
    {
        int i=0;
        if (i==null)
        {
            i = 3;
        }
        else
        {
            i = 5;
        }
    }
    protected void RepeaterDriversGeneric_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        int i = 0;
        if (i == null)
        {
            i = 3;
        }
        else
        {
            i = 5;
        }
    }
    protected void button1_Click(object sender, EventArgs e)
    {
        int i = 0;
        if (i == null)
        {
            i = 3;
        }
        else
        {
            i = 5;
        }
    }
}