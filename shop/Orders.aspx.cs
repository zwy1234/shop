using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["EShoppingConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {


        if (Session["key"] == "true")
        {
            String selectsql = "select *from  Goods,OrderDetails,Orders where Goods.Goods_id=OrderDetails.Goods_id and Orders.Orders_id=OrderDetails.Orders_id and Orders.Users_id=" + Session["user_id"];

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                //获取Command对象
                SqlCommand cmd = new SqlCommand(selectsql, conn);
                //为参数赋值


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TableRow tr = new TableRow();

                    TableCell tcl = new TableCell();
                    TableCell tc2 = new TableCell();
                    TableCell tc3 = new TableCell();
                    TableCell tc4 = new TableCell();

                    tcl.Text = (String)reader["Goods_name"];
                    tc2.Text=Convert.ToInt32(reader["Goods_price"])+" ";
                    tc3.Text = Convert.ToInt32(reader["Goods_count"]) + " ";
                    tc4.Text = (String)reader["Orders_id"];

                    tr.Cells.Add(tcl);

                    tr.Cells.Add(tc2);
                    tr.Cells.Add(tc3);
                    tr.Cells.Add(tc4);
                    
                    Table1.Rows.Add(tr);

                }

                conn.Close();
            }

        }
        else
        {
            Response.Redirect("login.aspx");
        }

    }
}