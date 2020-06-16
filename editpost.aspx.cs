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
    public partial class editpost : System.Web.UI.Page
    {

        String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
        String path = null;
        String descrption = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                SqlConnection con = new SqlConnection(connect);
                int pid = Convert.ToInt32(Session["postid"].ToString());
                SqlCommand cmd = new SqlCommand("select * from tbl_post where pid= " + pid + " ", con);
                con.Open();
                SqlDataReader img = cmd.ExecuteReader();
                while (img.Read())
                {
                    path = img["post_img"].ToString();
                    descrption = img["post_desc"].ToString();
                }
                Image1.ImageUrl = path;
                desc.Text = descrption;
                
            }
        }
        protected void done_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connect);
            int pid = Convert.ToInt32(Session["postid"].ToString());
            String descri = "update tbl_post set post_desc='"+desc.Text+"' where pid= " + pid + " ";
            SqlCommand update_desc = new SqlCommand(descri, con);
            con.Open();
            update_desc.ExecuteNonQuery();
            con.Close();
            //Response.Write("<script>alert(' Work Done')</script>");
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alertMessage", "alert('Work Done...!')", true);
        }

        protected void cansle_Click(object sender, EventArgs e)
        {
            Response.Redirect("U_uploadPost.aspx");
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connect);
            int pid =  Convert.ToInt32( Session["postid"].ToString());
            String del = "update tbl_post set isDelete='t' where pid= " + pid + " ";
            SqlCommand delete = new SqlCommand(del,con);
            con.Open();
            delete.ExecuteNonQuery();
            con.Close();
            Response.Redirect("U_uploadPost.aspx");
            

        }
    }
}