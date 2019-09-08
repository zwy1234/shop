<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #title{
            text-align:center;
            font-size:20px;
        }
        #content{
            text-align:center;

        }
           body{
       background-image:url(images/loginbcg.jpg);
   }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p id="title">用户注册</p>
        <div id="content">
        <p>用户名:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>密码：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>确认密码：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>手机号：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>你的密保问题：<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>你的生日是什么时候？</asp:ListItem>
            <asp:ListItem>你几岁？</asp:ListItem>
            <asp:ListItem>你爸爸几岁？</asp:ListItem>
            </asp:DropDownList>
        </p>
          
       
           你的答案是: <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="注册" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="返回" />
        </p>
        <p>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        </p>
        <p>&nbsp;</p>
            </div>
    </div>
    </form>
</body>
</html>
