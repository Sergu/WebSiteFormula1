<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="Schedule.aspx.cs" Inherits="Standings_Schedule" %>


<asp:Content ID="ScheduleContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:4%;border-bottom:solid;border-bottom-color:purple">
        <h1>Schedule</h1>
        <h3 id="Season" runat="server"></h3>
    </div>
    <div style="margin-left:4%">
    <table style="text-align:left">
        <thead>
            <tr style="height:60px">
                <td style="width:5%;font-size:x-large; font-family:David;color:#51125e">
                    Round
                </td>
                <td style="width:15%;font-size:x-large; font-family:David;color:#51125e">
                    Race
                </td>
                <td style="width:10%;font-size:x-large; font-family:David;color:#51125e">
                    Date
                </td>
                <td style="width:10%;font-size:x-large; font-family:David;color:#51125e">
                    Time
                </td>
                <td style="width:10%;font-size:x-large; font-family:David;color:#51125e">
                    Url
                </td>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepeaterSchedules" runat="server">
                <ItemTemplate>
                <tr style="height:30px">
                    <td style="width:5%;color:black;">
                        <%#Eval("Round") %>
                    </td>
                    <td style="width:15%;color:black;font-size:larger">
                        <%#Eval("RaceName") %>
                    </td>
                    <td style="width:10%;color:gray">
                        <%#Eval("Date") %>
                    </td>
                    <td style="width:10%;font-size:larger;color:#4b4343">
                        <%#Eval("Time") %>
                    </td>
                    <td style="width:10%;color:gray">
                        <a href="<%#Eval("Url") %>" style="color:#a94dfb">Race info...</a>
                    </td>
                </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    </div>
</asp:Content>