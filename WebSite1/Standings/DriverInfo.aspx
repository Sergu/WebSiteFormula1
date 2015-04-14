<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="DriverInfo.aspx.cs" Inherits="Standings_Standings" %>

<asp:Content ID="DriverInfoCOntent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style ="width:340px; font-family:'Times New Roman'" runat="server">
        <asp:GridView ID="GridViewDriverInfo" runat="server" CssClass="GridView" GridLines="Both" AutoGenerateColumns="false" ShowHeader="false">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td>
                                    <h3><%#Eval("GivenName") %></h3>
                                </td>
                                <td>
                                    <h3><%#Eval("FamilyName") %></h3>
                                </td>
                                <td>
                                    <h3><%#Eval("PermanentNumber") %></h3>
                                </td>
                                <td>
                                    <h3><%#Eval("DateOfBirth") %></h3>
                                </td>
                                <td>
                                    <h3><%#Eval("Nationality") %></h3>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="ButtonBackDriverInfo" runat="server" Text="Back" OnClick="ButtonBackDriverInfo_Click" />
    </div>
</asp:Content>
