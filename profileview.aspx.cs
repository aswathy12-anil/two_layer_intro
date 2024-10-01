using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace two_layer_intro
{
    public partial class profileview : System.Web.UI.Page
    {
        connectionclass obj = new connectionclass();

        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select Name,Age,Address,Photo from two_layer where Id=" + Session["uid"] + "";
            SqlDataReader dr = obj.Fun_exeReader(sel);
            while (dr.Read())
            {
                Label2.Text = dr["Name"].ToString();
                Label4.Text = dr["Age"].ToString();
                Label7.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }
            DataSet ds = obj.Fun_exeDataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataTable dt = obj.Fun_exeDatatable(sel);
            DataList1.DataSource = dt;
            DataList1.DataBind();

        }
    }
}