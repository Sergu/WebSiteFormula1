<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="PersonalDriver.aspx.cs" Inherits="Standings_PersonalDriver" %>


<asp:Content ID="PersonalDriverContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<h1 style="color:gray;margin:4%">Driver information</h1>--%>
    <div style="display:inline-block;width:45%;height:750px">       
        <div style="width:100%;height:500px;">
            <img id="driverImg" src="..//" alt="---" style ="width:100%;height:500px" runat="server" />
        </div>
        <div style="width:100%;height:150px;background-color:white">
            <h1 style="margin-left:7%;font-size:xx-large;color:gray"><asp:Label ID="LabelMainDriverNumber" runat="server"></asp:Label></h1>
            <h1 style="margin-left:7%;font-size:xx-large"><asp:Label ID="LabelMainDriverName" runat="server"></asp:Label></h1>
        </div>
    </div>
    <div style="display:inline-block;vertical-align:top;width:49%;height:700px;background-color:white;margin-left:3%" runat="server">
        <div style="width:90%;height:30%;margin:auto;background-color:white;border-bottom:solid;border-bottom-color:gray">
            <img id="helmetImg" src="helmet" alt="helmet" style="width:175px ;height:126px;margin-top:8%;margin-left:2%" runat="server"/>
            <img id="carImg" src="car" alt="car" style="width:300px;height:70px; margin-left:4%" runat="server"/>
        </div>
        <div style="width:90%;height:50%;margin-left:5%;margin-top:10%;background-color:white">
            <table style="text-align:left;height:80%;width:90%;font-size:large;margin-left:3%">
                <tr>
                    <td class="driverInfoDefaultFields">
                        Name
                    </td>
                    <td class="driverInfoDynamicFields">
                        <asp:Label ID="LabelPersonalDriverName" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Team
                    </td>
                    <td class="driverInfoDynamicFields">
                        <asp:Label ID="LabelPersonalDriverTeam" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Podiums
                    </td>
                    <td class="driverInfoDynamicFields">
                        <asp:Label ID="LabelPersonalDriverPodiums" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Points
                    </td>
                    <td class="driverInfoDynamicFields">
                        <asp:Label ID="LabelPersonalDriverPoints" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Date of birth
                    </td>
                    <td class="driverInfoDynamicFields">
                        <asp:Label ID="LabelPersonalDriverDateOfBirth" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Number                      
                    </td>
                    <td class="driverInfoDynamicFields">
                        <asp:Label ID="LabelPersonalDriverNumber" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Nationality
                    </td>
                    <td class="driverInfoDynamicFields">
                        <asp:Label ID="LabelPersonalDriverNationality" runat="server" BorderStyle="None">

                        </asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
