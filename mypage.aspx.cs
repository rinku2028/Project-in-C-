using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace loginweb
{
    public partial class mypage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome" + "\t" + Session["username"]);

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            string str = "Data Source=desktop-tb3r1mj;Initial Catalog=access;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(str);
            sqlconn.Open();
            string sql1 = "select username from users where username='" + txtusername.Text + "'";
            SqlCommand sqlcmd1 = new SqlCommand(sql1, sqlconn);
            SqlDataReader reader = sqlcmd1.ExecuteReader();
            if (reader.Read() != true)
            {
                sqlconn.Close();
                sqlconn.Open();
                string sql = @"insert into users(username,password) values 
               ('" + txtusername.Text + "','" + txtpassword.Text + "')";
                SqlCommand sqlcmd = new SqlCommand(sql, sqlconn);
                sqlcmd.ExecuteNonQuery();
                lblmessage.Text = "User added successfully!";
            }
            else
            {
                lblmessage.Text = "User" + "\t" + txtusername.Text + "\t" + "already exists!";
                lblmessage.ForeColor = System.Drawing.Color.Red;
                txtusername.Text = "";
                txtpassword.Text = "";

            }
        }

        protected void btnchangepasswd_Click(object sender, EventArgs e)
        {
            string str = "Data Source=desktop-tb3r1mj;Initial Catalog=access;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(str);
            sqlconn.Open();
            string sql1 = "select username from users where username='" + txtusername.Text + "'";
            SqlCommand sqlcmd1 = new SqlCommand(sql1, sqlconn);
            SqlDataReader reader = sqlcmd1.ExecuteReader();
            if (reader.Read() == true)
            {
                sqlconn.Close();
                sqlconn.Open();
                string sql = @"update users set password='" + txtpassword.Text + "' where  username='" + txtusername.Text + "'";
                SqlCommand sqlcmd = new SqlCommand(sql, sqlconn);
                sqlcmd.ExecuteNonQuery();
                lblmessage.Text = "Password of" + "\t" + txtusername.Text + "\t" + "changed is" +"\t"+ "<b>" + txtpassword.Text + "</b>";

            }
            else
            {
                lblmessage.Text = "Username" + "\t" + txtusername.Text + "does not exists!";
                lblmessage.ForeColor = System.Drawing.Color.Red;
            }
            sqlconn.Close();
        }
    }
}

