<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  <style type="text/css">
      #content{
          
      }
      .tab2{
          width:100%;
          border:solid 1px #808080;
      }

  </style>
     </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="content">
    <asp:Table ID="Table1" runat="server"  class="tab2" BorderStyle="Solid">
        <asp:TableRow>
    <asp:TableCell>商品名</asp:TableCell>
      <asp:TableCell>价格</asp:TableCell>
            <asp:TableCell>数量</asp:TableCell>
            <asp:TableCell>日期</asp:TableCell>
            </asp:TableRow>
    </asp:Table>
</div>

    </asp:Content>

