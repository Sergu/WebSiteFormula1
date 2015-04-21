using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Standings_PersonalDriver : System.Web.UI.Page
{
    private static Driver curDriver;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            curDriver = FindDriverInList(DriversStandings.GetCurrentDriverNumber());
            if (curDriver !=null)
            {
                LabelPersonalDriverName.Text = curDriver.NameSurname;
                LabelPersonalDriverNationality.Text = curDriver.Nationality;
                LabelPersonalDriverNumber.Text = curDriver.PermanentNumber;
                LabelPersonalDriverDateOfBirth.Text = curDriver.DateOfBirth;
                LabelPersonalDriverPodiums.Text = curDriver.Wins;
                LabelPersonalDriverPoints.Text = curDriver.Points;
                LabelPersonalDriverTeam.Text = curDriver.Constructor;
                Car.Src = curDriver.ImageCar;
            }
        }
    }

    public static Driver FindDriverInList(string number)
    {
        foreach (Driver driver in DriversStandings.GetDriverStandings())
        {
            if (driver.PermanentNumber == number)
            {
                return driver;
            }
        }
        return null;
    }
}