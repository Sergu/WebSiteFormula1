<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LinkTable.ascx.cs" Inherits="LinkTable" %>

<table style="width:100%" cellpadding="8" border="5">
    <tr>
        <td>
            <p style="margin: 8px">
                <asp:Label ID="lblTitle"
                    runat="server">[Вставьте заголовок]</asp:Label>
            </p>
        </td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="gridLinkList" runat="server" AutoGenerateColumns="false"
                ShowHeader="false" GridLines="Both">               
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <img height="23" src="exclaim.gif" alt="Menu Item" style="vertical-align: middle" />
                            <asp:HyperLink runat="server" ID="link"
                                NavigateUrl='<%# Eval("Url") %>'                                
                                Text='<%# Eval("Text") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>
