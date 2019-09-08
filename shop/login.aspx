<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body{
            background-image:url(images/loginbcg.jpg);
        }
        .btn1{
            margin-left:40px;
        }
        .hy1{
            font-size:small;
            margin-left:20px;
        }
        #title{
            text-align:center;
            font-size:20px;
        }
    #page{
        margin-top:100px;
    }
    </style>
</head>
<body>
    <div id="page">
    <div id="title">
        用户注册
    </div>
    <br />
    <form id="form1" runat="server">

        <div style="padding-left:42%">
        <div>
            账号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</div>
        <div>
            <br />
            密码：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Red" class="hy1" NavigateUrl="~/findPassword.aspx">找回密码</asp:HyperLink>
        </div>
        <div style="padding-left:50px">
            <br />
          
            <asp:Button ID="Button1" runat="server" Text="登入" OnClick="Button1_Click" />

            <asp:Button ID="Button2" runat="server" Text="注册" CssClass="btn1" OnClick="Button2_Click" />
        </div>
            </div>
        
    </form>
        </div>
</body>
</html>
