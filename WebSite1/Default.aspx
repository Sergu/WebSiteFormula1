<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>


<asp:Content ID="StandingsContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;background-color:purple"><h2>The latest in Formula 1</h2></div>
    <div style="width:100%">
        <div class="mainPage-driverStandingsBlock" style="display:inline-block" runat="server">   
            <table style="text-align:left">
            <thead>
                <tr style="width:100%">
                   <h2>DriverStandings</h2>
                </tr>
            </thead>
            <tfoot>
                <tr>
                    <p><a  href="Standings/RaceResultsCurrent.aspx" style="text-align:center"> see full championship standings</a></p>
                </tr>
            </tfoot>
            <tbody>
                <asp:Repeater ID="RepeaterDrivers" runat ="server">
                    <ItemTemplate>
                        <tr">
                            <td style="width:3%">
                                <%#Eval("Position") %>
                            </td>
                            <td style="width:25%">
                                <%#Eval("NameSurname") %>
                            </td>
                            <td style="width:35%">
                                <%#Eval("Constructor") %>
                            </td>
                            <td style="width:25%">
                                <img src="<%#Eval("ImageCar") %>" alt="---" width ="120px" height="30px"/>
                            </td>
                            <td style="width:12%">
                                <%#Eval("Points") %>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
            </table>
        </div>
        <div  style="width:49%;height:100%;background-color:#63e47a;display:inline-block">
            <h3>news</h3>
        </div>
    </div>
<%--    <asp:LinkButton ID="DriverInfoButton" runat="server" OnClick="DriverInfoButton_Click">DriverInfo</asp:LinkButton>
    <asp:LinkButton ID="CurrentRaceButton" runat="server" OnClick="CurrentRaceButton_Click">Latest Result</asp:LinkButton>--%>
</asp:Content>

