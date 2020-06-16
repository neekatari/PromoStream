using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class _Default : System.Web.UI.Page
{
    String from;
    String name, message;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            TextBox tt = (TextBox)FindControl("email");
            from = tt.Text;
            TextBox t = (TextBox)FindControl("Name");
            name = t.Text;
            TextBox ttt = (TextBox)FindControl("textarea");
            message = ttt.Text;
        }
        catch
        {
            Response.Redirect("default.aspx");
        }
    }

    public void SendMail()
    {
        
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        SendMail();
    }
}
