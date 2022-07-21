<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample.aspx.cs" Inherits="ServerControl.Sample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox runat="server" ID="textBox1"></asp:TextBox>
            <asp:Button Text="Click me" runat="server" ID="btn1" OnClick="btn1_Click"/>
        </div>
        <br />
        <br />
        <br />
        <div>
            <input type="text" name="textBox2" id="textBox2"/>
            <input type="submit" name="btn2" value="Click me" id="btn2" />
        </div>
    </form>
</body>
</html>
