using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAssignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["SessionData"] = new List<KeyValuePair<string, string>>();
                Application["ApplicationData"] = new List<KeyValuePair<string, string>>();



            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string key = TextBox1.Text;
            string value = TextBox2.Text;



            List<KeyValuePair<string, string>> sessiondata = (List<KeyValuePair<string, string>>)Session["SessionData"];
            sessiondata.Add(new KeyValuePair<string, string>(key, value));
            Label3.Text = "data added in Session";
            rptdisplay.DataSource = sessiondata;
            rptdisplay.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string key = TextBox1.Text;
            string value = TextBox2.Text;



            List<KeyValuePair<string, string>> applicationdata = (List<KeyValuePair<string, string>>)Application["ApplicationData"];
            applicationdata.Add(new KeyValuePair<string, string>(key, value));
            Label3.Text = "data added in Application";
            rptdisplay.DataSource = applicationdata;
            rptdisplay.DataBind();
        }
    }
}
