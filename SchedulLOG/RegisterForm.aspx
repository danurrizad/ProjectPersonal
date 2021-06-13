<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="SchedulLOG.RegisterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create an account</title>
    <link href="additional/css/regStyle.css" rel="stylesheet" />
    

</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group" id="card">
             <center><asp:Label ID="lblTitle" runat="server" Text="Sign Up"></asp:Label></center><br />
            <div>
                <asp:Label ID="Label1" runat="server" Text="Full name"></asp:Label><br />
                <asp:TextBox ID="tbName" type="text" runat="server" placeholder="Enter your name" Width="319px" Height="40px" OnTextChanged="tbName_TextChanged"></asp:TextBox>
            </div>
             <asp:RequiredFieldValidator ID="RequiredName" runat="server" Font-Size="15px" ErrorMessage="Please enter your name" ControlToValidate="tbName" ForeColor="#FF5050"></asp:RequiredFieldValidator>
            <br />
            <div>
                <asp:Label ID="Label5" runat="server" Text="NIM"></asp:Label><br />
                <asp:TextBox ID="tbNIM" type="text" runat="server" placeholder="Enter your NIM" Width="319px" Height="40px"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RequiredNIM" runat="server" Font-Size="15px" ErrorMessage="Please enter your NIM" ControlToValidate="tbNIM" ForeColor="#FF5050"></asp:RequiredFieldValidator>
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="Email address"></asp:Label><br />
                <asp:TextBox ID="tbEmail" type="email" runat="server" placeholder="Enter your email" Width="319px" Height="40px"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RequiredEmail" runat="server" Font-Size="15px" ErrorMessage="Please enter your email" ControlToValidate="tbEmail" ForeColor="#FF5050"></asp:RequiredFieldValidator>
            <br />
            <div>
                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label><br />
                <asp:TextBox ID="tbPass" type="password" runat="server" placeholder="Create your password" Width="319px" Height="40px"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RequiredPass" runat="server" Font-Size="15px" ErrorMessage="Please create your password" ControlToValidate="tbPass" ForeColor="#FF5050"></asp:RequiredFieldValidator>
            <br />
            <div>
                <asp:Label ID="Label4" runat="server" Text="Password confirmation"></asp:Label><br />
                <asp:TextBox ID="tbPassConf" type="password" runat="server" placeholder="Enter your password again" Width="319px" Height="40px"></asp:TextBox>
            </div>
            <asp:CompareValidator ID="ComparePass" runat="server" Font-Size="15px" ErrorMessage="Password doesn't match" ControlToCompare="tbPass" ControlToValidate="tbPassConf" ForeColor="#FF5050"></asp:CompareValidator>
            <br />
            <div>
                <asp:CheckBox ID="cbPass" text="Show password" runat="server" Font-Size="15px" OnCheckedChanged="cbPass_CheckedChanged" />
            </div>
            <br />
            <div >
                <asp:Button ID="btnReg" runat="server" Text="Create account" Width="331px" Height="46px" OnClick="btnReg_Click" />
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script>
        $(document).ready(function() {
            $('#cbPass').click(function() {
                if ($(this).is(':checked')) {
                    $('#tbPass').attr('type', 'text');
                    $('#tbPassConf').attr('type', 'text');
                } else {
                    $('#tbPass').attr('type', 'password');
                    $('#tbPassConf').attr('type', 'password');
                }
            });
        });
    </script>
</body>
</html>
