using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace loginweb
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string str = "Data Source=desktop-tb3r1mj;Initial Catalog=access;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(str);
            sqlconn.Open();
            string sql = @"select username,password from users where
                username='"+txtusername.Text+"' and password='"+txtpassword.Text+"'";
            SqlCommand sqlcmd = new SqlCommand(sql,sqlconn);
            SqlDataReader reader = sqlcmd.ExecuteReader();
            if(reader.Read()==true)
            {
                lblmessage.Text = "Login successful!";
                Session["username"] = txtusername.Text.ToUpper();
                Response.Redirect("mypage.aspx");
            }
            else
            {
                lblmessage.Text = "Wrong login credentials!";
                lblmessage.ForeColor = System.Drawing.Color.Indigo;
                txtusername.Text = "";
                txtpassword.Text = "";
            }
            sqlconn.Close();

        }
    }
}