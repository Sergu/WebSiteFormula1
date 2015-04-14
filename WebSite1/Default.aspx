<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinkButton ID="DriverInfoButton" runat="server" OnClick="DriverInfoButton_Click">DriverInfo</asp:LinkButton>
    <asp:LinkButton ID="CurrentRaceButton" runat="server" OnClick="CurrentRaceButton_Click">Latest Result</asp:LinkButton>
</asp:Content>

