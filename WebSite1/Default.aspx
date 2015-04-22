<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>


<asp:Content ID="StandingsContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center"><h2>The latest in Formula 1</h2></div>
    <div style="width:100%">
        <div class="mainPage-driverStandingsBlock" style="display:inline-block;vertical-align:top" runat="server">   
            <table style="text-align:left">
            <thead>
                <tr style="width:100%">
                   <h2>Driver Standings</h2>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="RepeaterDrivers" runat ="server">
                    <ItemTemplate>
                        <tr>
                            <td style="width:5%;color:gray;height:50px">
                                <%#Eval("Position") %>
                            </td>
                            <td style="width:30%;font-size:medium">
                                <%#Eval("NameSurname") %>
                            </td>
                            <td style="width:25%;color:gray">
                                <%#Eval("Constructor") %>
                            </td>
                            <td style="width:25%">
                                <img src="<%#Eval("ImageCar") %>" alt="---" width ="120px" height="30px"/>
                            </td>
                            <td style="width:15%; text-align:center">
                                <%#Eval("Points") %>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
            </table>
            <p><a  href="Standings/RaceResultsCurrent.aspx" style="text-align:center"> see full championship standings</a></p>
            <br /><br /><br /><br /><br />
            <table style="text-align:left">
            <thead>
                <tr style="width:100%">
                   <h2>Team Standings</h2>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="RepeaterTeamStandings" runat ="server">
                    <ItemTemplate>
                        <tr ">
                            <td style="width:5%;font-size:larger">
                                <%#Eval("Position") %>
                            </td>
                            <td style="width:80%;font-size:larger">
                                <%#Eval("Name") %>
                            </td>
                            <td style="width:15%; text-align:right;font-size:larger">
                                <%#Eval("Points") %>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
            </table>
            <p><a  href="Standings/RaceResultsCurrent.aspx" style="text-align:center"> See full standings</a></p>
        </div>
        <div ID="BlockNews" style="width:49%;max-height:100%;background-color:#e0f3f6;display:inline-block">
            <h2 style="margin:4%;font-family:'Times New Roman';text-align:center"> Some news from Formula 1 world</h2>
            <asp:Button ID="ButtonUrlAdd" runat="server" CssClass="deleteItem_Button" Text="Add" OnClick="ButtonUrlAdd_Click" />
            <asp:TextBox ID="TextBoxSite" Text="Site" Width="100px" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBoxUrl" Text="url" Width="100px" runat="server"></asp:TextBox> <br />

            <asp:Button ID="ButtonDelete" runat="server" CssClass="deleteItem_Button" OnClick="ButtonDelete_Click" Text="Delete" />
            <asp:DropDownList 
                ID="DropDownListRssUrls"
                runat="server"
                width="212px"                
                AutoPostBack="true" 
                OnSelectedIndexChanged="DropDownListRssUrls_SelectedIndexChanged">
                <asp:ListItem Text="http://www.f1-world.ru/" ></asp:ListItem>
                <asp:ListItem Text="http://www.f1news.ru/" ></asp:ListItem>
                <asp:ListItem Text="http://www.championat.com/"></asp:ListItem>
                <asp:ListItem Text="http://www.autofaq.com.ua/blog/formula-1/"></asp:ListItem>
            </asp:DropDownList><br /><br />

            <asp:Button ID="ButtonRefresh" runat="server" CssClass="refreshNews_Button" OnClick="ButtonRefresh_Click" Text="Refresh" />
            <div ID="NewsBlock" style="width:95%;margin:auto;height: 1400px;overflow:auto" runat="server">
            <asp:Repeater ID="RepeaterNews" runat="server">
                <ItemTemplate>
                    <div style="background-color:#d692ff;margin:4%;padding:4%;border-radius:5px">
                        <h3><%#Eval("Title") %></h3><hr />
                        <div><%#Eval("Description") %></div>
                        <div><h4>Date : <%#Eval("PublishDate") %></h4></div>
                        <div><h4><a class="news_link_a" href="<%#Eval("Link") %>">Read More...</a></h4></div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            </div>
        </div>
    </div>
<%--    <asp:LinkButton ID="DriverInfoButton" runat="server" OnClick="DriverInfoButton_Click">DriverInfo</asp:LinkButton>
    <asp:LinkButton ID="CurrentRaceButton" runat="server" OnClick="CurrentRaceButton_Click">Latest Result</asp:LinkButton>--%>
</asp:Content>

