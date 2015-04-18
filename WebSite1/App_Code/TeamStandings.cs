using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

/// <summary>
/// Сводное описание для TeamStandings
/// </summary>
public class TeamStandings
{
    private static List<Team> standingsTeam;

    public static List<Team> GetTeamStandings()
    {
        return standingsTeam;
    }

    public static void MakeTeamStandings()
    {
        string teamStandingsUrl = "http://ergast.com/api/f1/current/constructorStandings";
        standingsTeam = new List<Team>();
        try
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(teamStandingsUrl);

            var i = xDoc.LastChild.FirstChild.ChildNodes;

            foreach (XmlElement xmlelement in xDoc.LastChild.FirstChild.FirstChild.ChildNodes)
            {
                Team team = new Team();

                team.Position = xmlelement.Attributes[0].Value;
                team.Points = xmlelement.Attributes[2].Value;
                team.Wins = xmlelement.Attributes[3].Value;

                team.Name = xmlelement.FirstChild.ChildNodes[0].InnerText;
                team.Nationality = xmlelement.FirstChild.ChildNodes[1].InnerText;

                standingsTeam.Add(team);
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}