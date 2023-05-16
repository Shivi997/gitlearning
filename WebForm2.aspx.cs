using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAssignment
{
    public partial class WebForm2 : System.Web.UI.Page
    {
      

        protected void Page_Load(object sender, EventArgs e)
        {

           

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into dbbooks values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "',' " + TextBox4.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            
            Bookdetails.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            Label6.Text = "Data has been inserted";
            Label5.Text = "success";

        }

        protected void Bookdetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}