using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


public partial class Admin_page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { 
        string str = "select image from Admin where id='"+ Session["id"] +"'";
        SqlDataAdapter da = new SqlDataAdapter(str, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        Image2.ImageUrl = dt.Rows[0]["image"].ToString();

    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
    SqlDataAdapter da;
    DataTable dt;
    SqlDataReader dr;



protected void LinkButton2_Click(object sender, EventArgs e)
    {
            
         
            iframeDiv.Controls.Add(new LiteralControl("<iframe src=\"user_admin.aspx\" style= \"height: 500px; width:800px; border-style:none; \" > </iframe>"));
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string str = "select * from Admin where id='" + Session["id"] + "'";
        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        SqlDataReader dr=cmd.ExecuteReader();
        dr.Read(); 
        Session["id"] = dr["id"];
        iframeDiv.Controls.Add(new LiteralControl("<iframe src=\"Admin_profile.aspx\" style= \"height: 500px; width:750px; border-style:none; \" > </iframe>"));
      
        
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {    

    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        iframeDiv.Controls.Add(new LiteralControl("<iframe src=\"orders_admin.aspx\" style= \"height: 500px; width:800px; border-style:none; \" > </iframe>"));
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        iframeDiv.Controls.Add(new LiteralControl("<iframe src=\"pickr_admin.aspx\" style= \"height: 500px; width:800px; border-style:none; \" > </iframe>"));
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        iframeDiv.Controls.Add(new LiteralControl("<iframe src=\"pickr_req.aspx\" style= \"height: 500px; width:800px; border-style:none; \" > </iframe>"));
    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        iframeDiv.Controls.Add(new LiteralControl("<iframe src=\"pickr-admin_register.aspx\" style= \"height: 500px; width:800px; border-style:none; \" > </iframe>"));
    }

    protected void LinkButton7_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Main.aspx");
    }
}