<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exam4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

List of Items available in Store :<asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="207px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<br />
<asp:Image ID="Image1" runat="server" Height="400px" Width="700px" />
<p>
Cost of selected item : <asp:Button ID="Price" runat="server" OnClick="Button1_Click1" style="margin-left: 43px" Text="Price" Width="119px" />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>


        </div>
    </form>
</body>
</html>
