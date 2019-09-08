using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
public partial class findPassword : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["EShoppingConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
       


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String User_name = TextBox1.Text.Trim();
        String User_answer = TextBox2.Text.Trim();

        string selectsql = "select  Users_pwd from Users where Users_name=@user_name and Users_answer=@user_answer";
        string updatesql = "update  Users set Users_pwd=@user_pwd where Users_name=@users_name";
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();
            //获取Command对象
            SqlCommand cmd = new SqlCommand(selectsql, conn);
            //为参数赋值
            cmd.Parameters.AddWithValue("@user_name", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@user_answer", TextBox2.Text.Trim());

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                SqlCommand cmd2 = new SqlCommand(updatesql, conn);
                cmd2.Parameters.AddWithValue("@users_name", TextBox1.Text.Trim());
                cmd2.Parameters.AddWithValue("@user_pwd", TextBox3.Text.Trim());

                cmd2.ExecuteNonQuery();
            }
            else
            {
                Response.Write("1111111111111111111");
            }

            conn.Close();
        }
    
    
    
    
    
    
    
    
    
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
}