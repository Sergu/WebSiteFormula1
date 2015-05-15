using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

/// <summary>
/// Сводное описание для GrandPrixList
/// </summary>
public class GrandPrixList
{
    private static List<GrandPrix> scheduleList;

	public static string Formula1Season;
    public static void MakeGrandPrixList()
    {
        string Url = "http://ergast.com/api/f1/current";
        try
        {
            scheduleList = new List<GrandPrix>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Url);

            Formula1Season = xDoc.LastChild.FirstChild.Attributes[0].Value;

            foreach(XmlElement race in xDoc.LastChild.FirstChild.ChildNodes)
            {
                GrandPrix grandPrix = new GrandPrix();
                grandPrix.RaceName = race.ChildNodes[0].InnerText;
                grandPrix.Date = race.ChildNodes[2].InnerText;
                grandPrix.Time = race.ChildNodes[3].InnerText;
                grandPrix.Round = race.Attributes[1].InnerText;
                grandPrix.Url = race.Attributes[2].InnerText;
                scheduleList.Add(grandPrix);
            }
        }
        catch (Exception ex)
        {
            scheduleList.Clear();
        }
    }
    public static List<GrandPrix> GetScheduleList()
    {
        return scheduleList;
    }
    public static void SetScheduleList(List<GrandPrix> grandPrixList)
    {
        scheduleList = grandPrixList;
    }
}