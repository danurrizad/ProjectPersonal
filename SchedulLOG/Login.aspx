<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SchedulLOG.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login page SchedulLOG</title>
    <link href="additional/css/global.css" rel="stylesheet" />
</head>
<body>
    <div class="bg">
        <div class="titleApp">
            <label> SchedulLOG</label>
        </div>
        <div class="login" id="card">
            <form id="form1" runat="server">
                <p style="margin-left: 120px">
                    <label class="title">Login</label></p>
                <div class="auto-style2">
                    <label for="InputEmail">Email Adress</label><br />
                    <asp:TextBox ID="InputEmail" type="email" runat="server" placeholder="Enter your email" Height="20px" Width="301px"></asp:TextBox>
                </div>
                <div >
                    <label>Password</label><br />
                    <asp:TextBox ID="tbPass" type="password" runat="server" placeholder="Enter your password" Height="20px" Width="300px" CssClass="auto-style3"></asp:TextBox>
                </div>
                <div >
                    <input type="checkbox" id="cbPass"/>
                    <label class="label">Show password</label>
                </div>
                <div class="form-group-reg">
                    <label for="Register" Font-Size="15px">Don't have an account?</label>
                   
                    <asp:Button class="reg" ID="btnReg" runat="server" Text="Create new account" OnClick="btnReg_Click" />
                </div>

                <asp:Button class="submit" ID="btnSubmit" runat="server" Text="Login" OnClick="btnSubmit_Click" />
                <div>
                    <asp:Label ID="errorMsg" runat="server" forecolor="red" Text="Email and password are not match!"></asp:Label>
                </div>
            </form>
        </div>
    </div>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script>
        $(document).ready(function() {
            $('#cbPass').click(function() {
                if ($(this).is(':checked')) {
                    $('#tbPass').attr('type', 'text');               
                } else {
                    $('#tbPass').attr('type', 'password');

                }
            });
        });
    </script>
</body>
</html>
