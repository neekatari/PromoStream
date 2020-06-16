using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!this.IsPostBack)
            {
                Session.Abandon();
            }
        }

        protected void btnlogin_click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Btnregi_click(object sender,EventArgs e)
        {
            Response.Redirect("~/regi.aspx");
        }
        public void demo(object sender, EventArgs e)
        {
            Response.Redirect("regi.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
             Response.Redirect("~/regi.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("reg.aspx");
        }
    }
}