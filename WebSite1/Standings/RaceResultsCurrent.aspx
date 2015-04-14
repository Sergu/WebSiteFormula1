<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="RaceResultsCurrent.aspx.cs" Inherits="Standings_RaceResultsCurrent" %>

<asp:Content ID="DriverInfoCOntent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style ="width:340px; font-family:'Times New Roman'" runat="server">
        <asp:GridView ID="GridViewCurrentRace" runat="server" AutoGenerateColumns="false" ShowHeader="false">
            
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table cols="9">
                            <tr>
                                <td>
                                    <h3><%#Eval("Position") %></h3>
                                </td>
                                <td>
                                    <h3><%#Eval("Driver") %></h3>
                                </td>
                                <td>
                                    <h3><%#Eval("Team") %></h3>
                                </td>
                                <td>
                                    <h3><%#Eval("Laps") %></h3>
                                </td>
                                <td>
                                    <h3><%#Eval("Grid") %></h3>
                                </td>
                                <td>
                                    <h3><%#Eval("Time") %></h3>
                                </td>
                                <td>
                                    <h3><%#Eval("Status") %></h3>
                                </td>
                                <td>
                                    <h3><%#Eval("FastestLap") %></h3>
                                </td>
                                <td>
                                    <p><img src="<%#Eval("ImageCar") %>" alt="---" width ="160px" height="40px"/></p>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="ButtonBackCurrentRace" runat="server" Text="Back" OnClick="ButtonBackCurrentRace_Click"/>
    </div>
</asp:Content>
