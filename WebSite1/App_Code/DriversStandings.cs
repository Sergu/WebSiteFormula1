using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

/// <summary>
/// Сводное описание для DriversStandings
/// </summary>
public class DriversStandings
{
    private static List<Driver> standingsDrivers;

    public static IEnumerable<Driver> GetDriverStandings()
    {
        return standingsDrivers;
    }
    public static void MakeDriversStandings()
    {
        string driverStandingsUrl = "http://ergast.com/api/f1/2015/driverStandings";
        try
        {
            standingsDrivers = new List<Driver>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(driverStandingsUrl);

            int counter = 0;
            foreach (XmlElement xmlelement in xDoc.LastChild.FirstChild.FirstChild.ChildNodes)
            {
                counter = 0;
                Driver driver = new Driver();
                driver.Position = xmlelement.Attributes[0].Value;
                driver.Points = xmlelement.Attributes[2].Value;
                driver.Wins = xmlelement.Attributes[3].Value;

                driver.PermanentNumber = xmlelement.FirstChild.ChildNodes[0].InnerText;
                driver.GivenName = xmlelement.FirstChild.ChildNodes[1].InnerText;
                driver.FamilyName = xmlelement.FirstChild.ChildNodes[2].InnerText;
                driver.DateOfBirth = xmlelement.FirstChild.ChildNodes[3].InnerText;
                driver.Nationality = xmlelement.FirstChild.ChildNodes[4].InnerText;

                driver.Constructor = xmlelement.LastChild.ChildNodes[0].InnerText;
                driver.ImageCar = GetImageCar(driver.Constructor);
                driver.NameSurname = driver.GivenName + " " + driver.FamilyName;
                standingsDrivers.Add(driver);
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    private static string GetImageCar(string str)
    {
        switch (str)
        {
            case "Mercedes":
                return "../Images/teamCarMercedes.jpg";
            case "Ferrari":
                return "../Images/teamCarFerrari.jpg";
            case "Williams":
                return "../Images/teamCarWilliams.jpg";
            case "Lotus F1":
                return "../Images/teamCarLotus.jpg";
            case "Sauber":
                return "../Images/teamCarSauber.jpg";
            case "Red Bull":
                return "../Images/teamCarRedBull.jpg";
            case "Force India":
                return "../Images/teamCarForceIndia.jpg";
            case "Toro Rosso":
                return "../Images/teamCarToroRosso.jpg";
            case "McLaren":
                return "../Images/teamCarMcLaren.jpg";
            default:
                return "../Images/default.jpg";
        }
    }
}