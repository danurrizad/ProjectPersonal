using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SchedulLOG
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["email"]== null)
            {
                Response.Redirect("Login.aspx");
            }
            lbEmailDetails.Text = "Welcome," + Session["email"];
        }

       
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edit.aspx");
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
        

        protected void btnMonday_Click(object sender, EventArgs e)
        {
            titleDay.Text = "Monday";
            DataTable dt = new DataTable();
            dt = Homepage.ShowDataMonday();
            RptShowData.DataSource = dt;
            RptShowData.DataBind();
        }

        protected void btnTuesday_Click(object sender, EventArgs e)
        {
            titleDay.Text = "Tuesday";
            DataTable dt = new DataTable();
            dt = Homepage.ShowDataTuesday();
            RptShowData.DataSource = dt;
            RptShowData.DataBind();
        }

        protected void btnWed_Click(object sender, EventArgs e)
        {
            titleDay.Text = "Wednesday";
            DataTable dt = new DataTable();
            dt = Homepage.ShowDataWednesday();
            RptShowData.DataSource = dt;
            RptShowData.DataBind();
        }

        protected void btnThurs_Click(object sender, EventArgs e)
        {
            titleDay.Text = "Thursday";
            DataTable dt = new DataTable();
            dt = Homepage.ShowDataThursday();
            RptShowData.DataSource = dt;
            RptShowData.DataBind();
        }

        protected void btnFriday_Click(object sender, EventArgs e)
        {
            titleDay.Text = "Friday";
            DataTable dt = new DataTable();
            dt = Homepage.ShowDataFriday();
            RptShowData.DataSource = dt;
            RptShowData.DataBind();
        }

        protected void btnSatur_Click(object sender, EventArgs e)
        {
            titleDay.Text = "Saturday";
            DataTable dt = new DataTable();
            dt = Homepage.ShowDataSaturday();
            RptShowData.DataSource = dt;
            RptShowData.DataBind();
        }
    }
}