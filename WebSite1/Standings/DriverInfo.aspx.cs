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

    //private void MakeDriverList()
    //{
    //    string url = "http://ergast.com/api/f1/2015/drivers";
    //    List<DriverInfoPilot> pilotsInfoList = new List<DriverInfoPilot>();
    //    try
    //    {
    //        XmlDocument xDoc = new XmlDocument();
    //        xDoc.Load(url);

    //        var i = xDoc.LastChild.FirstChild.ChildNodes;
    //        int counter = 0;
    //        foreach (XmlElement xmlelement in xDoc.LastChild.FirstChild.ChildNodes)
    //        {
    //            counter = 0;
    //            DriverInfoPilot driver = new DriverInfoPilot();
    //            foreach (XmlElement xmlInnner in xmlelement)
    //            {
    //                switch (counter)
    //                {
    //                    case 0:
    //                        driver.PermanentNumber = xmlInnner.InnerText;
    //                        break;
    //                    case 1:
    //                        driver.GivenName = xmlInnner.InnerText;
    //                        break;
    //                    case 2:
    //                        driver.FamilyName = xmlInnner.InnerText;
    //                        break;
    //                    case 3:
    //                        driver.DateOfBirth = xmlInnner.InnerText;
    //                        break;
    //                    case 4:
    //                        driver.Nationality = xmlInnner.InnerText;
    //                        break;
    //                    default:
    //                        break;
    //                }
    //                counter++;
    //            }
    //            pilotsInfoList.Add(driver);
    //        }
    //        GridViewDriverInfo.DataSource = pilotsInfoList;
    //        GridViewDriverInfo.DataBind();
    //    }
    //    catch (Exception ex)
    //    {
    //        throw;
    //    }
    //}
    //protected void ButtonBackDriverInfo_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("~/Default.aspx");
    //}
}