<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="PersonalDriver.aspx.cs" Inherits="Standings_PersonalDriver" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display:inline-block;width:50%;height:700px">       
        <div style="width:100%;height:500px">
            <img src="..//" alt="---" width="100%" height=500px; />
        </div>
        <div style="width:100%;height:200px;background-color:green;">

        </div>
    </div>
    <div style="display:inline-block;vertical-align:top;width:49%;height:700px;background-color:gray;">
        <div style="width:90%;height:30%;margin:auto;background-color:yellow">
            <img src="helmet" alt="helmet" style="width:100px ;height:100px;margin-top:12%;margin-left:5%"  />
            <img src="car" alt="car" style="width:300px;height:75px; margin-left:7%" />
        </div>
        <div style="width:90%;height:50%;margin-left:5%;margin-top:10%;background-color:red">
            <table style="text-align:left;height:80%;font-size:large;margin-left:3%">
                <tr>
                    <td class="driverInfoDefaultFields">
                        Name
                    </td>
                    <td>
                        
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Team
                    </td>
                    <td>

                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Podiums
                    </td>
                    <td>
                        
                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Points
                    </td>
                    <td>

                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Date of birth
                    </td>
                    <td>

                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Number
                    </td>
                    <td>

                    </td>
                </tr>
                <tr>
                    <td class="driverInfoDefaultFields">
                        Nationality
                    </td>
                    <td>

                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
