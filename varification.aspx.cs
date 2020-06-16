using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace final
{
    public partial class varification : System.Web.UI.Page
    {
        String name, add, gen, contact, height, type, cate, quali, mail, pass, a;
        int ag=0,h=0;
        long c=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Check Your mail : " + Request.QueryString["emailid"].ToString();
            String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand();


             name = Application["name"].ToString();
             add = Application["address"].ToString();
             gen = Application["gender"].ToString();
             contact = Application["con"].ToString();
             height = Application["height"].ToString();
             type = Application["type"].ToString();
             cate = Application["cate"].ToString();
             quali = Application["qualification"].ToString();
             mail = Application["mail"].ToString();
             pass = Application["password"].ToString();
             a = Application["age"].ToString();

             ag = Convert.ToInt32(a);
           
             c = Convert.ToInt64(contact);
            
        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
            String query = "select * from varification where emailaddress='"+Request.QueryString["emailid"]+"'";
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                String activationcode;
                activationcode = ds.Tables[0].Rows[0]["activationcode"].ToString();
                if(activationcode == txtotp.Text)
                {


                    SqlCommand cmd1 = new SqlCommand();
                    int subid = 0;

                    SqlDataAdapter sd1 = new SqlDataAdapter("select sid  from sub_photographer where type = '" + type + "' ", con);
                    DataTable dt = new DataTable();
                    sd1.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        subid = Convert.ToInt32(row["sid"]);
                    }

                    if (cate == "photographer")
                    {
                        String qu = "insert into tbl_photographer (name,email,contactno,gender,address,age,subid,password,qualification,isDeactive,created,updated ) values('" + name + "','" + mail + "'," + contact + ",'" + gen + "','" + add + "'," + ag + "," + subid + ",'" + pass + "','" + quali + "','f',GETDATE(),GETDATE()";
                        con.Open();
                        cmd1.CommandText = qu;
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        Application["n"] = name;
                        Application["t"] = cate;
                        Application["email"] = mail;
                        Application["mail"] = mail;
                        changestatus();
                        con.Close();
                        String p = "~/images/newvector.jpg";    
                        String image_in = "insert into image (image,mail) values ('" + p + "','" + Application["email"].ToString() + "')";
                        SqlCommand ima = new SqlCommand(image_in, con);
                        con.Open();
                        ima.ExecuteNonQuery();
                        con.Close();

                        Response.Redirect("profile.aspx");

                    }
                    else if ( cate == "model")
                    {
                        h = Convert.ToInt32(height);
                        String qu = "insert into tbl_model (name,email,contactno,gender,address,age,height,password,qualification,isDeactive,created,updated) values ('" + name + "','" + mail + "'," + contact + ",'" + gen + "','" + add + "'," + ag + "," + h + ",'" + pass + "','" + quali + "','f',GETDATE(),GETDATE())";
                        con.Open();
                        cmd1.CommandText = qu;
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        Application["n"] = name;
                        Application["t"] = cate;
                        Application["email"] = mail;
                        Application["mail"] = mail;
                        changestatus();
                        con.Close();
                        String p = "~/images/newvector.jpg";
                        String image_in = "insert into image (image,mail) values ('"+p+"','"+ Application["email"] .ToString()+ "')";
                        SqlCommand ima = new SqlCommand(image_in,con);
                        con.Open();
                       ima.ExecuteNonQuery();
                        con.Close();
                
                        Response.Redirect("profile.aspx");
                    }
                    else if(cate == "customer")
                    {
                        String qu = "insert into tbl_customer (name,email,contactno,gender,address,age,password,qualification,isDeactive,created,updated) values ('" + name + "','" + mail + "'," + contact + ",'" + gen + "','" + add + "'," + ag + ",'" + pass + "','" + quali + "','f',GETDATE(),GETDATE())";
                        con.Open();
                        cmd1.CommandText = qu;
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        Application["n"] = name;
                        Application["t"] = cate;
                        Application["email"] = mail;
                        Application["mail"] = mail;
                        changestatus();
                        con.Close();
                        String p = "~/images/newvector.jpg";
                        String image_in = "insert into image (image,mail) values ('" + p + "','" + Application["email"].ToString() + "')";
                        SqlCommand ima = new SqlCommand(image_in, con);
                        con.Open();
                       ima.ExecuteNonQuery();
                        con.Close();
                        Response.Redirect("chome.aspx");
                    }


                    
                }
                else
                {
                    
                    Label2.Text = "Invalid OTP....! please Check your mail Address or OTP.";
                }
            }
            con.Close();

            
        }

        private void changestatus()
        {
            String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
            String updatedata = "Update varification set status='Verified' where emailaddress='" + Request.QueryString["emailid"] + "'";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }

       
    }
}