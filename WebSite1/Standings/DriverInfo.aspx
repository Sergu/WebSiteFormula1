<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="DriverInfo.aspx.cs" Inherits="Standings_Standings" %>

<asp:Content ID="DriverInfoCOntent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <h1 style="color:gray;margin:4%">Formula 1 Drivers</h1>  
    <ul class="driverInfoUl">
        <asp:Repeater ID="RepeaterDriversGeneric" runat="server">
            <ItemTemplate>
                <li class="driverInfoLi">
                    <div class="drivers_divBlock_in_li" style="text-align:center" runat="server" onclick="">
                        <div class="text_style_for_iherit">
                            <%#Eval("PermanentNumber") %>
                        </div>
                        <div style="color:inherit">
                            <%#Eval("NameSurname") %>
                        </div>
                        <div class="text_style_for_iherit">
                            <%#Eval("Constructor") %>
                        </div>
                    </div>    
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</asp:Content>
