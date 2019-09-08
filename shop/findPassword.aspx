<%@ Page Language="C#" AutoEventWireup="true" CodeFile="findPassword.aspx.cs" Inherits="findPassword" %>

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
   body{
       background-image:url(images/loginbcg.jpg);
   }
   #page{
       margin:100px;
   }
    </style>
</head>
<body>
  
    <div id="page">
    <p id="title">密码找回</p>
    <form id="form1" runat="server" style="padding-left:42%">
       
        <p style="position:relative;padding-left:64px">
            用户名：<asp:TextBox ID="TextBox1" runat="server" style="position:absolute;left:120px;bottom:0px"></asp:TextBox>
        </p>
        <p style="position:relative;padding-left:64px">
            新密码：<asp:TextBox ID="TextBox3" runat="server" style="position:absolute;left:120px;bottom:0px"></asp:TextBox>
        </p>
        <p style="position:relative">
            你的密保答案是：<asp:TextBox ID="TextBox2" runat="server" style="position:absolute;left:120px;bottom:0px "></asp:TextBox>
        </p>
        <p  style="padding-left:100px">
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />

           &nbsp;&nbsp;&nbsp <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
       </div> 
</body>
</html>
