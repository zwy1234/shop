<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 
    <style type="text/css">
        .auto-style1 {
            width: 100px;
        }
        #pay{
            position:fixed;
            right:2px;
            bottom:50px;
        }
        #lab1{
            position:fixed;
            left:5px;
            bottom:50px;
            font-size:20px;
            
        }
    </style>
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
     
    
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="5"  RepeatDirection="Horizontal" BorderWidth="2px" GridLines="Both" Width="100%" >
        <ItemTemplate>
            <table class="auto-style1" >
                <tr>
                    <td rowspan="3" ><asp:Image ID="Image1"    runat="server" Height="50px" ImageUrl='<%# Eval("Goods_images", "~/images/{0}") %>' Width="76px" /></td>
                    <td >商品名:<%#Eval("Goods_name") %></td>
                </tr>
                <tr>
                    
                    <td >价格:<%#Eval("Goods_price") %></td>
                </tr>
                <tr>
                    
                    <td >数量:<%#Eval("CartDetails_count") %></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
   <div id="lab1">
    <asp:Label ID="Label1" runat="server" Text="总价：   总数量："></asp:Label></div>
    <div id="pay">
        <asp:Button ID="Button1" height="30px" width="100px" runat="server" Text="结算" OnClick="Button1_Click" />
    </div>
</asp:Content>

