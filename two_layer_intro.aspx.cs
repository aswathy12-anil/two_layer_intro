using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace two_layer_intro
{
    public partial class two_layer_intro : System.Web.UI.Page
    {
        connectionclass obj = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/NewFolder1/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));
            string strinsert = "insert into two_layer values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + path + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = obj.Fun_exenonquery(strinsert);
            if (i == 1)
            {
                Label7.Text = "Inserted";
            }

        }
    }
}