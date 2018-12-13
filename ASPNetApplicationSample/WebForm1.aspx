<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPNetApplicationSample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send Mail" />
        <br />
        <asp:Panel ID="Panel1" runat="server">
            GetMessage
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            &nbsp;<asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            &nbsp;&nbsp;<asp:Button ID="btnAdd" runat="server" OnClick="btnInvokeGetMessage_Click" Text="Invoke Add" />
            &nbsp;
            <asp:Button ID="btnInvokeGetNumber" runat="server" OnClick="btnInvokeGetNumber_Click" Text="Invoke Substract" />
        </asp:Panel>
    </form>
</body>
</html>
