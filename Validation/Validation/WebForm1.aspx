<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Validation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link type="text/css" rel="stylesheet" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ValidationSummary ID="VS" runat="server" ShowModelStateErrors="true" />

        <asp:TextBox runat="server" ID="t1" CssClass="t1">10</asp:TextBox> <br/>
        <asp:TextBox runat="server" ID="t2">2</asp:TextBox> <br/>
        <asp:Button runat="server" ID="btn" Text="Разделить" OnClick="btn_Click"/>
        <asp:Label runat="server" ID="lbl">qweqwe</asp:Label>
    </form>
</body>
</html>
