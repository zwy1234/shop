using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
public partial class GoodsDetails : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["EShoppingConnectionString"].ConnectionString;
    String goods_id;
    float goods_price = 0;
    String goods_id1;
    protected void Page_Load(object sender, EventArgs e)
    {
         goods_id = (String)Request.QueryString["goods_id"];
         string selectsql = "select  * from Goods where Goods_name like '%" + goods_id + "%'"; ;
       
        String url="";
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();
            //获取Command对象
            SqlCommand cmd = new SqlCommand(selectsql, conn);
            //为参数赋值
           // cmd.Parameters.AddWithValue("@goods_id", goods_id);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                goods_id1 = (String)reader["Goods_id"];
                url = (String)reader["Goods_images"];
                Label1.Text = "<p>商品名称:" + reader["Goods_name"] + "</p>" + "<p>商品类型:" + reader["Goods_type"] + "</p>" +
                    "<p>商品价格:" + "<font color='red'>" + reader["Goods_price"] + "</font></p>" + "<p>库存数量:" +reader["Goods_count"]+"</p>";
               // goods_price = (float)reader["Goods_price"];
                goods_price = Convert.ToInt32(reader["Goods_price"]);
            }
            Image1.ImageUrl = "~/images/" + url;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
      
        String time = (String)DateTime.Now.ToString();

        if (Session["key"] == "true")
        {
            int count = Convert.ToInt32(TextBox1.Text.ToString().Trim());
          
            string insertsql = "insert into  CartDetails values(@carts_id,@cartdetails_id,@goods_id,@goods_count)";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                //获取Command对象
                SqlCommand cmd2 = new SqlCommand(insertsql, conn);
                //为参数赋值
                cmd2.Parameters.AddWithValue("@carts_id", Session["name"]);
                cmd2.Parameters.AddWithValue("@cartdetails_id", time);
                 cmd2.Parameters.AddWithValue("@goods_id",goods_id1);
                 cmd2.Parameters.AddWithValue("@goods_count", count);
                 cmd2.ExecuteNonQuery();
            }
        }

        else
        {
            Response.Redirect("login.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String time_id = (String)DateTime.Now.ToString();
        //订单时间
        String time = (String)DateTime.Now.ToShortDateString().ToString();
        if (Session["key"] == "true")
        {
            int count = Convert.ToInt32(TextBox1.Text.ToString().Trim());

            string insertsql2 = "insert into Orders values(@orders_id,@Orders_price,@Orders_count,@Orders_time,@user_id) ";
            string insertsql = "insert into  OrderDetails(Goods_id,Orders_id,OrderDetails_count) values(@Goods_id,@Orders_id,@OrderDetails_count)";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                //获取Command对象
                SqlCommand cmd3 = new SqlCommand(insertsql, conn);
                SqlCommand cmd4 = new SqlCommand(insertsql2, conn);
                //为参数赋值
                cmd3.Parameters.AddWithValue("@Goods_id", goods_id1);
                cmd3.Parameters.AddWithValue("@Orders_id",time_id);
                cmd3.Parameters.AddWithValue("OrderDetails_count",count );
                cmd4.Parameters.AddWithValue("@orders_id", time_id);
                cmd4.Parameters.AddWithValue("@Orders_price", count*goods_price);
                cmd4.Parameters.AddWithValue("@Orders_count", count);
                cmd4.Parameters.AddWithValue("@Orders_time", time);
                cmd4.Parameters.AddWithValue("@user_id", Session["user_id"]);
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
            }
        }

        else
        {
            Response.Redirect("login.aspx");
        }


    }
}