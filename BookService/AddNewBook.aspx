<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewBook.aspx.cs" Inherits="BookService.AddNewBook" %>

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

                </td>
                <td>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Book Name:"></asp:Label>
                </td>
                
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Release Date:"></asp:Label>
                </td>
                
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="ISBN:"></asp:Label>
                </td>
                
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Add Book" OnClick="Button1_Click" />
                </td>
                
            </tr>
        </table>
    
            
        
    </div>
    </form>
</body>
</html>
