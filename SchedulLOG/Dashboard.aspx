<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="SchedulLOG.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to SchedulLOG</title>
    <style type="text/css">
        .auto-style2 {
            width: 662px;
        }
        .auto-style3 {
            background-color: aliceblue;
            width: 100%;
        }
        .auto-style8 {
            height: 32px;
            width: 218px;
        }
        .auto-style9 {
            width: 218px;
        }
        .auto-style10 {
            height: 32px;
            width: 379px;
        }
        .auto-style11 {
            width: 379px;
        }
        .auto-style12 {
            height: 32px;
            width: 448px;
        }
        .auto-style13 {
            width: 448px;
        }
        .auto-style14 {
            height: 32px;
            width: 123px;
        }
        .auto-style15 {
            width: 123px;
        }
        .auto-style16 {
            height: 32px;
            width: 239px;
        }
        .auto-style17 {
            width: 239px;
        }
    </style>
    <link href="additional/css/dashboardStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style3">
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnHome" runat="server" Height="62px" Text="Home" Width="88px" OnClick="btnHome_Click" />
                        <asp:Button ID="btnEdit" runat="server" Height="62px" Text="Manage" Width="120px" OnClick="btnEdit_Click" />
                        <asp:Button ID="btnAdmin" runat="server" Height="62px" Text="Account Manager" Width="207px" OnClick="btnAdmin_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnLogout" runat="server" Height="62px" Text="Logout" Width="135px" OnClick="btnLogout_Click" />
                        <br />
                        <asp:Label ID="lbEmailDetails" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
        <div><br />
           <h1><center> <asp:Label ID="lblTitle" runat="server" Text="SchedulLOG"></asp:Label></center></h1>
        </div>
        <div>
            <center><asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar></center>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <center class="desc">
                SchedulLOG help you manage all your activities neatly<br />
                Click button below to show your schedule.
            </center>
            <br />
            <center>
            <asp:Button class="btnDay"  ID="btnMonday" runat="server" Height="50px" Text="Monday" Width="175px" OnClick="btnMonday_Click" />
            <asp:Button class="btnDay"  ID="btnTuesday" runat="server" Height="50px" Text="Tuesday" Width="175px" OnClick="btnTuesday_Click" />
            <asp:Button class="btnDay"  ID="btnWed" runat="server" Height="50px" Text="Wednesday" Width="184px" OnClick="btnWed_Click" />
            <asp:Button class="btnDay"  ID="btnThurs" runat="server" Height="50px" Text="Thursday" Width="176px" OnClick="btnThurs_Click" />
            <asp:Button class="btnDay"  ID="btnFriday" runat="server" Height="50px" Text="Friday" Width="184px" OnClick="btnFriday_Click" />
            <asp:Button class="btnDay"  ID="btnSatur" runat="server" Height="50px" Text="Saturday" Width="187px" OnClick="btnSatur_Click" />
            </center>
        </p>
        <p>
            <center>
                <asp:Label ID="titleDay" runat="server" Font-Size="70px" Text=""></asp:Label>
        </center>
            <asp:Repeater ID="RptShowData" runat="server">
                <HeaderTemplate>
                     <table class="tbSchedule" style="width:100%;">                  
                        <tr class="tbHeader">
                            <td class="auto-style8"> <asp:Label ID="Label1" runat="server" Text="Time"></asp:Label></td>
                            <td class="auto-style10"><asp:Label ID="Label2" runat="server" Text="Course"></asp:Label></td>
                            <td class="auto-style12"><asp:Label ID="Label3" runat="server" Text="Lecturer"></asp:Label></td>
                            <td class="auto-style14"><asp:Label ID="Label4" runat="server" Text="Class"></asp:Label></td>
                            <td class="auto-style16"><asp:Label ID="Label5" runat="server" Text="Link Online Class"></asp:Label></td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                        <tr class="tbContent">
                            <td class="auto-style9"><%# Eval("Time") %></td>
                            <td class="auto-style11"><%# Eval("Course") %></td>
                            <td class="auto-style13"><%# Eval("Lecturer") %></td>
                            <td class="auto-style15"><%# Eval("Class") %></td>
                            <td class="auto-style17"><a href="<%# Eval("LinkOnlineClass") %>" class="btnDay btn-warning btn-sm">Link</a></td>
                        </tr>
                </ItemTemplate>
                <FooterTemplate>
                            <tr>
                            <td class="tbFooter" colspan="5">&nbsp;</td>
                        </tr>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
           
                
             
        </p>
        <div>
        </div>
    </form>
    </body>
</html>
