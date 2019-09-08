<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GoodsType4.aspx.cs" Inherits="GoodsType4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EShoppingConnectionString %>" SelectCommand="SELECT * FROM [Goods]  where Goods_type='家具'">
            <SelectParameters>
                <asp:QueryStringParameter Name="Goods_type2" QueryStringField="type" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:ListView ID="ListView1" runat="server" DataKeyNames="Goods_id" DataSourceID="SqlDataSource1" GroupItemCount="5"  >
            <AlternatingItemTemplate>
                <td runat="server" style=""><p>

                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# Eval("Goods_images", "~/images/{0}") %>' Width="15%" height="20px" PostBackUrl='<%# Eval("Goods_name","~/GoodsDetails.aspx?goods_id={0}") %>'  />
                                            </p><div>
                   
                    <asp:Label ID="Goods_nameLabel" runat="server" Text='<%# Eval("Goods_name") %>' />

                  &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Goods_priceLabel" runat="server" Text='<%# Eval("Goods_price") %>' />
                   
                    </div></td>
             
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <td runat="server" style="">Goods_id:
                    <asp:Label ID="Goods_idLabel1" runat="server" Text='<%# Eval("Goods_id") %>' />
                    <br />Goods_name:
                    <asp:TextBox ID="Goods_nameTextBox" runat="server" Text='<%# Bind("Goods_name") %>' />
                    <br />Goods_type:
                    <asp:TextBox ID="Goods_typeTextBox" runat="server" Text='<%# Bind("Goods_type") %>' />
                    <br />Goods_price:
                    <asp:TextBox ID="Goods_priceTextBox" runat="server" Text='<%# Bind("Goods_price") %>' />
                    <br />Goods_count:
                    <asp:TextBox ID="Goods_countTextBox" runat="server" Text='<%# Bind("Goods_count") %>' />
                    <br />Goods_Images:
                    <asp:TextBox ID="Goods_ImagesTextBox" runat="server" Text='<%# Bind("Goods_Images") %>' />
                    <br />
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                    <br />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="取消" />
                    <br /></td>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>未返回数据。</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
<td runat="server" />
            </EmptyItemTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            <InsertItemTemplate>
                <td runat="server" style="">Goods_id:
                    <asp:TextBox ID="Goods_idTextBox" runat="server" Text='<%# Bind("Goods_id") %>' />
                    <br />Goods_name:
                    <asp:TextBox ID="Goods_nameTextBox" runat="server" Text='<%# Bind("Goods_name") %>' />
                    <br />Goods_type:
                    <asp:TextBox ID="Goods_typeTextBox" runat="server" Text='<%# Bind("Goods_type") %>' />
                    <br />Goods_price:
                    <asp:TextBox ID="Goods_priceTextBox" runat="server" Text='<%# Bind("Goods_price") %>' />
                    <br />Goods_count:
                    <asp:TextBox ID="Goods_countTextBox" runat="server" Text='<%# Bind("Goods_count") %>' />
                    <br />Goods_Images:
                    <asp:TextBox ID="Goods_ImagesTextBox" runat="server" Text='<%# Bind("Goods_Images") %>' />
                    <br />
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="插入" />
                    <br />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="清除" />
                    <br /></td>
            </InsertItemTemplate>
            <ItemTemplate>
                <td runat="server" style=""><p><asp:ImageButton ID="Image1" runat="server" ImageUrl='<%# Eval("Goods_images", "~/images/{0}") %>' Width="15%" height="30px" PostBackUrl='<%# Eval("Goods_name","~/GoodsDetails.aspx?goods_id={0}") %>' /></p><div>
                   
                    <asp:Label ID="Goods_nameLabel" runat="server" Text='<%# Eval("Goods_name") %>' />

                  &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Goods_priceLabel" runat="server" Text='<%# Eval("Goods_price") %>' />
                   
                    </div></td>
                
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                             
                            <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                               
                                <tr id="groupPlaceholder" runat="server">
                              <td>
                        
                              </td>
                                      </tr>
                            </table>
                           
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="">
                            <asp:DataPager ID="DataPager1" runat="server" PageSize="12">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <td runat="server" style="">Goods_id:
                    <asp:Label ID="Goods_idLabel" runat="server" Text='<%# Eval("Goods_id") %>' />
                    <br />Goods_name:
                    <asp:Label ID="Goods_nameLabel" runat="server" Text='<%# Eval("Goods_name") %>' />
                    <br />Goods_type:
                    <asp:Label ID="Goods_typeLabel" runat="server" Text='<%# Eval("Goods_type") %>' />
                    <br />Goods_price:
                    <asp:Label ID="Goods_priceLabel" runat="server" Text='<%# Eval("Goods_price") %>' />
                    <br />Goods_count:
                    <asp:Label ID="Goods_countLabel" runat="server" Text='<%# Eval("Goods_count") %>' />
                    <br />Goods_Images:
                    <asp:Label ID="Goods_ImagesLabel" runat="server" Text='<%# Eval("Goods_Images") %>' />
                    <br /></td>
            </SelectedItemTemplate>
        </asp:ListView>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

