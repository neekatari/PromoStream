using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;
namespace final
{
    public partial class profile : System.Web.UI.Page
    {
       SqlConnection con;
        String email,name;
        int cnt = 0;
        String path;
        String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
        String id = null;
        String type = null;
        protected void update_Click(object sender, EventArgs e)
        {
            Response.Redirect("updateinfo.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection(connect);
            email = Application["mail"].ToString();
            name = Application["name"].ToString();
            type = Application["t"].ToString();

          //  Image1.ImageUrl = "C:/Users/Neel/source/repos/final/final/images/vector.jpg";
            SqlCommand dada = new SqlCommand("select count(*) from tbl_profile where prid='" + email + "'",con);
            con.Open();
            cnt=dada.ExecuteNonQuery();
            con.Close();

            String s1 = "select image from image where mail='" + email + "' ";
            SqlCommand cmd1 = new SqlCommand(s1, con);
            con.Open();
            SqlDataReader sd = cmd1.ExecuteReader();
             while (sd.Read())
             {
                 Image1.ImageUrl = sd["image"].ToString();
             }
           

            con.Close();
            SqlCommand cmdd;
            SqlDataReader sdr;
            if (type == "photographer")
            {
                cmdd = new SqlCommand("select * from tbl_photographer where email='" + email + "' ", con);
                con.Open();
                sdr = cmdd.ExecuteReader();
                {
                    while (sdr.Read())
                    {
                        lblname.Visible = true;
                        lblemail.Visible = true;
                        lblcontact.Visible = true;
                        lblgender.Visible = true;
                        lbladdress.Visible = true;
                        lblage.Visible = true;
                        sub.Visible = true;
                        lblhei.Visible = false;
                        lblname.Text = sdr["name"].ToString();
                        lblemail.Text = sdr["email"].ToString();
                        lblcontact.Text = sdr["contactno"].ToString();
                        lblgender.Text = sdr["gender"].ToString();
                        lbladdress.Text = sdr["address"].ToString();
                        lblage.Text = sdr["age"].ToString();
                        if (sdr["qualification"] != null)
                        {

                            lblquali.Text = sdr["qualification"].ToString();
                        }
                        else
                        {
                            lblquali.Text = "-";
                        }
                        String i = sdr["subid"].ToString(); int pid = Convert.ToUInt16(i);
                        if (pid == 1)
                        {
                            sub.Text = "fashion";
                        }
                        else if (pid == 2)
                        {
                            sub.Text = "event";
                        }
                        else if (pid == 3)
                        {
                            sub.Text = "sports";
                        }
                        else if (pid == 4)
                        {
                            sub.Text = "wildlife";
                        }
                    }

                    Session["n"] = lblname.Text;
                    Session["e"] = lblemail.Text;
                    Session["c"] = lblcontact.Text;
                    Session["a"] = lbladdress.Text;
                    Session["ag"] = lblage.Text;
                    Session["s"] = sub.Text;
                    Session["q"] = lblquali.Text;
                    Session["g"] = lblgender.Text;
                }
                con.Close();




                






            }
            else if (type == "model")
            {
                cmdd = new SqlCommand("select * from tbl_model where email='" + email + "' ", con);
                con.Open();
                sdr = cmdd.ExecuteReader();
                {
                    while (sdr.Read())
                    {
                        lblname.Visible = true;
                        lblemail.Visible = true;
                        lblcontact.Visible = true;
                        lblgender.Visible = true;
                        lbladdress.Visible = true;
                        lblage.Visible = true;
                        height.Visible = true;
                        lblsun.Visible = false;
                        lblname.Text = sdr["name"].ToString();
                        lblemail.Text = sdr["email"].ToString();
                        lblcontact.Text = sdr["contactno"].ToString();
                        lblgender.Text = sdr["gender"].ToString();
                        lbladdress.Text = sdr["address"].ToString();
                        lblage.Text = sdr["age"].ToString();
                        height.Text = sdr["height"].ToString();
                        lblquali.Text = sdr["qualification"].ToString();



                    }
                    Session["n"] = lblname.Text;
                    Session["e"] = lblemail.Text;
                    Session["c"] = lblcontact.Text;
                    Session["a"] = lbladdress.Text;
                    Session["ag"] = lblage.Text;
                    Session["h"] = height.Text;
                    Session["q"] = lblquali.Text;
                    Session["g"] = lblgender.Text;
                }
                con.Close();
            }
            else if (type == "customer")
            {

                cmdd = new SqlCommand("select * from tbl_customer where email='" + email + "' ", con);
                con.Open();
                sdr = cmdd.ExecuteReader();
                {
                    while (sdr.Read())
                    {
                        lblname.Visible = true;
                        lblemail.Visible = true;
                        lblcontact.Visible = true;
                        lblgender.Visible = true;
                        lbladdress.Visible = true;
                        lblage.Visible = true;
                        height.Visible = false;
                        lblsun.Visible = false;
                        lblname.Text = sdr["name"].ToString();
                        lblemail.Text = sdr["email"].ToString();
                        lblcontact.Text = sdr["contactno"].ToString();
                        lblgender.Text = sdr["gender"].ToString();
                        lbladdress.Text = sdr["address"].ToString();
                        lblage.Text = sdr["age"].ToString();
                        lblquali.Text = sdr["qualification"].ToString();
                        lblhei.Visible = false;
                        sub.Visible = false;
                    }
                    Session["n"] = lblname.Text;
                    Session["e"] = lblemail.Text;
                    Session["c"] = lblcontact.Text;
                    Session["a"] = lbladdress.Text;
                    Session["ag"] = lblage.Text;
                    
                    Session["q"] = lblquali.Text;
                    Session["g"] = lblgender.Text;
                    con.Close();

                }
                
            }
                id = Application["mail"].ToString();
                type = Application["t"].ToString();
                int uid = 0;
                SqlDataAdapter dds = new SqlDataAdapter("select * from tbl_" + type + " where email = '" + id + "' ", con);
                DataTable dt = new DataTable();
                dds.Fill(dt);
                uid = Convert.ToInt32(dt.Rows[0][0].ToString());
                String ss = "select * from tbl_post where uploder_id=" + uid + " and isDelete='f' order by pid desc";
                SqlDataAdapter ddd = new SqlDataAdapter(ss, con);
                DataTable ds = new DataTable();
                ddd.Fill(ds);
                //postid = Convert.ToInt32(ds.Rows[0][0].ToString());
                rpost.DataSource = ds;
                rpost.DataBind();
        }

        protected void btndis_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                String ext = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (ext.ToLower() != ".jpeg" && ext.ToLower() != ".jpg" && ext.ToLower() != ".png")
                {
                    Page.RegisterStartupScript("UserMsg", "<script>alert('Invalid File Extension  ..!');</script>");
                }
                else
                {
                    String filename = FileUpload1.FileName.ToString();
                    String uploadpath = "~/img/";
                    String filepath = HttpContext.Current.Server.MapPath(uploadpath);
                    FileUpload1.SaveAs(filepath + "\\" + filename);
                    path = "~/img/" + FileUpload1.FileName.ToString();


                    Image1.ImageUrl = path;
                    // String s = "insert into image (image,mail) values ('" + path + "','" + email + "')";
                    String s = "update image set image = '" + path + "' where mail = '" + email + "' ";
                    SqlCommand cmd = new SqlCommand(s, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    String s1 = "select image from image where image='" + path + "' ";
                    SqlCommand cmd1 = new SqlCommand(s, con);
                    con.Open();
                    SqlDataReader sd = cmd1.ExecuteReader();

                    while (sd.Read())
                    {
                        Image1.ImageUrl = sd["image"].ToString();
                    }
                }

            }
        }
    }
}