<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="WEB1.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title></title>
    <link rel="stylesheet" href="style.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="list1" runat="server">
            <asp:ListBox SelectionMode="Multiple" Width="200" ID="listbox1" runat="server">
                <asp:ListItem Text="item1"></asp:ListItem>
                <asp:ListItem Text="item2"></asp:ListItem>
                <asp:ListItem Text="item3"></asp:ListItem>
                <asp:ListItem Text="item4"></asp:ListItem>
                <asp:ListItem Text="item5"></asp:ListItem>
                <asp:ListItem Text="item6"></asp:ListItem>
            </asp:ListBox>
        </div>
        <div class="list2" runat="server">
            <asp:ListBox SelectionMode="Multiple" Width="200" ID="listbox2" runat="server"></asp:ListBox>
        </div>
        <div class="btns" runat="server">
            <asp:Button Text="В корзину" runat="server" OnClick="Unnamed_Click"/>
            <asp:Button Text="Удалить с корзины" runat="server" onClick="Unnamed_Click1"/>
            <asp:Button Text="Все в корзину" runat="server" OnClick="Unnamed_Click2"/>
            <asp:Button Text="Удалить все с корзины" runat="server" OnClick="Unnamed_Click3"/>
        </div>
    </form>
</body>
</html>
