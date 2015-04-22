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

    private static string GetImageDriver(string number)
    {
        switch (number)
        {
            case "11":
                return "../ImagesDrivers/11.jpg";
            case "12":
                return "../ImagesDrivers/12.jpg";
            case "13":
                return "../ImagesDrivers/13.jpg";
            case "14":
                return "../ImagesDrivers/12.jpg";
            case "19":
                return "../ImagesDrivers/19.jpg";
            case "22":
                return "../ImagesDrivers/22.jpg";
            case "26":
                return "../ImagesDrivers/26.jpg";
            case "27":
                return "../ImagesDrivers/28.jpg";
            case "28":
                return "../ImagesDrivers/28.jpg";
            case "3":
                return "../ImagesDrivers/3.jpg";
            case "33":
                return "../ImagesDrivers/33.jpg";
            case "44":
                return "../ImagesDrivers/44.jpg";
            case "5":
                return "../ImagesDrivers/5.jpg";
            case "55":
                return "../ImagesDrivers/55.jpg";
            case "6":
                return "../ImagesDrivers/6.jpg";
            case "7":
                return "../ImagesDrivers/7.jpg";
            case "77":
                return "../ImagesDrivers/77.jpg";
            case "8":
                return "../ImagesDrivers/8.jpg";
            case "9":
                return "../ImagesDrivers/9.jpg";
            case "98":
                return "../ImagesDrivers/98.jpg";
            default:
                return "";

        }
    }
}