using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
public partial class Cart : System.Web.UI.Page
{
    String time_id = "";
    string connStr = ConfigurationManager.ConnectionStrings["EShoppingConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["key"] == "true")
        {

            if (!IsPostBack)
            {
                BindDataList();
            }
        }
        else
        {
            Response.Redirect("login.aspx");
        }
    }
    private void BindDataList()
    {
        string connStr = ConfigurationManager.ConnectionStrings["EShoppingConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr);
        
        String selectsql = "select Goods_name,Goods_price,CartDetails_count,Goods_Images from Goods,CartDetails where Goods.Goods_id=CartDetails.Goods_id and shoppingCart_id="+"'"+Session["name"]+"'";
        SqlDataAdapter adapter = new SqlDataAdapter(selectsql, conn);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //  Label1.Text = "000000000000000000000";
        time_id = (String)DateTime.Now.ToString();
        String time = (String)DateTime.Now.ToShortDateString().ToString();
        String selectsql = "select SUM(Goods_price*CartDetails_count )as 'price',SUM(CartDetails_count) as 'count',shoppingCart_id  from Goods,CartDetails  where Goods.Goods_id=CartDetails.Goods_id group by shoppingCart_id having shoppingCart_id='" + Session["name"] + "'";
        String insertsql1 = "insert into Orders values(@orders_id,@Orders_price,@Orders_count,@Orders_time,@user_id) ";
        String insertsql2 = "insert into  OrderDetails(Goods_id,Orders_id,OrderDetails_count) values(@Goods3_id,@Orders_id,@OrderDetails_count)";
        String selectsql2 = "select * from CartDetails";
        String deletesql = "delete from CartDetails";

        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();

            //获取Command对象
            SqlCommand cmd = new SqlCommand(selectsql, conn);
            //为参数赋值
            SqlCommand cmd2 = new SqlCommand(insertsql1, conn);
            cmd2.Parameters.AddWithValue("@Orders_id", time_id);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int price = Convert.ToInt32(reader["price"]);
                int count = Convert.ToInt32(reader["count"]);
                cmd2.Parameters.AddWithValue("@Orders_price", price);
                cmd2.Parameters.AddWithValue("@Orders_count", count);
                cmd2.Parameters.AddWithValue("@Orders_time", time);
                cmd2.Parameters.AddWithValue("@user_id", Session["user_id"]);
                Label1.Text = "总价是:" + "<font color='red'>" + price + "</font>    总数量:" + count;
                reader.Close();
                cmd2.ExecuteNonQuery();
            }
            else
            {
                Response.Write("11111111111111111");
            }

        }
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();
            //获取Command对象
            SqlCommand cmd4 = new SqlCommand(selectsql2, conn);
            //为参数赋值

            SqlConnection conn2 = new SqlConnection(connStr);
            conn2.Open();

            SqlDataReader reader = cmd4.ExecuteReader();
            while (reader.Read())
            {
                SqlCommand cmd3 = new SqlCommand(insertsql2, conn2);
                String goods_id = (String)reader["Goods_id"];
                int count = Convert.ToInt32(reader["CartDetails_count"]);
                cmd3.Parameters.AddWithValue("@Goods3_id", goods_id);
                cmd3.Parameters.AddWithValue("@Orders_id", time_id);
                cmd3.Parameters.AddWithValue("@OrderDetails_count", count);
                cmd3.ExecuteNonQuery();

            }


        }
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();
            SqlCommand cmd5 = new SqlCommand(deletesql, conn);
            //获取Command对象
            cmd5.ExecuteNonQuery();
            DataList1.DataBind();
        }
    }
}