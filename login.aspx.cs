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
    public partial class login : System.Web.UI.Page
    {
        String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
        SqlConnection con;
        int i = 0, j = 0, p = 0, m = 0, n = 0, h = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           try { 
            if(!this.IsPostBack)
                {
                    Session.Abandon();
                    
                }
            }
            catch(Exception)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            //int d = 0;
            con = new SqlConnection(connect);
            if (txtuname.Text.Equals("Vision") || txtpass.Text.Equals("neekneel") )
            {
               
                Response.Redirect("Admin.aspx");
            }
            else
            {


               
                    SqlCommand cmd2 = new SqlCommand(" select count(*) as fp from tbl_photographer where email='" + txtuname.Text + "' and password='" + txtpass.Text + "' ", con);
                    SqlCommand cmd = new SqlCommand("select count(*) as fb from tbl_model where email='" + txtuname.Text + "' and password='" + txtpass.Text + "'  ", con);
                    SqlCommand cmd1 = new SqlCommand(" select count(*) as fc from tbl_customer where email='" + txtuname.Text + "' and password='" + txtpass.Text + "' ", con);

                    SqlDataAdapter sd2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sd1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();

                    sd2.Fill(dt2);
                    sd.Fill(dt);
                    sd1.Fill(dt1);
                    con.Open();
                  m=  cmd2.ExecuteNonQuery();
                   n= cmd.ExecuteNonQuery();
                   h= cmd1.ExecuteNonQuery();

                if (m > 0 || n > 0)
                {
                    Response.Redirect("stream.aspx");
                }
                else if(h>0)
                {
                    Response.Redirect("chome.aspx");
                }
                else
                {
                    Page.RegisterStartupScript("UserMsg", "<script>alert('Faild');</script>");
                    
                }


                    SqlCommand cmd22 = new SqlCommand(" select name from tbl_photographer where email='" + txtuname.Text + "' and password='" + txtpass.Text + "' and isDeactive='f' ", con);
                    SqlCommand cmdd = new SqlCommand("select name from tbl_model where email='" + txtuname.Text + "' and password='" + txtpass.Text + "' and isDeactive='f'  ", con);
                    SqlCommand cmd11 = new SqlCommand(" select name from tbl_customer where email='" + txtuname.Text + "' and password='" + txtpass.Text + "' and isDeactive='f' ", con);

                    SqlDataAdapter sd22 = new SqlDataAdapter(cmd22);
                    DataTable dt22 = new DataTable();
                    SqlDataAdapter sdd = new SqlDataAdapter(cmdd);
                    DataTable dtt = new DataTable();
                    SqlDataAdapter sd11 = new SqlDataAdapter(cmd11);
                    DataTable dt11 = new DataTable();

                    sd22.Fill(dt22);
                    sdd.Fill(dtt);
                    sd11.Fill(dt11);

                    i = cmd22.ExecuteNonQuery();
                    j = cmdd.ExecuteNonQuery();
                    p = cmd11.ExecuteNonQuery();



                    con.Close();

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Application["mail"] = txtuname.Text;
                        Application["t"] = "model";
                        Application["name"] = dtt.Rows[0][0].ToString();
                    }
                    if (dt1.Rows[0][0].ToString() == "1")
                    {
                        Application["mail"] = txtuname.Text;
                        Application["t"] = "customer";
                        Application["name"] = dt11.Rows[0][0].ToString();
                    }
                    if (dt2.Rows[0][0].ToString() == "1")
                    {
                        Application["mail"] = txtuname.Text;
                        Application["t"] = "photographer";
                        Application["name"] = dt22.Rows[0][0].ToString();
                    }

                    if (i > 0 || j>0 || p > 0) { 
                    SqlCommand ccd = new SqlCommand("update tbl_" + Application["t"].ToString() + " set updated=GetDate() where email='" + Application["mail"].ToString() + "'", con);

                    con.Open();
                    ccd.ExecuteNonQuery();
                    con.Close();
                       
                    }
                    else
                    {
                         Page.RegisterStartupScript("UserMsg", "<script>alert('Faild');</script>");
                        lblmsg.Visible = true;
                    }

                    if (dt.Rows[0][0].ToString() == "1" || dt2.Rows[0][0].ToString() == "1")
                    {

                        Response.Redirect("stream.aspx");
                    }
                    else if (dt1.Rows[0][0].ToString() == "1")
                    {
                        Response.Redirect("chome.aspx");
                    }
                    else
                    {
                           Page.RegisterStartupScript("UserMsg", "<script>alert('Faild');</script>");
                          
                        
                    }
                
               
            }
        }
    }
}