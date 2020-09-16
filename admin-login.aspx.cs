using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Security;
public partial class admin_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        Label1.Visible = false; 
    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
    SqlDataAdapter da;
    DataTable dt;

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        dt = new DataTable();
        SqlCommand com = new SqlCommand("select * from Admin;",con);
        con.Open();
        SqlDataReader dr = com.ExecuteReader();
        if(dr.HasRows)
        {
            while(dr.Read())
            {
                Label1.Visible = true;
                if(TextBox2.Text.ToString()==dr["name"].ToString())
                {
                    if(TextBox3.Text.ToString()==dr["password"].ToString())
                    {
                        Session["id"] = dr["id"];
                        Session["password"] = dr["password"];
                        Response.Redirect("Admin_page.aspx");
                    }
                    else
                    {
                        Label1.Text = "password incorrect";
                    }
                }
                else
                {
                    Label1.Text = "username incorrect";
                }
            }
        }
        con.Close();
      //  da = new SqlDataAdapter("select * from Admins", con);
      //  da.Fill(dt);
       // int i= 0;
      //  int row=dt.Rows.Count;
        /*  while(i<row)
          {
              if (TextBox2.Text.ToString() == dt.Rows[i][0].ToString())
              {
                  if (TextBox3.Text.ToString() == dt.Rows[i][1].ToString())
                  {
                      Session["username"] = TextBox2.Text.ToString();
                      Response.Redirect("Admin_page.aspx");
                  } 
                  else
                  {
                      Label1.Visible = true;
                      Label1.Text = "Invalid password..!";
                  }
              } 
              else
              {
                  Label1.Visible = true;
                  Label1.Text = "Incorrect username..!";
              }
              i++;
          }
        foreach (DataRow ex in dt.Rows)
        {

            Label1.Visible = true;
            Label1.Text = dt.Rows[0]["name"].ToString();
            Label2.Text = dt.Rows[1]["name"].ToString();
            if (dt.Rows[i]["name"].ToString()== TextBox2.Text.ToString() )
            {

                if (TextBox3.Text.ToString() == dt.Rows[i]["password"].ToString())
                {
                    Label3.Text = "lgin success";
                    Response.Redirect("Home .aspx");
                    break;
                }
                else
                {
                    // Label1.Text = "invalid password";
                }

            }
            else
                Label3.Text = "username invalid";
              //  Label1.Text = "invalid username";
            i++;
        }*/
    }
}