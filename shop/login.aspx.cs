using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["EShoppingConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*
         */
        String User_name = TextBox1.Text.Trim();
        String User_pwd = TextBox2.Text.Trim();
        int type;
        string selectsql = "select  * from Users where Users_name=@user_name and Users_pwd=@user_pwd";
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();
            //获取Command对象
            SqlCommand cmd = new SqlCommand(selectsql, conn);
            //为参数赋值
            cmd.Parameters.AddWithValue("@user_name", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@user_pwd", TextBox2.Text.Trim());

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                type = Convert.ToInt32(reader["Users_type"]);

                if (type == 1) Session["type"] = "true";
                else Session["type"] = "false";
                Session["key"] = "true";
                Session["name"] = User_name;
                Session["user_id"] = reader["Users_id"];
                Response.Redirect("homePage.aspx");
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("register.aspx");
    }
}