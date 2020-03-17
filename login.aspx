<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="loginweb.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            <asp:Button ID="btnlogin" runat="server" Text="LOGIN" OnClick="btnlogin_Click" />
            <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>

        </div>

      
    </form>
</body>
</html>
