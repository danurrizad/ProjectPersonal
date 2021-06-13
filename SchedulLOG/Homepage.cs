using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SchedulLOG
{
    public class Homepage
    {
        public static DataTable ShowDataMonday()
        {
            try
            {
                DataTable dtShown = new DataTable();
                SqlConnection conn = new SqlConnection(DataConn.Conn.ToString());
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Monday";
                da.SelectCommand = cmd;
                da.Fill(dtShown);
                conn.Close();
                return dtShown;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ShowDataTuesday()
        {
            try
            {
                DataTable dtShown = new DataTable();
                SqlConnection conn = new SqlConnection(DataConn.Conn.ToString());
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Tuesday";
                da.SelectCommand = cmd;
                da.Fill(dtShown);
                conn.Close();
                return dtShown;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ShowDataWednesday()
        {
            try
            {
                DataTable dtShown = new DataTable();
                SqlConnection conn = new SqlConnection(DataConn.Conn.ToString());
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Wednesday";
                da.SelectCommand = cmd;
                da.Fill(dtShown);
                conn.Close();
                return dtShown;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ShowDataThursday()
        {
            try
            {
                DataTable dtShown = new DataTable();
                SqlConnection conn = new SqlConnection(DataConn.Conn.ToString());
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Thursday";
                da.SelectCommand = cmd;
                da.Fill(dtShown);
                conn.Close();
                return dtShown;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ShowDataFriday()
        {
            try
            {
                DataTable dtShown = new DataTable();
                SqlConnection conn = new SqlConnection(DataConn.Conn.ToString());
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Friday";
                da.SelectCommand = cmd;
                da.Fill(dtShown);
                conn.Close();
                return dtShown;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ShowDataSaturday()
        {
            try
            {
                DataTable dtShown = new DataTable();
                SqlConnection conn = new SqlConnection(DataConn.Conn.ToString());
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Saturday";
                da.SelectCommand = cmd;
                da.Fill(dtShown);
                conn.Close();
                return dtShown;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}