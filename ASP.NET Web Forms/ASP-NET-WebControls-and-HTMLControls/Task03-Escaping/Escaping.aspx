<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Escaping.aspx.cs" Inherits="Task03_Escaping.Escaping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="Input" runat="server"></asp:TextBox>
        <asp:Button ID="SumbitInput" runat="server" Text="Button" OnClick="SumbitInput_Click" />
    </div>
    <div>
        <asp:TextBox Mode="Encode" ID="TB_Result" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Mode="Encode" ID="LBL_Result" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
