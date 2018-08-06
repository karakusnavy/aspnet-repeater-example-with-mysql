<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="RepeaterApplication.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
<asp:Repeater ID="rptAdi" OnItemCommand="rptAdi_ItemCommand" runat="server">
    <ItemTemplate>
        <asp:Label runat="server" ID="text"><%#Eval("name") %></asp:Label><!-- "name" is database column name (MYSQL) -->
    </ItemTemplate>
    </asp:Repeater>
    </form>
</body>
</html>
