<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Task06_HyperCalculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="PAN_Calculator" runat="server">
            <asp:Table ID="TAB_CalculatorBody" HorizontalAlign="Center" BorderWidth="2" runat="server" Height="331px" Width="550px">
                <asp:TableRow HorizontalAlign="Center" BorderWidth="2">
                    <asp:TableCell ColumnSpan="4">
                        <asp:TextBox Enabled="false" Width="100%" Height="100%" ID="Output" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow HorizontalAlign="Center" BorderWidth="2">
                    <asp:TableCell ColumnSpan="4">
                        <asp:Label ID="LBL_Alerts" runat="server" Text="HyperCalculator!" Font-Bold="true"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow HorizontalAlign="Center" BorderWidth="2">
                    <asp:TableCell>
                        <asp:Button ID="BTN_1" OnClick="BTN_1_Click" Width="100%" Height="100%" runat="server" Text="1" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="BTN_2" OnClick="BTN_2_Click" Width="100%" Height="100%" runat="server" Text="2" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="BTN_3" OnClick="BTN_3_Click" Width="100%" Height="100%" runat="server" Text="3" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="BTN_Plus" OnClick="BTN_Plus_Click" Width="100%" Height="100%" runat="server" Text="+" />
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow HorizontalAlign="Center" BorderWidth="2">
                    <asp:TableCell>
                        <asp:Button ID="BTN_4" OnClick="BTN_4_Click"  Width="100%" Height="100%" runat="server" Text="4" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="BTN_5" OnClick="BTN_5_Click" Width="100%" Height="100%" runat="server" Text="5" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="BTN_6" OnClick="BTN_6_Click" Width="100%" Height="100%" runat="server" Text="6" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="BTN_Minus" OnClick="BTN_Minus_Click" Width="100%" Height="100%" runat="server" Text="-" />
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow HorizontalAlign="Center" BorderWidth="2">
                    <asp:TableCell>
                        <asp:Button ID="BTN_7" OnClick="BTN_7_Click" Width="100%" Height="100%" runat="server" Text="7" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="BTN_8" OnClick="BTN_8_Click" Width="100%" Height="100%" runat="server" Text="8" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="BTN_9" OnClick="BTN_9_Click" Width="100%" Height="100%" runat="server" Text="9" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="BTN_Multiply" OnClick="BTN_Multiply_Click" Width="100%" Height="100%" runat="server" Text="x" />
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow HorizontalAlign="Center" BorderWidth="2">
                    <asp:TableCell>
                        <asp:Button ID="BTN_Clear" OnClick="BTN_Clear_Click" Width="100%" Height="100%" runat="server" Text="C" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="BTN_0" OnClick="BTN_0_Click" Width="100%" Height="100%" runat="server" Text="0" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="BTN_Divide" OnClick="BTN_Divide_Click" Width="100%" Height="100%" runat="server" Text="/" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="BTN_Modulus" OnClick="BTN_Modulus_Click" Width="100%" Height="100%" runat="server" Text="%" />
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow HorizontalAlign="Center" BorderWidth="2">
                    <asp:TableCell ColumnSpan="4" >
                       <asp:Button ID="BTN_Equals" OnClick="BTN_Equals_Click" Width="100%" Height="100%" runat="server" Text="=" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
