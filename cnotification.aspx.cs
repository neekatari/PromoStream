using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace final
{
    public partial class cnotification : System.Web.UI.Page
    {
        String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
        int currentuserid;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand();
            SqlCommand c = new SqlCommand("select * from tbl_" + Application["t"].ToString() + " where email='" + Application["mail"].ToString() + "'  ", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dtrr = new DataTable();
            sd.Fill(dtrr);
            currentuserid = Convert.ToInt32(dtrr.Rows[0][0].ToString());
            int id = 0;
            SqlCommand custid = new SqlCommand("select tc.gen_by from tbl_contract tc join tbl_work tw on tw.con_id=tc.ncid where tw.work_for=" + currentuserid + "  ", con);
            con.Open();
            SqlDataReader rr = custid.ExecuteReader();
            while(rr.Read())
            {
                id = Convert.ToInt32(rr["gen_by"]);
            }
            con.Close();
                SqlDataAdapter ssd = new SqlDataAdapter("select i.image,tc.email as mail,tco.title from tbl_customer tc join image i on i.mail=tc.email join tbl_contract tco on tco.gen_by=tc.cid join tbl_work tw on tw.con_id=tco.ncid where tw.work_for="+currentuserid+"",con);
                DataTable st = new DataTable();
                ssd.Fill(st);
                r.DataSource = st;
                r.DataBind();
            

        }
        protected void m_Click(object sender, EventArgs e)
        {
            LinkButton btn3 = (LinkButton)sender;
            RepeaterItem it3 = (RepeaterItem)btn3.NamingContainer;
            HiddenField id3 = (HiddenField)it3.FindControl("cmail");
            String m = Convert.ToString(id3.Value);
            Session["pumail"] = m;
            Session["msg"] = "Congratulation";
            Response.Redirect("comman.aspx");
        }
    }
}