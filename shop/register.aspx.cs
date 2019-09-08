using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class register : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["EShoppingConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String user_name = TextBox1.Text;
        String user_pwd = TextBox2.Text;
        String user_phone = TextBox4.Text;
        String user_answer = DropDownList1.SelectedItem.Value;
        int user_type = 0;

        string selectsql = "select *from Users where Users_phone=@Users_phone";
        string insertsql ="insert into Users(Users_name,Users_pwd,Users_phone,Users_answer,Users_type) values(@user_name,@user_pwd,@User_phones,@user_answer,0)";
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();
            //获取Command对象
            SqlCommand cmd = new SqlCommand(selectsql, conn);
            SqlCommand cmd2 = new SqlCommand(insertsql, conn);
            //为参数赋值
            cmd.Parameters.AddWithValue("@Users_phone", TextBox4.Text.Trim());
        
            
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Response.Write("<script language=javascript>alert('该手机号已被注册');</script>");
              //  Response.Write("111111111111111111111");
            }
            else
            {
                reader.Close();
                cmd2.Parameters.AddWithValue("@User_phones", TextBox4.Text.Trim());
                cmd2.Parameters.AddWithValue("@user_name", TextBox1.Text.Trim());
                cmd2.Parameters.AddWithValue("@user_pwd", TextBox2.Text.Trim());
                cmd2.Parameters.AddWithValue("@user_answer", TextBox5.Text.Trim());
                cmd2.ExecuteNonQuery();
            }
          
          
            conn.Close();
        }





    }
}