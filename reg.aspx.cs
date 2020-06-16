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
    public partial class reg : System.Web.UI.Page
    {
        static String activationcode;
        protected void Page_Load(object sender, EventArgs e)
        {
            dtype.Visible = false;
            if (Page.IsPostBack)
                return;

            String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            String str ="select * from sub_photographer" ;
            SqlDataAdapter sda = new SqlDataAdapter(str,con);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            foreach (DataRow row in ds.Rows)
            {
                dtype.Items.Add(row["type"].ToString());
            }
        }

        protected void listcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*  if (listcategory.SelectedIndex == 1)
              {
                  txttype.Visible = true;
              }*/

            String a = listcategory.SelectedValue.ToString();
            
            if (a == "photographer")
            {
                dtype.Visible = true;
                txtheight.Visible = false;
            }
            
            if (a == "model")
            {
                txtheight.Visible = true;
                dtype.Visible = false;

            }
            if (a == "customer")
            {
                txtheight.Visible = false;
                dtype.Visible = false;
            }
            if (a == "select")
            {
                txtheight.Visible = false;
                dtype.Visible = false;
            }

        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
            SqlConnection con = new SqlConnection(connect);
            SqlDataAdapter customer = new SqlDataAdapter("select count(*) from tbl_customer where email= '" + txtmail.Text + "'", con);
            SqlDataAdapter photographer = new SqlDataAdapter("select count(*)  from tbl_photographer where email= '" + txtmail.Text + "' ", con);
            SqlDataAdapter model = new SqlDataAdapter("select count(*)  from tbl_model where email= '" + txtmail.Text + "'", con);

            DataTable cust = new DataTable();
            DataTable photo = new DataTable();
            DataTable mod = new DataTable();

            customer.Fill(cust);
            photographer.Fill(photo);
            model.Fill(mod);

            if (cust.Rows[0][0].ToString() == "1" || photo.Rows[0][0].ToString() == "1" || mod.Rows[0][0].ToString() == "1")
            {
                error.Visible = true;
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('This E-mail Is Already Registered.Please Use Another One..! ')", true);
            }
            else
            {

                /*SqlCommand cmdd = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                cmdd = new SqlCommand("delete from varification",con);
                con.Open();
                cmdd.ExecuteNonQuery();
                con.Close();*/
                String s = "insert into tbl_profile (prid ,type) values ('" + txtmail.Text + "','" + dtype.Text + "' )";
                SqlCommand cmd2 = new SqlCommand(s, con);
                con.Open();

                cmd2.ExecuteNonQuery();

                con.Close();

                Random random = new Random();
                activationcode = random.Next(100001, 999999).ToString();
                String query = "insert into varification values('" + txtname + "','" + txtmail.Text + "','Unverified','" + activationcode + "')";


                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                sendcode();
                int jaba = 0;
                if (jaba == 0)
                {
                    Application["name"] = txtname.Text;
                    Application["address"] = txtaddress.Text;
                    Application["gender"] = GEnder.Text;
                    Application["con"] = txtcontact.Text;
                    Application["height"] = txtheight.Text;
                    Application["type"] = dtype.Text;
                    Application["cate"] = listcategory.Text;
                    Application["qualification"] = txtquali.Text;
                    Application["mail"] = txtmail.Text;
                    Application["password"] = txtpass.Text;
                    Application["age"] = txtage.Text;
                    jaba = 1;
                }
                if (jaba == 1)
                {

                    Response.Redirect("varification.aspx?emailid=" + txtmail.Text);

                }

            }
        }

        private void sendcode()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("promostream.pvt@gmail.com", "jaba$baje");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "Activation code Verification by Promostream";
            msg.Body = "Dear" + txtname.Text + " , Your Activation Code is " + activationcode + "\n\n\n\nThanks & Regards\nPromostram.pvt";
            string toaddress = txtmail.Text;
            msg.To.Add(toaddress);
            string fromaddress = "P R O M O S T R E A M <promostream.pvt@gmail.com>";
            msg.From = new MailAddress(fromaddress);
            try
            {
                smtp.Send(msg);
            }
            catch(Exception e)
            {
                throw   e;
            }
        }
       
    }
}