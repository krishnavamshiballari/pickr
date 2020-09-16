using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void signIn_Click(object sender, EventArgs e)
    {
        Response.Redirect("user_login.aspx");
    } 

    protected void newAccount_Click(object sender, EventArgs e)
    {
        Response.Redirect("register.aspx");
    }

    protected void wannaPickr_Click(object sender, EventArgs e)
    {
        Response.Redirect("pickr_signin.aspx");
    }

    protected void Pricing_Click(object sender, EventArgs e)
    {
        Response.Redirect("WebForm1.aspx");
    }
}