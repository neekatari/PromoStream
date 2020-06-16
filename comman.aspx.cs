using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;

namespace final
{
    public partial class comman : System.Web.UI.Page
    {
        String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
        SqlCommand cmd;
        int pid = 0,cid=0, ty = 0,nccid=0;
        protected void Page_Load(object sender, EventArgs e)
        {
          


                String m = Session["pumail"].ToString();
                SqlConnection con = new SqlConnection(connect);
                String s = "select image from image where mail = '" + m + "' ";
                SqlDataAdapter profile = new SqlDataAdapter(s, con);
                DataTable ds = new DataTable();
                profile.Fill(ds);
                String p = ds.Rows[0][0].ToString();

                imgcp.ImageUrl = p;

                SqlDataAdapter pho = new SqlDataAdapter("select count(*) from tbl_photographer where email = '" + m + "' ", con);
                SqlDataAdapter mod = new SqlDataAdapter("select count(*) from tbl_model where email = '" + m + "' ", con);
                SqlDataAdapter cus = new SqlDataAdapter("select count(*) from tbl_customer where email = '" + m + "' ", con);
                DataTable dtp = new DataTable();
                DataTable dtm = new DataTable();
                DataTable dtc = new DataTable();
                pho.Fill(dtp);
                mod.Fill(dtm);
                cus.Fill(dtc);

                if (dtp.Rows[0][0].ToString() == "1")
                {
                    cmd = new SqlCommand("select * from tbl_photographer where email='" + m + "' ", con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        Name.Text = sdr["name"].ToString();
                        Add.Text = sdr["address"].ToString();
                        cont.Text = sdr["contactno"].ToString();
                        email.Text = sdr["email"].ToString();
                        gender.Text = sdr["gender"].ToString();
                        age.Text = sdr["age"].ToString();
                        quali.Text = sdr["qualification"].ToString();
                        type.Visible = true;
                        lbltype.Visible = true;

                        String i = sdr["subid"].ToString(); int pid = Convert.ToUInt16(i);
                        if (pid == 1)
                        {
                            type.Text = "fashion";
                        }
                        else if (pid == 2)
                        {
                            type.Text = "event";
                        }
                        else if (pid == 3)
                        {
                            type.Text = "sports";
                        }
                        else if (pid == 4)
                        {
                            type.Text = "wildlife";
                        }

                    }
                    con.Close();


                    int uid = 0;
                    SqlDataAdapter dds = new SqlDataAdapter("select * from tbl_photographer where email = '" + m + "' ", con);
                    DataTable dt = new DataTable();
                    dds.Fill(dt);
                    uid = Convert.ToInt32(dt.Rows[0][0].ToString());
                    String ss = "select * from tbl_post where uploder_id=" + uid + " and isDelete='f' order by pid desc";
                    SqlDataAdapter ddd = new SqlDataAdapter(ss, con);
                    DataTable ds1 = new DataTable();
                    ddd.Fill(ds1);
                    //postid = Convert.ToInt32(ds.Rows[0][0].ToString());
                    rpost.DataSource = ds1;
                    rpost.DataBind();





                }
                else if (dtm.Rows[0][0].ToString() == "1")
                {
                    cmd = new SqlCommand("select * from tbl_model where email='" + m + "' ", con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Name.Text = sdr["name"].ToString();
                        Add.Text = sdr["address"].ToString();
                        cont.Text = sdr["contactno"].ToString();
                        email.Text = sdr["email"].ToString();
                        gender.Text = sdr["gender"].ToString();
                        age.Text = sdr["age"].ToString();
                        quali.Text = sdr["qualification"].ToString();
                        txthei.Visible = true;
                        lblhei.Visible = true;
                        txthei.Text = sdr["height"].ToString();
                    }
                    con.Close();
                    int uid = 0;
                    SqlDataAdapter dds = new SqlDataAdapter("select * from tbl_model where email = '" + m + "' ", con);
                    DataTable dt = new DataTable();
                    dds.Fill(dt);
                    uid = Convert.ToInt32(dt.Rows[0][0].ToString());
                    String ss = "select * from tbl_post where uploder_id=" + uid + " and isDelete='f' order by pid desc";
                    SqlDataAdapter ddd = new SqlDataAdapter(ss, con);
                    DataTable ds1 = new DataTable();
                    ddd.Fill(ds1);
                    //postid = Convert.ToInt32(ds.Rows[0][0].ToString());
                    rpost.DataSource = ds1;
                    rpost.DataBind();
                }
                else if (dtc.Rows[0][0].ToString() == "1")
                {
                    cmd = new SqlCommand("select * from tbl_customer where email='" + m + "' ", con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Name.Text = sdr["name"].ToString();
                        Add.Text = sdr["address"].ToString();
                        cont.Text = sdr["contactno"].ToString();
                        email.Text = sdr["email"].ToString();
                        gender.Text = sdr["gender"].ToString();
                        age.Text = sdr["age"].ToString();
                        quali.Text = sdr["qualification"].ToString();
                        txthei.Visible = false;
                        btnallow.Visible = false;
                    }
                    con.Close();
                    int uid = 0;
                    SqlDataAdapter dds = new SqlDataAdapter("select * from tbl_customer where email = '" + m + "' ", con);
                    DataTable dt = new DataTable();
                    dds.Fill(dt);
                    uid = Convert.ToInt32(dt.Rows[0][0].ToString());
                    String ss = "select * from tbl_post where uploder_id=" + uid + " and isDelete='f' order by pid desc";
                    SqlDataAdapter ddd = new SqlDataAdapter(ss, con);
                    DataTable ds1 = new DataTable();
                    ddd.Fill(ds1);
                    //postid = Convert.ToInt32(ds.Rows[0][0].ToString());
                    rpost.DataSource = ds1;
                    rpost.DataBind();
                }
            
         }

        protected void btnallow_Click(object sender, EventArgs e)
        {
            if(btnallow.Text=="Allow")
            {
                btnallow.Text = "Allowed";
                

                String m = email.Text;
                SqlConnection con = new SqlConnection(connect);
                SqlDataAdapter pho = new SqlDataAdapter("select count(*) from tbl_photographer where email = '" + m + "' ", con);
                SqlDataAdapter mod = new SqlDataAdapter("select count(*) from tbl_model where email = '" + m + "' ", con);
                SqlDataAdapter cus = new SqlDataAdapter("select * from tbl_customer where email = '" + Application["mail"].ToString()+ "' ", con);

                DataTable dtp = new DataTable();
                DataTable dtm = new DataTable();
                DataTable dtc = new DataTable();

                pho.Fill(dtp);
                mod.Fill(dtm);
                cus.Fill(dtc);

                cid = Convert.ToInt32( dtc.Rows[0][0].ToString());


                if (dtp.Rows[0][0].ToString() == "1")
                {
                    cmd = new SqlCommand("select * from tbl_photographer where email='" + m + "' ", con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                         ty = 1;
                         pid = Convert.ToInt32(sdr["pid"].ToString());
                    }
                    con.Close();
                }
                else if (dtm.Rows[0][0].ToString() == "1")
                {
                    cmd = new SqlCommand("select * from tbl_model where email='" + m + "' ", con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                         pid = Convert.ToInt32(sdr["fid"].ToString());
                         ty = 2;
                    }
                    con.Close();
                }
                else
                {
                     ty = 0;
                }

                int addid = Convert.ToInt32( Session["addid"].ToString());
                int notid = Convert.ToInt32(Session["notification"].ToString());

                //String s = "insert into tbl_notification (notify_for,notify_by,ads_id,updated,created,isActive,type ) values ("+cid+","+pid+","+addid+ ",GETDATE(),GETDATE(),'f', "+ty+")  ";
                String s= "update tbl_notification set isActive='f' where nid="+notid+" ";
                SqlCommand contract = new SqlCommand(s, con);
                con.Open();
                contract.ExecuteNonQuery();
                con.Close();
                String title = "select post_title from tbl_advertisement where aid = "+addid+" ";
                SqlDataAdapter ss = new SqlDataAdapter(title,con);
                DataTable dtpt = new DataTable();
                ss.Fill(dtpt);
                String ti = dtpt.Rows[0][0].ToString();
                String cont  = "insert into tbl_contract (title,gen_by,gen_for,ad_id,isActive,created,updated ) values ('"+ti+"',"+cid+","+pid+","+addid+ ",'t',GETDATE(),GETDATE() ) ";
                con.Close();
                SqlCommand cmcon = new SqlCommand(cont, con);
                con.Open();
                cmcon.ExecuteNonQuery();
                con.Close();
                SqlCommand ciid = new SqlCommand( "select ncid from tbl_contract where gen_by = " + cid + " ",con);
                con.Open();
                SqlDataReader ssr = ciid.ExecuteReader();
                while(ssr.Read())
                {
                    nccid = Convert.ToInt32( ssr["ncid"].ToString());
                }

                con.Close();
                string work = "insert into tbl_work (con_id,work_for,type,updated,isActive,created) values (" + nccid + ","+pid+", "+ ty + ",GETDATE(),'t',GETDATE() ) ";
                
                SqlCommand cmwo = new SqlCommand(work,con);

                con.Open();
                
                cmwo.ExecuteNonQuery();
               
                con.Close();



                //sending mail
                string ctmailtitle = null;
                SqlCommand cmail = new SqlCommand("select title from tbl_contract where ad_id="+addid+"",con);
                con.Open();
                SqlDataReader rrr = cmail.ExecuteReader();
                while (rrr.Read())
                {
                    ctmailtitle = rrr["title"].ToString();
                }
                con.Close();
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.To.Add(email.Text);
                mail.From = new MailAddress("promostream.pvt@gmail.com", "Email head", System.Text.Encoding.UTF8);
                mail.Subject = "Congratulations Contract Established..!";
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = Application["name"].ToString()+" Accepted Your Request on "+ctmailtitle+".";
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("promostream.pvt@gmail.com", "jaba$baje");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                try
                {

                    client.Send(mail);
                    Page.RegisterStartupScript("UserMsg", "<script>alert('Successfully Send...');if(alert){ window.location='notification.aspx';}</script>");

                }
                catch (Exception ex)
                {
                    Exception ex2 = ex;
                    string errorMessage = string.Empty;
                    while (ex2 != null)
                    {
                        errorMessage += ex2.ToString();
                        ex2 = ex2.InnerException;
                    }
                    Page.RegisterStartupScript("UserMsg", "<script>alert('Sending Failed...');if(alert){ window.location='notification.aspx';}</script>");
                }










            }
            else
            {
                int notid = Convert.ToInt32(Session["notification"].ToString());
                String s = "update tbl_notification set isActive='t' where nid=" + notid + " ";
                SqlConnection con = new SqlConnection(connect);
                SqlCommand contract = new SqlCommand(s, con);
                con.Open();
                contract.ExecuteNonQuery();


                /*int id=0;
                SqlConnection con = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand("select nid from tbl_notification",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    id = Convert.ToInt32(dr["nid"]);
                }
                con.Close();
                SqlCommand cmf = new SqlCommand("delete from tbl_notification where nid=" + id + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();*/
                btnallow.Text = "Allow";
            }
        }
    }
}