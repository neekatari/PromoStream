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
    public partial class search : System.Web.UI.Page
    {
        String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            String serv = Session["ser"].ToString();
            if (serv != null)
            {


                con = new SqlConnection(connect);
                SqlCommand cmd2 = new SqlCommand(" select i.image,tp.name,tp.email from tbl_photographer tp join image i on i.mail=tp.email where tp.name='" + Session["ser"].ToString() + "' and  isDeactive='f' ", con);
                SqlCommand cmdd = new SqlCommand("select i.image,tm.name,tm.email from tbl_model tm join image i on i.mail=tm.email where tm.name='" + Session["ser"].ToString() + "' and  isDeactive='f'  ", con);
                SqlCommand cmd1 = new SqlCommand(" select i.image,tc.name,tc.email from tbl_customer tc join image i on i.mail=tc.email where tc.name='" + Session["ser"].ToString() + "'  and isDeactive='f' ", con);
                con.Open();
                cmd2.ExecuteNonQuery();
                cmdd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

                SqlDataAdapter sd2 = new SqlDataAdapter(cmd2);

                SqlDataAdapter sd = new SqlDataAdapter(cmdd);

                SqlDataAdapter sd1 = new SqlDataAdapter(cmd1);
                DataSet dt1 = new DataSet();

                sd2.Fill(dt1);
                sd.Fill(dt1);
                sd1.Fill(dt1);
                ser.DataSource = dt1;
                ser.DataBind();
            }
            else
            {

            }


        }

        protected void mail_Click(object sender, EventArgs e)
        {
            LinkButton btn3 = (LinkButton)sender;
            RepeaterItem it3 = (RepeaterItem)btn3.NamingContainer;
            HiddenField id3 = (HiddenField)it3.FindControl("cmail");
            String my = Convert.ToString(id3.Value);
           
            Session["mm"] = my;
            Response.Redirect("searchcommon.aspx");
        }
    }
}