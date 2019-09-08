using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
public partial class shelf : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["EShoppingConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["type"] == "true")
        {

          


        }
        else
        {
            Response.Write("<script language=javascript>alert('你没有权限');</script>");


            Response.Redirect("homePage.aspx");
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
       
        String Goods_id = TextBox2.Text.Trim().ToString();
        String Goods_name = TextBox3.Text.Trim().ToString();
        String Goods_type = DropDownList1.SelectedValue;
        float Goods_price = Convert.ToInt32(TextBox4.Text.Trim().ToString());
        int Goods_count = Convert.ToInt32(TextBox5.Text.Trim().ToString());
        String Goods_images = TextBox1.Text.ToString();

        String insertsql = "insert into Goods values(@Goods_id,@Goods_name,@Goods_type,@Goods_price,@Goods_count,@Goods_Images)";

        Boolean fileOK = false;      //文件类型是否符合要求标志
        String path = Server.MapPath("~/images/");   //图片路径
        if (FileUpload1.HasFile)         //检查是否有路径
        {
            fileOK = true;
            if (fileOK)
            {
                FileUpload1.PostedFile.SaveAs(path + FileUpload1.FileName);


            }

        }
        else
        {
             Response.Write("<script language=javascript>alert('1111111');</script>");
        }

       
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            
            conn.Open();
            //获取Command对象
            SqlCommand cmd = new SqlCommand(insertsql, conn);
            //为参数赋值
            cmd.Parameters.AddWithValue("@Goods_id", Goods_id);
            cmd.Parameters.AddWithValue("@Goods_name", Goods_name);
            cmd.Parameters.AddWithValue("@Goods_type", Goods_type);
            cmd.Parameters.AddWithValue("@Goods_price", Goods_price);
            cmd.Parameters.AddWithValue("@Goods_count", Goods_count);
            cmd.Parameters.AddWithValue("@Goods_Images", Goods_images);
            cmd.ExecuteNonQuery();
            Response.Write("<script language=javascript>alert('上架成功');</script>");
        }
    }
}