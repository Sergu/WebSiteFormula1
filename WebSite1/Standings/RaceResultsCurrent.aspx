<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="RaceResultsCurrent.aspx.cs" Inherits="Standings_RaceResultsCurrent" %>

<asp:Content ID="DriverInfoCOntent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="driver-info-content">
        <h1 style="text-align:left;font-family:'Times New Roman';margin:4%;color:gray">Driver Standings</h1>
        <div>
            <table style="text-align:left;width:100%">
                <tbody>
                    <asp:Repeater runat="server" ID="RepeaterDriverStandingsFull">
                        <ItemTemplate>
                        <tr style="height:80px">
                            <td style="width:5%;font-size:large;color:gray">
                                <%#Eval("Position") %>
                            </td>
                            <td style="width:15%;font-size:large;color:#444242">
                                <%#Eval("NameSurname") %>
                            </td>
                            <td style="width:5%;color:gray">
                                <%#Eval("PermanentNumber") %>
                            </td>
                            <td style="width:10%;color:gray">
                                <%#Eval("Nationality") %>
                            </td>
                            <td style="width:13%;color:gray">
                                <%#Eval("Constructor") %>
                            </td>
                            <td style="width:12%">
                                <img src="<%#Eval("ImageCar") %>" style="width:180px;height:45px" />
                            </td>
                            <td style="width:5%;text-align:center;color:#6b6666;font-family:'Times New Roman';font-size:medium">
                                <%#Eval("Points") %>
                            </td>
                        </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
