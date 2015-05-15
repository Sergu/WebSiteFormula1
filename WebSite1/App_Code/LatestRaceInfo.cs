using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

/// <summary>
/// Сводное описание для LatestRaceInfo
/// </summary>
public class LatestRaceInfo
{
    public class DriverRaceResult
    {
        public string Name {get;set;}
        public string Surname {get;set;}
        public string NameSurname {get;set;}
        public string Constructor {get;set;}
        public string Grid {get;set;}
        public string Laps {get;set;}
        public string Status {get;set;}
        public string Position {get;set;}
        public string Points {get;set;}
        public string Time {get;set;}
        public string FastestLap{get;set;}
    }

    private static string GrandPrixName { get; set; }
    private static string GrandPrixDate {get;set;}
    public static string GetGrandPrixName()
    {
        return GrandPrixName;
    }
    public static string GetGrandPrixDate()
    {
        return GrandPrixDate;
    }

    private static List<DriverRaceResult> LatestRaceResults;

    public static List<DriverRaceResult> GetLatestRaceResult()
    {
        return LatestRaceResults;
    }

    public static void SetLatestRaceResult(List<DriverRaceResult> latestRaceRes)
    {
        LatestRaceResults = latestRaceRes;
    }
	
    public static void MakeLatestRaceResult()
    {
        string lastRaceSource = "http://ergast.com/api/f1/current/last/results";
        LatestRaceResults = new List<DriverRaceResult>();
        try
        {

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(lastRaceSource);

            GrandPrixName = xDoc.LastChild.FirstChild.FirstChild.ChildNodes[0].InnerText;
            GrandPrixDate = xDoc.LastChild.FirstChild.FirstChild.ChildNodes[2].InnerText;

            foreach (XmlElement xmlelement in xDoc.LastChild.FirstChild.FirstChild.ChildNodes[4])
            {
                Team team = new Team();

                team.Position = xmlelement.Attributes[0].Value;
                team.Points = xmlelement.Attributes[2].Value;
                team.Points = xmlelement.Attributes[3].Value;

                team.Name = xmlelement.FirstChild.ChildNodes[0].InnerText;
                team.Nationality = xmlelement.FirstChild.ChildNodes[1].InnerText;

                DriverRaceResult driver = new DriverRaceResult();

                driver.Points = xmlelement.Attributes[3].Value;
                driver.Position = xmlelement.Attributes[1].Value;

                driver.Name = xmlelement.ChildNodes[0].ChildNodes[1].InnerText;
                driver.Surname = xmlelement.ChildNodes[0].ChildNodes[2].InnerText;
                driver.NameSurname = driver.Name + " " + driver.Surname; 
                driver.Constructor = xmlelement.ChildNodes[1].ChildNodes[0].InnerText;
                driver.Grid = xmlelement.ChildNodes[2].InnerText;
                driver.Laps = xmlelement.ChildNodes[3].InnerText;
                driver.Status = xmlelement.ChildNodes[4].FirstChild.InnerText;
                if (xmlelement.ChildNodes[5] == null)
                {
                    driver.Time = "";
                }
                else
                {
                    driver.Time = xmlelement.ChildNodes[5].InnerText;
                }
                if (xmlelement.ChildNodes[6] == null)
                {
                    driver.FastestLap = "";
                }
                else
                {
                    driver.FastestLap = xmlelement.ChildNodes[6].ChildNodes[0].InnerText;
                }
                LatestRaceResults.Add(driver);
            }
        }
        catch (Exception ex)
        {
            LatestRaceResults.Clear();
        }
    }
}