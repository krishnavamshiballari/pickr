<%@ Page Language="C#" AutoEventWireup="true" CodeFile="orders_admin.aspx.cs" Inherits="orders_admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 30px;
            margin-top: 0px;
        }
        .auto-style2 {
            width: 788px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="color: #FFFFFF" class="auto-style2">
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" GridLines="None" runat="server" AutoGenerateColumns="False" CssClass="auto-style1" DataSourceID="SqlDataSource1" Height="167px" Width="755px">
           <RowStyle HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="username" HeaderText="Pickr name" SortExpression="username" />
                    <asp:BoundField DataField="itemname" HeaderText="Product" SortExpression="itemname" />
                    <asp:BoundField DataField="charge" HeaderText="Charge" SortExpression="charge" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connection %>" SelectCommand="SELECT [id], [username], [charge], [itemname] FROM [Orders]"></asp:SqlDataSource>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
