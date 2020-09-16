using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_profile : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
    SqlDataAdapter da;
    DataTable dt;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        string str="select * from Admin where id='"+ Session["id"] +"'";
        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        Label1.Text = dr["name"].ToString();
        Label2.Text = dr["email"].ToString();
        Label3.Text = dr["phone"].ToString();
        Label4.Text = dr["aadhar"].ToString();
        con.Close();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        // ChangePassword();
        oldpwd.Visible = true;
        oldpwdl.Visible = true;
        newpwd.Visible = true;
        newpwdl.Visible = true;
        cnewpwd.Visible = true;
        cnewpwdl.Visible = true;
        submit.Visible = true;
    }
    public void ChangePassword()
    {
        
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Admin where id='"+Session["id"] +"'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            string username = ds.Tables[0].Rows[0]["username"].ToString();
            string OLdpassword = ds.Tables[0].Rows[0]["password"].ToString();
           
            if (OLdpassword == oldpwd.Text)
            {
                if (newpwd.Text == cnewpwd.Text)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Admin set password='" + newpwd.Text + "' where id='" + Session["id"] + "'",con);
                    int querystatus = cmd.ExecuteNonQuery();
                    if (querystatus > 0)
                    {
                        lblError.Visible = true;
                        lblError.ForeColor = System.Drawing.Color.Green;
                        lblError.Text = "Password updated successfully";
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.ForeColor = System.Drawing.Color.Red;
                        lblError.Text = "Execution error";
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Password miss match";
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Text = "Old password is incorrect";
            }
         con.Close(); 
    }

    

    protected void submit_Click(object sender, EventArgs e)
    {
        ChangePassword();
    }
}