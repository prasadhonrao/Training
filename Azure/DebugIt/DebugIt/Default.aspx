<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DebugIt.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Enter First Number <asp:TextBox ID="FirstNumber" runat="server"></asp:TextBox>
        <br />
        Enter Second Number <asp:TextBox ID="SecondNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="Add" />
&nbsp;<asp:Label ID="ResultLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
