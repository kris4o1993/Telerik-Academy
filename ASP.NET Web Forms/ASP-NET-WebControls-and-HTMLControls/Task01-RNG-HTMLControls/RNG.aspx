<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RNG.aspx.cs" Inherits="Task01_RNG_HTMLControls.RNG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="rangeMin" type="text" runat="server" />
            <input id="rangeMax" type="text" runat="server" />
            <input 
                id="GetRandomNumber" 
                type="button"
                runat="server" 
                value="Submit"
                onserverclick="ButtonSubmit_Click" />
            <span id="output" runat="server" />
        </div>
    </form>
</body>
</html>
