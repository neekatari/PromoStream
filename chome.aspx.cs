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
    public partial class chome : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
           con= new SqlConnection(connect);
        }
        protected void a_upload_Click(object sender, EventArgs e)
        {
            String m = Application["mail"].ToString();
           cmd = new SqlCommand("select cid from tbl_customer where email='"+m+"' ",con);
            int id=0;
            con.Open();
            SqlDataReader sdr =cmd.ExecuteReader();
            if(sdr.HasRows)
            {
                while(sdr.Read())
                {
                    id = sdr.GetInt32(0);
                }
            }
            con.Close();

            cmd = new SqlCommand("insert into tbl_advertisement  (post_title,description,isActive,allowuser,created,updated,cid)  values  ('"+title.Text+"','"+ descri .Text+ "','t','"+allowuser.Text+ "',GETDATE(),GETDATE()," + id+")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}