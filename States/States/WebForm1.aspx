<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="States.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Регистрационные данные"></asp:Label> <br/>
            <asp:TextBox runat="server" ID="username"></asp:TextBox> <br/>
            <asp:TextBox runat="server" ID="passw"></asp:TextBox> <br/>
            <asp:TextBox runat="server" ID="age"></asp:TextBox> <br/>
            <asp:Button runat="server" Text="СОХРАНИТЬ" OnClick="Unnamed_Click"/>
            <asp:Button runat="server" Text="ВОССТАНОВИТЬ" OnClick ="Unnamed_Click1"/>
        </div>
    </form>
</body>
</html>
