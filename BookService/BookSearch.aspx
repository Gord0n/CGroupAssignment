<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookSearch.aspx.cs" Inherits="BookService.BookSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body style="height: 251px">
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Search For a Book Review: "></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Text="By Book ID"></asp:ListItem>
                        <asp:ListItem Text="By Book Name"></asp:ListItem>
                        <asp:ListItem Text="By reviewer name"></asp:ListItem>

                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="Search" />
                </td>
            </tr>
            
        </table>
    
        <asp:GridView ID="GridView1" runat="server" Width="100%">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
