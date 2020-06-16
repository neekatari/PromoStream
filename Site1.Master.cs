using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace final
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        String type;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                type = Application["t"].ToString();

                Application["t"] = type;

                lblname.Text = "Hi, " + Application["name"].ToString();


            }
            catch(Exception)
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            Session["ser"] = txtsearch.Text;
            if(Session["ser"] == null)
            {

            }
            else
            {
                Session["ser"] = txtsearch.Text;
                Response.Redirect("search.aspx");
            }
        }

       

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("U_uploadPost.aspx"); 
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (type != "customer")
            {
                Response.Redirect("cnotification.aspx");
            }
            else
            {
                Response.Redirect("notification.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application.RemoveAll();
            Response.Redirect("Default.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }

        protected void home_Click(object sender, EventArgs e)
        {
            if (type != "customer")
            {
                Response.Redirect("stream.aspx");
            }
            else
            {
                Response.Redirect("chome.aspx");
            }
        }

        protected void changepass_Click(object sender, EventArgs e)
        {
            Response.Redirect("changepassword.aspx");
        }
    }
}