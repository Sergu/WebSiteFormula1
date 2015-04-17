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
    private static List<Driver> Standings;

    public static IEnumerable<Driver> GetDriverStandings()
    {
        return Standings;
    }
    public static void MakeDriversStandings()
    {
        string rssFeedUrl = "http://ergast.com/api/f1/2015/driverStandings";
        try
        {
            Standings = new List<Driver>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(rssFeedUrl);

            int counter = 0;
            foreach (XmlElement xmlelement in xDoc.LastChild.FirstChild.FirstChild.ChildNodes)
            {
                counter = 0;
                Driver driver = new Driver();
                foreach (XmlAttribute driverStandingAttributes in xmlelement.Attributes)
                {
                    switch (counter)
                    {
                        case 0:
                            driver.Position = driverStandingAttributes.InnerText;
                            break;
                        case 2:
                            driver.Points = driverStandingAttributes.InnerText;
                            break;
                        case 3:
                            driver.Wins = driverStandingAttributes.InnerText;
                            break;
                        default:
                            break;
                    }
                    counter++;
                }
                counter = 0;
                foreach (XmlElement driverInfo in xmlelement.FirstChild.ChildNodes)
                {
                    switch (counter)
                    {
                        case 0:
                            driver.PermanentNumber = driverInfo.InnerText;
                            break;
                        case 1:
                            driver.GivenName = driverInfo.InnerText;
                            break;
                        case 2:
                            driver.FamilyName = driverInfo.InnerText;
                            break;
                        case 3:
                            driver.DateOfBirth = driverInfo.InnerText;
                            break;
                        case 4:
                            driver.Nationality = driverInfo.InnerText;
                            break;
                        default:
                            break;
                    }
                    counter++;
                }
                driver.Constructor = xmlelement.LastChild.InnerText;
                driver.ImageCar = GetImageCar(driver.Constructor);
                Standings.Add(driver);
                driver.NameSurname = driver.GivenName + " " + driver.FamilyName;
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
            case "MercedesGerman":
                return "../Images/teamCarMercedes.jpg";
            case "FerrariItalian":
                return "../Images/teamCarFerrari.jpg";
            case "WilliamsBritish":
                return "../Images/teamCarWilliams.jpg";
            case "Lotus F1British":
                return "../Images/teamCarLotus.jpg";
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
}