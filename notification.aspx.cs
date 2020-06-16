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
    public partial class notification : System.Web.UI.Page
    {
        int cidd = 0, addid=0,custid=0;
        protected void Page_Load(object sender, EventArgs e)
        {

            String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand();
           
                cmd = new SqlCommand("select cid from tbl_customer where email='" + Application["mail"].ToString() + "' ", con);
                int id = 0;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    id = sdr.GetInt32(0);
                }

                con.Close();





                SqlDataAdapter da1 = new SqlDataAdapter("select i.image,ta.post_title,tm.email as mail,ta.aid as adsid,tn.nid as notid  from tbl_advertisement ta join  tbl_notification tn on ta.aid=tn.ads_id join tbl_model tm on tm.fid=tn.notify_by join image i on i.mail=tm.email  where tn.notify_for=" + id + " and tn.type=2   ", con);
                SqlDataAdapter da2 = new SqlDataAdapter("select i.image,ta.post_title,tp.email as mail,ta.aid as adsid,tn.nid as notid from tbl_advertisement ta join  tbl_notification tn on ta.aid=tn.ads_id join tbl_photographer tp on tp.pid=tn.notify_by join image i on i.mail=tp.email where tn.notify_for=" + id + " and tn.type=1  ", con);
                DataSet dt = new DataSet();
                da1.Fill(dt);
                da2.Fill(dt);
                r2.DataSource = dt;
                r2.DataBind();

         
           

               SqlCommand c = new SqlCommand("select * from tbl_" + Application["t"].ToString() + " where email='" + Application["mail"].ToString() + "'  ", con);

                SqlDataAdapter sd = new SqlDataAdapter(c);
                DataTable dtrr = new DataTable();
                sd.Fill(dtrr);
                cidd = Convert.ToInt32(dtrr.Rows[0][0].ToString());
            /*SqlDataAdapter addsid = new SqlDataAdapter("select aid from tbl_advertisement where cid= "+cidd+" ",con);
            DataTable dtad = new DataTable();
            addsid.Fill(dtad);
            addid = Convert.ToInt32(dtad.Rows[0][0].ToString()); */

            /* if(Application["t"].ToString() != "customer") { 
             if (!this.IsPostBack)
             {

                 SqlDataAdapter cut = new SqlDataAdapter("select cid  from tbl_customer where cid = (select notify_for from tbl_notification where notify_by = " + cidd + "  ) ", con);
                 DataTable dtr1 = new DataTable();
                 cut.Fill(dtr1);
                 custid = Convert.ToInt32(dtr1.Rows[0][0].ToString());

                 SqlDataAdapter addsid = new SqlDataAdapter("select aid from tbl_advertisement where cid= " + custid + " ", con);
                 DataTable dtad = new DataTable();
                 addsid.Fill(dtad);
                 addid = Convert.ToInt32(dtad.Rows[0][0].ToString());

                 SqlDataAdapter cuta = new SqlDataAdapter("select email as mail from tbl_customer where cid = (select notify_for from tbl_notification where notify_by = " + cidd + " and  ads_id = "+addid+"  ) ", con);
                 DataTable dtr = new DataTable();
                 cuta.Fill(dtr);
                 r.DataSource = dtr;
                 r.DataBind();
             }

             }*/


            //String cmail =  dtr.Rows[0][0].ToString();



        }

        protected void mail_Click(object sender, EventArgs e)
        {

            LinkButton btn1 = (LinkButton)sender;
            RepeaterItem it1 = (RepeaterItem)btn1.NamingContainer;
            HiddenField id1 = (HiddenField)it1.FindControl("adid");
            String i = Convert.ToString(id1.Value);
            Session["addid"] = i;

            LinkButton btn = (LinkButton)sender;
            RepeaterItem it = (RepeaterItem)btn.NamingContainer;
            HiddenField id = (HiddenField)it.FindControl("hidemail");
            String l = Convert.ToString(id.Value);
            Session["pumail"]=l;

            LinkButton btn2= (LinkButton)sender;
            RepeaterItem it2 = (RepeaterItem)btn2.NamingContainer;
            HiddenField id2 = (HiddenField)it2.FindControl("nid");
            int n = Convert.ToInt32(id2.Value);
            Session["notification"] = n;


            Response.Redirect("comman.aspx");            
        }

        protected void m_Click(object sender, EventArgs e)
        {
            LinkButton btn3 = (LinkButton)sender;
            RepeaterItem it3 = (RepeaterItem)btn3.NamingContainer;
            HiddenField id3 = (HiddenField)it3.FindControl("cmail");
            String  m = Convert.ToString(id3.Value);
            Session["pumail"] = m;
            Session["msg"] = "Congratulation";
            Response.Redirect("comman.aspx");
        }
    }
}