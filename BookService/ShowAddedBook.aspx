<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAddedBook.aspx.cs" Inherits="BookService.ShowAddedBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Book Name:"></asp:Label>
                </td>
                
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Release Date:"></asp:Label>
                </td>
                
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="ISBN:"></asp:Label>
                </td>
                
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Book ID:"></asp:Label>
                 </td>
                
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                 </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" Text="Return To The main page" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
