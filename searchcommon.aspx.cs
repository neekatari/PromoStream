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
    public partial class searchcommon : System.Web.UI.Page
    {
        String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
        SqlCommand cmd;
        int pid = 0, cid = 0, ty = 0, nccid = 0;
        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {
                String m = Session["mm"].ToString();
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
            catch
            {
                Response.Redirect("Default.aspx");
            }
        }

    }
}