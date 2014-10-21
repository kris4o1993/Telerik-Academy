<%@ Page Language="C#" UnobtrusiveValidationMode="None"  AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="Task04_Students.Students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LBL_FirstName" runat="server" Text="First Name" />
        <asp:TextBox ID="TB_FirstName" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_FirstName" ErrorMessage="This field is required" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <br />
    <div>
        <asp:Label ID="LBL_LastName" runat="server" Text="Last Name" />
        <asp:TextBox ID="TB_LastName" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_LastName" ErrorMessage="This field is required" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <br />
    <div>
        <asp:Label ID="LBL_FacNumber" runat="server" Text="Faculty Number" />
        <asp:TextBox ID="TB_FacNumber" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_FacNumber" ErrorMessage="This field is required" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <br />
    <div>
        <asp:Label ID="LBL_University" runat="server" Text="University" />
        <asp:DropDownList ID="DDL_University" runat="server">
            <asp:ListItem Value="UNWE">UNWE</asp:ListItem>
            <asp:ListItem Value="SU">SU</asp:ListItem>
            <asp:ListItem Value="TU">TU</asp:ListItem>
        </asp:DropDownList>
    </div>
    <br />
    <div>
        <asp:Label ID="LBL_Courses" runat="server" Text="Courses" />
        <asp:ListBox ID="LBOX_Courses" runat="server" SelectionMode="Multiple">
            <asp:ListItem Value="Mathematics">Mathematics</asp:ListItem>
            <asp:ListItem Value="C# Fundamentals">C# Fundamentals</asp:ListItem>
            <asp:ListItem Value="HTML and CSS">HTML and CSS</asp:ListItem>
            <asp:ListItem Value="JavaScript">JavaScript</asp:ListItem>
            <asp:ListItem Value="Physics">Physics</asp:ListItem>
            <asp:ListItem Value="Networking">Networking</asp:ListItem>
        </asp:ListBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="LBOX_Courses" ErrorMessage="This field is required" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <br />
    <div>
        <asp:Button ID="SumbitInput" runat="server" Text="Button" OnClick="SumbitInput_Click" />
    </div>
    <br />
    <br />
    <br />
    <div>
        <asp:Panel runat="server" ID="PanelResults"/>
    </div>
    </form>
</body>
</html>
