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
    public partial class U_uploadPost : System.Web.UI.Page
    {
        String path;
        int typ = 0;
        int uid = 0;
        int postid = 0;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
                String id = Application["mail"].ToString();
                String type = Application["t"].ToString();

                SqlDataAdapter sd = new SqlDataAdapter("select * from tbl_" + type + " where email = '" + id + "' ", con);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                uid = Convert.ToInt32(dt.Rows[0][0].ToString());
                String ss = "select * from tbl_post where uploder_id=" + uid + " and isDelete='f' order by pid desc";
                SqlDataAdapter ddd = new SqlDataAdapter(ss, con);
                DataTable ds = new DataTable();
                ddd.Fill(ds);
                //postid = Convert.ToInt32(ds.Rows[0][0].ToString());
                rpost.DataSource = ds;
                rpost.DataBind();
           
           
         
        }

        protected void upload_Click(object sender, EventArgs e)
        {
            String id = Application["mail"].ToString();
            String type = Application["t"].ToString();
            
                SqlDataAdapter sd = new SqlDataAdapter("select * from tbl_"+type+" where email = '"+id+"' ",con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
             uid = Convert.ToInt32(dt.Rows[0][0].ToString() );
            
            if(type == "photographer")
            {
                 typ =  1;
            }
            if (type == "model")
            {
                typ = 2;
            }
            if (type == "customer")
            {
                 typ = 0;
            }
            if (FileUpload1.HasFile )
            {
                String ext = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (ext.ToLower() != ".jpeg" && ext.ToLower() != ".jpg")
                {
                    Page.RegisterStartupScript("UserMsg", "<script>alert('Invalid File Extension  ..!');</script>");
                }
                else
                {
                    String file = FileUpload1.FileName.ToString();
                    String uploadpath = "~/userpost/";
                    String filepath = HttpContext.Current.Server.MapPath(uploadpath);
                    FileUpload1.SaveAs(filepath + "\\" + file);
                    path = "~/userpost/" + FileUpload1.FileName.ToString();
                    DateTime date = DateTime.Now;
                    String s = "insert into tbl_post (post_desc,post_img,uploder_id,type,created,updated,isDelete) values('" + txtdesc.Text + "','" + path + "'," + uid + "," + typ + ",GETDATE(),GETDATE(),'f')";
                    SqlCommand cmd = new SqlCommand("insert into tbl_post(post_desc, post_img, uploder_id, type, created, updated, isDelete) values('" + txtdesc.Text + "', '" + path + "', " + uid + ", " + typ + ",GETDATE(),GETDATE(), 'f')", con);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    //con.Close();
                    if (i > 0)
                    {
                        String ss = "select * from tbl_post where uploder_id=" + uid + " and isDelete='f' order by pid desc ";
                        SqlDataAdapter ddd = new SqlDataAdapter(ss, con);
                        DataSet ds = new DataSet();
                        ddd.Fill(ds);
                        rpost.DataSource = ds;
                        rpost.DataBind();
                    }

                }
           
            }
        }

        protected void edit_Click(object sender, EventArgs e)
        {
           // con = new SqlConnection(connect);
            LinkButton btn = (LinkButton)sender;
            RepeaterItem it = (RepeaterItem)btn.NamingContainer;
            HiddenField id = (HiddenField)it.FindControl("id");
            int pid = int.Parse(id.Value);
            Session["postid"] = pid;
            
            Response.Redirect("editpost.aspx");
        }
    }
}