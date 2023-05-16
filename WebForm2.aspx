<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebAssignment.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Management</title>
       
    <style type="text/css">  
        .auto-style1 {  
            width: 100%;  
        }  
        
    </style>  
</head>
<body>
    <form id="form1" runat="server">
    
        <div class="auto-style1">
            <h1>Book Management System</h1>
            <p>
               <asp:Label ID="Label1" runat="server" Text="BookId:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="BookName:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

            </p>
            <p>
                <asp:Label ID="Label3" runat="server"  Text="AuthorName:"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox><br />
            </p>
             <p>
                <asp:Label ID="Label4" runat="server"  Text="Cost:"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox><br />
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Save" Onclick="Button_Click"/>
            </p>
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            <p>
                <asp:Label ID="Label6" runat ="server" Text=""><</asp:Label>
            </p>
            <br />
            <br />
            <asp:GridView ID="Bookdetails" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="Bookdetails_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="BookId" HeaderText="BookId" />
                     <asp:BoundField DataField="BookName" HeaderText="BookName" />
                     <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" />
                     <asp:BoundField DataField="Cost" HeaderText="Cost" />
                    </Columns>
                    
                
            </asp:GridView>
        </div>
    </form>
</body>
</html>
