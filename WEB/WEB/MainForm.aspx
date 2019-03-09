<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="WEB.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Главная страница</title>

    <link rel="stylesheet" href="style.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:200px; margin-left:auto; margin-right:auto;">
           <asp:ListBox ID="listbox" runat="server" Width="200"></asp:ListBox>
           <asp:TextBox ID="textbox" runat="server" Width="200"></asp:TextBox>

            <div class="btns">
                <asp:Button runat="server" Text="Добавить" OnClick="Unnamed_Click"/>
                <asp:Button runat="server" Text="Редактировать" OnClick="Unnamed_Click1"/>
                <asp:Button runat="server" Text="Удалить" OnClick="Unnamed_Click2"/>
            </div>
        </div>
    </form>
</body>
</html>
