﻿<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="DriverInfo.aspx.cs" Inherits="Standings_Standings" %>

<asp:Content ID="DriverInfoCOntent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <h1 style="color:gray;margin:4%">Formula 1 Drivers</h1>  
    <ul class="driverInfoUl">
        <asp:Repeater ID="RepeaterDriversGeneric" runat="server">
            <ItemTemplate>
                <li class="driverInfoLi" runat="server">
                    <div id="newblock" class="drivers_divBlock_in_li" style="text-align:center" runat="server" onclick="clickDiv()">
                        <div style="width:100%">
                            <img src="<%#Eval("ImageDriver") %>" width="100%" alt="Driver image" />
                        </div>
                        <div>
                        <div class="text_style_for_iherit">
                            <a href="PersonalDriver.aspx?page=<%#Eval("PermanentNumber") %>"><%#Eval("PermanentNumber") %></a>
                        </div>
                        <div style="color:inherit;font-size:x-large">
                            <%#Eval("NameSurname") %>
                        </div>  
                        <div class="text_style_for_iherit">
                            <%#Eval("Constructor") %>
                        </div>
                        </div>
                    </div>  
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
<%--    <div >

    </div>
    <asp:Button ID="button1" OnClick="button1_Click" Text="7" runat="server" />
    <asp:Button ID="button2" OnClick="button1_Click" Text="17" runat="server" />
    <asp:Button ID="button3" OnClick="button1_Click" Text="77" runat="server" />--%>
</asp:Content>
