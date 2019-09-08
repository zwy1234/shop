<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GoodsDetails.aspx.cs" Inherits="GoodsDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style style="text/css">
        #goods{
            margin-left:100px;
        }
        #content{
            
            font-size:20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        
        <div id="goods">
        <asp:Image ID="Image1" runat="server" width="150px"  />
            </div>
        <div id="content">
            <asp:Label ID="Label1" runat="server" Text="Label">

            </asp:Label>
            <br />
            购买数量:<asp:TextBox ID="TextBox1" runat="server">1</asp:TextBox>件
            <br />
            <asp:Button ID="Button1" runat="server" Text="立即购买" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="加入购物车" OnClick="Button2_Click" />
        </div>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

