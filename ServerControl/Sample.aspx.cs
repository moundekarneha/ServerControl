using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerControl
{ 
    public partial class Sample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text; //server controll can directly access and with all its attributes
            Response.Write(str);
            Response.Write("<br/>");
            string str1 = Request.Form["textBox2"]; //html control can not directly access and only value of its
            Response.Write(str1);
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            string str = Request.Form["textBox2"]; //html control can not directly access and only value of its
            Response.Write(str);
        }
    }
}