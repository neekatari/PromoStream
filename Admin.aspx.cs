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
    public partial class Admin : System.Web.UI.Page
    {
        String connect = "Data Source=DESKTOP-16RB54Q;Initial Catalog=promostream;Integrated Security=True";
        SqlConnection con;
        int total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connect);
            SqlDataAdapter sdd = new SqlDataAdapter("select count(*) from tbl_contract where created =Convert(varchar(10),GETDATE(),120) ",con);
            DataTable dt = new DataTable();
            sdd.Fill(dt);
            totalcontract.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sd = new SqlDataAdapter("select count(*) from tbl_contract ", con);
            DataTable d = new DataTable();
            sd.Fill(d);
            totalcon.Text = d.Rows[0][0].ToString();
            
            SqlDataAdapter dd = new SqlDataAdapter("select count(*) from tbl_photographer where updated=Convert(varchar(10),GETDATE(),120)", con);
            DataTable dt0 = new DataTable();
            dd.Fill(dt0);
            SqlDataAdapter dd1 = new SqlDataAdapter("select count(*) from tbl_customer where updated=Convert(varchar(10),GETDATE(),120)", con);
            DataTable dt1 = new DataTable();
            dd1.Fill(dt1);
            SqlDataAdapter dd2 = new SqlDataAdapter("select count(*) from tbl_model where updated=Convert(varchar(10),GETDATE(),120)", con);
            DataTable dt2 = new DataTable();
            dd2.Fill(dt2);

            total = Convert.ToInt32(dt0.Rows[0][0])+ Convert.ToInt32(dt1.Rows[0][0])+ Convert.ToInt32(dt2.Rows[0][0]);
            totallog.Text = total.ToString();

            int reg = 0;
            SqlDataAdapter d0 = new SqlDataAdapter("select count(*) from tbl_photographer where created=Convert(varchar(10),GETDATE(),120)", con);
            DataTable t0 = new DataTable();
            d0.Fill(t0);
            SqlDataAdapter d1 = new SqlDataAdapter("select count(*) from tbl_customer where created=Convert(varchar(10),GETDATE(),120)", con);
            DataTable t1 = new DataTable();
            d1.Fill(t1);
            SqlDataAdapter d2 = new SqlDataAdapter("select count(*) from tbl_model where created=Convert(varchar(10),GETDATE(),120)", con);
            DataTable t2 = new DataTable();
            d2.Fill(t2);

            reg = Convert.ToInt32(t0.Rows[0][0]) + Convert.ToInt32(t1.Rows[0][0]) + Convert.ToInt32(t2.Rows[0][0]);
            regtotal.Text = reg.ToString();

            SqlDataAdapter tp = new SqlDataAdapter("select count(*) from tbl_photographer ", con);
            DataTable tpc = new DataTable();
            tp.Fill(tpc);
            SqlDataAdapter tc = new SqlDataAdapter("select count(*) from tbl_customer ", con);
            DataTable tcc = new DataTable();
            tc.Fill(tcc);
            SqlDataAdapter tm = new SqlDataAdapter("select count(*) from tbl_model ", con);
            DataTable tmc = new DataTable();
            tm.Fill(tmc);

            photographer.Text = tpc.Rows[0][0].ToString();
            model.Text = tmc.Rows[0][0].ToString();
            customer.Text = tcc.Rows[0][0].ToString();

            
            SqlDataAdapter ppc = new SqlDataAdapter("select count(*) from tbl_photographer ", con);
            DataTable pc = new DataTable();
            ppc.Fill(pc);
            SqlDataAdapter pcc = new SqlDataAdapter("select count(*) from tbl_customer ", con);
            DataTable cc = new DataTable();
            pcc.Fill(cc);
            SqlDataAdapter mmc = new SqlDataAdapter("select count(*) from tbl_model", con);
            DataTable mm = new DataTable();
            mmc.Fill(mm);

            totaluser.Text = (Convert.ToInt32(pc.Rows[0][0]) + Convert.ToInt32(cc.Rows[0][0]) + Convert.ToInt32(mm.Rows[0][0])).ToString();




        }       
    }
}