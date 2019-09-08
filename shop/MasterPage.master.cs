using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["key"] == "true")
        {

            Label1.Text = "欢迎"+(String)Session["name"]+"登录";
        }
        else
        {
            Label1.Text = "你未登录";
            HyperLink1.Text = "请登录";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["key"] = "false";
        Response.Redirect("login.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("1111");
        Response.Redirect( "GoodsDetails.aspx?goods_id="+TextBox1.Text.Trim());
      
    }
}
