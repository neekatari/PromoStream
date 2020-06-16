using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace final
{
    public partial class changepassword : System.Web.UI.Page
    {
        String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
        SqlConnection con;
        String oldpassword = null;
        protected void Page_Load(object sender, EventArgs e)
        {
             con = new SqlConnection(connect);
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            try
            {
                String utype = null;
                if (Application["t"].ToString() == "photographer")
                {

                    utype = "tbl_photographer";
                }
                if (Application["t"].ToString() == "model")
                {

                    utype = "tbl_model";
                }
                if (Application["t"].ToString() == "customer")
                {

                    utype = "tbl_customer";
                }

                String check = "select * from " + utype + " where email='" + Application["mail"].ToString() + "'  ";
                SqlCommand cmd = new SqlCommand(check, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    oldpassword = sdr["password"].ToString();
                }

                if (old.Text == oldpassword)
                {
                    if (newp.Text == cnew.Text)
                    {
                        String query = "update " + utype + " set password='" + cnew.Text + "' where email='" + Application["mail"].ToString() + "' ";
                        con = new SqlConnection(connect);
                        SqlCommand pass = new SqlCommand(query, con);
                        con.Open();
                        pass.ExecuteNonQuery();

                        if (Application["t"].ToString() == "Customer")
                        {
                            Response.Redirect("chome.aspx");
                        }
                        else
                        {
                            Response.Redirect("stream.aspx");
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Enter Correct password  ')", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Enter Correct password  ')", true);
                }
            }
            catch(Exception)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Fill all the Fileld  ')", true);
            }
        }
    }
}