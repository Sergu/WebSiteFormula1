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
            CurrentRaceList();
        }
    }

    private void CurrentRaceList()
    {
        string rssFeedUrl = "http://ergast.com/api/f1/current/last/results";
        List<CurrentRaceInfoPilot> currentRace = new List<CurrentRaceInfoPilot>();
        try
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(rssFeedUrl);

            int counter = 0;
            int position = 1;
            foreach (XmlElement xmlelements in xDoc.LastChild.FirstChild.FirstChild.LastChild)
            {
                counter = 0;
                CurrentRaceInfoPilot pilot = new CurrentRaceInfoPilot();
                foreach (XmlElement xmlInnner in xmlelements)
                {
                    switch (counter)
                    {
                        case 0:
                            pilot.Driver =  xmlInnner.InnerText;
                            break;
                        case 1:
                            pilot.Team = xmlInnner.InnerText;
                            pilot.ImageCar = GetImageCar(pilot.Team);
                            break;
                        case 2:
                            pilot.Grid = xmlInnner.InnerText;
                            break;
                        case 3:
                            pilot.Laps = xmlInnner.InnerText;
                            break;
                        case 4:
                            pilot.Status = xmlInnner.InnerText;
                            break;
                        case 5:
                            pilot.Time = xmlInnner.InnerText;
                            break;
                        case 6:
                            pilot.FastestLap = xmlInnner.InnerText;
                            break;
                        default:
                            break;
                    }
                    counter++;
                }
                pilot.Position = Convert.ToString(position);
                position++;
                currentRace.Add(pilot);
            }
            GridViewCurrentRace.DataSource = currentRace;
            GridViewCurrentRace.DataBind();
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    //private string GetName(string innerText)
    //{
    //    string name = null;
    //    int counter = innerText.Length - 1;
    //    bool start = true;
    //}
    private string GetImageCar(string str)
    {
        switch(str)
        {
            case "MercedesGerman":
                return "../Images/teamCarMercedes.jpg";
            case "FerrariItalian":
                return "../Images/teamCarFerrari.jpg";
            case "WilliamsBritish":
                return "../Images/teamCarWilliams.jpg";
            case "Lotus F1British":
                return "../Images/default.jpg";
            case "SauberSwiss":
                return "../Images/teamCarSauber.jpg";
            case "Red BullAustrian":
                return "../Images/teamCarRedBull.jpg";
            case "Force IndiaIndian":
                return "../Images/teamCarForceIndia.jpg";
            case "Toro RossoItalian":
                return "../Images/teamCarToroRosso.jpg";
            case "McLarenBritish":
                return "../Images/teamCarMcLaren.jpg";
            default:
                return "../Images/default.jpg";
        }
    }

    protected void ButtonBackCurrentRace_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
}