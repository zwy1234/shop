<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="shelf.aspx.cs" Inherits="shelf" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        #title{
            font-size:20px;
            text-align:center;
        }
        #content{
            margin-left:300px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <p id="title">上架商品</p>
       <div id="content"> 
           <table>
            <tr><td><span>商品id:</span></td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
            
            <tr><td><span>商品名:</span></td><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
            
            <tr><td><span>商品类型:</span></td><td><asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>水果</asp:ListItem>
                <asp:ListItem>玩具</asp:ListItem>
                <asp:ListItem>食品</asp:ListItem>
                <asp:ListItem Value="家具"></asp:ListItem>
                <asp:ListItem>衣服</asp:ListItem>
            </asp:DropDownList></td></tr>
            
            <tr><td><span>商品单价:</span></td><td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td></tr>
          
            <tr><td><span>商品库存量：</span></td><td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td></tr>
      
            <tr><td><span>图片路径：</span></td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
          
           <tr><td><span>商品图片：</span></td><td> <asp:FileUpload ID="FileUpload1" runat="server" /></td></tr>
    
   <tr><td> 
       <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="上架商品" />
       </td></tr>
              </table></div>
</asp:Content>

