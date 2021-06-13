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
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Redirect("Dashboard.aspx");
            }
            
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Redirect("Edit.aspx");
            }
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {

            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Redirect("Admin.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblAdded.Text = "";
            lblError.Text = "";
            SqlConnection schedConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Schedulle"].ConnectionString);

            //Monday
            if (listDay.SelectedItem.ToString() == "Monday")
            {
                schedConn.Open();
                string schedCheck = "SELECT COUNT(*) FROM [Monday] WHERE course ='" + tbCourse.Text + "'";
                SqlCommand query = new SqlCommand(schedCheck, schedConn);
                int total = Convert.ToInt32(query.ExecuteScalar().ToString());
                schedConn.Close();
                if (total != 0)
                {
                    lblError.Text = "Course has already added!";
                }
                else
                {
                    schedConn.Open();
                    string inputSched = "INSERT INTO [Monday] (time,course,lecturer,class,linkonlineclass) VALUES (@time,@course,@lecturer,@class,@linkonlineclass)";
                    SqlCommand inputQuery = new SqlCommand(inputSched, schedConn);
                    inputQuery.Parameters.AddWithValue("@time", tbTime.Text);
                    inputQuery.Parameters.AddWithValue("@course", tbCourse.Text);
                    inputQuery.Parameters.AddWithValue("@lecturer", tbLecturer.Text);
                    inputQuery.Parameters.AddWithValue("@class", tbClass.Text);
                    inputQuery.Parameters.AddWithValue("@linkonlineclass", tbLink.Text);
                    inputQuery.ExecuteNonQuery();
                    schedConn.Close();

                    //Session

                    lblAdded.Text = "Course succesfully registered!";
                   
                }

            }

            //TUESDAY
            else if (listDay.SelectedItem.ToString() == "Tuesday")
            {
                schedConn.Open();
                string schedCheck = "SELECT COUNT(*) FROM [Tuesday] WHERE course ='" + tbCourse.Text + "'";
                SqlCommand query = new SqlCommand(schedCheck, schedConn);
                int total = Convert.ToInt32(query.ExecuteScalar().ToString());
                schedConn.Close();
                if (total != 0)
                {
                    lblError.Text = "Course has already added!";
                }
                else
                {
                    schedConn.Open();
                    string inputSched = "INSERT INTO [Tuesday] (time,course,lecturer,class,linkonlineclass) VALUES (@time,@course,@lecturer,@class,@linkonlineclass)";
                    SqlCommand inputQuery = new SqlCommand(inputSched, schedConn);
                    inputQuery.Parameters.AddWithValue("@time", tbTime.Text);
                    inputQuery.Parameters.AddWithValue("@course", tbCourse.Text);
                    inputQuery.Parameters.AddWithValue("@lecturer", tbLecturer.Text);
                    inputQuery.Parameters.AddWithValue("@class", tbClass.Text);
                    inputQuery.Parameters.AddWithValue("@linkonlineclass", tbLink.Text);
                    inputQuery.ExecuteNonQuery();
                    schedConn.Close();

                    //Session


                    lblAdded.Text = "Course succesfully registered!";
                }

            }

            //WEDNESDAY
            else if (listDay.SelectedItem.ToString() == "Wednesday")
            {
                schedConn.Open();
                string schedCheck = "SELECT COUNT(*) FROM [Wednesday] WHERE course ='" + tbCourse.Text + "'";
                SqlCommand query = new SqlCommand(schedCheck, schedConn);
                int total = Convert.ToInt32(query.ExecuteScalar().ToString());
                schedConn.Close();
                if (total != 0)
                {
                    lblError.Text = "Course has already added!";
                }
                else
                {
                    schedConn.Open();
                    string inputSched = "INSERT INTO [Wednesday] (time,course,lecturer,class,linkonlineclass) VALUES (@time,@course,@lecturer,@class,@linkonlineclass)";
                    SqlCommand inputQuery = new SqlCommand(inputSched, schedConn);
                    inputQuery.Parameters.AddWithValue("@time", tbTime.Text);
                    inputQuery.Parameters.AddWithValue("@course", tbCourse.Text);
                    inputQuery.Parameters.AddWithValue("@lecturer", tbLecturer.Text);
                    inputQuery.Parameters.AddWithValue("@class", tbClass.Text);
                    inputQuery.Parameters.AddWithValue("@linkonlineclass", tbLink.Text);
                    inputQuery.ExecuteNonQuery();
                    schedConn.Close();

                    //Session


                    lblAdded.Text = "Course succesfully registered!";
                }

            }

            //THURSDAY
            else if (listDay.SelectedItem.ToString() == "Thursday")
            {
                schedConn.Open();
                string schedCheck = "SELECT COUNT(*) FROM [Thursday] WHERE course ='" + tbCourse.Text + "'";
                SqlCommand query = new SqlCommand(schedCheck, schedConn);
                int total = Convert.ToInt32(query.ExecuteScalar().ToString());
                schedConn.Close();
                if (total != 0)
                {
                    lblError.Text = "Course has already added!";
                }
                else
                {
                    schedConn.Open();
                    string inputSched = "INSERT INTO [Thursday] (time,course,lecturer,class,linkonlineclass) VALUES (@time,@course,@lecturer,@class,@linkonlineclass)";
                    SqlCommand inputQuery = new SqlCommand(inputSched, schedConn);
                    inputQuery.Parameters.AddWithValue("@time", tbTime.Text);
                    inputQuery.Parameters.AddWithValue("@course", tbCourse.Text);
                    inputQuery.Parameters.AddWithValue("@lecturer", tbLecturer.Text);
                    inputQuery.Parameters.AddWithValue("@class", tbClass.Text);
                    inputQuery.Parameters.AddWithValue("@linkonlineclass", tbLink.Text);
                    inputQuery.ExecuteNonQuery();
                    schedConn.Close();

                    //Session


                    lblAdded.Text = "Course succesfully registered!";
                }

            }

            //FRIDAY
            else if (listDay.SelectedItem.ToString() == "Friday")
            {
                schedConn.Open();
                string schedCheck = "SELECT COUNT(*) FROM [Friday] WHERE course ='" + tbCourse.Text + "'";
                SqlCommand query = new SqlCommand(schedCheck, schedConn);
                int total = Convert.ToInt32(query.ExecuteScalar().ToString());
                schedConn.Close();
                if (total != 0)
                {
                    lblError.Text = "Course has already added!";
                }
                else
                {
                    schedConn.Open();
                    string inputSched = "INSERT INTO [Friday] (time,course,lecturer,class,linkonlineclass) VALUES (@time,@course,@lecturer,@class,@linkonlineclass)";
                    SqlCommand inputQuery = new SqlCommand(inputSched, schedConn);
                    inputQuery.Parameters.AddWithValue("@time", tbTime.Text);
                    inputQuery.Parameters.AddWithValue("@course", tbCourse.Text);
                    inputQuery.Parameters.AddWithValue("@lecturer", tbLecturer.Text);
                    inputQuery.Parameters.AddWithValue("@class", tbClass.Text);
                    inputQuery.Parameters.AddWithValue("@linkonlineclass", tbLink.Text);
                    inputQuery.ExecuteNonQuery();
                    schedConn.Close();

                    //Session


                    lblAdded.Text = "Course succesfully registered!";
                }

            }

            //SATRUDAY
            else if (listDay.SelectedItem.ToString() == "Saturday")
            {
                schedConn.Open();
                string schedCheck = "SELECT COUNT(*) FROM [Saturday] WHERE course ='" + tbCourse.Text + "'";
                SqlCommand query = new SqlCommand(schedCheck, schedConn);
                int total = Convert.ToInt32(query.ExecuteScalar().ToString());
                schedConn.Close();
                if (total != 0)
                {
                    lblError.Text = "Course has already added!";
                }
                else
                {
                    schedConn.Open();
                    string inputSched = "INSERT INTO [Saturday] (time,course,lecturer,class,linkonlineclass) VALUES (@time,@course,@lecturer,@class,@linkonlineclass)";
                    SqlCommand inputQuery = new SqlCommand(inputSched, schedConn);
                    inputQuery.Parameters.AddWithValue("@time", tbTime.Text);
                    inputQuery.Parameters.AddWithValue("@course", tbCourse.Text);
                    inputQuery.Parameters.AddWithValue("@lecturer", tbLecturer.Text);
                    inputQuery.Parameters.AddWithValue("@class", tbClass.Text);
                    inputQuery.Parameters.AddWithValue("@linkonlineclass", tbLink.Text);
                    inputQuery.ExecuteNonQuery();
                    schedConn.Close();

                    //Session


                    lblAdded.Text = "Course succesfully registered!";
                }

            }





        }

        protected void tbLink_TextChanged(object sender, EventArgs e)
        {

        }

        protected void listDay_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void tbTime_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblAdded.Text = "";
            lblError.Text = "";
            SqlConnection schedConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Schedulle"].ConnectionString);

            //Monday
            if (listDay.SelectedItem.ToString() == "Monday")
            {
                schedConn.Open();
                SqlCommand cmd = new SqlCommand("update Monday set Time= '" + tbTime.Text + "', Course= '" + tbCourse.Text + "', Lecturer= '" + tbLecturer.Text + "', Class= '" + tbClass.Text + "', LinkOnlineClass= '" + tbLink.Text + "' ", schedConn);
                cmd.ExecuteNonQuery();
                schedConn.Close();

                //Session

                lblAdded.Text = "Course succesfully Updated!";
            }

            //Tuesday
            if (listDay.SelectedItem.ToString() == "Tuesday")
            {
                schedConn.Open();
                SqlCommand cmd = new SqlCommand("update Tuesday set Time= '" + tbTime.Text + "', Course= '" + tbCourse.Text + "', Lecturer= '" + tbLecturer.Text + "', Class= '" + tbClass.Text + "', LinkOnlineClass= '" + tbLink.Text + "' ", schedConn);
                cmd.ExecuteNonQuery();
                schedConn.Close();

                //Session

                lblAdded.Text = "Course succesfully Updated!";
            }

            //Wednesday
            if (listDay.SelectedItem.ToString() == "Wednesday")
            {
                schedConn.Open();
                SqlCommand cmd = new SqlCommand("update Wednesday set Time= '" + tbTime.Text + "', Course= '" + tbCourse.Text + "', Lecturer= '" + tbLecturer.Text + "', Class= '" + tbClass.Text + "', LinkOnlineClass= '" + tbLink.Text + "' ", schedConn);
                cmd.ExecuteNonQuery();
                schedConn.Close();

                //Session

                lblAdded.Text = "Course succesfully Updated!";
            }

            //Thursday
            if (listDay.SelectedItem.ToString() == "Thursday")
            {
                schedConn.Open();
                SqlCommand cmd = new SqlCommand("update Thursday set Time= '" + tbTime.Text + "', Course= '" + tbCourse.Text + "', Lecturer= '" + tbLecturer.Text + "', Class= '" + tbClass.Text + "', LinkOnlineClass= '" + tbLink.Text + "' ", schedConn);
                cmd.ExecuteNonQuery();
                schedConn.Close();

                //Session

                lblAdded.Text = "Course succesfully Updated!";
            }

            //Friday
            if (listDay.SelectedItem.ToString() == "Friday")
            {
                schedConn.Open();
                SqlCommand cmd = new SqlCommand("update Friday set Time= '" + tbTime.Text + "', Course= '" + tbCourse.Text + "', Lecturer= '" + tbLecturer.Text + "', Class= '" + tbClass.Text + "', LinkOnlineClass= '" + tbLink.Text + "' ", schedConn);
                cmd.ExecuteNonQuery();
                schedConn.Close();

                //Session

                lblAdded.Text = "Course succesfully Updated!";
            }

            //Monday
            if (listDay.SelectedItem.ToString() == "Saturday")
            {
                schedConn.Open();
                SqlCommand cmd = new SqlCommand("update Saturday set Time= '" + tbTime.Text + "', Course= '" + tbCourse.Text + "', Lecturer= '" + tbLecturer.Text + "', Class= '" + tbClass.Text + "', LinkOnlineClass= '" + tbLink.Text + "' ", schedConn);
                cmd.ExecuteNonQuery();
                schedConn.Close();

                //Session

                lblAdded.Text = "Course succesfully Updated!";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            lblAdded.Text = "";
            lblError.Text = "";
            SqlConnection schedConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Schedulle"].ConnectionString);

            //Monday
            if (listDay.SelectedItem.ToString() == "Monday")
            {
                schedConn.Open();
                SqlCommand cmd = new SqlCommand("Delete Monday where Course= '" + tbCourse.Text + "' ", schedConn);
                cmd.ExecuteNonQuery();
                schedConn.Close();

                //Session

                lblAdded.Text = "Course succesfully deleted!";
            }

            //Tuesday
            if (listDay.SelectedItem.ToString() == "Tuesday")
            {
                schedConn.Open();
                SqlCommand cmd = new SqlCommand("Delete Tuesday where Course= '" + tbCourse.Text + "' ", schedConn);
                cmd.ExecuteNonQuery();
                schedConn.Close();

                //Session

                lblAdded.Text = "Course succesfully deleted!";
            }

            //Wednesday
            if (listDay.SelectedItem.ToString() == "Wednesday")
            {
                schedConn.Open();
                SqlCommand cmd = new SqlCommand("Delete Wednesday where Course= '" + tbCourse.Text + "' ", schedConn);
                cmd.ExecuteNonQuery();
                schedConn.Close();

                //Session

                lblAdded.Text = "Course succesfully deleted!";
            }

            //Thursday
            if (listDay.SelectedItem.ToString() == "Thursday")
            {
                schedConn.Open();
                SqlCommand cmd = new SqlCommand("Delete Thursday where Course= '" + tbCourse.Text + "' ", schedConn);
                cmd.ExecuteNonQuery();
                schedConn.Close();

                //Session

                lblAdded.Text = "Course succesfully deleted!";
            }

            //Friday
            if (listDay.SelectedItem.ToString() == "Friday")
            {
                schedConn.Open();
                SqlCommand cmd = new SqlCommand("Delete Friday where Course= '" + tbCourse.Text + "' ", schedConn);
                cmd.ExecuteNonQuery();
                schedConn.Close();

                //Session

                lblAdded.Text = "Course succesfully deleted!";
            }

            //Saturday
            if (listDay.SelectedItem.ToString() == "Saturday")
            {
                schedConn.Open();
                SqlCommand cmd = new SqlCommand("Delete Saturday where Course= '" + tbCourse.Text + "' ", schedConn);
                cmd.ExecuteNonQuery();
                schedConn.Close();

                //Session

                lblAdded.Text = "Course succesfully deleted!";
            }
        }
    }
}