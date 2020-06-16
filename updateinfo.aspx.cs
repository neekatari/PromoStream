using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final
{
    public partial class updateinfo : System.Web.UI.Page
    {
        string co = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        int a = 0;
        String t;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                name.Text = Session["n"].ToString();
                Add.Text = Session["a"].ToString();
                age.Text = Session["ag"].ToString();
                quali.Text = Session["q"].ToString();
                gender.Text = Session["g"].ToString();
                email.Text = Session["e"].ToString();
                con.Text = Session["c"].ToString();
                a = Convert.ToInt32(age.Text);
                t = Application["t"].ToString();
                if (t == "photographer")
                {
                    lblhei.Visible = false;
                    lbltype.Visible = true;
                    txthei.Visible = false;
                    sub.Visible = true;
                    sub.Text = Session["s"].ToString();
                }
                else if (t == "model")
                {
                    lblhei.Visible = true;
                    lbltype.Visible = false;
                    sub.Visible = false;
                    txthei.Visible = true;
                    txthei.Text = Session["h"].ToString();
                }
                else if (t == "customer")
                {

                    txthei.Visible = false;
                    sub.Visible = false;
                }
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {

            t = Application["t"].ToString();
            int sid = 0;
            if (t == "photographer")
            {
                if (sub.Text == "fashion")
                {
                    sid = 1;
                }
                if (sub.Text == "event")
                {
                    sid = 2;
                }
                if (sub.Text == "sports")
                {
                    sid = 3;
                }
                if (sub.Text == "wildlife")
                {
                    sid = 4;
                }

                long num = Convert.ToInt64(con.Text);
                int a = Convert.ToInt32(age.Text);
                conn = new SqlConnection(co);
                cmd = new SqlCommand("update tbl_photographer set name='" + name.Text + "',contactno=" + num + ",gender='" + gender.Text + "',address='" + Add.Text + "',age=" + a + ",subid=" + sid + ",qualification='" + quali.Text + "' where email='" + email.Text + "' ", conn);
                conn.Open();
                Application["name"] = name.Text;
                Session["n"] = name.Text;
                Session["e"] = email.Text;
                Session["c"] = con.Text;
                Session["a"] = Add.Text;
                Session["ag"] = age.Text;
                Session["s"] = sub.Text;
                Session["q"] = quali.Text;
                Session["g"] = gender.Text;
                cmd.ExecuteNonQuery();
                Page.RegisterStartupScript("UserMsg", "<script>alert('Information update succesfully..!');if(alert){ window.location='updateinfo.aspx';}</script>");
            }
            if (t == "model")
            {
                int h = Convert.ToInt32(txthei.Text);
                long num = Convert.ToInt64(con.Text);
                conn = new SqlConnection(co);
                conn.Close();
                //int l  = name.Text.Length;
                int a = Convert.ToInt32(age.Text);
                cmd = new SqlCommand("update tbl_model set name='"+name.Text+"',contactno="+num+",gender='"+gender.Text+"',address='"+Add.Text+"',age=" + a + ",height="+h+",qualification='"+quali.Text+"' where email='"+email.Text+"'  ", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                Application["name"] = name.Text;
                Session["n"] = name.Text;
               
                Session["e"] = email.Text;
                Session["c"] = con.Text;
                Session["a"] = Add.Text;
                Session["ag"] = age.Text;
                Session["h"] = txthei.Text;
                Session["q"] = quali.Text;
                Session["g"] = gender.Text;
                Page.RegisterStartupScript("UserMsg", "<script>alert('Information update succesfully..!');if(alert){ window.location='updateinfo.aspx';}</script>");

            }
            if (t == "customer")
            {
                
                long num = Convert.ToInt64(con.Text);
                conn = new SqlConnection(co);
                conn.Close();
                //int l  = name.Text.Length;
                int a = Convert.ToInt32(age.Text);
                cmd = new SqlCommand("update tbl_customer set name='" + name.Text + "',contactno=" + num + ",gender='" + gender.Text + "',address='" + Add.Text + "',age=" + a + ",qualification='" + quali.Text + "' where email='" + email.Text + "'  ", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                Application["name"] = name.Text;
                Session["n"] = name.Text;
                Session["e"] = email.Text;
                Session["c"] = con.Text;
                Session["a"] = Add.Text;
                Session["ag"] = age.Text;

                Session["q"] = quali.Text;
                Session["g"] = gender.Text;
                Page.RegisterStartupScript("UserMsg", "<script>alert('Information update succesfully..!');if(alert){ window.location='updateinfo.aspx';}</script>");

            }
        }
    }
}