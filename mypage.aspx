<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mypage.aspx.cs" Inherits="loginweb.mypage" %>

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
            <asp:Button ID="btnadd" runat="server" Text="ADD" OnClick="btnadd_Click" />
            <asp:Button ID="btnchangepasswd" runat="server" Text="CHANGE PASSWORD" OnClick="btnchangepasswd_Click" />
            <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
