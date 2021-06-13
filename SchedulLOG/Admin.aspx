<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="SchedulLOG.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Account registered</title>
    <link href="additional/css/adminStyle.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style10 {
            height: 50px;
            width: 1673px;
        }
        .auto-style11 {
            height: 50px;
            width: 662px;
        }
        .auto-style12 {
            height: 50px;
            width: 100%;
            background-color: aliceblue;
        }
        .auto-style13 {
            margin-left: 0px;
            margin-bottom: 33px;
        }
        .auto-style14 {
            width: 1221px;
        }
        .auto-style15 {
            width: 638px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table class="auto-style12">
                <tr>
                    <td class="auto-style11">
                        <asp:Button ID="btnHome" runat="server" Height="62px" Text="Home" Width="88px" OnClick="btnHome_Click" />
                        <asp:Button ID="btnEdit" runat="server" Height="62px" Text="Manage" Width="120px" OnClick="btnEdit_Click" />
                        <asp:Button ID="btnAdmin" runat="server" Height="62px" Text="Account Manager" Width="207px" OnClick="btnAdmin_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnLogout" runat="server" Height="62px" Text="Logout" Width="135px" OnClick="btnLogout_Click" />
                        <br />
                    </td>
                </tr>
            </table>
            <center class="auto-style15"><asp:Label ID="lblTitle" runat="server" Font-Size="60px" Text="Account Registered" Font-Bold="True"></asp:Label></center>
            <br />
        </div><center class="auto-style14">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Height="125px" Width="924px" AllowPaging="True" AllowSorting="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="auto-style13">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName" />
                <asp:BoundField DataField="NIM" HeaderText="NIM" SortExpression="NIM" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:adminConnection %>" SelectCommand="SELECT * FROM [tbLogin]" DeleteCommand="DELETE FROM [tbLogin] WHERE [Id] = @Id" InsertCommand="INSERT INTO [tbLogin] ([Email], [Password], [FullName], [NIM]) VALUES (@Email, @Password, @FullName, @NIM)" UpdateCommand="UPDATE [tbLogin] SET [Email] = @Email, [Password] = @Password, [FullName] = @FullName, [NIM] = @NIM WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="FullName" Type="String" />
                <asp:Parameter Name="NIM" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="FullName" Type="String" />
                <asp:Parameter Name="NIM" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
            </asp:SqlDataSource></center>
    </form>
</body>
</html>
