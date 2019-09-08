using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
public partial class disShelf : System.Web.UI.Page
{

    String goods_id;
    string connStr = ConfigurationManager.ConnectionStrings["EShoppingConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

         goods_id = Request.QueryString["goods_id"];
        if (Session["type"] == "true")
        {




        }
        else
        {
            Response.Write("<script language=javascript>alert('你没有权限');</script>");


            Response.Redirect("homePage.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        String deletesql = "delete from Goods where Goods_id=@Goods_id";
        using (SqlConnection conn = new SqlConnection(connStr))
        {

            conn.Open();
            //获取Command对象
            SqlCommand cmd = new SqlCommand(deletesql, conn);
            //为参数赋值
            cmd.Parameters.AddWithValue("@Goods_id", goods_id);
            cmd.ExecuteNonQuery();
            Response.Write("<script language=javascript>alert('下架成功');</script>");
            ListView1.DataBind();
        }

    }
}