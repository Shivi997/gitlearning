<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAssignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
<div>
<asp:Label ID="Label1" runat="server" Text="KEY"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
<asp:Label ID="Label2" runat="server" Text="value"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
<asp:Button ID="Button1" runat="server" Text="Session" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Application" OnClick="Button2_Click" />
<asp:Button ID="Button3" runat="server" Text="view "/>
<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

 <br />
    <div>
   <table>
   <thread>
<tr>
<th>Key</th>
<th>Value</th>
</tr>
</thread>
<tbody>
<asp:Repeater ID="rptdisplay" runat="server">
<ItemTemplate>
<tr>
<td><%#Eval("Key") %></td>
<td><%#Eval("Value") %></td>
</tr>
</ItemTemplate>
</asp:Repeater>
</tbody>
</table>
</div>
</form>
</body>

</html>
