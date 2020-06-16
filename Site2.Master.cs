using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Mphotographer_Click(object sender, EventArgs e)
        {
            Response.Redirect("Managephotographer.aspx");
        }

        protected void Mmodel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Managemodel.aspx");
        }

        protected void Mcustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("Managecustomer.aspx");
        }

        protected void dash_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}