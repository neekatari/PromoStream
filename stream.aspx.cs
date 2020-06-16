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
    public partial class stream : System.Web.UI.Page
    {
        String type,name,mail;
        String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
        SqlConnection con;

        protected void btnads_Click1(object sender, EventArgs e)
        {
            con = new SqlConnection(connect);
            LinkButton btn = (LinkButton)sender;
            RepeaterItem it = (RepeaterItem)btn.NamingContainer;
            HiddenField id = (HiddenField)it.FindControl("adid");
            int aid = int.Parse(id.Value);
            
            int tflag = 0;
            String utype = null;
            String uidd = null;
            if (Application["t"].ToString() == "photographer")
            {
                tflag = 1;
                utype = "tbl_photographer";
                uidd = "p";
            }
            if (Application["t"].ToString() == "model")
            {
                tflag = 2;
                utype = "tbl_model";
                uidd = "f";
            }
            if (Application["t"].ToString() == "customer")
            {
                tflag = 0;
                utype = "tbl_customer";
                uidd = "c";
            }


            SqlDataAdapter sd = new SqlDataAdapter("select * from " + utype + " where email = '"+mail+"' ", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            int uid = Convert.ToInt32(dt.Rows[0][0]);
            DateTime date = DateTime.Now;
            SqlCommand cmd = new SqlCommand("insert into tbl_adsbidder (adid,bidder_id,created,isActive,updated,type) values(" + aid + "," + uid + ",GETDATE(),'t',GETDATE()," + tflag + ")", con);
            SqlCommand cmd1 = new SqlCommand("insert into tbl_notification (notify_for,notify_by,ads_id,updated,created,isActive,type ) values ((select cid from tbl_advertisement where aid= "+ aid + ")," + uid + "," + aid + ",GETDATE(),GETDATE(),'t'," + tflag + "  )   ", con);

            con.Open();
            int i=cmd.ExecuteNonQuery();
            int j=cmd1.ExecuteNonQuery(); 
            if(i==1 && j==1)
            {
                Page.RegisterStartupScript("UserMsg", "<script>alert('Successfully Send...');</script>");
            }
            else
            {
                Page.RegisterStartupScript("UserMsg", "<script>alert('Faild');</script>");
            }
            con.Close();
        }

        /*protected void btnads_Click(object sender, EventArgs e)
        {
           con = new SqlConnection(connect);
            Button btn = (Button)sender;
            RepeaterItem it = (RepeaterItem)btn.NamingContainer;
            HiddenField id = (HiddenField)it.FindControl("adid");
            int aid = int.Parse(id.Value);
            int tflag = 0;
            String utype= null;
            if(Application["t"].ToString() == "photographer")
            {
                tflag = 1;
                utype = "tbl_photographer";
            }
            if (Application["t"].ToString() == "model")
            {
                tflag = 2;
                utype = "tbl_model";
            }
            if (Application["t"].ToString() == "customer")
            {
                tflag = 0;
                utype = "tbl_customer";
            }

            SqlDataAdapter sd = new SqlDataAdapter("select * from "+utype+" ",con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            int uid = Convert.ToInt32(dt.Rows[0][0]);
            DateTime date = DateTime.Now;
            SqlCommand cmd = new SqlCommand("insert into tbl_adsbidder (adid,bidder_id,created,isActive,updated,type) values("+aid+","+uid+ ",'" + date + "','t','" + date + "',"+tflag+")", con);
            SqlCommand cmd1 = new SqlCommand("insert into tbl_notification (notify_for,notify_by,ads_id,updated,created,isActive,type ) values (select cid from tbl_advertisement where aid="+aid+","+uid+","+aid+",'"+date+"','"+date+"','t',"+tflag+"  )   ", con);

            con.Open();
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            con.Close();

        }*/

        protected void Page_Load(object sender, EventArgs e)
        {
            con  = new SqlConnection(connect);
           
            if (!this.IsPostBack)
            { 
                Session.Abandon();  

            }
            try
            {
                type = Application["t"].ToString();
                Application["t"] = type;
                name = Application["name"].ToString();
                Application["n"] = name;
                mail = Application["mail"].ToString();
                Application["mail"] = mail;
            }
            catch(Exception )
            {
                Response.Redirect("index.aspx");
            }
                SqlDataAdapter da = new SqlDataAdapter("select i.image,ta.*,tc.name as name from tbl_advertisement ta join tbl_customer tc on ta.cid=tc.cid join image i on i.mail=tc.email where ta.allowuser='" + type + "'", con);
                SqlDataAdapter da1 = new SqlDataAdapter("select i.image,ta.*,tc.name as name from tbl_advertisement ta join tbl_customer tc on ta.cid=tc.cid join image i on i.mail=tc.email where ta.allowuser='both'", con);
                DataSet dt = new DataSet();
                da1.Fill(dt);
                da.Fill(dt);
                r1.DataSource = dt;
                r1.DataBind();

        }
    }
}