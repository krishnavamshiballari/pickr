<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pickr_admin.aspx.cs" Inherits="pickr_admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 53px;
        }
        .auto-style2 {
            width: 789px;
            height: 309px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2" style="color: #FFFFFF; font-size: 19px">


            <br />
            <asp:GridView ID="GridView1" runat="server" GridLines="None" AutoGenerateColumns="False" CssClass="auto-style1" DataSourceID="SqlDataSource1" Height="161px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="701px">
               <RowStyle HorizontalAlign="Center" />
                <Columns>
                    <asp:ImageField DataImageUrlField="image" HeaderText="Image" SortExpression="image"  ControlStyle-Height="100" ControlStyle-Width="100">
                        <ControlStyle Height="100px" Width="100px" />
                    </asp:ImageField>
                    <asp:BoundField DataField="id" HeaderText="Id" SortExpression="id" InsertVisible="False" ReadOnly="True" />
                    <asp:BoundField DataField="name"  HeaderText="Name" SortExpression="name" />
                    <asp:BoundField DataField="email" HeaderText="E-Mail" SortExpression="email" />
                    <asp:BoundField DataField="phone" HeaderText="Phone"  SortExpression="phone" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connection %>" SelectCommand="SELECT image, id, name, email, aadhar, phone FROM Pickr"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <br />
            <br />


        </div>
    </form>
</body>
</html>
