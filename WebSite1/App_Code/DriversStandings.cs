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
    private static string CurrentDriverNumber { get; set; }
    public static void SetCurrentDriverNumber(string number)
    {
        CurrentDriverNumber = number;
    }

    public static IEnumerable<Driver> GetFirstTenDrivers()
    {
        List<Driver> topTenList = new List<Driver>();
        int count = 0;
        while (count < 10) 
        {
            topTenList.Add(standingsDrivers[count]);
            count++;
        }
        return topTenList;
    }

    public static string GetCurrentDriverNumber()
    {
        return CurrentDriverNumber;
    }
    public static IEnumerable<Driver> GetDriverStandings()
    {
        return standingsDrivers;
    }
    //public static IEnumerable<Driver> GetBest10DriverStandings()
    //{
        
    //}
    public static void MakeDriversStandings()
    {
        string driverStandingsUrl = "http://ergast.com/api/f1/2015/driverStandings";
        try
        {
            standingsDrivers = new List<Driver>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(driverStandingsUrl);

            foreach (XmlElement xmlelement in xDoc.LastChild.FirstChild.FirstChild.ChildNodes)
            {
                Driver driver = new Driver();
                driver.Position = xmlelement.Attributes[0].Value;
                driver.Points = xmlelement.Attributes[2].Value;
                driver.Wins = xmlelement.Attributes[3].Value;

                driver.PermanentNumber = xmlelement.FirstChild.ChildNodes[0].InnerText;
                driver.ImageDriver = GetImageDriver(driver.PermanentNumber);
                driver.GivenName = xmlelement.FirstChild.ChildNodes[1].InnerText;
                driver.FamilyName = xmlelement.FirstChild.ChildNodes[2].InnerText;
                driver.DateOfBirth = xmlelement.FirstChild.ChildNodes[3].InnerText;
                driver.Nationality = xmlelement.FirstChild.ChildNodes[4].InnerText;

                driver.Constructor = xmlelement.LastChild.ChildNodes[0].InnerText;
                driver.ImageCar = GetImageCar(driver.Constructor);
                driver.NameSurname = driver.GivenName + " " + driver.FamilyName;
                if (driver.PermanentNumber != "20")
                {
                    standingsDrivers.Add(driver);
                }
            }
        }
        catch (Exception ex)
        {
            standingsDrivers.Clear();
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

    private static string GetImageDriver(string number)
    {
        string pathImage = "../ImagesDrivers/";
        string fullPath;
        fullPath = String.Concat(pathImage, Convert.ToString(number), ".jpg");

        return fullPath;
    }
}   