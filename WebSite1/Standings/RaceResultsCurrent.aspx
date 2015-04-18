<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="RaceResultsCurrent.aspx.cs" Inherits="Standings_RaceResultsCurrent" %>

<asp:Content ID="DriverInfoCOntent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="driver-info-content">
        <h2 style="text-align:center;font-family:'Times New Roman';font-size:large">2015 Driver Standings</h2>
        <div>
            <table style="text-align:left;width:100%">
                <tbody>
                    <asp:Repeater runat="server" ID="RepeaterDriverStandingsFull">
                        <ItemTemplate>
                        <tr style="height:80px">
                            <td style="width:5%">
                                <%#Eval("Position") %>
                            </td>
                            <td style="width:15%">
                                <%#Eval("NameSurname") %>
                            </td>
                            <td style="width:5%">
                                <%#Eval("PermanentNumber") %>
                            </td>
                            <td style="width:10%">
                                <%#Eval("Nationality") %>
                            </td>
                            <td style="width:13%">
                                <%#Eval("Constructor") %>
                            </td>
                            <td style="width:12%">
                                <img src="<%#Eval("ImageCar") %>" style="width:180px;height:45px" />
                            </td>
                            <td style="width:5%;text-align:center">
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
