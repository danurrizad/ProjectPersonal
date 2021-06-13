using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SchedulLOG
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorMsg.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Desktop\NewProject\SchedulLOG\SchedulLOG\App_Data\dbLogin.mdf;Integrated Security=True");
            connection.Open();
            string query = "SELECT COUNT (1) FROM tbLogin WHERE email=@email AND password=@password";
            SqlCommand sqlCmd = new SqlCommand(query, connection);
            sqlCmd.Parameters.AddWithValue("@email", InputEmail.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@password", tbPass.Text.Trim());
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            if (count == 1)
            {
                Session["email"] = InputEmail.Text.Trim();
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                errorMsg.Visible = true;
            }
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("RegisterForm.aspx");
        }
    }
}