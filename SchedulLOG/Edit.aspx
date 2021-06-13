<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="SchedulLOG.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage your schedule</title>
    <link href="additional/css/editStyle.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style4 {
            width: 340px;
        }
        .auto-style6 {
            width: 340px;
            height: 33px;
        }
        .auto-style7 {
            height: 33px;
            width: 419px;
        }
        .auto-style17 {
            width: 959px;
        }
        .auto-style18 {
            width: 932px;
        }
        .auto-style19 {
            width: 419px;
        }
        .auto-style20 {
            width: 340px;
            height: 32px;
        }
        .auto-style21 {
            width: 419px;
            height: 32px;
        }
        .auto-style22 {
            width: 340px;
            height: 48px;
        }
        .auto-style23 {
            height: 48px;
            width: 419px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style3">
                <tr>
                    <td class="auto-style18">
                        <asp:Button ID="btnHome" runat="server" Height="62px" Text="Home" Width="88px" OnClick="btnHome_Click" />
                        <asp:Button ID="btnEdit" runat="server" Height="62px" Text="Manage" Width="120px" OnClick="btnEdit_Click" />
                        <asp:Button ID="btnAdmin" runat="server" Height="62px" Text="Account Manager" Width="207px" OnClick="btnAdmin_Click" />
                    </td>
                    <td class="auto-style17">
                        <asp:Button ID="btnLogout" runat="server" Height="62px" Text="Logout" Width="135px" OnClick="btnLogout_Click" />
                        <br />
                    </td>
                </tr>
            </table>

        </div>
        <br />
        <div>
            <center><h1>Manage</h1></center>
            <h4>You can manage your schedule here. <br />
            </h4>
        </div>
        <table class="tblEdit">
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label6" runat="server" Text="Day"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="listDay" runat="server" Height="29px" Width="359px" OnSelectedIndexChanged="listDay_SelectedIndexChanged">
                        <asp:ListItem>Monday</asp:ListItem>
                        <asp:ListItem>Tuesday</asp:ListItem>
                        <asp:ListItem>Wednesday</asp:ListItem>
                        <asp:ListItem>Thursday</asp:ListItem>
                        <asp:ListItem>Friday</asp:ListItem>
                        <asp:ListItem>Saturday</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server" Text="Time"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="tbTime" runat="server" Width="347px" OnTextChanged="tbTime_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Course"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:TextBox ID="tbCourse" runat="server" Width="348px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label3" runat="server" Text="Lecturer"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:TextBox ID="tbLecturer" runat="server" Width="348px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label4" runat="server" Text="Class"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:TextBox ID="tbClass" runat="server" Width="347px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label5" runat="server" Text="Link Online Class"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:TextBox ID="tbLink" runat="server" Width="348px" OnTextChanged="tbLink_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr class="ftEdit">
                <td class="auto-style22">
                    </td>
                <td class="auto-style23">
                    <asp:Button ID="Button1" runat="server" Height="45px" OnClick="Button1_Click" Text="Add" Width="120px" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" Height="45px" OnClick="btnUpdate_Click" Width="120px" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" Height="45px" OnClick="btnDelete_Click" Width="120px" />
                    </tr>
        </table>
        <span>
            <h6>nb: Course is the only needed if you want to delete a data in your schedule</h6>
        </span>
        <center>
            <asp:Label ID="lblAdded" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </center>
    <div>
        <h3>&nbsp;</h3>
    </div>
    </form>
    </body>
</html>
