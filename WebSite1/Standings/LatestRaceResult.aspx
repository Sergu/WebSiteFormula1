<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="LatestRaceResult.aspx.cs" Inherits="Standings_LatestRaceResult" %>

<asp:Content ID="LatestRaceResultContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:4%;border-bottom:solid;border-bottom-color:purple">
        <h1 id="RaceName" runat="server"></h1>
        <h4 id="RaceDate" runat="server"></h4>
    </div>
    <div style="margin-left:4%">
    <table style="text-align:left">
        <thead>
            <tr style="height:60px">
                <td style="width:5%;font-size:x-large; font-family:David;color:#51125e">
                    Pos
                </td>
                <td style="width:15%;font-size:x-large; font-family:David;color:#51125e">
                    Name
                </td>
                <td style="width:5%;font-size:x-large; font-family:David;color:#51125e">
                    Grid
                </td>
                <td style="width:10%;font-size:x-large; font-family:David;color:#51125e">
                    Team
                </td>
                <td style="width:5%;font-size:x-large; font-family:David;color:#51125e">
                    Laps
                </td>
                <td style="width:10%;font-size:x-large; font-family:David;color:#51125e">
                    Status
                </td>
                <td style="width:10%;font-size:x-large; font-family:David;color:#51125e">
                    Fastest Lap
                </td>
                <td style="width:12s%;font-size:x-large; font-family:David;color:#51125e">
                    Time
                </td>
                <td style="width:8%;font-size:x-large; font-family:David;color:#51125e">
                    Points
                </td>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterLastRace" runat="server">
                <ItemTemplate>
                <tr style="height:30px">
                    <td style="width:5%;color:black;">
                        <%#Eval("Position") %>
                    </td>
                    <td style="width:15%;color:black;font-size:larger">
                        <%#Eval("NameSurname") %>
                    </td>
                    <td style="width:5%;color:gray">
                        <%#Eval("Grid") %>
                    </td>
                    <td style="width:10%;font-size:larger;color:#4b4343">
                        <%#Eval("Constructor") %>
                    </td>
                    <td style="width:5%;color:gray">
                        <%#Eval("Laps") %>
                    </td>
                    <td style="width:10%;font-family:Century">
                        <%#Eval("Status") %>
                    </td>
                    <td style="width:10%">
                        <%#Eval("FastestLap") %>
                    </td>
                    <td style="width:12%">
                        <%#Eval("Time") %>
                    </td>
                    <td style="width:8%;font-size:larger;color:black">
                        <%#Eval("Points") %>
                    </td>
                </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    </div>
</asp:Content>
