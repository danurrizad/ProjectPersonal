using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace SchedulLOG
{
    public partial class RegisterForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("Login.aspx");
        }

        protected void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            SqlConnection userConn = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString);
            userConn.Open();
            string userCheck = "SELECT COUNT(*) FROM [tbLogin] WHERE email ='"+tbEmail.Text+"'";
            SqlCommand query = new SqlCommand(userCheck, userConn);
            int total = Convert.ToInt32(query.ExecuteScalar().ToString());
            userConn.Close();
            if (total != 0)
            {
                Response.Write("Email has already used!");
            }
            else
            {
                userConn.Open();
                string inputUser = "INSERT INTO [tbLogin] (email,password,fullname,NIM) VALUES (@email,@password,@fullname,@NIM)";
                SqlCommand inputQuery = new SqlCommand(inputUser, userConn);
                inputQuery.Parameters.AddWithValue("@email", tbEmail.Text);
                inputQuery.Parameters.AddWithValue("@password", tbPass.Text);
                inputQuery.Parameters.AddWithValue("@fullname", tbName.Text);
                inputQuery.Parameters.AddWithValue("@NIM", tbNIM.Text);
                inputQuery.ExecuteNonQuery();
                userConn.Close();

                //Session
                
                Response.Redirect("Login.aspx");
                Response.Write("Account succesfully registered!");

            }
        }
    }
}