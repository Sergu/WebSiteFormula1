<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="PersonalDriver.aspx.cs" Inherits="Standings_PersonalDriver" %>


<asp:Content ID="PersonalDriverContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display:inline-block;width:50%;height:700px">       
        <div style="width:100%;height:500px">
            <img src="..//" alt="---" width="100%" height=500px; />
        </div>
        <div style="width:100%;height:200px;background-color:green;">

        </div>
    </div>
    <div style="display:inline-block;vertical-align:top;width:49%;height:700px;background-color:gray;" runat="server">
        <div style="width:90%;height:30%;margin:auto;background-color:yellow">
            <img id="HelmetImg" src="helmet" alt="helmet" style="width:100px ;height:100px;margin-top:12%;margin-left:5%" runat="server"/>
            <img id="Car" src="car" alt="car" style="width:300px;height:75px; margin-left:7%" runat="server"/>
        </div>
        <div style="width:90%;height:50%;margin-left:5%;margin-top:10%;background-color:red">
            <table style="text-align:left;height:80%;font-size:large;margin-left:3%">
                <tr>
                    <td class="driverInfoDefaultFields">
                        Name
                    </td>
                    <td>
                        <asp:Label ID="LabelPersonalDriverName" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Team
                    </td>
                    <td>
                        <asp:Label ID="LabelPersonalDriverTeam" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Podiums
                    </td>
                    <td>
                        <asp:Label ID="LabelPersonalDriverPodiums" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Points
                    </td>
                    <td>
                        <asp:Label ID="LabelPersonalDriverPoints" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Date of birth
                    </td>
                    <td>
                        <asp:Label ID="LabelPersonalDriverDateOfBirth" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Number
                    </td>
                    <td>
                        <asp:Label ID="LabelPersonalDriverNumber" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Nationality
                    </td>
                    <td>
                        <asp:Label ID="LabelPersonalDriverNationality" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
