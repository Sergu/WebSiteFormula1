using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Standings_PersonalDriver : System.Web.UI.Page
{
    private static Driver curDriver;

    public string CurrentDriverNumber
    {
        get
        {
            string Number;
            Number = Request.QueryString["page"];
            return Number;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //curDriver = FindDriverInList(DriversStandings.GetCurrentDriverNumber());
            //if (curDriver != null)
            //{
            //    LabelPersonalDriverName.Text = curDriver.NameSurname;
            //    LabelPersonalDriverNationality.Text = curDriver.Nationality;
            //    LabelPersonalDriverNumber.Text = curDriver.PermanentNumber;
            //    LabelPersonalDriverDateOfBirth.Text = curDriver.DateOfBirth;
            //    LabelPersonalDriverPodiums.Text = curDriver.Wins;
            //    LabelPersonalDriverPoints.Text = curDriver.Points;
            //    LabelPersonalDriverTeam.Text = curDriver.Constructor;
            //    Car.Src = curDriver.ImageCar;
            //}
            LabelPersonalDriverNumber.Text = CurrentDriverNumber;
            foreach(Driver curDriver in DriversStandings.GetDriverStandings())
            {
                if (curDriver.PermanentNumber == CurrentDriverNumber)
                {
                    LabelPersonalDriverName.Text = curDriver.NameSurname;
                    LabelPersonalDriverNationality.Text = curDriver.Nationality;
                    LabelPersonalDriverNumber.Text = curDriver.PermanentNumber;
                    LabelPersonalDriverDateOfBirth.Text = curDriver.DateOfBirth;
                    LabelPersonalDriverPodiums.Text = curDriver.Wins;
                    LabelPersonalDriverPoints.Text = curDriver.Points;
                    LabelPersonalDriverTeam.Text = curDriver.Constructor;
                    carImg.Src = curDriver.ImageCar;
                    driverImg.Src = curDriver.ImageDriver;
                    helmetImg.Src = curDriver.ImageHelmet;
                    LabelMainDriverName.Text = curDriver.NameSurname;
                    LabelMainDriverNumber.Text = curDriver.PermanentNumber;
                }
            }
        }
    }

    //public static Driver FindDriverInList(string number)
    //{
    //    foreach (Driver driver in DriversStandings.GetDriverStandings())
    //    {
    //        if (driver.PermanentNumber == number)
    //        {
    //            return driver;
    //        }
    //    }
    //    return null;
    //}
}