<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RNG.aspx.cs" Inherits="Task02_RNG_WebControls.RNG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="RangeMin" runat="server"></asp:TextBox>

        <asp:TextBox 
            ID="RangeMax" 
            runat="server">
        </asp:TextBox>


        <asp:Button ID="GenerateRandomNumber" runat="server" Text="Button" OnClick="GenerateRandomNumber_Click" />
        <asp:Label ID="Output" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
